import { React, useContext } from "react";
import MasonryList from "@react-native-seoul/masonry-list";
import { TouchableOpacity, View, Text, InteractionManager } from "react-native";
import TitleCategory from "./TitleCategory";
import { HomeContext } from "../context/HomeContext";
import { AppConst } from "../constants/AppConst";
import { SearchContext } from "../context/SearchContext";
import Ionicons from "react-native-vector-icons/Ionicons";

import {
  responsiveHeight,
  responsiveWidth,
  responsiveFontSize,
} from "react-native-responsive-dimensions";

const SpecialSimAtCategory = (props) => {
  const fakeSpecialSimDatas = [
    {
      id: 12,
      name: "Tiến đơn 3",
      format: "ABC",
      description: "*012,*123,*234,*345,*456,*567,*678,*789",
      type: 0,
      color: "#748eff",
    },
    {
      id: 23,
      name: "Tiến giữa",
      format: "123.xxx",
      description: "*012*,*123*,*234*,*345*,*456*,*567*,*678*,*789*",
      type: 0,
      color: "#ffb661",
    },
    {
      id: 30,
      name: "Sim số đẹp",
      format: "AB.CB.DB",
      description: "",
      type: 0,
      color: "#ff508e",
    },
    {
      id: 15,
      name: "Lộc phát",
      format: "68",
      description: "*68",
      type: 0,
      color: "#ffd500",
    },
    {
      id: 16,
      name: "Phát lộc",
      format: "86",
      description: "*86",
      type: 0,
      color: "#99586e",
    },
    {
      id: 17,
      name: "Cửu cửu",
      format: "99",
      description: "*99",
      type: 0,
      color: "#ff6b73",
    },
    {
      id: 18,
      name: "Phát phát",
      format: "88",
      description: "*88",
      type: 0,
      color: "#66dd83",
    },
    {
      id: 19,
      name: "Lộc lộc",
      format: "66",
      description: "*66",
      type: 1,
      color: "#1485bf",
    },
  ];

  const fakeSpecialVIP = [
    {
      id: 1,
      name: "Ngũ quý",
      format: "AAAAA",
      description:
        "*00000,*11111,*22222,*33333,*44444,*55555,*66666,*77777,*88888,*99999",
      type: 0,
    },
    {
      id: 2,
      name: "Tứ quý",
      format: "AAAA",
      description:
        "*0000,*1111,*2222,*3333,*4444,*5555,*6666,*7777,*8888,*9999",
      type: 0,
    },
    {
      id: 24,
      name: "Tứ quý giữa",
      format: "AAAA.",
      description: "",
      type: 0,
    },
    {
      id: 4,
      name: "Tam hoa kép",
      format: "AAA.BBB",
      description: "",
      type: 0,
    },
    {
      id: 6,
      name: "Tam hoa",
      format: ".AAA",
      description: "*000,*111,*222,*333,*444,*555,*666,*777,*888,*999",
      type: 0,
    },
  ];

  const fakeSpecialBeauti = [
    {
      id: 3,
      name: "Taxi",
      format: "BAA.BAA",
      description: "",
    },
    {
      id: 7,
      name: "Tiến đơn 5",
      format: "ABCDE",
      description: "",
    },
    {
      id: 8,
      name: "Tiến đơn 4",
      format: "ABCD",
      description: "",
    },
    {
      id: 9,
      name: "Tiến đơn 3 kép",
      format: "ABC.ABC",
      description: "",
    },
    {
      id: 12,
      name: "Tiến đơn 3",
      format: "ABC",
      description: "*012,*123,*234,*345,*456,*567,*678,*789",
    },
    {
      id: 28,
      name: "Số gánh",
      format: ".ABA",
      description: "",
    },
    {
      id: 26,
      name: "Gánh đôi",
      format: "ABA.CDC",
      description: "",
    },
  ];

  const fakeSpecialLucky = [
    {
      id: 19,
      name: "Lộc phát",
      format: "68",
      description: "*68",
    },
    {
      id: 13,
      name: "Thần tài",
      format: "79-39",
      description: "*79,*39",
    },
    {
      id: 20,
      name: "Ông địa",
      format: "78-38",
      description: "*78,*38",
    },
    {
      id: 10,
      name: "Số đặc biệt",
      format: "SPECIAL",
      description: "",
    },
    {
      id: 11,
      name: "Tiến đặc biệt",
      format: "SPECIAL_UP",
      description: "",
    },
    {
      id: 31,
      name: "Năm sinh",
      format: "19bx",
      description: "",
    },
  ];

  const { simTypeDatas } = useContext(HomeContext);
  const isFakeData = props.fake;

  return (
    <View className="mx-">
      {isFakeData == true ? (
        <View>
          <View className="bg-white py-2 px-2">
            <TitleCategory title="SIM SỐ ĐẸP" />
          </View>
          <View style={{ flex: 1 }} className="px-1">
            {fakeSpecialSimDatas && (
              <MasonryList
                data={fakeSpecialSimDatas}
                numColumns={3}
                renderItem={({ item }) => (
                  <SpecialSimCard
                    pathProp={props.navi}
                    routeProp={props.route}
                    itemData={item}
                    fakeData={props.fake}
                  />
                )}
                columnWrapperStyle={{ justifyContent: "space-between" }}
                contentContainerStyle={{ padding: 3 }}
              />
            )}
          </View>
        </View>
      ) : (
        <View>
          <View>
            <View className="bg-white py-2 px-2">
              <TitleCategory title="SIM SỐ VIP" />
            </View>
            <View style={{ flex: 1 }} className="px-1">
              {
                <MasonryList
                  data={fakeSpecialVIP}
                  numColumns={3}
                  renderItem={({ item }) => (
                    <SpecialSimCard
                      pathProp={props.navi}
                      routeProp={props.route}
                      itemData={item}
                      fakeData={props.fake}
                    />
                  )}
                  columnWrapperStyle={{ justifyContent: "space-between" }}
                  contentContainerStyle={{ padding: 3 }}
                />
              }
            </View>
          </View>

          <View>
            <View className="bg-white py-2 px-2">
              <TitleCategory title="SIM SỐ ĐẸP" />
            </View>
            <View style={{ flex: 1 }} className="px-1">
              {
                <MasonryList
                  data={fakeSpecialBeauti}
                  numColumns={3}
                  renderItem={({ item }) => (
                    <SpecialSimCard
                      pathProp={props.navi}
                      routeProp={props.route}
                      itemData={item}
                      fakeData={props.fake}
                    />
                  )}
                  columnWrapperStyle={{ justifyContent: "space-between" }}
                  contentContainerStyle={{ padding: 3 }}
                />
              }
            </View>
          </View>

          <View>
            <View className="bg-white py-2 px-2 ">
              <TitleCategory title="SIM MAY MẮN" />
            </View>
            <View style={{ height: 450 }} className="px-1 ">
              {
                <MasonryList
                  data={fakeSpecialLucky}
                  numColumns={3}
                  renderItem={({ item }) => (
                    <SpecialSimCard
                      pathProp={props.navi}
                      itemData={item}
                      routeProp={props.route}
                      fakeData={props.fake}
                    />
                  )}
                  columnWrapperStyle={{ justifyContent: "space-between" }}
                  contentContainerStyle={{ padding: 3 }}
                />
              }
            </View>
          </View>
        </View>
      )}
    </View>
  );
};

export default SpecialSimAtCategory;

const SpecialSimCard = (prop) => {
  const { search } = useContext(SearchContext);
  return prop.itemData.type == 1 ? (
    <TouchableOpacity
      className="px-2 rounded-xl justify-center items-items"
      style={{ backgroundColor: "white", ...styles.card }}
      onPress={() => {
        prop.pathProp.navigate(AppConst.ScreenConst.SEARCH_SCREEN);
      }}
    >
      <Ionicons
        name="ellipsis-horizontal-outline"
        className="text-center"
        color="#1575b6"
        size={25}
      ></Ionicons>
      <Text
        className="font-bold text-center"
        style={{ fontSize: 12, color: "#1575b6" }}
      >
        Xem tất cả
      </Text>
    </TouchableOpacity>
  ) : (
    <TouchableOpacity
      className="p-2 rounded-xl justify-center items-items"
      style={{
        backgroundColor: prop.itemData.color ? prop.itemData.color : "white",
        ...styles.card,
      }}
      onPress={() => {
        const currentIndex = prop.routeProp.state?.index || 0; // Lấy chỉ số của màn hình hiện tại
        prop.pathProp.reset({
          index: currentIndex,
          routes: [
            {
              name: AppConst.ScreenConst.SEARCH_SCREEN, // Tên của stack
              params: {
                screenParam: AppConst.SearchFrameConst.IS_RESULT,
              },
            },
          ],
        });
        // Trigger search after navigation to keep transition smooth
        InteractionManager.runAfterInteractions(() => {
          search(null, null, null, prop.itemData.id, { suppressLoading: true });
        });
      }}
    >
      <Text
        className="font-bold text-center"
        style={{
          fontSize: responsiveFontSize(1.8),
          color: "#1575b6",
        }}
      >
        {prop.itemData.name}
      </Text>
    </TouchableOpacity>
  );
};
const styles = {
  card: {
    shadowColor: "black",
    shadowOffset: { width: 0, height: 2 },
    shadowOpacity: 1,
    shadowRadius: 8,
    margin: 5,
    height: responsiveHeight(5),
    width: responsiveWidth(30),
    elevation: 5,
  },
  price: {
    textDecorationLine: "line-through",
    color: "red",
  },
  promotionPrice: {
    color: "red",
    fontWeight: "bold",
  },
};
