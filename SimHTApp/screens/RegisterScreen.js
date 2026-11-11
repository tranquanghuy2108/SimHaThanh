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
  ScrollView,
  TextInput,
} from "react-native";
import { Block, Text } from "galio-framework";
import Ionicons from "react-native-vector-icons/Ionicons";

import { Input } from "../components";
import { argonTheme } from "../constants";
import { AuthContext } from "../context/AuthContext";
import { AppConst } from "../constants/AppConst";
import LoadingScreen from "./LoadingScreen";
import AsyncStorage from "@react-native-async-storage/async-storage";
import CommunityGuidelinesModal, {
  COMMUNITY_TERMS_PROMPT_SEEN_KEY,
  COMMUNITY_TERMS_VERSION,
} from "../components/CommunityGuidelinesModal";

const { width, height } = Dimensions.get("screen");
const phoneNumRegex = /^(03|05|07|08|09)[0-9]{8}$/;
const passwordRegex = /^.{8,14}$/;
const TOP_BASE = 40;
const TOP_OFFSET =
  TOP_BASE + (Platform.OS === "android" ? StatusBar.currentHeight || 0 : 0);

const RegisterScreen = ({ navigation }) => {
  const [fullName, setFullName] = useState("");
  const [phoneNumber, setPhoneNumber] = useState("");
  const [password, setPassword] = useState("");
  const [rePassword, setRePassword] = useState("");
  const [validateText, setValidateText] = useState("");
  const [isSubmitting, setIsSubmitting] = useState(false);
  const [hasAcceptedTerms, setHasAcceptedTerms] = useState(false);
  const [isTermsVisible, setTermsVisible] = useState(false);

  const { register, isRegisterSuccess, isLoading } = useContext(AuthContext);

  useEffect(() => {
    console.log("Active Screen  : RegisterScreen");
    if (isRegisterSuccess) {
      navigation.navigate(AppConst.ScreenConst.LOGIN_SCREEN);
    }
  }, [isRegisterSuccess, navigation]);

  useEffect(() => {
    if (!isLoading) {
      setIsSubmitting(false);
    }
  }, [isLoading]);

  const validateInput = (name, phone, pass, rePass) => {
    setValidateText("");
    if (!name.trim() || !phone.trim() || !pass || !rePass)
      return "Bạn chưa nhập đủ thông tin!";
    if (!phoneNumRegex.test(phone.trim()))
      return "Số điện thoại bạn nhập không hợp lệ.";
    if (!passwordRegex.test(pass)) return "Mật khẩu có độ dài từ 8-14 kí tự.";
    if (pass !== rePass) return "Xác nhận lại mật khẩu không đúng.";
    return null;
  };

  const handleRegister = useCallback(() => {
    if (isSubmitting) return;
    if (!hasAcceptedTerms) {
      setValidateText("Vui lòng đồng ý với điều khoản sử dụng ứng dụng.");
      return;
    }
    const error = validateInput(fullName, phoneNumber, password, rePassword);
    if (error) {
      setValidateText(error);
      return;
    }
    setIsSubmitting(true);
    AsyncStorage.multiSet([
      ["CommunityTermsVersion", COMMUNITY_TERMS_VERSION],
      [COMMUNITY_TERMS_PROMPT_SEEN_KEY, "true"],
    ]).catch(() => undefined);
    register(phoneNumber.trim(), fullName.trim(), password, rePassword);
  }, [
    fullName,
    phoneNumber,
    password,
    rePassword,
    isSubmitting,
    register,
    hasAcceptedTerms,
  ]);

  const isBusy = isSubmitting || isLoading;

  return (
    <KeyboardAvoidingView
      behavior={"padding"}
      keyboardVerticalOffset={
        Platform.OS === "ios" ? 0 : StatusBar.currentHeight || 0
      }
      style={{ flex: 1 }}
    >
      <SafeAreaView style={styles.safeArea}>
        <CommunityGuidelinesModal
          visible={isTermsVisible}
          onClose={() => setTermsVisible(false)}
        />
        {isLoading ? <LoadingScreen isVisible={isLoading} /> : null}
        <StatusBar translucent backgroundColor={argonTheme.COLORS.ERROR} />
        <ScrollView
          contentContainerStyle={[
            styles.scrollContent,
            { paddingTop: TOP_OFFSET },
          ]}
          keyboardShouldPersistTaps="handled"
        >
          <View style={styles.center}>
            <Image
              source={require("../assets/imgs/icon_about.png")}
              style={styles.logo}
              resizeMode="stretch"
            />
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
                  iconContent={
                    <Image
                      source={require("../assets/imgs/icon_mobile.png")}
                      style={styles.icon}
                      resizeMode="contain"
                    />
                  }
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
                  iconContent={
                    <Image
                      source={require("../assets/imgs/icon_user.png")}
                      style={styles.icon}
                      resizeMode="contain"
                    />
                  }
                />
              </Block>

              <Block style={styles.formRow}>
                <View style={styles.passwordInput}>
                  <TextInput
                    style={styles.passwordTextInput}
                    placeholder="Mật khẩu"
                    placeholderTextColor={argonTheme.COLORS.MUTED}
                    value={password}
                    onChangeText={setPassword}
                    secureTextEntry
                    autoCapitalize="none"
                    autoCorrect={false}
                    textContentType="newPassword"
                    accessibilityLabel="Mật khẩu"
                  />
                </View>
              </Block>

              <Block style={styles.formRow}>
                <View style={styles.passwordInput}>
                  <TextInput
                    style={styles.passwordTextInput}
                    placeholder="Nhập lại mật khẩu"
                    placeholderTextColor={argonTheme.COLORS.MUTED}
                    value={rePassword}
                    onChangeText={setRePassword}
                    secureTextEntry
                    autoCapitalize="none"
                    autoCorrect={false}
                    textContentType="newPassword"
                    accessibilityLabel="Nhập lại mật khẩu"
                  />
                </View>
              </Block>

              {validateText ? (
                <Block row style={styles.passwordCheck}>
                  <Text size={12} color={argonTheme.COLORS.ERROR}>
                    {validateText}
                  </Text>
                </Block>
              ) : null}

              <View style={styles.termsRow}>
                <TouchableOpacity
                  accessibilityRole="checkbox"
                  accessibilityLabel="Tôi đồng ý với điều khoản sử dụng ứng dụng"
                  accessibilityState={{ checked: hasAcceptedTerms }}
                  hitSlop={8}
                  onPress={() => setHasAcceptedTerms((accepted) => !accepted)}
                  style={styles.checkboxButton}
                >
                  <Ionicons
                    name={hasAcceptedTerms ? "checkbox" : "square-outline"}
                    color={argonTheme.COLORS.ERROR}
                    size={24}
                  />
                </TouchableOpacity>
                <Text style={styles.termsText}>Tôi đồng ý với </Text>
                <TouchableOpacity
                  accessibilityRole="link"
                  accessibilityLabel="Mở điều khoản sử dụng ứng dụng"
                  onPress={() => setTermsVisible(true)}
                >
                  <Text style={styles.termsLink}>
                    Điều khoản sử dụng ứng dụng
                  </Text>
                </TouchableOpacity>
              </View>

              <TouchableOpacity
                accessibilityRole="button"
                accessibilityState={{ busy: isBusy }}
                disabled={isBusy}
                style={[
                  styles.submitButton,
                  isBusy && styles.disabledButton,
                  { backgroundColor: argonTheme.COLORS.ERROR },
                ]}
                onPress={handleRegister}
              >
                <Text style={styles.submitButtonText}>
                  {isBusy ? "ĐANG XỬ LÝ..." : "ĐĂNG KÝ"}
                </Text>
              </TouchableOpacity>

              <Block row style={styles.loginRow}>
                <Text style={styles.navText}>Bạn đã có tài khoản?</Text>
                <Text
                  style={styles.loginText}
                  onPress={() =>
                    navigation.navigate(AppConst.ScreenConst.LOGIN_SCREEN)
                  }
                >
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
    backgroundColor: "#fff",
  },
  scrollContent: {
    flexGrow: 1,
    justifyContent: "flex-start",
    alignItems: "center",
    paddingVertical: 20,
  },
  center: {
    width: width * 0.9,
    alignItems: "center",
  },
  logo: {
    height: 150,
    width: 141,
    marginBottom: 10,
  },
  form: {
    width: "100%",
    alignItems: "center",
  },
  formRow: {
    marginBottom: 8,
    width: "100%",
  },
  icon: {
    height: 20,
    width: 20,
    marginRight: 10,
  },
  passwordInput: {
    alignItems: "center",
    backgroundColor: "#FFFFFF",
    borderColor: "transparent",
    borderRadius: 4,
    borderWidth: 0,
    flexDirection: "row",
    height: 44,
    marginVertical: 8,
    paddingHorizontal: 12,
    shadowColor: argonTheme.COLORS.BLACK,
    shadowOffset: { width: 0, height: 1 },
    shadowOpacity: 0.3,
    shadowRadius: 2,
    elevation: 2,
  },
  passwordTextInput: {
    color: argonTheme.COLORS.HEADER,
    flex: 1,
    fontSize: 14,
    height: "100%",
    paddingVertical: 0,
  },
  passwordCheck: {
    paddingTop: 10,
    paddingBottom: 10,
  },
  termsRow: {
    alignItems: "center",
    flexDirection: "row",
    flexWrap: "wrap",
    marginTop: 6,
    width: width * 0.8,
  },
  checkboxButton: {
    alignItems: "center",
    justifyContent: "center",
    marginRight: 6,
  },
  termsText: {
    color: "#525f7f",
    fontSize: 12,
  },
  submitButton: {
    height: 40,
    borderRadius: 6,
    justifyContent: "center",
    alignItems: "center",
    paddingHorizontal: 20,
    marginTop: 10,
    width: width * 0.8,
  },
  disabledButton: {
    opacity: 0.6,
  },
  submitButtonText: {
    color: "#fff",
    fontWeight: "700",
  },
  loginRow: {
    width: width * 0.8,
    justifyContent: "space-between",
    marginTop: 10,
  },
  navText: {
    flex: 1,
    paddingTop: 20,
    textAlign: "right",
  },
  loginText: {
    color: "#0a6eb4",
    paddingLeft: 6,
    alignSelf: "flex-end",
  },
  termsLink: {
    color: "#0a6eb4",
    fontSize: 12,
    fontWeight: "700",
    textDecorationLine: "underline",
  },
});
