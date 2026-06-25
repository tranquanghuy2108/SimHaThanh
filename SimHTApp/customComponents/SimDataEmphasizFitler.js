
import React, { useEffect, useContext, useState } from "react";
import { StyleSheet, TouchableOpacity, View, Text } from "react-native";
import { SimDataContext } from "../context/SimDataContext";
import { Checkbox, } from "galio-framework";
import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
} from "react-native-responsive-dimensions";
import Config from "../constants/Config";

const SimDataEmphasizFitler = (prop) => {

    const { searchFilter, setUpdateSortBy } = useContext(SimDataContext);
    const { sortType, updatedSubscriptionArray, } = useContext(SimDataContext);

    //Filter - SortBy

    useEffect(() => {
        setUpdateSortBy(sortType);

        if (sortType == 0) {
            handleButtonPress('highlight')
        }
        else if (sortType == 1) {
            handleButtonPress('lowPrice')
        }
        else if (sortType == 2) {
            handleButtonPress('highPrice')
        }

    }, [sortType])


    const [activeButton, setActiveButton] = useState(null);
    const handleButtonPress = (buttonName) => {
        setActiveButton(buttonName);
    };
    const handleFilterHighPrice = () => {
        setUpdateSortBy(Config.SEARCH_SIM_SORT_TYPE.HIGH_PRICE);
        searchFilter(updatedSubscriptionArray, Config.SEARCH_SIM_SORT_TYPE.HIGH_PRICE);
    }
    const handleFilterLowPrice = () => {
        setUpdateSortBy(Config.SEARCH_SIM_SORT_TYPE.LOW_PRICE);
        searchFilter(updatedSubscriptionArray, Config.SEARCH_SIM_SORT_TYPE.LOW_PRICE);

    }
    const handleEmphasis = () => {
        setUpdateSortBy(Config.SEARCH_SIM_SORT_TYPE.NORMAL);
        searchFilter(updatedSubscriptionArray, Config.SEARCH_SIM_SORT_TYPE.NORMAL);

    }
    const PriceEmphasis = () => {
        return (
            <TouchableOpacity
                style={[styles.button, activeButton === 'highlight' && styles.activeButton]}
                className="flex-1 ml-7"
                onPress={() => {
                    handleButtonPress('highlight');
                    handleEmphasis();
                }}
            >
                <Text style={[styles.buttonText, activeButton === 'highlight' && styles.activeText]}>Nổi bật</Text>
            </TouchableOpacity>

        );
    }
    const PriceLow = () => {
        return (
            <TouchableOpacity
                style={[styles.button, activeButton === 'lowPrice' && styles.activeButton]}
                className="flex-1"
                onPress={() => {
                    handleButtonPress('lowPrice');
                    handleFilterLowPrice();

                }}
            >
                <Text style={[styles.buttonText, activeButton === 'lowPrice' && styles.activeText]}>Giá thấp</Text>
            </TouchableOpacity>
        );
    }
    const PriceHigh = () => {
        return (
            <TouchableOpacity
                style={[styles.button, activeButton === 'highPrice' && styles.activeButton]}
                onPress={() => {
                    handleButtonPress('highPrice')
                    handleFilterHighPrice();
                }}
                className="flex-1"
            >
                <Text style={[styles.buttonText, activeButton === 'highPrice' && styles.activeText]}>Giá cao</Text>
            </TouchableOpacity>
        );
    }



    return (

        <View className="flex-row justify-center items-center border-b border-stone-300">
            <Checkbox className="mx-3" color="warning" style={{ width: 2, height: 5 }} />
            <PriceEmphasis />
            <PriceLow />
            <PriceHigh />

        </View>
    );

}


const styles = StyleSheet.create({
    filterText: {
        fontSize: responsiveFontSize(2),
    },
    filterArrowDown: {
        fontSize: responsiveFontSize(2),
    },
    card: {
        backgroundColor: 'white',
        shadowColor: 'black',
        shadowOffset: { width: 1, height: 1 },
        shadowOpacity: 1,
        shadowRadius: 8,
        margin: 5,
        height: responsiveHeight(5),
        width: responsiveWidth(30),

        elevation: 5,
    },
    button: {
        padding: 10,
        backgroundColor: 'transparent',
    },
    activeButton: {
        borderBottomWidth: 2,
        borderBottomColor: '#1183d2',
    },
    activeText: {
        color: '#1183d2',
        fontSize: 14,
        fontWeight: 'bold',
        textAlign: 'center'
    },
    buttonText: {
        fontSize: 14,
        fontWeight: 'bold',
        textAlign: 'center'
    },
});
export default SimDataEmphasizFitler;