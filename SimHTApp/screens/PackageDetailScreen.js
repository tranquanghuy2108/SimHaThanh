import { React } from 'react';
import { Dimensions, ScrollView, StyleSheet, TouchableOpacity, View, Image, StatusBar, Text, Linking } from "react-native";
// Argon themed components
import { argonTheme } from "../constants";

import {
    responsiveScreenHeight,
    responsiveScreenWidth,
    responsiveScreenFontSize
} from "react-native-responsive-dimensions";
import Config from '../constants/Config';


const ConvertCurrency = (numberString) => {
    const formattedNumber = parseInt(numberString, 10).toLocaleString('vi-VN', {
        style: 'currency',
        currency: 'VND',
    });
    return formattedNumber;
}

const CutString = (inputString) => {
    const splitStrings = inputString.split(" + ");
    return splitStrings;
}
const CutPackageName = (inputString) => {

    const splitStrings = inputString.split("_");
    const result = splitStrings[0];
    return result;
}

const PackageDetailScreen = ({ navigation, route }) => {

    const { packageData } = route.params;
    return (
        <View style={styles.container}>

            <StatusBar translucent backgroundColor={argonTheme.COLORS.ERROR} />
            <View testID="package_Info" style={styles.packageInfo}>

                <View testID="header_Info">
                    <View>
                        <Text style={styles.headerInfoText}>{packageData.name}</Text>
                    </View>

                    <View style={styles.headerInfoOverView}>
                        <View style={styles.headerInfoItem}>
                            <Text>{`${ConvertCurrency(packageData.price)}`}</Text>
                            <Image
                                source={require("../assets/imgs/icon_wallet.png")}
                                style={{ width: responsiveScreenHeight(10), height: responsiveScreenHeight(10) }}
                                resizeMode={"contain"}
                            />
                        </View>
                        <View style={styles.headerInfoItem}>
                            <Text>Tiết kiệm</Text>
                            <Image
                                source={require("../assets/imgs/icon_calendar_package.png")}
                                style={{ width: responsiveScreenHeight(8), height: responsiveScreenHeight(8) }}
                                resizeMode={"contain"}
                            />
                        </View>
                    </View>


                </View>

                <View testID="Body_Info">
                    <View>
                        <Text style={styles.incentivesHeaderTxt}>ƯU ĐÃI</Text>
                    </View>

                    <View className="mx-2">
                        <Text style={styles.incentivesBodyTxt}>{`Giá cước: ${ConvertCurrency(packageData.price)}`}</Text>
                        <Text style={styles.incentivesBodyTxt}>Ưu đãi:</Text>
                        {
                            CutString(packageData.summary).map((item) => {
                                return (
                                    <Text style={styles.incentivesBodyTxt}>{`+ ${item}`}</Text>
                                );
                            })
                        }



                    </View>


                </View>


                <ScrollView style={{}}>


                    {/* Card Sim Info */}
                    <View >


                    </View>



                </ScrollView>
            </View>


            {/* Order Button */}
            <View style={styles.coverOrderBtn}>
                <TouchableOpacity activeOpacity={.9}

                    style={styles.orderButton}
                    onPress={() => {
                        const phoneNumber = '1543'; // Số điện thoại của người nhận
                        const content = CutPackageName(packageData.name)+ " "+ "DN"+ " "+ Config.VINAPHONE_CUSTOMER_ID;
             
                        const messageUrl = `sms:${phoneNumber}?body=${encodeURIComponent(content)}`;
                        Linking.openURL(messageUrl);

                    }}
                >
                    <Text style={{}}>
                        <Text style={{ color: "white", fontWeight: "bold" }} >
                            ĐĂNG KÝ
                        </Text>
                    </Text>

                </TouchableOpacity>
            </View>

        </View>
    );

}


export default PackageDetailScreen;

const styles = StyleSheet.create({
    container: {
        flex: 1,
    },
    packageInfo: {
        backgroundColor: "white",
        flex: 1,


    },
    headerInfoOverView: {
        flexDirection: "row",
    },
    headerInfoTxt: {
        textAlign: "center",
        fontWeight: "bold"
    },
    headerInfoItem: {
        flex: 1,
        alignItems: "center"
    },
    incentivesHeaderTxt: {
        textAlign: "center",
        fontWeight: "bold",
        fontSize: responsiveScreenFontSize(2)
    },
    incentivesBodyTxt: {
        textAlign: "center",
        fontSize: responsiveScreenFontSize(2),
        textAlign: "left"
    },
    headerInfoText: {
        textAlign: "center",
        fontWeight: "bold",
        fontSize: responsiveScreenFontSize(3)
    },
    cardContainer: {
        position: 'relative',
        width: 'auto',
        height: responsiveScreenHeight(25),
        marginLeft: responsiveScreenWidth(4),
        marginRight: responsiveScreenWidth(4),
    },
    cardImage: {
        borderRadius: 15,
        width: '100%',
        height: '100%',
        position: 'absolute'
    },
    cardContent: {
        padding: 15
    },
    orderSim: {
        margin: 15,
        backgroundColor: 'white',
        alignItems: 'center',
        borderRadius: 10,

    },
    simFeature: {
        margin: 15,
        backgroundColor: 'white',
        borderRadius: 10,
        padding: 15
    },
    input: {
        width: "100%",
        borderRadius: 10,
        flexDirection: "row",
        alignContent: "center",
        justifyContent: "center",
        borderWidth: 1,
        borderColor: 'grey',
        backgroundColor: "white",
        marginTop: 5
    },
    coverOrderBtn: {
        position: "absolute",
        bottom: 0,
        left: 0,
        right: 0,
        backgroundColor: "white",
        padding: 10,
    },
    orderButton: {
        borderRadius: 10,
        flexDirection: "row",
        alignContent: "center",
        justifyContent: "center",
        borderColor: 'grey',
        padding: 10,
        alignItems: "center",
        backgroundColor: argonTheme.COLORS.ERROR,

    },

    checkboxWrapper: {
        width: 20,
        height: 20,
        borderWidth: 1,
        borderColor: '#dddddd',
        backgroundColor: '#dddddd',
        padding: 2,
        marginRight: 10,
        borderRadius: 3,
    },
    checkbox: {
        flex: 1,
        backgroundColor: '#1183d2',
        borderRadius: 3,
    },
});