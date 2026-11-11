import React, {
  useCallback,
  useContext,
  useEffect,
  useMemo,
  useRef,
  useState,
} from "react";
import {
  ScrollView,
  StatusBar,
  StyleSheet,
  Text,
  TextInput,
  TouchableOpacity,
  View,
} from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
import Ionicons from "react-native-vector-icons/Ionicons";
import { AppConst } from "../constants/AppConst";
import { argonTheme } from "../constants";
import { BottomTabContext } from "../context/BottomTabContext";
import { SimDataContext } from "../context/SimDataContext";
import SimDataAtCategory from "../customComponents/SimDataAtCategory";

const PACKAGE_GROUPS = [
  { packageCategoryID: "1", packageCategoryName: "SIM BM", packageKey: "BM" },
  { packageCategoryID: "2", packageCategoryName: "SIM VD", packageKey: "VD" },
  { packageCategoryID: "3", packageCategoryName: "SIM YOLO", packageKey: "YOLO" },
  {
    packageCategoryID: "4",
    packageCategoryName: "GÓI CƯỚC DATA",
    packageKey: "SIMKHAC",
  },
];

const groupPackages = (packages) => {
  if (!Array.isArray(packages) || packages.length === 0) return [];

  const assignedPackages = new Set();
  const groups = PACKAGE_GROUPS.reduce((result, packageGroup) => {
    const subPackages = packages.filter((packageItem) => {
      const packageName = String(packageItem?.name || "").toUpperCase();
      const belongsToGroup = packageName.includes(packageGroup.packageKey);

      if (belongsToGroup) assignedPackages.add(packageItem);
      return belongsToGroup;
    });

    if (subPackages.length > 0) result.push({ packageGroup, subPackages });
    return result;
  }, []);

  const remainingPackages = packages.filter(
    (packageItem) => !assignedPackages.has(packageItem),
  );

  if (remainingPackages.length > 0) {
    groups.push({
      packageGroup: PACKAGE_GROUPS[PACKAGE_GROUPS.length - 1],
      subPackages: remainingPackages,
    });
  }

  return groups;
};

const SimDataCategoryScreen = ({ navigation, route }) => {
  const { GetPackageSimData, packageSimDatas, search } = useContext(SimDataContext);
  const {
    searchDataKey,
    searchHistory,
    SetDataKeySearch,
    SetSimGroupData,
  } = useContext(BottomTabContext);
  const [isSearching, setIsSearching] = useState(false);
  const [localSearch, setLocalSearch] = useState(searchDataKey || "");
  const inputRef = useRef(null);

  const simGroups = useMemo(() => groupPackages(packageSimDatas), [packageSimDatas]);

  useEffect(() => {
    console.log("Active Screen : SimDataCategoryScreen");
    GetPackageSimData();
  }, []);

  useEffect(() => {
    SetSimGroupData(simGroups);
  }, [simGroups]);

  useEffect(() => {
    setLocalSearch(searchDataKey || "");
  }, [searchDataKey]);

  useEffect(() => {
    if (!isSearching) return undefined;

    const focusTimer = setTimeout(() => inputRef.current?.focus(), 0);
    return () => clearTimeout(focusTimer);
  }, [isSearching]);

  const navigateToSearch = useCallback(
    (keyword) => {
      const normalizedKeyword = keyword.trim();
      SetDataKeySearch(normalizedKeyword);
      search(normalizedKeyword, null);
      navigation.navigate(AppConst.StackConst.BOTTOM_STACK, {
        screen: AppConst.BottomScreenConst.HOME_BOTTOM_SCREEN,
        params: { screen: AppConst.ScreenConst.SIM_DATA_SEARCH_SCREEN },
      });
    },
    [SetDataKeySearch, navigation, search],
  );

  const handleSearchSubmit = useCallback(() => {
    navigateToSearch(localSearch);
  }, [localSearch, navigateToSearch]);

  const handleExit = useCallback(() => {
    navigation.navigate(AppConst.StackConst.BOTTOM_STACK, {
      screen: AppConst.BottomScreenConst.HOME_BOTTOM_SCREEN,
      params: { screen: AppConst.ScreenConst.HOME_SCREEN },
    });
  }, [navigation]);

  const handleHistoryPress = useCallback(
    (keyword) => {
      setLocalSearch(keyword);
      navigateToSearch(keyword);
    },
    [navigateToSearch],
  );

  return (
    <View style={styles.container}>
      <StatusBar
        translucent
        backgroundColor={argonTheme.COLORS.ERROR}
        barStyle="light-content"
      />
      <SafeAreaView edges={["top"]} style={styles.headerSafeArea}>
        <View style={styles.header}>
          <TouchableOpacity
            accessibilityRole="button"
            accessibilityLabel="Trở về trang chủ"
            hitSlop={8}
            onPress={handleExit}
            style={styles.backButton}
          >
            <Ionicons name="chevron-back-outline" color="#111" size={26} />
          </TouchableOpacity>

          <View style={styles.searchBox}>
            <Ionicons name="search-outline" color="#222" size={21} />
            <TextInput
              ref={inputRef}
              value={localSearch}
              onChangeText={setLocalSearch}
              onFocus={() => setIsSearching(true)}
              onSubmitEditing={handleSearchSubmit}
              placeholder="Tìm kiếm SIM Data"
              placeholderTextColor="#777"
              returnKeyType="search"
              keyboardType="default"
              autoCapitalize="none"
              autoCorrect={false}
              style={styles.searchInput}
              accessibilityLabel="Tìm kiếm SIM Data"
            />
          </View>
        </View>
      </SafeAreaView>

      {!isSearching ? (
        <View style={styles.instruction}>
          <Text style={styles.instructionTitle}>TÌM KIẾM SIM</Text>
          <Text style={styles.instructionItem}>• Tìm sim có số 6789: nhập 6789</Text>
          <Text style={styles.instructionItem}>• Tìm đầu 090, đuôi 8888: nhập 090*8888</Text>
          <Text style={styles.instructionItem}>• Tìm số bắt đầu 0914: nhập 0914*</Text>
        </View>
      ) : (
        <ScrollView
          style={styles.content}
          contentContainerStyle={styles.contentContainer}
          keyboardShouldPersistTaps="handled"
          showsVerticalScrollIndicator={false}
          overScrollMode="never"
        >
          {Array.isArray(searchHistory) && searchHistory.length > 0 && (
            <View style={styles.historySection}>
              <Text style={styles.sectionTitle}>LỊCH SỬ TÌM KIẾM</Text>
              {searchHistory.map((keyword, index) => (
                <TouchableOpacity
                  key={`${keyword}-${index}`}
                  accessibilityRole="button"
                  onPress={() => handleHistoryPress(keyword)}
                  style={styles.historyItem}
                >
                  <Ionicons name="time-outline" color="#777" size={17} />
                  <Text style={styles.historyText}>{keyword}</Text>
                </TouchableOpacity>
              ))}
            </View>
          )}

          {simGroups.map((packageGroup) => (
            <SimDataAtCategory
              key={packageGroup.packageGroup.packageCategoryID}
              data={packageGroup}
              navi={navigation}
              route={route}
            />
          ))}

          {simGroups.length === 0 && (
            <Text style={styles.emptyText}>Chưa có gói SIM Data để hiển thị.</Text>
          )}
        </ScrollView>
      )}
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#f8f8f8",
  },
  headerSafeArea: {
    backgroundColor: argonTheme.COLORS.ERROR,
  },
  header: {
    alignItems: "center",
    flexDirection: "row",
    minHeight: 60,
    paddingHorizontal: 10,
    paddingVertical: 8,
  },
  backButton: {
    alignItems: "center",
    backgroundColor: "#fff",
    borderRadius: 22,
    height: 44,
    justifyContent: "center",
    marginRight: 8,
    width: 44,
  },
  searchBox: {
    alignItems: "center",
    backgroundColor: "#fff",
    borderRadius: 22,
    flex: 1,
    flexDirection: "row",
    height: 44,
    paddingHorizontal: 14,
  },
  searchInput: {
    color: "#222",
    flex: 1,
    fontSize: 16,
    height: "100%",
    marginLeft: 10,
    paddingVertical: 0,
  },
  content: {
    flex: 1,
  },
  contentContainer: {
    paddingBottom: 24,
    paddingTop: 12,
  },
  instruction: {
    flex: 1,
    paddingHorizontal: 20,
    paddingTop: 22,
  },
  instructionTitle: {
    color: "#111",
    fontSize: 17,
    fontWeight: "700",
    marginBottom: 12,
  },
  instructionItem: {
    color: "#5a5a5a",
    fontSize: 15,
    lineHeight: 24,
  },
  historySection: {
    backgroundColor: "#fff",
    borderBottomColor: "#e7e7e7",
    borderBottomWidth: StyleSheet.hairlineWidth,
    marginBottom: 8,
    paddingHorizontal: 16,
    paddingVertical: 10,
  },
  sectionTitle: {
    color: "#111",
    fontSize: 16,
    fontWeight: "700",
    marginBottom: 4,
  },
  historyItem: {
    alignItems: "center",
    flexDirection: "row",
    minHeight: 38,
  },
  historyText: {
    color: "#333",
    fontSize: 16,
    marginLeft: 9,
  },
  emptyText: {
    color: "#666",
    fontSize: 15,
    paddingHorizontal: 16,
    paddingTop: 20,
    textAlign: "center",
  },
});

export default SimDataCategoryScreen;
