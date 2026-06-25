import React, { useContext, useRef } from "react";
import {
  Dimensions,
  ScrollView,
  TouchableOpacity,
  View,
  TextInput,
  Alert,
} from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
// Galio components
import { Checkbox, Text } from "galio-framework";
import { Button } from "../components";
// Argon themed components
import { argonTheme } from "../constants";
import Ionicons from "react-native-vector-icons/Ionicons";
import { SimDataContext } from "../context/SimDataContext";

import { AppConst } from "../constants/AppConst";
import { BottomTabContext } from "../context/BottomTabContext";
import SimDataEmphasizFitler from "../customComponents/SimDataEmphasizFitler";
import {
  responsiveHeight,
  responsiveWidth,
  responsiveFontSize,
} from "react-native-responsive-dimensions";
import Config from "../constants/Config";
import SendBird from "sendbird";
import { AuthContext } from "../context/AuthContext";

const ConvertCurrency = (numberString) => {
  const formattedNumber = parseInt(numberString, 10).toLocaleString("vi-VN", {
    style: "currency",
    currency: "VND",
  });
  return formattedNumber;
};

const SimDataSearchScreen = (props) => {
  const { search, searchPaging } = useContext(SimDataContext);
  const { searchResult, countryData } = useContext(SimDataContext);
  const { userInfos } = useContext(AuthContext);
  const isFetchingRef = useRef(false);

  const SearchButton = () => {
    const { searchDataKey, SetDataKeySearch } = useContext(BottomTabContext);

    const handleInputChange = (text) => {
      SetDataKeySearch(text);
    };
    const handleInputSubmit = async () => {
      search(searchDataKey, null);
    };
    const handleBlur = () => {
      search(searchDataKey, null);
    };

    //Filter-Subscription

    return (
      <TouchableOpacity className="flex-1" activeOpacity={0.9}>
        <View className="flex-row flex-0 items-center rounded-full bg-white mx-1">
          <View className="bg-transparent rounded-full m-3">
            <Ionicons name="search-outline" color="black" size={20}></Ionicons>
          </View>
          <TextInput
            placeholder="Tìm SIM Data"
            placeholderTextColor={"gray"}
            className="flex-1 text-base p-1 tracking-wider"
            returnKeyType="search"
            keyboardType="phone-pad"
            editable={true}
            onChangeText={handleInputChange}
            value={searchDataKey}
            onSubmitEditing={handleInputSubmit}
            onBlur={handleBlur}
          />
        </View>
      </TouchableOpacity>
    );
  };

  const FilterButton = () => {
    return (
      // Nút Lọc
      <TouchableOpacity
        className="p-2 bg-transparent flex-row justify-center items-center"
        style={{
          borderTopLeftRadius: 15,
          borderTopRightRadius: 15,
          borderBottomLeftRadius: 15,
          borderBottomRightRadius: 15,
        }}
        onPress={() => {
          props.navigation.getParent("SIM_DATA_FILTER").openDrawer();
        }}
      >
        <Ionicons name="funnel-outline" color="white" size={30}></Ionicons>
        <Text
          className="text-bold"
          style={{ color: "#1183d2", fontSize: 18, fontWeight: "bold" }}
        ></Text>
      </TouchableOpacity>
    );
  };
  const ExitButton = () => {
    return (
      // Nút Thoát
      <TouchableOpacity
        className="p-1 rounded-full bg-white mx-1"
        onPress={() => {
          props.navigation.goBack();
        }}
      >
        <Ionicons
          name="chevron-back-outline"
          color="black"
          size={26}
        ></Ionicons>
      </TouchableOpacity>
    );
  };

  const SearchHeader = () => {
    return (
      <View
        className="flex-row justify-center items-center p-2"
        backgroundColor={argonTheme.COLORS.ERROR}
      >
        <ExitButton />
        <SearchButton className="flex-start" />

        <FilterButton className="flex-end" />
      </View>
    );
  };
  //

  const ConfirmOrder = (simData) => {
    Alert.alert(
      "Bạn có muốn hỏi sim trước khi đặt mua?",
      "",
      [
        { text: "Trở về" },
        {
          text: "Hỏi Sim",
          onPress: () => {
            AskSimHandle();
          },
        },
        {
          text: "Đặt mua",
          onPress: () => {
            OrderHandle(simData);
          },
        },
      ],
      {
        cancelable: false,
      },
    );
  };
  const AskSimHandle = () => {
    const sb = new SendBird({ appId: Config.SEND_BIRD_APP_ID });
    sb.connect(userInfos.id, (user, error) => {
      if (error) {
        console.error("Error connecting to Sendbird:", error);
      } else {
        var userId1 = userInfos.id;
        var userId2 = Config.SEND_BIRD_SUPPORT_ID;
        const params = new sb.GroupChannelParams();
        params.isDistinct = true; // Tạo một kênh duy nhất cho hai người dùng
        params.addUserIds([userId1, userId2]);

        sb.GroupChannel.createChannel(params, (groupChannel, error) => {
          if (error) {
            console.error("Error creating group channel:", error);
          } else {
            const channelUrl = groupChannel.url;
            // groupChannel.sendUserMessage('Bạn có muốn?', (message, error) => {
            //     if (error) {
            //         console.error('Error sending pre-message:', error);
            //     } else {
            //         navigation.navigate(AppConst.ScreenConst.GROUP_CHANNEL, { channelUrl: channelUrl });
            //     }
            // });
            props.navigation.navigate(AppConst.ScreenConst.GROUP_CHANNEL, {
              channelUrl: channelUrl,
            });
          }
        });
      }
    });
  };

  const GetCountryName = (itemCountryID) => {
    if (itemCountryID != null) {
      if (countryData != null && countryData.length > 0) {
        var countryItems = countryData.filter(
          (x) => x.id == parseInt(item.countryId),
        );
        var countryName = countryItems[0].name;
        return countryName;
      } else {
        return "";
      }
    } else {
      return "";
    }
  };
  const OrderHandle = (item) => {
    // openPopup(item)
    var simDataParam = {
      id: item.id,
      phoneNumber: item.simNumber,
      networkID: "",
      networkName: item.network,
      isSaleActive: false,
      price: item.simPrice,
      priceOnSale: null,
      simDataPackageType: item.productType,
      simDataPackageCountry: GetCountryName(item.countryId),
    };
    props.navigation.push(AppConst.StackConst.NATIVE_STACK, {
      screen: AppConst.ScreenConst.PURCHASE_SIM,
      params: { simDataParam: simDataParam },
    });
  };
  //

  const SearchResult = ({ item }) => {
    return (
      <View className="">
        {searchResult &&
          searchResult.map((item) => {
            return (
              <View className="flex-row bg-white border-b border-stone-300">
                <View className="ml-3 items-left justify-center">
                  <Checkbox color="warning" />
                </View>
                <View className="flex-1 ml-5 my-1 items-left justify-center">
                  <View className="flex-row">
                    <View style={{ flex: 1 }}>
                      <Text
                        className="font-bold text-sm pt-2"
                        selectable={true}
                        style={{ fontSize: responsiveFontSize(2.5) }}
                      >
                        {item.simNumber}
                      </Text>
                    </View>
                    <View style={{}}>
                      <Text
                        className="font-bold text-sm mx-2"
                        style={{ fontSize: responsiveFontSize(2) }}
                      >
                        {ConvertCurrency(item.simPrice)}
                      </Text>
                    </View>
                  </View>

                  <View className="flex-row">
                    <View style={{ flex: 1, justifyContent: "center" }}>
                      <Text
                        className="text-xs"
                        style={{ fontSize: responsiveFontSize(2) }}
                      >
                        {item.network}
                      </Text>
                    </View>
                    <View className="flex-row mx-2">
                      <View
                        style={{
                          borderRadius: 5,
                          backgroundColor: argonTheme.COLORS.ERROR,
                          height: responsiveHeight(5),
                          width: responsiveWidth(22),
                          justifyContent: "center",
                          alignItems: "center",
                        }}
                      >
                        <TouchableOpacity
                          onPress={() => {
                            OrderHandle(item);
                          }}
                        >
                          <Text
                            style={{
                              fontSize: responsiveFontSize(1.9),
                              color: "white",
                              fontWeight: "bold",
                            }}
                          >
                            Đặt Mua
                          </Text>
                        </TouchableOpacity>
                      </View>
                    </View>
                  </View>
                </View>
              </View>
            );
          })}
      </View>
    );
  };
  const NoResultData = () => {
    return (
      <View className="items-center mt-5">
        <Text className="font-bold">Không có dữ liệu!</Text>
      </View>
    );
  };
  return (
    <SafeAreaView>
      <SearchHeader />
      <SimDataEmphasizFitler />

      <ScrollView
        style={{ marginBottom: responsiveHeight(14) }}
        scrollEventThrottle={16}
        onScroll={({ nativeEvent }) => {
          const { layoutMeasurement, contentOffset, contentSize } = nativeEvent;
          const isEndReached =
            contentOffset.y + layoutMeasurement.height >=
            contentSize.height - 20; // small threshold
          if (isEndReached) {
            console.log("reach end");
            if (
              !isFetchingRef.current &&
              searchResult &&
              searchResult.length > 0 &&
              searchResult[0].nextID != 0
            ) {
              isFetchingRef.current = true;
              try {
                searchPaging();
              } finally {
                // prevent double-calls for a short window while paging happens
                setTimeout(() => {
                  isFetchingRef.current = false;
                }, 1000);
              }
            }
          }
        }}
      >
        {searchResult && searchResult.length > 0 ? (
          <SearchResult />
        ) : (
          <NoResultData />
        )}
      </ScrollView>
    </SafeAreaView>
  );
};

export default SimDataSearchScreen;
