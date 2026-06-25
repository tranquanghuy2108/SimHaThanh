import React, { useEffect, useContext } from "react";
import { createStackNavigator } from '@react-navigation/stack';
import { Home, ImagePreview, PostDetails } from '../screens/PostScreens';
import { Text, TouchableOpacity } from 'react-native';
import Ionicons from 'react-native-vector-icons/Ionicons';
import { useNavigation } from "@react-navigation/native";
import { PostContext } from '../context/PostContext';
import CreatePostScreen from "../screens/PostScreens/CreatePostScreen";
import { argonTheme } from "../constants";
import { responsiveFontSize } from "react-native-responsive-dimensions";

const Stack = createStackNavigator();

export default function PostStack() {
    const { SetHitPost } = useContext(PostContext);
    const navigation = useNavigation()
    useEffect(() => {
        const unsubscribe = navigation.addListener('focus', () => {


        });

        return unsubscribe;
    }, [navigation]);
    const PostButton = () => {
        return (
            <TouchableOpacity onPress={onPressPost} className="flex-row justify-center items-center">
                <Ionicons name="create-outline" color="white" size={30}></Ionicons>
                <Text className="font-bold mx-1" style={{ color: 'white' }}>Đăng Bài</Text>
            </TouchableOpacity>
        );
    };

    const CreatePostButton = () => {
        return (
            <TouchableOpacity onPress={onPressCreatePost} className="flex-row justify-center items-center">
                <Ionicons name="navigate-outline" color="green" size={25}></Ionicons>
                <Text className="font-bold mx-2">Đăng</Text>
            </TouchableOpacity>
        );
    };

    const onPressPost = () => {
        navigation.navigate('CreatePostScreen'); //Enter Post Page
    }
    const onPressCreatePost = () => {
        SetHitPost(true);

        navigation.navigate('FacebookFeedHome')

    }
    return (
            <Stack.Navigator>
                <Stack.Screen
                    options={{
                        title: '                     Chợ SIM',
                        headerRight: () => {
                            return <PostButton />;
                        },
                        headerStyle: {
                            backgroundColor: argonTheme.COLORS.ERROR,
                        },
                        headerTintColor: 'white',
                        headerTitleStyle: {
                            fontSize: responsiveFontSize(2.5),
                            fontWeight: 'bold', // Độ đậm của font chữ
                        },
                    }}

                    name="FacebookFeedHome"
                    component={Home}

                />
                <Stack.Screen
                    name="FacebookFeedPostDetails"
                    // options={({ route }) => ({ title: `${route.params.post.creator.name}'s Post` })}
                    component={PostDetails} />
                <Stack.Screen
                    options={{ title: '' }}
                    name="FacebookFeedImagePreview"
                    component={ImagePreview} />

                <Stack.Screen
                    options={({ route }) => ({
                        title: "Đăng bài", headerRight: () => {
                            return <CreatePostButton />;
                        }
                    })}
                    name="CreatePostScreen"
                    component={CreatePostScreen} />
            </Stack.Navigator>
    );
}