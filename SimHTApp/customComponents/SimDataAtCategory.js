import React, { useContext } from "react";
import { InteractionManager } from "react-native";
import MasonryList from "@react-native-seoul/masonry-list";
import { TouchableOpacity, View, Text } from "react-native";
import TitleCategory from "./TitleCategory";
import { AppConst } from "../constants/AppConst";
import { SimDataContext } from "../context/SimDataContext";
import {
  responsiveHeight,
  responsiveWidth,
  responsiveFontSize,
} from "react-native-responsive-dimensions";

const SimDataAtCategory = (props) => {
  return (
    <View className="">
      <View className="bg-white px-2 py-1">
        <TitleCategory title={props.data.packageGroup.packageCategoryName} />
      </View>

      <View style={{ flex: 1 }} className="px-1">
        <MasonryList
          data={props.data.subPackages}
          numColumns={3}
          renderItem={({ item }) => (
            <SimPackageCard
              pathProp={props.navi}
              itemProp={item}
              routeProp={props.route}
            />
          )}
          columnWrapperStyle={{ justifyContent: "space-between" }}
          contentContainerStyle={{ padding: 3 }}
        />
      </View>
    </View>
  );
};

export default SimDataAtCategory;

const SimPackageCard = (prop) => {
  const { search } = useContext(SimDataContext);
  return (
    <TouchableOpacity
      className="p-2 bg-slate-100 rounded-xl justify-center items-items"
      style={styles.card}
      onPress={() => {
        // Navigate first to keep animation smooth, then trigger search shortly after
        prop.pathProp.navigate(AppConst.StackConst.BOTTOM_STACK, {
          screen: AppConst.BottomScreenConst.HOME_BOTTOM_SCREEN,
          params: { screen: AppConst.ScreenConst.SIM_DATA_SEARCH_SCREEN },
        });
        InteractionManager.runAfterInteractions(() => {
          search(null, [prop.itemProp.id], { suppressLoading: true });
        });
      }}
    >
      <Text
        className="font-bold text-center"
        style={{ fontSize: responsiveFontSize(1.8), color: "#1575b6" }}
      >
        {prop.itemProp.name}
      </Text>
    </TouchableOpacity>
  );
};
const styles = {
  card: {
    backgroundColor: "white",
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
