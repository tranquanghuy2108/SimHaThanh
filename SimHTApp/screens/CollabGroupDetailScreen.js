
import {  useEffect, useContext } from 'react'
import { View, Text, TouchableOpacity,StyleSheet, FlatList, ToastAndroid, StatusBar, Alert } from 'react-native';
import { CollaboratorContext } from '../context/CollaboratorContext';
import Ionicons from 'react-native-vector-icons/Ionicons';
import * as Clipboard from 'expo-clipboard';
import { argonTheme } from '../constants';
import { responsiveFontSize, responsiveWidth } from 'react-native-responsive-dimensions';
import { AppConst } from '../constants/AppConst';
import { AuthContext } from '../context/AuthContext';


const ConvertCurrency = (numberString)=>{
    const formattedNumber = parseInt(numberString, 10).toLocaleString();
    return formattedNumber;
}


const CollabGroupDetailScreen = ({ navigation, route }) => {

    const { memberGroupDatas,memberRequestDatas, myGroupOwnDatas, groupHadJoinDatas} = useContext(CollaboratorContext); //Datas
    const { GetMembersInGroup} = useContext(CollaboratorContext); //Datas
    const {userInfoData} = useContext(AuthContext);
    const { item } = route.params;
    useEffect(() => {
        navigation.setOptions({
            title: item.name, // Đặt tiêu đề mới cho header của screen này
        });
        GetMembersInGroup(item.id);
    }, [navigation]);
    const handleCopyCode = async () => {
        try {
            await Clipboard.setString(item.code);
            console.log('Sao chép mã thành công!');
            ToastAndroid.showWithGravity(
                'Sao chép thành công!',
                ToastAndroid.LONG,
                ToastAndroid.BOTTOM,
            );
        } catch (error) {
            console.log('Lỗi khi sao chép mã:', error);
            ToastAndroid.showWithGravity(
                'Sao chép thất bại!',
                ToastAndroid.LONG,
                ToastAndroid.BOTTOM,
            );
        }
    };
    const MememberGroupRow = ({ item }) => {
        return (

            <View style={styles.tableDiscountRow}>
            <View style={{ width: responsiveWidth(55) }}>
                <Text style={styles.tableDisRowTxt}>{item.memberName}</Text>
            </View>

            <View style={{ width: responsiveWidth(35) }}>
                <Text style={styles.tableDisRowTxt} >{item.memberPhoneNumber}</Text>
            </View>
        </View>


        );
    }
    const ExitButton = () => {
        return (
            // Nút Thoát
            <TouchableOpacity className="p-1 rounded-full bg-white mx-1 "
                onPress={() => {
                    if(userInfoData.discount){
                        if(userInfoData.isAgent){
                            navigation.goBack();
                        }
                        else{
                            navigation.navigate(AppConst.ScreenConst.HOME_SCREEN);
                        }
                    }
                    else{
                        navigation.navigate(AppConst.ScreenConst.HOME_SCREEN);
                    }

                }}>
                <Ionicons name="chevron-back-outline" color="black" size={26}></Ionicons>
            </TouchableOpacity>
        );
    }
    const Title = () => {
        return (
            <View className="flex-1 items-center justify-center">
                <Text style={{ color: "white", fontWeight: "bold", fontSize: responsiveFontSize(2.2) }}>{item.name}</Text>
            </View>

        );
    }
    const LogoutGroupBtn = () => {
        const ConfirmCancelOrder = (orderID) => {
            Alert.alert(
                'Bạn có chắc chắn muốn rời khỏi nhóm?',
                '',
                [
                    { text: 'Trở về', },
                    { text: 'Đồng ý', }
                ],
                { cancelable: false }
            );
        }

        return (
            // Nút Thoát
            <TouchableOpacity className="p-1 rounded-full bg-white mx-1 "
                onPress={() => {
                    ConfirmCancelOrder()
                }}>
                <Ionicons name="log-out-outline" color="black" size={25}></Ionicons>
            </TouchableOpacity>
        );
    }

    return (
        <View className="">
            
            <View className="flex-row p-2" style={{ zIndex: 1000, marginTop: StatusBar.currentHeight }} backgroundColor={argonTheme.COLORS.ERROR}>
                <ExitButton />
                <Title />
                {/* <LogoutGroupBtn/> */}
            </View>

            <View style={styles.headerContainer}>
          
           

                <Text>
                    <Text className="font-bold">Chủ đại lý: </Text>
                    <Text style={{ color: 'black' }}> {item.owner}</Text>
                </Text>

                <Text>
                    <Text className="font-bold">Số lượng thành viên: </Text>
                    <Text style={{ color: 'black' }}> {memberGroupDatas.length}</Text>
                </Text>

                <Text>
                    <Text className="font-bold">Chiết Khẩu:</Text>
                    {/* <Text style={{ color: 'black' }}> {item.discount}</Text> */}
                </Text>
                {
                    item.discount && item.discount.length > 0 ? (
                        <View style={styles.tableDiscountHeader}>
                            <View style={{ width: responsiveWidth(32) }}>
                                <Text style={styles.tableDisHeaderTxt}>Giá từ</Text>
                            </View>

                            <View style={{ width: responsiveWidth(33) }}>
                                <Text style={styles.tableDisHeaderTxt} >Giá đến</Text>
                            </View>

                            <View style={{ width: responsiveWidth(25) }}>
                                <Text style={styles.tableDisHeaderTxt} >Chiết khấu</Text>
                            </View>
                        </View>
                    )
                        :
                        (null)
                }


                {
                    item.discount && item.discount.map((dis) => {
                        return (
                            <View style={styles.tableDiscountRow}>
                                <View style={{ width: responsiveWidth(32) }}>
                                    <Text style={styles.tableDisRowTxt}>{ConvertCurrency(dis.priceFrom)}</Text>
                                </View>

                                <View style={{ width: responsiveWidth(33) }}>
                                    <Text style={styles.tableDisRowTxt} >{ConvertCurrency(dis.priceTo)}</Text>
                                </View>

                                <View style={{ width: responsiveWidth(25) }}>
                                    <Text style={styles.tableDisRowTxt} >{`${dis.discountPer}%`}</Text>
                                </View>


                            </View>
                        )
                    })

                }
                <View className="flex-row">

                    <Text>
                        <Text className="font-bold">Code: </Text>
                        <Text style={{ color: 'black' }} selectable> {item.code}</Text>
                    </Text>

                    <TouchableOpacity

                        activeOpacity={0.2}
                        onPress={handleCopyCode}
                    >
                        <Ionicons name="copy" color={argonTheme.COLORS.ERROR} size={19}></Ionicons>
                    </TouchableOpacity>

                </View>


            </View>
            {
                memberGroupDatas && memberGroupDatas.length > 0 ? (
                    <View>
                        <View className="mx-1">
                            <Text className="font-bold">Danh sách thành viên: </Text>
                        </View>

                        <View style={styles.tableDiscountHeader}>
                            <View style={{ width: responsiveWidth(55) }}>
                                <Text style={styles.tableDisHeaderTxt}>Họ tên</Text>
                            </View>

                            <View style={{ width: responsiveWidth(35) }}>
                                <Text style={styles.tableDisHeaderTxt} >Số điện thoại</Text>
                            </View>
                        </View>

                        <View>

                            <FlatList
                                data={memberGroupDatas}
                                showsVerticalScrollIndicator={false}
                                contentContainerStyle={{ paddingBottom: 20 }}
                                onEndReachedThreshold={0.5}
                                renderItem={({ item }) => <MememberGroupRow item={item} />}
                            />
                        </View>
                    </View>
                ) : (null)
            }



        </View>
    );
};
export default CollabGroupDetailScreen;

const styles = StyleSheet.create({

    tableDiscountHeader: {
        backgroundColor: argonTheme.COLORS.ERROR,
        margin: 2,
        padding: 5,
        flexDirection: "row",
        borderRadius: 5
    },
    tableDiscountRow: {
        backgroundColor: "#525453",
        margin: 2,
        padding: 5,
        flexDirection: "row",
        borderRadius: 5
    },
    tableDisHeaderTxt: {
        color: "white",
        fontWeight: "bold",
    },
    tableDisRowTxt: {
        color: "white",
    },
    input: {
        color: '#333',
        borderWidth: 1,
        borderColor: 'black',
        padding: 4,
    },
    button: {

        backgroundColor: 'green',
        borderWidth: 2,
        marginLeft: 'auto',
        height: 40,
    }
    ,
    userRow: {
        borderRadius: 5,
        backgroundColor: "black",
        flexDirection: "row",
        borderColor: 'black',
        padding: 5,
        margin: 3,
        shadowColor: 'rgba(0, 0, 0, 0.5)',
        shadowOffset: {
            width: 0,
            height: 2,
        },
        shadowOpacity: 0.8,
        shadowRadius: 2,
        elevation: 2, // Chỉ áp dụng cho Android
    },
    headerContainer: {
        borderRadius: 5,
        backgroundColor: 'white',
        borderColor: 'black',
        padding: 5,
        margin: 3,
        shadowColor: 'rgba(0, 0, 0, 0.5)',
        shadowOffset: {
            width: 0,
            height: 2,
        },
        shadowOpacity: 0.8,
        shadowRadius: 2,
        elevation: 2, // Chỉ áp dụng cho Android
    }
});