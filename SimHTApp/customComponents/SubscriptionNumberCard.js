
import React, { useEffect, useState } from "react";
import { TouchableOpacity, View,Image,Text } from "react-native";


const SubscriptionNumberCard = (prop) => {
    const [isTick, SetTickState] = useState(false);

    useEffect(()=>{
        if(prop.isActiveFrame){
            SetTickState(true);
        }
        else{
            SetTickState(false);
        }
    },[])
    useEffect(()=>{
        if(prop.resetFrame){
            SetTickState(false);
        }
        
    },[prop.resetFrame]);

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
                        prop.setButtonIndex(prop.type);
                    }
                }
            >
                <Text style={{fontSize:12}}> {prop.network.name}</Text>
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
        height: 28,
        width: 100
        ,
        elevation: 5,
    },
};
export default SubscriptionNumberCard;