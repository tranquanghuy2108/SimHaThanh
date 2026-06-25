import { React, useState, useEffect, useContext, useRef } from 'react';
import { ScrollView, StyleSheet, TouchableOpacity, View, TextInput, Image, StatusBar, TouchableWithoutFeedback, ToastAndroid, Text, Animated, Dimensions, PanResponder, Alert } from "react-native";
import { SafeAreaView } from 'react-native-safe-area-context';
import AsyncStorage from '@react-native-async-storage/async-storage';
import Config from '../constants/Config';
import SendBird from 'sendbird';
// Argon themed components
import { argonTheme } from "../constants";
import Ionicons from 'react-native-vector-icons/Ionicons';

import { AuthContext } from '../context/AuthContext';
import { OrderContext } from '../context/OrderContext';
import { Dropdown } from 'react-native-element-dropdown';
import { InstallmentContext } from '../context/InstallmentContext';
import { addMinutes, addMonths, differenceInDays, isAfter } from 'date-fns';
import { useHeaderHeight } from '@react-navigation/elements';

import {
    responsiveScreenHeight,
    responsiveScreenWidth,
    responsiveFontSize,
    responsiveHeight
} from "react-native-responsive-dimensions";
import { AppConst } from '../constants/AppConst';


const netWorkNames = [
    { name: 'Viettel', id: 1, image: require('../assets/imgs/icon_viettel.png') },
    { name: 'Vinaphone', id: 2, image: require('../assets/imgs/icon_vinaphone.png') },
    { name: 'Mobiphone', id: 3, image: require('../assets/imgs/icon_mobifone.png') },
    { name: 'VietNamobile', id: 4, image: require('../assets/imgs/icon_vietnamobile.png') },
    { name: 'Gmobile', id: 5, image: require('../assets/imgs/icon_gMobile.png') },
    { name: 'iTel', id: 6, image: require('../assets/imgs/icon_itel.png') },

];
const BorrowTimeDatas = [
    {
        "id": 1,
        "name": "1 Tháng",
        "value": 1
    },
    {
        "id": 2,
        "name": "2 Tháng",
        "value": 2
    },
    {
        "id": 3,
        "name": "3 Tháng",
        "value": 3
    },
    {
        "id": 6,
        "name": "6 Tháng",
        "value": 6
    },
    {
        "id": 12,
        "name": "12 Tháng",
        "value": 12
    },
]


const PurchaseSimScreen = ({ navigation, route }) => {
    const height = Dimensions.get('window').height;
    const { userInfos, userInfoData } = useContext(AuthContext);
    const { GetUserInfo } = useContext(AuthContext);
    const { CreateOrder } = useContext(OrderContext);
    const { configData, GetConfigData } = useContext(AuthContext);
    const ConvertCurrency = (numberString) => {
        const formattedNumber = parseInt(numberString, 10).toLocaleString('vi-VN', {
            style: 'currency',
            currency: 'VND',
        });
        const convertedNumber = formattedNumber.replace('₫', 'VND');
        return convertedNumber;
      }

    useEffect(() => {
        GetUserInfo();
    }, []);

    const headerHeight = useHeaderHeight();
    const [nameEdit, SetNameEdit] = useState(userInfos.fullName);
    const [callEdit, SetCallEdit] = useState(userInfos.username);
    const [addressEdit, SetAddressEdit] = useState(userInfos.address);
    const [noteEdit, SetNoteEdit] = useState("");

    const [payMode, SetPayMode] = useState(0);

    const EditName = (text) => {
        SetNameEdit(text);
    }

    const EditCall = (text) => {
        SetCallEdit(text);
    }
    const EditAdress = (text) => {
        SetAddressEdit(text);
    }
    const EditNote = (text) => {
        SetNoteEdit(text);
    }


    const [simPrice, SetSimPriceState] = useState(route.params.simDataParam.price.toString());
    const [isSale, SetIsSaleState] = useState(route.params.simDataParam.isSaleActive);
    const [simPriceAfterDiscount, SetSimPriceDiscountState] = useState(route.params.simDataParam.price.toString());
    const [borrowTime, SetBorrowTimeState] = useState(1);
    const [isFocus, setIsFocus] = useState(false);
    const [payFirst, SetPayFirstState] = useState("");
    const [payAfter, SetPayAfterState] = useState("");

    const [payMonth, SetPayMonthState] = useState("");

    const PriceSimChange = (text) => {
        SetSimPriceState(text);


    }
    useEffect(() => {
        if (payMode === 3) {
            SetNoteEdit("ĐƠN HÀNG TRẢ GÓP")
        }
        else {
            if (isSale) {
                SetNoteEdit("ĐƠN HÀNG FLASH SALE")
            }
            else {

            }
        }

    }, [payMode]);

    const { installmentConfig } = useContext(InstallmentContext);

    useEffect(() => {
        if (isSale) {
            var priceDiscount = parseInt(route.params.simDataParam.priceOnSale) - (parseInt(route.params.simDataParam.priceOnSale) * (parseInt(CalculateDiscountPer(parseInt(route.params.simDataParam.priceOnSale))) / 100));
            SetSimPriceDiscountState(priceDiscount.toString());
            if (installmentConfig != null) {
                var firstPay = (installmentConfig.installment_MinimumPaymentRate / 100) * parseInt(priceDiscount);
                var afterPay = parseInt(priceDiscount) - firstPay;
                if (!isNaN(firstPay) && !isNaN(afterPay)) {
                    SetPayFirstState(firstPay.toString());
                    SetPayAfterState(afterPay.toString());
                }

                const currentDate = new Date(); // Lấy ngày hiện tại
                // Tính ngày cần tính

                const targetDate = addMonths(currentDate, borrowTime);

                // Kiểm tra nếu targetDate nằm sau ngày hiện tại
                if (isAfter(targetDate, currentDate)) {
                    // Tính số ngày
                    const dayDiff = differenceInDays(targetDate, currentDate);
                    var interestRate = installmentConfig.installment_DailyInterestRate; //Lãi suất tính trên 1 triệu
                    var monthPay = (afterPay / parseInt(borrowTime)) + (((afterPay /1000000)*interestRate ) * (dayDiff/parseInt(borrowTime)));

                    if (!isNaN(monthPay)) {
                        SetPayMonthState(monthPay.toString());
                    }


                }

            }
        }
        else {
            var priceDiscount = parseInt(simPrice) - (parseInt(simPrice) * (parseInt(CalculateDiscountPer(parseInt(simPrice))) / 100));
            SetSimPriceDiscountState(priceDiscount.toString());
            if (installmentConfig != null) {
                var firstPay = (installmentConfig.installment_MinimumPaymentRate / 100) * parseInt(priceDiscount);
                var afterPay = parseInt(priceDiscount) - firstPay;
                if (!isNaN(firstPay) && !isNaN(afterPay)) {
                    SetPayFirstState(firstPay.toString());
                    SetPayAfterState(afterPay.toString());
                }

                const currentDate = new Date(); // Lấy ngày hiện tại
                // Tính ngày cần tính

                const targetDate = addMonths(currentDate, borrowTime);

                // Kiểm tra nếu targetDate nằm sau ngày hiện tại
                if (isAfter(targetDate, currentDate)) {
                    // Tính số ngày
                    const dayDiff = differenceInDays(targetDate, currentDate);
                    var interestRate = installmentConfig.installment_DailyInterestRate; //Lãi suất tính trên 1 triệu
                    var monthPay = (afterPay / parseInt(borrowTime)) + (((afterPay /1000000)*interestRate ) * (dayDiff/parseInt(borrowTime)));

                    if (!isNaN(monthPay)) {
                        SetPayMonthState(monthPay.toString());
                    }


                }

            }
        }

    }, [installmentConfig, borrowTime])

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

    var netWorkName = "";

    if (route.params.simDataParam.networkName === "") {
        const foundNetwork = netWorkNames.find(x => x.id == route.params.simDataParam.networkID);
        if (foundNetwork) {
            netWorkName = foundNetwork.name;
        } else {
            netWorkName = " ";
        }
    }
    else {
        netWorkName = route.params.simDataParam.networkName;
    }

    //Animate
    const [isExpanded, setIsExpanded] = useState(false);
    const [animation] = useState(new Animated.Value(0));
    const [offsetY, setOffsetY] = useState(0);
    const [containerHeight, setContainerHeight] = useState(0);
    const handlePress = () => {
        if (isExpanded) {
            hideAnimation();
        } else {
            showAnimation();
        }
    };

    const showAnimation = () => {
        setIsExpanded(true);
        Animated.timing(animation, {
            toValue: 1,
            duration: 200,
            useNativeDriver: true,
        }).start();
    };

    const hideAnimation = () => {
        Animated.timing(animation, {
            toValue: 0,
            duration: 200,
            useNativeDriver: true,
        }).start(() => {
            setIsExpanded(false);
            setOffsetY(0);
        });
    };

    const interpolatedAnimation = animation.interpolate({
        inputRange: [0, 1],
        outputRange: [1.5 * height, 0],
        extrapolate: 'clamp',
    });
    const CalculateDiscountPer = (price) => {

        if (isSale) {
            return "0";
        }
        else {
            if (userInfoData) {
                if (!userInfoData.discount || userInfoData.discount.length === 0) {
                    return "0";
                }
                for (const discount of userInfoData.discount) {
                    if (price >= discount.priceFrom && price <= discount.priceTo) {
                        return discount.discountPer.toString();
                    }
                }
            }
            else {
                return "0";
            }
            return "0";
        }
    }

    const panResponder = PanResponder.create({
        onMoveShouldSetPanResponder: (_, gestureState) => {
            return Math.abs(gestureState.dy) > 5;
        },
        onPanResponderMove: (_, gestureState) => {


            const newOffsetY = offsetY + gestureState.dy;
            console.log("OFFSETY:" + newOffsetY)
            if (newOffsetY < 50 && newOffsetY > -containerHeight / 1.5) {
                setOffsetY(newOffsetY);
            }


        },
    });
    
    const handleContainerLayout = (event) => {
        const { height } = event.nativeEvent.layout;
        setContainerHeight(height);
        console.log("HEIGHT CONTAINER:" + containerHeight);
    };

    const OrderHandle = (orderType) => {
        SetPayMode(orderType);
        handlePress();
    }
    const ChatToSupport = () => {
        const sb = new SendBird({ appId: Config.SEND_BIRD_APP_ID });
        sb.connect(userInfos.id, (user, error) => {
            if (error) {
                console.error('Error connecting to Sendbird:', error);
            } else {

                var userId1 = userInfos.id;
                var userId2 = Config.SEND_BIRD_SUPPORT_ID;
                const params = new sb.GroupChannelParams();
                params.isDistinct = true; // Tạo một kênh duy nhất cho hai người dùng
                params.addUserIds([userId1, userId2]);

                sb.GroupChannel.createChannel(params, (groupChannel, error) => {
                    if (error) {
                        console.error('Error creating group channel:', error);
                    } else {
                        const channelUrl = groupChannel.url;
                        const message = `Tôi đang quan tâm tình trạng số thuê bao ${route.params.simDataParam.phoneNumber}`;

                        const params = new sb.UserMessageParams();
                        params.message = message;

                        groupChannel.sendUserMessage(params, (userMessage, error) => {
                            if (error) {
                                console.error('Error sending user message:', error);
                            } else {
                                console.log('User message sent successfully:', userMessage);
                                navigation.navigate(AppConst.ScreenConst.GROUP_CHANNEL, { channelUrl: channelUrl });
                            }
                        });
                    }
                });
            }
        });
    }

    const AskSimHandle = async () => {
        if (configData) {
            try {
                let askSimTimeData = await AsyncStorage.getItem('AskSimTime');
                let askSimCountData = await AsyncStorage.getItem('AskSimCount');
                var currentTime = new Date();
                var nextTime = addMinutes(currentTime, parseInt(configData.askSim_AskingTime));
                if (askSimTimeData === null) {

                    await AsyncStorage.setItem('AskSimTime', nextTime.toString());
                    await AsyncStorage.setItem('AskSimCount', (parseInt(configData.askSim_SimNumber) - 1).toString());
                    ChatToSupport();
                }
                else if (askSimTimeData != null) {
                    var targetTime = new Date(askSimTimeData);
                    console.log("CURRENT TIME:" + currentTime);
                    console.log("STORAGE ASK TIME:" + targetTime);
                    console.log("STORAGE ASK COUNT:" + askSimCountData);
                    if (targetTime > currentTime && parseInt(askSimCountData) > 0) {

                        await AsyncStorage.setItem('AskSimCount', JSON.stringify(parseInt(askSimCountData) - 1));
                        ChatToSupport();
                    }
                    else {
                        if (targetTime <= currentTime) {
                            await AsyncStorage.setItem('AskSimTime', nextTime.toString());
                            await AsyncStorage.setItem('AskSimCount', (parseInt(configData.askSim_SimNumber) - 1).toString());
                            ChatToSupport();
                        }
                        else if (askSimCountData <= 0) {

                            const timeRemaining = targetTime - currentTime;

                            if (timeRemaining > 0) {
                                const remainingSeconds = Math.floor(timeRemaining / 1000);
                                const remainingMinutes = Math.floor((remainingSeconds % (60 * 60)) / 60);
                                const remainingSecondsCount = remainingSeconds % 60;
                                ToastAndroid.showWithGravity(
                                    `Đã đạt giới hạn lượt hỏi Sim. Vui lòng thử lại sau ${remainingMinutes} phút: ${remainingSecondsCount} giây nữa!`,
                                    ToastAndroid.SHORT,
                                    ToastAndroid.BOTTOM,
                                );
                            }
                        }
                    }
                }

            } catch (error) {
                console.log('Error saving ask Sim:', error);
            }
        }
    }
    const ConfirmOrder = (orderType) => {
        Alert.alert(
            'Bạn có muốn hỏi sim trước khi đặt mua?',
            '',
            [
                { text: 'Trở về', },
                { text: 'Hỏi Sim', onPress: () => { AskSimHandle() } },
                { text: 'Đặt mua', onPress: () => { OrderHandle(orderType) } }
            ],
            {
                cancelable: false,
            },

        );
    }
    return (
        <View>

            <StatusBar translucent backgroundColor={argonTheme.COLORS.ERROR} />
            <SafeAreaView>
                <ScrollView style={{}}>
                    {/* Card Sim Info */}
                    <View testID='CardContainer' style={styles.cardContainer} >
                        <Image source={require('../assets/imgs/sim_card.png')} style={styles.cardImage} resizeMode="contain" />
                        <View testID='CardContent' style={styles.cardContent} >
                            <View >
                                <Text selectable={true} style={{ fontSize: 25, color: 'white', fontWeight: 'bold' }}>{route.params.simDataParam.phoneNumber}</Text>
                                {
                                    route.params.simDataParam.simDataPackageCountry ? (
                                        <Text style={{ fontSize: 18, color: 'white', fontWeight: 'bold' }}>{route.params.simDataParam.simDataPackageCountry}</Text>
                                    ) : (null)
                                }
                                {
                                    route.params.simDataParam.simDataPackageType ? (
                                        <Text style={{ fontSize: 18, color: 'white', fontWeight: 'bold' }}>{route.params.simDataParam.simDataPackageType}</Text>
                                    ) : (null)
                                }
                                {
                                    route.params.simDataParam.isSaleActive == true && route.params.simDataParam.priceOnSale ? (
                                        <View>
                                            <Text style={{ fontSize: 18, color: 'white', fontWeight: 'bold', textDecorationLine: 'line-through' }}>{ConvertCurrency(route.params.simDataParam.price)}</Text>
                                            <Text style={{ fontSize: 20, color: 'white', fontWeight: 'bold' }}>{ConvertCurrency(route.params.simDataParam.priceOnSale)}</Text>
                                        </View>
                                    ) : (
                                        <View>
                                            <Text style={{ fontSize: 20, color: 'white', fontWeight: 'bold' }}>{ConvertCurrency(route.params.simDataParam.price)}</Text>
                                        </View>
                                    )
                                }

                                <Text className="mt-4">
                                    <Text style={{ fontSize: 17, color: '#e3e2e1', fontWeight: 'bold' }}>{netWorkName}</Text>
                                </Text>
                            </View>
                        </View>
                    </View>
                    {/* Feature */}

                    <View testID="OrderSim" style={styles.simFeature}>
                        <View testID='featureRow'>
                            <View className="flex-row">
                                <View style={styles.checkboxWrapper}>
                                    <View style={[styles.checkbox, { backgroundColor: argonTheme.COLORS.ERROR }]} />
                                </View>
                                <Text style={{ flex: 1 }}>
                                    <Text style={{ flex: 1, textAlign: "justify" }}>Bộ SimCard nguyên kit có sẵn tài khoản </Text>
                                </Text>
                            </View>
                        </View>

                        <View testID='featureRow'>
                            <View className="flex-row">
                                <View style={styles.checkboxWrapper}>
                                    <View style={[styles.checkbox, { backgroundColor: argonTheme.COLORS.ERROR }]} />
                                </View>
                                <Text style={{ flex: 1 }}>
                                    <Text style={{ flex: 1, textAlign: "justify" }}>Hưởng khuyến mãi hiện hành của nhà mạng</Text>
                                </Text>
                            </View>
                        </View>

                        <View testID='featureRow'>
                            <View className="flex-row">
                                <View style={styles.checkboxWrapper}>
                                    <View style={[styles.checkbox, { backgroundColor: argonTheme.COLORS.ERROR }]} />
                                </View>
                                <Text style={{ flex: 1 }}>
                                    <Text style={{ flex: 1, textAlign: "justify" }}>Khách hàng sẽ được đăng ký thông tin khi mua sim </Text>
                                </Text>
                            </View>
                        </View>
                    </View>

                    <View testID="OrderSim" style={styles.orderType}>
                        {/* AskSim */}
                        <TouchableOpacity activeOpacity={.9}
                            style={styles.orderButton}
                            onPress={() => {
                                AskSimHandle()
                            }}
                        >
                            <Text style={{}}>
                                <Ionicons name="chatbubbles-outline" color="white" size={15}></Ionicons>
                                <Text style={{ color: "white", fontWeight: "bold" }} >
                                    {` HỎI SIM`}
                                </Text>
                            </Text>
                        </TouchableOpacity>

                        {/* Order Sim */}
                        <TouchableOpacity activeOpacity={.9}
                            style={styles.orderButton}
                            onPress={() => {
                                ConfirmOrder(0);
                            }}
                        >
                            <Text style={{}}>
                                <Ionicons name="cart-outline" color="white" size={15}></Ionicons>
                                <Text style={{ color: "white", fontWeight: "bold" }} >
                                    {` MUA NGAY`}
                                </Text>
                            </Text>
                        </TouchableOpacity>
                        {
                            route.params.simDataParam.price > 10000000 ? (
                                <TouchableOpacity activeOpacity={.9}
                                    style={styles.installmentButton}
                                    onPress={() => {
                                        ConfirmOrder(3);
                                    }}
                                >
                                    <Text style={{}}>
                                        <Ionicons name="card-outline" color="white" size={15}></Ionicons>
                                        <Text style={{ color: "white", fontWeight: "bold" }} >
                                            {` TRẢ GÓP`}
                                        </Text>
                                    </Text>
                                </TouchableOpacity>
                            ) : (null)
                        }

                    </View>
                </ScrollView>
                {/* Order Button */}
                <Animated.View
                    style={{
                        position: "absolute",
                        height: height - headerHeight,
                        transform: [{ translateY: interpolatedAnimation }],
                        backgroundColor: "transparent",
                        left: 0,
                        right: 0
                    }}
                >
                    <TouchableWithoutFeedback
                        onPress={() => {
                            SetPayMode(0);
                            hideAnimation();
                        }
                        }
                    >
                        <View style={{ backgroundColor: "rgba(1, 1, 1, 0.3)", height: responsiveHeight(30) }}>
                        </View>
                    </TouchableWithoutFeedback>
                    <View style={{ flex: 1 }}>
                        <View style={styles3.container} {...panResponder.panHandlers}>
                            <View
                                style={[styles3.content, { transform: [{ translateY: offsetY }] }]}
                                onLayout={handleContainerLayout}
                            >
                                <Text style={{ fontWeight: 'bold', color: 'black', fontSize: responsiveFontSize(2), textAlign: "center" }}>ĐẶT MUA SIM</Text>

                                {/* onPress={() => { handleSearchtFocus() }} */}
                                {/* Input_Name */}

                                <View className=" bg-stone-100 " style={styles.input}>
                                    <View className="bg-transparent m-3">
                                        <Ionicons name="person-outline" color={argonTheme.COLORS.ERROR} size={20}></Ionicons>
                                    </View>
                                    <TextInput
                                        placeholder='Họ và Tên'
                                        placeholderTextColor={'gray'}
                                        value={nameEdit}
                                        className="text-base mb-1 pl-2"

                                        editable={true}
                                        onChangeText={EditName}
                                        style={{ flex: 1 }}
                                    />
                                </View>


                                {/* Input_PhoneNum */}

                                <View className=" bg-stone-100 " style={styles.input}>
                                    <View className="bg-transparent m-3">
                                        <Ionicons name="call-outline" color={argonTheme.COLORS.ERROR} size={20}></Ionicons>
                                    </View>
                                    <TextInput
                                        placeholder='Số điện thoại'
                                        keyboardType='numeric'
                                        placeholderTextColor={'gray'}
                                        value={callEdit}
                                        className="text-base mb-1 pl-2"

                                        onChangeText={EditCall}
                                        maxLength={10}
                                        editable={true}
                                        style={{ flex: 1 }}
                                    />
                                </View>

                                {/* Input_Address */}

                                <View className=" bg-stone-100 " style={styles.input}>
                                    <View className="bg-transparent m-3">
                                        <Ionicons name="location-outline" color={argonTheme.COLORS.ERROR} size={20}></Ionicons>
                                    </View>
                                    <TextInput
                                        placeholder='Địa chỉ nhận hàng'
                                        placeholderTextColor={'gray'}
                                        value={addressEdit}
                                        className="text-base mb-1 pl-2"

                                        onChangeText={EditAdress}
                                        editable={true}
                                        style={{ flex: 1 }}
                                    />
                                </View>

                                {/* Input_Note */}


                                <View className=" bg-stone-100 " style={styles.input}>
                                    <View className="bg-transparent m-3 items-center justify-center">
                                        <Ionicons name="reorder-four-outline" color={argonTheme.COLORS.ERROR} size={20}></Ionicons>
                                    </View>
                                    <TextInput
                                        placeholder='Ghi Chú'
                                        placeholderTextColor={'gray'}
                                        className="text-base mb-1 pl-2"

                                        value={noteEdit}
                                        onChangeText={EditNote}
                                        editable={true}
                                        style={{ flex: 1 }}
                                        multiline={true}
                                        numberOfLines={5}
                                    />
                                </View>

                                <Text style={styles.headerText}>Giá Sim</Text>
                                <View style={styles.inputContainer} >
                                    {/* <View style={styles.iconContainer}>
              <Image source={require('../assets/imgs/icon_mobile.png')} style={{ width: 17, height: 17 }} resizeMode='contain' />
            </View> */}
                                    <TextInput
                                        style={styles.input}
                                        placeholder=""
                                        keyboardType='numeric'
                                        editable={false}
                                        placeholderTextColor="#888"
                                        value={isSale ? ConvertCurrency(route.params.simDataParam.priceOnSale.toString()) : ConvertCurrency(simPrice)}
                                    />
                                </View>

                                {
                                    !isSale && (
                                        <View>
                                            <Text style={styles.headerText}>% Chiết Khấu</Text>
                                            <View style={styles.inputContainer} >
                                                {/* <View style={styles.iconContainer}>
              <Image source={require('../assets/imgs/icon_mobile.png')} style={{ width: 17, height: 17 }} resizeMode='contain' />
            </View> */}
                                                <TextInput
                                                    style={styles.input}
                                                    placeholder=""
                                                    keyboardType='numeric'
                                                    editable={false}
                                                    placeholderTextColor="#888"
                                                    value={CalculateDiscountPer(parseInt(simPrice))}
                                                />
                                            </View>
                                            <Text style={styles.headerText}>Giá Sim Sau Chiết Khấu</Text>
                                            <View style={styles.inputContainer} >
                                                {/* <View style={styles.iconContainer}>
              <Image source={require('../assets/imgs/icon_mobile.png')} style={{ width: 17, height: 17 }} resizeMode='contain' />
            </View> */}
                                                <TextInput
                                                    style={styles.input}
                                                    placeholder=""
                                                    keyboardType='numeric'
                                                    editable={false}
                                                    placeholderTextColor="#888"
                                                    value={ConvertCurrency(simPriceAfterDiscount)}
                                                />
                                            </View>
                                        </View>
                                    )
                                }

                                {
                                    payMode === 3 ? (
                                        <View>
                                            <Text style={styles.headerText}>%Trả trước</Text>
                                            <View style={styles.inputContainer} >
                                                {/* <View style={styles.iconContainer}>
              <Image source={require('../assets/imgs/icon_mobile.png')} style={{ width: 17, height: 17 }} resizeMode='contain' />
            </View> */}
                                                <TextInput
                                                    style={styles.input}
                                                    placeholder=""
                                                    keyboardType='numeric'
                                                    editable={false}
                                                    placeholderTextColor="#888"
                                                    value={installmentConfig.installment_MinimumPaymentRate.toString()}
                                                />
                                            </View>

                                            <Text style={styles.headerText}>Tiền Trả Trước</Text>
                                            <View style={styles.inputContainer} >
                                                {/* <View style={styles.iconContainer}>
              <Image source={require('../assets/imgs/icon_mobile.png')} style={{ width: 17, height: 17 }} resizeMode='contain' />
            </View> */}
                                                <TextInput
                                                    style={styles.input}
                                                    placeholder=""
                                                    keyboardType='numeric'
                                                    placeholderTextColor="#888"
                                                    value={ConvertCurrency(payFirst)}
                                                    editable={false}


                                                />
                                            </View>
                                            <Text style={styles.headerText}>Tiền Trả Góp</Text>
                                            <View style={styles.inputContainer} >
                                                {/* <View style={styles.iconContainer}>
              <Image source={require('../assets/imgs/icon_mobile.png')} style={{ width: 17, height: 17 }} resizeMode='contain' />
            </View> */}
                                                <TextInput
                                                    style={styles.input}
                                                    placeholder=""
                                                    keyboardType='numeric'
                                                    placeholderTextColor="#888"
                                                    editable={false}
                                                    value={ConvertCurrency(payAfter)}


                                                />
                                            </View>
                                            <Text style={styles.headerText}>Thời Hạn Trả Góp</Text>
                                            <Dropdown
                                                style={[styles5.dropdown, isFocus && { borderColor: 'green' }]}
                                                placeholderStyle={styles5.placeholderStyle}
                                                selectedTextStyle={styles5.selectedTextStyle}
                                                inputSearchStyle={styles5.inputSearchStyle}
                                                iconStyle={styles5.iconStyle}
                                                data={BorrowTimeDatas}

                                                maxHeight={300}
                                                labelField="name"
                                                valueField="id"

                                                value={borrowTime}
                                                onFocus={() => setIsFocus(true)}
                                                onBlur={() => setIsFocus(false)}
                                                onChange={item => {
                                                    // setValue(item.id);
                                                    SetBorrowTimeState(item.value);
                                                    console.log("VAlue la:" + item.id);
                                                    setIsFocus(false);
                                                }}
                                            />
                                            <Text style={styles.headerText}>Lãi suất (Tính cho 1tr/1 ngày)</Text>
                                            <View style={styles.inputContainer} >
                                                {/* <View style={styles.iconContainer}>
              <Image source={require('../assets/imgs/icon_mobile.png')} style={{ width: 17, height: 17 }} resizeMode='contain' />
            </View> */}
                                                <TextInput
                                                    style={styles.input}
                                                    placeholder=""
                                                    keyboardType='numeric'
                                                    editable={false}
                                                    placeholderTextColor="#888"
                                                    value={ConvertCurrency(installmentConfig.installment_DailyInterestRate.toString())}
                                                />
                                            </View>

                                            <Text style={styles.headerText}>Số Tiền Phải Trả Hàng Tháng</Text>
                                            <View style={styles.inputContainer} >
                                                {/* <View style={styles.iconContainer}>
              <Image source={require('../assets/imgs/icon_mobile.png')} style={{ width: 17, height: 17 }} resizeMode='contain' />
            </View> */}
                                                <TextInput
                                                    style={styles.input}
                                                    placeholder=""
                                                    keyboardType='numeric'
                                                    placeholderTextColor="#888"
                                                    editable={false}
                                                    value={ConvertCurrency(payMonth)}
                                                />
                                            </View>

                                        </View>
                                    ) : (
                                        null
                                    )
                                }

                                <TouchableOpacity activeOpacity={.9}

                                    style={styles.buyButton}
                                    onPress={() => {

                                        if (nameEdit != "" && callEdit != "" && isValidPhoneNumber(callEdit) && addressEdit != "") {
                                            if (payMode === 0) {

                                                CreateOrder(parseInt(payMode), route.params.simDataParam.id.toString(), parseInt(simPrice), parseInt(CalculateDiscountPer(parseInt(simPrice))), nameEdit, callEdit, addressEdit, noteEdit, isSale ? parseInt(route.params.simDataParam.priceOnSale) : parseInt(simPriceAfterDiscount));
                                                setTimeout(() => {
                                                    navigation.goBack();
                                                    hideAnimation();
                                                }, 200)
                                            }
                                            else if (payMode === 3) {
                                                const currentDate = new Date(); // Lấy ngày hiện tại                                         
                                                const targetDate = addMonths(currentDate, borrowTime);
                                                CreateOrder(parseInt(payMode), route.params.simDataParam.id.toString(), parseInt(simPrice), parseInt(CalculateDiscountPer(parseInt(simPrice))), nameEdit, callEdit, addressEdit, noteEdit, isSale ? parseInt(route.params.simDataParam.priceOnSale) : parseInt(simPriceAfterDiscount), parseInt(borrowTime), targetDate.getDate(), targetDate, parseInt(payFirst), parseInt(payAfter), parseFloat(payMonth), installmentConfig.installment_DailyInterestRate);
                                                setTimeout(() => {
                                                    navigation.goBack();
                                                    hideAnimation();
                                                }, 200)
                                            }
                                        }
                                        else {
                                            const missingFields = [];

                                            if (nameEdit === "") {
                                                missingFields.push("Họ Tên");
                                            }

                                            if (!isValidPhoneNumber(callEdit)) {
                                                missingFields.push("Số Điện Thoại");
                                            }

                                            if (addressEdit === "") {
                                                missingFields.push("Địa Chỉ");
                                            }

                                            if (missingFields.length === 0) {

                                            }
                                            else if (missingFields.length === 3) {
                                                ToastAndroid.showWithGravity(
                                                    "Vui lòng kiểm tra Thông Tin!",
                                                    ToastAndroid.SHORT,
                                                    ToastAndroid.BOTTOM,
                                                );
                                            } else {
                                                ToastAndroid.showWithGravity(
                                                    "Vui lòng kiểm tra " + missingFields.join(", ") + " !",
                                                    ToastAndroid.SHORT,
                                                    ToastAndroid.BOTTOM,
                                                );
                                            }
                                        }

                                    }}
                                >

                                    <Text style={{}}>
                                        <Ionicons name="cart-outline" color="white" size={15}></Ionicons>
                                        <Text style={{ color: "white", fontWeight: "bold" }} >
                                            {`MUA`}

                                        </Text>
                                    </Text>

                                </TouchableOpacity>

                                {/* Installment */}
                            </View>
                        </View>
                    </View>
                </Animated.View>
            </SafeAreaView>
        </View>
    );
}


export default PurchaseSimScreen;
const styles3 = {
    container: {
        flex: 1,
        overflow: 'hidden',
        backgroundColor: "white",

    },
    content: {
        position: 'absolute',
        padding: 20,
        left: 0,
        right: 0,
        top: 0,
    },
    text: {
        fontSize: 16,
        lineHeight: 24,
        marginBottom: 10,
    },
};

const styles = StyleSheet.create({
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
    headerText: {
        fontWeight: "bold",
        fontSize: responsiveFontSize(2),
        color: "black"
    },
    orderSim: {
        margin: 15,
        backgroundColor: 'white',
        alignItems: 'center',
        borderRadius: 10,

    },
    orderType: {
        margin: 15,
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
        marginTop: 5,
        position: "relative",
        padding: 5,
        color: "black"
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
        margin: 5,
        width: "100%"
    },
    buyButton: {
        borderRadius: 10,
        flexDirection: "row",
        alignContent: "center",
        justifyContent: "center",
        borderColor: 'grey',
        padding: 10,
        alignItems: "center",
        backgroundColor: argonTheme.COLORS.ERROR,
        marginTop: 10,
        marginBottom: 10,
        width: "auto",

    },
    installmentButton: {
        borderRadius: 10,
        flexDirection: "row",
        alignContent: "center",
        justifyContent: "center",
        borderColor: 'grey',
        padding: 10,
        alignItems: "center",
        backgroundColor: "#494d4a",
        margin: 5,
        width: "100%"
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






const styles5 = StyleSheet.create({
    container: {
        backgroundColor: 'white',
        padding: 16,
    },
    dropdown: {
        height: 50,
        borderColor: 'gray',
        borderWidth: 0.5,
        borderRadius: 8,
        paddingHorizontal: 8,
        backgroundColor: "white"
    },
    icon: {
        marginRight: 5,
    },
    label: {
        position: 'absolute',
        backgroundColor: 'white',
        left: 22,
        top: 8,
        zIndex: 999,
        paddingHorizontal: 8,
        fontSize: 14,
    },
    placeholderStyle: {
        fontSize: 16,
    },
    selectedTextStyle: {
        fontSize: 16,
    },
    iconStyle: {
        width: 20,
        height: 20,
    },
    inputSearchStyle: {
        height: 40,
        fontSize: 16,
    },
    inputContainer: {
        flexDirection: 'row',
        alignItems: 'center',

        borderWidth: 1,
        borderColor: '#ccc',
        borderRadius: 5,
        backgroundColor: 'white',
        shadowColor: 'black',
        shadowOffset: { width: 0, height: 2 },
        shadowOpacity: 1,
        shadowRadius: 8,
        marginTop: 5,
    },
    iconContainer: {
        padding: 10,
    },
    input: {
        flex: 1,
        height: 40,
        paddingHorizontal: 10,
        color: '#333',
    },
});

