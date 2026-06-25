import React, {useContext, } from "react";
import { TouchableOpacity, View,Image } from "react-native";
import TitleCategory from "./TitleCategory";
import MasonryList from '@react-native-seoul/masonry-list';
import { AppConst } from '../constants/AppConst';
import { SearchContext } from '../context/SearchContext';
import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
  } from "react-native-responsive-dimensions";

const netWorkNames = [
    { name: 'Viettel', id: 1, image: require('../assets/imgs/icon_viettel.png') },
    { name: 'Vinaphone', id: 2, image: require('../assets/imgs/icon_vinaphone.png') },
    { name: 'Mobiphone', id: 3, image: require('../assets/imgs/icon_mobifone.png') },
    { name: 'VietNamobile', id: 4, image: require('../assets/imgs/icon_vietnamobile.png') },
    { name: 'Gmobile', id: 5, image: require('../assets/imgs/icon_gMobile.png') },
    { name: 'iTel', id: 6, image: require('../assets/imgs/icon_itel.png') },
];

const SimNetWorkAtCategory = (props) => {
    return (
        <View className="">
            <View className="bg-white px-2 py-1">
                <TitleCategory title="SIM THEO MẠNG" />
            </View>

            <View style={{ flex: 1 }} className="px-1 ">
                {
                    netWorkNames && (
                        <MasonryList
                            data={netWorkNames}
                            numColumns={3}
                            renderItem={({ item }) => (

                                <SimNetWorkCard pathProp={props.navi} routeProp={props.route} network={item} />
                            )}
                            columnWrapperStyle={{ justifyContent: 'space-between' }}
                            contentContainerStyle={{ padding: 2 }}
                        />
                    )
                }

            </View>


        </View>
    );
}
const SimNetWorkCard = (prop) => {
    const { search } = useContext(SearchContext);
    return (
        <View >
            <TouchableOpacity style={styles.card} className="bg-white rounded-xl mx-1 justify-center items-center"
                onPress={
                    () => {
                        search(null, null, [prop.network.id], null);

                        const currentIndex = prop.routeProp.state?.index || 0; // Lấy chỉ số của màn hình hiện tại
                        prop.pathProp.reset({
                            index: currentIndex,
                            routes: [
                                {
                                    name: AppConst.ScreenConst.SEARCH_SCREEN, // Tên của stack
                                    params: {
                                        screenParam:AppConst.SearchFrameConst.IS_RESULT
                                    },
                                },
                            ],
                        });
                    }
                }
            >
                <Image style={{ height: responsiveHeight(4), width: responsiveWidth(20), resizeMode: 'contain' }} source={prop.network.image} />
              
            </TouchableOpacity>
        </View>
    );
}
export default SimNetWorkAtCategory;

const styles = {
    card: {
        backgroundColor: 'white',
        shadowColor: 'black',
        shadowOffset: { width: 1, height: 1 },
        shadowOpacity: 1,
        shadowRadius: 8,
        margin: 5,
        height: responsiveHeight(5),
        width: responsiveWidth(30)
        ,
        elevation: 5,
    },
};