import React, { useState, useContext, useRef, useEffect } from 'react';
import { TouchableOpacity, ScrollView, Text, Image, View, TextInput, StyleSheet, SafeAreaView, ToastAndroid } from 'react-native';
import DateTimePicker from '@react-native-community/datetimepicker';
import MasonryList from '@react-native-seoul/masonry-list';
import { StatusBar } from 'expo-status-bar';
import Banner from '../customComponents/Banner';
import { AppConst } from '../constants/AppConst';
import Ionicons from 'react-native-vector-icons/Ionicons';
import { argonTheme } from '../constants';
import { FengShuiContext } from '../context/FengShuiContext';
import { BottomTabContext } from '../context/BottomTabContext';
import {
    responsiveScreenHeight,
    responsiveScreenWidth,
    responsiveScreenFontSize
} from "react-native-responsive-dimensions";



const RegisterCollabPopupScreen = ({ navigation }) => {
    const { valueSimData} = useContext(FengShuiContext);
    const { ValuateSim,ResetValuaSimData} = useContext(FengShuiContext);


    const [valuationSearch ,SetValuationSearchState] = useState("");

  
    useEffect(() =>{
        ResetValuaSimData();
    },[])
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

    const ConvertCurrency = (numberString) => {
        const formattedNumber = parseInt(numberString, 10).toLocaleString('vi-VN', {
            style: 'currency',
            currency: 'VND',
        });
        return formattedNumber;
    }
    const handleSimNumberChange = (text) => {
        SetValuationSearchState(text);
    }
    return (
        <SafeAreaView>
            <View className="mt-9">

                <Banner></Banner>
                <View testID="Body" className="mx-2">
                    <Text style={{fontSize: responsiveScreenFontSize(2),fontWeight:"bold"}}>Sim muốn định giá</Text>

                    {/* SearchButton */}
                    <View style={styles.container}>
                        <TextInput
                            style={styles.input}
                            placeholder="Số điện thoại"
                            placeholderTextColor="#888"
                            keyboardType='numeric'
                            value={valuationSearch}
                            onChangeText={handleSimNumberChange}
                            maxLength={10}
                        />
                        <TouchableOpacity style={styles.button}
                            onPress={
                                () => {

                                    if (isValidPhoneNumber(valuationSearch)) {
                                        ValuateSim(parseInt(valuationSearch));
                                    } else {
                                        ToastAndroid.showWithGravity(
                                            'Vui Lòng Kiểm Tra Lại Thông Tin!',
                                            ToastAndroid.SHORT,
                                            ToastAndroid.BOTTOM,
                                        );

                                    }
                                }
                            }
                        >
                            <Text style={styles.buttonText}>Định Giá</Text>
                        </TouchableOpacity>
                    </View>


                    {
                        valueSimData && (
                            <View testID='CardContainer' style={styles.cardContainer} >
                                <Image source={require('../assets/imgs/sim_card.png')} style={styles.cardImage} resizeMode="contain" />
                                <View testID='CardContent' style={styles.cardContent} >
                                    <View >
                                        <Text style={{ fontSize:  responsiveScreenFontSize(2.7), color: 'white', fontWeight: 'bold' }}> {valuationSearch}</Text>
                                    </View>
                                    <View style={{ flex: 1, flexDirection: 'column', justifyContent:"flex-end"}}>

                                        <Text style={{ fontSize: responsiveScreenFontSize(2), color: 'white', fontWeight: 'bold', textAlign: "center" }}>{`Sim được định giá tham khảo`}</Text>
                                        <Text style={{ fontSize:  responsiveScreenFontSize(2.5), color: 'white', fontWeight: 'bold', textAlign: "center" }}>{`${ConvertCurrency(valueSimData)}`}</Text>
                                    </View>
                                </View>

                            </View>

                        )

                    }


                    <Text style={{color:argonTheme.COLORS.ERROR,fontSize: responsiveScreenFontSize(2),fontWeight:"bold"}}>Lưu ý:</Text>
                    <Text style={{ fontSize: responsiveScreenFontSize(2) }}>Công cụ Định giá sim số đẹp chỉ mang tính chất tham khảo.</Text>
                    <Text style={{ fontSize: responsiveScreenFontSize(2) }}>Quý khách muốn trao đổi bán sim hãy thỏa thuận hai bên.</Text>
                </View>
            </View>
        </SafeAreaView>
    );
}

const styles = StyleSheet.create({
    container: {
        flexDirection: 'row',
        borderRadius: 5,
        borderWidth: 1,
        borderColor: '#ccc',
        backgroundColor: 'white'
    },
    cardContainer: {
        position: 'relative',
        width: 'auto',
        marginTop: 10,
        height: responsiveScreenHeight(22),
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
        padding: 15,
        height: "100%",
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
    buttonText: {
        color: 'white',
        fontWeight: 'bold',
    },
});
export default RegisterCollabPopupScreen;