import React from 'react';
import { TouchableOpacity, ScrollView, View, TextInput, StyleSheet, SafeAreaView, StatusBar } from 'react-native';
import { AppConst } from '../constants/AppConst';
import Ionicons from 'react-native-vector-icons/Ionicons';
import { argonTheme } from '../constants';
import {
    responsiveScreenHeight,
    responsiveScreenWidth,
    responsiveScreenFontSize,
    responsiveFontSize
} from "react-native-responsive-dimensions";
import SimNetWorkAtCategory from '../customComponents/SimNetWorkAtCategory';
import SimAsPricesAtCategory from '../customComponents/SimAsPricesAtCategory';
import SpecialSimAtCategory from '../customComponents/SpecialSimAtCategory';


const SimCategoryScreen = ({ navigation,route }) => {
    const handleSearchtFocus = () => {
        
        navigation.navigate(AppConst.ScreenConst.SEARCH_SCREEN, { screenParam: AppConst.SearchFrameConst.IS_HOMESEARCH });

    }

    const handleExit = () => {
        navigation.navigate(AppConst.StackConst.BOTTOM_STACK, {
            screen: AppConst.BottomScreenConst.HOME_BOTTOM_SCREEN,
            params: { screen: AppConst.ScreenConst.HOME_SCREEN },
          });

    }

    const SearchButton = () => {
        return (
            <TouchableOpacity className="flex-1" onPress={() => { handleSearchtFocus() }} activeOpacity={.9}>
                <View className="flex-row flex-1 items-center rounded-full bg-white mx-1">
                    <View className="bg-transparent rounded-full m-3">
                        <Ionicons name="search-outline" color="black" size={responsiveFontSize(2.5)}></Ionicons>
                    </View>
                    <TextInput
                        placeholder='Tìm Kiếm SIM'
                        placeholderTextColor={'gray'}
                        className="text-base mb-1 pl-2"
                        returnKeyType="search"
                        editable={false}
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
                {/* <Text
                    style={{ fontSize: 20 }}
                >
                    Thoát
                </Text> */}
                <Ionicons name="chevron-back-outline" color="black" size={26}></Ionicons>
            </TouchableOpacity>
        );
    }
    const HomeHeader = () => {
        return (
            <View className="flex-row justify-center items-center p-2" style={{ position: 'absolute', zIndex: 1000, marginTop: StatusBar.currentHeight }} backgroundColor={argonTheme.COLORS.ERROR}>
                <ExitButton />
                <SearchButton />
            </View>
        );
    }

    const SimCateGory = () => {
        return (
 
                <ScrollView>
                    <View style={{marginTop: StatusBar.currentHeight + responsiveScreenHeight(10)}}>
                        <SimNetWorkAtCategory navi={navigation} route={route} />
                        <SimAsPricesAtCategory navi={navigation} route={route} />
                        <SpecialSimAtCategory navi={navigation} route={route} />
                    </View>
                </ScrollView>
            
        );
    }

    return (

        <View>
            <SafeAreaView>
                <StatusBar translucent backgroundColor={argonTheme.COLORS.ERROR} />

                {/* Header */}
                <HomeHeader />
                <SimCateGory />
            </SafeAreaView>
        </View>



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
export default SimCategoryScreen;