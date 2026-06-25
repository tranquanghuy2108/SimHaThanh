import React, { useContext, useState, useEffect } from 'react';
import { View, StyleSheet, Dimensions, StatusBar, SafeAreaView, TouchableOpacity, Text, ScrollView, ActivityIndicator } from 'react-native';
import { TabView, SceneMap, TabBar } from 'react-native-tab-view';
import { argonTheme } from '../constants';
import Ionicons from 'react-native-vector-icons/Ionicons';
import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
} from "react-native-responsive-dimensions";
import { EscrowWalletContext } from '../context/EscrowWalletContext';
import { AppConst } from '../constants/AppConst';

const ConvertCurrency = (numberString) => {
    const formattedNumber = parseInt(numberString, 10).toLocaleString('vi-VN', {
        style: 'currency',
        currency: 'VND',
    });
    const convertedNumber = formattedNumber.replace('₫', 'VND');
    return convertedNumber;
}

const GetDate = (_time) => {
    const startTime = new Date(_time);

    const startDate = startTime.getDate(); // Ngày
    const startMonth = startTime.getMonth() + 1; // Tháng (lưu ý: tháng bắt đầu từ 0 nên cần cộng 1)
    const startYear = startTime.getFullYear(); // Năm

    const startHour = startTime.getHours(); // Giờ
    const startMinute = startTime.getMinutes(); // Phút
    const startSecond = startTime.getSeconds(); // Giây

    const padStartWithZero = (value) => value.toString().padStart(2, '0');

    const dateObject = {
        date: `${padStartWithZero(startDate)}/${padStartWithZero(startMonth)}/${startYear}`,
        time: `${padStartWithZero(startHour)}:${padStartWithZero(startMinute)}:${padStartWithZero(startSecond)}`
    };

    return dateObject;
};


const EscrowWalletHistoryScreen = (props) => {

    const { escrowHistoryData } = useContext(EscrowWalletContext);
    const { GetEcrowHistory } = useContext(EscrowWalletContext);

    const [index, setIndex] = useState(0);
    const [isTempLoad, SetTempLoad] = useState(false);


    const onSetIndex = async (index) => {
        SetTempLoad(true);
        setIndex(index);

        if (index === 0) {
            var x = await GetEcrowHistory(null);
            SetTempLoad(x);
        }
        else if (index === 1) {
            var x = await GetEcrowHistory(1);
            SetTempLoad(x);
        }
        else {
            var x = await GetEcrowHistory(2);
            SetTempLoad(x);
        }
    }

    const [routes] = useState([
        { key: 'all', title: 'Tất cả' },
        { key: 'push', title: 'Nạp tiền' },
        { key: 'pop', title: 'Rút tiền' },
    ]);


    useEffect(() => {
        onSetIndex(null);
    }, []);
    const FirstRoute = () => {
        return (
            <View style={{ flex: 1 }}>
                {
                    !isTempLoad ?
                        (
                            escrowHistoryData && escrowHistoryData.length > 0 ?
                                (
                                    <ScrollView >
                                        {
                                            escrowHistoryData.map(item => {
                                                return (
                                                    <EscrowCard data={item} />
                                                )
                                            })
                                        }
                                    </ScrollView>
                                )
                                :
                                (
                                    <View className="items-center mt-5">
                                        <Text className="font-bold">
                                            Không có dữ liệu!
                                        </Text>
                                    </View>
                                )
                        )
                        :

                        (
                            <View style={{ flex: 1, justifyContent: "center" }}>
                                <ActivityIndicator size="large" color={argonTheme.COLORS.ERROR} ></ActivityIndicator>
                            </View>
                        )
                }
            </View>
        );
    }

    const SecondRoute = () => {

        return (
            <View style={{ flex: 1 }}>
                {
                    !isTempLoad ?
                        (
                            escrowHistoryData && escrowHistoryData.length > 0 ?
                                (
                                    <ScrollView >
                                        {
                                            escrowHistoryData.map(item => {
                                                return (
                                                    <EscrowCard data={item} />
                                                )
                                            })
                                        }
                                    </ScrollView>
                                )
                                :
                                (
                                    <View className="items-center mt-5">
                                        <Text className="font-bold">
                                            Không có dữ liệu!
                                        </Text>
                                    </View>
                                )
                        )
                        :

                        (
                            <View style={{ flex: 1, justifyContent: "center" }}>
                                <ActivityIndicator size="large" color={argonTheme.COLORS.ERROR} ></ActivityIndicator>
                            </View>
                        )
                }
            </View>
        );

    }

    const ThirdRoute = () => {

        return (
            <View style={{ flex: 1 }}>
                {
                    !isTempLoad ?
                        (
                            escrowHistoryData && escrowHistoryData.length > 0 ?
                                (
                                    <ScrollView >
                                        {
                                            escrowHistoryData.map(item => {
                                                return (
                                                    <EscrowCard data={item} />
                                                )
                                            })
                                        }
                                    </ScrollView>
                                )
                                :
                                (
                                    <View className="items-center mt-5">
                                        <Text className="font-bold">
                                            Không có dữ liệu!
                                        </Text>
                                    </View>
                                )
                        )
                        :

                        (
                            <View style={{ flex: 1, justifyContent: "center" }}>
                                <ActivityIndicator size="large" color={argonTheme.COLORS.ERROR} ></ActivityIndicator>
                            </View>
                        )
                }
            </View>
        );
    }





    const renderScene = SceneMap({

        all: FirstRoute,
        push: SecondRoute,
        pop: ThirdRoute,
    });
    const ExitButton = () => {
        return (
            // Nút Thoát
            <TouchableOpacity className="p-1 rounded-full bg-white mx-1 "
                onPress={() => {
                    console.log(props.isDrawer);
                    if (!props.isDrawer) {
                        props.navigation.navigate(AppConst.StackConst.BOTTOM_STACK, {
                            screen: AppConst.BottomScreenConst.PROFILE_BOTTOM_SCREEN,
                        });
                        console.log("dung");
                    }
                    else {
                        props.navigation.closeDrawer();
                    }
                }}>
                <Ionicons name="chevron-back-outline" color="black" size={26}></Ionicons>
            </TouchableOpacity>
        );
    }
    const Title = () => {
        return (
            <View className="flex-1 items-center justify-center">
                <Text style={{ color: "white", fontWeight: "bold", fontSize: responsiveFontSize(2.2) }}>Lịch sử ký quỹ</Text>
            </View>

        );
    }


    const EscrowCard = ({ data }) => {

        return (

            <View className="bg-stone-100 mx-2 mt-2 p-3 rounded" style={styles.card} >
                {/* header */}
                <View className="flex-row justify-between rounded-tl rounded-tr" >
                    <View className="justify-center items-start">
                        <Text className="font-bold" style={{ fontSize: responsiveFontSize(2.1) }}>
                            Ký quỹ
                        </Text>
                    </View>

                    {

                        <Text>
                            <Text
                                className="font-bold"
                                style={{ color: data.cashActionType == AppConst.CashType.PUSH_ESCROW_MONEY ? "green" : data.cashActionType == AppConst.CashType.POP_ESCROW_MONEY ? argonTheme.COLORS.ERROR : "black" }}
                            >
                                {data.cashActionType == AppConst.CashType.PUSH_ESCROW_MONEY ? "+" : data.cashActionType == AppConst.CashType.POP_ESCROW_MONEY ? "-" : ""}
                            </Text>
                            <Text
                                className="font-bold"
                                style={{ color: data.cashActionType == AppConst.CashType.PUSH_ESCROW_MONEY ? "green" : data.cashActionType == AppConst.CashType.POP_ESCROW_MONEY ? argonTheme.COLORS.ERROR : "black" }}
                            >
                                {parseInt(data.receivables) > 0 ? ConvertCurrency(data.receivables) : ConvertCurrency(data.liabilities)}
                            </Text>
                        </Text>


                    }
                </View>

                <View className="flex-row justify-between border-stone-300 border-b mt-1" >

                </View>
                {/* Price */}
                <View className="">
                    <View>
                        {

                            <View className="flex-row items-center justify-between my-1">
                                <View className="">
                                    <Text style={{ fontSize: responsiveFontSize(1.5) }} >{data.note.charAt(0).toUpperCase() + data.note.slice(1).toLowerCase()}</Text>
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
                                        color={data.approvedStatus == AppConst.ApproveType.WAITNG ? "#cf8525" : data.approvedStatus == AppConst.ApproveType.APPROVED ? "green" : data.approvedStatus == AppConst.ApproveType.REJECTED ? argonTheme.COLORS.ERROR : "black"}
                                        size={responsiveFontSize(1.8)}></Ionicons>
                                    <Text
                                        style={{
                                            fontSize: responsiveFontSize(1.8),
                                            color: data.approvedStatus == AppConst.ApproveType.WAITNG ? "#cf8525" : data.approvedStatus == AppConst.ApproveType.APPROVED ? "green" : data.approvedStatus == AppConst.ApproveType.REJECTED ? argonTheme.COLORS.ERROR : "black",
                                            fontWeight: "bold"
                                        }} >
                                        {data.approvedStatus == AppConst.ApproveType.WAITNG ? "Chờ duyệt" : data.approvedStatus == AppConst.ApproveType.APPROVED ? "Đã duyệt" : data.approvedStatus == AppConst.ApproveType.REJECTED ? "Hủy bỏ" : "Khác"}
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
    }
    const renderTabBar = (props) => (
        <TabBar
            {...props}
            renderLabel={({ route, focused }) => (
                <Text style={{ color: focused ? '#1183d2' : 'black', fontWeight: "bold" }}>{route.title}</Text>
            )}
            style={{ backgroundColor: 'white' }}
            indicatorStyle={{ backgroundColor: '#1183d2' }}
        />
    );

    return (
        <View style={styles.container}>
            <View style={styles.extraView}>
                <View className="flex-row p-2" style={{ zIndex: 1000, marginTop: StatusBar.currentHeight }} backgroundColor={argonTheme.COLORS.ERROR}>
                    <ExitButton />
                    <Title />
                </View>
            </View>
            <TabView
                navigationState={{ index, routes }}
                renderScene={renderScene}
                renderTabBar={renderTabBar}
                onIndexChange={(index) => onSetIndex(index)}
                initialLayout={{ width: Dimensions.get('window').width }}
                style={styles.tabView}
            />
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,

    },
    extraView: {

        backgroundColor: 'yellow',
        justifyContent: 'center',
        alignItems: 'center',
    },
    tabView: {
        flex: 1,
    },
    scene: {
        flex: 1,
    },
    card: {
        backgroundColor: 'white',
        shadowColor: 'black',
        shadowOffset: { width: 1, height: 1 },
        shadowOpacity: 1,
        shadowRadius: 8,
        elevation: 5,
        borderColor:"black",
        marginLeft:10,
        marginRight:10,
        marginTop:5,
        marginBottom:5,
        height: "auto",
        padding: 5,
    },
});

export default EscrowWalletHistoryScreen;