import React, { useContext, useState } from 'react';
import { argonTheme } from '../constants';
import * as Clipboard from 'expo-clipboard';

import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
} from "react-native-responsive-dimensions";
import Ionicons from 'react-native-vector-icons/Ionicons';
import {
    StyleSheet,
    StatusBar,
    View,
    TouchableOpacity,
    SafeAreaView,
    Text,
    ScrollView,
    TextInput,
    ToastAndroid

} from "react-native";
import Config from '../constants/Config';
import { AuthContext } from '../context/AuthContext';
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
const EscrowWalletPushManualScreen = ({ navigation, route }) => {
    const { userInfos,bankInfo } = useContext(AuthContext);
    const {moneyEscrowData} = useContext(EscrowWalletContext);
    const ExitButton = () => {
        return (
            // Nút Thoát
            <TouchableOpacity className="p-1 rounded-full bg-white mx-1 "
                onPress={() => {
                    navigation.goBack();
                }}>
                <Ionicons name="chevron-back-outline" color="black" size={26}></Ionicons>
            </TouchableOpacity>
        );
    }
    const Title = () => {
        return (
            <View className="flex-1 items-center justify-center">
                <Text style={{ color: "white", fontWeight: "bold", fontSize: responsiveFontSize(2.2) }}>Nạp ký quỹ</Text>
            </View>

        );
    }
    const handleCopyCode = async (value) => {
        try {
            await Clipboard.setString(value);
            console.log('Sao chép thành công!');
            ToastAndroid.showWithGravity(
                'Sao chép thành công!',
                ToastAndroid.LONG,
                ToastAndroid.BOTTOM,
            );
        } catch (error) {
            console.log('Lỗi khi sao chép:', error);
            ToastAndroid.showWithGravity(
                'Sao chép thất bại!',
                ToastAndroid.LONG,
                ToastAndroid.BOTTOM,
            );
        }
    };
    const CardContentRow = ({ data }) => {
        return (
            <View style={styles2.cardRow}>
                <View style={styles2.cardHeader}>
                    <Text style={styles2.cardHeaderText}>{data.name}</Text>
                </View>
                <View style={styles2.cardContent}>
                    <Text style={styles2.cardContentText}>{data.value}</Text>
                </View>
                <TouchableOpacity

                    activeOpacity={0.2}
                    onPress={() => { handleCopyCode(data.value) }}
                >
                    <Ionicons name="copy-outline" color={"black"} size={19}></Ionicons>
                </TouchableOpacity>
            </View>
        )

    }

    const PushMoneyManual = () => {

        var cardContentDatas = [
            {
                "name": "Ngân hàng",
                "value": bankInfo ? bankInfo.name: ""
            },
            {
                "name": "Số tài khoản",
                "value":  bankInfo ? bankInfo.number: ""
            },
            {
                "name": "Số tiền",
                "value": ConvertCurrency(route.params.moneyData)
            },
            {
                "name": "Chủ tài khoản",
                "value":  bankInfo ? bankInfo.owner: ""
            },
            {
                "name": "Nội dung",
                "value": `NKQ ${userInfos.username}`
            },
        ];

        return (
            <View style={styles2.card3}>

                <View style={styles2.card}>
                    {
                        cardContentDatas.map(content => {
                            return (
                                <CardContentRow data={content} />
                            );
                        })
                    }
                </View>
                <View>
                    <Text style={styles2.manualText}>
                        Để nạp tiền ký quỹ tham gia đấu giá, bạn vui lòng chuyển khoản số tiền và cú pháp đúng như trên.
                    </Text>
                    <Text style={styles2.manualTextNotice}>
                        Chú ý:
                    </Text>
                    <Text style={styles2.manualText}>
                        - Ghi đúng nội dung chuyển khoản.
                    </Text>
                    <Text style={styles2.manualText}>
                        - Trường hợp hệ thống chưa tự động cộng số dư sau 10 phút, hãy liên hệ bộ phận support để được hỗ trợ kiểm tra.
                    </Text>
                </View>

            </View>




        )
    }
  


    return (
        <SafeAreaView style={{}}>

            <View className="flex-row p-2" style={{ zIndex: 1000, marginTop: StatusBar.currentHeight }} backgroundColor={argonTheme.COLORS.ERROR}>
                <ExitButton />
                <Title />
            </View>

            <ScrollView className="mx-2" style={{ marginBottom: responsiveHeight(10) }}>
                <View >
                    <View style={styles2.card2}>
                        <Text style={styles2.nameText}>{userInfos.fullName.toUpperCase()}</Text>
                        <Text style={styles2.moneyText}>{`${ConvertCurrency(moneyEscrowData)}`}</Text>
                    </View>
    
                    {
                        route.params.moneyData != "" && !isNaN(route.params.moneyData) && route.params.moneyData != "0" ? (
                            <PushMoneyManual />
                        ) : (null)
                    }
                    <TouchableOpacity activeOpacity={.9}

                        style={styles2.orderButton}
                        onPress={() => {
                            navigation.navigate(AppConst.StackConst.NATIVE_STACK, { screen: "EscrowWalletHistoryScreen" });
                 
                        }}
                    >
                        <Text style={{}}>

                            <Text style={{ color: "white", fontWeight: "bold" }} >
                                {`Xong`}

                            </Text>
                        </Text>

                    </TouchableOpacity>

                </View>
            </ScrollView>

        </SafeAreaView>
    )


}

const styles2 = StyleSheet.create({
    orderButton: {
        borderRadius: 10,
        flexDirection: "row",
        alignContent: "center",
        justifyContent: "center",
        borderColor: 'grey',
        padding: 10,
        alignItems: "center",
        backgroundColor: argonTheme.COLORS.ERROR,
        marginTop: 10,
    
      },
    card: {
        backgroundColor: '#e6e6e6',
        marginRight: 1,
        marginLeft: 1,
        marginTop: 5,
        marginBottom: 5,
        padding: 10,
        borderRadius: 5,
    },
    card2: {
        backgroundColor: 'white',
        shadowColor: 'black',
        shadowOffset: { width: 1, height: 1 },
        shadowOpacity: 1,
        shadowRadius: 4,
        marginRight: 1,
        marginLeft: 1,
        marginTop: 15,
        marginBottom: 5,
        padding: 12,
        elevation: 5,
        borderRadius: 5,
    },

    card3: {
        backgroundColor: 'white',
        shadowColor: 'black',
        shadowOffset: { width: 1, height: 1 },
        shadowOpacity: 1,
        shadowRadius: 4,
        marginRight: 1,
        marginLeft: 1,
        marginTop: 5,
        marginBottom: 5,
        padding: 10,
        elevation: 5,
        borderRadius: 5,
    },
    nameText: {
        fontSize: responsiveFontSize(1.8),
    },
    moneyText: {
        fontSize: responsiveFontSize(2.2),
        fontWeight: "bold",
    },
    cardRow: {
        flexDirection: "row"
    },
    cardHeader: {
        width: "40%",
    },

    cardContent: {
        flex: 1,
    },
    cardHeaderText: {
        fontSize: responsiveFontSize(2)
    },
    cardContentText: {
        fontWeight: "bold",
        fontSize: responsiveFontSize(2),
        textAlign: "left",
        alignItems: "flex-start"
    },
    manualText: {
        fontSize: responsiveFontSize(2),
        textAlign: "justify",
    },
    manualTextNotice: {
        fontSize: responsiveFontSize(2),
        textAlign: "justify",
        color: argonTheme.COLORS.ERROR,
        fontWeight: "bold"
    }
});

const styles = StyleSheet.create({
    Inputcontainer: {
        marginTop: 5,
        marginBottom: 5,
        flexDirection: 'row',
        borderRadius: 5,
        borderWidth: 1,
        borderColor: '#ccc',
        backgroundColor: 'white'
    },
    container: {
        backgroundColor: 'black',
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
    textHeader: {
        fontWeight: "bold",
        fontSize: responsiveFontSize(2.2),
    },
    texSubHeader: {
        fontWeight: "bold",
        fontSize: responsiveFontSize(2),
        color: argonTheme.COLORS.ERROR,
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
    },
    input: {
        flex: 1,
        paddingVertical: 8,
        paddingHorizontal: 10,
        color: '#333',
        height: 35,
    },
    button: {
        backgroundColor: argonTheme.COLORS.ERROR,
        borderTopRightRadius: 5,
        borderBottomRightRadius: 5,
        paddingVertical: 8,
        paddingHorizontal: 12,
        marginLeft: 'auto',
        height: 35,
        alignItems: 'flex-end',
    },
});

export default EscrowWalletPushManualScreen;