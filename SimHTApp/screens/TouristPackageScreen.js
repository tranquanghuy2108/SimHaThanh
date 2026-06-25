import React, { useState, useContext, useEffect  } from "react";
import { View, TextInput, TouchableOpacity, Text, ScrollView, StyleSheet, Image, Linking, ToastAndroid } from 'react-native';
import Ionicons from 'react-native-vector-icons/Ionicons';
import { AppConst } from "../constants/AppConst";
import { argonTheme } from "../constants";
import Config from "../constants/Config";
import HTMLView from 'react-native-htmlview';
import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize,
    responsiveScreenFontSize
} from "react-native-responsive-dimensions";

import { TouristPackageContext } from "../context/TouristPackageContext";

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
const TouristPackageScreen = (props) => {
    const { simTouristPackages } = useContext(TouristPackageContext);
    const { GetSimTouristPackage } = useContext(TouristPackageContext);
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
    useEffect(() => {
        GetSimTouristPackage();
    }, []);
    return (
        <View className="bg-stone-100">
            {/* <SearchHeader /> */}
            <View className="" style={{ backgroundColor: "white" }}>
                <View style={{ backgroundColor: "yellow" }}>
                    <Image
                        source={require("../assets/imgs/sim-du-lich.png")}
                        style={{ width: '100%', height: responsiveHeight(25) }}
                        resizeMode={"stretch"}
                    />
                </View>
                {/* <SearchButton /> */}
                { simTouristPackages ? (
                        <ScrollView
                            style={{ marginBottom: responsiveHeight(50), flexDirection: 'row', alignContent: 'space-between',flexWrap: 'wrap' }}
                        >
                            {
                                simTouristPackages.map((item) => {
                                    return (
                                        <View style={styles.buttonFortune}
                                        >
                                            <View style={styles.card} >
                                                {/* header */}
                                                <View style={styles.cardHeader}>
                                                    <Text className="font-bold" style={styles.packageHeaderText}>
                                                        {item.name}
                                                    </Text>
                                                </View>
                                                <View style={styles.cardContent}>
                                                    <HTMLView
                                                        value={item.summary}
                                                        stylesheet={styles.cardContent}
                                                    />
                                                    {/* Price */}
                                                    <View className="flex-row items-center mt-5">
                                                        <Image
                                                            source={require("../assets/imgs/icon-price-tag-256.png")}
                                                            style={{ width: responsiveHeight(4), height: responsiveHeight(4) }}
                                                            resizeMode={"contain"}
                                                        />
                                                        <Text className="mx-3" style={{ fontSize: responsiveFontSize(3), fontWeight: "900" }}>{ConvertCurrency(item.price)}</Text>
                                                    </View>
                                                    <View style={styles.RegisterRow}>
                                                        <TouchableOpacity
                                                            style={styles.RegisterBtn}
                                                            onPress={() => {
                                                                var simDataParam = {
                                                                    id: item.id,
                                                                    packageName: item.name,
                                                                    networkID: "",
                                                                    networkName:  "item.network",
                                                                    description: item.description,
                                                                    isSaleActive: false,
                                                                    summary: item.summary,
                                                                    price: item.price,
                                                                    priceOnSale: null,
                                                                }
                                                                props.navigation.push(AppConst.StackConst.NATIVE_STACK, { screen: AppConst.ScreenConst.PURCHASE_SIMDATA, params: { simDataParam: simDataParam } })
                                                            }}
                                                        >
                                                            <Text style={styles.RegisterBtnTxt }>Mua sim</Text>
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
export default TouristPackageScreen;


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
        flex: 0,
        borderTopEndRadius: 5,
        borderTopLeftRadius: 5,
        justifyContent: "center",
        textAlign: "center",
        height: responsiveHeight(5),
        padding: 2
    },
    packageHeaderText: {
        fontWeight: "bold",
        fontSize: responsiveFontSize(3.5),
        margin: 1,
        color: "white",
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
        width: responsiveWidth(30),
        height: responsiveHeight(5),
        borderRadius: 5
    },
    RegisterBtnTxt: {
        textAlign: "center",
        color: "white",
        fontSize: responsiveFontSize(3),
        fontWeight: "900"
    },
    buttonFortune: {
        width: responsiveWidth(100)
    }
});