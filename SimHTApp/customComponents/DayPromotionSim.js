
import { React, useContext } from 'react'
import MasonryList from '@react-native-seoul/masonry-list';
import { ScrollView, TouchableOpacity, View, Image, Text } from "react-native";
import TitleCategory from './TitleCategory';
import { HomeContext } from '../context/HomeContext';
import { AppConst } from '../constants/AppConst';

import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
} from "react-native-responsive-dimensions";


const DayPromotionSim = (props) => {
    const { dayPromotionData } = useContext(HomeContext);
    let roundedLength = 0;
    if (dayPromotionData) {
        roundedLength = Math.ceil(dayPromotionData.length / 3);
    }

    return (
        dayPromotionData && (
            <View style={{ flex: 1 }}>
                <View className="flex-row justify-start items-center bg-white py-1 px-2">
                    <TitleCategory title="SIM KHUYẾN MÃI TRONG NGÀY" />
                    <Image source={require('../assets/imgs/icon_fire_flashSale.png')} style={{ width: responsiveWidth(5), height: responsiveHeight(4) }} resizeMode='contain' className="mx-1" />
                </View>

                <View className="pl-1">
                    <ScrollView
                        horizontal
                        showsHorizontalScrollIndicator={false}
                    >
                        {
                            <MasonryList
                                data={dayPromotionData}
                                numColumns={roundedLength}
                                renderItem={({ item }) => (
                                    <PromotionSimCard itemData={item} pathProp={props.navi} />
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
        height: responsiveHeight(8),
        width: responsiveWidth(35),
        elevation: 5,
    },
    price: {
        textDecorationLine: 'line-through', color: 'red'
    },
    promotionPrice: {
        color: 'red',
        fontWeight: 'bold',
        alignItems: 'flex-end',
        fontSize: responsiveFontSize(1.8),
    },
};

export default DayPromotionSim;

const PromotionSimCard = (prop) => {
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
        <TouchableOpacity
            className="space-y-3 bg-slate-100 rounded-xl"
            style={styles.card}
            onPress={() => {
                var simDataParam = {
                    id: prop.itemData.id,
                    phoneNumber: prop.itemData.phoneNumber,
                    networkID: prop.itemData.simNetworkId,
                    networkName: "",
                    isSaleActive: false,
                    price: prop.itemData.price,
                    priceOnSale: null,
                }
                prop.pathProp.navigate(AppConst.StackConst.NATIVE_STACK, { screen: AppConst.ScreenConst.PURCHASE_SIM, params: { simDataParam: simDataParam } })
            }}

        >
            <View className="items-left px-1">
                <Text
                    className="font-semibold text-neutral-1000"
                    style={{ fontSize: responsiveFontSize(2) }}
                >
                    {prop.itemData.phoneNumber}
                </Text>
            </View>

            <View className="flex-row justify-end">
                <Text style={styles.promotionPrice} className="">   {ConvertCurrency(prop.itemData.price)}  </Text>
            </View>
            <Image source={require('../assets/imgs/icon_gift.png')} style={{ width: responsiveWidth(10), height: responsiveHeight(3.5), position: "absolute", bottom: 0, left: 0 }} resizeMode='stretch' />
        </TouchableOpacity>
    )
}