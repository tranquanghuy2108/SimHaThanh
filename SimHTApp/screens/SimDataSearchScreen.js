import React, { useCallback, useContext, useMemo, useRef } from "react";
import {
  Alert,
  FlatList,
  StatusBar,
  StyleSheet,
  Text,
  TextInput,
  TouchableOpacity,
  View,
} from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
import Ionicons from "react-native-vector-icons/Ionicons";
import SendBird from "sendbird";
import { argonTheme } from "../constants";
import { AppConst } from "../constants/AppConst";
import Config from "../constants/Config";
import { AuthContext } from "../context/AuthContext";
import { BottomTabContext } from "../context/BottomTabContext";
import { SimDataContext } from "../context/SimDataContext";
import { useLoginRequired } from "../context/LoginRequiredContext";
import SimDataEmphasizFitler from "../customComponents/SimDataEmphasizFitler";
import LoadingScreen from "./LoadingScreen";

const formatCurrency = (value) => {
  const amount = Number(value);
  if (!Number.isFinite(amount)) return "Liên hệ";

  return amount.toLocaleString("vi-VN", {
    style: "currency",
    currency: "VND",
  });
};

const SimDataSearchScreen = ({ navigation }) => {
  const { search, searchPaging, searchResult, countryData, isSearching } =
    useContext(SimDataContext);
  const { searchDataKey, SetDataKeySearch } = useContext(BottomTabContext);
  const { userInfos } = useContext(AuthContext);
  const { requireLogin } = useLoginRequired();
  const isFetchingRef = useRef(false);

  const hasNextPage = useMemo(() => {
    const nextId = searchResult?.[0]?.nextID;
    return nextId !== undefined && nextId !== null && Number(nextId) !== 0;
  }, [searchResult]);

  const handleSearchSubmit = useCallback(() => {
    search(searchDataKey?.trim() || "", null);
  }, [search, searchDataKey]);

  const openFilter = useCallback(() => {
    const filterNavigator =
      navigation.getParent("SIM_DATA_FILTER") || navigation;
    filterNavigator?.openDrawer();
  }, [navigation]);

  const getCountryName = useCallback(
    (countryId) => {
      if (countryId === undefined || countryId === null) return "";
      return countryData?.find((country) => Number(country.id) === Number(countryId))
        ?.name || "";
    },
    [countryData],
  );

  const askSim = useCallback(() => {
    const sb = new SendBird({ appId: Config.SEND_BIRD_APP_ID });
    sb.connect(userInfos.id, (user, connectionError) => {
      if (connectionError) {
        console.error("Error connecting to Sendbird:", connectionError);
        return;
      }

      const params = new sb.GroupChannelParams();
      params.isDistinct = true;
      params.addUserIds([userInfos.id, Config.SEND_BIRD_SUPPORT_ID]);
      sb.GroupChannel.createChannel(params, (groupChannel, channelError) => {
        if (channelError) {
          console.error("Error creating group channel:", channelError);
          return;
        }

        navigation.navigate(AppConst.ScreenConst.GROUP_CHANNEL, {
          channelUrl: groupChannel.url,
        });
      });
    });
  }, [navigation, userInfos?.id]);

  const orderSim = useCallback(
    (item) => {
      const simDataParam = {
        id: item.id,
        phoneNumber: item.simNumber,
        networkID: item.networkID || "",
        networkName: item.network || "",
        isSaleActive: false,
        price: item.simPrice,
        priceOnSale: null,
        simDataPackageType: item.productType || "",
        simDataPackageCountry: getCountryName(item.countryId),
      };

      navigation.push(AppConst.StackConst.NATIVE_STACK, {
        screen: AppConst.ScreenConst.PURCHASE_SIM,
        params: { simDataParam },
      });
    },
    [getCountryName, navigation],
  );

  const confirmOrder = useCallback(
    (item) => {
      requireLogin(() => {
        Alert.alert("Bạn có muốn hỏi sim trước khi đặt mua?", "", [
          { text: "Trở về", style: "cancel" },
          { text: "Hỏi Sim", onPress: askSim },
          { text: "Đặt mua", onPress: () => orderSim(item) },
        ]);
      });
    },
    [askSim, orderSim, requireLogin],
  );

  const loadMore = useCallback(() => {
    if (isFetchingRef.current || !hasNextPage) return;

    isFetchingRef.current = true;
    Promise.resolve(searchPaging({ suppressLoading: true })).finally(() => {
      isFetchingRef.current = false;
    });
  }, [hasNextPage, searchPaging]);

  const renderItem = useCallback(
    ({ item }) => (
      <View style={styles.resultItem}>
        <View style={styles.resultContent}>
          <Text selectable numberOfLines={1} style={styles.simNumber}>
            {item.simNumber || item.name || "SIM Data"}
          </Text>
          <Text numberOfLines={1} style={styles.network}>
            {item.network || item.productType || ""}
          </Text>
        </View>
        <View style={styles.resultAction}>
          <Text numberOfLines={1} style={styles.price}>
            {formatCurrency(item.simPrice)}
          </Text>
          <TouchableOpacity
            accessibilityRole="button"
            accessibilityLabel={`Đặt mua ${item.simNumber || item.name || "SIM Data"}`}
            activeOpacity={0.85}
            onPress={() => confirmOrder(item)}
            style={styles.orderButton}
          >
            <Text style={styles.orderButtonText}>Đặt mua</Text>
          </TouchableOpacity>
        </View>
      </View>
    ),
    [confirmOrder],
  );

  const keyExtractor = useCallback(
    (item, index) =>
      `sim-data-${item.id ?? item.simNumber ?? "unknown"}-${index}`,
    [],
  );

  return (
    <View style={styles.container}>
      {isSearching ? <LoadingScreen /> : null}
      <StatusBar
        translucent
        backgroundColor={argonTheme.COLORS.ERROR}
        barStyle="light-content"
      />
      <SafeAreaView edges={["top"]} style={styles.headerSafeArea}>
        <View style={styles.header}>
          <TouchableOpacity
            accessibilityRole="button"
            accessibilityLabel="Trở lại"
            hitSlop={8}
            onPress={() => navigation.goBack()}
            style={styles.backButton}
          >
            <Ionicons name="chevron-back-outline" color="#111" size={26} />
          </TouchableOpacity>

          <View style={styles.searchBox}>
            <Ionicons name="search-outline" color="#222" size={21} />
            <TextInput
              value={searchDataKey || ""}
              onChangeText={SetDataKeySearch}
              onSubmitEditing={handleSearchSubmit}
              placeholder="Tìm SIM Data"
              placeholderTextColor="#777"
              returnKeyType="search"
              keyboardType="default"
              autoCapitalize="none"
              autoCorrect={false}
              style={styles.searchInput}
              accessibilityLabel="Tìm SIM Data"
            />
          </View>

          <TouchableOpacity
            accessibilityRole="button"
            accessibilityLabel="Lọc SIM Data"
            hitSlop={8}
            onPress={openFilter}
            style={styles.filterButton}
          >
            <Ionicons name="funnel-outline" color="#fff" size={24} />
          </TouchableOpacity>
        </View>
      </SafeAreaView>

      <SimDataEmphasizFitler />

      <FlatList
        data={Array.isArray(searchResult) ? searchResult : []}
        renderItem={renderItem}
        keyExtractor={keyExtractor}
        style={styles.list}
        contentContainerStyle={styles.listContent}
        keyboardShouldPersistTaps="handled"
        showsVerticalScrollIndicator={false}
        overScrollMode="never"
        onEndReached={loadMore}
        onEndReachedThreshold={0.25}
        ListEmptyComponent={
          isSearching ? null : (
            <View style={styles.emptyState}>
              <Ionicons name="search-outline" color="#a0a0a0" size={34} />
              <Text style={styles.emptyText}>Không có dữ liệu!</Text>
            </View>
          )
        }
      />
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    backgroundColor: "#f8f8f8",
    flex: 1,
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
  filterButton: {
    alignItems: "center",
    height: 44,
    justifyContent: "center",
    marginLeft: 8,
    width: 36,
  },
  list: {
    flex: 1,
  },
  listContent: {
    flexGrow: 1,
    paddingBottom: 24,
  },
  resultItem: {
    alignItems: "center",
    backgroundColor: "#fff",
    borderBottomColor: "#e6e6e6",
    borderBottomWidth: StyleSheet.hairlineWidth,
    flexDirection: "row",
    minHeight: 78,
    paddingHorizontal: 16,
    paddingVertical: 10,
  },
  resultContent: {
    flex: 1,
    paddingRight: 8,
  },
  simNumber: {
    color: "#1b1b1b",
    fontSize: 18,
    fontWeight: "700",
  },
  network: {
    color: "#666",
    fontSize: 14,
    marginTop: 4,
  },
  resultAction: {
    alignItems: "flex-end",
    minWidth: 110,
  },
  price: {
    color: "#222",
    fontSize: 14,
    fontWeight: "700",
    marginBottom: 7,
  },
  orderButton: {
    alignItems: "center",
    backgroundColor: argonTheme.COLORS.ERROR,
    borderRadius: 7,
    justifyContent: "center",
    minHeight: 32,
    minWidth: 92,
    paddingHorizontal: 10,
  },
  orderButtonText: {
    color: "#fff",
    fontSize: 13,
    fontWeight: "700",
  },
  emptyState: {
    alignItems: "center",
    flex: 1,
    justifyContent: "center",
    paddingTop: 80,
  },
  emptyText: {
    color: "#666",
    fontSize: 16,
    marginTop: 10,
  },
});

export default SimDataSearchScreen;
