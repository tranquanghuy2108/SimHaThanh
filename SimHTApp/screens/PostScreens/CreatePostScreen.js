
import React, { useEffect, useState, useContext } from "react";
import { View, TextInput, TouchableOpacity, Text, StyleSheet, Image, FlatList, SafeAreaView, } from 'react-native';
import { PostContext } from "../../context/PostContext";
import { AuthContext } from "../../context/AuthContext";
import Ionicons from 'react-native-vector-icons/Ionicons';
import * as ImagePicker from 'expo-image-picker';
import * as FileSystem from 'expo-file-system/legacy';
import { validateUserGeneratedText } from "../../utils/contentModeration";
const numColumns = 2; // Số cột trong lưới


const CreatePostScreen = ({ route }) => {
    const [selectedImages, setSelectedImages] = useState([]);
    const [imgBase64s, setImgBase64s] = useState([]);
    const { CreatePost, isHitPost, ReloadPost, SetHitPost } = useContext(PostContext);
    const { userInfos } = useContext(AuthContext);

    const [postContent, SetPostContent] = useState('');
    const [isSubmitting, setSubmitting] = useState(false);

    const handleInputChange = (text) => {
        SetPostContent(text)
    };
    useEffect(() => {
        if (!isHitPost || isSubmitting) return;

        const submitPost = async () => {
            setSubmitting(true);
            const contentValidation = validateUserGeneratedText(postContent, {
                required: true,
            });
            if (!contentValidation.isAllowed) {
                alert(contentValidation.message);
                ReloadPost(false);
                SetHitPost(false);
                setSubmitting(false);
                return;
            }

            const postData = {
                content: postContent,
                imgs: imgBase64s
            };

            const isCreated = await CreatePost(postData);
            SetHitPost(false);

            if (isCreated) {
                SetPostContent('');
                setSelectedImages([]);
                setImgBase64s([]);
                ReloadPost(true);
            } else {
                ReloadPost(false);
            }
            setSubmitting(false);
        };

        submitPost();
    }, [
        CreatePost,
        ReloadPost,
        SetHitPost,
        imgBase64s,
        isHitPost,
        isSubmitting,
        postContent,
    ]);


    const handleChooseImages = async () => {
        const pickerResult = await ImagePicker.launchImageLibraryAsync({
            // Dùng trình chọn ảnh hệ thống (PHPicker/Android Photo Picker),
            // không yêu cầu quyền truy cập toàn bộ thư viện ảnh.
            mediaTypes: ['images'],
            allowsMultipleSelection: true,
            allowsEditing: false,
        });

        if (!pickerResult.canceled) {
            const selectedUris = pickerResult.assets.map((item) => item.uri);
            setSelectedImages(selectedUris);

            const img64Tmps = await Promise.all(
              pickerResult.assets.map(async (item) => {
                const img64 = await FileSystem.readAsStringAsync(item.uri, { encoding: 'base64' });
                return {
                    imageUrl: img64,
                    description: "none"
                };
              })
            );
            setImgBase64s(img64Tmps);

        }
    };


    const handleTakePhoto = async () => {
        const permissionResult = await ImagePicker.requestCameraPermissionsAsync();
        if (permissionResult.granted === false) {
            alert('Permission to access the camera is required!');
            return;
        }

        const pickerResult = await ImagePicker.launchCameraAsync();
        if (pickerResult.canceled === true) {
            return;
        }


        var imageArray = [];
        imageArray.push(pickerResult.assets[0].uri)
        setSelectedImages(imageArray);
        console.log(JSON.stringify(imageArray))
        //Convert base64
        var img64Tmps = [];
        const base64 = await FileSystem.readAsStringAsync(pickerResult.assets[0].uri, { encoding: 'base64' });
        var img = {
            imageUrl: base64,
            description: "none"
        }
        img64Tmps.push(img);
        setImgBase64s(img64Tmps);

    };


    return (
        <SafeAreaView >
            <View >
                <View className="flex-row p-2 items-center mx-3">
                    {/* Left */}
                    <View>
                        <Image style={{
                            height: 60, width: 60, resizeMode: 'contain', borderRadius: 30, backgroundColor: 'gray'
                           
                        }} source={{ uri: `data:image/jpeg;base64,${userInfos.avatar}` }} />
                    </View>

                    {/* Right */}
                    <View className="mx-1" >
                        <Text className="font-bold">{userInfos.fullName}</Text>
                    </View>
                </View>
            </View>

            <View className="items-center">
                <View className=" bg-white" style={{ height: 250, width: '90%'}}>
                    <TextInput
                        style={styles.textInput}
                        placeholder='Viết bài...'
                        placeholderTextColor={'gray'}

                        className="flex-1 text-base pl-2 tracking-wider"
                        editable={true}
                        value={postContent}
                        onChangeText={handleInputChange}
                        multiline
                    />
                </View>
            </View>

            <View className="items-center">
                <View className=" bg-white" style={{ height: 250, width: '90%' }}>
                    {/* Hiển thị danh sách hình ảnh đã chọn */}
                    <FlatList
                        data={imgBase64s}

                        keyExtractor={(_, index) => String(index)}
                        numColumns={numColumns}
                        renderItem={({ item }) =>
                            // <Image source={{ uri: item }} style={styles.image} />
                            <Image source={{ uri: `data:image/jpeg;base64,${item.imageUrl}` }} style={styles.image} />

                        }
                    />
                </View>
            </View>


            {/* Chọn ảnh */}
            <View className="items-start mx-5 mt-3">
                <TouchableOpacity onPress={handleChooseImages} className="flex-row justify-center items-center">
                    <Ionicons name="image-outline" color="green" size={25}></Ionicons>
                    <Text className="font-bold mx-2">Chọn Ảnh</Text>
                </TouchableOpacity>
                <TouchableOpacity onPress={handleTakePhoto} className="flex-row justify-center items-center">
                    <Ionicons name="camera-outline" color="green" size={25}></Ionicons>
                    <Text className="font-bold mx-2">Camera</Text>
                </TouchableOpacity>
            </View>

        </SafeAreaView>
    )
};
export default CreatePostScreen;

const styles = StyleSheet.create({

    textInput: {
        flex: 1,
        padding: 10,
        textAlignVertical: 'top',
    },
    container: {
        flex: 1,
        padding: 10,
        heigh: 700
    },
    image: {
        width: 150,
        height: 150,
        margin: 5,
    },
});
