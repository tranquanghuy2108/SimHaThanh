import React, { useContext, useEffect, useState, useRef } from "react";
import { InteractionManager } from "react-native";
import {
  TouchableOpacity,
  ScrollView,
  View,
  Text,
  TextInput,
  StyleSheet,
  SafeAreaView,
  StatusBar,
} from "react-native";
import { AppConst } from "../constants/AppConst";
import Ionicons from "react-native-vector-icons/Ionicons";
import { argonTheme } from "../constants";
import { BottomTabContext } from "../context/BottomTabContext";
import SimDataAtCategory from "../customComponents/SimDataAtCategory";
import {
  responsiveScreenHeight,
  responsiveScreenWidth,
  responsiveScreenFontSize,
  responsiveFontSize,
} from "react-native-responsive-dimensions";
import { SimDataContext } from "../context/SimDataContext";

const PACKAGE_GROUP_DATAS = [
  {
    packageCategoryID: "1",
    packageCategoryName: "SIM BM",
    packageKey: "BM",
  },

  {
    packageCategoryID: "2",
    packageCategoryName: "SIM VD",
    packageKey: "VD",
  },
  {
    packageCategoryID: "3",
    packageCategoryName: "SIM YOLO",
    packageKey: "YOLO",
  },
  {
    packageCategoryID: "4",
    packageCategoryName: "GÓI CƯỚC DATA",
    packageKey: "SIMKHAC",
  },
];
const headerOffset = (StatusBar.currentHeight || 0) + responsiveScreenHeight(8);
const SearchInstruction = () => {
  return (
    <View style={{ marginTop: headerOffset }}>
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
const SimDataCategoryScreen = (props) => {
  const { packageSimDatas } = useContext(SimDataContext);

  const { GetPackageSimData, search } = useContext(SimDataContext);

  const [isSearching, setIsSearching] = useState(false);

  const inputRef = useRef(null);

  const { simGroupDatas, SetSimGroupData } = useContext(BottomTabContext);

  useEffect(() => {
    GetPackageSimData();
  }, []);

  useEffect(() => {
    if (packageSimDatas != null && packageSimDatas.length > 0) {
      FilterSimPackage(PACKAGE_GROUP_DATAS, packageSimDatas);
    }
  }, [packageSimDatas]);

  useEffect(() => {
    if (isSearching && inputRef.current) {
      try {
        inputRef.current.focus();
        const t = setTimeout(() => {
          try {
            inputRef.current && inputRef.current.focus();
          } catch (e) {}
        }, 50);
        return () => clearTimeout(t);
      } catch (e) {}
    }
  }, [isSearching]);

  const handleExit = () => {
    props.navigation.navigate(AppConst.StackConst.BOTTOM_STACK, {
      screen: AppConst.BottomScreenConst.HOME_BOTTOM_SCREEN,
      params: { screen: AppConst.ScreenConst.HOME_SCREEN },
    });
  };

  const SearchButton = () => {
    const { searchDataKey, SetDataKeySearch } = useContext(BottomTabContext);
    const [localSearch, setLocalSearch] = useState(searchDataKey || "");

    const handleInputChange = (text) => {
      setLocalSearch(text);
    };
    const handleInputSubmit = async () => {
      SetDataKeySearch(localSearch);
      search(localSearch, null);

      props.navigation.navigate(AppConst.StackConst.BOTTOM_STACK, {
        screen: AppConst.BottomScreenConst.HOME_BOTTOM_SCREEN,
        params: { screen: AppConst.ScreenConst.SIM_DATA_SEARCH_SCREEN },
      });
    };
    const handleBlur = () => {
      SetDataKeySearch(localSearch);
      if (!localSearch || localSearch.trim() === "") {
        setIsSearching(false);
      }
    };

    return (
      <TouchableOpacity
        className="flex-1"
        activeOpacity={0.9}
        onPress={() => inputRef.current && inputRef.current.focus()}
      >
        <View className="flex-row flex-1 items-center rounded-full bg-white mx-1">
          <View className="bg-transparent rounded-full m-3">
            <Ionicons
              name="search-outline"
              color="black"
              size={responsiveFontSize(2.5)}
            ></Ionicons>
          </View>
          <TextInput
            placeholder="Tìm Kiếm SIM Data"
            placeholderTextColor={"gray"}
            className="text-base mb-1 pl-2"
            returnKeyType="search"
            keyboardType="phone-pad"
            editable={true}
            value={localSearch}
            ref={inputRef}
            onSubmitEditing={handleInputSubmit}
            onChangeText={handleInputChange}
            onBlur={handleBlur}
            onFocus={() => setIsSearching(true)}
          />
        </View>
      </TouchableOpacity>
    );
  };

  const SearchHistory = () => {
    const { searchHistory, SetDataKeySearch } = useContext(BottomTabContext);
    if (!searchHistory || searchHistory.length === 0) return null;
    return (
      <View
        style={{
          paddingHorizontal: 12,
          paddingTop: 12,
          marginTop: headerOffset,
        }}
      >
        <Text
          className="font-semibold text-neutral-1000 p-1"
          style={{ fontSize: 16 }}
        >
          LỊCH SỬ TÌM KIẾM
        </Text>
        {searchHistory.map((h, idx) => (
          <TouchableOpacity
            key={idx}
            onPress={() => {
              SetDataKeySearch(h);
              props.navigation.navigate(AppConst.StackConst.BOTTOM_STACK, {
                screen: AppConst.BottomScreenConst.HOME_BOTTOM_SCREEN,
                params: { screen: AppConst.ScreenConst.SIM_DATA_SEARCH_SCREEN },
              });
              InteractionManager.runAfterInteractions(() => {
                search(h, null, { suppressLoading: true });
              });
            }}
          >
            <Text style={{ fontSize: 16, paddingVertical: 6 }}>{h}</Text>
          </TouchableOpacity>
        ))}
      </View>
    );
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
        style={{
          position: "absolute",
          zIndex: 1000,
          marginTop: StatusBar.currentHeight,
        }}
        backgroundColor={argonTheme.COLORS.ERROR}
      >
        <ExitButton />
        <SearchButton />
      </View>
    );
  };

  const FilterSimPackage = (packagesGroupDatas, packageSimDatas) => {
    const SimDatas = [];
    const unprocessedPackages = [];

    if (packageSimDatas != null && packageSimDatas.length > 0) {
      packagesGroupDatas.map((packageGroup) => {
        var subPackages = packageSimDatas.filter((x) =>
          x.name.includes(packageGroup.packageKey),
        );

        if (subPackages.length > 0) {
          SimDatas.push({ packageGroup, subPackages });
        }
      });

      // Kiểm tra xem packageSimDatas còn phần tử nào chưa được thêm vào SimDatas hay không
      unprocessedPackages.push(
        ...packageSimDatas.filter(
          (x) => !SimDatas.some((s) => s.subPackages.includes(x)),
        ),
      );
    }

    if (unprocessedPackages != null && unprocessedPackages.length > 0) {
      SimDatas.push({
        packageGroup: packagesGroupDatas[packagesGroupDatas.length - 1],
        subPackages: unprocessedPackages,
      });
    }

    if (SimDatas.length > 0) {
      SetSimGroupData(SimDatas);
    }
  };

  const SimCateGory = () => {
    return (
      <ScrollView
        contentContainerStyle={{ paddingTop: headerOffset }}
        keyboardShouldPersistTaps="always"
      >
        <View
          style={{
            marginTop: responsiveScreenHeight(2),
          }}
        >
          {simGroupDatas != null && simGroupDatas.length > 0
            ? simGroupDatas.map((packageGroup) => {
                return (
                  <SimDataAtCategory
                    data={packageGroup}
                    navi={props.navigation}
                    route={props.route}
                  />
                );
              })
            : null}
        </View>
      </ScrollView>
    );
  };

  return (
    <View>
      <SafeAreaView>
        <StatusBar translucent backgroundColor={argonTheme.COLORS.ERROR} />
        {/* Header */}
        <HomeHeader />
        {!isSearching ? (
          <SearchInstruction />
        ) : (
          <>
            <SearchHistory />
            <SimCateGory />
          </>
        )}
      </SafeAreaView>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flexDirection: "row",
    borderRadius: 5,
    borderWidth: 1,
    borderColor: "#ccc",
    backgroundColor: "white",
  },
  cardContainer: {
    position: "relative",
    width: "auto",
    marginTop: 10,
    height: responsiveScreenHeight(22),
    marginLeft: responsiveScreenWidth(4),
    marginRight: responsiveScreenWidth(4),
  },
  cardImage: {
    borderRadius: 15,
    width: "100%",
    height: "100%",
    position: "absolute",
  },
  cardContent: {
    padding: 15,
    height: "100%",
  },
  input: {
    flex: 1,
    paddingVertical: 8,
    paddingHorizontal: 10,
    color: "#333",
    height: 35,
  },
  button: {
    backgroundColor: argonTheme.COLORS.ERROR,
    borderTopRightRadius: 5,
    borderBottomRightRadius: 5,
    paddingVertical: 8,
    paddingHorizontal: 12,
    marginLeft: "auto",
    height: 35,
    alignItems: "flex-end",
  },
  buttonText: {
    color: "white",
    fontWeight: "bold",
  },
});
export default SimDataCategoryScreen;
