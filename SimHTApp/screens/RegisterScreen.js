import React, { useContext, useState, useRef, useCallback } from "react";
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
  Modal,
  ActivityIndicator,
  Keyboard,
} from "react-native";
import { Block, Text } from "galio-framework";
import Ionicons from "react-native-vector-icons/Ionicons";

import { Input } from "../components";
import { argonTheme } from "../constants";
import { AuthContext } from "../context/AuthContext";
import { AppConst } from "../constants/AppConst";
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
  const [showPassword, setShowPassword] = useState(false);
  const [showRePassword, setShowRePassword] = useState(false);
  const [validateText, setValidateText] = useState("");
  const [isSubmitting, setIsSubmitting] = useState(false);
  const submittingRef = useRef(false);
  const [registrationResult, setRegistrationResult] = useState(null);
  const [hasAcceptedTerms, setHasAcceptedTerms] = useState(false);
  const [isTermsVisible, setTermsVisible] = useState(false);

  const { register, isLoading } = useContext(AuthContext);

  const showRegistrationFailure = (message) => {
    Keyboard.dismiss();
    setValidateText(message);
    setRegistrationResult({ success: false, message });
  };

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

  const handleRegister = useCallback(async () => {
    if (submittingRef.current || registrationResult) return;
    if (!hasAcceptedTerms) {
      showRegistrationFailure("Vui lòng đồng ý với điều khoản sử dụng ứng dụng.");
      return;
    }
    const error = validateInput(fullName, phoneNumber, password, rePassword);
    if (error) {
      showRegistrationFailure(error);
      return;
    }
    submittingRef.current = true;
    setIsSubmitting(true);
    Keyboard.dismiss();
    AsyncStorage.multiSet([
      ["CommunityTermsVersion", COMMUNITY_TERMS_VERSION],
      [COMMUNITY_TERMS_PROMPT_SEEN_KEY, "true"],
    ]).catch(() => undefined);
    try {
      const result = await register(phoneNumber.trim(), fullName.trim(), password, rePassword);
      setRegistrationResult(result);
    } catch {
      setRegistrationResult({
        success: false,
        message: "Không thể đăng ký tài khoản. Vui lòng thử lại.",
      });
    } finally {
      submittingRef.current = false;
      setIsSubmitting(false);
    }
  }, [
    fullName,
    phoneNumber,
    password,
    rePassword,
    registrationResult,
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
        <Modal
          visible={isSubmitting || registrationResult !== null}
          transparent
          animationType="fade"
          onRequestClose={() => {
            if (registrationResult && !registrationResult.success) {
              setRegistrationResult(null);
            }
          }}
        >
          <View style={styles.resultOverlay}>
            <View style={styles.resultCard} accessibilityViewIsModal>
              {isSubmitting ? (
                <>
                  <ActivityIndicator size="large" color={argonTheme.COLORS.ERROR} />
                  <Text style={styles.resultMessage}>Đang đăng ký tài khoản...</Text>
                </>
              ) : (
                <>
                  <Ionicons
                    name={registrationResult?.success ? "checkmark-circle-outline" : "alert-circle-outline"}
                    size={48}
                    color={registrationResult?.success ? "#2D8A4E" : argonTheme.COLORS.ERROR}
                  />
                  <Text style={styles.resultTitle} accessibilityRole="header">
                    {registrationResult?.success ? "Đăng ký thành công" : "Đăng ký thất bại"}
                  </Text>
                  <Text style={styles.resultMessage}>{registrationResult?.message}</Text>
                  <TouchableOpacity
                    accessibilityRole="button"
                    style={[styles.submitButton, styles.resultButton]}
                    onPress={() => {
                      const success = registrationResult?.success;
                      setRegistrationResult(null);
                      if (success) {
                        navigation.navigate(AppConst.ScreenConst.LOGIN_SCREEN);
                      }
                    }}
                  >
                    <Text style={styles.submitButtonText}>
                      {registrationResult?.success ? "Đăng nhập" : "Quay lại"}
                    </Text>
                  </TouchableOpacity>
                </>
              )}
            </View>
          </View>
        </Modal>
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
                    secureTextEntry={!showPassword}
                    autoCapitalize="none"
                    autoCorrect={false}
                    textContentType="newPassword"
                    accessibilityLabel="Mật khẩu"
                  />
                  <TouchableOpacity
                    style={styles.passwordToggle}
                    onPress={() => setShowPassword((visible) => !visible)}
                    accessibilityRole="button"
                    accessibilityLabel={showPassword ? "Ẩn mật khẩu" : "Hiện mật khẩu"}
                  >
                    <Ionicons
                      name={showPassword ? "eye-off-outline" : "eye-outline"}
                      size={22}
                      color={argonTheme.COLORS.ICON}
                    />
                  </TouchableOpacity>
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
                    secureTextEntry={!showRePassword}
                    autoCapitalize="none"
                    autoCorrect={false}
                    textContentType="newPassword"
                    accessibilityLabel="Nhập lại mật khẩu"
                  />
                  <TouchableOpacity
                    style={styles.passwordToggle}
                    onPress={() => setShowRePassword((visible) => !visible)}
                    accessibilityRole="button"
                    accessibilityLabel={showRePassword ? "Ẩn mật khẩu xác nhận" : "Hiện mật khẩu xác nhận"}
                  >
                    <Ionicons
                      name={showRePassword ? "eye-off-outline" : "eye-outline"}
                      size={22}
                      color={argonTheme.COLORS.ICON}
                    />
                  </TouchableOpacity>
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
  resultOverlay: {
    flex: 1,
    justifyContent: "center",
    alignItems: "center",
    backgroundColor: "rgba(0, 0, 0, 0.5)",
    padding: 24,
  },
  resultCard: {
    width: "100%",
    maxWidth: 400,
    borderRadius: 16,
    padding: 24,
    backgroundColor: "#fff",
    alignItems: "center",
  },
  resultTitle: {
    fontSize: 20,
    fontWeight: "bold",
    textAlign: "center",
    marginTop: 12,
    color: argonTheme.COLORS.HEADER,
  },
  resultMessage: {
    fontSize: 16,
    textAlign: "center",
    marginTop: 12,
    marginBottom: 20,
    color: argonTheme.COLORS.HEADER,
  },
  resultButton: {
    width: "100%",
    backgroundColor: argonTheme.COLORS.ERROR,
  },
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
  passwordToggle: {
    width: 44,
    height: 44,
    alignItems: "center",
    justifyContent: "center",
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
