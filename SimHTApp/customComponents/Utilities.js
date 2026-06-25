import React, { useContext } from "react";
import MasonryList from "@react-native-seoul/masonry-list";
import { TouchableOpacity, View, Image, Text } from "react-native";
import { AppConst } from "../constants/AppConst";
import { AuthContext } from "../context/AuthContext";
import {
  responsiveScreenHeight,
  responsiveScreenWidth,
  responsiveScreenFontSize,
  responsiveFontSize,
} from "react-native-responsive-dimensions";
import { BottomTabContext } from "../context/BottomTabContext";
import { CollaboratorContext } from "../context/CollaboratorContext";
const Utilities = (props) => {
  const data = [
    {
      id: "1",
      description: "Sim Số",
      type: AppConst.UltilitiType.SIM_CATEGORY,
      image: require("../assets/imgs/icon_simcategory.png"),
    },
    {
      id: "14",
      description: "Sim Data",
      type: AppConst.UltilitiType.DATA_PACKAGE,
      image: require("../assets/imgs/icon_about.png"),
    },
    {
      id: "15",
      description: "Sim Du lịch",
      type: AppConst.UltilitiType.TOURIST_PACKAGE,
      image: require("../assets/imgs/icon_contact.png"),
    },
    {
      id: "13",
      description: "Gói cước Vinaphone",
      type: AppConst.UltilitiType.VNPT_PACKAGE,
      image: require("../assets/imgs/icon_orders.png"),
    },
    {
      id: "2",
      description: "Tìm SIM phong thủy",
      type: AppConst.UltilitiType.SEARCH_FENGSHUI,
      image: require("../assets/imgs/icon_searchSim.png"),
    },
    {
      id: "3",
      description: "Bói SIM phong thủy",
      type: AppConst.UltilitiType.SIM_FORTUNE,
      image: require("../assets/imgs/icon_fortune.png"),
    },
    {
      id: "4",
      description: "Định giá SIM",
      type: AppConst.UltilitiType.SIM_VALUATION,
      image: require("../assets/imgs/icon_valuation.png"),
    },
    // { id: '5', description: 'Nâng cấp VIP', type: AppConst.UltilitiType.SIM_CATEGORY, image: require('../assets/imgs/icon_upgradeVip.png') },
    {
      id: "6",
      description: "Quản lý CTV",
      type: AppConst.UltilitiType.COLLABORATION,
      image: require("../assets/imgs/icon_collaboration.png"),
    },
    // { id: '7', description: 'Danh bạ GDH', type: AppConst.UltilitiType.SIM_CATEGORY, image: require('../assets/imgs/icon_contact.png') },
    // { id: '8', description: 'Đơn hàng', type: AppConst.UltilitiType.ORDER, image: require('../assets/imgs/icon_orders.png') },
    {
      id: "9",
      description: "Dự toán trả góp",
      type: AppConst.UltilitiType.INSTALLMENT_SEARCH,
      image: require("../assets/imgs/icon_installment_estimate.png"),
    },
    {
      id: "10",
      description: "Quản lý trả góp",
      type: AppConst.UltilitiType.INSTALLMENT_MANAGER,
      image: require("../assets/imgs/icon_installment_manager.png"),
    },
    // { id: '11', description: 'Giới thiệu', type: AppConst.UltilitiType.ABOUT, image: require('../assets/imgs/icon_about.png') },
    {
      id: "12",
      description: "Đấu giá",
      type: AppConst.UltilitiType.AUTION,
      image: require("../assets/imgs/icon_auction.png"),
    },
  ];
  return (
    <View className="mx-">
      <View style={{ flex: 1 }}>
        <MasonryList
          data={data}
          numColumns={5}
          renderItem={({ item }) => (
            <UtilitiCard data={item} pathProp={props.navi} />
          )}
          columnWrapperStyle={{ justifyContent: "space-between" }}
          contentContainerStyle={{ paddingVertical: 25 }}
        />
      </View>
    </View>
  );
};

export default Utilities;

const UtilitiCard = (prop) => {
  const { userInfos, userInfoData } = useContext(AuthContext);
  const { GetUserInfo } = useContext(AuthContext);
  const { toggleCollabPopUp } = useContext(BottomTabContext);
  const { myGroupOwnDatas, groupHadJoinDatas } =
    useContext(CollaboratorContext);
  const { GetGroupHadJoin, GetMyGroupOwn } = useContext(CollaboratorContext);
  return (
    <TouchableOpacity
      className="flex items-center"
      style={{
        margin: responsiveScreenWidth(1),
        height: responsiveScreenHeight(12),
      }}
      onPress={() => {
        GetUserInfo();
        GetGroupHadJoin();
        switch (prop.data.type) {
          //Danh mục sim
          case AppConst.UltilitiType.SIM_CATEGORY:
            prop.pathProp.navigate(AppConst.StackConst.BOTTOM_STACK, {
              screen: AppConst.BottomScreenConst.HOME_BOTTOM_SCREEN,
              params: { screen: AppConst.ScreenConst.SIM_CATEGORY_SCREEN },
            });
            break;
          //Đơn mua
          case AppConst.UltilitiType.ORDER:
            prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
              screen: AppConst.ScreenConst.ORDER_SCREEN,
            });
            break;
          //Bói Sim
          case AppConst.UltilitiType.SIM_FORTUNE:
            prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
              screen: AppConst.ScreenConst.FORTUNE_SIM_SCREEN,
            });
            break;
          //Tìm Sim Phong Thủy
          case AppConst.UltilitiType.SEARCH_FENGSHUI:
            prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
              screen: AppConst.ScreenConst.SEARCH_FENGSHUI_SCREEN,
            });
            break;
          //Định giá Sim
          case AppConst.UltilitiType.SIM_VALUATION:
            prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
              screen: AppConst.ScreenConst.SIM_VALUATION_SCREEN,
            });
            break;
          //Quản lý CTV
          case AppConst.UltilitiType.COLLABORATION:
            if (userInfoData != null) {
              if (userInfoData.discount) {
                //Đại lý
                if (userInfoData.isAgent) {
                  prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
                    screen: AppConst.ScreenConst.COLLABORATION_SCREEN,
                  });
                }
                //CTV
                else if (!userInfoData.isAgent) {
                  prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
                    screen: AppConst.ScreenConst.COLLAB_GROUP_SCREEN,
                    params: { item: groupHadJoinDatas[0] }, //Truyền nhóm mà CTV tham gia
                  });
                }
              } else {
                toggleCollabPopUp(); // Hiện Popup Hướng dẫn đăng ký CTV
              }
            }
            break;
          //About
          case AppConst.UltilitiType.ABOUT:
            prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
              screen: AppConst.ScreenConst.ABOUT_SCREEN,
            });
            break;
          //Trả góp
          case AppConst.UltilitiType.INSTALLMENT_SEARCH:
            prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
              screen: AppConst.ScreenConst.INSTALLMENT_SEARCH_SCREEN,
            });
            break;
          case AppConst.UltilitiType.INSTALLMENT_MANAGER:
            prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
              screen: AppConst.ScreenConst.INSTALLMENT_MANGER_SCREEN,
            });
            break;
          //Đấu giá
          case AppConst.UltilitiType.AUTION:
            prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
              screen: AppConst.ScreenConst.AUTION_SCREEN,
            });
            break;
          //Gói cước Vina
          case AppConst.UltilitiType.VNPT_PACKAGE:
            prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
              screen: AppConst.ScreenConst.VNPT_PACKAGE_SCREEN,
            });
            break;
          //Sim Data
          case AppConst.UltilitiType.DATA_PACKAGE:
            prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
              screen: AppConst.ScreenConst.DATA_PACKAGE_SCREEN,
              //screen: AppConst.ScreenConst.SIM_DATA_CATEGORY_SCREEN,
            });
            break;
          //Sim Du lịch
          case AppConst.UltilitiType.TOURIST_PACKAGE:
            prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
              screen: AppConst.ScreenConst.TOURIST_PACKAGE_SCREEN,
            });
            break;
        }
      }}
    >
      <Image
        source={prop.data.image}
        className=""
        style={{
          width: responsiveScreenWidth(13.5),
          height: responsiveScreenHeight(7),
        }}
      />
      <Text
        className="text-center"
        style={{ fontSize: responsiveFontSize(1.5) }}
      >
        {prop.data.description}
      </Text>
    </TouchableOpacity>
  );
};
