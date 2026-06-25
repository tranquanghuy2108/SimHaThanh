import React, { useState, useContext } from "react";
import { View, TextInput, TouchableOpacity, Text, ScrollView, StyleSheet, Image, Linking, ToastAndroid } from 'react-native';
import Ionicons from 'react-native-vector-icons/Ionicons';
import { AppConst } from "../constants/AppConst";
import { argonTheme } from "../constants";
import Config from "../constants/Config";
import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize,
    responsiveScreenFontSize
} from "react-native-responsive-dimensions";

import { VNPTContext } from "../context/VNPTContext";


const isValidPhoneNumber = (phoneNumber) => {
    // Loại bỏ các ký tự không phải số (nếu có)
    const sanitizedNumber = phoneNumber.replace(/\D/g, '');

    // Kiểm tra độ dài của số điện thoại
    if (sanitizedNumber.length !== 10 && sanitizedNumber.length !== 11) {
        return false;
    }

    // Kiểm tra đúng định dạng số điện thoại của Việt Nam
    const regex = /^(0[2-9]|84[2-9])(\d{8}|\d{9})$/;
    return regex.test(sanitizedNumber);
}
const ConvertCurrency = (numberString) => {
    const formattedNumber = parseInt(numberString, 10).toLocaleString('vi-VN', {
        style: 'currency',
        currency: 'VND',
    });
    return formattedNumber;
}
const CutPackageName = (inputString) => {

    const splitStrings = inputString.split("_");
    const result = splitStrings[0];
    return result;
}
const TruncateText = (originalText) => {
    const truncatedText = originalText.length > 28
        ? originalText.substring(0, 28) + "..."
        : originalText;
    return truncatedText;
}
const VNPT_Package_Screen = ({ navigation }) => {
    const { vinaPackageDatas } = useContext(VNPTContext);

    const SearchButton = () => {
        const [searchSimNumber, SetSimNumberSearch] = useState("");
        const { GetPackageOfSim } = useContext(VNPTContext);

        const SearchTextChange = (text) => {
            SetSimNumberSearch(text);
        }
        const searchSubmit = () => {
            if (isValidPhoneNumber(searchSimNumber)) {
                GetPackageOfSim(searchSimNumber);
            }
            else {
                ToastAndroid.showWithGravity(
                    "Vui lòng kiểm tra số điện thoại!",
                    ToastAndroid.SHORT,
                    ToastAndroid.BOTTOM,
                );
            }
        }

        return (
            <View className="flex-row justify-center items-center py-3 px-4" backgroundColor={argonTheme.COLORS.ERROR} styles={{ position: 'absolute', top: 0, right: 0, left: 0 }}>
                <TouchableOpacity className="flex-1" activeOpacity={.9} onPress={() => { handleInputFocus() }}>
                    <View className="flex-row flex-0 items-center rounded-full bg-white mx-1">
                        <TextInput
                            placeholder='Nhập số thuê bao Vina'
                            placeholderTextColor={'gray'}
                            keyboardType="numeric"
                            className="flex-1 text-base tracking-wider"
                            returnKeyType="search"
                            editable={true}
                            style={{ padding: 10 }}
                            maxLength={10}
                            value={searchSimNumber}
                            onChangeText={SearchTextChange}
                            onSubmitEditing={searchSubmit}
                        />
                    </View>
                </TouchableOpacity>
                <TouchableOpacity className="p-1 rounded-full bg-white mx-1"
                    onPress={() => {
                        searchSubmit();
                    }}>
                    <Ionicons name="search-outline" color="black" size={26}></Ionicons>
                </TouchableOpacity>
            </View>
        );
    }
    const CutString = (inputString) => {
        const splitStrings = inputString.split(" + ");
  
        return splitStrings;
    };
    const transformString = (inputString) => {
        const delimiter = "_";
        const targetChar = "T";
      
        const index = inputString.indexOf(delimiter);
        if (index === -1 || !inputString.includes(targetChar)) {
          return inputString; // Trả về chuỗi ban đầu nếu không có dấu "_" hoặc không có ký tự "T"
        }
      
        const numberString = inputString.substring(index + 1, inputString.indexOf(targetChar));
        const prefix = inputString.slice(0, index);
      
        const transformedString = numberString.concat(prefix);
        return transformedString;
      };
    return (
        <View className="bg-stone-100">


            {/* <SearchHeader /> */}

            <View className="" style={{ backgroundColor: "white" }}>
                <View style={{ backgroundColor: "yellow" }}>
                    <Image
                        source={require('../assets/imgs/banner_vinaphone.png')}
                        style={{ width: '100%', height: responsiveHeight(20) }}
                        resizeMode={"stretch"}
                    />

                </View>

                <SearchButton />
                {
                    vinaPackageDatas ? (
                        <ScrollView

                            style={{ marginBottom: responsiveHeight(60) }}
                        >
                            <Text style={styles.packageHeaderText}>
                                CÁC GÓI CƯỚC CỦA BẠN
                            </Text>
                            {
                                vinaPackageDatas && vinaPackageDatas.map((item) => {
                                    return (
                                        <View style={styles.buttonFortune}
                                        >
                                            <View style={styles.card} >
                                                {/* header */}
                                                <View style={styles.cardHeader}>
                                                    <Text className="font-bold" style={{ fontSize: responsiveFontSize(2.5), marginLeft: 10, color: "white" }}>
                                                        {item.name}
                                                    </Text>
                                                </View>
                                                <View style={styles.cardContent}>
                                                    {/* Familiar Price */}
                                                    {
                                                        CutString(item.summary).map((item) => {
                                                            return (
                                                                <View className="flex-row items-center" style={{ }}>
                                                                    <View style={{}}>
                                                                        <Image
                                                                            source={require("../assets/imgs/icon_pack_check.png")}
                                                                            style={{ width: responsiveHeight(4), height: responsiveHeight(3) }}
                                                                            resizeMode={"contain"}
                                                                        />
                                                                    </View>
                                                                    <View style={{ flex: 1 }}>

                                                                        <Text style={styles.incentivesBodyTxt}>{`${item}`}</Text>
                                                                    </View>
                                                                </View>
                                                            );
                                                        })
                                                    }

                                                    {/* Price */}
                                                    <View className="flex-row items-center">
                                                        <Image
                                                            source={require("../assets/imgs/icon_gold_bag.png")}
                                                            style={{ width: responsiveHeight(5), height: responsiveHeight(6) }}
                                                            resizeMode={"contain"}
                                                        />
                                                        <Text style={{ fontSize: responsiveFontSize(1.8) }}>{ConvertCurrency(item.price)}</Text>
                                                    </View>

                                                    <View style={styles.RegisterRow}>
                                                        <TouchableOpacity
                                                            style={styles.RegisterBtn}
                                                            key={item.id}
                                                            onPress={() => {
                                                                const phoneNumber = '1543'; // Số điện thoại của người nhận
                                                                const content = transformString(item.name) + " " + "DN" + " " + Config.VINAPHONE_CUSTOMER_ID; // Nội dung tin nhắn
                                                                const messageUrl = `sms:${phoneNumber}?body=${encodeURIComponent(content)}`;
                                                                Linking.openURL(messageUrl);

                                                            }}
                                                        >
                                                            <Text style={styles.RegisterBtnTxt}>Đăng ký</Text>
                                                        </TouchableOpacity>
                                                    </View>

                                                </View>

                                            </View>
                                        </View>

                                    )
                                })
                            }

                        </ScrollView>
                    ) :
                        (
                            <View>

                            </View>
                        )
                }
            </View>


        </View>
    );
}
export default VNPT_Package_Screen;


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
    incentivesBodyTxt: {
        textAlign: "center",
        fontSize: responsiveScreenFontSize(2),
        textAlign: "left"
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
        justifyContent: "center",
        alignItems: "center",

    },
    RegisterBtn: {
        justifyContent: "center",
        backgroundColor: argonTheme.COLORS.ERROR,
        width: responsiveWidth(20),
        height: responsiveHeight(4),
        borderRadius: 5
    },
    RegisterBtnTxt: {
        textAlign: "center",
        color: "white",
        fontWeight: "bold"
    }
});