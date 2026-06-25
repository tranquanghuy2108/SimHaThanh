import React, { useContext, useEffect } from 'react';
import { argonTheme } from '../constants';


import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
} from "react-native-responsive-dimensions";

import Ionicons from 'react-native-vector-icons/Ionicons';
import { TouchableOpacity, Text, Image, View, StyleSheet, SafeAreaView, StatusBar, ScrollView, Alert } from 'react-native';
import { AppConst } from '../constants/AppConst';
import { AuthContext } from '../context/AuthContext';
import { SearchContext } from '../context/SearchContext';

const ConvertCurrency = (numberString) => {
    const formattedNumber = parseInt(numberString, 10).toLocaleString('vi-VN', {
        style: 'currency',
        currency: 'VND',
    });
    return formattedNumber;
}

const AccountScreen = (props) => {

    const { logout, userInfos, DeleteAccount, GetUserInfo, userInfoData, } = useContext(AuthContext);
    const { simUserInfo, GetSimOfUserInfo } = useContext(SearchContext);


    useEffect(() => {
        GetUserInfo();
        GetSimOfUserInfo();
    }, [])
    const DeleteAccountBtn = () => {
        return (
            <TouchableOpacity
                className="rounded-full bg-white justify-center items-center mx-1"
                style={{ width: 40, height: 40 }}
                onPress={() => {
                    Alert.alert(
                        'Thông báo',
                        'Bạn có chắc chắn muốn xóa tài khoản!',
                        [
                            { text: 'Đồng ý', onPress: () => DeleteAccount() },
                            { text: 'Hủy', onPress: () => console.log('Đã hủy'), style: 'cancel' },
                        ],
                        { cancelable: false }
                    );
                }}
            >
                <Ionicons name="trash-outline" size={20} color={argonTheme.COLORS.ERROR} />
            </TouchableOpacity>
        );
    }
    const ExitButton = () => {
        return (
            // Nút Thoát
            <TouchableOpacity className="p-1 rounded-full bg-white mx-1"
                onPress={() => {
                    props.navigation.closeDrawer();
                }}>
                <Ionicons name="chevron-back-outline" color="black" size={26}></Ionicons>
            </TouchableOpacity>
        );
    }

    const EditAccountBtn = () => {
        return (
            <TouchableOpacity
                className="rounded-full bg-white justify-center items-center"
                style={{ width: 40, height: 40 }}
                onPress={() => { props.navigation.navigate(AppConst.StackConst.NATIVE_STACK, { screen: AppConst.ScreenConst.UPDATE_PROFILE_SCREEN }); }}
            >
                <Ionicons name="pencil-outline" size={20} color={argonTheme.COLORS.ERROR} />
            </TouchableOpacity>
        );
    }
    const Title = () => {
        return (
            <View className="flex-1 items-center justify-center">
                <Text style={{ color: "white", fontWeight: "bold", fontSize: responsiveFontSize(2.2) }}>Cá nhân</Text>
            </View>

        );
    }
    const HomeHeader = () => {
        return (
            <View style={{ position: 'absolute', zIndex: 999, width: "100%" }}>
                <View className="flex-row justify-center items-center p-2" style={{ zIndex: 1000, marginTop: StatusBar.currentHeight }} backgroundColor={argonTheme.COLORS.ERROR}>
                    <ExitButton />
                    <Title />
                    {/*Notification Btn */}
                    <DeleteAccountBtn />
                    {/*My Profile Btn*/}
                    <EditAccountBtn />
                </View>
                <View style={styles.scollView}>

                    <ScrollView
                        showsVerticalScrollIndicator={false}
                        showsHorizontalScrollIndicator={false}
                    >
                        {/* Name_Phone */}
                        <View style={styles.info_name_overview}>


                            <View style={styles.avatarContainer}>
                                <Image
                                    source={{ uri: `data:image/jpeg;base64,${userInfos.avatar}` }}
                                    style={styles.avatar}
                                    resizeMode="contain"
                                />
                            </View>


                            <View style={styles.info_name_row}>
                                <Text style={styles.info_name_text}>{userInfos.fullName}</Text>
                                <Text style={styles.info_phone_text}>{userInfos.username}</Text>
                            </View>

                        </View>

                        {
                            userInfoData && userInfoData.isAgent ? (
                                <View testID="info_overView1" style={styles.simCountTable}>
                                    <View>
                                        <View style={styles.simCountItem}>
                                            <Text style={styles.simCountText}>GIÁ TRỊ BẢNG SIM</Text>
                                        </View>
                                        <View>
                                            <Text style={styles.simCountValueText}>{simUserInfo ? ConvertCurrency(simUserInfo.totalPrice) : ""}</Text>
                                        </View>
                                    </View>

                                    <View style={styles.simCountBetween}>

                                    </View>

                                    <View>
                                        <View style={styles.simCountItem}>
                                            <Text style={styles.simCountText}>SỐ LƯỢNG SIM</Text>
                                        </View>
                                        <View>
                                            <Text style={styles.simCountValueText}>{simUserInfo ? simUserInfo.totalSim : ""}</Text>
                                        </View>
                                    </View>
                                </View>
                            ) :
                                (null)
                        }

                        {/* Block1 */}
                        <View testID="info_overView" style={styles.info_overview}>
                            <View style={{ flex: 1 }}>
                                <Text style={{ textAlign: "center", fontWeight: "bold" }}> THÔNG TIN TÀI KHOẢN</Text>
                            </View>
                            {/* PhoneNumber */}
                            
                            <View className="flex-row items-center">
                                <View className="justify-center items-center" testID="left" style={{ width: responsiveWidth(7), height: responsiveHeight(3) }}>
                                    <Image source={require('../assets/imgs/icon_user_phone.png')} style={{ width: responsiveWidth(6), height: responsiveHeight(3), }} resizeMode="contain" />
                                </View>
                
                                <Text>{userInfos.username!=null && userInfos.username!=""?userInfos.username:"----------------------------------------------"}</Text>
                            </View>

                            {/* Gmail */}
                            <View className="flex-row items-center">
                                <View className="justify-center items-center" testID="left" style={{ width: responsiveWidth(7), height: responsiveHeight(3) }}>
                                    <Image source={require('../assets/imgs/icon_user_gmail.png')} style={{ width: responsiveWidth(4), height: responsiveHeight(3), }} resizeMode="contain" />
                                </View>
                     
                                <Text>{userInfos.email!=null && userInfos.email!=""?userInfos.email:"----------------------------------------------"}</Text>
                            </View>

                            {/* Website */}
                            {/* <View className="flex-row items-center">
                                <View className="justify-center items-center" testID="left" style={{ width: responsiveWidth(7), height: responsiveHeight(3) }}>
                                    <Image source={require('../assets/imgs/icon_user_gmail.png')} style={{ width: responsiveWidth(4), height: responsiveHeight(3), }} resizeMode="contain" />
                                </View>
                                <Text>{userInfos.website}</Text>
                            </View> */}
                            {/* Location */}
                            <View className="flex-row items-center">
                                <View className="justify-center items-center" testID="left" style={{ width: responsiveWidth(7), height: responsiveHeight(3) }}>
                                    <Image source={require('../assets/imgs/icon_user_location.png')} style={{ width: responsiveWidth(4), height: responsiveHeight(3), }} resizeMode="contain" />
                                </View>
                                <Text>{userInfos.address!=null && userInfos.address!=""?userInfos.address:"----------------------------------------------"}</Text>
                            </View>

                        </View>

                    </ScrollView>
                </View>
            </View>
        );
    }

    return (
        <View>
            <SafeAreaView>
                <StatusBar translucent backgroundColor={argonTheme.COLORS.ERROR} />

                <View style={styles.container}>
                    <View style={styles.container_header}>
                        <Text>Hello</Text>
                    </View>
                    <HomeHeader />
                </View>
            </SafeAreaView>
        </View>
    )
}
const styles = StyleSheet.create(
    {
        avatarContainer: {

            backgroundColor: "white",
            borderRadius: 62,
        },
        avatar: {
            width: responsiveHeight(10),
            height: responsiveHeight(10),
            borderRadius: 62,
            borderWidth: 0,
        },
        container: {
            backgroundColor: '#f0eded',
            position: "relative",
            flex: 0,
            height: "100%",
            width: "100%",
        },
        container_header: {
            height: responsiveHeight(30),
            backgroundColor: argonTheme.COLORS.ERROR,
            width: "100%",
            borderBottomRightRadius: 20,
            borderBottomLeftRadius: 20,
        },
        scollView: {
            backgroundColor: "transparent",
            height: responsiveHeight(76),
            margin: 25,
        },
        info_name_overview: {
            flexDirection: "row",
            marginBottom: 10,
        },
        info_name_row: {
            justifyContent: "center",
            marginLeft: 10,
        },
        info_name_text: {
            fontWeight: "bold",
            color: "white",
            fontSize: responsiveFontSize(2.3)
        },
        info_phone_text: {
            fontWeight: "bold",
            color: "white",
            fontSize: responsiveFontSize(2)
        },

        simCountTable: {
            backgroundColor: "white",
            borderRadius: 10,
            marginBottom: 10,
            padding: 20,
            shadowOffset: { width: 0, height: 2 },
            shadowOpacity: 1,
            shadowRadius: 8,
            elevation: 1,
            flexDirection: "row",
            alignItems: 'center',
            justifyContent: "center",
            justifyContent: 'space-between',

        },
        simCountBetween: {

            width: 1,
            height: responsiveHeight(3),
            backgroundColor: "grey",
        },
        simCountItem: {
            alignItems: "center",

        },
        simCountText: {
            fontWeight: "bold",
            textAlign: "center",
            color: "black",
            fontSize: responsiveFontSize(1.7)
        },
        simCountValueText: {
            fontWeight: "bold",
            textAlign: "center",
            color: "#1090ad",
            fontSize: responsiveFontSize(1.7)
        },
        info_overview: {
            backgroundColor: "white",
            borderRadius: 10,
            marginBottom: 10,
            padding: 10,
            shadowOffset: { width: 0, height: 2 },
            shadowOpacity: 1,
            shadowRadius: 8,
            elevation: 1,
        },
        info_row: {
            padding: 5,
            flexDirection: "row",
            margin: 5,
        },
        info_row_border: {
            padding: 5,
            margin: 5,
            flexDirection: "row",
            borderBottomColor: "#dbdbdb",
            borderBottomWidth: 1,

        },
        overview: {
            height: 'auto',
            borderRadius: 3,
            padding: 10,
            margin: 4,
            shadowOpacity: .1,
            shadowRadius: 3,
            elevation: 1,

            shadowColor: 'black',

        },
        textRow: {
            textAlign: "auto",
        },
        texHeader: {
            fontWeight: "bold",
            fontSize: responsiveFontSize(2.2),
        },
        findSim: {
            fontWeight: "bold",
            fontSize: responsiveFontSize(2.4),
            color: argonTheme.COLORS.ERROR,
        },
        emphasizTxt: {
            fontWeight: "bold",
            fontSize: responsiveFontSize(2.1),
            marginLeft: 5,
            marginRight: 5,
        },
        textContent: {
            textAlign: "justify",
            marginLeft: 5,
            marginRight: 5,
            fontSize: responsiveFontSize(2.1)
        },
        textParentContent: {
            textAlign: "justify",
            fontSize: responsiveFontSize(2.1)
        },
        cellTableTxt: {
            textAlign: "justify",
            fontSize: responsiveFontSize(1.9)
        },
        cellTable: {
            borderWidth: 1,
            borderColor: 'black',
            flex: 1,
            alignItems: "center",
            width: 100,
        },
        point: {
            alignItems: "center",
            flex: 1,
            backgroundColor: argonTheme.COLORS.ERROR,
            width: "auto",
            margin: 1,
            marginTop: 20,
            marginBottom: 20,
            padding: 15,
            borderRadius: 10

        },
        pointTxt: {
            color: "white",
            fontWeight: "bold",
            fontSize: responsiveFontSize(2.2)
        },
        improveSim: {
            alignItems: "center",
            flex: 1,
            backgroundColor: argonTheme.COLORS.ERROR,
            width: "auto",
            margin: 1,
            padding: 15,
            borderRadius: 10
        },
        bottomSim: {
            flexDirection: "row",
            width: "100%",
            alignItems: "center",
            padding: 5,
            margin: 5,


            justifyContent: "center",
        },
        buttonSim: {
            backgroundColor: "white",
            padding: 5,
            margin: 5,
            borderRadius: 5,
        }
    });

export default AccountScreen;