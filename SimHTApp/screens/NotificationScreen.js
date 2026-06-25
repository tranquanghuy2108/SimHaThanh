import React, { useContext, } from 'react';
import { TouchableOpacity, Text, Image, View, StyleSheet, SafeAreaView, FlatList, Alert, StatusBar } from 'react-native';
import { AppConst } from '../constants/AppConst';
import Ionicons from 'react-native-vector-icons/Ionicons';
import { NotificationMailContext } from '../context/NotificationMailContext';

import { argonTheme } from '../constants';
import {
    responsiveScreenHeight,
    responsiveScreenWidth,
    responsiveScreenFontSize,
    responsiveFontSize,
    responsiveHeight,
    responsiveWidth
} from "react-native-responsive-dimensions";


const TruncateText = (originalText) => {
    if(originalText != "" && originalText!=null){
        const truncatedText = originalText.length > 28
        ? originalText.substring(0, 30) + "..."
        : originalText;
        return truncatedText;
    }
    else{
        return "";
    }

}
const NotificationScreen = (props) => {


    const { ReadNotification, } = useContext(NotificationMailContext);
    const { notificationDatas } = useContext(NotificationMailContext);
    const ConfirmReadAll = (orderID) => {
        Alert.alert(
            'Bạn có muốn đánh dấu đã đọc tất cả thông báo?',
            '',
            [
                { text: 'Hủy', },
                { text: 'Đồng ý', onPress: () => ReadNotification(null) }
            ],
            { cancelable: false }
        );
    }
    const NoResultData = () => {
        return (
            <View className="items-center mt-5">
                <Text className="font-bold">
                    Không có thông báo!
                </Text>
            </View>


        )
    }
    const ExitButton = () => {
        return (
            // Nút Thoát
            <TouchableOpacity className="p-1 rounded-full bg-white mx-1 "
                onPress={() => {
                    if (!props.isDrawer) {
                        props.navigation.goBack();
                    }
                    else {
                        props.navigation.closeDrawer();
                    }
                }}>

                <Ionicons name="chevron-back-outline" color="black" size={26}></Ionicons>
            </TouchableOpacity>
        );
    }
    const Title = () => {
        return (
            <View className="flex-1 items-center justify-center">
                <Text style={{textAlign:"center",color: "white", fontWeight: "bold", fontSize: responsiveFontSize(2.5) }}>Thông báo</Text>
            </View>

        );
    }
    const ReadAll = () => {
        return (
            <View>
                {
                    notificationDatas && notificationDatas.length > 0 ?
                        (
                            <TouchableOpacity activeOpacity={.9}
                                style={styles.orderButton}
                                onPress={() => {


                                    ConfirmReadAll();


                                }}
                            >
                                <Text style={{justifyContent:"center"}}>
                                    <Ionicons name="checkmark-outline" color="white" size={responsiveFontSize(2.5)}></Ionicons>
                                    <Text style={{ color: "white", fontWeight: "bold",fontSize:responsiveFontSize(2) }} >
                                        Đọc tất cả
                                    </Text>
                                </Text>

                            </TouchableOpacity>
                        ) : (null)
                }
            </View>
        );
    }

    return (
        <SafeAreaView className="bg-white flex-1">
            <View className="flex-row p-2" style={{ zIndex: 1000, marginTop: StatusBar.currentHeight }} backgroundColor={argonTheme.COLORS.ERROR}>
                <ExitButton />
                <Title />
                <ReadAll />
            </View>

            <View className=" ">
                <View testID="Body" style={{ marginBottom: responsiveScreenHeight(8) }}>
                    {
                        notificationDatas && notificationDatas.length > 0 ? (
                            <FlatList
                                data={notificationDatas}
                                showsVerticalScrollIndicator={false}
                                contentContainerStyle={{ paddingBottom: 20 }}
                                onEndReachedThreshold={0.5}
                                renderItem={({ item }) => <NotificationCard data={item} navi={props.navigation} />}
                            />
                        ) : (
                            <NoResultData />
                        )
                    }


                </View>
            </View>
        </SafeAreaView>
    );
}
const NotificationCard = (prop) => {
    return (
        <TouchableOpacity
            onPress={() => {
                prop.navi.navigate(AppConst.StackConst.NATIVE_STACK, { screen: AppConst.ScreenConst.NOTIFICATION_DETAIL_SCREEN, params: { notificationData: prop.data } });
            }}
        >
            <View className="flex-row border-b border-stone-200 justifty-center items-center bg-white " style={{ marginTop: 1 }}>
                <View className="mx-2 justify-center" testID="left" style={{ width: responsiveWidth(14), height: responsiveHeight(7) }}>
                    <Image source={prop.data.isRead ? require('../assets/imgs/icon_mail_seen.png') : require('../assets/imgs/icon_mail_available.png')} style={{ width: responsiveWidth(13), height: responsiveHeight(6) ,}} resizeMode="contain" />
                </View>
                <View className="" testID="right">
                    <View>
                        <Text className="font-bold" style={{ fontSize: 15 }}>{prop.data.title}</Text>
                    </View>
                    <View>
                        <Text>{TruncateText(prop.data.content)}</Text>
                    </View>
                </View>
            </View>
        </TouchableOpacity>
    );
}
export default NotificationScreen;
const styles = StyleSheet.create({

    orderButton: {
        flexDirection: "row",
        justifyContent: "flex-end",
        borderColor: 'grey',
        padding: 1,
        margin: 5,
        width: "auto"
    },
});