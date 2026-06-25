import React, { useContext } from 'react';
import { View, Text, TouchableOpacity, StyleSheet } from 'react-native';
import { responsiveFontSize, responsiveHeight, responsiveScreenHeight, responsiveScreenWidth, responsiveWidth } from 'react-native-responsive-dimensions';
import { BottomTabContext } from '../context/BottomTabContext';
import { CollaboratorContext } from '../context/CollaboratorContext';
import Ionicons from 'react-native-vector-icons/Ionicons';

const CollaboratorPopup = ({ onClose }) => {
    const { toggleCollabPopUp, toggleEnterCodeCollabPopUp, toggleCreateCollabPopUp, } = useContext(BottomTabContext);
    const { myGroupOwnDatas, groupHadJoinDatas } = useContext(CollaboratorContext);

    return (
        <View style={styles.container}>
            <View style={styles.modalContainer}>
                <View style={styles.closeBtn}>
                    <TouchableOpacity
                        onPress={() => {
                            toggleCollabPopUp()
                        }}
                    >
                        <Ionicons name="close-outline" color="black" size={responsiveFontSize(2.2)}></Ionicons>
                    </TouchableOpacity>

                </View>

                {/* Header */}
                <View>

                </View>
                {/* Content */}
                <View style={{ marginBottom:25 }}>
                    <Text style={{ textAlign: "justify",fontWeight:"500"}}>Bạn muốn đăng ký đại lý để bán sim hay tham gia nhóm cộng tác viên của đại lý khác?</Text>
                </View>

                {/* Footer */}
                <View style={styles.btnPopupContainer}>
                    <View style={styles.btnPopup}>


                        <TouchableOpacity
                            onPress={
                                () => {
                                    toggleCollabPopUp();
                                    toggleCreateCollabPopUp();
                                }


                            }
                            style={{ backgroundColor: '#0061b0' }}
                            className="items-center justify-center flex-1 rounded p-2 mx-1"
                        >
                            <Text className="text-white" style={{fontWeight:"500"}}>
                                Đăng ký đại lý
                            </Text>
                        </TouchableOpacity>
                    </View>

                    <View style={styles.btnPopup}>
                        <TouchableOpacity
                            onPress={
                                () => {
                                    toggleCollabPopUp()
                                    toggleEnterCodeCollabPopUp();
                                }


                            }
                            style={{ backgroundColor: '#ff6b00' }} className="items-center justify-center rounded p-2 flex-1 mx-1">
                            <Text className="text-white" style={{fontWeight:"500"}}>
                                Đăng ký CTV
                            </Text>
                        </TouchableOpacity>
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
        padding: 30,
        right: 0,
        left: 0,
        height: responsiveHeight(100),
        backgroundColor: 'rgba(0, 0, 0, 0.2)',
        zIndex: 1111111,

    },
    modalContainer: {
        borderRadius: 10,
        width: "100%",
        padding: 20,
        paddingTop:20,
        paddingBottom:20,
        backgroundColor: "white",
        borderWidth: 1,
    },
    btnPopupContainer:{
        marginLeft:responsiveWidth(10),
        marginRight:responsiveWidth(10),
    },
    btnPopup: {
        height: responsiveHeight(5),
         marginBottom: 8
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

export default CollaboratorPopup;