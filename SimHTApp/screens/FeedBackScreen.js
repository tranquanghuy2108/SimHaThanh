import React, { useState, useContext } from "react";
import { View, TextInput, TouchableOpacity, Text, ScrollView, StyleSheet,Image, Linking } from 'react-native';
import { OrderContext } from "../context/OrderContext";
import Ionicons from 'react-native-vector-icons/Ionicons';
import { SafeAreaView } from "react-native-safe-area-context";
import { AppConst } from "../constants/AppConst";
import { argonTheme} from "../constants";
import { BottomTabContext } from "../context/BottomTabContext";
import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
} from "react-native-responsive-dimensions";

import { VNPTContext } from "../context/VNPTContext";

const FeedBackScreen = ({ navigation }) => {
    const { orderDatas, GetAllOrder } = useContext(OrderContext);
    const [filterData, SetFilterData] = useState(orderDatas);
    const { GetPackageOfSim } = useContext(VNPTContext);



    const handleExit = () => {
        navigation.navigate(AppConst.ScreenConst.HOME_SCREEN);
    }


    const SearchHeader = () => {
        return (

            <View className="flex-row justify-center items-center py-3 px-4" backgroundColor={argonTheme.COLORS.ERROR} styles={{ position: 'absolute', top: 0, right: 0, left: 0 }}>
                <ExitButton className="flex-end" />
                <SearchButton className="flex-start" />

            </View>

        );
    }
    const SearchButton = () => {
        const { orderKeyWordSearch, SetOrderKeyWorkSearch } = useContext(BottomTabContext);

        const searchSubmit = () => {
            if (orderKeyWordSearch != "") {
                const filteredData = orderDatas.filter(record => record.simNumber.includes(orderKeyWordSearch));
                SetFilterData(filteredData);
            }
            else {
                SetFilterData(orderDatas);
            }
        }
        const handleSearch = (text) => {
            SetOrderKeyWorkSearch(text);
        }
        const handleBlur = () => {
            if (orderKeyWordSearch != "") {
                const filteredData = orderDatas.filter(record => record.simNumber.includes(orderKeyWordSearch));
                SetFilterData(filteredData);
            }
            else {
                SetFilterData(orderDatas);
            }
        }
        return (
            <TouchableOpacity className="flex-1" activeOpacity={.9} onPress={() => { handleInputFocus() }}>
                <View className="flex-row flex-0 items-center rounded-full bg-white mx-1">
                    <View className="bg-transparent rounded-full m-3">
                        <Ionicons name="search-outline" color="black" size={20}></Ionicons>
                    </View>
                    <TextInput
                        placeholder='Tìm kiếm'
                        placeholderTextColor={'gray'}
                        keyboardType="numeric"
                        className="flex-1 text-base pl-2 tracking-wider"
                        returnKeyType="search"
                        editable={true}
                        value={orderKeyWordSearch}
                        onChangeText={handleSearch}
                        onSubmitEditing={searchSubmit}
                        onBlur={handleBlur}
                    />
                </View>
            </TouchableOpacity>

        );
    }
    const ExitButton = () => {
        return (
            // Nút Thoát
            <TouchableOpacity className="p-1 rounded-full bg-white mx-1"
                onPress={() => {

                    handleExit();
                }}>
                {/* <Text
                    style={{ fontSize: 20 }}
                >
                    Thoát
                </Text> */}
                <Ionicons name="chevron-back-outline" color="black" size={26}></Ionicons>
            </TouchableOpacity>
        );
    }
    return (
        <View className="bg-stone-100">
            <SafeAreaView>

                {/* <SearchHeader /> */}

                <View className="" style={{ height: '92%', width: '100%' }}>
                    <ScrollView
                        showsHorizontalScrollIndicator={false}
                        showsVerticalScrollIndicator={false}
                    >
                        <Image
                            source={require("../assets/imgs/banner_vinaphone.png")}
                            style={{ width: '100%', height: responsiveHeight(21) }}
                            resizeMode={"contain"}
                        />

                        <Text style={styles.packageHeaderText}>
                            CÁC GÓI CƯỚC CỦA BẠN
                        </Text>

                        {/* gói cước */}
                        <TouchableOpacity style={styles.buttonFortune}
                            TouchableOpacity={.9}
                            onPress={() => {
                                navigation.navigate(AppConst.StackConst.NATIVE_STACK, { screen: AppConst.ScreenConst.PACKAGE_DETAIL_SCREEN });
                            }}
                        >
                            <View style={styles.card} >
                                {/* header */}

                                <View style={styles.cardHeader}>
                                    <Text className="font-bold" style={{ fontSize: responsiveFontSize(2.5), marginLeft: 10, color: "white" }}>
                                        {"STK10"}
                                    </Text>
                                </View>


                                <View style={styles.cardContent}>
                                    {/* Price */}
                                    <View className="flex-row items-center">
                                        <Image
                                            source={require("../assets/imgs/icon_gold_bag.png")}
                                            style={{ width: responsiveHeight(5), height: responsiveHeight(6) }}
                                            resizeMode={"contain"}
                                        />
                                        <Text style={{ fontSize: responsiveFontSize(1.8) }}>5.000đ</Text>
                                    </View>

                                    {/* Familiar Price */}
                                    <View style={styles.RegisterRow}>
                                        <View >
                                            <Text>5000đ/ngày có 1 GB sử dụng...</Text>
                                        </View>
                                        <TouchableOpacity
                                            style={styles.RegisterBtn}
                                            onPress={() => {
                                                const phoneNumber = '0123456789'; // Số điện thoại của người nhận
                                                const content = 'Nội dung tin nhắn'; // Nội dung tin nhắn
                                                const messageUrl = `sms:${phoneNumber}?body=${encodeURIComponent(content)}`;
                                                Linking.openURL(messageUrl);

                                            }}
                                        >
                                            <Text style={styles.RegisterBtnTxt}>Đăng ký</Text>
                                        </TouchableOpacity>
                                    </View>

                                </View>

                            </View>
                        </TouchableOpacity>

                    </ScrollView>
                </View>

            </SafeAreaView>
        </View>
    );
}
export default FeedBackScreen;


const styles = StyleSheet.create({
    card: {
        backgroundColor: '#f8f8f8f8',
        shadowColor: 'black',
        shadowOffset: { width: 1, height: 1 },
        shadowOpacity: 1,
        shadowRadius: 8,
        elevation: 5,
        margin: 10,
        borderRadius: 5,
    },
    cardHeader: {
        backgroundColor: argonTheme.COLORS.ERROR,
        flex: 1,
        borderTopEndRadius: 5,
        borderTopLeftRadius: 5,
        justifyContent: "center",
        padding: 2
    },
    packageHeaderText: {
        fontWeight: "bold",
        fontSize: responsiveFontSize(2),
        margin: 10,
        textAlign: "center"
    },
    cardContent: {
        marginLeft: 10,
        padding: 5
    },
    RegisterRow: {
        flexDirection: "row",
        justifyContent: "space-between",
        alignItems: "center"
    },
    RegisterBtn: {
        justifyContent: "center",
        backgroundColor: argonTheme.COLORS.ERROR,
        width: responsiveWidth(20),
        height: responsiveHeight(4),
        borderRadius: 10
    },
    RegisterBtnTxt: {
        textAlign: "center",
        color: "white",
        fontWeight: "bold"
    }
});