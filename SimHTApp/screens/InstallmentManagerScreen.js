import React, { useEffect, useContext } from "react";
import { View, Text, ScrollView, Alert } from 'react-native';
import { OrderContext } from "../context/OrderContext";
import MasonryList from '@react-native-seoul/masonry-list';
import { AppConst } from "../constants/AppConst";
import { argonTheme } from "../constants";
import { InstallmentContext } from "../context/InstallmentContext";

import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
} from "react-native-responsive-dimensions";

const GetDayFormat = (timestamp) => {
    const dateObj = new Date(timestamp);

    const day = String(dateObj.getDate()).padStart(2, '0');
    const month = String(dateObj.getMonth() + 1).padStart(2, '0');
    const year = dateObj.getFullYear();

    const hours = String(dateObj.getHours()).padStart(2, '0');
    const minutes = String(dateObj.getMinutes()).padStart(2, '0');

    const formattedDate = `${day}/${month}/${year}`;
    const formattedTime = `${hours}:${minutes}`;
    const dayReturn = {
        formattedDate,
        formattedTime
    }
    return dayReturn;
}

const ConvertCurrency = (numberString) => {
    const formattedNumber = parseInt(numberString, 10).toLocaleString('vi-VN', {
        style: 'currency',
        currency: 'VND',
    });
    const convertedNumber = formattedNumber.replace('₫', 'VND');
    return convertedNumber;
}


const InstallmentManagerScreen = ({ navigation }) => {


    const { GetInstallmentList } = useContext(InstallmentContext);
    const { installmentDatas } = useContext(InstallmentContext);

    useEffect(() => {
        GetInstallmentList();

    }, [])



    const handleExit = () => {
        navigation.navigate(AppConst.ScreenConst.HOME_SCREEN);
    }

    const NoResultData = () => {
        return (
            <View className="items-center mt-5">
                <Text className="font-bold">
                    Không có đơn hàng trả góp!
                </Text>
            </View>


        )
    }


    return (
        <View className="bg-stone-100">

            {/* <SearchHeader /> */}

            <View className="" style={{ height: "100%", width: '100%' }}>
                <ScrollView
                    showsHorizontalScrollIndicator={false}
                    showsVerticalScrollIndicator={false}
                >
                    {
                        installmentDatas && installmentDatas.length > 0 ? (
                            <MasonryList
                                data={installmentDatas}
                                numColumns={1}
                                renderItem={({ item }) => (
                                    <OrderCard data={item} />
                                )}
                                columnWrapperStyle={{ justifyContent: 'space-between' }}
                                contentContainerStyle={{ paddingVertical: 10 }}
                            />
                        ) : (
                            <NoResultData />
                        )

                    }
                </ScrollView>
            </View>

        </View>
    );
}
export default InstallmentManagerScreen;

const OrderCard = ({ data }) => {


    const { CancelOrder } = useContext(OrderContext);
    const handleCancelOrder = (orderID) => {
        console.log("huy" + orderID);
        CancelOrder(orderID);
    }
    const ConfirmCancelOrder = (orderID) => {
        Alert.alert(
            'Bạn có chắc chắn muốn hủy đơn hàng?',
            '',
            [
                { text: 'Trở về', },
                { text: 'Đồng ý', onPress: () => handleCancelOrder(orderID) }
            ],
            { cancelable: false }
        );
    }

    return (
        <View className="" style={styles.card} >
            {/* header */}
            <View className="flex-row justify-between bg-white px-1 rounded-tl rounded-tr" style={{ backgroundColor: argonTheme.COLORS.ERROR }}>
                <View className="justify-center items-start">
                    <Text className="font-bold" style={{ fontSize: responsiveFontSize(2.5), color: "white" }}>
                        {data.simNumber}
                    </Text>
                </View>
            </View>
            <View testID="body" style={{ padding: 5 }}>

                {/* Status */}
                
                <View className="flex-row">
                    <Text style={{ fontSize: responsiveFontSize(1.8), fontWeight: "bold" }} className="flex-1">Trạng thái</Text>
                    <Text style={{ fontSize: responsiveFontSize(1.8), fontWeight: "bold" }} className="flex-1 text-right" >  {data.approvedStatus}</Text>
                </View>

                {/* Price */}
                <View className="flex-row">
                    <Text style={{ fontSize: responsiveFontSize(1.8), fontWeight: "bold" }} className="flex-1">Giá Sim</Text>
                    <Text style={{ fontSize: responsiveFontSize(1.8) }} className="flex-1 text-right" >  {ConvertCurrency(data.orderPrice)}</Text>
                </View>
                {/* Familiar Price */}
                <View className="flex-row">
                    <Text style={{ fontSize: responsiveFontSize(1.8), fontWeight: "bold" }} className="flex-1">Thời hạn trả góp</Text>
                    <Text style={{ fontSize: responsiveFontSize(1.8) }} className="flex-1 text-right" >  {`${data.installmentPeriod} tháng`}</Text>
                </View>
                <View className="flex-row">
                    <Text style={{ fontSize: responsiveFontSize(1.8), fontWeight: "bold" }} className="flex-1">Ngày kết thúc</Text>
                    <Text style={{ fontSize: responsiveFontSize(1.8), color: '#1183d2', fontWeight: 'bold' }} className="flex-1 text-right" >  {`${GetDayFormat(data.installmentEndDate).formattedDate} ${GetDayFormat(data.installmentEndDate).formattedTime}`}</Text>
                </View>

                <View className="flex-row">
                    <Text style={{ fontSize: responsiveFontSize(1.8), fontWeight: "bold" }} className="flex-1">Ngày trả hàng tháng</Text>
                    <Text style={{ fontSize: responsiveFontSize(1.8) }} className="flex-1 text-right" >  {`${data.dateOfPayment}`}</Text>
                </View>

                <View className="flex-row">
                    <Text style={{ fontSize: responsiveFontSize(1.8), fontWeight: "bold" }} className="flex-1">Tiền đã trả trước</Text>
                    <Text style={{ fontSize: responsiveFontSize(1.8) }} className="flex-1 text-right" >  {`${ConvertCurrency(data.downPayment)}`}</Text>
                </View>

                <View className="flex-row">
                    <Text style={{ fontSize: responsiveFontSize(1.8), fontWeight: "bold" }} className="flex-1">Tổng tiền trả góp</Text>
                    <Text style={{ fontSize: responsiveFontSize(1.8) }} className="flex-1 text-right" >  {ConvertCurrency(data.installmentPayment)}</Text>
                </View>

                <View className="flex-row">
                    <Text style={{ fontSize: responsiveFontSize(1.8), fontWeight: "bold" }} className="flex-1">Lãi suất (tính cho 1tr/1 ngày)</Text>
                    <Text style={{ fontSize: responsiveFontSize(1.8) }} className="flex-1 text-right" >  {`${ConvertCurrency(data.interestRate)}`}</Text>
                </View>

                <View className="flex-row">
                    <Text style={{ fontSize: responsiveFontSize(1.8), fontWeight: "bold" }} className="flex-1">Trả góp hàng tháng</Text>
                    <Text style={{ fontSize: responsiveFontSize(1.8), color: argonTheme.COLORS.ERROR, fontWeight: 'bold' }} className="flex-1 text-right" >  {ConvertCurrency(data.monthlyInstallmentPayment)}</Text>
                </View>

                <View className="flex-row">
                    <Text style={{ fontSize: responsiveFontSize(1.8), fontWeight: "bold" }} className="flex-1">Ghi chú</Text>
                    <Text style={{ fontSize: responsiveFontSize(1.8) }} className="flex-1 text-right" >  {data.note}</Text>
                </View>
            </View>
        </View>
    );
}
const styles = {
    card: {
        backgroundColor: 'white',
        shadowColor: 'black',
        shadowOffset: { width: 1, height: 1 },
        shadowOpacity: 1,
        shadowRadius: 8,
        elevation: 5,
        borderColor: "black",
        marginLeft: 10,
        marginRight: 10,
        marginTop: 5,
        marginBottom: 5,
        height: "auto",

    },
};