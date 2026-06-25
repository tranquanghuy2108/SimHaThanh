import { React} from 'react'
import {  View, Text } from "react-native";


const TitleCategory = (prop) =>{
    return(
        <View style={styles.flashContainer} className = "flex-row">
            <View style={styles.flashLine} />
            <Text style={styles.flashText}>{prop.title}</Text>
        </View>
    );
}
export default TitleCategory;

const styles = {
    flashContainer: {
        flexDirection: 'row',
        alignItems: 'center',
    },
    flashLine: {
        backgroundColor: "#e16921",
        width: 5,
        height: 17,
        marginRight: 5,
    },
    flashText: {
        fontSize: 15,
        fontWeight: 'bold',
        color: "#c60600"
    },
};