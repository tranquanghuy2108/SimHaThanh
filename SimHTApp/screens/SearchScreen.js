import React, { useEffect, useContext, useState, useRef } from "react";
import {
  Dimensions,
  ScrollView,
  StyleSheet,
  TouchableOpacity,
  View,
  TextInput,
  FlatList,
  Animated,
  TouchableWithoutFeedback,
  Alert,
} from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
import AsyncStorage from "@react-native-async-storage/async-storage";
import SendBird from "sendbird";
// Galio components
import { Checkbox, Text } from "galio-framework";
// Argon themed components
import { argonTheme } from "../constants";
import Ionicons from "react-native-vector-icons/Ionicons";
import { SearchContext } from "../context/SearchContext";

import { AppConst } from "../constants/AppConst";
const { width, height } = Dimensions.get("screen");
import { FilterContext } from "../context/FilterContext";
import { StatusBar } from "expo-status-bar";
import LoadingScreen from "./LoadingScreen";
import { SetLoadingContext } from "../context/SetLoadingContext";
import { BottomTabContext } from "../context/BottomTabContext";
import { Dropdown } from "react-native-element-dropdown";
import { HomeContext } from "../context/HomeContext";
import NetWorkCard from "../customComponents/NetworkCard";
import HeaderNumberCard from "../customComponents/HeaderNumberCard";
import AvoidNumberCard from "../customComponents/AvoidNumberCard";
import SubscriptionNumberCard from "../customComponents/SubscriptionNumberCard";
import SimNetWorkAtCategory from "../customComponents/SimNetWorkAtCategory";
import SpecialSimAtCategory from "../customComponents/SpecialSimAtCategory";
import SimAsPricesAtCategory from "../customComponents/SimAsPricesAtCategory";
import Config from "../constants/Config";
import {
  responsiveHeight,
  responsiveWidth,
  responsiveFontSize,
} from "react-native-responsive-dimensions";
import { AuthContext } from "../context/AuthContext";

const ConvertCurrency = (numberString) => {
  const formattedNumber = parseInt(numberString, 10).toLocaleString("vi-VN", {
    style: "currency",
    currency: "VND",
  });
  const convertedNumber = formattedNumber.replace("₫", "VND");
  return convertedNumber;
};

const ConvertCurrencyNumber = (numberString) => {
  if (isNaN(parseInt(numberString))) {
    return "";
  } else {
    const number = parseInt(numberString.replace(/\D/g, ""), 10);
    const formattedNumber = number.toLocaleString("vi-VN");
    return formattedNumber;
  }
};
const ReverseCurrencyNumber = (formattedNumber) => {
  const numberString = formattedNumber.replace(/\D/g, "");
  const number = parseInt(numberString, 10);
  return number.toString();
};

export default SearchScreen = ({ navigation, route }) => {
  const { userInfos } = useContext(AuthContext);
  const [currentFrame, SetCurrentFrame] = useState("");

  useEffect(() => {
    const unsubscribe = navigation.addListener("focus", () => {
      if (route.params && route.params.screenParam) {
        const { screenParam } = route.params;
        if (screenParam == AppConst.SearchFrameConst.IS_HOMESEARCH) {
          SetCurrentFrame(AppConst.SearchFrameConst.IS_INSTRUCTION);
        } else if (screenParam == AppConst.SearchFrameConst.IS_CATEGORY) {
          SetCurrentFrame(AppConst.SearchFrameConst.IS_CATEGORY);
        } else if (screenParam == AppConst.SearchFrameConst.IS_RESULT) {
          SetCurrentFrame(AppConst.SearchFrameConst.IS_RESULT);
        }
      } else {
        SetCurrentFrame(AppConst.SearchFrameConst.IS_INSTRUCTION);

        // setTimeout(() => {
        //   SetCurrentFrame(AppConst.SearchFrameConst.IS_RECENT);
        // }, 1000);
      }
      navigation.setParams({ screenParam: null });
    });

    return unsubscribe;
  }, [route]);

  const textInputRef = useRef(null);

  const {
    SetSortBy,
    search,
    searchPaging,
    ResetSearchFilter,
    DeleteAllFilter,
  } = useContext(SearchContext);
  const {
    avoidNumberTypes,
    keyWord,
    price,
    isAvoidSixDigit,
    prefixTypes,
    networkTypes,
    searchResult,
    subscriptionTypes,
    simTypes,
    sortType,
    isDeleteAllFilter,
  } = useContext(SearchContext);
  const { isLoading, SetLoading } = useContext(SetLoadingContext);
  const [activeButton, setActiveButton] = useState(null);
  const [selectedNetwork, setSelectedNetwork] = useState(null);
  const [selectedPriceRange, setSelectedPriceRange] = useState(null);
  const [isFilter, setFilter] = useState(false);
  const { isFilterVisible, setFilterState } = useContext(FilterContext);

  useEffect(() => {
    if (sortType == 0) {
      handleButtonPress("highlight");
    } else if (sortType == 1) {
      handleButtonPress("lowPrice");
    } else if (sortType == 2) {
      handleButtonPress("highPrice");
    }
  }, [sortType]);

  const handleInputFocus = () => {
    // Giữ nguyên màn hướng dẫn khi người dùng vừa chạm vào ô input.
    // Chỉ chuyển sang IS_RECENT khi người dùng bấm CTA "Nhập số sim".
    SetCurrentFrame(AppConst.SearchFrameConst.IS_RECENT);
    setTimeout(() => {
      textInputRef?.current?.focus?.();
    }, 50);
  };
  const handleInputBlur = () => {};
  const handleClickCategoryButton = () => {
    navigation.navigate(AppConst.StackConst.BOTTOM_STACK, {
      screen: AppConst.BottomScreenConst.HOME_BOTTOM_SCREEN,
      params: { screen: AppConst.ScreenConst.SIM_CATEGORY_SCREEN },
    });
  };

  const handleButtonPress = (buttonName) => {
    setActiveButton(buttonName);
  };
  const handleFilterHighPrice = () => {
    setUpdateSortBy(Config.SEARCH_SIM_SORT_TYPE.HIGH_PRICE);
    searchFilter(
      updatedNetworkArray,
      value,
      priceFrom,
      priceTo,
      updatedSubscriptionArray,
      updatedAvoidNumber,
      updatedHeaderNumber,
      avoidSixDigits,
      Config.SEARCH_SIM_SORT_TYPE.HIGH_PRICE,
    );
  };
  const handleFilterLowPrice = () => {
    setUpdateSortBy(Config.SEARCH_SIM_SORT_TYPE.LOW_PRICE);
    searchFilter(
      updatedNetworkArray,
      value,
      priceFrom,
      priceTo,
      updatedSubscriptionArray,
      updatedAvoidNumber,
      updatedHeaderNumber,
      avoidSixDigits,
      Config.SEARCH_SIM_SORT_TYPE.LOW_PRICE,
    );
  };
  const handleEmphasis = () => {
    setUpdateSortBy(Config.SEARCH_SIM_SORT_TYPE.NORMAL);
    searchFilter(
      updatedNetworkArray,
      value,
      priceFrom,
      priceTo,
      updatedSubscriptionArray,
      updatedAvoidNumber,
      updatedHeaderNumber,
      avoidSixDigits,
      Config.SEARCH_SIM_SORT_TYPE.NORMAL,
    );
  };
  //Filter-NetWork
  const CheckActiveTickNetWork = (index) => {
    if (networkTypes.includes(index)) {
      return true;
    } else {
      return false;
    }
  };
  //Filter-Subscription
  const CheckActiveTickScription = (index) => {
    if (subscriptionTypes.includes(index)) {
      return true;
    } else {
      return false;
    }
  };
  //Filter-HeaderNumber
  const CheckActiveTickHeader = (index) => {
    if (prefixTypes.includes(index)) {
      return true;
    } else {
      return false;
    }
  };
  //Filter-Avoid

  const CheckActiveTickAvoid = (index) => {
    if (avoidNumberTypes.includes(index)) {
      return true;
    } else {
      return false;
    }
  };

  const netWorkNames = [
    {
      name: "Viettel",
      id: 1,
      image: require("../assets/imgs/icon_viettel.png"),
    },
    {
      name: "Vinaphone",
      id: 2,
      image: require("../assets/imgs/icon_vinaphone.png"),
    },
    {
      name: "Mobiphone",
      id: 3,
      image: require("../assets/imgs/icon_mobifone.png"),
    },
    {
      name: "VietNamobile",
      id: 4,
      image: require("../assets/imgs/icon_vietnamobile.png"),
    },
    {
      name: "Gmobile",
      id: 5,
      image: require("../assets/imgs/icon_gMobile.png"),
    },
    { name: "iTel", id: 6, image: require("../assets/imgs/icon_itel.png") },
    // { name: 'Wintel', id: 7, image: require('../assets/imgs/icon_viettel.png') },
  ];
  const headerNumbers = [
    {
      name: "09",
      id: 1,
      value: "*09",
      image: require("../assets/imgs/icon_viettel.png"),
    },
    {
      name: "03",
      id: 2,
      value: "*03",
      image: require("../assets/imgs/icon_vinaphone.png"),
    },
    {
      name: "05",
      id: 3,
      value: "*05",
      image: require("../assets/imgs/icon_mobifone.png"),
    },
    {
      name: "07",
      id: 4,
      value: "*07",
      image: require("../assets/imgs/icon_vietnamobile.png"),
    },
    {
      name: "08",
      id: 5,
      value: "*08",
      image: require("../assets/imgs/icon_gMobile.png"),
    },
  ];
  const avoidNumbers = [
    { name: "0", id: 1 },
    { name: "1", id: 2 },
    { name: "2", id: 3 },
    { name: "3", id: 4 },
    { name: "4", id: 5 },
    { name: "5", id: 6 },
    { name: "6", id: 7 },
    { name: "7", id: 8 },
    { name: "8", id: 9 },
    { name: "9", id: 10 },
  ];
  const subscriptionNumbers = [
    { name: "Trả trước", id: 1 },
    { name: "Trả sau", id: 2 },
    { name: "Trước cam kết", id: 3 },
    { name: "Sau cam kết", id: 4 },
  ];

  const FILTER_POPUP_NETWORK = "FILTER_POPUP_NETWORK";
  const FILTER_POPUP_CATEGORY = "FILTER_POPUP_CATEGORY";
  const FILTER_POPUP_SUBSCRIPTION = "FILTER_POPUP_SUBSCRIPTION";
  const FILTER_POPUP_PRICES = "FILTER_POPUP_PRICES";
  const FILTER_POPUP_HEADER = "FILTER_POPUP_HEADER";
  const FILTER_POPUP_AVOID = "FILTER_POPUP_AVOID";

  const SearchInstruction = () => {
    return (
      <View>
        <Text
          className="font-semibold text-neutral-1000 p-1 mx-2"
          style={{ fontSize: 17 }}
        >
          TÌM KIẾM SIM
        </Text>
        <View className="mx-1">
          <View className="flex-row mx-1">
            <Text style={{ fontSize: 10 }} className="p-1">
              🔵
            </Text>
            <Text
              className="font-semibold text-neutral-500"
              style={{ fontSize: 16 }}
            >
              Tìm sim có số 6789 bạn hãy gõ 6789
            </Text>
          </View>
          <View className="flex-row mx-1">
            <Text style={{ fontSize: 10 }} className="p-1">
              🔵
            </Text>
            <Text
              className="font-semibold text-neutral-500 "
              style={{ fontSize: 16 }}
            >
              Tìm sim có đầu 090 đuôi 8888 hãy gõ 090*8888
            </Text>
          </View>
          <View className="flex-row mx-1">
            <Text style={{ fontSize: 10 }} className="p-1">
              🔵
            </Text>
            <Text
              className="font-semibold text-neutral-500"
              style={{ fontSize: 16 }}
            >
              Tìm sim bắt đầu bằng 0914 đuôi bất kì, hãy gõ: 0914*
            </Text>
          </View>
        </View>
      </View>
    );
  };

  const SearchHeader = () => {
    return (
      <View
        className="flex-row justify-center items-center p-2"
        backgroundColor={argonTheme.COLORS.ERROR}
      >
        <SearchButton className="flex-start" />

        {
          currentFrame == AppConst.SearchFrameConst.IS_RESULT ? (
            <FilterButton className="flex-end" />
          ) : null
          // <ExitButton />
        }
      </View>
    );
  };
  const { SetKeyWord } = useContext(SearchContext);

  const SearchButton = () => {
    const { currentSearchKey, SetCurrentSearch } = useContext(BottomTabContext);

    const handleInputChange = (text) => {
      SetCurrentSearch(text);
    };
    const handleInputSubmit = async () => {
      SetCurrentFrame(AppConst.SearchFrameConst.IS_RESULT);
      search(currentSearchKey, null, null, null);
      if (currentSearchKey != "") {
        try {
          let storedSearchHistory = await AsyncStorage.getItem("SearchHistory");
          if (storedSearchHistory === null) {
            storedSearchHistory = [];
          } else {
            storedSearchHistory = JSON.parse(storedSearchHistory);
          }

          const updatedSearchHistory = [
            currentSearchKey,
            ...storedSearchHistory,
          ];

          await AsyncStorage.setItem(
            "SearchHistory",
            JSON.stringify(updatedSearchHistory),
          );
        } catch (error) {
          console.error("Error saving search history:", error);
        }
      }
    };

    return (
      <TouchableOpacity
        className="flex-1"
        activeOpacity={0.9}
        onPress={() => {
          handleInputFocus();
        }}
      >
        <View className="flex-row flex-0 items-center rounded-full bg-white mx-1">
          <View className="bg-transparent rounded-full m-3">
            <Ionicons name="search-outline" color="black" size={20}></Ionicons>
          </View>
          <TextInput
            ref={textInputRef}
            placeholder="Tìm SIM trên App"
            placeholderTextColor={"gray"}
            className="flex-1 text-base p-1 tracking-wider"
            returnKeyType="search"
            keyboardType="phone-pad"
            editable={true}
            onChangeText={handleInputChange}
            value={currentSearchKey}
            onSubmitEditing={handleInputSubmit}
            onFocus={handleInputFocus}
            onBlur={handleInputBlur}
            onPress={() => {
              SetCurrentFrame(AppConst.SearchFrameConst.IS_RECENT);
              setTimeout(() => {
                textInputRef?.current?.focus?.();
              }, 50);
            }}
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
          handlePress();
          SetFilterPopup("");
        }}
      >
        {/* <Image source={require('../assets/imgs/btn_filler.png')} style={{ height: 23, width: 23 }} resizeMode="contain" /> */}
        <Ionicons name="funnel-outline" color="white" size={30}></Ionicons>
        <Text
          className="text-bold"
          style={{ color: "#1183d2", fontSize: 18, fontWeight: "bold" }}
        ></Text>
      </TouchableOpacity>
    );
  };
  const PriceEmphasis = () => {
    return (
      <TouchableOpacity
        style={[
          styles.button,
          activeButton === "highlight" && styles.activeButton,
        ]}
        className="flex-1 ml-7"
        onPress={() => {
          handleButtonPress("highlight");
          handleEmphasis();
        }}
      >
        <Text
          style={[
            styles.buttonText,
            activeButton === "highlight" && styles.activeText,
          ]}
        >
          Nổi bật
        </Text>
      </TouchableOpacity>
    );
  };
  const PriceLow = () => {
    return (
      <TouchableOpacity
        style={[
          styles.button,
          activeButton === "lowPrice" && styles.activeButton,
        ]}
        className="flex-1"
        onPress={() => {
          handleButtonPress("lowPrice");
          handleFilterLowPrice();
        }}
      >
        <Text
          style={[
            styles.buttonText,
            activeButton === "lowPrice" && styles.activeText,
          ]}
        >
          Giá thấp
        </Text>
      </TouchableOpacity>
    );
  };
  const PriceHigh = () => {
    return (
      <TouchableOpacity
        style={[
          styles.button,
          activeButton === "highPrice" && styles.activeButton,
        ]}
        onPress={() => {
          handleButtonPress("highPrice");
          handleFilterHighPrice();
        }}
        className="flex-1"
      >
        <Text
          style={[
            styles.buttonText,
            activeButton === "highPrice" && styles.activeText,
          ]}
        >
          Giá cao
        </Text>
      </TouchableOpacity>
    );
  };
  const PriceFilter = () => {
    return (
      <View className="flex-row justify-center items-center border-b border-stone-300">
        <Checkbox
          className="mx-3"
          color="warning"
          style={{ width: 2, height: 5 }}
        />
        <PriceEmphasis />
        <PriceLow />
        <PriceHigh />
      </View>
    );
  };

  function convertToCurrency(number) {
    if (number >= 1000000000) {
      const billion = (number / 1000000000).toLocaleString(undefined, {
        minimumFractionDigits: 0,
        maximumFractionDigits: 2,
      });
      return billion + "T";
    } else if (number >= 1000000) {
      const million = (number / 1000000).toLocaleString(undefined, {
        minimumFractionDigits: 0,
        maximumFractionDigits: 2,
      });
      return million + "tr";
    } else if (number >= 1000) {
      const formattedNumber = (number / 1000).toLocaleString(undefined, {
        minimumFractionDigits: 0,
        maximumFractionDigits: 2,
      });
      return formattedNumber + "k";
    } else {
      return number.toString();
    }
  }

  const NetworkFilter = (prop) => {
    const { SetCurrentSearch } = useContext(BottomTabContext);
    return !isDeleteAllFilter &&
      (value != null ||
        priceTo > 0 ||
        updatedNetworkArray.length > 0 ||
        updatedSubscriptionArray.length > 0 ||
        updatedHeaderNumber.length > 0 ||
        updatedAvoidNumber.length > 0) ? (
      <View className="border-b border-stone-300 py-2 px-2">
        <ScrollView horizontal showsHorizontalScrollIndicator={false}>
          {value != null ||
          priceTo > 0 ||
          updatedNetworkArray.length > 0 ||
          updatedSubscriptionArray.length > 0 ||
          updatedHeaderNumber.length > 0 ||
          updatedAvoidNumber.length > 0 ? (
            <View>
              <TouchableOpacity
                style={[styles.card, { backgroundColor: "white" }]}
                className="bg-white rounded-xl mx-1 justify-center items-center"
                onPress={() => {
                  if (currentFilterPopUp === "") {
                    DeleteAllFilter();
                    setActiveButton(null);
                    SetCurrentSearch("");
                    ResetSearchFilter();
                  } else {
                    SetFilterPopup("");
                  }
                }}
              >
                <Text>
                  <Text
                    style={[
                      { color: argonTheme.COLORS.ERROR },
                      styles.filterText,
                    ]}
                    className="font-bold"
                  >
                    Xóa Lọc
                  </Text>
                </Text>
              </TouchableOpacity>
            </View>
          ) : null}

          {priceTo > 0 && (
            <View>
              <TouchableOpacity
                style={[
                  styles.card,
                  {
                    backgroundColor:
                      currentFilterPopUp === FILTER_POPUP_PRICES
                        ? "#e0dcdc"
                        : "white",
                  },
                ]}
                className="bg-white rounded-xl mx-1 justify-center items-center"
                onPress={() => {
                  if (currentFilterPopUp === "") {
                    SetFilterPopup(FILTER_POPUP_PRICES);
                  } else {
                    SetFilterPopup("");
                  }
                }}
              >
                <Text>
                  <Text style={styles.filterText}>
                    {convertToCurrency(priceFrom)}
                  </Text>

                  <Text style={styles.filterText}> - </Text>
                  <Text style={styles.filterText}>
                    {convertToCurrency(priceTo)}
                  </Text>
                  <Ionicons
                    name="chevron-down-outline"
                    color="black"
                    size={responsiveFontSize(2)}
                  ></Ionicons>
                </Text>
              </TouchableOpacity>
            </View>
          )}

          {updatedSubscriptionArray.length > 0 && (
            <View>
              <TouchableOpacity
                style={[
                  styles.card,
                  {
                    backgroundColor:
                      currentFilterPopUp === FILTER_POPUP_SUBSCRIPTION
                        ? "#e0dcdc"
                        : "white",
                  },
                ]}
                className="bg-white rounded-xl mx-1 justify-center items-center"
                onPress={() => {
                  if (currentFilterPopUp === "") {
                    SetFilterPopup(FILTER_POPUP_SUBSCRIPTION);
                  } else {
                    SetFilterPopup("");
                  }
                }}
              >
                <Text>
                  <Text style={styles.filterText}>
                    Thuê bao ({updatedSubscriptionArray.length})
                  </Text>
                  <Ionicons
                    name="chevron-down-outline"
                    color="black"
                    size={responsiveFontSize(2)}
                  ></Ionicons>
                </Text>
              </TouchableOpacity>
            </View>
          )}
          {updatedHeaderNumber.length > 0 && (
            <View>
              <TouchableOpacity
                style={[
                  styles.card,
                  {
                    backgroundColor:
                      currentFilterPopUp === FILTER_POPUP_HEADER
                        ? "#e0dcdc"
                        : "white",
                  },
                ]}
                className="bg-white rounded-xl mx-1 justify-center items-center"
                onPress={() => {
                  if (currentFilterPopUp === "") {
                    SetFilterPopup(FILTER_POPUP_HEADER);
                  } else {
                    SetFilterPopup("");
                  }
                }}
              >
                <Text>
                  <Text style={styles.filterText}>
                    Đầu số ({updatedHeaderNumber.length})
                  </Text>
                  <Ionicons
                    name="chevron-down-outline"
                    color="black"
                    size={responsiveFontSize(2)}
                  ></Ionicons>
                </Text>
              </TouchableOpacity>
            </View>
          )}
          {updatedAvoidNumber.length > 0 && (
            <View>
              <TouchableOpacity
                style={[
                  styles.card,
                  {
                    backgroundColor:
                      currentFilterPopUp === FILTER_POPUP_AVOID
                        ? "#e0dcdc"
                        : "white",
                  },
                ]}
                className="bg-white rounded-xl mx-1 justify-center items-center"
                onPress={() => {
                  if (currentFilterPopUp === "") {
                    SetFilterPopup(FILTER_POPUP_AVOID);
                  } else {
                    SetFilterPopup("");
                  }
                }}
              >
                <Text>
                  <Text style={styles.filterText}>
                    Tránh ({updatedAvoidNumber.length})
                  </Text>
                  <Ionicons
                    name="chevron-down-outline"
                    color="black"
                    size={responsiveFontSize(2)}
                  ></Ionicons>
                </Text>
              </TouchableOpacity>
            </View>
          )}

          {value && (
            <View>
              <TouchableOpacity
                style={[
                  styles.card,
                  {
                    backgroundColor:
                      currentFilterPopUp === FILTER_POPUP_CATEGORY
                        ? "#e0dcdc"
                        : "white",
                  },
                ]}
                className="bg-white rounded-xl mx-1 justify-center items-center"
                onPress={() => {
                  if (currentFilterPopUp === "") {
                    SetFilterPopup(FILTER_POPUP_CATEGORY);
                  } else {
                    SetFilterPopup("");
                  }
                }}
              >
                <Text>
                  <Text style={styles.filterText}>
                    {
                      (
                        simTypeDatas.find((x) => x.id == value) || {
                          name: "Tất cả",
                        }
                      ).name
                    }
                  </Text>
                  <Ionicons
                    name="chevron-down-outline"
                    color="black"
                    size={responsiveFontSize(2)}
                  ></Ionicons>
                </Text>
              </TouchableOpacity>
            </View>
          )}

          {updatedNetworkArray.length > 0 ? (
            <View>
              <TouchableOpacity
                style={[
                  styles.card,
                  {
                    backgroundColor:
                      currentFilterPopUp === FILTER_POPUP_NETWORK
                        ? "#e0dcdc"
                        : "white",
                  },
                ]}
                className="bg-white rounded-xl mx-1 justify-center items-center"
                onPress={() => {
                  if (currentFilterPopUp === "") {
                    SetFilterPopup(FILTER_POPUP_NETWORK);
                  } else {
                    SetFilterPopup("");
                  }
                }}
              >
                <Text>
                  <Text style={styles.filterText}>
                    Mạng ({convertToCurrency(updatedNetworkArray.length)})
                  </Text>
                  <Ionicons
                    name="chevron-down-outline"
                    color="black"
                    size={responsiveFontSize(2)}
                  ></Ionicons>
                </Text>
              </TouchableOpacity>
            </View>
          ) : null}
        </ScrollView>
      </View>
    ) : null;
  };
  const SimCateGory = () => {
    return (
      <ScrollView>
        <View className="bg-stone-100 ">
          <SimNetWorkAtCategory navi={navigation} route={route} />
          <SimAsPricesAtCategory navi={navigation} route={route} />
          <SpecialSimAtCategory navi={navigation} route={route} />
        </View>
      </ScrollView>
    );
  };
  const NoResultData = () => {
    return (
      <View className="items-center mt-5">
        <Text className="font-bold">Không có dữ liệu!</Text>
      </View>
    );
  };
  const ConvertCurrency = (numberString) => {
    const formattedNumber = parseInt(numberString, 10).toLocaleString("vi-VN", {
      style: "currency",
      currency: "VND",
    });
    return formattedNumber;
  };

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
            navigation.navigate(AppConst.ScreenConst.GROUP_CHANNEL, {
              channelUrl: channelUrl,
            });
          }
        });
      }
    });
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
    };

    navigation.push(AppConst.StackConst.NATIVE_STACK, {
      screen: AppConst.ScreenConst.PURCHASE_SIM,
      params: { simDataParam: simDataParam },
    });
  };

  const SearchResult = () => {
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
  const SearchRecent = () => {
    const [searchHistory, setSearchHistory] = useState([]);
    useEffect(() => {
      const getSearchHistory = async () => {
        try {
          const storedSearchHistory =
            await AsyncStorage.getItem("SearchHistory");
          if (storedSearchHistory) {
            setSearchHistory(JSON.parse(storedSearchHistory));
          }
        } catch (error) {
          console.error("Error getting search history:", error);
        }
      };
      getSearchHistory();
    }, []);
    const clearSearchHistory = async (keyword) => {
      try {
        const storedSearchHistory = await AsyncStorage.getItem("SearchHistory");
        if (storedSearchHistory) {
          const parsedSearchHistory = JSON.parse(storedSearchHistory);
          const updatedSearchHistory = parsedSearchHistory.filter(
            (item) => item !== keyword,
          );
          await AsyncStorage.setItem(
            "SearchHistory",
            JSON.stringify(updatedSearchHistory),
          );
          setSearchHistory(updatedSearchHistory);
        }
      } catch (error) {
        console.error("Error clearing search history:", error);
      }
    };
    const { SetCurrentSearch } = useContext(BottomTabContext);
    return (
      <View className="mx-6 my-4">
        <TouchableOpacity
          className="flex-row justify-start items-center"
          onPress={() => {
            handleClickCategoryButton();
          }}
        >
          <Ionicons className="flex-0 mr-2" name="list-outline" size={18} />
          <Text className="" style={{ fontSize: 17 }}>
            Danh mục sim
          </Text>
        </TouchableOpacity>

        <FlatList
          data={searchHistory}
          className="mt-3"
          renderItem={({ item }) => (
            <View className="flex-row items-center justify-center mt-2">
              <View className="">
                <TouchableOpacity
                  className="flex-row justify-center items-center"
                  onPress={() => {
                    SetCurrentFrame(AppConst.SearchFrameConst.IS_RESULT);
                    search(item, null, null, null);
                    SetCurrentSearch(item);
                  }}
                >
                  <Ionicons
                    className="flex-0 mr-2"
                    name="timer-outline"
                    size={17}
                  />
                  <Text className="" style={{ fontSize: 16 }}>
                    {item}
                  </Text>
                </TouchableOpacity>
              </View>
              <View className="flex-grow" />
              <View className="mx-4 ">
                <TouchableOpacity
                  className="flex-row justify-center items-center"
                  onPress={() => {
                    clearSearchHistory(item);
                  }}
                >
                  <Ionicons
                    className="flex-0 mr-1"
                    name="trash-outline"
                    size={17}
                  />
                </TouchableOpacity>
              </View>
            </View>
          )}
          keyExtractor={(item, index) => index.toString()}
        />
      </View>
    );
  };
  //Filter
  const [isExpanded, setIsExpanded] = useState(false);
  const [animation] = useState(new Animated.Value(0));

  //Filter-NetWork

  const [updatedNetworkArray, SetUpdateNetWorkArray] = useState([]);

  useEffect(() => {}, [updatedNetworkArray]);

  useEffect(() => {
    SetUpdateNetWorkArray(networkTypes);
  }, [networkTypes]);

  //Filter-Subscription

  const [updatedSubscriptionArray, SetUpdateSubscriptionArray] = useState([]);

  useEffect(() => {}, [updatedSubscriptionArray]);

  useEffect(() => {
    SetUpdateSubscriptionArray(subscriptionTypes);
  }, [subscriptionTypes]);

  //Filter-HeaderNumber
  const [updatedHeaderNumber, SetUpdateHeaderArray] = useState([]);

  useEffect(() => {}, [updatedHeaderNumber]);

  useEffect(() => {
    SetUpdateHeaderArray(prefixTypes);
  }, [prefixTypes]);

  //Filter - Avoid

  const [updatedAvoidNumber, SetUpdateAvoidArray] = useState([]);

  useEffect(() => {}, [updatedAvoidNumber]);

  useEffect(() => {
    SetUpdateAvoidArray(avoidNumberTypes);
  }, [avoidNumberTypes]);

  //Filter - IsSixAvoid

  const [avoidSixDigits, setAvoidSixDigits] = useState(isAvoidSixDigit);
  const maleCheckboxColor = avoidSixDigits ? "#1183d2" : "transparent";
  const femaleCheckboxColor = avoidSixDigits ? "transparent" : "#1183d2";
  const handleCheckboxChange = () => {
    setAvoidSixDigits(!avoidSixDigits);
  };

  useEffect(() => {
    setAvoidSixDigits(isAvoidSixDigit);
  }, [isAvoidSixDigit]);

  //Filter - SortBy
  const [updateSortBy, setUpdateSortBy] = useState(sortType);

  useEffect(() => {
    setUpdateSortBy(sortType);
  }, [sortType]);

  //Filter - Price
  const [priceFrom, SetPriceFrom] = useState(price.min);
  const [priceTo, SetPriceTo] = useState(price.max);

  useEffect(() => {
    SetPriceFrom(price.min);
    SetPriceTo(price.max);
  }, [price]);

  //Filter - Category SimType
  const [value, setValue] = useState(simTypes);

  useEffect(() => {
    setValue(simTypes);
  }, [simTypes]);

  //handle Show
  const handleShow = () => {
    SetUpdateNetWorkArray([]);
    SetUpdateSubscriptionArray([]);
    SetUpdateHeaderArray([]);
    SetUpdateAvoidArray([]);

    setValue(simTypes);

    SetPriceFrom(price.min);
    SetPriceTo(price.max);
    setUpdateSortBy(sortType);
    setAvoidSixDigits(isAvoidSixDigit);
    SetUpdateNetWorkArray([...networkTypes]);
    SetUpdateSubscriptionArray([...subscriptionTypes]);
    SetUpdateHeaderArray([...prefixTypes]);
    SetUpdateAvoidArray([...avoidNumberTypes]);
  };

  //handle Hide
  const handleHide = () => {
    setValue(simTypes);
    SetPriceFrom(price.min);
    SetPriceTo(price.max);
    setUpdateSortBy(sortType);
    setAvoidSixDigits(isAvoidSixDigit);
    SetUpdateNetWorkArray([...networkTypes]);
    SetUpdateSubscriptionArray([...subscriptionTypes]);
    SetUpdateHeaderArray([...prefixTypes]);
    SetUpdateAvoidArray([...avoidNumberTypes]);
  };

  const handlePress = () => {
    if (isExpanded) {
      handleHide();
      hideAnimation();
    } else {
      handleShow();
      showAnimation();
    }
  };

  //
  const showAnimation = () => {
    setIsExpanded(true);
    Animated.timing(animation, {
      toValue: 1,
      duration: 300,
      useNativeDriver: true,
    }).start();
  };
  const hideAnimation = () => {
    Animated.timing(animation, {
      toValue: 0,
      duration: 300,
      useNativeDriver: true,
    }).start(() => {
      setIsExpanded(false);
    });
  };

  const interpolatedAnimation = animation.interpolate({
    inputRange: [0, 1],
    outputRange: [width, height - height],
    extrapolate: "identity",
  });

  const [isFocus, setIsFocus] = useState(false);

  const { simTypeDatas } = useContext(HomeContext);

  const { searchFilter } = useContext(SearchContext);

  const [resetFrameState, SetResetFrameState] = useState(false);

  //Filter-Handle-NetWork

  const handleSetNetIndex = (type) => {
    console.log("typeHandle" + type);

    let currentNetWorkArray = updatedNetworkArray;

    if (currentNetWorkArray.includes(type)) {
      // Nếu phần tử _netWorkType có trong mảng, xóa phần tử đó khỏi mảng
      currentNetWorkArray.splice(currentNetWorkArray.indexOf(type), 1);
    } else {
      // Nếu phần tử _netWorkType không có trong mảng, thêm phần tử đó vào mảng
      currentNetWorkArray.push(type);
    }
    SetUpdateNetWorkArray(currentNetWorkArray);
    console.log("UpdateFilter NetWork:" + JSON.stringify(updatedNetworkArray));
  };

  //Filter-Handle-Subscription

  const handleSetSubscriptionIndex = (type) => {
    console.log("typeHandle" + type);

    let currentSubscriptionArray = updatedSubscriptionArray;

    if (currentSubscriptionArray.includes(type)) {
      // Nếu phần tử _netWorkType có trong mảng, xóa phần tử đó khỏi mảng
      currentSubscriptionArray.splice(
        currentSubscriptionArray.indexOf(type),
        1,
      );
    } else {
      // Nếu phần tử _netWorkType không có trong mảng, thêm phần tử đó vào mảng
      currentSubscriptionArray.push(type);
    }
    SetUpdateSubscriptionArray(currentSubscriptionArray);
    console.log(
      "UpdateFilter Subscription:" + JSON.stringify(updatedSubscriptionArray),
    );
  };

  //Filter-Handle-Price

  const handlePriceFromChange = (text) => {
    var number = parseInt(text);
    if (isNaN(number)) {
      number = 0;
    }
    SetPriceFrom(number);
  };

  const handlePriceToChange = (text) => {
    var number = parseInt(text);
    if (isNaN(number)) {
      number = 0;
    }
    SetPriceTo(number);
  };

  //Filter-Handle-HeaderNumber
  const handleSetHeaderIndex = (type) => {
    console.log("typeHandle" + type);

    let currentHeaderArray = updatedHeaderNumber;

    if (currentHeaderArray.includes(type)) {
      // Nếu phần tử _netWorkType có trong mảng, xóa phần tử đó khỏi mảng
      currentHeaderArray.splice(currentHeaderArray.indexOf(type), 1);
    } else {
      // Nếu phần tử _netWorkType không có trong mảng, thêm phần tử đó vào mảng
      currentHeaderArray.push(type);
    }
    SetUpdateHeaderArray(currentHeaderArray);
    console.log("UpdateFilter Header:" + JSON.stringify(updatedHeaderNumber));
  };
  //Filter-Handle-Avoid
  const handleSetAvoidIndex = (type) => {
    console.log("avoidtypeHandle" + type);

    let currentAvoidArray = updatedAvoidNumber;

    if (currentAvoidArray.includes(type)) {
      // Nếu phần tử _netWorkType có trong mảng, xóa phần tử đó khỏi mảng
      currentAvoidArray.splice(currentAvoidArray.indexOf(type), 1);
    } else {
      // Nếu phần tử _netWorkType không có trong mảng, thêm phần tử đó vào mảng
      currentAvoidArray.push(type);
    }
    SetUpdateAvoidArray(currentAvoidArray);
    console.log("UpdateFilter Avoid:" + JSON.stringify(updatedAvoidNumber));
  };

  const ApplyFilter = () => {
    console.log("value là:" + JSON.stringify(value));
    searchFilter(
      updatedNetworkArray,
      value,
      priceFrom,
      priceTo,
      updatedSubscriptionArray,
      updatedAvoidNumber,
      updatedHeaderNumber,
      avoidSixDigits,
      updateSortBy,
    );
  };
  const ResetFilter = () => {
    setValue(null);
    handlePriceFromChange(0);
    handlePriceToChange(0);
    SetUpdateNetWorkArray([]);
    SetUpdateSubscriptionArray([]);
    SetUpdateHeaderArray([]);
    SetUpdateAvoidArray([]);
    setAvoidSixDigits(true);
    setUpdateSortBy(0);
  };

  const FilterPopupApply = () => {
    hideAnimation();
    SetFilterPopup("");
    setTimeout(() => {
      ApplyFilter();
    }, 10);
  };

  const [currentFilterPopUp, SetFilterPopup] = useState("");

  const [inputValue, setInputValue] = useState("20");
  return (
    //Container

    <View className="flex-1 bg-white">
      <StatusBar translucent backgroundColor={argonTheme.COLORS.ERROR} />

      {isExpanded && (
        <Animated.View
          style={{
            position: "absolute",
            top: 0,
            bottom: 0,
            right: 0,

            height: "100%",
            width: "100%",
            borderLeftWidth: 0,
            borderTopWidth: 0,
            transform: [{ translateX: interpolatedAnimation }],

            backgroundColor: "transparent",
            // justifyContent: 'center',
            // alignItems: 'center',
            zIndex: 100001,
          }}
          className="flex-row"
        >
          <TouchableWithoutFeedback
            onPress={() => {
              handleHide();
              hideAnimation();
            }}
          >
            <View
              style={{
                backgroundColor: "rgba(1, 1, 1, 0.5)",
                width: "auto",
                height: "auto",
                flex: 1,
              }}
            >
              <Text>hello</Text>
            </View>
          </TouchableWithoutFeedback>

          <View
            style={{
              position: "relative",
              top: 0,
              bottom: 0,
              right: 0,
              height: "100%",
              width: "auto",
              borderLeftWidth: 0,
              borderTopWidth: 0,

              backgroundColor: "white",
              justifyContent: "center",
              alignItems: "center",
              zIndex: 100001,
            }}
          >
            <ScrollView className="mb-10" style={{}}>
              <View
                style={{
                  width: 200,
                  margin: 20,
                }}
              >
                <View testID="networks" className="my-5">
                  <View testID="header">
                    <Text className="font-bold">CHỌN MẠNG</Text>
                  </View>
                  <View style={{ width: 200 }}>
                    <View className="flex-row">
                      <NetWorkCard
                        type={1}
                        network={netWorkNames[0]}
                        isActiveFrame={CheckActiveTickNetWork(1)}
                        setButtonIndex={handleSetNetIndex}
                        resetFrame={resetFrameState}
                      />
                      <NetWorkCard
                        type={2}
                        network={netWorkNames[1]}
                        isActiveFrame={CheckActiveTickNetWork(2)}
                        setButtonIndex={handleSetNetIndex}
                        resetFrame={resetFrameState}
                      />
                    </View>
                    <View className="flex-row">
                      <NetWorkCard
                        type={3}
                        network={netWorkNames[2]}
                        isActiveFrame={CheckActiveTickNetWork(3)}
                        setButtonIndex={handleSetNetIndex}
                        resetFrame={resetFrameState}
                      />
                      <NetWorkCard
                        type={4}
                        network={netWorkNames[3]}
                        isActiveFrame={CheckActiveTickNetWork(4)}
                        setButtonIndex={handleSetNetIndex}
                        resetFrame={resetFrameState}
                      />
                    </View>
                    <View className="flex-row">
                      <NetWorkCard
                        type={5}
                        network={netWorkNames[4]}
                        isActiveFrame={CheckActiveTickNetWork(5)}
                        setButtonIndex={handleSetNetIndex}
                        resetFrame={resetFrameState}
                      />
                      <NetWorkCard
                        type={6}
                        network={netWorkNames[5]}
                        isActiveFrame={CheckActiveTickNetWork(6)}
                        setButtonIndex={handleSetNetIndex}
                        resetFrame={resetFrameState}
                      />
                    </View>
                  </View>
                </View>

                <View
                  testID="SimCategory"
                  style={{ height: "auto" }}
                  className=""
                >
                  <View testID="header">
                    <Text className="font-bold">DANH MỤC SIM</Text>
                  </View>

                  <View>
                    {simTypeDatas.length > 0 && (
                      <Dropdown
                        style={[
                          styles5.dropdown,
                          isFocus && { borderColor: "green" },
                        ]}
                        placeholderStyle={styles5.placeholderStyle}
                        selectedTextStyle={styles5.selectedTextStyle}
                        inputSearchStyle={styles5.inputSearchStyle}
                        iconStyle={styles5.iconStyle}
                        data={simTypeDatas}
                        maxHeight={300}
                        labelField="name"
                        valueField="id"
                        placeholder={!isFocus ? "Tất cả" : "Chọn Danh Mục"}
                        value={value}
                        onFocus={() => setIsFocus(true)}
                        onBlur={() => setIsFocus(false)}
                        onChange={(item) => {
                          setValue(item.id);
                          console.log("VAlue la:" + item.id);
                          setIsFocus(false);
                        }}
                      />
                    )}
                  </View>
                </View>

                <View testID="networks" className="my-5">
                  <View testID="header">
                    <Text className="font-bold">THUÊ BAO</Text>
                  </View>
                  <View style={{ width: 200 }}>
                    <View className="flex-row">
                      <SubscriptionNumberCard
                        type={1}
                        network={subscriptionNumbers[0]}
                        isActiveFrame={CheckActiveTickScription(1)}
                        setButtonIndex={handleSetSubscriptionIndex}
                        resetFrame={resetFrameState}
                      />
                      <SubscriptionNumberCard
                        type={2}
                        network={subscriptionNumbers[1]}
                        isActiveFrame={CheckActiveTickScription(2)}
                        setButtonIndex={handleSetSubscriptionIndex}
                        resetFrame={resetFrameState}
                      />
                    </View>
                    <View className="flex-row">
                      <SubscriptionNumberCard
                        type={3}
                        network={subscriptionNumbers[2]}
                        isActiveFrame={CheckActiveTickScription(3)}
                        setButtonIndex={handleSetSubscriptionIndex}
                        resetFrame={resetFrameState}
                      />
                      <SubscriptionNumberCard
                        type={4}
                        network={subscriptionNumbers[3]}
                        isActiveFrame={CheckActiveTickScription(4)}
                        setButtonIndex={handleSetSubscriptionIndex}
                        resetFrame={resetFrameState}
                      />
                    </View>
                  </View>
                </View>

                <View testID="Prices" style={{ height: "auto" }} className="">
                  <View testID="header">
                    <Text className="font-bold">CHỌN KHOẢNG GIÁ</Text>
                  </View>
                  <View className="flex-row mt-2">
                    <TextInput
                      placeholder="Giá từ"
                      keyboardType="numeric"
                      placeholderTextColor={"gray"}
                      className="text-base mb-1 pl-2 border flex-1 mr-2 text-center rounded"
                      editable={true}
                      value={priceFrom.toString()}
                      onChangeText={handlePriceFromChange}
                    />

                    <TextInput
                      placeholder="Giá đến"
                      keyboardType="numeric"
                      placeholderTextColor={"gray"}
                      className="text-base mb-1 pl-2 border flex-1 ml-2 text-center rounded"
                      editable={true}
                      value={priceTo.toString()}
                      onChangeText={handlePriceToChange}
                    />
                  </View>
                </View>
                <View testID="networks" className="my-5">
                  <View testID="header">
                    <Text className="font-bold">ĐẦU SỐ</Text>
                  </View>
                  <View style={{ width: 200 }}>
                    <View className="flex-row">
                      <HeaderNumberCard
                        type={1}
                        network={headerNumbers[0]}
                        isActiveFrame={CheckActiveTickHeader(
                          headerNumbers[0].name,
                        )}
                        setButtonIndex={handleSetHeaderIndex}
                        resetFrame={resetFrameState}
                      />
                      <HeaderNumberCard
                        type={2}
                        network={headerNumbers[1]}
                        isActiveFrame={CheckActiveTickHeader(
                          headerNumbers[1].name,
                        )}
                        setButtonIndex={handleSetHeaderIndex}
                        resetFrame={resetFrameState}
                      />
                    </View>
                    <View className="flex-row">
                      <HeaderNumberCard
                        type={3}
                        network={headerNumbers[2]}
                        isActiveFrame={CheckActiveTickHeader(
                          headerNumbers[2].name,
                        )}
                        setButtonIndex={handleSetHeaderIndex}
                        resetFrame={resetFrameState}
                      />
                      <HeaderNumberCard
                        type={4}
                        network={headerNumbers[3]}
                        isActiveFrame={CheckActiveTickHeader(
                          headerNumbers[3].name,
                        )}
                        setButtonIndex={handleSetHeaderIndex}
                        resetFrame={resetFrameState}
                      />
                    </View>
                    <View className="flex-row">
                      <HeaderNumberCard
                        type={5}
                        network={headerNumbers[4]}
                        isActiveFrame={CheckActiveTickHeader(
                          headerNumbers[4].name,
                        )}
                        setButtonIndex={handleSetHeaderIndex}
                        resetFrame={resetFrameState}
                      />
                    </View>
                  </View>
                </View>

                <View testID="networks" className="">
                  <View testID="header">
                    <Text className="font-bold">TRÁNH SỐ</Text>
                  </View>

                  <View className="flex-row justify-between">
                    <TouchableOpacity
                      onPress={handleCheckboxChange}
                      style={styles2.container}
                      className=""
                    >
                      <View style={styles2.checkboxContainer}>
                        <View style={styles2.checkboxWrapper}>
                          {avoidSixDigits && (
                            <View
                              style={[
                                styles2.checkbox,
                                { backgroundColor: maleCheckboxColor },
                              ]}
                            />
                          )}
                        </View>
                        <Text style={styles2.label}>Tránh 6 số</Text>
                      </View>
                    </TouchableOpacity>

                    <TouchableOpacity
                      onPress={handleCheckboxChange}
                      style={styles2.container}
                      className=""
                    >
                      <View style={styles2.checkboxContainer}>
                        <View style={styles2.checkboxWrapper}>
                          {!avoidSixDigits && (
                            <View
                              style={[
                                styles2.checkbox,
                                { backgroundColor: femaleCheckboxColor },
                              ]}
                            />
                          )}
                        </View>
                        <Text style={styles2.label}>Tránh tất cả</Text>
                      </View>
                    </TouchableOpacity>
                  </View>
                  <View style={{ width: 200 }}>
                    <View className="flex-row">
                      <AvoidNumberCard
                        type={1}
                        network={avoidNumbers[0]}
                        isActiveFrame={CheckActiveTickAvoid(
                          avoidNumbers[0].name,
                        )}
                        setButtonIndex={handleSetAvoidIndex}
                        resetFrame={resetFrameState}
                      />
                      <AvoidNumberCard
                        type={2}
                        network={avoidNumbers[1]}
                        isActiveFrame={CheckActiveTickAvoid(
                          avoidNumbers[1].name,
                        )}
                        setButtonIndex={handleSetAvoidIndex}
                        resetFrame={resetFrameState}
                      />
                    </View>
                    <View className="flex-row">
                      <AvoidNumberCard
                        type={3}
                        network={avoidNumbers[2]}
                        isActiveFrame={CheckActiveTickAvoid(
                          avoidNumbers[2].name,
                        )}
                        setButtonIndex={handleSetAvoidIndex}
                        resetFrame={resetFrameState}
                      />
                      <AvoidNumberCard
                        type={4}
                        network={avoidNumbers[3]}
                        isActiveFrame={CheckActiveTickAvoid(
                          avoidNumbers[3].name,
                        )}
                        setButtonIndex={handleSetAvoidIndex}
                        resetFrame={resetFrameState}
                      />
                    </View>
                    <View className="flex-row">
                      <AvoidNumberCard
                        type={5}
                        network={avoidNumbers[4]}
                        isActiveFrame={CheckActiveTickAvoid(
                          avoidNumbers[4].name,
                        )}
                        setButtonIndex={handleSetAvoidIndex}
                        resetFrame={resetFrameState}
                      />
                      <AvoidNumberCard
                        type={5}
                        network={avoidNumbers[5]}
                        isActiveFrame={CheckActiveTickAvoid(
                          avoidNumbers[5].name,
                        )}
                        setButtonIndex={handleSetAvoidIndex}
                        resetFrame={resetFrameState}
                      />
                    </View>
                    <View className="flex-row">
                      <AvoidNumberCard
                        type={5}
                        network={avoidNumbers[6]}
                        isActiveFrame={CheckActiveTickAvoid(
                          avoidNumbers[6].name,
                        )}
                        setButtonIndex={handleSetAvoidIndex}
                        resetFrame={resetFrameState}
                      />
                      <AvoidNumberCard
                        type={5}
                        network={avoidNumbers[7]}
                        isActiveFrame={CheckActiveTickAvoid(
                          avoidNumbers[7].name,
                        )}
                        setButtonIndex={handleSetAvoidIndex}
                        resetFrame={resetFrameState}
                      />
                    </View>
                    <View className="flex-row">
                      <AvoidNumberCard
                        type={5}
                        network={avoidNumbers[8]}
                        isActiveFrame={CheckActiveTickAvoid(
                          avoidNumbers[8].name,
                        )}
                        setButtonIndex={handleSetAvoidIndex}
                        resetFrame={resetFrameState}
                      />
                      <AvoidNumberCard
                        type={5}
                        network={avoidNumbers[9]}
                        isActiveFrame={CheckActiveTickAvoid(
                          avoidNumbers[9].name,
                        )}
                        setButtonIndex={handleSetAvoidIndex}
                        resetFrame={resetFrameState}
                      />
                    </View>
                  </View>
                </View>
              </View>
            </ScrollView>

            <View
              testID="Prices"
              style={{
                position: "absolute",
                bottom: 0,
                left: 0,
                right: 0,

                backgroundColor: "white",
                padding: 2,
              }}
              className="flex-row items-center justify-between m-2 "
            >
              <TouchableOpacity
                onPress={() => {
                  hideAnimation();
                  ApplyFilter();
                }}
                style={{ backgroundColor: "#0061b0" }}
                className="items-center justify-center flex-1 rounded p-2 mx-1"
              >
                <Text className="text-white">ÁP DỤNG</Text>
              </TouchableOpacity>

              <TouchableOpacity
                onPress={() => {
                  SetResetFrameState(true);
                  ResetFilter();
                  setTimeout(() => {
                    SetResetFrameState(false);
                  }, 10);
                }}
                style={{ backgroundColor: "#ff6b00" }}
                className="items-center justify-center rounded p-2 flex-1 mx-1"
              >
                <Text className="text-white">ĐẶT LẠI</Text>
              </TouchableOpacity>
            </View>
          </View>
        </Animated.View>
      )}
      <SafeAreaView>
        {isLoading == true ? <LoadingScreen /> : null}

        {/* Filter */}

        {/* Search*/}
        <View className="">
          {/* Header */}
          <SearchHeader />

          {/* Search Result */}
          <View className="">
            {currentFrame == AppConst.SearchFrameConst.IS_CATEGORY ? (
              <SimCateGory />
            ) : null}

            {currentFrame == AppConst.SearchFrameConst.IS_INSTRUCTION ? (
              <SearchInstruction />
            ) : null}

            {currentFrame == AppConst.SearchFrameConst.IS_RECENT ? (
              <SearchRecent />
            ) : null}

            {currentFrame == AppConst.SearchFrameConst.IS_RESULT ? (
              <View className="bg-white">
                {/*CategoryFilter*/}
                <PriceFilter />
                {/*Networks*/}
                <NetworkFilter navi={navigation} />

                <View style={{ height: "100%", position: "relative" }}>
                  {currentFilterPopUp === FILTER_POPUP_SUBSCRIPTION && (
                    <View
                      className="bg-stone-100"
                      style={{
                        position: "absolute",
                        top: 0,
                        alignItems: "center",
                        padding: 4,
                        right: 0,
                        left: 0,
                        zIndex: 10000,
                        borderBottomColor: "grey",
                        borderBottomWidth: 1,
                      }}
                    >
                      <View testID="networks" className="my-5">
                        <View style={{ width: 200 }}>
                          <View className="flex-row">
                            <SubscriptionNumberCard
                              type={1}
                              network={subscriptionNumbers[0]}
                              isActiveFrame={CheckActiveTickScription(1)}
                              setButtonIndex={handleSetSubscriptionIndex}
                              resetFrame={resetFrameState}
                            />
                            <SubscriptionNumberCard
                              type={2}
                              network={subscriptionNumbers[1]}
                              isActiveFrame={CheckActiveTickScription(2)}
                              setButtonIndex={handleSetSubscriptionIndex}
                              resetFrame={resetFrameState}
                            />
                          </View>
                          <View className="flex-row">
                            <SubscriptionNumberCard
                              type={3}
                              network={subscriptionNumbers[2]}
                              isActiveFrame={CheckActiveTickScription(3)}
                              setButtonIndex={handleSetSubscriptionIndex}
                              resetFrame={resetFrameState}
                            />
                            <SubscriptionNumberCard
                              type={4}
                              network={subscriptionNumbers[3]}
                              isActiveFrame={CheckActiveTickScription(4)}
                              setButtonIndex={handleSetSubscriptionIndex}
                              resetFrame={resetFrameState}
                            />
                          </View>
                        </View>
                      </View>

                      <TouchableOpacity
                        onPress={() => {
                          FilterPopupApply();
                        }}
                        style={{ backgroundColor: "#0061b0" }}
                        className="items-center justify-center flex-1 rounded p-2 mx-1"
                      >
                        <Text className="text-white">ÁP DỤNG</Text>
                      </TouchableOpacity>
                    </View>
                  )}

                  {currentFilterPopUp === FILTER_POPUP_PRICES && (
                    <View
                      className="bg-stone-100"
                      style={{
                        position: "absolute",
                        top: 0,
                        alignItems: "center",
                        padding: 4,
                        right: 0,
                        left: 0,
                        zIndex: 10000,
                        borderBottomColor: "grey",
                        borderBottomWidth: 1,
                      }}
                    >
                      <View className="flex-row mt-2">
                        <TextInput
                          placeholder="Giá từ"
                          keyboardType="numeric"
                          placeholderTextColor={"gray"}
                          className="text-base mb-1 pl-2 border flex-1 mr-2 text-center rounded"
                          editable={true}
                          value={priceFrom.toString()}
                          onChangeText={handlePriceFromChange}
                        />

                        <TextInput
                          placeholder="Giá đến"
                          keyboardType="numeric"
                          placeholderTextColor={"gray"}
                          className="text-base mb-1 pl-2 border flex-1 ml-2 text-center rounded"
                          editable={true}
                          value={priceTo.toString()}
                          onChangeText={handlePriceToChange}
                        />
                      </View>

                      <TouchableOpacity
                        onPress={() => {
                          FilterPopupApply();
                        }}
                        style={{ backgroundColor: "#0061b0" }}
                        className="items-center justify-center flex-1 rounded p-2 mx-1"
                      >
                        <Text className="text-white">ÁP DỤNG</Text>
                      </TouchableOpacity>
                    </View>
                  )}

                  {currentFilterPopUp === FILTER_POPUP_NETWORK && (
                    <View
                      className="bg-stone-100"
                      style={{
                        position: "absolute",
                        top: 0,
                        alignItems: "center",
                        padding: 4,
                        right: 0,
                        left: 0,
                        zIndex: 10000,
                        borderBottomColor: "grey",
                        borderBottomWidth: 1,
                      }}
                    >
                      <View style={{ width: 200 }}>
                        <View className="flex-row">
                          <NetWorkCard
                            type={1}
                            network={netWorkNames[0]}
                            isActiveFrame={CheckActiveTickNetWork(1)}
                            setButtonIndex={handleSetNetIndex}
                            resetFrame={resetFrameState}
                          />
                          <NetWorkCard
                            type={2}
                            network={netWorkNames[1]}
                            isActiveFrame={CheckActiveTickNetWork(2)}
                            setButtonIndex={handleSetNetIndex}
                            resetFrame={resetFrameState}
                          />
                        </View>
                        <View className="flex-row">
                          <NetWorkCard
                            type={3}
                            network={netWorkNames[2]}
                            isActiveFrame={CheckActiveTickNetWork(3)}
                            setButtonIndex={handleSetNetIndex}
                            resetFrame={resetFrameState}
                          />
                          <NetWorkCard
                            type={4}
                            network={netWorkNames[3]}
                            isActiveFrame={CheckActiveTickNetWork(4)}
                            setButtonIndex={handleSetNetIndex}
                            resetFrame={resetFrameState}
                          />
                        </View>
                        <View className="flex-row">
                          <NetWorkCard
                            type={5}
                            network={netWorkNames[4]}
                            isActiveFrame={CheckActiveTickNetWork(5)}
                            setButtonIndex={handleSetNetIndex}
                            resetFrame={resetFrameState}
                          />
                          <NetWorkCard
                            type={6}
                            network={netWorkNames[5]}
                            isActiveFrame={CheckActiveTickNetWork(6)}
                            setButtonIndex={handleSetNetIndex}
                            resetFrame={resetFrameState}
                          />
                        </View>
                      </View>
                      <TouchableOpacity
                        onPress={() => {
                          FilterPopupApply();
                        }}
                        style={{ backgroundColor: "#0061b0" }}
                        className="items-center justify-center flex-1 rounded p-2 mx-1"
                      >
                        <Text className="text-white">ÁP DỤNG</Text>
                      </TouchableOpacity>
                    </View>
                  )}
                  {currentFilterPopUp === FILTER_POPUP_HEADER && (
                    <View
                      className="bg-stone-100"
                      style={{
                        position: "absolute",
                        top: 0,
                        alignItems: "center",
                        padding: 4,
                        right: 0,
                        left: 0,
                        zIndex: 10000,
                        borderBottomColor: "grey",
                        borderBottomWidth: 1,
                      }}
                    >
                      <View style={{ width: 200 }}>
                        <View className="flex-row">
                          <HeaderNumberCard
                            type={1}
                            network={headerNumbers[0]}
                            isActiveFrame={CheckActiveTickHeader(
                              headerNumbers[0].name,
                            )}
                            setButtonIndex={handleSetHeaderIndex}
                            resetFrame={resetFrameState}
                          />
                          <HeaderNumberCard
                            type={2}
                            network={headerNumbers[1]}
                            isActiveFrame={CheckActiveTickHeader(
                              headerNumbers[1].name,
                            )}
                            setButtonIndex={handleSetHeaderIndex}
                            resetFrame={resetFrameState}
                          />
                        </View>
                        <View className="flex-row">
                          <HeaderNumberCard
                            type={3}
                            network={headerNumbers[2]}
                            isActiveFrame={CheckActiveTickHeader(
                              headerNumbers[2].name,
                            )}
                            setButtonIndex={handleSetHeaderIndex}
                            resetFrame={resetFrameState}
                          />
                          <HeaderNumberCard
                            type={4}
                            network={headerNumbers[3]}
                            isActiveFrame={CheckActiveTickHeader(
                              headerNumbers[3].name,
                            )}
                            setButtonIndex={handleSetHeaderIndex}
                            resetFrame={resetFrameState}
                          />
                        </View>
                        <View className="flex-row">
                          <HeaderNumberCard
                            type={5}
                            network={headerNumbers[4]}
                            isActiveFrame={CheckActiveTickHeader(
                              headerNumbers[4].name,
                            )}
                            setButtonIndex={handleSetHeaderIndex}
                            resetFrame={resetFrameState}
                          />
                        </View>
                      </View>
                      <TouchableOpacity
                        onPress={() => {
                          FilterPopupApply();
                        }}
                        style={{ backgroundColor: "#0061b0" }}
                        className="items-center justify-center flex-1 rounded p-2 mx-1"
                      >
                        <Text className="text-white">ÁP DỤNG</Text>
                      </TouchableOpacity>
                    </View>
                  )}
                  {currentFilterPopUp === FILTER_POPUP_AVOID && (
                    <View
                      className="bg-stone-100"
                      style={{
                        position: "absolute",
                        top: 0,
                        alignItems: "center",
                        padding: 4,
                        right: 0,
                        left: 0,
                        zIndex: 10000,
                        borderBottomColor: "grey",
                        borderBottomWidth: 1,
                      }}
                    >
                      <View style={{ width: 200 }}>
                        <View className="flex-row justify-between">
                          <TouchableOpacity
                            onPress={handleCheckboxChange}
                            style={styles2.container}
                            className=""
                          >
                            <View style={styles2.checkboxContainer}>
                              <View style={styles2.checkboxWrapper}>
                                {avoidSixDigits && (
                                  <View
                                    style={[
                                      styles2.checkbox,
                                      { backgroundColor: maleCheckboxColor },
                                    ]}
                                  />
                                )}
                              </View>
                              <Text style={styles2.label}>Tránh 6 số</Text>
                            </View>
                          </TouchableOpacity>

                          <TouchableOpacity
                            onPress={handleCheckboxChange}
                            style={styles2.container}
                            className=""
                          >
                            <View style={styles2.checkboxContainer}>
                              <View style={styles2.checkboxWrapper}>
                                {!avoidSixDigits && (
                                  <View
                                    style={[
                                      styles2.checkbox,
                                      { backgroundColor: femaleCheckboxColor },
                                    ]}
                                  />
                                )}
                              </View>
                              <Text style={styles2.label}>Tránh tất cả</Text>
                            </View>
                          </TouchableOpacity>
                        </View>
                        <View style={{ width: 200 }}>
                          <View className="flex-row">
                            <AvoidNumberCard
                              type={1}
                              network={avoidNumbers[0]}
                              isActiveFrame={CheckActiveTickAvoid(
                                avoidNumbers[0].name,
                              )}
                              setButtonIndex={handleSetAvoidIndex}
                              resetFrame={resetFrameState}
                            />
                            <AvoidNumberCard
                              type={2}
                              network={avoidNumbers[1]}
                              isActiveFrame={CheckActiveTickAvoid(
                                avoidNumbers[1].name,
                              )}
                              setButtonIndex={handleSetAvoidIndex}
                              resetFrame={resetFrameState}
                            />
                          </View>
                          <View className="flex-row">
                            <AvoidNumberCard
                              type={3}
                              network={avoidNumbers[2]}
                              isActiveFrame={CheckActiveTickAvoid(
                                avoidNumbers[2].name,
                              )}
                              setButtonIndex={handleSetAvoidIndex}
                              resetFrame={resetFrameState}
                            />
                            <AvoidNumberCard
                              type={4}
                              network={avoidNumbers[3]}
                              isActiveFrame={CheckActiveTickAvoid(
                                avoidNumbers[3].name,
                              )}
                              setButtonIndex={handleSetAvoidIndex}
                              resetFrame={resetFrameState}
                            />
                          </View>
                          <View className="flex-row">
                            <AvoidNumberCard
                              type={5}
                              network={avoidNumbers[4]}
                              isActiveFrame={CheckActiveTickAvoid(
                                avoidNumbers[4].name,
                              )}
                              setButtonIndex={handleSetAvoidIndex}
                              resetFrame={resetFrameState}
                            />
                            <AvoidNumberCard
                              type={5}
                              network={avoidNumbers[5]}
                              isActiveFrame={CheckActiveTickAvoid(
                                avoidNumbers[5].name,
                              )}
                              setButtonIndex={handleSetAvoidIndex}
                              resetFrame={resetFrameState}
                            />
                          </View>
                          <View className="flex-row">
                            <AvoidNumberCard
                              type={5}
                              network={avoidNumbers[6]}
                              isActiveFrame={CheckActiveTickAvoid(
                                avoidNumbers[6].name,
                              )}
                              setButtonIndex={handleSetAvoidIndex}
                              resetFrame={resetFrameState}
                            />
                            <AvoidNumberCard
                              type={5}
                              network={avoidNumbers[7]}
                              isActiveFrame={CheckActiveTickAvoid(
                                avoidNumbers[7].name,
                              )}
                              setButtonIndex={handleSetAvoidIndex}
                              resetFrame={resetFrameState}
                            />
                          </View>
                          <View className="flex-row">
                            <AvoidNumberCard
                              type={5}
                              network={avoidNumbers[8]}
                              isActiveFrame={CheckActiveTickAvoid(
                                avoidNumbers[8].name,
                              )}
                              setButtonIndex={handleSetAvoidIndex}
                              resetFrame={resetFrameState}
                            />
                            <AvoidNumberCard
                              type={5}
                              network={avoidNumbers[9]}
                              isActiveFrame={CheckActiveTickAvoid(
                                avoidNumbers[9].name,
                              )}
                              setButtonIndex={handleSetAvoidIndex}
                              resetFrame={resetFrameState}
                            />
                          </View>
                        </View>
                      </View>
                      <TouchableOpacity
                        onPress={() => {
                          FilterPopupApply();
                        }}
                        style={{ backgroundColor: "#0061b0" }}
                        className="items-center justify-center flex-1 rounded p-2 mx-1"
                      >
                        <Text className="text-white">ÁP DỤNG</Text>
                      </TouchableOpacity>
                    </View>
                  )}

                  {currentFilterPopUp === FILTER_POPUP_CATEGORY && (
                    <View
                      className="bg-stone-100"
                      style={{
                        position: "absolute",
                        top: 0,
                        alignItems: "center",
                        padding: 4,
                        right: 0,
                        left: 0,
                        zIndex: 10000,
                        borderBottomColor: "grey",
                        borderBottomWidth: 1,
                      }}
                    >
                      {
                        <ScrollView style={{ height: 300, width: "100%" }}>
                          {simTypeDatas.map((item) => {
                            isCheck = item.id == value;
                            return (
                              <TouchableOpacity
                                onPress={() => {
                                  setValue(item.id);
                                  FilterPopupApply();
                                }}
                              >
                                <View
                                  style={{
                                    borderRadius: 5,
                                    padding: 5,
                                    marginTop: 5,
                                    backgroundColor: "white",
                                    shadowColor: "black",
                                    shadowOffset: { width: 1, height: 2 },
                                    shadowOpacity: 1,
                                    shadowRadius: 8,
                                    margin: 5,
                                    elevation: 5,
                                  }}
                                >
                                  <View
                                    style={{
                                      flexDirection: "row",
                                      alignItems: "center",
                                    }}
                                  >
                                    <Text> {item.name}</Text>
                                    <View
                                      style={{
                                        flex: 1,
                                        alignItems: "flex-end",
                                      }}
                                    >
                                      {isCheck && (
                                        <Ionicons
                                          name="checkmark-outline"
                                          color="black"
                                          size={20}
                                        ></Ionicons>
                                      )}
                                    </View>
                                  </View>
                                </View>
                              </TouchableOpacity>
                            );
                          })}
                        </ScrollView>
                      }
                    </View>
                  )}
                  <ScrollView
                    showsVerticalScrollIndicator={false}
                    showsHorizontalScrollIndicator={false}
                    overScrollMode="never"
                    keyboardShouldPersistTaps="always"
                    onScroll={({ nativeEvent }) => {
                      const { layoutMeasurement, contentOffset, contentSize } =
                        nativeEvent;
                      const isEndReached =
                        layoutMeasurement.height + contentOffset.y >=
                        contentSize.height - 1;
                      if (isEndReached) {
                        console.log("reach end");
                        if (
                          searchResult &&
                          searchResult.length > 0 &&
                          searchResult[0].nextID != 0
                        ) {
                          searchPaging();
                        }
                      }
                    }}
                  >
                    {searchResult && searchResult.length == 0 ? (
                      <NoResultData />
                    ) : null}
                    <SearchResult />
                  </ScrollView>
                </View>
              </View>
            ) : null}
          </View>
        </View>
      </SafeAreaView>
    </View>
  );
};

//STYLE
const styles = StyleSheet.create({
  filterText: {
    fontSize: responsiveFontSize(2),
  },
  filterArrowDown: {
    fontSize: responsiveFontSize(2),
  },
  card: {
    backgroundColor: "white",
    shadowColor: "black",
    shadowOffset: { width: 1, height: 1 },
    shadowOpacity: 1,
    shadowRadius: 8,
    margin: 5,
    height: responsiveHeight(5),
    width: responsiveWidth(30),

    elevation: 5,
  },
  button: {
    padding: 10,
    backgroundColor: "transparent",
  },
  activeButton: {
    borderBottomWidth: 2,
    borderBottomColor: "#1183d2",
  },
  activeText: {
    color: "#1183d2",
    fontSize: 14,
    fontWeight: "bold",
    textAlign: "center",
  },
  buttonText: {
    fontSize: 14,
    fontWeight: "bold",
    textAlign: "center",
  },
});
const styles5 = StyleSheet.create({
  container: {
    backgroundColor: "white",
    padding: 16,
  },
  dropdown: {
    height: 50,
    borderColor: "gray",
    borderWidth: 0.5,
    borderRadius: 8,
    paddingHorizontal: 8,
  },
  icon: {
    marginRight: 5,
  },
  label: {
    position: "absolute",
    backgroundColor: "white",
    left: 22,
    top: 8,
    zIndex: 999,
    paddingHorizontal: 8,
    fontSize: 14,
  },
  placeholderStyle: {
    fontSize: 16,
  },
  selectedTextStyle: {
    fontSize: 16,
  },
  iconStyle: {
    width: 20,
    height: 20,
  },
  inputSearchStyle: {
    height: 40,
    fontSize: 16,
  },
});
const styles7 = StyleSheet.create({
  container: { padding: 16 },
  dropdown: {
    height: 50,
    backgroundColor: "white",
    borderRadius: 12,
    padding: 12,
    shadowColor: "#000",
    shadowOffset: {
      width: 0,
      height: 1,
    },
    shadowOpacity: 0.2,
    shadowRadius: 1.41,

    elevation: 2,
  },
  placeholderStyle: {
    fontSize: 16,
  },
  selectedTextStyle: {
    fontSize: 14,
  },
  iconStyle: {
    width: 20,
    height: 20,
  },
  inputSearchStyle: {
    height: 40,
    fontSize: 16,
  },
  icon: {
    marginRight: 5,
  },
  item: {
    padding: 17,
    flexDirection: "row",
    justifyContent: "space-between",
    alignItems: "center",
  },
  selectedStyle: {
    flexDirection: "row",
    justifyContent: "center",
    alignItems: "center",
    borderRadius: 14,
    backgroundColor: "white",
    shadowColor: "#000",
    marginTop: 8,
    marginRight: 12,
    paddingHorizontal: 12,
    paddingVertical: 8,
    shadowOffset: {
      width: 0,
      height: 1,
    },
    shadowOpacity: 0.2,
    shadowRadius: 1.41,

    elevation: 2,
  },
  textSelectedStyle: {
    marginRight: 5,
    fontSize: 16,
  },
});
const styles2 = StyleSheet.create({
  container: {
    flexDirection: "row",

    borderColor: "#ccc",
    borderRadius: 5,
    backgroundColor: "white",
    shadowColor: "black",
    shadowOffset: { width: 0, height: 2 },
    shadowOpacity: 1,
    shadowRadius: 8,
    marginTop: 5,
    marginBottom: 5,
    margin: 2,
  },
  checkboxContainer: {
    flexDirection: "row",
    alignItems: "center",
    padding: 1,
  },
  checkboxWrapper: {
    width: 15,
    height: 15,
    borderWidth: 1,
    borderColor: "#dddddd",
    backgroundColor: "#dddddd",
    padding: 2,
    marginRight: 2,
    borderRadius: 3,
  },
  checkbox: {
    flex: 1,
    backgroundColor: "#1183d2",
    borderRadius: 3,
  },
  label: {
    fontSize: 14,
  },
});
const styles8 = StyleSheet.create({
  container: {
    flex: 1,
  },
  filterView: {
    position: "absolute",
    top: 0,
    right: 0,
    bottom: 0,
    width: 300,
    flexDirection: "row",
  },
  transparentHalf: {
    flex: 1,
    backgroundColor: "black",
  },
  whiteHalf: {
    flex: 1,
    backgroundColor: "white",
  },
});
