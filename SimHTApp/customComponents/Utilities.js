import React, { useMemo, useContext } from "react";
import MasonryList from "@react-native-seoul/masonry-list";
import { TouchableOpacity, View, Image, Text } from "react-native";
import { AppConst } from "../constants/AppConst";
import { AuthContext } from "../context/AuthContext";
import { BottomTabContext } from "../context/BottomTabContext";
import { CollaboratorContext } from "../context/CollaboratorContext";
import { useLoginRequired } from "../context/LoginRequiredContext";
const Utilities = (props) => {
  const { configData, GetConfigData } = useContext(AuthContext);
  const isPublish = configData?.isPublish ?? false;
  const filteredData = useMemo(() => {
    const rawData = [
      {
        id: "1",
        description: "Sim Số",
        type: AppConst.UltilitiType.SIM_CATEGORY,
        image: require("../assets/imgs/icon_simcategory.png"),
        // Không có requiresPublish -> Luôn hiển thị
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
      {
        id: "6",
        description: "Quản lý CTV",
        type: AppConst.UltilitiType.COLLABORATION,
        image: require("../assets/imgs/icon_collaboration.png"),
      },
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
      {
        id: "12",
        description: "Đấu giá",
        type: AppConst.UltilitiType.AUTION,
        image: require("../assets/imgs/icon_auction.png"),
      },
    ];

    // 2. Lọc mảng
    return rawData.filter((item) => {
      if (isPublish === true) {
        return true;
      }
      return !item.requiresPublish;
    });
  }, [isPublish]);
  return (
    <View className="mx-">
      <View style={{ flex: 1 }}>
        <MasonryList
          data={filteredData}
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
  const { requireLogin } = useLoginRequired();
  const { userInfoData } = useContext(AuthContext);
  const { GetUserInfo } = useContext(AuthContext);
  const { toggleCollabPopUp } = useContext(BottomTabContext);
  const { groupHadJoinDatas, GetGroupHadJoin } = useContext(CollaboratorContext);

  const publicUtilityTypes = [
    AppConst.UltilitiType.SIM_CATEGORY,
    AppConst.UltilitiType.SIM_FORTUNE,
    AppConst.UltilitiType.SEARCH_FENGSHUI,
    AppConst.UltilitiType.SIM_VALUATION,
    AppConst.UltilitiType.DATA_PACKAGE,
    AppConst.UltilitiType.TOURIST_PACKAGE,
    AppConst.UltilitiType.ABOUT,
  ];

  const handlePress = () => {
    if (prop.data.type === AppConst.UltilitiType.COLLABORATION) {
      GetUserInfo();
      GetGroupHadJoin();
    }

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
            if (userInfoData.isAgent) {
              prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
                screen: AppConst.ScreenConst.COLLABORATION_SCREEN,
              });
            } else {
              prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
                screen: AppConst.ScreenConst.COLLAB_GROUP_SCREEN,
                params: { item: groupHadJoinDatas[0] },
              });
            }
          } else {
            toggleCollabPopUp();
          }
        }
        break;
      case AppConst.UltilitiType.ABOUT:
        prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
          screen: AppConst.ScreenConst.ABOUT_SCREEN,
        });
        break;
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
      case AppConst.UltilitiType.AUTION:
        prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
          screen: AppConst.ScreenConst.AUTION_SCREEN,
        });
        break;
      case AppConst.UltilitiType.VNPT_PACKAGE:
        prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
          screen: AppConst.ScreenConst.VNPT_PACKAGE_SCREEN,
        });
        break;
      case AppConst.UltilitiType.DATA_PACKAGE:
        prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
          screen: AppConst.ScreenConst.DATA_PACKAGE_SCREEN,
        });
        break;
      case AppConst.UltilitiType.TOURIST_PACKAGE:
        prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, {
          screen: AppConst.ScreenConst.TOURIST_PACKAGE_SCREEN,
        });
        break;
    }
  };

  return (
    <TouchableOpacity
      className="flex items-center"
      style={{
        marginHorizontal: 3,
        marginVertical: 5,
        height: 92,
      }}
      onPress={() => {
        if (publicUtilityTypes.includes(prop.data.type)) handlePress();
        else requireLogin(handlePress);
      }}
    >
      <Image
        source={prop.data.image}
        className=""
        style={{
          width: 48,
          height: 48,
        }}
      />
      <Text
        className="text-center"
        style={{ fontSize: 12, lineHeight: 16, fontWeight: "500" }}
      >
        {prop.data.description}
      </Text>
    </TouchableOpacity>
  );
};
