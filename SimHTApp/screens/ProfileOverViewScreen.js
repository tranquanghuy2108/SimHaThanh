import React, { useContext, useEffect,useState } from 'react';
import { argonTheme } from '../constants';
import { AuthContext } from '../context/AuthContext';
import { Badge } from 'react-native-elements'
import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
} from "react-native-responsive-dimensions";

import Ionicons from 'react-native-vector-icons/Ionicons';
import { TouchableOpacity, Text, Image, View, TextInput, StyleSheet, SafeAreaView, StatusBar, ScrollView, Alert } from 'react-native';
import { AppConst } from '../constants/AppConst';
import { NotificationMailContext } from '../context/NotificationMailContext';
import { MySimContext } from '../context/MySimContext';
import { BottomTabContext } from '../context/BottomTabContext';
import { SearchContext } from '../context/SearchContext';
import { EscrowWalletContext } from '../context/EscrowWalletContext';



const ConvertCurrency = (numberString) => {
    const formattedNumber = parseInt(numberString, 10).toLocaleString('vi-VN', {
        style: 'currency',
        currency: 'VND',
    });
    return formattedNumber;
}

const ProfileOverViewScreen = ({ navigation }) => {
    const { logout, userInfos, DeleteAccount, GetUserInfo, userInfoData, } = useContext(AuthContext);
    const { notificationDatas } = useContext(NotificationMailContext);
    const { SetSearchMySim } = useContext(BottomTabContext);
    const { search } = useContext(MySimContext);
    const {moneyEscrowData} = useContext(EscrowWalletContext);
 
    const handleSearchtFocus = () => {
        navigation.navigate(AppConst.ScreenConst.SEARCH_SCREEN, { screenParam: AppConst.SearchFrameConst.IS_HOMESEARCH });

    }


    const { simUserInfo, GetSimOfUserInfo } = useContext(SearchContext);

    useEffect(() => {
        GetUserInfo();
        GetSimOfUserInfo();
    }, [])

    const ConfirmLogout = (orderID) => {
        Alert.alert(
            'Bạn có muốn đăng xuất?',
            '',
            [
                { text: 'Hủy', },
                { text: 'Đồng ý', onPress: () => logout() }
            ],
            { cancelable: false }
        );
    }

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
    const ChatBoxBtn = () => {
        return (
            <TouchableOpacity
                className="rounded-full bg-white justify-center items-center mx-1"
                style={{ width: 40, height: 40 }}
                onPress={() => { navigation.navigate(AppConst.StackConst.NATIVE_STACK, { screen: AppConst.ScreenConst.NOTIFICATION_SCREEN }); }}
            >
                <Ionicons name="chatbox-ellipses-outline" size={20} color={argonTheme.COLORS.ERROR} />
            </TouchableOpacity>
        );
    }
    const HomeHeader = () => {
        const [eye,SetEyeState] = useState(false);
        const EyeToggle = ()=>{
            SetEyeState(!eye);
        }
        return (
            <View style={{ position: 'absolute', zIndex: 999, width: "100%" }}>
                <View className="flex-row justify-center items-center p-2" style={{ zIndex: 1000, marginTop: StatusBar.currentHeight }} backgroundColor={argonTheme.COLORS.ERROR}>
                    <SearchButton />
                    {/*Notification Btn */}
                    <NotificationBtn />
                    {/*My Profile Btn*/}
                    {/* <ChatBoxBtn /> */}
                </View>
                <View style={styles.scollView}>

                    <ScrollView
                        showsVerticalScrollIndicator={false}
                        showsHorizontalScrollIndicator={false}
                    >
                        {/* Name_Phone */}
                        <TouchableOpacity
                            onPress={() => {
                                navigation.getParent("ACCOUNT").openDrawer();
                            }}

                        >
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
                        </TouchableOpacity>

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
                        <View testID="info_overView" style={styles.info_overview}>
                            <View className="flex-row" style={{ borderBottomColor: "grey", borderBottomWidth: 1, paddingTop: 5, paddingBottom: 10 }}>
                                <View className="flex-1 flex-row">
                                    <Text> Số dư ví</Text>
                                    <TouchableOpacity
                                        onPress ={()=>{EyeToggle()}}
                                    >

                                        <Ionicons style={{ marginLeft:5, color: "black", fontSize: responsiveFontSize(2.8) }} name= {eye?"eye-outline":"eye-off-outline"}></Ionicons>
                                    </TouchableOpacity>
                                </View>


                                <View style={{flexDirection:"row"}}>
                                    <Text style={{ fontWeight: "bold" }}> {eye?ConvertCurrency(moneyEscrowData):"******"}</Text>
                                </View>

                            </View>


                            <View style={{ justifyContent: "space-between", alignItems: "center", flexDirection: "row", marginLeft: responsiveWidth(7), marginRight: responsiveWidth(7), marginTop: 5 }} >
                                <TouchableOpacity
                                    onPress={() => {
                                        navigation.getParent("ESCROW_WALLET_PUSH").openDrawer();
                                    }}

                                >
                                    <View>
                                        {/* <Image
                source={require("../assets/imgs/icon_wallet.png")}
                style={{ width: responsiveHeight(10), height: responsiveHeight(10) }}
                resizeMode={"contain"}
            /> */}
                                        <View style={{ width: responsiveWidth(20), justifyContent: "center", alignItems: "center" }}>
                                            <View style={{ backgroundColor: argonTheme.COLORS.ERROR, height: responsiveWidth(10), width: responsiveWidth(10), borderRadius: responsiveWidth(10), justifyContent: "center", alignItems: "center" }}>
                                                <Ionicons style={{ color: "white", fontSize: responsiveFontSize(2.8) }} name="card-outline"></Ionicons>
                                            </View>
                                            <View style={{ justifyContent: "center", alignItems: "center" }}>
                                                <Text style={{ textAlign: "center", fontSize: responsiveFontSize(1.7) }}> Nạp tiền</Text>
                                            </View>
                                        </View>
                                    </View>
                                </TouchableOpacity>

                                <TouchableOpacity
                                    onPress={() => {
                                        navigation.getParent("ESCROW_WALLET_POP").openDrawer();
                                    }}

                                >
                                    <View className="flex-">
                                        {/* <Image
                source={require("../assets/imgs/icon_wallet.png")}
                style={{ width: responsiveHeight(10), height: responsiveHeight(10) }}
                resizeMode={"contain"}
            /> */}
                                        <View style={{ width: responsiveWidth(20), justifyContent: "center", alignItems: "center" }}>
                                            <View style={{ backgroundColor: argonTheme.COLORS.ERROR, height: responsiveWidth(10), width: responsiveWidth(10), borderRadius: responsiveWidth(10), justifyContent: "center", alignItems: "center" }}>
                                                <Ionicons style={{ color: "white", fontSize: responsiveFontSize(2.8) }} name="download-outline"></Ionicons>
                                            </View>
                                            <View style={{ justifyContent: "center", alignItems: "center" }}>
                                                <Text style={{ textAlign: "center", fontSize: responsiveFontSize(1.7) }}> Rút tiền</Text>
                                            </View>
                                        </View>
                                    </View>
                                </TouchableOpacity>

                                <TouchableOpacity
                                    onPress={() => {
                                        navigation.getParent("ESCROW_WALLET_HISTORY").openDrawer();
                                    }}

                                >
                                    <View>
                                        {/* <Image
                source={require("../assets/imgs/icon_wallet.png")}
                style={{ width: responsiveHeight(10), height: responsiveHeight(10) }}
                resizeMode={"contain"}
            /> */}
                                        <View style={{ width: responsiveWidth(20), justifyContent: "center", alignItems: "center" }}>
                                            <View style={{ backgroundColor: argonTheme.COLORS.ERROR, height: responsiveWidth(10), width: responsiveWidth(10), borderRadius: responsiveWidth(10), justifyContent: "center", alignItems: "center" }}>
                                                <Ionicons style={{ color: "white", fontSize: responsiveFontSize(2.8) }} name="contract-outline"></Ionicons>
                                            </View>
                                            <View style={{ justifyContent: "center", alignItems: "center" }}>
                                                <Text style={{ textAlign: "center", fontSize: responsiveFontSize(1.7) }}> Giao dịch</Text>
                                            </View>
                                        </View>



                                    </View>
                                </TouchableOpacity>
                            </View>


                        </View>
                        {/* Block2 */}
                        <View testID="info_overView" style={styles.info_overview}>

                            <TouchableOpacity
                                onPress={() => {
                                    navigation.getParent("ORDER").openDrawer();
                                }}
                            >
                                <View style={styles.info_row_border} >
                                    <Ionicons name="cart-outline" color="black" size={20}></Ionicons>
                                    <Text style={styles.info_row_text}>
                                        Đơn mua
                                    </Text>
                                </View>

                            </TouchableOpacity>

                            {/* <TouchableOpacity
                                onPress={() => {

                                }}
                            >
                                <View style={styles.info_row_border} >
                                    <Ionicons name="time-outline" color="black" size={20}></Ionicons>
                                    <Text style={styles.info_row_text}>
                                        Sim xem gần đây
                                    </Text>
                                </View>

                            </TouchableOpacity>

                            <TouchableOpacity
                                onPress={() => {

                                }}
                            >
                                <View style={styles.info_row} >
                                    <Ionicons name="heart-outline" color="black" size={20}></Ionicons>
                                    <Text style={styles.info_row_text}>
                                        Sim yêu thích
                                    </Text>
                                </View>

                            </TouchableOpacity> */}

                        </View>

                        {/* Block3 */}
                        <View testID="info_overView" style={styles.info_overview}>

                            <TouchableOpacity
                                onPress={() => {
                                    navigation.getParent("ACCOUNT").openDrawer();
                                }}
                            >
                                <View style={styles.info_row_border} >
                                    <Ionicons name="person-outline" color="black" size={20}></Ionicons>
                                    <Text style={styles.info_row_text}>
                                        Tài khoản
                                    </Text>
                                </View>

                            </TouchableOpacity>
                            {/*                             
                            <TouchableOpacity
                                onPress={() => {
                                    navigation.getParent("MY_AUCTION").openDrawer();
                                }}
                            >
                                <View style={styles.info_row_border} >
                                    <Ionicons name="hammer-outline" color="black" size={20}></Ionicons>
                                    <Text style={styles.info_row_text}>
                                        Đấu giá của tôi
                                    </Text>
                                </View>

                            </TouchableOpacity> */}

                            <TouchableOpacity
                                onPress={() => {
                                    SetSearchMySim("");
                                    search("");
                                    navigation.navigate(AppConst.StackConst.BOTTOM_STACK, {
                                        screen: AppConst.BottomScreenConst.PROFILE_BOTTOM_SCREEN,
                                        params: { screen: AppConst.ScreenConst.MY_SIM_SCREEN },
                                    });

                                    // navigation.navigate(AppConst.StackConst.NATIVE_STACK, { screen: AppConst.ScreenConst.MY_SIM_SCREEN });
                                }}
                            >
                                <View style={styles.info_row_border} >
                                    <Ionicons name="document-text-outline" color="black" size={20}></Ionicons>
                                    <Text style={styles.info_row_text}>
                                        Sim của tôi
                                    </Text>
                                </View>

                            </TouchableOpacity>




                        </View>

                        {/* Block4 */}
                        <View testID="info_overView" style={styles.info_overview}>

                            <TouchableOpacity
                                onPress={() => {
                                    navigation.getParent("POLICY").openDrawer();
                                }}
                            >
                                <View style={styles.info_row_border} >
                                    <Ionicons name="shield-checkmark-outline" color="black" size={20}></Ionicons>
                                    <Text style={styles.info_row_text}>
                                        Chính sách & điều khoản
                                    </Text>
                                </View>

                            </TouchableOpacity>

                            <TouchableOpacity
                                onPress={() => {
                                    navigation.getParent("AUCTION_MANUAL").openDrawer();
                                }}
                            >
                                <View style={styles.info_row_border} >
                                    <Ionicons name="document-text-outline" color="black" size={20}></Ionicons>
                                    <Text style={styles.info_row_text}>
                                        Hướng dẫn đấu giá
                                    </Text>
                                </View>

                            </TouchableOpacity>

                            <TouchableOpacity
                                onPress={() => {
                                    navigation.getParent("AUCTION_RULE").openDrawer();
                                }}
                            >
                                <View style={styles.info_row_border} >
                                    <Ionicons name="newspaper-outline" color="black" size={20}></Ionicons>
                                    <Text style={styles.info_row_text}>
                                        Quy định đấu giá
                                    </Text>
                                </View>

                            </TouchableOpacity>
                            {/* <TouchableOpacity
                                onPress={() => {

                                }}
                            >
                                <View style={styles.info_row_border} >
                                    <Ionicons name="chatbox-outline" color="black" size={20}></Ionicons>
                                    <Text style={styles.info_row_text}>
                                        Đóng góp ý kiến
                                    </Text>
                                </View>

                            </TouchableOpacity> */}

                            <TouchableOpacity
                                onPress={() => {
                                    navigation.getParent("CHANGE_PASSWORD").openDrawer();
                                }}
                            >
                                <View style={styles.info_row_border} >
                                    <Ionicons name="lock-closed-outline" color="black" size={20}></Ionicons>
                                    <Text style={styles.info_row_text}>
                                        Đổi mật khẩu
                                    </Text>
                                </View>

                            </TouchableOpacity>
                            <TouchableOpacity
                                onPress={() => {
                                    ConfirmLogout();
                                }}
                            >
                                <View style={styles.info_row} >
                                    <Ionicons name="log-out-outline" color="black" size={20}></Ionicons>
                                    <Text style={styles.info_row_text}>
                                        Đăng xuất
                                    </Text>
                                </View>

                            </TouchableOpacity>

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
            margin: 18,
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
        info_row_text: {
            marginLeft: 5,
            fontSize: responsiveFontSize(1.8)
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

export default ProfileOverViewScreen;


