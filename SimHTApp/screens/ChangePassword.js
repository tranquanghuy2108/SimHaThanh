import React, { useContext, useState } from "react";
import {
  StyleSheet,
  Dimensions,
  StatusBar,
  KeyboardAvoidingView,
  View,
  TouchableOpacity,
  Text

} from "react-native";
import Ionicons from 'react-native-vector-icons/Ionicons';
import { Block} from "galio-framework";

import { Button, Icon, Input } from "../components";
import { argonTheme } from "../constants";
import { AuthContext } from "../context/AuthContext";
import { responsiveFontSize } from "react-native-responsive-dimensions";

const { width, height } = Dimensions.get("screen");

export default function ChangePassword(props) {
  const [password, setPassword] = useState(null);
  const [newPassword, setNewPassword] = useState(null);
  const [reNewPassword, setReNewPassword] = useState(null);

  const [validateText, setValidateText] = useState(null);

  const { changePassword,logout } = useContext(AuthContext);

  const validateInput = async (password, newPassword, reNewPassword) => {
    setValidateText(null);
    const passwordRegex = new RegExp("(?=.{7,13}$)");
    if (password != null && newPassword != null && reNewPassword != null) {
      if (passwordRegex.test(password) == false) {
        setValidateText('Mật khẩu có độ dài từ 8-14 kí tự.');
      }
      else if (passwordRegex.test(newPassword) == false) {
        setValidateText('Mật khẩu có độ dài từ 8-14 kí tự.');
      }
      else if (newPassword != reNewPassword) {
        setValidateText('Xác nhận lại mật khẩu không đúng.');
      }
      else {

        var result = await changePassword(password, newPassword, reNewPassword);
        if(result){
          ResetInput();
          props.navigation.goBack();
          setTimeout(() => {
            logout();
          }, 300);
        }
      }
    }
    else
      setValidateText('Bạn chưa nhập đủ thông tin!');
  }


  const ExitButton = () => {
    return (
      // Nút Thoát
      <TouchableOpacity className="p-1 rounded-full bg-white mx-1 "
        onPress={() => {
          props.navigation.closeDrawer();
        }}>
        <Ionicons name="chevron-back-outline" color="black" size={26}></Ionicons>
      </TouchableOpacity>
    );
  }
  const Title = () => {
    return (
      <View className="flex-1 items-center justify-center">
          <Text style={{color:"white", fontWeight:"bold",fontSize:responsiveFontSize(2.2)}}>Đổi mật khẩu</Text>
      </View>
      
    );
  }
  const ResetInput = ()=>{
    setPassword("");
    setNewPassword("");
    setReNewPassword("");
  }


  return (

    <View style={{ flex: 1 }}>
      <View className="flex-row p-2" style={{ zIndex: 1000, marginTop: StatusBar.currentHeight }} backgroundColor={argonTheme.COLORS.ERROR}>
        <ExitButton />
        <Title/>
      </View>


      <View className="m-3">
        <KeyboardAvoidingView
          behavior="padding"
          enabled
        >
          <Block style={{ marginBottom: 10 }}>
            <Input
              password
              borderless
              placeholder="Mật khẩu cũ"
              value={password}
              onChangeText={text => setPassword(text)}
              iconContent={
                <Icon
                  size={16}
                  color={argonTheme.COLORS.ICON}
                  name="padlock-unlocked"
                  family="ArgonExtra"
                  style={styles.inputIcons}
                />
              }
            />
          </Block>
          <Block style={{ marginBottom: 10 }}>
            <Input
              password
              borderless
              placeholder="Mật khẩu mới"
              value={newPassword}
              onChangeText={text => setNewPassword(text)}
              iconContent={
                <Icon
                  size={16}
                  color={argonTheme.COLORS.ICON}
                  name="padlock-unlocked"
                  family="ArgonExtra"
                  style={styles.inputIcons}
                />
              }
            />
          </Block>

          <Block style={{ marginBottom: 10 }}>
            <Input
              password
              borderless
              placeholder="Nhập lại mật khẩu mới"
              value={reNewPassword}
              onChangeText={text => setReNewPassword(text)}
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

          <Block row style={styles.passwordCheck}>
            <Text size={12} color={argonTheme.COLORS.ERROR}>
              {validateText}
            </Text>
          </Block>

          <Block row middle>

            <Button color="error"
              onPress={() => { validateInput(password, newPassword, reNewPassword); }}>
              <Text style={{color:"white", fontWeight:"bold",fontSize:responsiveFontSize(2)}}>
                Đổi mật khẩu
              </Text>
            </Button>
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
  }
});