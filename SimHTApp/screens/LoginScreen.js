import React, { useContext, useState } from "react";
import {
  StyleSheet,
  Dimensions,
  StatusBar,
  KeyboardAvoidingView,
  TouchableOpacity,
  Image,
  View
} from "react-native";
import { Block, Text } from "galio-framework";

import { Input } from "../components";
import { argonTheme } from "../constants";
import { AuthContext } from "../context/AuthContext";
import { AppConst } from "../constants/AppConst";

const { width, height } = Dimensions.get("screen");

export default LoginScreen = ({ navigation }) => {
  const [phoneNumber, setPhoneNumber] = useState(null);
  const [password, setPassword] = useState(null);
  const [validateText, setValidateText] = useState(null);

  const { login,SetRegister } = useContext(AuthContext);
  return (
    <View className=" flex-1 justify-center items-center mb-14">
      <StatusBar translucent backgroundColor={argonTheme.COLORS.ERROR} />
      <View className="items-center">
        <Image source={require("../assets/imgs/icon_about.png")} style={{ height: 150, width: 141 }} resizeMode="stretch"></Image>
        <Text color="#8898AA" size={30}>
          ĐĂNG NHẬP
        </Text>
        <KeyboardAvoidingView
      
          behavior="padding"
          enabled
        >
          <Block style={{ marginBottom: 5 }}>
            <Input
              borderless
              placeholder="Số điện thoại"
              value={phoneNumber}
              onChangeText={text => setPhoneNumber(text)}
              iconContent={
                <Image source={require("../assets/imgs/icon_mobile.png")} style={{ height: 20, width: 20, marginRight: 10 }} resizeMode="contain" />
              }
            />
          </Block>
          <Block >
            <Input
              password
              borderless
              placeholder="Mật khẩu"
              value={password}
              onChangeText={text => setPassword(text)}
              iconContent={
                <Image source={require("../assets/imgs/icon_lock.png")} style={{ height: 20, width: 20, marginRight: 10 }} resizeMode="contain" />
              }
            />
          </Block>

          <Block row style={styles.passwordCheck}>
            <Text size={12} color={argonTheme.COLORS.ERROR} value={validateText}>
            </Text>
          </Block>

          <TouchableOpacity
            className="bg-black justify-center items-center rounded"
            style={{ height: 40, backgroundColor: argonTheme.COLORS.ERROR }}
            onPress={() => {
              login(phoneNumber, password, true);
            }}

          >
            <Text className="color-white font-bold">
              ĐĂNG NHẬP
            </Text>
          </TouchableOpacity>

          {/* <Block row width={width * 0.8} style={{ justifyContent: 'space-between' }}>
            <Text style={[{ color: '#0a6eb4' }, { alignSelf: 'flex-end' }, styles.navText, { textDecorationLine: 'underline' }]}
              onPress={() => navigation.navigate(AppConst.ScreenConst.REGISTER_SCEEN)}>
              QUÊN MẬT KHẨU ?
            </Text>

          </Block> */}


          <Block row width={width * 0.8} style={{ justifyContent: 'space-between' }}>
            <Text style={styles.navText} >
              Bạn chưa có tài khoản?
            </Text>
            <Text style={[{ color: '#0a6eb4' }, { paddingLeft: 3 }, { alignSelf: 'flex-end' }]}
              onPress={() =>{
                SetRegister(false);
                navigation.navigate(AppConst.ScreenConst.REGISTER_SCEEN)
              }}
              
              >
              ĐĂNG KÍ NGAY
            </Text>
          </Block>

        </KeyboardAvoidingView>


      </View>
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
    borderColor: "#8898AA"
  },
  inputIcons: {
    marginRight: 12
  },
  passwordCheck: {
    paddingTop: 5,
    paddingBottom: 5
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
  }
});

