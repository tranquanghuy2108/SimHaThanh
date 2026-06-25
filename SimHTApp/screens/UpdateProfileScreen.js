import React, { useContext, useEffect, useState } from "react";
import {
  StyleSheet,
  Dimensions,
  StatusBar,
  KeyboardAvoidingView,
  Image,
  TouchableOpacity,
  View,
  Animated,
} from "react-native";
import { Block, Text} from "galio-framework";

import { Icon, Input } from "../components";
import { argonTheme } from "../constants";
import { AuthContext } from "../context/AuthContext";
import { AppConst } from "../constants/AppConst";
import Ionicons from 'react-native-vector-icons/Ionicons';
const { width, height } = Dimensions.get("screen");
import * as ImagePicker from 'expo-image-picker';
import * as FileSystem from 'expo-file-system';
import SendBird from "sendbird";

import {
  responsiveHeight,
  responsiveWidth,
  responsiveFontSize
} from "react-native-responsive-dimensions";
import { SendBirdContext } from "../context/SendbirdContext";



export default function UpdateProfileScreen({ navigation }) {
  const { updateUserInfo, userInfos } = useContext(AuthContext);
  const [fullName, setFullName] = useState(userInfos.fullName);
  const [phoneNumber, setPhoneNumber] = useState(userInfos.username);
  const [email, setEmail] = useState(userInfos.email);
  const [website, setWebsite] = useState(userInfos.website);
  const [address, setAddress] = useState(userInfos.address);
  const [description, setDescription] = useState(userInfos.remark);
  const [validateText, setValidateText] = useState(null);
  const [validateEmail, SetValidateEmail] = useState(true);
  const {UpdateProfileSendBird} = useContext(SendBirdContext);
  //
  const ShowAvatar = () => {
    setImgBase64(userInfos.avatar);
  }


  //Animate
  const [isExpanded, setIsExpanded] = useState(false);
  const [animation] = useState(new Animated.Value(0));

  const handlePress = () => {
    if (isExpanded) {
      hideAnimation();
    } else {
      showAnimation();

    }
  };

  const showAnimation = () => {
    setIsExpanded(true);
    Animated.timing(animation, {
      toValue: 1,
      duration: 200,
      useNativeDriver: true,
    }).start();
  };

  const hideAnimation = () => {
    Animated.timing(animation, {
      toValue: 0,
      duration: 200,
      useNativeDriver: true,
    }).start(() => {
      setIsExpanded(false);
    });
  };

  const interpolatedAnimation = animation.interpolate({
    inputRange: [0, 1],
    outputRange: [height, 0],
    extrapolate: 'clamp',
  });

  //Pick Image
  const [imgBase64, setImgBase64] = useState([]);

  useEffect(() => {
    ShowAvatar();
  }, []);

  const handleChooseImages = async () => {
    const permissionResult = await ImagePicker.requestMediaLibraryPermissionsAsync();
    if (permissionResult.granted === false) {
      alert('Permission to access camera roll is required!');
      return;
    }

    const pickerResult = await ImagePicker.launchImageLibraryAsync({
      mediaTypes: ImagePicker.MediaTypeOptions.Images,
      allowsMultipleSelection: false,
      allowsEditing: false,
    });

    if (!pickerResult.canceled) {
      const base64 = await FileSystem.readAsStringAsync(pickerResult.assets[0].uri, { encoding: 'base64' });
      setImgBase64(base64);
    }


  };
  //
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

    const base64 = await FileSystem.readAsStringAsync(pickerResult.assets[0].uri, { encoding: 'base64' });
    setImgBase64(base64);

  };
  const ValidateEmail = () => {
    const emailRegex = /^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$/i;

    if (emailRegex.test(email) || email == userInfos.email) {
      SetValidateEmail(true);
      return true;
    } else {
      SetValidateEmail(false);
      return false;
    }
  };

  //HEADER
  const handleExit = () => {
    navigation.goBack();

  }

  const SearchButton = () => {
    return (
      <View className="flex-1">
        <Text style={{ textAlign: "center", fontSize: responsiveFontSize(2.5), color: "white", fontWeight: "bold" }}>Sửa Thông Tin</Text>
      </View>
    );
  }
  const ExitButton = () => {
    return (
      // Nút Thoát
      <TouchableOpacity className="p-1 rounded-full mx-1"
        onPress={() => {

          handleExit();
        }}>
        <Ionicons name="chevron-back-outline"color="white" size={responsiveFontSize(3)}></Ionicons>
        
      </TouchableOpacity>
    );
  }
  const SaveButton = () => {
    return (
      // Nút Thoát
      <TouchableOpacity className="py-1 px-2 rounded-full bg-white mx-1"
        onPress={async () => {
          if (ValidateEmail()) {  
            UpdateProfileSendBird(fullName);
            var result = await updateUserInfo(fullName, email, website, address, imgBase64, description);
            if(result){
              navigation.navigate(AppConst.ScreenConst.PROFILE_SCREEN);
            }
          }
        }}
      >
           <Text
            style={{fontSize:responsiveFontSize(1.8),fontWeight:"bold"}}
         >
            Lưu
         </Text>
        {/* <Ionicons name="save-outline" color="black" size={responsiveFontSize(2.5)}></Ionicons> */}
      </TouchableOpacity>
    );
  }

  const HomeHeader = () => {
    return (
      <View className="flex-row justify-center items-center p-2 " style={{ zIndex: 1000, marginTop: StatusBar.currentHeight }} backgroundColor={argonTheme.COLORS.ERROR}>
        <ExitButton />
        <SearchButton />
        <SaveButton />
      </View>
    );
  }


  return (
    <View style={{ flex: 1 }}>
      <StatusBar translucent backgroundColor={argonTheme.COLORS.ERROR} />
      <HomeHeader />
      <View style={styles.header}>
        {/* Avatar */}

        <View style={styles.avatarContainer}>
          <TouchableOpacity
            onPress={() => {
              handlePress()
            }}
          >

            <Image
              source={{ uri: `data:image/jpeg;base64,${imgBase64}` }}
              style={styles.avatar}
            />
            <Ionicons style={{ position: 'absolute', right: 15, bottom: 10, color: "black" }} name="camera" size={20}></Ionicons>
          </TouchableOpacity>

        </View>

      </View>
      <View style={{flex:1,margin:15}}>
        <KeyboardAvoidingView
          style={{}}
          behavior="padding"
          enabled
        >
          <Block style={{ }}>
            <Input
              editable={false}
              style={{ backgroundColor: '#d4d3d2' }}
              borderless
              placeholder="Số điện thoại"
              value={phoneNumber}
              onChangeText={text => setPhoneNumber(text)}
              iconContent={
                <Icon
                  size={16}
                  color={argonTheme.COLORS.ICON}
                  name="mobile1"
                  family="AntDesign"
                  style={styles.inputIcons}
                />
              }
            />
          </Block>
          <Block style={{ }}>
            <Input
              borderless
              placeholder="Họ tên"
              value={fullName}
              onChangeText={text => setFullName(text)}
              iconContent={
                <Icon
                  size={16}
                  color={argonTheme.COLORS.ICON}
                  name="user"
                  family="Entypo"
                  style={styles.inputIcons}
                />
              }
            />
          </Block>
          <Block style={{  }}>
            <Input
              borderless
              placeholder="Email"
              value={email}
              onChangeText={text => setEmail(text)}
              iconContent={
                <Icon
                  size={16}
                  color={argonTheme.COLORS.ICON}
                  name="mail"
                  family="AntDesign"
                  style={styles.inputIcons}
                />
              }
            />
          </Block>

          {/* <Block style={{ marginBottom: 10 }}>
            <Input
              borderless
              placeholder="Website"
              value={website}
              onChangeText={text => setWebsite(text)}
              iconContent={
                <Icon
                  size={16}
                  color={argonTheme.COLORS.ICON}
                  name="earth"
                  family="AntDesign"
                  style={styles.inputIcons}
                />
              }
            />
          </Block> */}

          <Block style={{  }}>
            <Input
              borderless
              placeholder="Địa chỉ"
              value={address}
              onChangeText={text => setAddress(text)}
              iconContent={
                <Icon
                  size={16}
                  color={argonTheme.COLORS.ICON}
                  name="pin"
                  family="Entypo"
                  style={styles.inputIcons}
                />
              }
            />
          </Block>

          <Block style={{ }}>
            <Input
              borderless
              placeholder="Giới thiệu"
              value={description}
              onChangeText={text => setDescription(text)}
              iconContent={
                <Icon
                  size={16}
                  color={argonTheme.COLORS.ICON}
                  name="typing"
                  family="Entypo"
                  style={styles.inputIcons}
                />
              }
            />
          </Block>
          {
            !validateEmail && (
              <Block row>
                <Text color="red">Vui lòng kiểm tra lại thông tin</Text>
              </Block>
            )
          }
        </KeyboardAvoidingView>
      </View>
      {isExpanded && (
        <TouchableOpacity
          style={{ position: 'absolute', left: 0, right: 0, bottom: 0, height: '100%' }}
          onPress={hideAnimation}
          activeOpacity={1}
        >
          <Animated.View
            style={{
              position: 'absolute',
              left: 0,
              right: 0,
              bottom: 0,
              borderTopColor: 'grey',
              borderTopWidth: 1,
              transform: [{ translateY: interpolatedAnimation }],
              backgroundColor: 'white',
              justifyContent: 'center',
              alignItems: 'center',
            }}
          >


            <View style={{ height: "100%", width: "100%" }}>
              <View className="items-start mx-5">
                <TouchableOpacity onPress={handleChooseImages} className="flex-row justify-center items-center mt-3" style={{ width: '100%' }} activeOpacity={0.8}>
                  <Ionicons name="image-outline" color="green" size={25}></Ionicons>
                  <Text className="font-bold mx-2">Chọn Ảnh</Text>
                </TouchableOpacity>
                <TouchableOpacity onPress={handleTakePhoto} className="flex-row justify-center items-center mt-3" style={{ width: '100%', left: -7 }} activeOpacity={0.8}>
                  <Ionicons name="camera-outline" color="green" size={25}></Ionicons>
                  <Text className="font-bold mx-2">Camera</Text>
                </TouchableOpacity>
              </View>
            </View>



          </Animated.View>
        </TouchableOpacity>
      )}
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    width: width * 0.9,
    height: height * 0.875,
    backgroundColor: "#F4F5F7",
    borderRadius: 4,
    shadowColor: argonTheme.COLORS.BLACK,
    shadowOffset: {
      width: 0,
      height: 4
    },
    shadowRadius: 8,
    shadowOpacity: 0.1,
    elevation: 1,
    overflow: "hidden"
  },
  socialConnect: {
    marginTop: 30,
    borderBottomWidth: StyleSheet.hairlineWidth,
    borderColor: "#8898AA"
  },
  inputIcons: {
    marginRight: 12
  },
  passwordCheck: {
    paddingTop: 13,
    paddingBottom: 30
  },
  createButton: {
    flex: 1,
    marginTop: 25,
    flexDirection: 'row',
    justifyContent: 'center',
    alignItems: 'center'
  },
  navText: {
    flex: 1,
    paddingTop: 20,
    textAlign: "right",
  },
  header: {
    marginTop: 50,
    justifyContent: 'center',
    alignItems: 'center'
  },
  avatarContainer: {
    position: "relative",

    width: 100,
    height: 100,

  },
  avatar: {
    width: 100,
    height: 100,
    borderWidth: 0,
    borderRadius: 62,
    backgroundColor: 'gray',
  },
  nameInfo: {
    marginTop: 5
  },
  divider: {
    width: "90%",
    borderWidth: 1,
    borderColor: "#E9ECEF"
  },
});

// const validateInput = (fullName, email, website, address, description)=>{
//   setValidateText(null);
//   const phoneNumRegex = new RegExp("(03|05|07|08|09)+([0-9]{8})");
//   const passwordRegex = new RegExp("(?=.{7,13}$)");
//   if(fullName != null && email != null && website != null && address != null && description != null)
//   {
//       // const isSucess = register(phoneNumber, fullName, password, rePassword);
//       // if(isSucess)
//       // {
//       //   navigation.navigate(AppConst.ScreenConst.LOGIN_SCREEN);
//       // }
//   }
//   else
//     setValidateText('Bạn chưa nhập đủ thông tin!');
// }
