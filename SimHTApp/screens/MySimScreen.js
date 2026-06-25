import React, { useContext } from "react";
import { Dimensions, ScrollView, TouchableOpacity, View, TextInput } from "react-native";
import { SafeAreaView } from 'react-native-safe-area-context';

// Galio components
import { Checkbox, Text } from "galio-framework";
import { Button } from "../components";
// Argon themed components
import { argonTheme } from "../constants";
import Ionicons from 'react-native-vector-icons/Ionicons';
import { MySimContext } from "../context/MySimContext";
import { AppConst } from "../constants/AppConst";
import { BottomTabContext } from "../context/BottomTabContext";
import MySimEmphasizFilter from "../customComponents/MySimEmphasizFilter";
import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
} from "react-native-responsive-dimensions";

const ConvertCurrency = (numberString) => {
    const formattedNumber = parseInt(numberString, 10).toLocaleString('vi-VN', {
        style: 'currency',
        currency: 'VND',
    });
    return formattedNumber;
}



const MySimScreen = (props) => {

    const { search, searchPaging } = useContext(MySimContext);
    const { searchResult } = useContext(MySimContext);


    const SearchButton = () => {
        const { searchMySimKey, SetSearchMySim } = useContext(BottomTabContext);

        const handleInputChange = (text) => {
            SetSearchMySim(text);
        };
        const handleInputSubmit = async () => {
            search(searchMySimKey);
        }
        const handleBlur = () => {
            console.log("Hello blur")
            search(searchMySimKey);
        }


        return (

            <TouchableOpacity className="flex-1" activeOpacity={.9} onPress={() => { handleInputFocus() }}>
                <View className="flex-row flex-0 items-center rounded-full bg-white mx-1">
                    <View className="bg-transparent rounded-full m-3">
                        <Ionicons name="search-outline" color="black" size={20}></Ionicons>
                    </View>
                    <TextInput
                        placeholder='Tìm SIM của tôi'
                        placeholderTextColor={'gray'}
                        className="flex-1 text-base p-1 tracking-wider"
                        returnKeyType="search"
                        editable={true}
                        onChangeText={handleInputChange}
                        value={searchMySimKey}
                        onSubmitEditing={
                            handleInputSubmit
                        }
                        onBlur={handleBlur}
                    />
                </View>
            </TouchableOpacity>
        );
    }

    const FilterButton = () => {
        return (

            // Nút Lọc
            <TouchableOpacity
                className="p-2 bg-transparent flex-row justify-center items-center" style={{ borderTopLeftRadius: 15, borderTopRightRadius: 15, borderBottomLeftRadius: 15, borderBottomRightRadius: 15 }}
                onPress={() => {
                    props.navigation.getParent("MY_SIM_FILTER").openDrawer();
                }}
            >
                <Ionicons name="funnel-outline" color="white" size={30}></Ionicons>
                <Text className="text-bold" style={{ color: '#1183d2', fontSize: 18, fontWeight: 'bold' }}>

                </Text>
            </TouchableOpacity>
        );
    }
    const ExitButton = () => {
        return (
            // Nút Thoát
            <TouchableOpacity className="p-1 rounded-full bg-white mx-1"
                onPress={() => {
                    props.navigation.goBack();
                }}>
                {/* <Text
                    style={{ fontSize: 20 }}
                >
                    Thoát
                </Text> */}
                <Ionicons name="chevron-back-outline" color="black" size={26}></Ionicons>
            </TouchableOpacity>
        );
    }

    const SearchHeader = () => {
        return (

            <View className="flex-row justify-center items-center p-2" backgroundColor={argonTheme.COLORS.ERROR}>
                <ExitButton />
                <SearchButton className="flex-start" />

                {/* <FilterButton className="flex-end" /> */}
            </View>
        );
    }


    const SearchResult = ({ item }) => {
        return (
            <View className="">
                {
                    searchResult && searchResult.map(item => {
                        return (
                            <View className="flex-row bg-white border-b border-stone-300">
                                <View className="ml-3 items-left justify-center">
                                    <Checkbox color="warning" />
                                </View>
                                <View className="flex-1 ml-5 items-left justify-center space-y-4">
                                    <Text className="font-bold text-sm" style={{ fontSize: responsiveFontSize(2.5) }}>{item.simNumber}</Text>
                                    <Text className="text-xs" style={{ fontSize: responsiveFontSize(2) }}>{item.network}</Text>
                                </View>
                                <View className="items-end justify-center ">
                                    <Text className="font-bold text-sm mx-2" style={{ fontSize: responsiveFontSize(2) }}>{ConvertCurrency(item.simPrice)}</Text>
                                    <Button style={{ height: responsiveHeight(5), width: responsiveWidth(22) }} color="error" onPress={() => {

                                        // openPopup(item) 
                                        var simDataParam = {
                                            id: item.id,
                                            phoneNumber: item.simNumber,
                                            networkID: "",
                                            networkName:  item.network,
                                            isSaleActive: false,
                                            price: item.simPrice,
                                            priceOnSale: null,
                                        }

                                        props.navigation.push(AppConst.StackConst.NATIVE_STACK, { screen: AppConst.ScreenConst.PURCHASE_SIM, params: { simDataParam: simDataParam } })

                                    }}>
                                        <Text style={{ fontSize: responsiveFontSize(1.9), color: 'white', fontWeight: 'bold' }}>
                                            Đặt mua
                                        </Text>

                                    </Button>
                                </View>
                            </View>
                        )
                    })
                }



            </View>
        );
    }
    const NoResultData = () => {
        return (
            <View className="items-center mt-5">
                <Text className="font-bold">
                    Không có dữ liệu!
                </Text>
            </View>


        )
    }
    return (
        <SafeAreaView>
            <SearchHeader />
            <MySimEmphasizFilter />
            <ScrollView style={{ marginBottom: responsiveHeight(14) }}
                onScroll={({ nativeEvent }) => {
                    const { layoutMeasurement, contentOffset, contentSize } = nativeEvent;
                    const isEndReached = layoutMeasurement.height + contentOffset.y >= contentSize.height - 1;
                    if (isEndReached) {
                        console.log("reach end");
                        if(searchResult && searchResult.length>0 && searchResult[0].nextID!=0){
                            searchPaging();
                        }
                    }
                }}
            >
                {

                    searchResult && searchResult.length > 0 ? (
                        <SearchResult />
                    ) :
                        (
                            <NoResultData />
                        )
                }
            </ScrollView>
        </SafeAreaView>
    )
}

export default MySimScreen;
