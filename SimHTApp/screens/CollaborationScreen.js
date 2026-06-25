import React, { useState, useContext, useEffect } from 'react';
import { TouchableOpacity, Text, View, TextInput, StyleSheet, SafeAreaView, ToastAndroid } from 'react-native';
import { AppConst } from '../constants/AppConst';
import { argonTheme } from '../constants';
import { CollaboratorContext } from '../context/CollaboratorContext';
import { FlatList } from 'react-native-gesture-handler';
import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
} from "react-native-responsive-dimensions";

const CollaborationScreen = ({ navigation }) => {
    const { memberRequestDatas, myGroupOwnDatas, groupHadJoinDatas } = useContext(CollaboratorContext); //Datas
    const { RequestJoinGroup, GetMemberRequestJoin, ApproveRequestJoinGroup, GetMyGroupOwn, GetMembersInGroup, } = useContext(CollaboratorContext); //Methods
    const [activeButton, setActiveButton] = useState('collabList');


    const handleButtonPress = (buttonName) => {
        setActiveButton(buttonName);

    };
    useEffect(() => {
        handleButtonPress('collabGroup');
        GetMyGroupOwn();
    }, []);

    const SendJoinRequestBtn = () => {

        const [codeJoin, SetCodeJoinState] = useState("");

        const SetCodeJoinChange = (code) => {
            SetCodeJoinState(code);
        }
        const onRequestJoin = () => {
            if (codeJoin != "") {
                RequestJoinGroup(codeJoin);
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
            <View>
                <View style={styles.container}>
                    <TextInput
                        style={styles.input}
                        placeholder="Mã nhóm CTV..."
                        placeholderTextColor="#888"
                        onChangeText={SetCodeJoinChange}
                    />
                    <TouchableOpacity style={styles.button}

                        activeOpacity={0.8}
                        onPress={onRequestJoin}
                    >
                        <Text className="color-white">Gửi Yêu Cầu</Text>
                    </TouchableOpacity>
                </View>
            </View>
        );
    }

    const Header = () => {
        return (
            <View className="mx-2 my-5">
                <View>
                    <Text>Nhập mã nhóm CTV để tham gia</Text>
                </View>
                <SendJoinRequestBtn />
            </View>
        );
    }

    const Body = () => {
        return (
            <View>
                <CollaborationHeader />
                <CollaborationBody />
            </View>

        );
    }
    const CollaborationHeader = () => {
        return (
            <View className="flex-row bg-white justify-center items-center border-b border-stone-300">
                {/* <CollaboratorList /> */}
                <CollabGroup />
                <PendingAprove />
            </View>
        );
    }
    const CollaborationBody = () => {
        return (
            <>
                {
                    activeButton == 'collabList' ? (
                        <CollabListContent />
                    ) : (null)
                }

                {
                    activeButton == 'collabGroup' ? (
                        <CollabGroupContent />
                    ) : (null)
                }

                {
                    activeButton == 'pending' ? (
                        <PendingContent />
                    ) : (null)
                }

            </>

        );
    }

    const PendingAprove = () => {
        return (
            <TouchableOpacity
                style={[styles2.button, activeButton === 'pending' && styles2.activeButton]}
                className="flex-1 ml-7"
                onPress={() => {

                    handleButtonPress('pending');
                    GetMemberRequestJoin();
                }}
            >
                <Text style={[styles2.buttonText, activeButton === 'pending' && styles2.activeText]}>Chờ duyệt</Text>
            </TouchableOpacity>
        );
    }
    const CollabGroup = () => {

        return (
            <TouchableOpacity
                style={[styles2.button, activeButton === 'collabGroup' && styles2.activeButton]}
                className="flex-1 ml-7"
                onPress={() => {
                    handleButtonPress('collabGroup');
                    GetMyGroupOwn();
                }}
            >
                <Text style={[styles2.buttonText, activeButton === 'collabGroup' && styles2.activeText]}>Nhóm CTV</Text>
            </TouchableOpacity>
        );
    }

    const SearchCollaboratorBtn = () => {
        return (
            <View>
                <View style={styles.container}>
                    <TextInput
                        style={styles.input}
                        placeholder="Tìm CTV theo số điện thoại"
                        placeholderTextColor="#888"
                    />
                    <TouchableOpacity style={styles.button}>
                        <Text className="color-white">Tìm</Text>
                    </TouchableOpacity>
                </View>
            </View>
        );
    }

    const [isMaleChecked, setIsMaleChecked] = useState(false);

    const handleMaleCheckboxPress = () => {
        setIsMaleChecked(!isMaleChecked);
    };
    const maleCheckboxColor = isMaleChecked ? '#1183d2' : 'transparent';

    const CollabListContent = () => {
        return (
            <View className="mx-2 my-2">
                <View >
                    <SearchCollaboratorBtn />
                </View>
                <View testID="header" className="flex-row justify-center items-center">
                    <TouchableOpacity onPress={handleMaleCheckboxPress} className="items-start flex-1">
                        <View style={styles3.checkboxContainer}>
                            <View style={styles3.checkboxWrapper}>
                                {isMaleChecked && <View style={[styles3.checkbox, { backgroundColor: maleCheckboxColor }]} />}
                            </View>
                        </View>
                    </TouchableOpacity>
                    <View className="flex-1">
                        <Text className="text-center">Họ tên</Text>
                    </View>
                    <View className="flex-1">
                        <Text className="text-center">SĐT</Text>
                    </View>
                    <View className="flex-1">
                        <Text className="text-center">Nhóm CTV</Text>
                    </View>


                </View>
                <View testID="body">

                </View>
            </View>

        );
    }

    const CollabGroupContent = () => {
        const GroupRow = ({ item }) => {
            const OnGroupDetail = () => {

                navigation.navigate(AppConst.ScreenConst.COLLAB_GROUP_SCREEN, { item: item });

            }
            return (


                <View style={styles.tableDiscountRow}>
                    <View style={{ width: responsiveWidth(60) }}>
                        <Text style={styles.tableDisRowTxt}>{item.name}</Text>
                    </View>







                    <View style={{ width: responsiveWidth(30) }}>

                        <TouchableOpacity


                            onPress={() => {

                                OnGroupDetail()
                            }}
                        >

                            <Text style={styles.tableDisRowUnderLineTxt} >Xem chi tiết</Text>

                        </TouchableOpacity>



                    </View>
                </View>


            )
        }
        return (
            <View className="mx-2 my-2">
                {
                    myGroupOwnDatas && myGroupOwnDatas.length > 0 ? (
                        <View style={styles.tableDiscountHeader}>
                            <View style={{ width: responsiveWidth(60) }}>
                                <Text style={styles.tableDisHeaderTxt}>Tên nhóm</Text>
                            </View>



                            <View style={{ width: responsiveWidth(30) }}>
                                <Text style={styles.tableDisHeaderTxt} >Thao tác</Text>
                            </View>
                        </View>
                    ) : (null)
                }




                <View testID="body">
                    {

                        myGroupOwnDatas && myGroupOwnDatas.length > 0 ? (
                            <FlatList
                                data={myGroupOwnDatas}
                                showsVerticalScrollIndicator={false}
                                contentContainerStyle={{ paddingBottom: 20 }}
                                // keyExtractor={(data) => data.id}
                                onEndReachedThreshold={0.5}
                                // onEndReached={hasMoreToLoad ? handleLoadMore : null}
                                renderItem={({ item }) => <GroupRow item={item} />}
                            />
                        ) : (
                            <View className="items-center mt-5">
                                <Text className="font-bold">
                                    Nhóm CTV chưa được tạo!
                                </Text>
                            </View>
                        )
                    }

                </View>
            </View>

        );
    }
    const PendingContent = () => {
        const RequestRow = ({ item }) => {
            const OnApprove = () => {
                ApproveRequestJoinGroup(item.requesId);
            }
            return (
                <View style={styles.tableDiscountRow}>
                    <View style={{ width: responsiveWidth(40) }}>
                        <Text style={styles.tableDisRowTxt}>{item.memberName}</Text>
                    </View>
                    <View style={{ width: responsiveWidth(35) }}>
                        <Text style={styles.tableDisRowTxt}>{item.memberPhoneNumber}</Text>
                    </View>
                    <View style={{ width: responsiveWidth(20) }}>

                        <TouchableOpacity


                            onPress={() => {
                                OnApprove()
                            }}
                        >

                            <Text style={styles.tableDisRowUnderLineTxt} >Duyệt</Text>

                        </TouchableOpacity>



                    </View>
                </View>
            )
        }
        return (
            <View className="my-2">

                {
                    memberRequestDatas && memberRequestDatas.length > 0 ? (
                        <View style={styles.tableDiscountHeader}>
                            <View style={{ width: responsiveWidth(40) }}>
                                <Text style={styles.tableDisHeaderTxt}>Họ Tên</Text>
                            </View>
                            <View style={{ width: responsiveWidth(35) }}>
                                <Text style={styles.tableDisHeaderTxt}>Số điện thoại</Text>
                            </View>

                            <View style={{ width: responsiveWidth(20) }}>
                                <Text style={styles.tableDisHeaderTxt} >Thao tác</Text>
                            </View>
                        </View>
                    ) : (
                        <View className="items-center mt-5">
                            <Text className="font-bold">
                                Không có yêu cầu tham gia nào!
                            </Text>
                        </View>
                    )
                }


                {
                    memberRequestDatas && memberRequestDatas.length > 0 ? (

                        <FlatList
                            // keyboardShouldPersistTaps={'always'}
                            // onScroll={handleScroll}
                            data={memberRequestDatas}
                            showsVerticalScrollIndicator={false}
                            contentContainerStyle={{ paddingBottom: 20 }}
                            // keyExtractor={(data) => data.id}
                            onEndReachedThreshold={0.5}
                            // onEndReached={hasMoreToLoad ? handleLoadMore : null}
                            renderItem={({ item }) => <RequestRow item={item} />}
                        />

                    ) : (null)
                }

            </View>
        );
    }

    const CreateCollabGroup = () => {
        const onCreateGroup = () => {
            navigation.navigate(AppConst.ScreenConst.CREATE_COLLABORATION_SCREEN);
        }
        return (
            <View style={styles4.container}>
                <TouchableOpacity
                    style={styles4.button}
                    onPress={onCreateGroup}
                >
                    <Text style={styles4.buttonTxt}>Tạo nhóm</Text>
                </TouchableOpacity>
            </View>
        );
    }
    return (
        <SafeAreaView>
            <View className=" ">
                {/* onPress={() => { navigation.navigate(AppConst.ScreenConst.HOME_SCREEN) }} */}
                <View testID="Body" className="" style={{ height: '100%' }}>
                    {
                        myGroupOwnDatas.length == 0 ? (
                            <CreateCollabGroup />
                        ) :
                            (null)

                    }
                    <Body />
                </View>
            </View>
        </SafeAreaView>
    );
}

export default CollaborationScreen;
const styles = StyleSheet.create({
    tableDiscountHeader: {
        backgroundColor: argonTheme.COLORS.ERROR,
        margin: 2,
        padding: 5,
        flexDirection: "row",
        borderRadius: 5
    },
    tableDiscountRow: {
        backgroundColor: "#525453",
        margin: 2,
        padding: 5,
        flexDirection: "row",
        borderRadius: 5
    },


    tableDisHeaderTxt: {
        color: "white",
        fontWeight: "bold",
        fontSize: responsiveFontSize(2),
    },
    tableDisRowTxt: {
        color: "white",
        fontSize: responsiveFontSize(1.8),
    },
    tableDisRowUnderLineTxt: {
        color: "white",
        textDecorationLine: 'underline',
        fontSize: responsiveFontSize(1.8),
    },
    container: {
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
});
const styles2 = StyleSheet.create({
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
        fontSize: responsiveFontSize(2),
        fontWeight: 'bold',
        textAlign: 'center'
    },
    buttonText: {
        fontSize: responsiveFontSize(2),
        fontWeight: 'bold',
        textAlign: 'center'
    },
});
const styles3 = StyleSheet.create({
    rowContainer: {

        justifyContent: 'space-between',
    },
    container: {
        flexDirection: 'row',
        height: 50,
        width: 120,
        borderWidth: 1,
        borderColor: '#ccc',
        borderRadius: 5,
        backgroundColor: 'white',
        shadowColor: 'black',
        shadowOffset: { width: 0, height: 2 },
        shadowOpacity: 1,
        shadowRadius: 8,
        margin: 5,
    },
    checkboxContainer: {
        flexDirection: 'row',
        alignItems: 'center',
        padding: 10,
    },
    checkboxWrapper: {
        width: 20,
        height: 20,
        borderWidth: 1,
        borderColor: '#dddddd',
        backgroundColor: '#dddddd',
        padding: 2,
        marginRight: 10,
        borderRadius: 3,
    },
    checkbox: {
        flex: 1,
        backgroundColor: '#1183d2',
        borderRadius: 3,
    },
    label: {
        fontSize: 16,
    },
});
const styles4 = StyleSheet.create({
    container: {
        position: 'absolute',
        marginTop: responsiveHeight(70),
        right: 10,
        zIndex: 1111,
    },
    button: {
        paddingVertical: 5,
        paddingHorizontal: 10,
        backgroundColor: argonTheme.COLORS.ERROR,
        alignItems: 'center',
        justifyContent: 'center',
        borderRadius: 5,
    },
    buttonTxt: {
        color: 'white'
    }
});


