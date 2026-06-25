import React, { useState, useContext, useRef, useEffect } from 'react';
import { TouchableOpacity, ScrollView, Text, Image, View, TextInput, StyleSheet, SafeAreaView, ToastAndroid, StatusBar } from 'react-native';
import DateTimePicker from '@react-native-community/datetimepicker';
import MasonryList from '@react-native-seoul/masonry-list';
import { AppConst } from '../constants/AppConst';
import Ionicons from 'react-native-vector-icons/Ionicons';
import { argonTheme } from '../constants';

import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
} from "react-native-responsive-dimensions";

import { AutionContext } from '../context/AutionContext';


const AutionScreen = (props) => {
    const { currentAuctionData, allAuctionData, myAuctionData } = useContext(AutionContext);
    const { GetAllAuction, GetCurrentAuction, GetAllAuctionPaging, GetMyAuction } = useContext(AutionContext);

    const [activeButton, setActiveButton] = useState('');


    const handleButtonPress = (buttonName) => {
        setActiveButton(buttonName);

    };




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
                <ScrollView horizontal >
                    <Aucting />
                    <AllAuction />
                    <AuctionHistory />
                </ScrollView>
            </View>
        );
    }
    const CollaborationBody = () => {
        return (
            <>
                {
                    activeButton == 'all' ? (
                        <AllAuctionContent />
                    ) : (null)
                }

                {
                    activeButton == 'Aucting' ? (
                        <AuctingContent />
                    ) : (null)
                }

                {
                    activeButton == 'History' ? (
                        <HistoryContent />
                    ) : (null)
                }

            </>

        );
    }
    const AllAuction = () => {
        return (
            <TouchableOpacity
                style={[styles2.button, activeButton === 'all' && styles2.activeButton]}
                className="flex-1 ml-7"
                onPress={() => {

                    handleButtonPress('all');
                    GetAllAuction();
                }}
            >
                <Text style={[styles2.buttonText, activeButton === 'all' && styles2.activeText]}>Tất Cả</Text>
            </TouchableOpacity>
        );
    }
    const Aucting = () => {

        return (
            <TouchableOpacity
                style={[styles2.button, activeButton === 'Aucting' && styles2.activeButton]}
                className="flex-1 ml-7"
                onPress={() => {
                    handleButtonPress('Aucting');
                    GetAllAuctionPaging();
                }}
            >
                <Text style={[styles2.buttonText, activeButton === 'Aucting' && styles2.activeText]}>Đang diễn ra</Text>
            </TouchableOpacity>
        );
    }

    const AuctionHistory = () => {

        return (
            <TouchableOpacity
                style={[styles2.button, activeButton === 'History' && styles2.activeButton]}
                className="flex-1 ml-7"
                onPress={() => {
                    handleButtonPress('History');
                    GetMyAuction();
                }}
            >
                <Text style={[styles2.buttonText, activeButton === 'History' && styles2.activeText]}>Lịch sử</Text>
            </TouchableOpacity>
        );
    }


    const ConvertCurrency = (numberString) => {
        const formattedNumber = parseInt(numberString, 10).toLocaleString('vi-VN', {
            style: 'currency',
            currency: 'VND',
        });
        const convertedNumber = formattedNumber.replace('₫', 'VND');
        return convertedNumber;
    }



    const CheckTimeEnd = (_endTime) => {
        const endTime = new Date(_endTime);
        const currentTime = new Date();

        if (endTime < currentTime) {
            return true; // Trả về false nếu startTime nhỏ hơn thời gian hiện tại
        }
        else {
            return false;
        }
    }
    const CheckTimeBegin = (_startTime) => {
        const startTime = new Date(_startTime);
        const currentTime = new Date();

        if (startTime < currentTime) {
            return true; // Trả về false nếu startTime nhỏ hơn thời gian hiện tại
        }
        else {
            return false;
        }
    }
    const GetDate = (_time) => {
        const startTime = new Date(_time);

        const startDate = startTime.getDate(); // Ngày
        const startMonth = startTime.getMonth() + 1; // Tháng (lưu ý: tháng bắt đầu từ 0 nên cần cộng 1)
        const startYear = startTime.getFullYear(); // Năm

        const startHour = startTime.getHours(); // Giờ
        const startMinute = startTime.getMinutes(); // Phút
        const startSecond = startTime.getSeconds(); // Giây

        const dateObject = {
            date: `${startDate}/${startMonth}/${startYear}`,
            time: `${startHour}:${startMinute}:${startSecond}`

        }
        return dateObject;
    }

    const AuctionCard = ({ data }) => {

        const endTime = new Date(data.endTime);

        const [days, setDays] = useState(0);
        const [hours, setHours] = useState(0);
        const [minutes, setMinutes] = useState(0);
        const [seconds, setSeconds] = useState(0);

        useEffect(() => {
            const calculateCountdown = () => {
                const currentTime = new Date();

                const timeRemaining = endTime - currentTime;

                if (timeRemaining > 0) {
                    const remainingSeconds = Math.floor(timeRemaining / 1000);

                    const remainingDays = Math.floor(remainingSeconds / (60 * 60 * 24));
                    const remainingHours = Math.floor((remainingSeconds % (60 * 60 * 24)) / (60 * 60));
                    const remainingMinutes = Math.floor((remainingSeconds % (60 * 60)) / 60);
                    const remainingSecondsCount = remainingSeconds % 60;

                    setDays(remainingDays);
                    setHours(remainingHours);
                    setMinutes(remainingMinutes);
                    setSeconds(remainingSecondsCount);

                    setTimeout(calculateCountdown, 1000); // Cập nhật mỗi giây
                }
            };

            calculateCountdown();
        }, []);
        return (
            <TouchableOpacity
                onPress={() => {
                    props.navigation.navigate(AppConst.StackConst.NATIVE_STACK, { screen: AppConst.ScreenConst.BIDING, params: { autionDataParam: data } })

                }}
            >
                <View className="" style={styles.card} >
                    {/* header */}
                    <View className="flex-row justify-between rounded-tl rounded-tr" >
                        <View className="justify-center items-start">
                            <Text className="font-bold" style={{ fontSize: responsiveFontSize(2.5) }}>
                                {data.simNumber}
                            </Text>
                        </View>

                        {
                            !CheckTimeBegin(data.startTime) ? (
                                <View className="justify-center  items-center flex-row  rounded px-2"
                                    style={{ backgroundColor: argonTheme.COLORS.ERROR, width: "auto", height: responsiveHeight(4) }}

                                >
                                    <Text className="color-white font-bold">CHƯA BẮT ĐẦU</Text>

                                </View>
                            ) : (

                                !CheckTimeEnd(data.endTime) ? (
                                    <View className="flex-row space-x-1 items-center">
                                        <View className="justify-center  items-center flex-row  rounded px-2"
                                            style={{ backgroundColor: argonTheme.COLORS.ERROR, width: responsiveWidth(8), height: responsiveHeight(3.2) }}
                                        >
                                            <Text style={{ fontWeight: "bold", color: "white", fontSize: responsiveFontSize(1.3) }}>{days}</Text>

                                        </View>
                                        <View className="justify-center  items-center flex-row  rounded px-2"
                                            style={{ backgroundColor: argonTheme.COLORS.ERROR, width: responsiveWidth(8), height: responsiveHeight(3.2) }}
                                        >
                                            <Text style={{ fontWeight: "bold", color: "white", fontSize: responsiveFontSize(1.3) }}>{hours}</Text>

                                        </View>
                                        <View className="justify-center  items-center flex-row  rounded px-2"
                                            style={{ backgroundColor: argonTheme.COLORS.ERROR, width: responsiveWidth(8), height: responsiveHeight(3.2) }}
                                        >
                                            <Text style={{ fontWeight: "bold", color: "white", fontSize: responsiveFontSize(1.3) }}>{minutes}</Text>

                                        </View>
                                        <View className="justify-center  items-center flex-row  rounded px-2"
                                            style={{ backgroundColor: argonTheme.COLORS.ERROR, width: responsiveWidth(8), height: responsiveHeight(3.2) }}
                                        >
                                            <Text style={{ fontWeight: "bold", color: "white", fontSize: responsiveFontSize(1.3) }}>{seconds}</Text>
                                        </View>
                                    </View>
                                ) : (
                                    <View className="justify-center  items-center flex-row  rounded px-2"
                                        style={{ backgroundColor: argonTheme.COLORS.ERROR, width: "auto", height: responsiveHeight(4) }}

                                    >
                                        <Text className="color-white font-bold">ĐÃ KẾT THÚC</Text>

                                    </View>
                                )


                            )
                        }

                    </View>

                    <View className="flex-row justify-between border-stone-300 border-b " >
                        <View className="justify-center">
                            <Text style={{ fontSize: responsiveFontSize(1.3) }}>
                                {data.network}
                            </Text>
                        </View>
                        <View className="justify-center">
                            {
                                !CheckTimeBegin(data.startTime) ? (
                                    <Text style={{ fontSize: responsiveFontSize(1.3) }}>{`Bắt đầu ${GetDate(data.startTime).date} ${GetDate(data.startTime).time}`}</Text>


                                ) : (
                                    !CheckTimeEnd(data.endTime) ? (
                                        <Text style={{ fontSize: responsiveFontSize(1.3) }}>Ngày    giờ     phút     giây </Text>

                                    ) : (
                                        null
                                    )


                                )
                            }

                        </View>

                    </View>

                    {/* Price */}
                    <View className="">
                        <View>
                            {
                                !CheckTimeEnd(data.endTime) ?
                                    (
                                        <Text style={{ fontSize: responsiveFontSize(1.5) }} >Giá hiện tại</Text>
                                    ) : (
                                        <Text style={{ fontSize: responsiveFontSize(1.5) }} >Giá kết thúc</Text>
                                    )
                            }


                            <View className="flex-row items-center justify-between">

                                <View className="">
                                    <Text>
                                        <Text style={{ fontSize: responsiveFontSize(1.8), color: argonTheme.COLORS.ERROR, fontWeight: "bold" }} >{data.biddingWin.id != null ? ConvertCurrency(data.biddingWin.price) : ConvertCurrency(data.auctionPrice)} </Text>

                                        {
                                            !CheckTimeEnd(data.endTime) ?
                                                (
                                                    <Ionicons name="trending-up" color="green" size={responsiveFontSize(1.8)}></Ionicons>
                                                ) : (
                                                    null
                                                )
                                        }

                                    </Text>
                                </View>

                                <View className="flex-row">
                                    <View className="bg-stone-200 items-center px-2 mx-1 rounded-xl">
                                        <Text>
                                            <Ionicons name="hammer" color="grey" size={responsiveFontSize(1.8)}></Ionicons>
                                            <Text style={{ fontSize: responsiveFontSize(1.8) }}>
                                                {` ${data.bidderNum} ng`}
                                            </Text>
                                        </Text>

                                    </View>

                                </View>
                            </View>


                        </View>

                    </View>


                </View>
            </TouchableOpacity>
        );
    }

    const AllAuctionContent = () => {
        return (

            allAuctionData && allAuctionData.length > 0 ? (
                <ScrollView className="" style={{ height: "100%", marginBottom: 10 }}
                    showsVerticalScrollIndicator={false}
                    showsHorizontalScrollIndicator={false}

                    onScroll={({ nativeEvent }) => {
                        const { layoutMeasurement, contentOffset, contentSize } = nativeEvent;
                        const isEndReached = layoutMeasurement.height + contentOffset.y >= contentSize.height - responsiveHeight(1);
                        if (isEndReached) {
                            GetAllAuction();
                        }
                    }}
                >
                    {
                        allAuctionData.map((item) => {
                            return (
                                <AuctionCard key={item.id} data={item} />
                            )
                        })
                    }
                </ScrollView>
            ) : (
                <View className="items-center mt-5">
                    <Text className="font-bold">
                        Không có dữ liệu đấu giá!
                    </Text>
                </View>
            )
        );
    }
    const AuctingContent = () => {
        return (
            currentAuctionData && currentAuctionData.length > 0 ? (
                <ScrollView className=""
                    showsVerticalScrollIndicator={false}
                    showsHorizontalScrollIndicator={false}
                    style={{ height: "100%", marginBottom: 10 }}
                >
                    {
                        currentAuctionData.map((item) => {
                            return (
                                <AuctionCard key={item.id} data={item} />
                            )
                        })
                    }
                </ScrollView>
            ) :
                (
                    <View className="items-center mt-5">
                        <Text className="font-bold">
                            Không có dữ liệu đấu giá!
                        </Text>
                    </View>
                )
        );
    }
    const HistoryContent = () => {

        return (

            myAuctionData && myAuctionData.length > 0 ? (
                <ScrollView className=""
                    showsVerticalScrollIndicator={false}
                    showsHorizontalScrollIndicator={false}
                    style={{ height: "100%", marginBottom: 10 }}
                >
                    {
                        myAuctionData.map((item) => {
                            return (
                                <AuctionCard key={item.id} data={item} />
                            )

                        })
                    }
                </ScrollView>
            ) :
                (
                    <View className="items-center mt-5">
                        <Text className="font-bold">
                            Không có dữ liệu đấu giá!
                        </Text>
                    </View>
                )
        );
    }
    const ExitButton = () => {
        return (
            // Nút Thoát
            <TouchableOpacity className="p-1 rounded-full bg-white mx-1 "
                onPress={() => {
                    if (!props.isDrawer) {
                        props.navigation.goBack();
                    }
                    else {
                        props.navigation.closeDrawer();
                    }
                }}>

                <Ionicons name="chevron-back-outline" color="black" size={26}></Ionicons>
            </TouchableOpacity>
        );
    }
    const Title = () => {
        return (
            <View className="flex-1 items-center justify-center">
                <Text style={{ color: "white", fontWeight: "bold", fontSize: responsiveFontSize(2.2) }}>Đấu giá</Text>
            </View>

        );
    }
    const MyAuctionBtn = () => {
        return (
            // Nút Thoát
            <TouchableOpacity className="p-1 rounded-full bg-white mx-1 "
                onPress={() => {
                    props.navigation.navigate(AppConst.StackConst.NATIVE_STACK, { screen: AppConst.ScreenConst.MY_AUCTION_SCREEN })
                }}>
                <Ionicons name="person-outline" color="black" size={23}></Ionicons>
            </TouchableOpacity>
        );
    }
    useEffect(() => {
        handleButtonPress('Aucting');
        GetCurrentAuction();
    }, []);
    return (
        <SafeAreaView>
            <View className="flex-row p-2" style={{ zIndex: 1000, marginTop: StatusBar.currentHeight }} backgroundColor={argonTheme.COLORS.ERROR}>
                <ExitButton />
                <Title />
                {/* <MyAuctionBtn /> */}
            </View>

            <View className="mt-1 ">
                <View testID="Body" className="" style={{ height: '100%' }}>
                    <Body />
                </View>
            </View>
        </SafeAreaView>
    );
}

export default AutionScreen;


const styles = StyleSheet.create({
    container: {
        flexDirection: 'row',
        borderRadius: 5,
        borderWidth: 1,
        borderColor: '#ccc',
        backgroundColor: 'white',
    },
    card: {
        backgroundColor: '#f8f8f8f8',
        shadowColor: 'black',
        shadowOffset: { width: 1, height: 1 },
        shadowOpacity: 1,
        shadowRadius: 8,
        elevation: 5,
        borderColor: "black",
        marginLeft: 10,
        marginRight: 10,
        marginTop: 5,
        marginBottom: 5,
        height: "auto",
        padding: 5,


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
        bottom: '10%',
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


