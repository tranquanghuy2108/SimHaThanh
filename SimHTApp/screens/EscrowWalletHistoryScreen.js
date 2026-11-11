import React, { useContext, useState, useEffect } from "react";
import {
  View,
  StyleSheet,
  StatusBar,
  TouchableOpacity,
  Text,
  ScrollView,
  ActivityIndicator,
} from "react-native";
import { argonTheme } from "../constants";
import Ionicons from "react-native-vector-icons/Ionicons";
import { responsiveFontSize } from "react-native-responsive-dimensions";
import { EscrowWalletContext } from "../context/EscrowWalletContext";
import { AppConst } from "../constants/AppConst";

const ConvertCurrency = (numberString) => {
  const formattedNumber = parseInt(numberString, 10).toLocaleString("vi-VN", {
    style: "currency",
    currency: "VND",
  });
  const convertedNumber = formattedNumber.replace("₫", "VND");
  return convertedNumber;
};

const GetDate = (_time) => {
  const startTime = new Date(_time);

  const startDate = startTime.getDate(); // Ngày
  const startMonth = startTime.getMonth() + 1; // Tháng (lưu ý: tháng bắt đầu từ 0 nên cần cộng 1)
  const startYear = startTime.getFullYear(); // Năm

  const startHour = startTime.getHours(); // Giờ
  const startMinute = startTime.getMinutes(); // Phút
  const startSecond = startTime.getSeconds(); // Giây

  const padStartWithZero = (value) => value.toString().padStart(2, "0");

  const dateObject = {
    date: `${padStartWithZero(startDate)}/${padStartWithZero(startMonth)}/${startYear}`,
    time: `${padStartWithZero(startHour)}:${padStartWithZero(startMinute)}:${padStartWithZero(startSecond)}`,
  };

  return dateObject;
};

const HISTORY_TABS = [
  { title: "Tất cả", cashActionType: null },
  { title: "Nạp tiền", cashActionType: 1 },
  { title: "Rút tiền", cashActionType: 2 },
];

const EscrowWalletHistoryScreen = (props) => {
  const { escrowHistoryData } = useContext(EscrowWalletContext);
  const { GetEcrowHistory } = useContext(EscrowWalletContext);

  const [index, setIndex] = useState(0);
  const [isTempLoad, SetTempLoad] = useState(false);

  const onSetIndex = async (nextIndex) => {
    SetTempLoad(true);
    setIndex(nextIndex);

    const isLoading = await GetEcrowHistory(
      HISTORY_TABS[nextIndex].cashActionType,
    );
    SetTempLoad(isLoading);
  };

  useEffect(() => {
    console.log("LOG Active Screen : EscrowWalletHistoryScreen");
    onSetIndex(0);
  }, []);
  const ExitButton = () => {
    return (
      // Nút Thoát
      <TouchableOpacity
        className="p-1 rounded-full bg-white mx-1 "
        onPress={() => {
          props.navigation.goBack();
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
  const Title = () => {
    return (
      <View className="flex-1 items-center justify-center">
        <Text
          style={{
            color: "white",
            fontWeight: "bold",
            fontSize: responsiveFontSize(2.2),
          }}
        >
          Lịch sử ký quỹ
        </Text>
      </View>
    );
  };

  const EscrowCard = ({ data }) => {
    return (
      <View className="bg-stone-100 mx-2 mt-2 p-3 rounded" style={styles.card}>
        {/* header */}
        <View className="flex-row justify-between rounded-tl rounded-tr">
          <View className="justify-center items-start">
            <Text
              className="font-bold"
              style={{ fontSize: responsiveFontSize(2.1) }}
            >
              Ký quỹ
            </Text>
          </View>

          {
            <Text>
              <Text
                className="font-bold"
                style={{
                  color:
                    data.cashActionType == AppConst.CashType.PUSH_ESCROW_MONEY
                      ? "green"
                      : data.cashActionType ==
                          AppConst.CashType.POP_ESCROW_MONEY
                        ? argonTheme.COLORS.ERROR
                        : "black",
                }}
              >
                {data.cashActionType == AppConst.CashType.PUSH_ESCROW_MONEY
                  ? "+"
                  : data.cashActionType == AppConst.CashType.POP_ESCROW_MONEY
                    ? "-"
                    : ""}
              </Text>
              <Text
                className="font-bold"
                style={{
                  color:
                    data.cashActionType == AppConst.CashType.PUSH_ESCROW_MONEY
                      ? "green"
                      : data.cashActionType ==
                          AppConst.CashType.POP_ESCROW_MONEY
                        ? argonTheme.COLORS.ERROR
                        : "black",
                }}
              >
                {parseInt(data.receivables) > 0
                  ? ConvertCurrency(data.receivables)
                  : ConvertCurrency(data.liabilities)}
              </Text>
            </Text>
          }
        </View>

        <View className="flex-row justify-between border-stone-300 border-b mt-1"></View>
        {/* Price */}
        <View className="">
          <View>
            {
              <View className="flex-row items-center justify-between my-1">
                <View className="">
                  <Text style={{ fontSize: responsiveFontSize(1.5) }}>
                    {data.note.charAt(0).toUpperCase() +
                      data.note.slice(1).toLowerCase()}
                  </Text>
                </View>
                <View className="flex-row">
                  <View className="bg-stone-200 items-center px-2 rounded-xl">
                    <Text>
                      <Text style={{ fontSize: responsiveFontSize(1.8) }}>
                        {GetDate(data.createTime).time}
                      </Text>
                    </Text>
                  </View>
                </View>
              </View>
            }
            <View className="flex-row items-center justify-between">
              <View className="">
                <Text>
                  <Ionicons
                    name="ellipse"
                    color={
                      data.approvedStatus == AppConst.ApproveType.WAITNG
                        ? "#cf8525"
                        : data.approvedStatus == AppConst.ApproveType.APPROVED
                          ? "green"
                          : data.approvedStatus == AppConst.ApproveType.REJECTED
                            ? argonTheme.COLORS.ERROR
                            : "black"
                    }
                    size={responsiveFontSize(1.8)}
                  ></Ionicons>
                  <Text
                    style={{
                      fontSize: responsiveFontSize(1.8),
                      color:
                        data.approvedStatus == AppConst.ApproveType.WAITNG
                          ? "#cf8525"
                          : data.approvedStatus == AppConst.ApproveType.APPROVED
                            ? "green"
                            : data.approvedStatus ==
                                AppConst.ApproveType.REJECTED
                              ? argonTheme.COLORS.ERROR
                              : "black",
                      fontWeight: "bold",
                    }}
                  >
                    {data.approvedStatus == AppConst.ApproveType.WAITNG
                      ? "Chờ duyệt"
                      : data.approvedStatus == AppConst.ApproveType.APPROVED
                        ? "Đã duyệt"
                        : data.approvedStatus == AppConst.ApproveType.REJECTED
                          ? "Hủy bỏ"
                          : "Khác"}
                  </Text>
                </Text>
              </View>
              <View className="flex-row">
                <View className="bg-stone-200 items-center px-2 rounded-xl">
                  <Text>
                    <Text style={{ fontSize: responsiveFontSize(1.8) }}>
                      {GetDate(data.createTime).date}
                    </Text>
                  </Text>
                </View>
              </View>
            </View>
          </View>
        </View>
      </View>
    );
  };
  const HistoryContent = () => {
    if (isTempLoad) {
      return (
        <View style={styles.centeredContent}>
          <ActivityIndicator size="large" color={argonTheme.COLORS.ERROR} />
        </View>
      );
    }

    if (!escrowHistoryData || escrowHistoryData.length === 0) {
      return (
        <View className="items-center mt-5">
          <Text className="font-bold">Không có dữ liệu!</Text>
        </View>
      );
    }

    return (
      <ScrollView>
        {escrowHistoryData.map((item, itemIndex) => (
          <EscrowCard
            data={item}
            key={`${item.id ?? item.createTime}-${itemIndex}`}
          />
        ))}
      </ScrollView>
    );
  };

  return (
    <View style={styles.container}>
      {/* <View style={styles.extraView}>
        <View
          className="flex-row p-2"
          style={{ zIndex: 1000, marginTop: StatusBar.currentHeight }}
          backgroundColor={argonTheme.COLORS.ERROR}
        >
          <ExitButton />
          <Title />
        </View>
      </View> */}
      <View style={styles.tabBar}>
        {HISTORY_TABS.map((tab, tabIndex) => {
          const isActive = index === tabIndex;

          return (
            <TouchableOpacity
              accessibilityRole="tab"
              accessibilityState={{ selected: isActive }}
              key={tab.title}
              onPress={() => onSetIndex(tabIndex)}
              style={[styles.tabButton, isActive && styles.tabButtonActive]}
            >
              <Text
                style={[styles.tabLabel, isActive && styles.tabLabelActive]}
              >
                {tab.title}
              </Text>
            </TouchableOpacity>
          );
        })}
      </View>
      <HistoryContent />
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
  },
  extraView: {
    backgroundColor: "yellow",
    justifyContent: "center",
    alignItems: "center",
  },
  tabBar: {
    flexDirection: "row",
    backgroundColor: "white",
  },
  tabButton: {
    alignItems: "center",
    borderBottomColor: "transparent",
    borderBottomWidth: 2,
    flex: 1,
    paddingVertical: 12,
  },
  tabButtonActive: {
    borderBottomColor: "#1183d2",
  },
  tabLabel: {
    color: "black",
    fontWeight: "bold",
  },
  tabLabelActive: {
    color: "#1183d2",
  },
  centeredContent: {
    flex: 1,
    justifyContent: "center",
  },
  card: {
    backgroundColor: "white",
    shadowColor: "black",
    shadowOffset: { width: 1, height: 1 },
    shadowOpacity: 0.3,
    shadowRadius: 8,
    elevation: 5,
    borderColor: "black",
    marginLeft: 10,
    marginRight: 10,
    marginTop: 5,
    marginBottom: 5,
    height: "auto",
    padding: 5,
  },
});

export default EscrowWalletHistoryScreen;
