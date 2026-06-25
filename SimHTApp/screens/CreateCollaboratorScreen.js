
import { useState, useContext } from 'react'
import { View, Text, TouchableOpacity, TextInput, StyleSheet, ToastAndroid } from 'react-native';
import { CollaboratorContext } from '../context/CollaboratorContext';
import { argonTheme } from '../constants';

const CreateCollaboratorScreen = ({ navigation }) => {

    const { CreateGroupCollab, GetMyGroupOwn } = useContext(CollaboratorContext);
    const [groupName, SetGroupNameState] = useState(null);
    const [groupDescription, SetGroupDescription] = useState(null);
    const [cards, SetCardState] = useState([]);
    const [cardID, SetCardID] = useState(0);


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
            navigation.goBack();
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
    return (
        <View style={styles.container}>
            <Text style={styles.textHeader}>Tên Nhóm</Text>
            <TextInput
                style={styles.input}
                autoFocus
                placeholder={'Nhập tên nhóm...'}
                placeholderTextColor={'grey'}
                onChangeText={SetGroupNameChange}
            />
            <Text style={styles.textHeader}>Chiết khấu</Text>

            {
                cards && cards.map(card => {
                    return (
                        <View className="flex-row items-center my-1">
                            <TextInput
                                style={styles.inputDiscount}

                                placeholder={'Giá từ'}
                                value={card.priceFrom}
                                placeholderTextColor={'grey'}
                                onChangeText={(text) => SetPriceFrom(text, card.id)}
                                keyboardType="numeric" // Chỉ cho phép nhập số
                            />
                            <View style={{ alignItems: "center", justifyContent: "center" }}>
                                <Text style={{ textAlign: 'center', justifyContent: "center" }}> - </Text>
                            </View>

                            <TextInput
                                style={styles.inputDiscount}

                                placeholder={'Giá đến'}
                                value={card.priceTo}
                                placeholderTextColor={'grey'}
                                onChangeText={(text) => SetPriceTo(text, card.id)}
                                keyboardType="numeric" // Chỉ cho phép nhập số

                            />
                            <View style={{ alignItems: "center", justifyContent: "center" }}>
                                <Text style={{ textAlign: 'center', justifyContent: "center" }}> </Text>
                            </View>

                            <TextInput
                                style={styles.inputDiscount}
                                placeholder={'%Chiết khấu'}
                                placeholderTextColor={'grey'}
                                keyboardType="numeric" // Chỉ cho phép nhập số
                                value={card.discountPer}
                                onChangeText={(text) => SetDiscountPer(text, card.id)}
                            />

                            <View style={{ alignItems: "center", justifyContent: "center" }}>
                                <Text style={{ textAlign: 'center', justifyContent: "center" }}> </Text>
                            </View>

                            <View style={{ alignItems: "center", justifyContent: "center" }}>
                                <TouchableOpacity
                                    onPress={() => { RemoveDiscountCard(card.id) }}

                                >
                                    <Text style={{ textAlign: 'center', justifyContent: "center", fontWeight: "bold", color: "red" }}>X</Text>
                                </TouchableOpacity>

                            </View>

                        </View>
                    )
                })
            }



            <View
                style={styles.addDiscountBtn}
            >
                <TouchableOpacity
                    activeOpacity={0.8}
                    onPress={onAddDiscountCard}

                >

                    <Text style={{ color: 'white', textAlign: 'center' }}>
                        + Thêm chiết khấu
                    </Text>

                </TouchableOpacity>
            </View>


            <Text style={styles.textHeader}>Miêu tả</Text>
            <TextInput
                style={styles.input}
                autoFocus
                placeholder={'Nhập miêu tả Nhóm...'}
                placeholderTextColor={'grey'}
                onChangeText={SetGroupDescriptionChange}
            />

            <TouchableOpacity
                activeOpacity={0.8}
                onPress={onCreateGroup}
                className="items-center"
            >
                <View
                    style={styles.button}
                >
                    <Text style={{ color: 'white' }}>
                        Tạo
                    </Text>
                </View>
            </TouchableOpacity >


        </View >
    );
};
export default CreateCollaboratorScreen;

const styles = StyleSheet.create({
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