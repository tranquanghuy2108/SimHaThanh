
import React, { useEffect, useContext, useState } from "react";
import { TouchableOpacity, View, Image, Text } from "react-native";
import { SimDataContext } from "../context/SimDataContext";

const SimDataCard = (prop) => {
    const [isTick, SetTickState] = useState(false);
    const { resetFrameState, updatedSubscriptionArray } = useContext(SimDataContext)
    useEffect(() => {
        if (prop.resetFrame) {
            SetTickState(false);
        }
    }, [resetFrameState]);

    useEffect(() => {
        if (updatedSubscriptionArray.includes(prop.item.id)) {
            SetTickState(true);
        }
        else {
            SetTickState(false);
        }



    }, [updatedSubscriptionArray])



    return (
        <View  >
            <TouchableOpacity style={styles.card} className="bg-white rounded-xl mx-1 justify-center items-center"
                onPress={
                    () => {
                        if (isTick) {
                            SetTickState(false);
                        }
                        else {
                            SetTickState(true);
                        }
                        prop.setButtonIndex(prop.item.id);
                    }
                }
            >

                <Text style={{ fontSize: 12 }}> {prop.item.name}</Text>
                {isTick === true ? (
                    <Image
                        source={require('../assets/imgs/bg_tick.png')}
                        style={{ position: "absolute", height: '100%', width: '100%' }}
                        resizeMode='contain'
                    />
                ) : null}



            </TouchableOpacity>
        </View>
    );
}


const styles = {
    card: {
        backgroundColor: 'white',
        shadowColor: 'black',
        shadowOffset: { width: 1, height: 1 },
        shadowOpacity: 1,
        shadowRadius: 8,
        margin: 5,
        height: 27,
        width: 93
        ,
        elevation: 5,
    },
};
export default SimDataCard;