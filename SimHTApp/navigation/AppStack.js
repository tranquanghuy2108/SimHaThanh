import React, { useContext, useEffect } from "react";
import { createBottomTabNavigator } from "@react-navigation/bottom-tabs";
import { createNativeStackNavigator } from "@react-navigation/native-stack";
import { NavigationContainer } from "@react-navigation/native";
import HomeScreen from "../screens/HomeScreen";
import SearchScreen from "../screens/SearchScreen";
import UpdateProfileScreen from "../screens/UpdateProfileScreen";
import ChangePassword from "../screens/ChangePassword";
import { argonTheme } from "../constants";
import { AppConst } from "../constants/AppConst";
import { Image, View } from "react-native";
import { Badge } from "react-native-elements";

import ChatScreen from "../screens/ChatScreen";
import OrderScreen from "../screens/OrderScreen";
import NotificationScreen from "../screens/NotificationScreen";
import NotificationDetailScreen from "../screens/NotificationDetailScreen";
import PostStack from "./PostStack";
import FortuneSimScreen from "../screens/FengShui/FortuneSimScreen";
import FortuneSimDetailScreen from "../screens/FengShui/FortuneSimDetailScreen";
import SearchFengShuiDetailScreen from "../screens/FengShui/SearchFengShuiDetailScreen";
import AboutScreen from "../screens/AboutScreen";
import SimValuationScreen from "../screens/SimValuationScreen";
import CollaborationScreen from "../screens/CollaborationScreen";
import CreateCollaboratorScreen from "../screens/CreateCollaboratorScreen";
import CollabGroupDetailScreen from "../screens/CollabGroupDetailScreen";
import SearchFengShuiScreen from "../screens/FengShui/SearchFengShuiScreen";
import SimCategoryScreen from "../screens/SimCategoryScreen";
import PurchaseSimScreen from "../screens/PurchaseSimScreen";
import PurchaseSimDataScreen from "../screens/PurchaseSimDataScreen";
import InstallmentSearchScreen from "../screens/InstallmentSearchScreen";
import InstallmentManagerScreen from "../screens/InstallmentManagerScreen";
import AutionScreen from "../screens/AutionScreeen";
import VNPT_Package_Screen from "../screens/VNPT_Package_Screen";
import DataPackageScreen from "../screens/DataPackageScreen";
import TouristPackageScreen from "../screens/TouristPackageScreen";
import PackageDetailScreen from "../screens/PackageDetailScreen";
import ProfileOverViewScreen from "../screens/ProfileOverViewScreen";
import PolicyScreeen from "../screens/PolicyScreeen";
import AccountScreen from "../screens/AccountScreen";
import SimDataCategoryScreen from "../screens/SimDataCategoryScreen";
import SimDataSearchScreen from "../screens/SimDataSearchScreen";
import SimDataFilterScreen from "../screens/SimDataFilterScreen";

import MySimScreen from "../screens/MySimScreen";
import { SendBirdContext } from "../context/SendbirdContext";
import AuctionManualScreen from "../screens/AuctionManualScreen";
import AuctionRuleScreen from "../screens/AuctionRuleScreen";
import MyAuctionScreen from "../screens/MyAuctionScreen";
import BidingScreen from "../screens/BidingScreen";
import EscrowWalletPushScreen from "../screens/EscrowWalletPushScreen";
import EscrowWalletPopScreen from "../screens/EscrowWalletPopScreen";
import EscrowWalletHistoryScreen from "../screens/EscrowWalletHistoryScreen";
import EscrowWalletPushManualScreen from "../screens/EscrowWalletPushManualScreen";

import {
  GroupChannelListScreen,
  GroupChannelCreateScreen,
  GroupChannelScreen,
} from "../SendBirdComponents/Fragment";
import { createDrawerNavigator } from "@react-navigation/drawer";
//Bottom Tab Init
const BottomTab = createBottomTabNavigator();
const Stack = createNativeStackNavigator();

const Drawer = createDrawerNavigator();

//
const Drawer_Profile_Overview = createDrawerNavigator();
const Drawer_Order = createDrawerNavigator();
const Drawer_Account = createDrawerNavigator();
const Drawer_AuctionManual = createDrawerNavigator();
const Drawer_AuctionRule = createDrawerNavigator();
const Drawer_Policy = createDrawerNavigator();
const Drawer_My_Auction = createDrawerNavigator();
const Drawer_ChangePassword = createDrawerNavigator();
const Drawer_Feedback = createDrawerNavigator();

//Sim_Data
const Drawer_SimData_Category = createDrawerNavigator();
const Drawer_SimData_Search = createDrawerNavigator();
const Drawer_SimData_Filter = createDrawerNavigator();

//MySim
const Drawer_MySim = createDrawerNavigator();
const Drawer_MySim_Filter = createDrawerNavigator();

//Escrow Wallet
const Drawer_EscrowWallet_Push = createDrawerNavigator();
const Drawer_EscrowWallet_Pop = createDrawerNavigator();
const Drawer_EscrowWallet_History = createDrawerNavigator();

//MySim

//SimData
const DrawerSimDataSearch = () => {
  return (
    <Drawer_SimData_Search.Navigator
      screenOptions={{
        drawerPosition: "right",
        headerShown: false,
        drawerStyle: { width: "100%" },
      }}
      drawerContent={(props) => <SimDataSearchScreen {...props} />}
      id="SIM_DATA_SEARCH"
    >
      <Drawer_SimData_Search.Screen
        options={{
          headerShown: false,
          title: "Đấu giá2",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
          headerBackVisible: false,
          headerTitle: "",
        }}
        name={"AUCTION_1_SCREEN"}
        component={DrawerSimDataFilter}
      />
    </Drawer_SimData_Search.Navigator>
  );
};

const DrawerSimDataFilter = () => {
  return (
    <Drawer_SimData_Filter.Navigator
      screenOptions={{
        drawerPosition: "right",
        headerShown: false,
        drawerStyle: { width: "70%" },
      }}
      drawerContent={(props) => <SimDataFilterScreen {...props} />}
      id="SIM_DATA_FILTER"
    >
      <Drawer_SimData_Filter.Screen
        options={{
          headerShown: false,
          title: "Đấu giá2",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
          headerBackVisible: false,
          headerTitle: "",
        }}
        name={"AUCTION_1_SCREEN"}
        component={SimDataSearchScreen}
      />
    </Drawer_SimData_Filter.Navigator>
  );
};

//
const DrawerProfileOverView = () => {
  return (
    <Drawer_Profile_Overview.Navigator
      screenOptions={{
        drawerPosition: "right",
        headerShown: false,
        drawerStyle: { width: "100%" },
      }}
      drawerContent={(props) => <ProfileOverViewScreen {...props} />}
      id="PROFILE_OVERVIEW"
    >
      <Drawer_Profile_Overview.Screen
        options={{
          headerShown: false,
          title: "Đấu giá2",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
          headerBackVisible: false,
          headerTitle: "",
        }}
        name={AppConst.ScreenConst.HOME_SCREEN}
        component={DrawerAccount}
      />
      <Drawer_Profile_Overview.Screen
        options={{
          headerShown: false,
          title: "Đấu giá2",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
          headerBackVisible: false,
          headerTitle: "",
        }}
        name={AppConst.ScreenConst.MY_SIM_SCREEN}
        component={DrawerMySim}
      />
    </Drawer_Profile_Overview.Navigator>
  );
};

const DrawerAccount = () => {
  return (
    <Drawer_Account.Navigator
      screenOptions={{
        drawerPosition: "right",
        headerShown: false,
        drawerStyle: { width: "100%" },
      }}
      drawerContent={(props) => <AccountScreen {...props} />}
      id="ACCOUNT"
    >
      <Drawer_Account.Screen
        options={{
          headerShown: false,
          title: "Đấu giá2",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
          headerBackVisible: false,
          headerTitle: "",
        }}
        name={"AUCTION_1_SCREEN"}
        component={DrawerAuctionManual}
      />
    </Drawer_Account.Navigator>
  );
};
const DrawerAuctionManual = () => {
  return (
    <Drawer_AuctionManual.Navigator
      screenOptions={{
        drawerPosition: "right",
        headerShown: false,
        drawerStyle: { width: "100%" },
      }}
      drawerContent={(props) => (
        <AuctionManualScreen {...props} isDrawer={true} />
      )}
      id="AUCTION_MANUAL"
    >
      <Drawer_AuctionManual.Screen
        options={{
          headerShown: false,
          title: "Đấu giá2",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
          headerBackVisible: false,
          headerTitle: "",
        }}
        name={"AUCTION_1_SCREEN"}
        component={DrawerAuctionRule}
      />
    </Drawer_AuctionManual.Navigator>
  );
};

const DrawerAuctionRule = () => {
  return (
    <Drawer_AuctionRule.Navigator
      screenOptions={{
        drawerPosition: "right",
        headerShown: false,
        drawerStyle: { width: "100%" },
      }}
      drawerContent={(props) => <AuctionRuleScreen {...props} />}
      id="AUCTION_RULE"
    >
      <Drawer_AuctionRule.Screen
        options={{
          headerShown: false,
          title: "Đấu giá2",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
          headerBackVisible: false,
          headerTitle: "",
        }}
        name={"AUCTION_1_SCREEN"}
        component={DrawerChangePassword}
      />
    </Drawer_AuctionRule.Navigator>
  );
};
const DrawerChangePassword = () => {
  return (
    <Drawer_ChangePassword.Navigator
      screenOptions={{
        drawerPosition: "right",
        headerShown: false,
        drawerStyle: { width: "100%" },
      }}
      drawerContent={(props) => <ChangePassword {...props} />}
      id="CHANGE_PASSWORD"
    >
      <Drawer_ChangePassword.Screen
        options={{
          headerShown: false,
          title: "Đấu giá2",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
          headerBackVisible: false,
          headerTitle: "",
        }}
        name={"AUCTION_1_SCREEN"}
        component={DrawerPolicy}
      />
    </Drawer_ChangePassword.Navigator>
  );
};
const DrawerPolicy = () => {
  return (
    <Drawer_Policy.Navigator
      screenOptions={{
        drawerPosition: "right",
        headerShown: false,
        drawerStyle: { width: "100%" },
      }}
      drawerContent={(props) => <PolicyScreeen {...props} />}
      id="POLICY"
    >
      <Drawer_Policy.Screen
        options={{
          headerShown: false,
          title: "Đấu giá2",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
          headerBackVisible: false,
          headerTitle: "",
        }}
        name={"AUCTION_1_SCREEN"}
        component={DrawerMyAuction}
      />
    </Drawer_Policy.Navigator>
  );
};
const DrawerMyAuction = () => {
  return (
    <Drawer_My_Auction.Navigator
      screenOptions={{
        drawerPosition: "right",
        headerShown: false,
        drawerStyle: { width: "100%" },
      }}
      drawerContent={(props) => <MyAuctionScreen {...props} isDrawer={true} />}
      id="MY_AUCTION"
    >
      <Drawer_My_Auction.Screen
        options={{
          headerShown: false,
          title: "Đấu giá2",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
          headerBackVisible: false,
          headerTitle: "",
        }}
        name={"AUCTION_1_SCREEN"}
        component={DrawerOrder}
      />
    </Drawer_My_Auction.Navigator>
  );
};

const DrawerMySim = () => {
  return (
    <Drawer_MySim.Navigator
      screenOptions={{
        drawerPosition: "right",
        headerShown: false,
        drawerStyle: { width: "100%" },
      }}
      drawerContent={(props) => <MySimScreen {...props} />}
      id="MY_SIM"
    >
      <Drawer_MySim.Screen
        options={{
          headerShown: false,
          title: "Đấu giá2",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
          headerBackVisible: false,
          headerTitle: "",
        }}
        name={"AUCTION_1_SCREEN"}
        component={DrawerMySimFilter}
      />
    </Drawer_MySim.Navigator>
  );
};

//

const DrawerMySimFilter = () => {
  return (
    <Drawer_MySim_Filter.Navigator
      screenOptions={{
        drawerPosition: "right",
        headerShown: false,
        drawerStyle: { width: "100%" },
      }}
      drawerContent={(props) => <SimDataFilterScreen {...props} />}
      id="MY_SIM_FILTER"
    >
      <Drawer_MySim_Filter.Screen
        options={{
          headerShown: false,
          title: "Đấu giá2",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
          headerBackVisible: false,
          headerTitle: "",
        }}
        name={AppConst.ScreenConst.MY_SIM_SCREEN}
        component={MySimScreen}
      />
    </Drawer_MySim_Filter.Navigator>
  );
};

//

const DrawerOrder = () => {
  return (
    <Drawer_Order.Navigator
      screenOptions={{
        drawerPosition: "right",
        headerShown: false,
        drawerStyle: { width: "100%" },
      }}
      drawerContent={(props) => <OrderScreen {...props} isDrawer={true} />}
      id="ORDER"
    >
      <Drawer_Order.Screen
        options={{
          headerShown: false,
          title: "Đấu giá2",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
          headerBackVisible: false,
          headerTitle: "",
        }}
        name={"AUCTION_1_SCREEN"}
        component={DrawerEscrowWalletPush}
      />
    </Drawer_Order.Navigator>
  );
};

//EscrowWallet

const DrawerEscrowWalletPush = () => {
  return (
    <Drawer_EscrowWallet_Push.Navigator
      screenOptions={{
        drawerPosition: "right",
        headerShown: false,
        drawerStyle: { width: "100%" },
      }}
      drawerContent={(props) => <EscrowWalletPushScreen {...props} />}
      id="ESCROW_WALLET_PUSH"
    >
      <Drawer_EscrowWallet_Push.Screen
        options={{
          headerShown: false,
          title: "Đấu giá2",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
          headerBackVisible: false,
          headerTitle: "",
        }}
        name={"AUCTION_1_SCREEN"}
        component={DrawerEscrowWalletPop}
      />
    </Drawer_EscrowWallet_Push.Navigator>
  );
};

const DrawerEscrowWalletPop = () => {
  return (
    <Drawer_EscrowWallet_Pop.Navigator
      screenOptions={{
        drawerPosition: "right",
        headerShown: false,
        drawerStyle: { width: "100%" },
      }}
      drawerContent={(props) => <EscrowWalletPopScreen {...props} />}
      id="ESCROW_WALLET_POP"
    >
      <Drawer_EscrowWallet_Pop.Screen
        options={{
          headerShown: false,
          title: "Đấu giá2",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
          headerBackVisible: false,
          headerTitle: "",
        }}
        name={"AUCTION_1_SCREEN"}
        component={DrawerEscrowWalletHistory}
      />
    </Drawer_EscrowWallet_Pop.Navigator>
  );
};
const DrawerEscrowWalletHistory = () => {
  return (
    <Drawer_EscrowWallet_History.Navigator
      screenOptions={{
        drawerPosition: "right",
        headerShown: false,
        drawerStyle: { width: "100%" },
      }}
      drawerContent={(props) => (
        <EscrowWalletHistoryScreen {...props} isDrawer={true} />
      )}
      id="ESCROW_WALLET_HISTORY"
    >
      <Drawer_EscrowWallet_History.Screen
        options={{
          headerShown: false,
          title: "Đấu giá2",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
          headerBackVisible: false,
          headerTitle: "",
        }}
        name={"ESCROW_HISTORY_SCREEN"}
        component={ProfileOverViewScreen}
      />
    </Drawer_EscrowWallet_History.Navigator>
  );
};

//
const HomeBottomScreen = () => {
  return (
    <Stack.Navigator>
      <Stack.Screen
        name={AppConst.ScreenConst.HOME_SCREEN}
        component={HomeScreen}
        options={{
          headerShown: false,
          title: AppConst.ScreenConst.HOME_SCREEN,
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
      <Stack.Screen
        name={AppConst.ScreenConst.SIM_CATEGORY_SCREEN}
        component={SimCategoryScreen}
        options={{
          headerShown: false,
          title: AppConst.ScreenConst.SIM_CATEGORY_SCREEN,
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
          headerBackVisible: false,
          headerTitle: "",
        }} // Đặt headerShown thành true
      />
      <Stack.Screen
        name={AppConst.ScreenConst.SIM_DATA_CATEGORY_SCREEN}
        component={SimDataCategoryScreen}
        options={{
          headerShown: false,
          title: "Thư mục Tìm kiếm",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
      <Stack.Screen
        name={AppConst.ScreenConst.SIM_DATA_SEARCH_SCREEN}
        component={DrawerSimDataSearch}
        options={{
          headerShown: false,
          title: "Thư mục Tìm kiếm",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
    </Stack.Navigator>
  );
};

const AuctionFilterStack = () => {
  return (
    <Drawer.Navigator
      screenOptions={{ drawerPosition: "right", headerShown: false }}
    >
      <Drawer.Screen
        name={AppConst.ScreenConst.AUTION_SCREEN}
        component={AutionScreen}
      />
    </Drawer.Navigator>
  );
};

const BottomStack = () => {
  const { GetUnreadMessageCount, unReadMessageCount, RegisterChatReceiver } =
    useContext(SendBirdContext);

  return (
    <BottomTab.Navigator
      style={{ height: 200 }}
      initialRouteName={AppConst.ScreenConst.HOME_SCREEN}
      screenOptions={({ route }) => ({
        headerShown: false,
        tabBarStyle: { padding: 10, height: 50 },
        tabBarActiveTintColor: argonTheme.COLORS.ERROR,
        tabBarInactiveTintColor: "grey",
        tabBarLabelStyle: {
          paddingBottom: 5,
          fontSize: 10,
          fontWeight: "bold",
        },

        tabBarIcon: ({ focused, color, size }) => {
          let iconImg;
          let rn = route.name;
          let fillColor;

          if (rn === AppConst.ScreenConst.HOME_SCREEN) {
            iconImg = AppConst.IconConst.ICON_HOME;

            fillColor = focused ? argonTheme.COLORS.ERROR : "#4e5858";
          } else if (rn === AppConst.ScreenConst.SEARCH_SCREEN) {
            iconImg = AppConst.IconConst.ICON_SEARCH;

            fillColor = focused ? argonTheme.COLORS.ERROR : "#4e5858";
          } else if (rn === AppConst.ScreenConst.MARKET_SCREEN) {
            iconImg = AppConst.IconConst.ICON_SIM;
            fillColor = focused ? argonTheme.COLORS.ERROR : "#4e5858";
          } else if (rn === AppConst.ScreenConst.CHAT_SCREEN) {
            iconImg = AppConst.IconConst.ICON_CHAT;
            fillColor = focused ? argonTheme.COLORS.ERROR : "#4e5858";
          } else if (rn === AppConst.ScreenConst.PROFILE_SCREEN) {
            iconImg = AppConst.IconConst.ICON_PROFILE;
            fillColor = focused ? argonTheme.COLORS.ERROR : "#1d2222";
          } else if (rn === AppConst.ScreenConst.ORDER_SCREEN) {
            iconImg = AppConst.IconConst.ICON_MARKET;
            fillColor = focused ? argonTheme.COLORS.ERROR : "#4e5858";
          }

          // You can return any component that you like here!
          // return <Ionicons name={iconName} size={size} color={color} />;
          return (
            <View>
              <Image
                source={iconImg}
                style={{ width: 17, height: 17 }}
                tintColor={fillColor}
                resizeMode="contain"
              />
              {iconImg == AppConst.IconConst.ICON_CHAT &&
              unReadMessageCount > 0 ? (
                <Badge
                  status="error"
                  containerStyle={{ position: "absolute", top: -2, right: -2 }}
                />
              ) : null}
            </View>
          );
        },
      })}
    >
      <BottomTab.Screen
        name={AppConst.BottomScreenConst.HOME_BOTTOM_SCREEN}
        component={HomeBottomScreen}
      />

      <BottomTab.Screen
        name={AppConst.ScreenConst.SEARCH_SCREEN}
        component={SearchScreen}
      />
      <BottomTab.Screen
        name={AppConst.ScreenConst.MARKET_SCREEN}
        component={PostStack}
      />
      <BottomTab.Screen
        name={AppConst.ScreenConst.CHAT_SCREEN}
        component={ChatScreen}
        initialParams={{ isDrawer: false }}
      />
      <BottomTab.Screen
        name={AppConst.BottomScreenConst.PROFILE_BOTTOM_SCREEN}
        component={DrawerProfileOverView}
      />
    </BottomTab.Navigator>
  );
};

const NativeStack = () => {
  return (
    <Stack.Navigator screenOptions={{ headerShown: false }}>
      <Stack.Screen
        name={AppConst.ScreenConst.CHANGE_PASSWORD}
        component={ChangePassword}
      />
      <Stack.Screen
        name={AppConst.ScreenConst.UPDATE_PROFILE_SCREEN}
        component={UpdateProfileScreen}
      />
      <Stack.Screen
        name={AppConst.ScreenConst.ORDER_SCREEN}
        component={OrderScreen}
        initialParams={{ isDrawer: false }}
      />

      <Stack.Screen
        name={AppConst.ScreenConst.PURCHASE_SIM}
        component={PurchaseSimScreen}
        options={{
          headerShown: true,
          title: "Chi Tiết Sim",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }}
      />

      <Stack.Screen
        name={AppConst.ScreenConst.PURCHASE_SIMDATA}
        component={PurchaseSimDataScreen}
        options={{
          headerShown: true,
          title: "Đặt sim data",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }}
      />

      <Stack.Screen
        name={AppConst.ScreenConst.BIDING}
        component={BidingScreen}
        options={{
          headerShown: true,
          title: "Đấu Giá Xuôi",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }}
      />

      <Stack.Screen
        name={AppConst.ScreenConst.NOTIFICATION_SCREEN}
        component={NotificationScreen}
        options={{
          headerShown: false,
          title: "Thông Báo",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
      <Stack.Screen
        name={AppConst.ScreenConst.NOTIFICATION_DETAIL_SCREEN}
        component={NotificationDetailScreen}
        options={{
          headerShown: true,
          title: "Nội dung",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />

      {/* Bói Sim */}
      <Stack.Screen
        name={AppConst.ScreenConst.FORTUNE_SIM_SCREEN}
        component={FortuneSimScreen}
        options={{
          headerShown: true,
          title: "Bói Sim Phong Thủy",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
      <Stack.Screen
        name={AppConst.ScreenConst.FORTUNE_SIM_DETAIL_SCREEN}
        component={FortuneSimDetailScreen}
        options={{
          headerShown: true,
          title: "Phong Thủy Sim",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
      {/* Tìm Sim Phong Thủy */}
      <Stack.Screen
        name={AppConst.ScreenConst.SEARCH_FORTUNE_SIM_DETAIL_SCREEN}
        component={SearchFengShuiDetailScreen}
        options={{
          headerShown: true,
          title: "Tìm Sim Phong Thủy",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
      <Stack.Screen
        name={AppConst.ScreenConst.SEARCH_FENGSHUI_SCREEN}
        component={SearchFengShuiScreen}
        options={{
          headerShown: true,
          title: "Tìm SIM Phong Thủy",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />

      <Stack.Screen
        name={AppConst.ScreenConst.ABOUT_SCREEN}
        component={AboutScreen}
        options={{ headerShown: true, title: "Giới Thiệu" }} // Đặt headerShown thành true
      />
      <Stack.Screen
        name={AppConst.ScreenConst.SIM_VALUATION_SCREEN}
        component={SimValuationScreen}
        options={{
          headerShown: true,
          title: "Định Giá SIM",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
      <Stack.Screen
        name={AppConst.ScreenConst.COLLABORATION_SCREEN}
        component={CollaborationScreen}
        options={{
          headerShown: true,
          title: "Quản Lý Cộng Tác Viên",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
      <Stack.Screen
        name={AppConst.ScreenConst.CREATE_COLLABORATION_SCREEN}
        component={CreateCollaboratorScreen}
        options={{
          headerShown: true,
          title: "Tạo Nhóm Cộng Tác Viên",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
      <Stack.Screen
        name={AppConst.ScreenConst.COLLAB_GROUP_SCREEN}
        component={CollabGroupDetailScreen}
        options={{
          headerShown: false,
          title: "Xem Chi Tiết",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
      <Stack.Screen
        name={AppConst.ScreenConst.INSTALLMENT_SEARCH_SCREEN}
        component={InstallmentSearchScreen}
        options={{
          headerShown: true,
          title: "Dự Toán Trả Góp",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
      <Stack.Screen
        name={AppConst.ScreenConst.INSTALLMENT_MANGER_SCREEN}
        component={InstallmentManagerScreen}
        options={{
          headerShown: true,
          title: "Quản Lý Trả Góp",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
      <Stack.Screen
        name={AppConst.ScreenConst.AUTION_SCREEN}
        component={AuctionFilterStack}
        options={{
          headerShown: false,
          title: "Đấu giá",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
      <Stack.Screen
        name={AppConst.ScreenConst.MY_AUCTION_SCREEN}
        component={MyAuctionScreen}
        initialParams={{ isDrawer: false }}
        options={{
          headerShown: false,
          title: "Đấu giá của tôi",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }}
      />
      <Stack.Screen
        name={AppConst.ScreenConst.VNPT_PACKAGE_SCREEN}
        component={VNPT_Package_Screen}
        options={{
          headerShown: true,
          title: "Đăng ký gói cước Vinaphone",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }}
      />
      <Stack.Screen
        name={AppConst.ScreenConst.DATA_PACKAGE_SCREEN}
        component={DataPackageScreen}
        options={{
          headerShown: false,
          title: "Gói cước data",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }}
      />
      <Stack.Screen
        name={AppConst.ScreenConst.SIM_DATA_CATEGORY_SCREEN}
        component={SimDataCategoryScreen}
        options={{
          headerShown: false,
          title: "",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
      <Stack.Screen
        name={AppConst.ScreenConst.TOURIST_PACKAGE_SCREEN}
        component={TouristPackageScreen}
        options={{
          headerShown: true,
          title: "Gói sim du lịch",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
      <Stack.Screen
        name={AppConst.ScreenConst.PACKAGE_DETAIL_SCREEN}
        component={PackageDetailScreen}
        options={{
          headerShown: true,
          title: "Chi tiết gói cước",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
      <Stack.Screen
        name={AppConst.ScreenConst.ESCROW_PUSH_MANUAL}
        component={EscrowWalletPushManualScreen}
        options={{
          headerShown: false,
          title: "",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
      <Stack.Screen
        name={"EscrowWalletHistoryScreen"}
        component={EscrowWalletHistoryScreen}
        initialParams={{ isDrawer: false }}
        options={{
          headerShown: false,
          title: "",
          headerStyle: { backgroundColor: argonTheme.COLORS.ERROR },
          headerTintColor: "white",
        }} // Đặt headerShown thành true
      />
    </Stack.Navigator>
  );
};

const MainStack = () => {
  return (
    <Stack.Navigator screenOptions={{ headerShown: false }}>
      <Stack.Screen
        name={AppConst.StackConst.BOTTOM_STACK}
        component={BottomStack}
      />
      <Stack.Screen
        name={AppConst.StackConst.NATIVE_STACK}
        component={NativeStack}
      />
      <Stack.Screen
        name={AppConst.ScreenConst.GROUP_CHANNEL_LIST}
        component={GroupChannelListScreen}
      />
      <Stack.Screen
        name={AppConst.ScreenConst.GROUP_CHANNEL_CREATE}
        component={GroupChannelCreateScreen}
      />
      <Stack.Screen
        name={AppConst.ScreenConst.GROUP_CHANNEL}
        component={GroupChannelScreen}
      />
    </Stack.Navigator>
  );
};

const AppStack = () => {
  return (
    <NavigationContainer>
      <MainStack />
    </NavigationContainer>
  );
};
export default AppStack;
