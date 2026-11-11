import React, { useCallback, useContext, useEffect } from "react";
import { ScrollView, StyleSheet, Text, TouchableOpacity, View } from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
import { useDrawerStatus } from "@react-navigation/drawer";
import { BottomTabContext } from "../context/BottomTabContext";
import { SimDataContext } from "../context/SimDataContext";
import SimDataCard from "../customComponents/SimDataCard";

const SimDataFilterScreen = ({ navigation }) => {
  const drawerStatus = useDrawerStatus();
  const {
    searchFilter,
    SetResetFrame,
    SetUpdateSubscriptionArray,
    setUpdateSortBy,
    sortType,
    subscriptionTypes,
    updateSortBy,
    updatedSubscriptionArray,
  } = useContext(SimDataContext);
  const { simGroupDatas } = useContext(BottomTabContext);

  useEffect(() => {
    if (drawerStatus !== "open") return;

    setUpdateSortBy(sortType);
    SetUpdateSubscriptionArray([...subscriptionTypes]);
  }, [drawerStatus]);

  const toggleSubscription = useCallback(
    (type) => {
      const nextSubscriptions = updatedSubscriptionArray.includes(type)
        ? updatedSubscriptionArray.filter((item) => item !== type)
        : [...updatedSubscriptionArray, type];

      SetUpdateSubscriptionArray(nextSubscriptions);
    },
    [SetUpdateSubscriptionArray, updatedSubscriptionArray],
  );

  const applyFilter = useCallback(() => {
    searchFilter(updatedSubscriptionArray, updateSortBy);
    navigation.closeDrawer?.();
  }, [navigation, searchFilter, updateSortBy, updatedSubscriptionArray]);

  const resetFilter = useCallback(() => {
    SetUpdateSubscriptionArray([]);
    setUpdateSortBy(0);
    SetResetFrame(true);
    setTimeout(() => SetResetFrame(false), 0);
  }, [SetResetFrame, SetUpdateSubscriptionArray, setUpdateSortBy]);

  return (
    <SafeAreaView edges={["top", "bottom"]} style={styles.safeArea}>
      <View style={styles.header}>
        <Text style={styles.title}>Lọc SIM Data</Text>
        <TouchableOpacity
          accessibilityRole="button"
          accessibilityLabel="Đóng bộ lọc"
          hitSlop={8}
          onPress={() => navigation.closeDrawer?.()}
        >
          <Text style={styles.closeText}>Đóng</Text>
        </TouchableOpacity>
      </View>

      <ScrollView
        style={styles.content}
        contentContainerStyle={styles.contentContainer}
        showsVerticalScrollIndicator={false}
      >
        {Array.isArray(simGroupDatas) && simGroupDatas.length > 0 ? (
          simGroupDatas.map((packageCategory) => (
            <View key={packageCategory.packageGroup.packageCategoryID} style={styles.group}>
              <Text style={styles.groupTitle}>
                {packageCategory.packageGroup.packageCategoryName}
              </Text>
              <View style={styles.grid}>
                {packageCategory.subPackages.map((item) => (
                  <SimDataCard
                    key={String(item.id)}
                    item={item}
                    setButtonIndex={toggleSubscription}
                  />
                ))}
              </View>
            </View>
          ))
        ) : (
          <Text style={styles.emptyText}>Chưa có dữ liệu bộ lọc.</Text>
        )}
      </ScrollView>

      <View style={styles.footer}>
        <TouchableOpacity
          accessibilityRole="button"
          onPress={applyFilter}
          style={[styles.footerButton, styles.applyButton]}
        >
          <Text style={styles.footerButtonText}>ÁP DỤNG</Text>
        </TouchableOpacity>
        <TouchableOpacity
          accessibilityRole="button"
          onPress={resetFilter}
          style={[styles.footerButton, styles.resetButton]}
        >
          <Text style={styles.footerButtonText}>ĐẶT LẠI</Text>
        </TouchableOpacity>
      </View>
    </SafeAreaView>
  );
};

const styles = StyleSheet.create({
  safeArea: {
    backgroundColor: "#fff",
    flex: 1,
  },
  header: {
    alignItems: "center",
    borderBottomColor: "#e7e7e7",
    borderBottomWidth: StyleSheet.hairlineWidth,
    flexDirection: "row",
    justifyContent: "space-between",
    minHeight: 52,
    paddingHorizontal: 16,
  },
  title: {
    color: "#222",
    fontSize: 18,
    fontWeight: "700",
  },
  closeText: {
    color: "#1575b6",
    fontSize: 15,
    fontWeight: "600",
  },
  content: {
    flex: 1,
  },
  contentContainer: {
    padding: 14,
    paddingBottom: 24,
  },
  group: {
    marginBottom: 18,
  },
  groupTitle: {
    color: "#333",
    fontSize: 15,
    fontWeight: "700",
    marginBottom: 8,
  },
  grid: {
    flexDirection: "row",
    flexWrap: "wrap",
  },
  emptyText: {
    color: "#777",
    textAlign: "center",
  },
  footer: {
    backgroundColor: "#fff",
    borderTopColor: "#e7e7e7",
    borderTopWidth: StyleSheet.hairlineWidth,
    flexDirection: "row",
    padding: 12,
  },
  footerButton: {
    alignItems: "center",
    borderRadius: 8,
    flex: 1,
    justifyContent: "center",
    minHeight: 44,
  },
  applyButton: {
    backgroundColor: "#0061b0",
    marginRight: 6,
  },
  resetButton: {
    backgroundColor: "#ff6b00",
    marginLeft: 6,
  },
  footerButtonText: {
    color: "#fff",
    fontSize: 14,
    fontWeight: "700",
  },
});

export default SimDataFilterScreen;
