
import React, { useContext } from 'react'
import MasonryList from '@react-native-seoul/masonry-list';
import { TouchableOpacity, View, Text } from "react-native";
import TitleCategory from './TitleCategory';
import { AppConst } from '../constants/AppConst';
import { SearchContext } from '../context/SearchContext';
import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
} from "react-native-responsive-dimensions";


const SimAsPrices = (props) => {

    const data = [
        { id: '1', description: '< 500k', _min: 0, _max: 500000 },
        { id: '1', description: '500k-1tr', _min: 500000, _max: 1000000 },
        { id: '1', description: '1-3 triệu', _min: 1000000, _max: 3000000 },
        { id: '1', description: '3-5triệu', _min: 3000000, _max: 5000000 },
        { id: '1', description: '5-10triệu', _min: 5000000, _max: 10000000 },
        { id: '1', description: '10-20triệu', _min: 10000000, _max: 20000000 },
        { id: '1', description: '20-50triệu', _min: 20000000, _max: 50000000 },
        { id: '1', description: '50t-100tr', _min: 50000000, _max: 100000000 },
        { id: '1', description: '100-200tr', _min: 100000000, _max: 200000000 },
        { id: '1', description: '200-500tr', _min: 200000000, _max: 500000000 },
        { id: '1', description: '> 500triệu', _min: 500000000, _max: 10000000000 },
    ];

    return (
        <View className="" >
            <View className="bg-white px-2 py-1">
                <TitleCategory title="SIM THEO GIÁ" />           
            </View>

            <View style={{flex:1}} className="px-1">
               
                <MasonryList
                    data={data}
                    numColumns={3}
                    renderItem={({ item }) => (
                         <SimPriceCard pathProp={props.navi} itemProp={item} />
       
                    )}
                    columnWrapperStyle={{ justifyContent: 'space-between' }}
                    contentContainerStyle={{ padding: 3 }}
                />
            </View>
        </View>

    );
}

export default SimAsPrices;

const SimPriceCard = (prop) => {
    const { search } = useContext(SearchContext);
    return (
        <TouchableOpacity className="p-2 bg-slate-100 rounded-xl justify-center items-items" style={styles.card} onPress={
            () => {
                search(null, { min: prop.itemProp._min, max: prop.itemProp._max}, null, null)
                prop.pathProp.navigate(AppConst.ScreenConst.SEARCH_SCREEN,{screenParam:AppConst.SearchFrameConst.IS_RESULT});
            }
        }>

            <Text
                className="font-bold text-center"
                style={{ fontSize: responsiveFontSize(2),color:'#1575b6'}}
            >
                {prop.itemProp.description}
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
        height:  responsiveHeight(5),
        width:  responsiveWidth(30),
        elevation: 5,
    },
    price: {
        textDecorationLine: 'line-through', color: 'red'
    },
    promotionPrice: {
        color: 'red', fontWeight: 'bold'
    },
};
