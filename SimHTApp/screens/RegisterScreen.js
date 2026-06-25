import React, { useContext, useState, useEffect, useCallback } from "react";
import {
  StyleSheet,
  Dimensions,
  StatusBar,
  KeyboardAvoidingView,
  Image,
  TouchableOpacity,
  View,
  Platform,
  SafeAreaView,
  ScrollView
} from "react-native";
import { Block, Text } from "galio-framework";

import { Input } from "../components";
import { argonTheme } from "../constants";
import { AuthContext } from "../context/AuthContext";
import { AppConst } from "../constants/AppConst";

const { width, height } = Dimensions.get("screen");
const phoneNumRegex = /^(03|05|07|08|09)[0-9]{8}$/;
const passwordRegex = /^.{8,14}$/;
const TOP_BASE = 40;
const TOP_OFFSET = TOP_BASE + (Platform.OS === "android" ? StatusBar.currentHeight || 0 : 0);

const RegisterScreen = ({ navigation }) => {
  const [fullName, setFullName] = useState("");
  const [phoneNumber, setPhoneNumber] = useState("");
  const [password, setPassword] = useState("");
  const [rePassword, setRePassword] = useState("");
  const [validateText, setValidateText] = useState("");
  const [isSubmitting, setIsSubmitting] = useState(false);

  const { register, isRegisterSuccess } = useContext(AuthContext);

  useEffect(() => {
    // stop submitting animation/state when registration completes (success or failure)
    setIsSubmitting(false);
    if (isRegisterSuccess) {
      navigation.navigate(AppConst.ScreenConst.LOGIN_SCREEN);
    }
  }, [isRegisterSuccess, navigation]);

  const validateInput = (name, phone, pass, rePass) => {
    setValidateText("");
    if (!name.trim() || !phone.trim() || !pass || !rePass) return "Bạn chưa nhập đủ thông tin!";
    if (!phoneNumRegex.test(phone.trim())) return "Số điện thoại bạn nhập không hợp lệ.";
    if (!passwordRegex.test(pass)) return "Mật khẩu có độ dài từ 8-14 kí tự.";
    if (pass !== rePass) return "Xác nhận lại mật khẩu không đúng.";
    return null;
  };

  const handleRegister = useCallback(() => {
    if (isSubmitting) return;
    const error = validateInput(fullName, phoneNumber, password, rePassword);
    if (error) {
      setValidateText(error);
      return;
    }
    setIsSubmitting(true);
    register(phoneNumber.trim(), fullName.trim(), password, rePassword);
  }, [fullName, phoneNumber, password, rePassword, isSubmitting, register]);

  return (
    <KeyboardAvoidingView
      behavior={"padding"}
      keyboardVerticalOffset={Platform.OS === "ios" ? 0 : StatusBar.currentHeight || 0}
      style={{ flex: 1 }}
    >
      <SafeAreaView style={styles.safeArea}>
        <StatusBar translucent backgroundColor={argonTheme.COLORS.ERROR} />
        <ScrollView contentContainerStyle={[styles.scrollContent, { paddingTop: TOP_OFFSET }]} keyboardShouldPersistTaps="handled">
          <View style={styles.center}>
            <Image source={require("../assets/imgs/icon_about.png")} style={styles.logo} resizeMode="stretch" />
            <Text color="#8898AA" size={30}>
              ĐĂNG KÝ
            </Text>

            <View style={styles.form}>
              <Block style={styles.formRow}>
                <Input
                  borderless
                  placeholder="Số điện thoại"
                  value={phoneNumber}
                  onChangeText={setPhoneNumber}
                  keyboardType="phone-pad"
                  accessibilityLabel="Số điện thoại"
                  iconContent={<Image source={require("../assets/imgs/icon_mobile.png")} style={styles.icon} resizeMode="contain" />}
                />
              </Block>

              <Block style={styles.formRow}>
                <Input
                  borderless
                  placeholder="Họ tên"
                  value={fullName}
                  onChangeText={setFullName}
                  autoCapitalize="words"
                  accessibilityLabel="Họ tên"
                  iconContent={<Image source={require("../assets/imgs/icon_user.png")} style={styles.icon} resizeMode="contain" />}
                />
              </Block>

              <Block style={styles.formRow}>
                <Input
                  password
                  borderless
                  placeholder="Mật khẩu"
                  value={password}
                  onChangeText={setPassword}
                  accessibilityLabel="Mật khẩu"
                  iconContent={<Image source={require("../assets/imgs/icon_lock.png")} style={styles.icon} resizeMode="contain" />}
                />
              </Block>

              <Block style={styles.formRow}>
                <Input
                  password
                  borderless
                  placeholder="Nhập lại mật khẩu"
                  value={rePassword}
                  onChangeText={setRePassword}
                  accessibilityLabel="Nhập lại mật khẩu"
                  iconContent={<Image source={require("../assets/imgs/icon_lock.png")} style={styles.icon} resizeMode="contain" />}
                />
              </Block>

              {validateText ? (
                <Block row style={styles.passwordCheck}>
                  <Text size={12} color={argonTheme.COLORS.ERROR}>
                    {validateText}
                  </Text>
                </Block>
              ) : null}

              <TouchableOpacity
                accessibilityRole="button"
                accessibilityState={{ busy: isSubmitting }}
                disabled={isSubmitting}
                style={[styles.submitButton, isSubmitting && styles.disabledButton, { backgroundColor: argonTheme.COLORS.ERROR }]}
                onPress={handleRegister}
              >
                <Text style={styles.submitButtonText}>{isSubmitting ? "ĐANG XỬ LÝ..." : "ĐĂNG KÝ"}</Text>
              </TouchableOpacity>

              <Block row style={styles.loginRow}>
                <Text style={styles.navText}>Bạn đã có tài khoản?</Text>
                <Text style={styles.loginText} onPress={() => navigation.navigate(AppConst.ScreenConst.LOGIN_SCREEN)}>
                  ĐĂNG NHẬP
                </Text>
              </Block>
            </View>
          </View>
        </ScrollView>
      </SafeAreaView>
    </KeyboardAvoidingView>
  );
};

export default RegisterScreen;

const styles = StyleSheet.create({
  safeArea: {
    flex: 1,
    backgroundColor: "#fff"
  },
  scrollContent: {
    flexGrow: 1,
    justifyContent: "flex-start",
    alignItems: "center",
    paddingVertical: 20,
    
  },
  center: {
    width: width * 0.9,
    alignItems: "center"
  },
  logo: {
    height: 150,
    width: 141,
    marginBottom: 10
  },
  form: {
    width: "100%",
    alignItems: "center"
  },
  formRow: {
    marginBottom: 8,
    width: "100%"
  },
  icon: {
    height: 20,
    width: 20,
    marginRight: 10
  },
  passwordCheck: {
    paddingTop: 10,
    paddingBottom: 10
  },
  submitButton: {
    height: 40,
    borderRadius: 6,
    justifyContent: "center",
    alignItems: "center",
    paddingHorizontal: 20,
    marginTop: 10,
    width: width * 0.8
  },
  disabledButton: {
    opacity: 0.6
  },
  submitButtonText: {
    color: "#fff",
    fontWeight: "700"
  },
  loginRow: {
    width: width * 0.8,
    justifyContent: "space-between",
    marginTop: 10
  },
  navText: {
    flex: 1,
    paddingTop: 20,
    textAlign: "right"
  },
  loginText: {
    color: "#0a6eb4",
    paddingLeft: 6,
    alignSelf: "flex-end"
  }
});