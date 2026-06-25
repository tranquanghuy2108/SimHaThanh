import React, { useEffect, useContext } from "react";
import { Dimensions, TouchableOpacity, View, FlatList } from "react-native";
import { SafeAreaView } from 'react-native-safe-area-context';
// Galio components
import { Text } from "galio-framework";
// Argon themed components
import { SimDataContext } from "../context/SimDataContext";

import SimDataCard from "../customComponents/SimDataCard";
import { useDrawerStatus } from '@react-navigation/drawer';

const packageDatas = [
    {
        packageCategoryID: "1",
        packageCategoryName: "SIM BM",
        subPackage:
            [
                { packageID: "1", pakageName: "BM99N", packageProductType: 5 },
                { packageID: "2", pakageName: "BM120", packageProductType: 6 }
            ]
    },
    {
        packageCategoryID: "2",
        packageCategoryName: "SIM VD",
        subPackage:
            [
                { packageID: "1", pakageName: "VD90", packageProductType: 7 },
                { packageID: "2", pakageName: "VD100F", packageProductType: 8 },
                { packageID: "3", pakageName: "VD100T", packageProductType: 9 },
                { packageID: "4", pakageName: "VD100Y", packageProductType: 10 },
                { packageID: "5", pakageName: "VD120M", packageProductType: 11 },
                { packageID: "6", pakageName: "VD120N", packageProductType: 12 },
                { packageID: "7", pakageName: "VD150", packageProductType: 13 },
            ]
    },
    {
        packageCategoryID: "3",
        packageCategoryName: "SIM YOLO",
        subPackage:
            [
                { packageID: "1", pakageName: "YOLO70", packageProductType: 14 },
                { packageID: "2", pakageName: "YOLO80F", packageProductType: 15 },
                { packageID: "3", pakageName: "YOLO80T", packageProductType: 16 },
                { packageID: "4", pakageName: "YOLO90", packageProductType: 17 },
                { packageID: "5", pakageName: "YOLO100M", packageProductType: 18 },
                { packageID: "6", pakageName: "YOLO125V", packageProductType: 19 },
            ]
    },
];



const MySimFilterScreen = (props) => {
    const isDrawerOpen = useDrawerStatus();

    const { searchFilter, SetUpdateSubscriptionArray, setUpdateSortBy, SetResetFrame } = useContext(SimDataContext);
    const { subscriptionTypes, sortType, updateSortBy, updatedSubscriptionArray, resetFrameState } = useContext(SimDataContext);

    useEffect(() => {
        SetUpdateSubscriptionArray(subscriptionTypes);
    }, [subscriptionTypes]);

    useEffect(() => {
        if (isDrawerOpen === 'open') {
            // Xử lý sự kiện khi Drawer mở
            console.log('Drawer đã mở');
            handleShow();
        } else if (isDrawerOpen === 'closed') {
            // Xử lý sự kiện khi Drawer đóng
            console.log('Drawer đã đóng');
            handleHide();
        }
    }, [isDrawerOpen]);


    const handleShow = () => {
        SetUpdateSubscriptionArray([])
        setUpdateSortBy(sortType);
        SetUpdateSubscriptionArray([...subscriptionTypes])
    }

    //handle Hide 
    const handleHide = () => {

        setUpdateSortBy(sortType);

        SetUpdateSubscriptionArray([...subscriptionTypes])


    }



    const CheckActiveTickScription = (index) => {
        if (subscriptionTypes.includes(index)) {
            return true;
        }
        else {
            return false;
        }
    }

    const handleSetSubscriptionIndex = (type) => {
        console.log("typeHandle" + type)

        let currentSubscriptionArray = updatedSubscriptionArray;

        if (currentSubscriptionArray.includes(type)) {
            // Nếu phần tử _netWorkType có trong mảng, xóa phần tử đó khỏi mảng
            currentSubscriptionArray.splice(currentSubscriptionArray.indexOf(type), 1);
        } else {
            // Nếu phần tử _netWorkType không có trong mảng, thêm phần tử đó vào mảng
            currentSubscriptionArray.push(type);
        }
        SetUpdateSubscriptionArray(currentSubscriptionArray);
        console.log("UpdateFilter Subscription:" + JSON.stringify(updatedSubscriptionArray));

    };
    const ApplyFilter = () => {
        searchFilter(updatedSubscriptionArray, updateSortBy);
    }
    const ResetFilter = () => {
        SetUpdateSubscriptionArray([]);
        setUpdateSortBy(0);
    }

    return (
        <SafeAreaView>
            <View

                style={{

                    height: '100%',

                }}




            >


                <View style={{
                    width: 200, margin: 20
                }}>
                    {
                        packageDatas.map(packageCate => {
                            return (
                                <View testID="networks" className="">
                                    <View testID="header">
                                        <Text className="font-bold">{packageCate.packageCategoryName}</Text>
                                    </View>
                                    <View style={{ width: 200 }}>
                                        {
                                            <FlatList
                                                data={packageCate.subPackage}
                                                renderItem={({ item }) => {
                                                    return (
                                                        <SimDataCard name={item.pakageName} isActiveFrame={CheckActiveTickScription(item.packageID)} setButtonIndex={handleSetSubscriptionIndex} resetFrame={resetFrameState} />
                                                    )
                                                }}

                                                numColumns={2}
                                            />
                                        }
                                    </View>
                                </View>

                            )
                        })
                    }





                </View>



                <View
                    testID="Prices"
                    style={{
                        position: 'absolute',
                        bottom: 0,
                        left: 0,
                        right: 0,

                        backgroundColor: 'white',
                        padding: 2,

                    }}
                    className="flex-row items-center justify-between m-2 "
                >
                    <TouchableOpacity
                        onPress={
                            () => {
                                ApplyFilter();
                                props.navigation.closeDrawer();

                            }


                        }
                        style={{ backgroundColor: '#0061b0' }}
                        className="items-center justify-center flex-1 rounded p-2 mx-1"
                    >
                        <Text className="text-white">
                            ÁP DỤNG
                        </Text>
                    </TouchableOpacity>

                    <TouchableOpacity
                        onPress={
                            () => {

                                SetResetFrame(true);
                                ResetFilter();
                                setTimeout(() => {
                                    SetResetFrame(false);
                                }, 10)


                            }


                        }
                        style={{ backgroundColor: '#ff6b00' }} className="items-center justify-center rounded p-2 flex-1 mx-1">
                        <Text className="text-white">
                            ĐẶT LẠI
                        </Text>
                    </TouchableOpacity>

                </View>

            </View>
        </SafeAreaView>
    )
}

export default MySimFilterScreen;
