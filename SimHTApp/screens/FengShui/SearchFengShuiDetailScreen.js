import React, { useContext } from 'react';
import { TouchableOpacity, Text, Image, View, StyleSheet, SafeAreaView, ScrollView } from 'react-native';
import { AppConst } from '../../constants/AppConst';
import { argonTheme } from '../../constants';
import { FengShuiContext } from '../../context/FengShuiContext';


import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
} from "react-native-responsive-dimensions";

const netWorkNames = [
    { name: 'Viettel', id: 1, image: require('../../assets/imgs/icon_viettel.png') },
    { name: 'Vinaphone', id: 2, image: require('../../assets/imgs/icon_vinaphone.png') },
    { name: 'Mobiphone', id: 3, image: require('../../assets/imgs/icon_mobifone.png') },
    { name: 'VietNamobile', id: 4, image: require('../../assets/imgs/icon_vietnamobile.png') },
    { name: 'Gmobile', id: 5, image: require('../../assets/imgs/icon_gMobile.png') },
    { name: 'iTel', id: 6, image: require('../../assets/imgs/icon_itel.png') },
];

const TakePhotoOfNetWork = (id) => {
    var x = netWorkNames.find(x => x.id == id);
    return x.image;

}

const ConvertCurrency = (numberString) => {
    const formattedNumber = parseInt(numberString, 10).toLocaleString('vi-VN', {
        style: 'currency',
        currency: 'VND',
    });
    return formattedNumber;
}
const ConvertPhoneNumber = (phoneNumber) => {
    const convertedString = phoneNumber.split(".").join("");
    return convertedString;
}


const SearchFengShuiDetailScreen = ({ navigation }) => {

    const { searchFortuneData,yearBirth, monthBirth, dateBirth, hourBirth, minuteBirth, isMale } = useContext(FengShuiContext);

    const { FotureTelling, SearchPagingFotureSim } = useContext(FengShuiContext);
    return (

        <SafeAreaView>
            {
                searchFortuneData ? (
                    <View>


                        <ScrollView className=""
                            showsVerticalScrollIndicator={false}
                            showsHorizontalScrollIndicator={false}

                            onScroll={({ nativeEvent }) => {
                                const { layoutMeasurement, contentOffset, contentSize } = nativeEvent;
                                const isEndReached = layoutMeasurement.height + contentOffset.y >= contentSize.height - responsiveHeight(1);
                                if (isEndReached) {
                                    console.log("reach end");
                                    SearchPagingFotureSim();
                                }
                            }}


                        >
                            {searchFortuneData.menhchu && (
                                <View>
                                    <View testID="OverView" style={styles.info}>

                                        <Image source={require('./../../assets/FortuneCard/zodiac12.png')} style={{ width: "100%", height: "100%", position: "absolute", top: 10 }} resizeMode='contain' />
                                        <View testID="FirstRow" className="flex-row">
                                            <View testID="Left" >
                                                <Image source={require('../../assets/imgs/icon_user.png')} style={{ width: responsiveWidth(10), height: responsiveWidth(10), top: 7 }} resizeMode='contain' />
                                            </View>
                                            <View testID="right" className="flex-1">

                                                <Text >
                                                    <Text style={styles.texHeader}>Thân chủ: </Text>
                                                    <Text style={styles.textContent}>{`sinh ngày ( ${searchFortuneData.lunarBirthDay} Âm lịch)`}</Text>

                                                </Text>


                                                <Text >
                                                    <Text style={styles.texHeader}>Năm can chi: </Text>
                                                    <Text style={styles.textContent}>{`${searchFortuneData.menhchu.canChi}`}</Text>
                                                </Text>
                                            </View>

                                        </View>

                                        {/* Mệnh Niên */}
                                        <View testID="NextRow" className="flex-1">

                                            <Text >
                                                <Text style={styles.texHeader}>Mệnh Cung Sinh: </Text>
                                                <Text style={styles.textContent}>{`${searchFortuneData.menhchu.cungSinh1} - ${searchFortuneData.menhchu.cungSinh2}`}</Text>
                                            </Text>
                                        </View>

                                        {/* Mệnh quái */}
                                        <View testID="NextRow" className="flex-1">

                                            <Text >
                                                <Text style={styles.texHeader}>Ngũ hành: </Text>
                                                <Text style={styles.textContent}>{`${searchFortuneData.menhchu.nguHanh}`}</Text>
                                            </Text>
                                        </View>
                                        {/* Mệnh Niên */}
                                        <View testID="NextRow" className="flex-1">

                                            <Text >
                                                <Text style={styles.texHeader}>Mệnh Cung Phi: </Text>
                                                <Text style={styles.textContent}>{`${searchFortuneData.menhchu.cungPhi1} - ${searchFortuneData.menhchu.cungPhi2}`}</Text>
                                            </Text>
                                        </View>

                                        {/* Cung mệnh */}
                                        <View testID="NextRow" className="flex-1">

                                            <Text >
                                                <Text style={styles.texHeader}>Con Giáp: </Text>
                                                <Text style={styles.textContent}>{`${searchFortuneData.menhchu.conGiap}`}</Text>
                                            </Text>
                                        </View>



                                    </View>

                                    <View style={styles.headerFindSim}>
                                        <Text >
                                            <Text style={styles.headerFindSimTxt}>CÁC SIM HỢP MỆNH</Text>
                                        </Text>
                                    </View>

                                </View>
                            )}


                            {

                                searchFortuneData.simPhongThuys && (
                                    searchFortuneData.simPhongThuys.map(item => {
                                        return (
                                            <View className="mx-2 ">
                                                {/* OVerview */}
                                                <View testID="OverView" style={styles.overview}>
                                                    <View testID="FirstRow" className="flex-row">

                                                        <View className="flex-1">
                                                            <Text style={styles.textSimNumber}>
                                                                {item.simNumber}

                                                            </Text>
                                                        </View>
                                                        <View testID="Left" >
                                                            <Image source={TakePhotoOfNetWork(item.networkId)} style={{ width: responsiveWidth(22), height: responsiveHeight(4) }} resizeMode='contain' />
                                                        </View>
                                                    </View>


                                                    {/* Price */}

                                                    <View className="flex-1">
                                                        <Text style={styles.textSimPrice}>{ConvertCurrency(item.price)}</Text>
                                                    </View>
                                                    {/* Mệnh Niên */}
                                                    <View testID="NextRow" className="flex-1">

                                                        <Text >
                                                            <Text style={styles.texHeader}>Điểm phong thủy: </Text>
                                                            <Text style={styles.textPoint}>{item.point}/10</Text>
                                                        </Text>
                                                    </View>
                                                    {/* Mệnh Niên */}
                                                    <View testID="NextRow" className="flex-1">

                                                        <Text >
                                                            <Text style={styles.texHeader}>Sim ngũ hành: </Text>
                                                            <Text style={[styles.FiveElement, {
                                                                color:
                                                                    item.nguHanhSim === "Thổ" ? "#ad7607" :
                                                                        item.nguHanhSim === "Hỏa" ? "#c43616" :
                                                                            item.nguHanhSim === "Thủy" ? "#067bba" :
                                                                                item.nguHanhSim === "Mộc" ? "#38b57d" :
                                                                                    item.nguHanhSim === "Kim" ? "#8f897c" :
                                                                                        "#3297c9"
                                                            }]}>{item.nguHanhSim}</Text>
                                                        </Text>
                                                    </View>

                                                    {/* Mệnh quái */}
                                                    <View testID="NextRow" className="flex-1">

                                                        <Text >
                                                            <Text style={styles.texHeader}>Quẻ kinh dịch: </Text>
                                                            <Text style={styles.textContent}>{item.queKinhDich}</Text>
                                                        </Text>
                                                    </View>
                                                    {/* Mệnh quái */}
                                                    <View testID="NextRow" className="flex-1">

                                                        <Text className="flex-1">
                                                            <Text style={styles.texHeader}>Ý nghĩa: </Text>
                                                            <Text style={styles.textContent}>{item.yNghiaQue}</Text>
                                                        </Text>
                                                    </View>
                                                    {/* CẢI VẬN BỔ KHUYẾT */}
                                                    <View className=''>
                                                        <View style={styles.bottomSim}>
                                                            <TouchableOpacity style={styles.buttonFortune}
                                                                onPress={() => {
                                                                    FotureTelling(ConvertPhoneNumber(item.simNumber), yearBirth, monthBirth, dateBirth, hourBirth, minuteBirth, isMale);
                                                                    navigation.navigate(AppConst.StackConst.NATIVE_STACK, { screen: AppConst.ScreenConst.FORTUNE_SIM_DETAIL_SCREEN });
                                                                }}
                                                            >
                                                                <Text style={styles.textBtnFortune}>Xem luận giải</Text>
                                                            </TouchableOpacity>

                                                            <TouchableOpacity style={styles.buttonOrder}

                                                                onPress={() => {

                                                                    var simDataParam = {
 
                                                                        id: item.simId,
                                                                        phoneNumber:item.simNumber,
                                                                        networkID: item.networkId,
                                                                        networkName:  "",
                                                                        isSaleActive: false,
                                                                        price: item.price,
                                                                        priceOnSale: null,

                                                                    }

                                                                    navigation.navigate(AppConst.StackConst.NATIVE_STACK, { screen: AppConst.ScreenConst.PURCHASE_SIM, params: { simDataParam: simDataParam } })

                                                                }}
                                                            >
                                                                <Text style={styles.textBtnOrder}>Mua ngay</Text>
                                                            </TouchableOpacity>
                                                        </View>
                                                    </View>

                                                </View>

                                            </View>
                                        );
                                    })



                                )

                            }
                        </ScrollView>
                    </View>
                )
                    : (
                        <View className="items-center mt-5">
                            <Text className="font-bold">
                                Không có dữ liệu!
                            </Text>
                        </View>
                    )
            }
        </SafeAreaView>
    )
}
const styles = StyleSheet.create({
    info: {
        height: 'auto',
        borderRadius: 5,
        padding: 10,
        margin: 11,
        shadowOffset: { width: 1, height: 1 },
        shadowOpacity: 1,
        shadowRadius: 8,
        elevation: 5,
        backgroundColor: 'white',
        shadowColor: 'black',

    },
    headerFindSim: {
        height: 'auto',
        borderRadius: 5,
        flex: 1,
        padding: 10,
        margin: 10,
        shadowOffset: { width: 1, height: 1 },
        shadowOpacity: 1,
        shadowRadius: 8,
        elevation: 5,
        backgroundColor: argonTheme.COLORS.ERROR,
        shadowColor: 'black',
        justifyContent: "center",
        alignItems: "center"

    },
    headerFindSimTxt: {
        fontWeight: "bold",
        fontSize: responsiveFontSize(2.2),
        color: "white",
        textAlign: "center"

    },
    overview: {
        height: 'auto',
        borderRadius: 5,
        padding: 10,
        margin: 4,
        shadowOffset: { width: 1, height: 1 },
        shadowOpacity: 1,
        shadowRadius: 8,
        elevation: 5,
        backgroundColor: 'white',
        shadowColor: 'black',

    },
    textRow: {
        textAlign: "auto",
    },
    textSimNumber: {
        fontWeight: "bold",
        fontSize: responsiveFontSize(2.5),
        color: "#3297c9"
    },
    textSimPrice: {
        fontWeight: "bold",
        fontSize: responsiveFontSize(2.2),
        color: argonTheme.COLORS.ERROR
    },
    textPoint: {
        textAlign: "justify",
        marginLeft: 5,
        marginRight: 5,
        fontWeight: "bold",
        fontSize: responsiveFontSize(2),
        color: "#38b57d"
    },
    FiveElement: {
        textAlign: "justify",
        marginLeft: 5,
        marginRight: 5,
        fontWeight: "bold",
        fontSize: responsiveFontSize(2),
    },
    texHeader: {
        fontWeight: "bold",
        fontSize: responsiveFontSize(2.2),
    },
    textContent: {
        textAlign: "justify",
        marginLeft: 5,
        marginRight: 5,
        fontSize: responsiveFontSize(2),
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
        fontWeight: "bold"
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
        justifyContent: 'space-between',

        alignItems: "center",
        padding: 5,
        justifyContent: "center",
    },
    buttonOrder: {
        backgroundColor: argonTheme.COLORS.ERROR,
        padding: 5,
        borderRadius: 5,
        borderColor: argonTheme.COLORS.ERROR,
        borderWidth: 1,
        flex: 1,
        marginLeft: 2,
    },
    buttonFortune: {
        backgroundColor: "white",
        padding: 5,
        borderRadius: 5,
        borderColor: argonTheme.COLORS.ERROR,
        borderWidth: 1,
        flex: 1,
        alignContent: 'center',
        marginRight: 2,
    },
    textBtnOrder: {
        color: 'white',
        fontWeight: "bold",
        textAlign: "center",
        fontSize: 17,
    },
    textBtnFortune: {
        color: argonTheme.COLORS.ERROR,
        fontWeight: "bold",
        textAlign: "center",
        fontSize: 17,
    }

});

export default SearchFengShuiDetailScreen;