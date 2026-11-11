import React, { memo, useCallback, useContext } from "react";
import {
  StyleSheet,
  Text,
  TouchableOpacity,
  View,
} from "react-native";
import { AppConst } from "../constants/AppConst";
import { SimDataContext } from "../context/SimDataContext";
import TitleCategory from "./TitleCategory";

const SimDataAtCategory = ({ data, navi }) => {
  const { search } = useContext(SimDataContext);

  const handleSelectPackage = useCallback(
    (packageId) => {
      search(null, [packageId]);
      navi.navigate(AppConst.StackConst.BOTTOM_STACK, {
        screen: AppConst.BottomScreenConst.HOME_BOTTOM_SCREEN,
        params: { screen: AppConst.ScreenConst.SIM_DATA_SEARCH_SCREEN },
      });
    },
    [navi, search],
  );

  if (!data?.subPackages?.length) return null;

  return (
    <View style={styles.section}>
      <View style={styles.sectionHeader}>
        <TitleCategory title={data.packageGroup.packageCategoryName} />
      </View>
      <View style={styles.grid}>
        {data.subPackages.map((packageItem) => (
          <TouchableOpacity
            key={String(packageItem.id)}
            accessibilityRole="button"
            accessibilityLabel={`Tìm gói ${packageItem.name}`}
            activeOpacity={0.8}
            onPress={() => handleSelectPackage(packageItem.id)}
            style={styles.card}
          >
            <Text numberOfLines={2} style={styles.cardText}>
              {packageItem.name}
            </Text>
          </TouchableOpacity>
        ))}
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  section: {
    backgroundColor: "#fff",
    marginBottom: 9,
    paddingBottom: 8,
  },
  sectionHeader: {
    paddingHorizontal: 12,
    paddingTop: 9,
  },
  grid: {
    flexDirection: "row",
    flexWrap: "wrap",
    paddingHorizontal: 8,
  },
  card: {
    alignItems: "center",
    backgroundColor: "#fff",
    borderColor: "#e4e4e4",
    borderRadius: 10,
    borderWidth: StyleSheet.hairlineWidth,
    justifyContent: "center",
    margin: "0.75%",
    minHeight: 52,
    paddingHorizontal: 6,
    paddingVertical: 7,
    width: "31.83%",
  },
  cardText: {
    color: "#1575b6",
    fontSize: 13,
    fontWeight: "700",
    textAlign: "center",
  },
});

export default memo(SimDataAtCategory);
