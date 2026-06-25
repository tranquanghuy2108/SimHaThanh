import React, { useEffect, useState, useContext } from "react";
import { View, TextInput, TouchableOpacity, Text, ScrollView, Alert, StyleSheet } from 'react-native';
import { OrderContext } from "../context/OrderContext";
import Ionicons from 'react-native-vector-icons/Ionicons';
import { SafeAreaView } from "react-native-safe-area-context";
import { argonTheme, } from "../constants";
import { BottomTabContext } from "../context/BottomTabContext";
import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
} from "react-native-responsive-dimensions";
import Config from "../constants/Config";
const ConvertCurrency = (numberString) => {
    const formattedNumber = parseInt(numberString, 10).toLocaleString('vi-VN', {
        style: 'currency',
        currency: 'VND',
    });
    const convertedNumber = formattedNumber.replace('₫', 'VND');
    return convertedNumber;
}
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
        day,
        month,
        year,
        formattedDate,

        formattedTime
    }
    return dayReturn;
}

const OrderScreen = (props) => {
    const { orderDatas, GetAllOrder } = useContext(OrderContext);
    const [filterData, SetFilterData] = useState(orderDatas);


    useEffect(() => {
        GetAllOrder();


    }, [])
    useEffect(() => {
        SetFilterData(orderDatas);
        console.log("ORDER LIST: " + JSON.stringify(filterData));
    }, [orderDatas]);


    const handleExit = () => {

        if (!props.isDrawer) {
            props.navigation.goBack();
        }
        else {
            props.navigation.closeDrawer();
        }


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
            <TouchableOpacity className="flex-1" activeOpacity={.9}>
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
                <Ionicons name="chevron-back-outline" color="black" size={26}></Ionicons>
            </TouchableOpacity>
        );
    }

    const NoResultData = () => {
        return (
            <View className="items-center mt-5" style={{ height: "100%" }}>
                <Text className="font-bold">
                    Không có đơn hàng!
                </Text>
            </View>


        )
    }

    return (
        <View className="bg-stone-100">
            <SafeAreaView>

                <SearchHeader />

                {
                    filterData && filterData.length > 0 ? (
                        <View className="" style={{ height: "90%" }}>
                            <ScrollView
                                showsHorizontalScrollIndicator={false}
                                showsVerticalScrollIndicator={false}
                                style={{ height: "100%" }}
                            >
                                {
                                    filterData.map(item => {
                                        return (
                                            <OrderCard data={item} key={item.id} />
                                        )
                                    })
                                }

                            </ScrollView>
                        </View>

                    ) : (
                        <NoResultData />
                    )
                }




            </SafeAreaView>
        </View>
    );
}
export default OrderScreen;

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
            <View className="flex-row justify-between bg-white px-2 rounded-tl rounded-tr" >
                <View className="justify-center items-start">
                    <Text className="font-bold" style={{ fontSize: responsiveFontSize(2.5) }}>
                        {data.simInfos[0].simNumber}
                    </Text>
                </View>
                {
                    data.status === "Order" ? (
                        <TouchableOpacity className="justify-center  items-center flex-row my-2 rounded"
                            style={{ backgroundColor: argonTheme.COLORS.ERROR, width: responsiveWidth(20), height: responsiveHeight(4) }}
                            onPress={() => { ConfirmCancelOrder((data.id)) }}
                        >
                            <Text className="color-white font-bold" style={{ fontSize: responsiveFontSize(1.8) }}>Hủy đơn</Text>
                        </TouchableOpacity>
                    )
                        :
                        (
                            null
                        )
                }
            </View>
            <View className="flex-row px-2">
                <Text style={{ fontSize: responsiveFontSize(1.8), fontWeight: "bold" }} className="flex-1">Loại thanh toán</Text>
                <Text style={{ fontSize: responsiveFontSize(1.8), fontWeight: "bold" }} className="flex-1 text-right" >  {data.payOrderType}</Text>
            </View>
            <View className="flex-row px-2">
                <Text style={{ fontSize: responsiveFontSize(1.8), fontWeight: "bold" }} className="flex-1">Trạng thái</Text>
                <Text style={{ fontSize: responsiveFontSize(1.8), fontWeight: "bold" }} className="flex-1 text-right" >  {data.status}</Text>
            </View>
            <View className="flex-row px-2">
                <Text style={{ fontSize: responsiveFontSize(1.8) }} className="flex-1">Giá Sim</Text>
                <Text style={{ fontSize: responsiveFontSize(1.8) }} className="flex-1 text-right" >  {ConvertCurrency(data.priceOfSim)}</Text>
            </View>
            {/* /////////////////////////////////// */}


            {/* Familiar Price */}

            {
                data.payOrderType === Config.PAY_ORDER_TYPE.INSTALLMENT ?
                    (
                        <View>
                            <View className="flex-row px-2">
                                <Text style={{ fontSize: responsiveFontSize(1.8), }} className="flex-1">Thời hạn trả góp</Text>
                                <Text style={{ fontSize: responsiveFontSize(1.8) }} className="flex-1 text-right" >  {`${data.installmentPeriod} tháng`}</Text>
                            </View>
                            <View className="flex-row px-2">
                                <Text style={{ fontSize: responsiveFontSize(1.8), }} className="flex-1">Ngày kết thúc</Text>
                                <Text style={{ fontSize: responsiveFontSize(1.8), color: '#1183d2', fontWeight: 'bold' }} className="flex-1 text-right" >  {`${GetDayFormat(data.installmentEndDate).formattedDate} ${GetDayFormat(data.installmentEndDate).formattedTime}`}</Text>
                            </View>

                            <View className="flex-row px-2">
                                <Text style={{ fontSize: responsiveFontSize(1.8), }} className="flex-1">Ngày trả hàng tháng</Text>
                                <Text style={{ fontSize: responsiveFontSize(1.8) }} className="flex-1 text-right" >  {`${GetDayFormat(data.installmentEndDate).day}`}</Text>
                            </View>

                            <View className="flex-row px-2">
                                <Text style={{ fontSize: responsiveFontSize(1.8), }} className="flex-1">Tiền đã trả trước</Text>
                                <Text style={{ fontSize: responsiveFontSize(1.8) }} className="flex-1 text-right" >  {`${ConvertCurrency(data.downPayment)}`}</Text>
                            </View>

                            <View className="flex-row px-2">
                                <Text style={{ fontSize: responsiveFontSize(1.8), }} className="flex-1">Tổng tiền trả góp</Text>
                                <Text style={{ fontSize: responsiveFontSize(1.8) }} className="flex-1 text-right" >  {ConvertCurrency(data.installmentPayment)}</Text>
                            </View>

                            <View className="flex-row px-2">
                                <Text style={{ fontSize: responsiveFontSize(1.8), }} className="flex-1">Lãi suất (tính cho 1tr/1 ngày)</Text>
                                <Text style={{ fontSize: responsiveFontSize(1.8) }} className="flex-1 text-right" >  {`${ConvertCurrency(data.interestRate)}`}</Text>
                            </View>

                            <View className="flex-row px-2">
                                <Text style={{ fontSize: responsiveFontSize(1.8), fontWeight: "bold" }} className="flex-1">Trả góp hàng tháng</Text>
                                <Text style={{ fontSize: responsiveFontSize(1.8), color: argonTheme.COLORS.ERROR, fontWeight: 'bold' }} className="flex-1 text-right" >  {ConvertCurrency(data.monthlyInstallmentPayment)}</Text>
                            </View>

                        </View>
                    ) :
                    (null)



            }



            {/* ///////////////////////////////////////////// */}



            {/* Price */}
            <View className="flex-row px-2">
                <Text style={{ fontSize: responsiveFontSize(1.8) }} className="flex-1">Chiết khấu</Text>
                <Text style={{ fontSize: responsiveFontSize(1.8) }} className="flex-1 text-right" >  {`${data.discount}%`}</Text>
            </View>
            {/* Familiar Price */}

            {

                data.payOrderType !== Config.PAY_ORDER_TYPE.INSTALLMENT ?
                    (
                        <View className="flex-row px-2">
                            <Text style={{ fontSize: responsiveFontSize(1.8), fontWeight: "bold" }} className="flex-1">Thành Tiền</Text>
                            <Text style={{ fontSize: responsiveFontSize(1.8), fontWeight: "bold" }} className="flex-1 text-right" >{ConvertCurrency(data.priceOrder)}</Text>
                        </View>
                    )
                    : (
                        null
                    )

            }



            <View className="flex-row px-2">
                <Text className="text-start" style={{ color: '#1183d2', fontSize: responsiveFontSize(1.8) }}>{data.createTime}</Text>
            </View>
        </View>
    );
}
const styles = StyleSheet.create({
    card: {
        backgroundColor: '#f8f8f8f8',
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
        padding: 5,

    },
})

