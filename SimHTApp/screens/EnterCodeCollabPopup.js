import React, { useContext, useState } from 'react';
import { View, Text, TouchableOpacity, StyleSheet, TextInput, ToastAndroid } from 'react-native';
import { responsiveFontSize, responsiveHeight, responsiveScreenHeight, responsiveScreenWidth } from 'react-native-responsive-dimensions';
import { BottomTabContext } from '../context/BottomTabContext';
import { CollaboratorContext } from '../context/CollaboratorContext';
import { argonTheme } from '../constants';
import Ionicons from 'react-native-vector-icons/Ionicons';

const EnterCodeCollabPopup = ({ onClose }) => {
    const { toggleEnterCodeCollabPopUp } = useContext(BottomTabContext);
    const { memberRequestDatas, myGroupOwnDatas, } = useContext(CollaboratorContext); //Datas
    const { RequestJoinGroup, GetMemberRequestJoin, ApproveRequestJoinGroup, GetMyGroupOwn, GetMembersInGroup, } = useContext(CollaboratorContext); //Methods
    const [activeButton, setActiveButton] = useState('collabList');




    const [codeJoin, SetCodeJoinState] = useState("");

    const SetCodeJoinChange = (code) => {
        SetCodeJoinState(code);
    }
    const onRequestJoin = () => {
        if (codeJoin != "") {
            RequestJoinGroup(codeJoin);
            toggleEnterCodeCollabPopUp();
        }
        else {
            ToastAndroid.showWithGravity(
                'Vui Lòng Kiểm Tra Mã Yêu Cầu!',
                ToastAndroid.SHORT,
                ToastAndroid.BOTTOM,
            );
        }


    }
    return (
        <View style={styles.container}>
            <View style={styles.modalContainer}>


                <View style={styles.closeBtn}>
                    <TouchableOpacity
                        onPress={() => {
                            toggleEnterCodeCollabPopUp()
                        }}
                    >
                        <Ionicons name="close-outline" color="black" size={responsiveFontSize(2.2)}></Ionicons>
                    </TouchableOpacity>

                </View>

                {/* Header */}
                <View>

                </View>
                {/* Content */}



                <View style={{width:"100%"}}>
                    <View style={{marginBottom:5}}>
                        <Text style={{ textAlign: 'center', fontWeight: "bold" }}>Nhập mã nhóm CTV để tham gia</Text>
                    </View>
                    <View>
                        <View style={styles.inputContainer}>
                            <TextInput
                                style={styles.input}
                                placeholder="Mã nhóm CTV..."
                                placeholderTextColor="#888"
                                onChangeText={SetCodeJoinChange}

                            />
                            <TouchableOpacity style={styles.button}

                                activeOpacity={0.8}
                                onPress={() => {
                                    onRequestJoin();

                                }
                                }
                            >
                                <Text className="color-white">Gửi Yêu Cầu</Text>
                            </TouchableOpacity>
                        </View>
                    </View>
                </View>

            </View>


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
    btnPopup: {
        height: responsiveHeight(5),
        marginBottom: 5
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

export default EnterCodeCollabPopup;