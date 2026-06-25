import React, { useContext, useState, useEffect } from 'react';
import { View, Text, TouchableOpacity, StyleSheet, TextInput, Linking, KeyboardAvoidingView, ScrollView, ToastAndroid, Image } from 'react-native';
import { responsiveFontSize, responsiveHeight, responsiveScreenHeight, responsiveScreenWidth, responsiveWidth } from 'react-native-responsive-dimensions';
import { BottomTabContext } from '../context/BottomTabContext';
import { CollaboratorContext } from '../context/CollaboratorContext';
import { argonTheme } from '../constants';
import CreateCollaboratorScreen from './CreateCollaboratorScreen';
import { AuthContext } from '../context/AuthContext';
import Ionicons from 'react-native-vector-icons/Ionicons';
import Config from '../constants/Config';
const CreateCollabGroupPopup = ({ onClose }) => {
    const { toggleCreateCollabPopUp } = useContext(BottomTabContext);
    const { RequestJoinGroup, GetMemberRequestJoin, ApproveRequestJoinGroup, GetMembersInGroup, } = useContext(CollaboratorContext); //Methods
    const [activeButton, setActiveButton] = useState('collabList');

    const { CreateGroupCollab, GetMyGroupOwn } = useContext(CollaboratorContext);
    const { myGroupOwnDatas, groupHadJoinDatas } = useContext(CollaboratorContext);

    const [groupName, SetGroupNameState] = useState(null);
    const [groupDescription, SetGroupDescription] = useState(null);
    const [cards, SetCardState] = useState([]);
    const [cardID, SetCardID] = useState(0);

    const { userInfos, spContact, GetSupportContact } = useContext(AuthContext);

    useEffect(() => {
        GetSupportContact();
    }, []);

    const CheckCreate = () => {
        if (CheckNameGroup()) {
            return true;
        } else {
            ToastAndroid.showWithGravity(
                'Vui lòng kiểm tra tên nhóm!',
                ToastAndroid.SHORT,
                ToastAndroid.BOTTOM,
            );
            return false;
        }
    }

    const CheckNameGroup = () => {
        if (groupName != null && groupName != "") {
            return true;
        }
        else {
            return false;
        }
    }

    const onCreateGroup = () => {
        if (CheckCreate()) {
            CreateGroupCollab(groupName, cards, groupDescription);
            toggleCreateCollabPopUp();
        }
    }

    const SetGroupNameChange = (name) => {
        SetGroupNameState(name);
    }



    const SetGroupDescriptionChange = (description) => {
        SetGroupDescription(description);
    }

    const SetPriceFrom = (price, cardID) => {

        const updatedCards = cards.map(card => {
            if (card.id === cardID) {
                return {
                    ...card,
                    priceFrom: parseInt(price)
                };
            }
            return card;
        });

        SetCardState(updatedCards);

    }


    const SetPriceTo = (price, cardID) => {

        const updatedCards = cards.map(card => {
            if (card.id === cardID) {
                return {
                    ...card,
                    priceTo: parseInt(price)
                };
            }
            return card;
        });

        SetCardState(updatedCards);

    }
    const SetDiscountPer = (_discountPer, cardID) => {

        const updatedCards = cards.map(card => {
            if (card.id === cardID) {
                return {
                    ...card,
                    discountPer: parseInt(_discountPer)
                };
            }
            return card;
        });

        SetCardState(updatedCards);

    }




    const onAddDiscountCard = () => {
        SetCardID(cardID + 1);
        const newCard =
        {
            "id": cardID,
            "priceFrom": 0,
            "priceTo": 0,
            "discountPer": 0,
            "description": ""
        }

        SetCardState([...cards, newCard]);
        console.log("Add discountCard");

    }
    const RemoveDiscountCard = (cardID) => {
        const updatedCards = cards.filter(card => card.id !== cardID);
        SetCardState(updatedCards);
    }
    const handlePress = (zaloNumber) => {
        Linking.openURL(`https://zalo.me/${zaloNumber}`);
    };

    return (
        <View style={styles.container}>
            <KeyboardAvoidingView style={styles.keyAvoid} behavior="padding" keyboardVerticalOffset={20}>
                <View style={styles.modalContainer}>

                    <View style={styles.closeBtn}>
                        <TouchableOpacity
                            onPress={() => {
                                toggleCreateCollabPopUp()
                            }}
                        >
                            <Ionicons name="close-outline" color="black" size={responsiveFontSize(2.2)}></Ionicons>
                        </TouchableOpacity>

                    </View>

                    <View style={{ width: "100%" }}>


                        <View>
                            <Text style={{ fontWeight: "bold", textAlign: "center" }}>Quý khách vui lòng liên hệ tổng đài để đăng ký đại lý</Text>
                        </View>


                    </View>

                    <View>
                        {
                            spContact && spContact.length>0 && spContact.filter(x =>x.name=== Config.SP_CONTACT.ZALO).length>0 ? (
                                <TouchableOpacity onPress={() => handlePress(spContact.filter(x =>x.name=== Config.SP_CONTACT.ZALO)[0].phoneNumber)}>
                                    <View className="flex-row items-center my-1">
                                        <View className="justify-center items-center" testID="left" style={{ width: responsiveWidth(7), height: responsiveHeight(3) }}>
                                            <Image source={require('../assets/imgs/icon_zalo.png')} style={{ width: responsiveWidth(4), height: responsiveHeight(3), }} resizeMode="contain" />
                                        </View>
                                        <Text style={{ textAlign: 'center',fontWeight:"bold",color:"#1090ad",fontSize:responsiveFontSize(2)}}>{spContact.filter(x =>x.name=== Config.SP_CONTACT.ZALO)[0].phoneNumber}</Text>
                                    </View>

                                
                                </TouchableOpacity>

                            ) : (null)
                        }
                    </View>

                </View>
            </KeyboardAvoidingView>

        </View>


    );
};


const styles = StyleSheet.create({

    container: {
        flex: 1,
        position: "absolute",
        justifyContent: 'center',
        alignItems: 'center',
        alignContent: "center",
        borderRadius: 10,
        padding: 10,
        right: 0,
        left: 0,
        height: responsiveHeight(100),
        backgroundColor: 'rgba(0, 0, 0, 0.2)',
        zIndex: 1111111,

    },
    modalContainer: {
        height: responsiveHeight(12),
        margin: 50,
        justifyContent: 'center',
        alignItems: 'center',
        alignContent: "center",
        borderRadius: 10,
        width: "100%",
        padding: 10,
        backgroundColor: "white",
        borderWidth: 1,
    },
    keyAvoid: {
        justifyContent: 'center',
        alignItems: 'center',
        alignContent: "center",
        width: "100%",
    },
    inputContainer: {
        flexDirection: 'row',
        borderRadius: 5,
        borderWidth: 1,
        borderColor: '#ccc',
        backgroundColor: 'white',
    },
    input: {
        flex: 1,
        paddingVertical: 8,
        paddingHorizontal: 10,
        color: '#333',
        height: 40,
    },
    button: {
        backgroundColor: argonTheme.COLORS.ERROR,
        borderTopRightRadius: 5,
        borderBottomRightRadius: 5,
        paddingVertical: 8,
        paddingHorizontal: 12,
        marginLeft: 'auto',
        height: 40,
        alignItems: 'flex-end',
    },
    buttonText: {
        color: 'white',
        fontWeight: 'bold',
    },
    closeBtn: {
        position: "absolute",
        backgroundColor: "white",
        right: -5,
        top: -8,
        padding: 2,
        borderWidth: 1,
        borderRadius: 50,
        height: responsiveHeight(3),
        width: responsiveHeight(3),
        justifyContent: "center",
        alignContent: "center",
        alignItems: "center"
    }

});
const styles2 = StyleSheet.create({
    container: {
        padding: 10,
    },
    textHeader: {
        fontWeight: "bold",
    },
    inputDiscount: {
        flex: 1,
        height: 40,
        borderColor: 'white',
        backgroundColor: 'white',
        borderWidth: 1,
        paddingHorizontal: 10,
        borderRadius: 5,
        shadowColor: 'rgba(0, 0, 0, 0.5)',
        shadowOffset: {
            width: 0,
            height: 2,
        },
        shadowOpacity: 0.8,
        shadowRadius: 2,
        elevation: 2,
    },
    input: {
        flex: 0,
        height: 40,
        borderColor: 'white',
        backgroundColor: 'white',
        borderWidth: 1,
        paddingHorizontal: 10,
        borderRadius: 5,
        shadowColor: 'rgba(0, 0, 0, 0.5)',
        shadowOffset: {
            width: 0,
            height: 2,
        },
        shadowOpacity: 0.8,
        shadowRadius: 2,
        elevation: 2,
    },
    button: {
        paddingVertical: 5,
        paddingHorizontal: 10,
        margin: 5,
        width: 100,
        backgroundColor: argonTheme.COLORS.ERROR,
        borderRadius: 5,
        justifyContent: 'center',
        alignContent: "center",
        alignItems: "center"
    },
    addDiscountBtn: {
        width: "auto",
        backgroundColor: argonTheme.COLORS.ERROR,
        borderRadius: 5,
        padding: 5,
        marginTop: 5
    }

});
export default CreateCollabGroupPopup;