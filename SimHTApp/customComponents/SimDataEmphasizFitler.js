import React, { memo, useCallback, useContext } from "react";
import { StyleSheet, Text, TouchableOpacity, View } from "react-native";
import Config from "../constants/Config";
import { SimDataContext } from "../context/SimDataContext";

const SORT_OPTIONS = [
  { key: "highlight", label: "Nổi bật", value: Config.SEARCH_SIM_SORT_TYPE.NORMAL },
  { key: "lowPrice", label: "Giá thấp", value: Config.SEARCH_SIM_SORT_TYPE.LOW_PRICE },
  { key: "highPrice", label: "Giá cao", value: Config.SEARCH_SIM_SORT_TYPE.HIGH_PRICE },
];

const SimDataEmphasizFitler = () => {
  const { searchFilter, setUpdateSortBy, sortType, updatedSubscriptionArray } =
    useContext(SimDataContext);

  const selectSort = useCallback(
    (sortValue) => {
      setUpdateSortBy(sortValue);
      searchFilter(updatedSubscriptionArray, sortValue);
    },
    [searchFilter, setUpdateSortBy, updatedSubscriptionArray],
  );

  return (
    <View style={styles.container}>
      {SORT_OPTIONS.map((option) => {
        const isActive = Number(sortType) === Number(option.value);
        return (
          <TouchableOpacity
            key={option.key}
            accessibilityRole="button"
            accessibilityState={{ selected: isActive }}
            activeOpacity={0.8}
            onPress={() => selectSort(option.value)}
            style={[styles.button, isActive && styles.activeButton]}
          >
            <Text style={[styles.buttonText, isActive && styles.activeText]}>
              {option.label}
            </Text>
          </TouchableOpacity>
        );
      })}
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    backgroundColor: "#fff",
    borderBottomColor: "#e6e6e6",
    borderBottomWidth: StyleSheet.hairlineWidth,
    flexDirection: "row",
    minHeight: 48,
    paddingHorizontal: 12,
  },
  button: {
    alignItems: "center",
    flex: 1,
    justifyContent: "center",
  },
  activeButton: {
    borderBottomColor: "#1183d2",
    borderBottomWidth: 2,
  },
  buttonText: {
    color: "#333",
    fontSize: 14,
    fontWeight: "600",
  },
  activeText: {
    color: "#1183d2",
    fontWeight: "700",
  },
});

export default memo(SimDataEmphasizFitler);
