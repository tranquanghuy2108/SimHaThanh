import React, { createContext, useEffect, useState } from "react";
import AsyncStorage from "@react-native-async-storage/async-storage";
import axios from "axios";
import Config from "../constants/Config";
import { Alert, Platform, ToastAndroid } from "react-native";
export const AuthContext = createContext();

export const isEmptyAuthValue = (value) => {
  if (value == null) return true;
  if (typeof value === "string") return value.trim().length === 0;
  if (typeof value === "object") return Object.keys(value).length === 0;
  return false;
};

const showMessage = (message, long = false) => {
  if (Platform.OS === "android") {
    ToastAndroid.showWithGravity(
      message,
      long ? ToastAndroid.LONG : ToastAndroid.SHORT,
      ToastAndroid.BOTTOM,
    );
  } else {
    Alert.alert("Thông báo", message);
  }
};

export const AuthProvider = ({ children }) => {
  const [isLoading, setIsLoading] = useState(false);
  const [userInfos, setUserInfos] = useState(null);
  const [userToken, setUserToken] = useState(null);
  const [isRegisterSuccess, SetRegisterState] = useState(false);
  const [userInfoData, SetUserInfoDataState] = useState(null);
  const [spContact, SetSupportContactState] = useState([]);
  const [configData, SetConfigState] = useState(null);
  const [bankInfo, SetBankInfoState] = useState(null);
  const isAuthenticated =
    !isEmptyAuthValue(userInfos) && !isEmptyAuthValue(userToken);

  const SetUserInfoByStorage = (userInfo) => {
    setUserInfos(userInfo);
  };
  const SetUserTokenByStorage = (userToken) => {
    setUserToken(userToken);
  };
  const login = (phoneNumber, password, rememberMe) => {
    try {
      setIsLoading(true);
      axios
        .post(
          Config.BASE_URL + "/api/account/authenticate",
          {
            username: phoneNumber,
            password: password,
            rememberMe: rememberMe,
          },
          {
            headers: {
              Accept: "*/*",
              "Content-Type": "application/json",
            },
          },
        )
        .then((res) => {
          const response = res.data;

          if (response.code === "1") {
            ToastAndroid.showWithGravity(
              `${response.message}`,
              ToastAndroid.SHORT,
              ToastAndroid.BOTTOM,
            );
            var token = response.data.token;
            setUserToken(token);
            AsyncStorage.setItem("UserToken", JSON.stringify(token));
            //
            var uInfo = response.data;
            setUserInfos(uInfo);
            AsyncStorage.setItem("UserInfo", JSON.stringify(uInfo));
          } else {
            ToastAndroid.showWithGravity(
              `${response.message}`,
              ToastAndroid.LONG,
              ToastAndroid.BOTTOM,
            );
          }
          setIsLoading(false);
        })
        .catch((error) => {
          setIsLoading(false);
          ToastAndroid.showWithGravity(
            `${error.response.data.message}`,
            ToastAndroid.LONG,
            ToastAndroid.BOTTOM,
          );
        });
    } catch (ex) {}
  };
  const logout = () => {
    setIsLoading(false);
    AsyncStorage.removeItem("UserInfo");
    AsyncStorage.getAllKeys()
      .then((keys) => {
        const keysToRemove = keys.filter(
          (key) =>
            key !== "CommunityTermsVersion" &&
            key !== "CommunityTermsPromptSeen" &&
            !key.startsWith("BlockedUserIds:"),
        );
        return AsyncStorage.multiRemove(keysToRemove);
      })
      .then(() => {})
      .catch((error) => {});
    setUserInfos(null);
    setUserToken(null);
  };

  const register = (phoneNumber, fullName, password, rePassword) => {
    setIsLoading(true);
    axios
      .post(Config.BASE_URL + "/api/account/register", {
        username: phoneNumber,
        fullName: fullName,
        password: password,
        rePassword: rePassword,
        groupId: 0,
        isStaff: false,
      })
      .then((response) => {
        setIsLoading(false);
        ToastAndroid.showWithGravity(
          "Đăng ký thành công!",
          ToastAndroid.SHORT,
          ToastAndroid.BOTTOM,
        );
        SetRegisterState(true);
        return true;
      })
      .catch((error) => {
        setIsLoading(false);
        ToastAndroid.showWithGravity(
          `Đăng ký thất bại. ${error.response.data.message}`,
          ToastAndroid.SHORT,
          ToastAndroid.BOTTOM,
        );
        SetRegisterState(false);
        return false;
      });
  };

  const DeleteAccount = () => {
    axios
      .post(Config.BASE_URL + "/api/account/delete-account", userInfos.id, {
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
          Authorization: "Bearer " + userToken,
        },
      })
      .then((response) => {
        ToastAndroid.showWithGravity(
          "Xóa tài khoản thành công!",
          ToastAndroid.SHORT,
          ToastAndroid.BOTTOM,
        );
        logout();
        return true;
      })
      .catch((error) => {
        ToastAndroid.showWithGravity(
          `Xóa tài khoản thất bại. ${error.response.data.message}`,
          ToastAndroid.SHORT,
          ToastAndroid.BOTTOM,
        );
        return false;
      });
  };

  const changePassword = async (password, newPassword, reNewPassword) => {
    setIsLoading(true);

    try {
      const response = await axios.post(
        Config.BASE_URL + "/api/account/change-password",
        {
          id: userInfos.id,
          current_user_pass: password,
          new_user_pass: newPassword,
          confirm_user_pass: reNewPassword,
        },
        {
          headers: {
            Accept: "application/json",
            "Content-Type": "application/json",
            Authorization: "Bearer " + userToken,
          },
        },
      );

      ToastAndroid.showWithGravity(
        "Đổi mật khẩu thành công!",
        ToastAndroid.LONG,
        ToastAndroid.BOTTOM,
      );
      setIsLoading(false);
      return true;
    } catch (error) {
      setIsLoading(false);
      ToastAndroid.showWithGravity(
        `Đổi mật khẩu thất bại. ${error.response.data.message}`,
        ToastAndroid.SHORT,
        ToastAndroid.BOTTOM,
      );
      return false;
    }
  };
  //
  const GetUserInfo = () => {
    axios
      .post(Config.BASE_URL + "/api/account/get-userinfo", userInfos.id, {
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
          Authorization: "Bearer " + userToken,
        },
      })
      .then((response) => {
        SetUserInfoDataState(response.data);
        setIsLoading(false);
        return true;
      })
      .catch((error) => {
        SetUserInfoDataState(null);
        setIsLoading(false);
        return false;
      });
  };
  //
  const updateUserInfo = async (
    fullName,
    email,
    website,
    address,
    avatar,
    remark,
  ) => {
    if (avatar == null) {
      avatar = userInfos.avatar;
    }
    setIsLoading(true);

    try {
      const response = await axios.post(
        Config.BASE_URL + "/api/account/update-info",
        {
          id: userInfos.id,
          fullName: fullName,
          email: email,
          username: userInfos.username,
          phoneNumber: userInfos.username,
          address: address,
          avatar: avatar,
          website: website,
          remark: remark,
          groupId: 0,
          agentGroupId: 0,
          discountForSimSellersId: 0,
          isActive: true,
          isCollaborator: true,
          isAgent: true,
          isStaff: false,
        },
        {
          headers: {
            Accept: "application/json",
            "Content-Type": "application/json",
            Authorization: "Bearer " + userToken,
          },
        },
      );
      showMessage("Cập nhật thành công!", true);
      const uInfo = response.data?.data || response.data;

      setUserInfos(uInfo);
      await AsyncStorage.setItem("UserInfo", JSON.stringify(uInfo));
      setIsLoading(false);
      return true;
    } catch (error) {
      setIsLoading(false);
      const message = error.response?.data?.message || error.message || "Vui lòng thử lại.";
      showMessage(`Cập nhật thất bại. ${message}`, true);
      return false;
    }
  };

  //

  const GetBankInfo = () => {
    setIsLoading(true);
    axios
      .post(
        Config.BASE_URL + "/api/account/get-bankInfo",
        {},
        {
          headers: {
            Accept: "application/json",
            "Content-Type": "application/json",
            Authorization: "Bearer " + userToken,
          },
        },
      )
      .then((response) => {
        SetBankInfoState(response.data);
        setIsLoading(false);
      })
      .catch((error) => {
        SetBankInfoState(null);
        setIsLoading(false);
      });
  };
  //
  const GetConfigData = () => {
    setIsLoading(true);
    axios
      .post(
        Config.BASE_URL + "/api/account/get-config",
        {},
        {
          headers: {
            Accept: "application/json",
            "Content-Type": "application/json",
            Authorization: "Bearer " + userToken,
          },
        },
      )
      .then((response) => {
        console.log("GetConfigData", response.data);
        SetConfigState(response.data);
        setIsLoading(false);
      })
      .catch((error) => {
        SetConfigState(null);
        setIsLoading(false);
      });
  };

  //
  const SetRegister = (active) => {
    SetRegisterState(active);
  };
  const GetSupportContact = () => {
    setIsLoading(true);
    axios
      .post(Config.BASE_URL + "/api/account/get-spcontact", userInfos.id, {
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
          Authorization: "Bearer " + userToken,
        },
      })
      .then((response) => {
        SetSupportContactState(response.data);
        setIsLoading(true);
        return true;
      })
      .catch((error) => {
        SetSupportContactState([]);
        setIsLoading(false);
        return false;
      });
  };

  return (
    <AuthContext.Provider
      value={{
        login,
        logout,
        register,
        changePassword,
        updateUserInfo,
        SetUserInfoByStorage,
        SetUserTokenByStorage,
        DeleteAccount,
        SetRegister,
        GetUserInfo,
        userToken,
        isAuthenticated,
        isLoading,
        userInfos,
        isRegisterSuccess,
        userInfoData,

        GetSupportContact,
        spContact,
        GetConfigData,
        configData,
        GetBankInfo,
        bankInfo,
      }}
    >
      {children}
    </AuthContext.Provider>
  );
};
