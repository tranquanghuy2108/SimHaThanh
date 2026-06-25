import { React, useEffect, useContext } from 'react';
import {  ScrollView,StyleSheet,  View, StatusBar, Text} from "react-native";
// Argon themed components
import { argonTheme } from "../constants";
import {
    responsiveScreenHeight,
    responsiveScreenWidth,
    responsiveScreenFontSize
} from "react-native-responsive-dimensions";


import { NotificationMailContext } from '../context/NotificationMailContext';

const NotificationDetailScreen = ({ navigation, route }) => {

    const {ReadNotification} = useContext(NotificationMailContext);
    useEffect(() => {
        navigation.setOptions({
            headerTitle: route.params.notificationData.title,
        });
        ReadNotification(route.params.notificationData.id);
    }, []);


    const { notificationData } = route.params;
    return (
        <View style={styles.container}>

            <StatusBar translucent backgroundColor={argonTheme.COLORS.ERROR} />
            <View testID="package_Info" style={styles.packageInfo}>
                <ScrollView style={{}}>
                    <View className="m-2">
                        <Text style={styles.incentivesBodyTxt}>{notificationData.content}</Text>
                    </View>
                </ScrollView>

            </View>
        </View>
    );

}


export default NotificationDetailScreen;

const styles = StyleSheet.create({
    container: {
        flex: 1,
    },
    packageInfo: {
        backgroundColor: "white",
        flex: 1,


    },
    headerInfoOverView: {
        flexDirection: "row",
    },
    headerInfoTxt: {
        textAlign: "center",
        fontWeight: "bold"
    },
    headerInfoItem: {
        flex: 1,
        alignItems: "center"
    },
    incentivesHeaderTxt: {
        textAlign: "center",
        fontWeight: "bold",
        fontSize: responsiveScreenFontSize(2)
    },
    incentivesBodyTxt: {
        textAlign: "center",
        fontSize: responsiveScreenFontSize(2),
        textAlign: "justify",
    },
    headerInfoText: {
        textAlign: "center",
        fontWeight: "bold",
        fontSize: responsiveScreenFontSize(3)
    },
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
    orderSim: {
        margin: 15,
        backgroundColor: 'white',
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
        marginTop: 5
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