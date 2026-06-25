import { React, useEffect, useContext, useState } from 'react';
import { Dimensions, ScrollView, TouchableOpacity, View, Text, TextInput, StatusBar, StyleSheet } from "react-native";
import { SafeAreaView } from 'react-native-safe-area-context'
// Galio components
// Argon themed components
import { argonTheme } from "../constants";
import Ionicons from 'react-native-vector-icons/Ionicons';
import Utilities from '../customComponents/Utilities';
import FlashSales from '../customComponents/FlashSales';
import SimAsNetWorks from '../customComponents/SimAsNetworks';
import SimAsPrices from '../customComponents/SimAsPrices';
import SimAsFormat from '../customComponents/SimAsFormat';
import DayPromotionSim from '../customComponents/DayPromotionSim';
import RecentUpdateSim from '../customComponents/RecentUpdateSim';
import Banner from '../customComponents/Banner';
import SpecialSim from '../customComponents/SpecialSim';
import { AppConst } from '../constants/AppConst';
import { HomeContext } from '../context/HomeContext';
import LoadingScreen from './LoadingScreen';
import SignInScreen from '../SendBirdComponents/SendBirdSignIn';
import { AuthContext } from '../context/AuthContext';
import { Badge } from 'react-native-elements'
import { SetLoadingContext } from '../context/SetLoadingContext';
import { NotificationMailContext } from '../context/NotificationMailContext';
import { InstallmentContext } from '../context/InstallmentContext';
import { BarNotificationContext } from '../context/BarNotificationContext';
import { SendBirdContext } from '../context/SendbirdContext';
import CollaboratorPopup from './CollaboratorPopup';
import { BottomTabContext } from '../context/BottomTabContext';
import EnterCodeCollabPopup from './EnterCodeCollabPopup';
import CreateCollabGroupPopup from './CreateCollabGroupPopup';
import { responsiveHeight } from 'react-native-responsive-dimensions';
import { SimDataContext } from '../context/SimDataContext';
import { EscrowWalletContext } from '../context/EscrowWalletContext';




const CheckTimeBegin = (_startTime) => {
    const startTime = new Date(_startTime);
    const currentTime = new Date();

    if (startTime < currentTime) {
        return true; // Trả về false nếu startTime nhỏ hơn thời gian hiện tại
    }
    else {
        return false;
    }
}
const CheckTimeEnd = (_endTime) => {
    const endTime = new Date(_endTime);
    const currentTime = new Date();

    if (endTime < currentTime) {
        return true; // Trả về false nếu endTime lớn hơn thời gian hiện tại
    }
    else {
        return false;
    }
}

const CheckIsSale = (_startTime, _endTime) => {
    if (CheckTimeBegin(_startTime) && !CheckTimeEnd(_endTime)) {
        return "HAPPENING";
    }
    else if (!CheckTimeBegin(_startTime)) {
        return "NOT_BEGIN";
    }

    else if (CheckTimeEnd(_endTime)) {
        return "END";
    }

}
const HomeScreen = ({ navigation }) => {
    const { userInfos } = useContext(AuthContext);
    const { RegisterNotification } = useContext(BarNotificationContext);
    const { isLoading } = useContext(SetLoadingContext);
    const { flashSaleData } = useContext(HomeContext);
    const { GetFlashSale, GetDayPromotion, GetSimLastUpdate, GetSimTypesFake, SetPopUpVisible } = useContext(HomeContext);
    const { GetMyNotifications, notificationDatas } = useContext(NotificationMailContext);
    const { GetUnreadMessageCount, unReadMessageCount, RegisterChatReceiver } = useContext(SendBirdContext);

    const { isCollabPopUpVisible, isEnterCodeCollabPopUpVisible, isCreateCollabPopUpVisible } = useContext(BottomTabContext)

    const { GetInstallmentConfig } = useContext(InstallmentContext);
    const {        GetConfigData,  GetBankInfo,} = useContext(AuthContext);
    const {GetCountry} = useContext(SimDataContext);
    const {GetMoneyEscrow} = useContext(EscrowWalletContext);
    const handleSearchtFocus = () => {
        navigation.navigate(AppConst.ScreenConst.SEARCH_SCREEN, { screenParam: AppConst.SearchFrameConst.IS_HOMESEARCH });

    }
    SignInScreen(userInfos.id, userInfos.fullName); //SendbirdSignIn
    const SearchButton = () => {
        return (
            <TouchableOpacity className="flex-1" onPress={() => { handleSearchtFocus() }} activeOpacity={.9}>
                <View className="flex-row flex-1 items-center rounded-full bg-white mx-1">
                    <View className="bg-transparent rounded-full m-3">
                        <Ionicons name="search-outline" color="black" size={20}></Ionicons>
                    </View>
                    <TextInput
                        placeholder='Tìm Kiếm SIM'
                        placeholderTextColor={'gray'}
                        className="text-base mb-1 pl-2"
                        returnKeyType="search"
                        editable={false}
                    />
                </View>
            </TouchableOpacity>
        );
    }
    useEffect(() => {
        setInterval(GetMyNotifications, 15000)
        GetInstallmentConfig();
        RegisterNotification();
        GetConfigData();
        GetBankInfo();

        RegisterChatReceiver();
        GetCountry();
        setInterval(GetUnreadMessageCount, 10000);
        setInterval(GetMoneyEscrow,5000);

    }, []);


    const NotificationBtn = () => {

        var unreadCount = 0;
        if (notificationDatas) {
            console.log("COUNT UNREAD: " + notificationDatas.length)
            unreadCount = notificationDatas.filter((x) => x.isRead === false).length
        }
        return (
            <TouchableOpacity
                className="rounded-full bg-white justify-center items-center mx-1"
                style={{ width: 40, height: 40 }}
                onPress={() => { navigation.navigate(AppConst.StackConst.NATIVE_STACK, { screen: AppConst.ScreenConst.NOTIFICATION_SCREEN }); }}
            >
                <Ionicons name="notifications-outline" size={20} color={argonTheme.COLORS.ERROR} />
                {
                    unreadCount > 0 && (
                        <Badge
                            value={unreadCount}
                            status="error"
                            containerStyle={{ position: 'absolute', top: -5, right: -5 }}
                        />
                    )
                }

            </TouchableOpacity>
        );
    }
    const MyProfileBtn = () => {
        return (
            <TouchableOpacity
                className="rounded-full bg-white justify-center items-center"
                style={{ width: 40, height: 40 }}
                onPress={() => { navigation.navigate(AppConst.StackConst.NATIVE_STACK, { screen: AppConst.ScreenConst.ORDER_SCREEN }); }}
            >
                <Ionicons name="cart-outline" size={20} color={argonTheme.COLORS.ERROR} />
            </TouchableOpacity>
        );
    }
    const HomeHeader = () => {
        return (
            <View className="flex-row justify-center items-center p-2" style={{ position: 'absolute', zIndex: 1000, marginTop: StatusBar.currentHeight }} backgroundColor={argonTheme.COLORS.ERROR}>
                <SearchButton />
                {/*Notification Btn */}
                <NotificationBtn />
                {/*My Profile Btn*/}
                <MyProfileBtn />
            </View>
        );
    }

    return (
        <View style={{ position: "relative", justifyContent: "center", alignItems: "center" }}>
            <SafeAreaView>
                <StatusBar translucent backgroundColor={argonTheme.COLORS.ERROR} />
                {

                    isCollabPopUpVisible ? (
                        <CollaboratorPopup />
                    ) :
                        (null)
                }
                {
                    isEnterCodeCollabPopUpVisible ? (
                        <EnterCodeCollabPopup />
                    ) :
                        (null)
                }

                {
                    isCreateCollabPopUpVisible ? (
                        <CreateCollabGroupPopup />
                    ) :
                        (null)

                }


                {isLoading == true ? (
                    <LoadingScreen />
                ) : null}

                {/* Header */}
                <HomeHeader />
                <View className="mt-10">
                    <ScrollView style={{ backgroundColor: '#f8f8f8f8' }} showsVerticalScrollIndicator={false} showsHorizontalScrollIndicator={false} overScrollMode="never">



                        {/* Utilities */}
                        <View>
                            <Utilities navi={navigation} />
                        </View>

                        {/* Banner */}
                        <View className="justify-center items-center" style={{ height: responsiveHeight(10) }}>
                            <Banner />
                        </View>

                        <View className="mt-2">
                            {
                                useEffect(() => {
                                    GetFlashSale();
                   
                                }, [])
                            }
                            {

                                flashSaleData && CheckIsSale(flashSaleData.startTime,flashSaleData.endTime) === "HAPPENING" ? (
                                    <FlashSales navi={navigation} data={flashSaleData} status ={"HAPPENING"} isSale={true} />
                                ) : (null)

                            }
                            {
                                flashSaleData && CheckIsSale(flashSaleData.startTime,flashSaleData.endTime) === "NOT_BEGIN" ? (
                                    <FlashSales navi={navigation} data={flashSaleData} status ={"NOT_BEGIN"} isSale={false} />
                                ) : (null)

                            }


                        </View>
                        {/* Sim as Networks */}
                        <View className="mt-2">
                            <SimAsNetWorks navi={navigation} />
                        </View>

                        {/* <View className="mt-2">
                            <SimAsFormat navi={navigation} fake={true} />
                        </View> */}

                        <View className="mt-2">
                            <SimAsPrices navi={navigation} />
                        </View>

                        <View className="mt-2">
                            {
                                useEffect(() => {
                                    GetSimTypesFake();
                                }, [])
                            }


                            <SpecialSim navi={navigation} fake={true} />
                        </View>

                        <View className="mt-2">
                            {
                                useEffect(() => {
                                    GetDayPromotion();
                                }, [])
                            }
                            <DayPromotionSim navi={navigation} />
                        </View>

                        <View className="mt-2">
                            {
                                useEffect(() => {
                                    GetSimLastUpdate();
                                }, [])
                            }
                            <RecentUpdateSim navi={navigation} />
                        </View>



                    </ScrollView>
                </View>
            </SafeAreaView>
        </View>
    );

}


export default HomeScreen;
