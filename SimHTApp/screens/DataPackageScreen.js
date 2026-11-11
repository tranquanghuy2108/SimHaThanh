import React, { useState, useContext, useEffect, useCallback } from "react";
import { useFocusEffect } from "@react-navigation/native";
import {
  View,
  TextInput,
  TouchableOpacity,
  Text,
  ScrollView,
  StyleSheet,
  Image,
  Linking,
  ToastAndroid,
  StatusBar,
} from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
import Ionicons from "react-native-vector-icons/Ionicons";
import { AppConst } from "../constants/AppConst";
import { argonTheme } from "../constants";
import Config from "../constants/Config";
import HTMLView from "react-native-htmlview";
import { BottomTabContext } from "../context/BottomTabContext";
import {
  responsiveHeight,
  responsiveWidth,
  responsiveFontSize,
  responsiveScreenFontSize,
} from "react-native-responsive-dimensions";
import { SimDataContext } from "../context/SimDataContext";
import { DataPackageContext } from "../context/DataPackageContext";

const ConvertCurrency = (numberString) => {
  const formattedNumber = parseInt(numberString, 10).toLocaleString("vi-VN", {
    style: "currency",
    currency: "VND",
  });
  return formattedNumber;
};
const CutPackageName = (inputString) => {
  const splitStrings = inputString.split("_");
  const result = splitStrings[0];
  return result;
};
const TruncateText = (originalText) => {
  const truncatedText =
    originalText.length > 28
      ? originalText.substring(0, 28) + "..."
      : originalText;
  return truncatedText;
};
const SearchButton = (props) => {
  const { searchDataKey, SetDataKeySearch } = useContext(BottomTabContext);
  const { search } = useContext(SimDataContext);
  const [localSearchKey, setLocalSearchKey] = useState(searchDataKey || "");

  const handleInputChange = (text) => {
    setLocalSearchKey(text);
  };
  const handleInputSubmit = async () => {
    const trimmedKey = localSearchKey.trim();
    SetDataKeySearch(trimmedKey);
    if (typeof search === "function") search(trimmedKey, null);

    if (props && props.navigation && props.navigation.navigate) {
      props.navigation.navigate(AppConst.StackConst.BOTTOM_STACK, {
        screen: AppConst.BottomScreenConst.HOME_BOTTOM_SCREEN,
        params: { screen: AppConst.ScreenConst.SIM_DATA_SEARCH_SCREEN },
      });
    }
  };
  const handleSearchFocus = () => {
    if (props && props.navigation && props.navigation.navigate) {
      props.navigation.navigate(AppConst.StackConst.BOTTOM_STACK, {
        screen: AppConst.BottomScreenConst.HOME_BOTTOM_SCREEN,
        params: { screen: AppConst.ScreenConst.SIM_DATA_CATEGORY_SCREEN },
      });
    }
  };

  return (
    <TouchableOpacity
      className="flex-1"
      activeOpacity={0.9}
      onPress={handleSearchFocus}
    >
      <View className="flex-row flex-1 items-center rounded-full bg-white mx-1">
        <View className="bg-transparent rounded-full m-3">
          <Ionicons
            name="search-outline"
            color="black"
            size={20}
          ></Ionicons>
        </View>
        <TextInput
          placeholder="Tìm Kiếm SIM Data"
          placeholderTextColor={"gray"}
          className="text-base m-0 pl-2"
          keyboardType="default"
          returnKeyType="search"
          blurOnSubmit={false}
          editable={false}
          value={localSearchKey}
        />
      </View>
    </TouchableOpacity>
  );
};
const DataPackageScreen = (props) => {
  useFocusEffect(
    useCallback(() => {
      console.log("LOG Active Screen : DataPackageScreen");
      return () => {
        // Optional: Add cleanup logic here if needed when the screen loses focus
      };
    }, []),
  );
  const { GetPackageSimData, search } = useContext(SimDataContext);
  const { simGroupDatas, SetSimGroupData } = useContext(BottomTabContext);
  const { simDataPackages } = useContext(DataPackageContext);
  const { GetSimDataPackage } = useContext(DataPackageContext);
  const handleExit = () => {
    props.navigation.navigate(AppConst.StackConst.BOTTOM_STACK, {
      screen: AppConst.BottomScreenConst.HOME_BOTTOM_SCREEN,
      params: { screen: AppConst.ScreenConst.HOME_SCREEN },
    });
  };
  const transformString = (inputString) => {
    const delimiter = "_";
    const targetChar = "T";

    const index = inputString.indexOf(delimiter);
    if (index === -1 || !inputString.includes(targetChar)) {
      return inputString; // Trả về chuỗi ban đầu nếu không có dấu "_" hoặc không có ký tự "T"
    }

    const numberString = inputString.substring(
      index + 1,
      inputString.indexOf(targetChar),
    );
    const prefix = inputString.slice(0, index);

    const transformedString = numberString.concat(prefix);
    return transformedString;
  };
  const ExitButton = () => {
    return (
      // Nút Thoát
      <TouchableOpacity
        className="p-1 rounded-full bg-white mx-1"
        onPress={() => {
          handleExit();
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
  const HomeHeader = () => {
    return (
      <View
        className="flex-row justify-center items-center p-2"
        style={styles.header}
        backgroundColor={argonTheme.COLORS.ERROR}
      >
        <ExitButton />
        <SearchButton navigation={props.navigation} />
      </View>
    );
  };
  useEffect(() => {
    GetSimDataPackage();
  }, []);
  return (
    <View style={styles.container}>
      {/* <SearchHeader /> */}
      <StatusBar translucent backgroundColor={argonTheme.COLORS.ERROR} />
      <SafeAreaView edges={["top"]} style={styles.headerSafeArea}>
        <HomeHeader />
      </SafeAreaView>
      <SafeAreaView edges={["bottom"]} style={styles.content}>
        <View style={styles.banner}>
          <Image
            source={require("../assets/imgs/sim-data.png")}
            style={styles.bannerImage}
            resizeMode={"stretch"}
          />
        </View>
        {/* <SearchButton /> */}
        {simDataPackages ? (
          <ScrollView
            style={styles.packageList}
            contentContainerStyle={styles.packageListContent}
            showsVerticalScrollIndicator={false}
            overScrollMode="never"
          >
            {simDataPackages.map((item) => {
              return (
                <View style={styles.buttonFortune}>
                  <View style={styles.card}>
                    {/* header */}
                    <View style={styles.cardHeader}>
                      <Text
                        className="font-bold"
                        style={styles.packageHeaderText}
                      >
                        {item.name}
                      </Text>
                    </View>
                    <View style={styles.cardContent}>
                      <HTMLView
                        value={item.summary}
                        stylesheet={styles.cardContent}
                      />
                      {/* Price */}
                      <View className="flex-row items-center mt-5">
                        <Image
                          source={require("../assets/imgs/icon-price-tag-256.png")}
                          style={{
                            width: responsiveHeight(4),
                            height: responsiveHeight(4),
                          }}
                          resizeMode={"contain"}
                        />
                        <Text
                          className="mx-3"
                          style={{
                            fontSize: responsiveFontSize(3),
                            fontWeight: "900",
                          }}
                        >
                          {ConvertCurrency(item.price)}
                        </Text>
                      </View>
                      <View style={styles.RegisterRow}>
                        <TouchableOpacity
                          style={styles.RegisterBtn}
                          onPress={() => {
                            var simDataParam = {
                              id: item.id,
                              packageName: item.name,
                              networkID: "",
                              networkName: "item.network",
                              description: item.description,
                              isSaleActive: false,
                              summary: item.summary,
                              price: item.price,
                              priceOnSale: null,
                            };
                            props.navigation.push(
                              AppConst.StackConst.NATIVE_STACK,
                              {
                                screen: AppConst.ScreenConst.PURCHASE_SIMDATA,
                                params: { simDataParam: simDataParam },
                              },
                            );
                          }}
                        >
                          <Text style={styles.RegisterBtnTxt}>Mua sim</Text>
                        </TouchableOpacity>
                      </View>
                    </View>
                  </View>
                </View>
              );
            })}
          </ScrollView>
        ) : (
          <View style={styles.emptyContent} />
        )}
      </SafeAreaView>
    </View>
  );
};
export default DataPackageScreen;

const styles = StyleSheet.create({
  container: {
    backgroundColor: "#f8f8f8",
    flex: 1,
  },
  headerSafeArea: {
    backgroundColor: argonTheme.COLORS.ERROR,
  },
  header: {
    minHeight: 60,
  },
  content: {
    backgroundColor: "white",
    flex: 1,
  },
  banner: {
    backgroundColor: "yellow",
  },
  bannerImage: {
    height: responsiveHeight(23),
    width: "100%",
  },
  packageList: {
    flex: 1,
  },
  packageListContent: {
    paddingBottom: 20,
  },
  emptyContent: {
    flex: 1,
  },
  card: {
    backgroundColor: "#f8f8f8f8",
    shadowColor: "black",
    shadowOffset: { width: 1, height: 1 },
    shadowOpacity: 0.3,
    shadowRadius: 8,
    elevation: 5,
    margin: 10,
    borderRadius: 5,
  },
  incentivesBodyTxt: {
    textAlign: "center",
    fontSize: responsiveScreenFontSize(2),
    textAlign: "left",
  },
  cardHeader: {
    backgroundColor: argonTheme.COLORS.ERROR,
    flex: 0,
    borderTopEndRadius: 5,
    borderTopLeftRadius: 5,
    justifyContent: "center",
    textAlign: "center",
    height: responsiveHeight(5),
    padding: 2,
  },
  packageHeaderText: {
    fontWeight: "bold",
    fontSize: responsiveFontSize(3.5),
    margin: 1,
    color: "white",
    textAlign: "center",
  },
  cardContent: {
    marginLeft: 10,
    padding: 5,
  },
  RegisterRow: {
    flexDirection: "row",
    justifyContent: "center",
    alignItems: "center",
  },
  RegisterBtn: {
    justifyContent: "center",
    backgroundColor: argonTheme.COLORS.ERROR,
    width: responsiveWidth(20),
    height: responsiveHeight(4),
    borderRadius: 5,
  },
  RegisterBtnTxt: {
    textAlign: "center",
    color: "white",
    fontWeight: "bold",
  },
  buttonFortune: {
    width: responsiveWidth(100),
  },
});
