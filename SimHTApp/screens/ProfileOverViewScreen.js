import React, { useContext, useEffect, useState, useRef } from "react";
import { argonTheme } from "../constants";
import { AuthContext } from "../context/AuthContext";
import { Badge } from "react-native-elements";
import {
  responsiveHeight,
  responsiveWidth,
  responsiveFontSize,
} from "react-native-responsive-dimensions";

import Ionicons from "react-native-vector-icons/Ionicons";
import {
  TouchableOpacity,
  Text,
  Image,
  View,
  TextInput,
  StyleSheet,
  SafeAreaView,
  StatusBar,
  ScrollView,
  Alert,
} from "react-native";
import { AppConst } from "../constants/AppConst";
import { NotificationMailContext } from "../context/NotificationMailContext";
import { MySimContext } from "../context/MySimContext";
import { BottomTabContext } from "../context/BottomTabContext";
import { SearchContext } from "../context/SearchContext";
import { EscrowWalletContext } from "../context/EscrowWalletContext";

const ConvertCurrency = (numberString) => {
  const numericValue = Number(numberString);
  if (Number.isNaN(numericValue)) {
    return "0 VND";
  }

  return numericValue.toLocaleString("vi-VN", {
    style: "currency",
    currency: "VND",
  });
};

const ProfileOverViewScreen = ({ navigation }) => {
  const { logout, userInfos, GetUserInfo, userInfoData } =
    useContext(AuthContext);
  const { notificationDatas } = useContext(NotificationMailContext);
  const { SetSearchMySim } = useContext(BottomTabContext);
  const { search } = useContext(MySimContext);
  const { moneyEscrowData } = useContext(EscrowWalletContext);
  const { simUserInfo, GetSimOfUserInfo } = useContext(SearchContext);
  const hasInitializedRef = useRef(false);

  const unreadCount =
    notificationDatas?.filter((item) => item.isRead === false).length ?? 0;
  const profileName = userInfos?.fullName || "Người dùng";
  const profilePhone = userInfos?.username || "";
  const avatarSource = userInfos?.avatar
    ? { uri: `data:image/jpeg;base64,${userInfos.avatar}` }
    : require("../assets/imgs/icon_user.png");

  useEffect(() => {
    if (hasInitializedRef.current) {
      return;
    }

    hasInitializedRef.current = true;
    console.log("Active Screen  : ProfileOverViewScreen");

    if (userInfos?.id) {
      GetUserInfo();
    }

    GetSimOfUserInfo();
  }, [GetUserInfo, GetSimOfUserInfo, userInfos?.id]);

  const handleNavigateToNativeScreen = (screen) => {
    navigation.navigate(AppConst.StackConst.NATIVE_STACK, { screen });
  };

  const handleSearchFocus = () => {
    navigation.navigate(AppConst.ScreenConst.SEARCH_SCREEN, {
      screenParam: AppConst.SearchFrameConst.IS_HOMESEARCH,
    });
  };

  const handleNavigateToNotification = () => {
    navigation.navigate(AppConst.StackConst.NATIVE_STACK, {
      screen: AppConst.ScreenConst.NOTIFICATION_SCREEN,
    });
  };

  const handleNavigateToChat = () => {
    navigation.navigate(AppConst.StackConst.BOTTOM_STACK, {
      screen: AppConst.ScreenConst.CHAT_SCREEN,
    });
  };

  const handleNavigateToMySim = () => {
    SetSearchMySim("");
    search("");
    navigation.navigate(AppConst.ScreenConst.MY_SIM_SCREEN);
  };

  const ConfirmLogout = () => {
    Alert.alert(
      "Bạn có muốn đăng xuất?",
      "",
      [{ text: "Hủy" }, { text: "Đồng ý", onPress: () => logout() }],
      { cancelable: false },
    );
  };

  const SearchButton = () => (
    <TouchableOpacity
      className="flex-1"
      onPress={handleSearchFocus}
      activeOpacity={0.9}
    >
      <View className="flex-row flex-1 items-center rounded-full bg-white mx-1">
        <View className="bg-transparent rounded-full m-3">
          <Ionicons name="search-outline" color="black" size={20} />
        </View>
        <TextInput
          placeholder="Tìm Kiếm SIM"
          placeholderTextColor="gray"
          className="text-base m-0 pl-2"
          returnKeyType="search"
          editable={false}
        />
      </View>
    </TouchableOpacity>
  );

  const NotificationBtn = () => (
    <TouchableOpacity
      className="rounded-full bg-white justify-center items-center mx-1"
      style={{ width: 40, height: 40 }}
      onPress={handleNavigateToNotification}
    >
      <Ionicons
        name="notifications-outline"
        size={20}
        color={argonTheme.COLORS.ERROR}
      />
      {unreadCount > 0 && (
        <Badge
          value={unreadCount}
          status="error"
          containerStyle={{ position: "absolute", top: -5, right: -5 }}
        />
      )}
    </TouchableOpacity>
  );

  const ChatBoxBtn = () => (
    <TouchableOpacity
      className="rounded-full bg-white justify-center items-center mx-1"
      style={{ width: 40, height: 40 }}
      onPress={handleNavigateToChat}
    >
      <Ionicons
        name="chatbox-ellipses-outline"
        size={20}
        color={argonTheme.COLORS.ERROR}
      />
    </TouchableOpacity>
  );

  const WalletActionButton = ({ iconName, label, onPress }) => (
    <TouchableOpacity onPress={onPress}>
      <View>
        <View
          style={{
            width: responsiveWidth(20),
            justifyContent: "center",
            alignItems: "center",
          }}
        >
          <View
            style={{
              backgroundColor: argonTheme.COLORS.ERROR,
              height: responsiveWidth(10),
              width: responsiveWidth(10),
              borderRadius: responsiveWidth(10),
              justifyContent: "center",
              alignItems: "center",
            }}
          >
            <Ionicons
              style={{
                color: "white",
                fontSize: responsiveFontSize(2.8),
              }}
              name={iconName}
            />
          </View>
          <View style={{ justifyContent: "center", alignItems: "center" }}>
            <Text
              style={{
                textAlign: "center",
                fontSize: responsiveFontSize(1.7),
              }}
            >
              {label}
            </Text>
          </View>
        </View>
      </View>
    </TouchableOpacity>
  );

  const MenuItem = ({ iconName, label, onPress, borderBottom = true }) => (
    <TouchableOpacity onPress={onPress}>
      <View style={borderBottom ? styles.info_row_border : styles.info_row}>
        <Ionicons name={iconName} color="black" size={20} />
        <Text style={styles.info_row_text}>{label}</Text>
      </View>
    </TouchableOpacity>
  );

  const HomeHeader = () => {
    const [eye, setEye] = useState(false);
    const EyeToggle = () => setEye((currentEye) => !currentEye);

    return (
      <View style={{ position: "absolute", zIndex: 999, width: "100%" }}>
        <View
          className="flex-row justify-center items-center p-2"
          style={{ zIndex: 1000, marginTop: StatusBar.currentHeight }}
          backgroundColor={argonTheme.COLORS.ERROR}
        >
          <SearchButton />
          <NotificationBtn />
          <ChatBoxBtn />
        </View>

        <View style={styles.scollView}>
          <ScrollView
            showsVerticalScrollIndicator={false}
            showsHorizontalScrollIndicator={false}
          >
            <TouchableOpacity
              onPress={() =>
                handleNavigateToNativeScreen(
                  AppConst.ScreenConst.ACCOUNT_SCREEN,
                )
              }
            >
              <View style={styles.info_name_overview}>
                <View style={styles.avatarContainer}>
                  <Image
                    source={avatarSource}
                    style={styles.avatar}
                    resizeMode="contain"
                  />
                </View>

                <View style={styles.info_name_row}>
                  <Text style={styles.info_name_text}>{profileName}</Text>
                  <Text style={styles.info_phone_text}>{profilePhone}</Text>
                </View>
              </View>
            </TouchableOpacity>

            {userInfoData && userInfoData.isAgent ? (
              <View testID="info_overView1" style={styles.simCountTable}>
                <View>
                  <View style={styles.simCountItem}>
                    <Text style={styles.simCountText}>GIÁ TRỊ BẢNG SIM</Text>
                  </View>
                  <View>
                    <Text style={styles.simCountValueText}>
                      {simUserInfo
                        ? ConvertCurrency(simUserInfo.totalPrice)
                        : ""}
                    </Text>
                  </View>
                </View>

                <View style={styles.simCountBetween} />

                <View>
                  <View style={styles.simCountItem}>
                    <Text style={styles.simCountText}>SỐ LƯỢNG SIM</Text>
                  </View>
                  <View>
                    <Text style={styles.simCountValueText}>
                      {simUserInfo ? simUserInfo.totalSim : ""}
                    </Text>
                  </View>
                </View>
              </View>
            ) : null}

            <View testID="info_overView" style={styles.info_overview}>
              <View
                className="flex-row"
                style={{
                  borderBottomColor: "grey",
                  borderBottomWidth: 1,
                  paddingTop: 5,
                  paddingBottom: 10,
                }}
              >
                <View className="flex-1 flex-row">
                  <Text>Số dư ví</Text>
                  <TouchableOpacity onPress={EyeToggle}>
                    <Ionicons
                      style={{
                        marginLeft: 5,
                        color: "black",
                        fontSize: responsiveFontSize(2.8),
                      }}
                      name={eye ? "eye-outline" : "eye-off-outline"}
                    />
                  </TouchableOpacity>
                </View>

                <View style={{ flexDirection: "row" }}>
                  <Text style={{ fontWeight: "bold" }}>
                    {eye ? ConvertCurrency(moneyEscrowData) : "******"}
                  </Text>
                </View>
              </View>

              <View
                style={{
                  justifyContent: "space-between",
                  alignItems: "center",
                  flexDirection: "row",
                  marginLeft: responsiveWidth(7),
                  marginRight: responsiveWidth(7),
                  marginTop: 5,
                }}
              >
                <WalletActionButton
                  iconName="card-outline"
                  label="Nạp tiền"
                  onPress={() =>
                    handleNavigateToNativeScreen(
                      AppConst.ScreenConst.ESCROW_WALLET_PUSH_SCREEN,
                    )
                  }
                />
                <WalletActionButton
                  iconName="download-outline"
                  label="Rút tiền"
                  onPress={() =>
                    handleNavigateToNativeScreen(
                      AppConst.ScreenConst.ESCROW_WALLET_POP_SCREEN,
                    )
                  }
                />
                <WalletActionButton
                  iconName="contract-outline"
                  label="Giao dịch"
                  onPress={() =>
                    handleNavigateToNativeScreen(
                      AppConst.ScreenConst.ESCROW_WALLET_HISTORY_SCREEN,
                    )
                  }
                />
              </View>
            </View>

            <View testID="info_overView" style={styles.info_overview}>
              <MenuItem
                iconName="cart-outline"
                label="Đơn mua"
                onPress={() =>
                  handleNavigateToNativeScreen(
                    AppConst.ScreenConst.ORDER_SCREEN,
                  )
                }
              />
            </View>

            <View testID="info_overView" style={styles.info_overview}>
              <MenuItem
                iconName="person-outline"
                label="Tài khoản"
                onPress={() =>
                  handleNavigateToNativeScreen(
                    AppConst.ScreenConst.ACCOUNT_SCREEN,
                  )
                }
              />
              <MenuItem
                iconName="document-text-outline"
                label="Sim của tôi"
                onPress={handleNavigateToMySim}
              />
            </View>

            <View testID="info_overView" style={styles.info_overview}>
              <MenuItem
                iconName="shield-checkmark-outline"
                label="Chính sách & điều khoản"
                onPress={() =>
                  handleNavigateToNativeScreen(
                    AppConst.ScreenConst.POLICY_SCREEN,
                  )
                }
              />
              <MenuItem
                iconName="document-text-outline"
                label="Hướng dẫn đấu giá"
                onPress={() =>
                  handleNavigateToNativeScreen(
                    AppConst.ScreenConst.AUCTION_MANUAL_SCREEN,
                  )
                }
              />
              <MenuItem
                iconName="newspaper-outline"
                label="Quy định đấu giá"
                onPress={() =>
                  handleNavigateToNativeScreen(
                    AppConst.ScreenConst.AUCTION_RULE_SCREEN,
                  )
                }
              />
              <MenuItem
                iconName="lock-closed-outline"
                label="Đổi mật khẩu"
                onPress={() =>
                  handleNavigateToNativeScreen(
                    AppConst.ScreenConst.CHANGE_PASSWORD,
                  )
                }
                borderBottom={false}
              />
              <TouchableOpacity onPress={ConfirmLogout}>
                <View style={styles.info_row}>
                  <Ionicons name="log-out-outline" color="black" size={20} />
                  <Text style={styles.info_row_text}>Đăng xuất</Text>
                </View>
              </TouchableOpacity>
            </View>
          </ScrollView>
        </View>
      </View>
    );
  };

  return (
    <View style={styles.root}>
      <SafeAreaView style={styles.safeArea}>
        <StatusBar translucent backgroundColor={argonTheme.COLORS.ERROR} />

        <View style={styles.container}>
          <View style={styles.container_header} />
          <HomeHeader />
        </View>
      </SafeAreaView>
    </View>
  );
};

const styles = StyleSheet.create({
  root: {
    flex: 1,
    backgroundColor: argonTheme.COLORS.ERROR,
  },
  safeArea: {
    flex: 1,
    backgroundColor: argonTheme.COLORS.ERROR,
  },
  avatarContainer: {
    backgroundColor: "white",
    borderRadius: 62,
  },
  avatar: {
    width: responsiveHeight(10),
    height: responsiveHeight(10),
    borderRadius: 62,
    borderWidth: 0,
  },
  container: {
    backgroundColor: "#f0eded",
    position: "relative",
    flex: 0,
    height: "100%",
    width: "100%",
  },
  container_header: {
    height: responsiveHeight(30),
    backgroundColor: argonTheme.COLORS.ERROR,
    width: "100%",
    borderBottomRightRadius: 20,
    borderBottomLeftRadius: 20,
  },
  scollView: {
    backgroundColor: "transparent",
    height: responsiveHeight(76),
    margin: 18,
  },
  info_name_overview: {
    flexDirection: "row",
    marginBottom: 10,
  },
  info_name_row: {
    justifyContent: "center",
    marginLeft: 10,
  },
  info_name_text: {
    fontWeight: "bold",
    color: "white",
    fontSize: responsiveFontSize(2.3),
  },
  info_phone_text: {
    fontWeight: "bold",
    color: "white",
    fontSize: responsiveFontSize(2),
  },
  info_overview: {
    backgroundColor: "white",
    borderRadius: 10,
    marginBottom: 10,
    padding: 10,
    shadowColor: "#000",
    shadowOffset: { width: 0, height: 1 },
    shadowOpacity: 0.12,
    shadowRadius: 3,
    elevation: 1,
  },
  info_row: {
    padding: 5,
    flexDirection: "row",
    margin: 5,
  },
  info_row_border: {
    padding: 5,
    margin: 5,
    flexDirection: "row",
    borderBottomColor: "#dbdbdb",
    borderBottomWidth: 1,
  },
  info_row_text: {
    marginLeft: 5,
    fontSize: responsiveFontSize(1.8),
  },
  overview: {
    height: "auto",
    borderRadius: 3,
    padding: 10,
    margin: 4,
    shadowOpacity: 0.1,
    shadowRadius: 3,
    elevation: 1,
    shadowColor: "black",
  },
  textRow: {
    textAlign: "auto",
  },
  texHeader: {
    fontWeight: "bold",
    fontSize: responsiveFontSize(2.2),
  },
  findSim: {
    fontWeight: "bold",
    fontSize: responsiveFontSize(2.4),
    color: argonTheme.COLORS.ERROR,
  },
  emphasizTxt: {
    fontWeight: "bold",
    fontSize: responsiveFontSize(2.1),
    marginLeft: 5,
    marginRight: 5,
  },
  textContent: {
    textAlign: "justify",
    marginLeft: 5,
    marginRight: 5,
    fontSize: responsiveFontSize(2.1),
  },
  textParentContent: {
    textAlign: "justify",
    fontSize: responsiveFontSize(2.1),
  },
  simCountTable: {
    backgroundColor: "white",
    borderRadius: 10,
    marginBottom: 10,
    padding: 20,
    shadowColor: "#000",
    shadowOffset: { width: 0, height: 1 },
    shadowOpacity: 0.1,
    shadowRadius: 3,
    elevation: 1,
    flexDirection: "row",
    alignItems: "center",
    justifyContent: "space-between",
  },
  simCountBetween: {
    width: 1,
    height: responsiveHeight(3),
    backgroundColor: "grey",
  },
  simCountItem: {
    alignItems: "center",
  },
  simCountText: {
    fontWeight: "bold",
    textAlign: "center",
    color: "black",
    fontSize: responsiveFontSize(1.7),
  },
  simCountValueText: {
    fontWeight: "bold",
    textAlign: "center",
    color: "#1090ad",
    fontSize: responsiveFontSize(1.7),
  },
  cellTableTxt: {
    textAlign: "justify",
    fontSize: responsiveFontSize(1.9),
  },
  cellTable: {
    borderWidth: 1,
    borderColor: "black",
    flex: 1,
    alignItems: "center",
    width: 100,
  },
  point: {
    alignItems: "center",
    flex: 1,
    backgroundColor: argonTheme.COLORS.ERROR,
    width: "auto",
    margin: 1,
    marginTop: 20,
    marginBottom: 20,
    padding: 15,
    borderRadius: 10,
  },
  pointTxt: {
    color: "white",
    fontWeight: "bold",
    fontSize: responsiveFontSize(2.2),
  },
  improveSim: {
    alignItems: "center",
    flex: 1,
    backgroundColor: argonTheme.COLORS.ERROR,
    width: "auto",
    margin: 1,
    padding: 15,
    borderRadius: 10,
  },
  bottomSim: {
    flexDirection: "row",
    width: "100%",
    alignItems: "center",
    padding: 5,
    margin: 5,
    justifyContent: "center",
  },
  buttonSim: {
    backgroundColor: "white",
    padding: 5,
    margin: 5,
    borderRadius: 5,
  },
});

export default ProfileOverViewScreen;
