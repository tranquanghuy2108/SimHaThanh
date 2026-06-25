
import { React, useState, useEffect, useContext } from 'react'
import MasonryList from '@react-native-seoul/masonry-list';
import { ScrollView, TouchableOpacity, View, Image, Text } from "react-native";
import { argonTheme } from '../constants';
import TitleCategory from './TitleCategory';
import { HomeContext } from '../context/HomeContext';
import { AppConst } from '../constants/AppConst';


import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
} from "react-native-responsive-dimensions";

const CountDownCard = ({ data, status }) => {
    const startTime = new Date(data.startTime);
    const endTime = new Date(data.endTime);

    const [days, setDays] = useState(0);
    const [hours, setHours] = useState(0);
    const [minutes, setMinutes] = useState(0);
    const [seconds, setSeconds] = useState(0);
    const {GetFlashSale} = useContext(HomeContext);
    useEffect(() => {
        const calculateCountdown = () => {
            if (status === "HAPPENING") {

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
                    GetFlashSale();
                }
            }
            else if (status === "NOT_BEGIN") {

                const currentTime = new Date();

                const timeRemaining = startTime - currentTime;


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
                    GetFlashSale();
                }
            }

        };

        calculateCountdown();
    }, []);
    return (
        <View className="flex-row space-x-1 items-center">

            <View className="justify-center  items-center flex-row  rounded"
                style={{ backgroundColor: argonTheme.COLORS.ERROR, width: responsiveWidth(6), height: responsiveHeight(3) }}
            >
                <Text style={{ fontWeight: "bold", color: "white", fontSize: responsiveFontSize(1.1) }}>{hours}</Text>

            </View>
            <View className="justify-center  items-center flex-row  rounded"
                style={{ backgroundColor: argonTheme.COLORS.ERROR, width: responsiveWidth(6), height: responsiveHeight(3) }}
            >
                <Text style={{ fontWeight: "bold", color: "white", fontSize: responsiveFontSize(1.1) }}>{minutes}</Text>

            </View>
            <View className="justify-center  items-center flex-row  rounded"
                style={{ backgroundColor: argonTheme.COLORS.ERROR, width: responsiveWidth(6), height: responsiveHeight(3) }}
            >
                <Text style={{ fontWeight: "bold", color: "white", fontSize: responsiveFontSize(1.1) }}>{seconds}</Text>
            </View>
        </View>
    )
}

const FlashSales = (props) => {
    let roundedLength = 0;
    if (props.data.simFlashSaleInfos) {
        roundedLength = Math.ceil(props.data.simFlashSaleInfos.length / 2);
    }

    return (
        props.data.simFlashSaleInfos && (
            <View style={{ flex: 1 }}>
                <View className="px-2 flex-row justify-between items-center bg-white py-1">
                    <TitleCategory title="FLASH SALE" />
                    <View style={{flex:1,marginRight:2}}>
                    {
                        props.isSale ? (
                            <Text style={{fontWeight:"400",textAlign:"right",fontSize:responsiveFontSize(1.5)}}>KẾT THÚC TRONG</Text>
                        ) : (
                            <Text style={{fontWeight:"400",textAlign:"right",fontSize:responsiveFontSize(1.5)}}>BẮT ĐẦU TRONG</Text>
                        )
                    }
                    </View>
                 

                    <CountDownCard data={props.data} status={props.status} />
                </View>

                <View className="px-1">
                    <ScrollView
                        horizontal
                        showsHorizontalScrollIndicator={false}
                    >
                        {
                            <MasonryList
                                data={props.data.simFlashSaleInfos}
                                numColumns={roundedLength}
                                renderItem={({ item }) => (
                                    <FlashSaleCard itemData={item} pathProp={props.navi} isSaleSim={props.isSale} />
                                )}
                                columnWrapperStyle={{ justifyContent: 'space-between' }}
                                contentContainerStyle={{ paddingVertical: 10 }}
                            />
                        }
                    </ScrollView>
                </View>
            </View>
        )



    );
}

const styles = {
    card: {
        backgroundColor: 'white',
        shadowColor: 'black',
        shadowOffset: { width: 0, height: 2 },
        shadowOpacity: 1,
        shadowRadius: 8,
        margin: 5,
        height: responsiveHeight(9),
        width: responsiveWidth(37),
        elevation: 5,
    },
    price: {
        textDecorationLine: 'line-through', color: 'red'
    },
    hiddenPrice:{
        color: 'red',
        fontWeight: 'bold',
        fontSize: responsiveFontSize(1.7)
    },
    promotionPrice: {
        color: 'red',
        fontWeight: 'bold',
        fontSize: responsiveFontSize(1.8)
    },
    orginPrice: {
        color: 'black',
        fontWeight: 'bold',
        fontSize: responsiveFontSize(1.7),
        textDecorationLine: 'line-through'
    },
    flashText: {
        fontSize: responsiveFontSize(2),
        fontWeight: 'bold',
        color: argonTheme.COLORS.ERROR
    },
};

export default FlashSales;

const FlashSaleCard = (prop) => {
    const { SetPopUpVisible, SetPopUpData } = useContext(HomeContext);
    const handleOrder = (data) => {
        SetPopUpVisible(true);
        SetPopUpData(data);
    }
    const ConvertCurrency = (numberString) => {
        const formattedNumber = parseInt(numberString, 10).toLocaleString('vi-VN', {
            style: 'currency',
            currency: 'VND',
        });
        return formattedNumber;
    }
    return (
        <TouchableOpacity className="bg-slate-100 rounded-xl" style={styles.card}
            onPress={() => {
                var simDataParam = {
                    id: prop.itemData.simId,
                    phoneNumber: prop.itemData.simNumber,
                    networkID: prop.itemData.networkId,
                    networkName: "",
                    isSaleActive: prop.isSaleSim,
                    price: prop.itemData.simPrice,
                    priceOnSale: prop.itemData.salePrice,

                }
                prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, { screen: AppConst.ScreenConst.PURCHASE_SIM, params: { simDataParam: simDataParam } })

            }}
        >
            <View className="items-left px-2">
                <Text
                    className="font-semibold text-neutral-1000"
                    style={{ fontSize: responsiveFontSize(2) }}
                >
                    {prop.itemData.simNumber}
                </Text>
            </View>
            <View className="flex-row justify-end pr-2 items-end">
                <Text style={styles.orginPrice}>{ConvertCurrency(prop.itemData.simPrice)}</Text>
            </View>

            {prop.isSaleSim ? (
                <View className="flex-row justify-end pr-2 pb-1">

                    <Text style={styles.promotionPrice}>{ConvertCurrency(prop.itemData.salePrice)}</Text>


                </View>
            ) : (
                <View className="flex-row justify-end pr-2 pb-1">
                    <Text>
                    <Text style={styles.hiddenPrice}>?</Text>
                    <Text style={styles.promotionPrice}> đ</Text>
                    </Text>
        
                </View>
            )}
            <Image source={require('../assets/imgs/icon_flash.png')} style={{ width: responsiveWidth(10), height: responsiveHeight(4), position: "absolute", bottom: 0, left: 0 }} resizeMode='stretch' />

        </TouchableOpacity>
    )
}