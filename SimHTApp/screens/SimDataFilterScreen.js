import React, { useEffect, useContext } from "react";
import { TouchableOpacity, View, FlatList } from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
// Galio components
import { Text } from "galio-framework";
// Argon themed components

import { SimDataContext } from "../context/SimDataContext";

import SimDataCard from "../customComponents/SimDataCard";
import { useDrawerStatus } from "@react-navigation/drawer";
import { BottomTabContext } from "../context/BottomTabContext";

const SimDataFilterScreen = (props) => {
  const isDrawerOpen = useDrawerStatus();

  const {
    searchFilter,
    SetUpdateSubscriptionArray,
    setUpdateSortBy,
    SetResetFrame,
  } = useContext(SimDataContext);
  const {
    subscriptionTypes,
    sortType,
    updateSortBy,
    updatedSubscriptionArray,
    resetFrameState,
  } = useContext(SimDataContext);

  const { simGroupDatas } = useContext(BottomTabContext);

  useEffect(() => {
    if (isDrawerOpen === "open") {
      // Xử lý sự kiện khi Drawer mở
      console.log("Drawer đã mở");
      handleShow();
    } else if (isDrawerOpen === "closed") {
      // Xử lý sự kiện khi Drawer đóng
      console.log("Drawer đã đóng");
      handleHide();
    }
  }, [isDrawerOpen]);

  const handleShow = () => {
    setUpdateSortBy(sortType);
    SetUpdateSubscriptionArray([]);
    console.log("PRODUCTYPE: " + subscriptionTypes);
    SetUpdateSubscriptionArray([...subscriptionTypes]);
  };

  //handle Hide
  const handleHide = () => {
    setUpdateSortBy(sortType);

    SetUpdateSubscriptionArray([...subscriptionTypes]);
  };

  const CheckActiveTickScription = (index) => {
    if (subscriptionTypes.includes(index)) {
      return true;
    } else {
      return false;
    }
  };

  const handleSetSubscriptionIndex = (type) => {
    console.log("typeHandle" + type);

    let currentSubscriptionArray = updatedSubscriptionArray;

    if (currentSubscriptionArray.includes(type)) {
      // Nếu phần tử _netWorkType có trong mảng, xóa phần tử đó khỏi mảng
      currentSubscriptionArray.splice(
        currentSubscriptionArray.indexOf(type),
        1,
      );
    } else {
      // Nếu phần tử _netWorkType không có trong mảng, thêm phần tử đó vào mảng
      currentSubscriptionArray.push(type);
    }
    SetUpdateSubscriptionArray(currentSubscriptionArray);
    console.log(
      "UpdateFilter Subscription:" + JSON.stringify(updatedSubscriptionArray),
    );
  };
  const ApplyFilter = () => {
    searchFilter(updatedSubscriptionArray, updateSortBy);
  };
  const ResetFilter = () => {
    SetUpdateSubscriptionArray([]);
    setUpdateSortBy(0);
  };

  return (
    <SafeAreaView>
      <View
        style={{
          height: "100%",
        }}
      >
        <View
          style={{
            width: 200,
            margin: 20,
          }}
        >
          {simGroupDatas.length > 0 &&
            simGroupDatas.map((packageCate) => {
              return (
                <View testID="networks" className="">
                  <View testID="header">
                    <Text className="font-bold">
                      {packageCate.packageGroup.packageCategoryName}
                    </Text>
                  </View>
                  <View style={{ width: 200 }}>
                    {
                      <FlatList
                        data={packageCate.subPackages}
                        renderItem={({ item }) => {
                          return (
                            <SimDataCard
                              navi={isDrawerOpen}
                              item={item}
                              setButtonIndex={handleSetSubscriptionIndex}
                              resetFrame={resetFrameState}
                            />
                          );
                        }}
                        numColumns={2}
                      />
                    }
                  </View>
                </View>
              );
            })}
        </View>

        <View
          testID="Prices"
          style={{
            position: "absolute",
            bottom: 0,
            left: 0,
            right: 0,

            backgroundColor: "white",
            padding: 2,
          }}
          className="flex-row items-center justify-between m-2 "
        >
          <TouchableOpacity
            onPress={() => {
              ApplyFilter();
              props.navigation.closeDrawer();
            }}
            style={{ backgroundColor: "#0061b0" }}
            className="items-center justify-center flex-1 rounded p-2 mx-1"
          >
            <Text className="text-white">ÁP DỤNG</Text>
          </TouchableOpacity>

          <TouchableOpacity
            onPress={() => {
              SetResetFrame(true);
              ResetFilter();
              setTimeout(() => {
                SetResetFrame(false);
              }, 10);
            }}
            style={{ backgroundColor: "#ff6b00" }}
            className="items-center justify-center rounded p-2 flex-1 mx-1"
          >
            <Text className="text-white">ĐẶT LẠI</Text>
          </TouchableOpacity>
        </View>
      </View>
    </SafeAreaView>
  );
};

export default SimDataFilterScreen;
