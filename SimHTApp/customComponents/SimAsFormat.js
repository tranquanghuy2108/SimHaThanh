
import { React, useContext } from 'react'
import MasonryList from '@react-native-seoul/masonry-list';
import { TouchableOpacity, View, Text } from "react-native";
import TitleCategory from './TitleCategory';
import { HomeContext } from '../context/HomeContext';
import { AppConst } from '../constants/AppConst';
import { SearchContext } from '../context/SearchContext';


import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
} from "react-native-responsive-dimensions";


const SimAsFormat = (props) => {
    const fakeSpecialSimDatas = [
        {
            "id": 38,
            "name": "Tiến đơn 3",
            "format": "ABC",
            "description": "*012,*123,*234,*345,*456,*567,*678,*789"
        },
        {
            "id": 39,
            "name": "Tiến giữa",
            "format": "123.xxx",
            "description": "*012*,*123*,*234*,*345*,*456*,*567*,*678*,*789*"
        },
        {
            "id": 40,
            "name": "Sim số đẹp",
            "format": "AB.CB.DB",
            "description": ""
        },
        {
            "id": 45,
            "name": "Lộc phát",
            "format": "68",
            "description": "*68"
        },
        {
            "id": 46,
            "name": "Phát lộc",
            "format": "86",
            "description": "*86"
        },
        {
            "id": 47,
            "name": "Cửu cửu",
            "format": "99",
            "description": "*99"
        },
        {
            "id": 48,
            "name": "Phát phát",
            "format": "88",
            "description": "*88"
        },
        {
            "id": 50,
            "name": "Lộc lộc",
            "format": "66",
            "description": "*66"
        },
    ];

    const { simTypeDatas } = useContext(HomeContext);
    const isFakeData = props.fake;

    return (
        <View className="mx-" >
            <View className="bg-white px-2 py-1">
                <TitleCategory title="SIM THEO ĐỊNH DẠNG" />
            </View>
            <View style={{ flex: 1 }} className="px-1">
                {
                    isFakeData == true ?
                        (
                            fakeSpecialSimDatas && (
                                <MasonryList
                                    data={fakeSpecialSimDatas}
                                    numColumns={3}
                                    renderItem={({ item }) => (
                                        <SimFormatCard pathProp={props.navi} itemData={item} fakeData={props.fake} />
                                    )}
                                    columnWrapperStyle={{ justifyContent: 'space-between' }}
                                    contentContainerStyle={{ padding: 3 }}
                                />
                            )

                        ) :
                        (
                            simTypeDatas && (
                                <MasonryList
                                    data={simTypeDatas}
                                    numColumns={3}
                                    renderItem={({ item }) => (
                                        <SimFormatCard pathProp={props.navi} itemData={item} fakeData={props.fake} />
                                    )}
                                    columnWrapperStyle={{ justifyContent: 'space-between' }}
                                    contentContainerStyle={{ padding: 3 }}
                                />
                            )
                        )
                }


            </View>
        </View>



    );
}

export default SimAsFormat;

const SimFormatCard = (prop) => {

    const { search } = useContext(SearchContext);
    return (
        <TouchableOpacity className="p-2 bg-slate-100 rounded-xl justify-center items-items" style={styles.card}
            onPress={
                () => {
                    search(null, null, null, prop.itemData.id);
                    prop.pathProp.navigate(AppConst.ScreenConst.SEARCH_SCREEN, { screenParam: AppConst.SearchFrameConst.IS_RESULT });
                }
            }
        >
            <Text
                className="font-bold text-center"
                style={{ fontSize: responsiveFontSize(2), color: '#1575b6' }}
            >
                {prop.itemData.format}
            </Text>

        </TouchableOpacity>
    )
}
const styles = {
    card: {
        backgroundColor: 'white',
        shadowColor: 'black',
        shadowOffset: { width: 0, height: 2 },
        shadowOpacity: 1,
        shadowRadius: 8,
        margin: 5,
        height: responsiveHeight(5),
        width: responsiveWidth(30),
        elevation: 5,
    },
    price: {
        textDecorationLine: 'line-through', color: 'red'
    },
    promotionPrice: {
        color: 'red', fontWeight: 'bold'
    },
};
