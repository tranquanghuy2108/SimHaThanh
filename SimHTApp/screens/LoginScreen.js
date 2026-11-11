import React, { useContext, useState, useCallback, useEffect } from "react";
import { useFocusEffect } from '@react-navigation/native';
import {
  StyleSheet,
  Dimensions,
  StatusBar,
  KeyboardAvoidingView,
  TouchableOpacity,
  Image,
  View,
} from "react-native";
import { Block, Text } from "galio-framework";

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

const LoginScreen = ({ navigation }) => {
  useFocusEffect(
    useCallback(() => {
      console.log("LOG Active Screen : LoginScreen");
      return () => {
        // Optional: Add cleanup logic here if needed when the screen loses focus
      };
    }, [])
  );
  const [phoneNumber, setPhoneNumber] = useState(null);
  const [password, setPassword] = useState(null);
  const [validateText, setValidateText] = useState(null);
  const [hasAcceptedTerms, setHasAcceptedTerms] = useState(false);
  const [isTermsVisible, setTermsVisible] = useState(false);

  const { login, SetRegister, isLoading, isAuthenticated } = useContext(AuthContext);

  useEffect(() => {
    if (isAuthenticated && navigation.canGoBack()) {
      navigation.goBack();
    }
  }, [isAuthenticated, navigation]);

  useEffect(() => {
    AsyncStorage.multiGet([
      "CommunityTermsVersion",
      COMMUNITY_TERMS_PROMPT_SEEN_KEY,
    ])
      .then((entries) => {
        const acceptedVersion = entries[0][1];
        const hasSeenPrompt = entries[1][1] === "true";
        const accepted = acceptedVersion === COMMUNITY_TERMS_VERSION;
        setHasAcceptedTerms(accepted);
        if (!accepted && !hasSeenPrompt) setTermsVisible(true);
      })
      .catch(() => setTermsVisible(true));
  }, []);

  const acceptTerms = async () => {
    await AsyncStorage.multiSet([
      ["CommunityTermsVersion", COMMUNITY_TERMS_VERSION],
      [COMMUNITY_TERMS_PROMPT_SEEN_KEY, "true"],
    ]);
    setHasAcceptedTerms(true);
    setTermsVisible(false);
  };

  const closeTerms = () => {
    AsyncStorage.setItem(COMMUNITY_TERMS_PROMPT_SEEN_KEY, "true").catch(
      () => undefined,
    );
    setTermsVisible(false);
  };

  const handleLogin = () => {
    if (!hasAcceptedTerms) {
      setTermsVisible(true);
      return;
    }
    login(phoneNumber, password, true);
  };

  return (
    <View className=" flex-1 justify-center items-center mb-14">
      <CommunityGuidelinesModal
        visible={isTermsVisible}
        onAccept={acceptTerms}
        onClose={closeTerms}
        acceptLabel="Đồng ý để tiếp tục"
      />
      {isLoading ? <LoadingScreen isVisible={isLoading} /> : null}
      <StatusBar translucent backgroundColor={argonTheme.COLORS.ERROR} />
      <View className="items-center">
        <Image
          source={require("../assets/imgs/icon_about.png")}
          style={{ height: 150, width: 141 }}
          resizeMode="stretch"
        ></Image>
        <Text color="#8898AA" size={30}>
          ĐĂNG NHẬP
        </Text>
        <KeyboardAvoidingView behavior="padding" enabled>
          <Block style={{ marginBottom: 5 }}>
            <Input
              borderless
              placeholder="Số điện thoại"
              value={phoneNumber}
              onChangeText={(text) => setPhoneNumber(text)}
              iconContent={
                <Image
                  source={require("../assets/imgs/icon_mobile.png")}
                  style={{ height: 20, width: 20, marginRight: 10 }}
                  resizeMode="contain"
                />
              }
            />
          </Block>
          <Block>
            <Input
              password
              borderless
              placeholder="Mật khẩu"
              value={password}
              onChangeText={(text) => setPassword(text)}
              iconContent={
                <Image
                  source={require("../assets/imgs/icon_lock.png")}
                  style={{ height: 20, width: 20, marginRight: 10 }}
                  resizeMode="contain"
                />
              }
            />
          </Block>

          <Block row style={styles.passwordCheck}>
            <Text
              size={12}
              color={argonTheme.COLORS.ERROR}
              value={validateText}
            ></Text>
          </Block>

          <TouchableOpacity
            className="bg-black justify-center items-center rounded"
            disabled={isLoading}
            style={{
              height: 40,
              backgroundColor: argonTheme.COLORS.ERROR,
              opacity: isLoading ? 0.7 : 1,
            }}
            onPress={() => {
              handleLogin();
            }}
          >
            <Text className="color-white font-bold">ĐĂNG NHẬP</Text>
          </TouchableOpacity>

          <Block
            row
            width={width * 0.8}
            style={{ justifyContent: "space-between" }}
          >
            <Text style={styles.navText}>Bạn chưa có tài khoản?</Text>
            <Text
              style={[
                { color: "#0a6eb4" },
                { paddingLeft: 3 },
                { alignSelf: "flex-end" },
              ]}
              onPress={() => {
                SetRegister(false);
                navigation.navigate(AppConst.ScreenConst.REGISTER_SCEEN);
              }}
            >
              ĐĂNG KÍ NGAY
            </Text>
          </Block>
          <TouchableOpacity onPress={() => setTermsVisible(true)}>
            <Text style={styles.termsLink}>Điều khoản sử dụng & Quy tắc cộng đồng</Text>
          </TouchableOpacity>
        </KeyboardAvoidingView>
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    width: width * 0.9,
    height: height * 0.875,
    backgroundColor: "#F4F5F7",
    borderRadius: 4,
    shadowColor: argonTheme.COLORS.BLACK,
    shadowOffset: {
      width: 0,
      height: 4,
    },
    shadowRadius: 8,
    shadowOpacity: 0.1,
    elevation: 1,
    overflow: "hidden",
  },
  socialConnect: {
    borderColor: "#8898AA",
  },
  inputIcons: {
    marginRight: 12,
  },
  passwordCheck: {
    paddingTop: 5,
    paddingBottom: 5,
  },
  createButton: {
    flex: 1,
    marginTop: 25,
    flexDirection: "row",
    justifyContent: "center",
    alignItems: "center",
  },
  navText: {
    flex: 1,
    paddingTop: 20,
    textAlign: "right",
  },
  termsLink: {
    color: "#0a6eb4",
    fontSize: 12,
    marginTop: 14,
    textAlign: "center",
  },
});
export default LoginScreen;
