import { React, useState, useEffect, useContext } from 'react';
import { ScrollView, StyleSheet, TouchableOpacity, View, TextInput, Image, StatusBar, Text, ToastAndroid, Alert } from "react-native";
import { SafeAreaView } from 'react-native-safe-area-context'
import AsyncStorage from '@react-native-async-storage/async-storage';
import { addSeconds, addMonths, differenceInDays, isAfter } from 'date-fns';
// Argon themed components
import { argonTheme } from "../constants";
import Ionicons from 'react-native-vector-icons/Ionicons';
import { AuthContext } from '../context/AuthContext';
import { OrderContext } from '../context/OrderContext';
import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
} from "react-native-responsive-dimensions";
import { AutionContext } from '../context/AutionContext';
import Config from '../constants/Config';

const BidingScreen = ({ navigation, route }) => {
    const { Bidding } = useContext(AutionContext);
    const [isEndAuction, SetEndAuctionState] = useState(false);
    const { configData } = useContext(AuthContext);

    const ConvertCurrency = (numberString) => {
        const formattedNumber = parseInt(numberString, 10).toLocaleString('vi-VN', {
            style: 'currency',
            currency: 'VND',
        });
        const convertedNumber = formattedNumber.replace('₫', 'VND');
        return convertedNumber;
    }
    
    const ConvertCurrencyNumber = (numberString) => {
        if (isNaN(parseInt(numberString))) {
            return "";
        }
        else {
            const number = parseInt(numberString.replace(/\D/g, ''), 10);
            const formattedNumber = number.toLocaleString('vi-VN');
            return formattedNumber;
        }
    
    };
    const ReverseCurrencyNumber = (formattedNumber) => {
        const numberString = formattedNumber.replace(/\D/g, '');
        const number = parseInt(numberString, 10);
        return number.toString();
    };
    
    const [value, setValue] = useState("")


    const priceAuctionChange = (text) => {
        setValue(ReverseCurrencyNumber(text));
    }

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
            return true; // Trả về false nếu startTime nhỏ hơn thời gian hiện tại
        }
        else {
            return false;
        }
    }

    const GetDate = (_time) => {
        const startTime = new Date(_time);

        const startDate = startTime.getDate(); // Ngày
        const startMonth = startTime.getMonth() + 1; // Tháng (lưu ý: tháng bắt đầu từ 0 nên cần cộng 1)
        const startYear = startTime.getFullYear(); // Năm

        const startHour = startTime.getHours(); // Giờ
        const startMinute = startTime.getMinutes(); // Phút
        const startSecond = startTime.getSeconds(); // Giây

        const dateObject = {
            date: `${startDate}/${startMonth}/${startYear}`,
            time: `${startHour}:${startMinute}:${startSecond}`

        }
        return dateObject; S
    }

    const AuctionCard = ({ data }) => {

        const endTime = new Date(data.endTime);

        const [days, setDays] = useState(0);
        const [hours, setHours] = useState(0);
        const [minutes, setMinutes] = useState(0);
        const [seconds, setSeconds] = useState(0);

        useEffect(() => {
            const calculateCountdown = () => {
                const currentTime = new Date();
                const timeRemaining = endTime - currentTime;

                if (timeRemaining > 0) {
                    const remainingSeconds = Math.floor(timeRemaining / 1000);

                    const remainingDays = Math.floor(remainingSeconds / (60 * 60 * 24));
                    const remainingHours = Math.floor((remainingSeconds % (60 * 60 * 24)) / (60 * 60));
                    const remainingMinutes = Math.floor((remainingSeconds % (60 * 60)) / 60);
                    const remainingSecondsCount = remainingSeconds % 60;

                    setDays(remainingDays);
                    setHours(remainingHours);
                    setMinutes(remainingMinutes);
                    setSeconds(remainingSecondsCount);

                    setTimeout(calculateCountdown, 1000); // Cập nhật mỗi giây
                }
                else {
                    SetEndAuctionState(true);
                }
            };

            calculateCountdown();
        }, []);
        return (
            <TouchableOpacity

            >
                <View className="bg-stone-100 mx-2 mt-2 p-3 rounded" style={styles.card} >
                    {/* header */}
                    <View className="flex-row justify-between rounded-tl rounded-tr" >
                        <View className="justify-center items-start">
                            <Text className="font-bold" style={{ fontSize: responsiveFontSize(2.5) }}>
                                Diễn biến đấu giá
                            </Text>
                        </View>

                        {
                            CheckTimeBegin(data.startTime) == false ? (
                                <View className="justify-center  items-center flex-row  rounded px-2"
                                    style={{ backgroundColor: argonTheme.COLORS.ERROR, width: "auto", height: responsiveHeight(4) }}

                                >
                                    <Text className="color-white font-bold">CHƯA BẮT ĐẦU</Text>

                                </View>
                            ) : (

                                <View className="flex-row space-x-1 items-center">
                                    <View className="justify-center  items-center flex-row  rounded px-2"
                                        style={{ backgroundColor: argonTheme.COLORS.ERROR, width: responsiveWidth(8), height: responsiveHeight(3.2) }}
                                    >
                                        <Text style={{ fontWeight: "bold", color: "white", fontSize: responsiveFontSize(1.3) }}>{days}</Text>

                                    </View>
                                    <View className="justify-center  items-center flex-row  rounded px-2"
                                        style={{ backgroundColor: argonTheme.COLORS.ERROR, width: responsiveWidth(8), height: responsiveHeight(3.2) }}
                                    >
                                        <Text style={{ fontWeight: "bold", color: "white", fontSize: responsiveFontSize(1.3) }}>{hours}</Text>

                                    </View>
                                    <View className="justify-center  items-center flex-row  rounded px-2"
                                        style={{ backgroundColor: argonTheme.COLORS.ERROR, width: responsiveWidth(8), height: responsiveHeight(3.2) }}
                                    >
                                        <Text style={{ fontWeight: "bold", color: "white", fontSize: responsiveFontSize(1.3) }}>{minutes}</Text>

                                    </View>
                                    <View className="justify-center  items-center flex-row  rounded px-2"
                                        style={{ backgroundColor: argonTheme.COLORS.ERROR, width: responsiveWidth(8), height: responsiveHeight(3.2) }}
                                    >
                                        <Text style={{ fontWeight: "bold", color: "white", fontSize: responsiveFontSize(1.3) }}>{seconds}</Text>
                                    </View>
                                </View>
                            )
                        }

                    </View>

                    <View className="flex-row justify-between border-stone-300 border-b " >
                        <View className="justify-center">
                            <Text style={{ fontSize: responsiveFontSize(1.3) }}>

                            </Text>
                        </View>
                        <View className="justify-center">
                            {
                                CheckTimeBegin(data.startTime) == true ? (
                                    <Text style={{ fontSize: responsiveFontSize(1.3) }}>Ngày    giờ     phút     giây </Text>

                                ) : (

                                    <Text style={{ fontSize: responsiveFontSize(1.3) }}>{`Bắt đầu ${GetDate(data.startTime).date} ${GetDate(data.startTime).time}`}</Text>
                                )
                            }

                        </View>

                    </View>

                    {/* Price */}
                    <View className="">
                        <View>
                            <Text style={{ fontSize: responsiveFontSize(1.5) }} >Giá khởi điểm</Text>

                            <View className="flex-row items-center justify-between">

                                <View className="">
                                    <Text>
                                        <Text style={{ fontSize: responsiveFontSize(1.8), color: argonTheme.COLORS.ERROR, fontWeight: "bold" }} >{ConvertCurrency(data.auctionPrice)} </Text>
                                        <Ionicons name="trending-up" color="green" size={responsiveFontSize(1.8)}></Ionicons>
                                    </Text>
                                </View>


                            </View>


                        </View>

                    </View>
                    {
                        data.biddingWin.id && (
                            <View className="">
                                <View>
                                    <Text style={{ fontSize: responsiveFontSize(1.5) }} >Top Đấu Giá</Text>



                                    <View className="flex-row justify-between" style={{ backgroundColor: "#ebebeb", padding: 5, borderRadius: 10 }}>
                                        <View>
                                            <Text style={{ fontSize: responsiveFontSize(1.8), color: argonTheme.COLORS.BLACK, fontWeight: "bold" }} >{data.biddingWin.userName} </Text>
                                        </View>
                                        <View>
                                            <Text style={{ fontSize: responsiveFontSize(1.8), color: "#239151", fontWeight: "bold" }} >{ConvertCurrency(data.biddingWin.price)} </Text>
                                        </View>
                                    </View>


                                </View>

                            </View>
                        )
                    }


                </View>
            </TouchableOpacity>
        );
    }

    const HandleWaitOrder = async () => {
        Bidding(route.params.autionDataParam.id, parseInt(ReverseCurrencyNumber(value)));  
        navigation.goBack();
    }


    return (
        <View style={{ position: "relative" }}>
            <SafeAreaView>
                <StatusBar translucent backgroundColor={argonTheme.COLORS.ERROR} />

                <ScrollView style={{ height: "100%" }}>
                    {/* Card Sim Info */}
                    <View testID='CardContainer' style={styles.cardContainer} >
                        <Image source={require('../assets/imgs/sim_card.png')} style={styles.cardImage} resizeMode="contain" />
                        <View testID='CardContent' style={styles.cardContent} >

                            <Text style={{ fontSize: 25, color: 'white', fontWeight: 'bold' }}>{route.params.autionDataParam.simNumber}</Text>
                            <Text style={{ fontSize: 20, color: 'white', fontWeight: 'bold' }}>{route.params.autionDataParam.network}</Text>

                            <View style={{ justifyContent: "flex-end", alignItems: "flex-end", flex: 1 }}>
                                <View className="px-2 mx-1 rounded-xl flex-row items-center">
                                    <Ionicons name="hammer" color="white" size={responsiveFontSize(2.5)}></Ionicons>
                                    <View className="mx-2">
                                        <Text style={{ fontSize: responsiveFontSize(1.8), color: "white" }}>
                                            Đang đặt giá
                                        </Text>
                                        <Text style={{ fontSize: responsiveFontSize(1.8), color: "white" }}>
                                            {`${route.params.autionDataParam.bidderNum} người`}
                                        </Text>
                                    </View>
                                </View>
                            </View>

                        </View>

                    </View>
                    {/* 
                    Middle */}

                    <AuctionCard data={route.params.autionDataParam} />








                </ScrollView>

                {
                    !isEndAuction && CheckTimeBegin(route.params.autionDataParam.startTime) ?
                        (
                            <View style={styles.coverOrderBtn}>


                                <View testID="OrderSim" style={styles.orderSim}>
                                    <TextInput
                                        placeholder='Nhập giá'
                                        keyboardType="numeric"
                                        style={{ width: "100%" }}
                                        placeholderTextColor={'gray'}
                                        className="text-base mb-1 pl-2 border flex-1 mr-2 text-center rounded"
                                        editable={true}
                                        value={ConvertCurrencyNumber(value.toString()) }
                                        onChangeText={priceAuctionChange}
                                    />
                                </View>

                                <TouchableOpacity activeOpacity={.9}

                                    style={styles.orderButton}
                                    onPress={() => {
                                        if (value != "") {
                                            HandleWaitOrder();

                                        }
                                        else {
                                            ToastAndroid.showWithGravity(
                                                `Vui lòng nhập giá!`,
                                                ToastAndroid.SHORT,
                                                ToastAndroid.BOTTOM,
                                            );
                                        }

                                    }}
                                >
                                    <Text style={{}}>
                                        <Ionicons name="hammer-outline" color="white" size={15}></Ionicons>
                                        <Text style={{ color: "white", fontWeight: "bold" }} >
                                            {` ĐẶT GIÁ`}
                                        </Text>
                                    </Text>

                                </TouchableOpacity>
                            </View>
                        ) : (null)

                }

            </SafeAreaView>
        </View>
    );

}


export default BidingScreen;

const styles = StyleSheet.create({
    cardContainer: {
        position: 'relative',
        width: 'auto',
        height: responsiveHeight(25),
        marginLeft: responsiveWidth(4),
        marginRight: responsiveWidth(4),
        flexDirection: "column"
    },
    card: {
        backgroundColor: '#f8f8f8f8',
        shadowColor: 'black',
        shadowOffset: { width: 1, height: 1 },
        shadowOpacity: 1,
        shadowRadius: 8,
        borderWidth: 1,
        elevation: 5,
        height: "auto",
        marginLeft: responsiveWidth(4),
        marginRight: responsiveWidth(4),
    },
    cardImage: {
        borderRadius: 15,
        width: '100%',
        height: '100%',
        position: 'absolute'
    },
    cardContent: {
        padding: 15,
        flexDirection: "column",
        height: "100%",
    },
    orderSim: {
        margin: responsiveWidth(4),
        backgroundColor: 'white',
        alignItems: 'center',
        borderRadius: 10,

    },
    coverWithBorder: {
        margin: responsiveWidth(4),
        backgroundColor: 'white',
        alignItems: 'center',
        borderRadius: 10,
        shadowColor: 'black',
        shadowOffset: { width: 1, height: 1 },
        shadowOpacity: 1,
        shadowRadius: 8,
        elevation: 5,
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

const styles2 = StyleSheet.create({
    container: {
        flexDirection: 'row',
        alignItems: 'center',
        backgroundColor: '#f2f2f2',
        borderRadius: 8,
        width: responsiveWidth(80),
        justifyContent: "center",
        paddingLeft: 10,
        paddingRight: 10


    },
    button: {
        backgroundColor: argonTheme.COLORS.ERROR,
        height: responsiveHeight(4),
        width: responsiveWidth(7),
        borderRadius: 50,
        margin: 6,
        justifyContent: 'center',
        alignItems: 'center',

    },
    buttonText: {
        fontSize: responsiveFontSize(2.5),
        color: "white",
        fontWeight: 'bold',
        textAlign: "center",
        justifyContent: "space-between"
    },
    value: {
        fontSize: responsiveFontSize(3),
        fontWeight: 'bold',
        flex: 1,
        textAlign: "center",
    },
});