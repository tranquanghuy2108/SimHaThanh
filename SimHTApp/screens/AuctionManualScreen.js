import React from 'react';
import { argonTheme } from '../constants';


import {
    responsiveHeight,
    responsiveWidth,
    responsiveFontSize
} from "react-native-responsive-dimensions";
import Ionicons from 'react-native-vector-icons/Ionicons';
import {
    StyleSheet,
    StatusBar,
    View,
    TouchableOpacity,
    SafeAreaView,
    Text,
    ScrollView

} from "react-native";




const paragraph = [
    {
        header:
            "1. Đấu giá xuôi là gì?"
        ,
        content: [
            , "Ở đây chúng ta nói đến khái niệm đấu giá xuôi tại SimHT. Đấu giá xuôi (phương thức trả giá lên) là phương thức đấu giá, theo đó người tham gia đấu giá trả giá từ thấp lên cao cho đến khi xác định được người trả giá cao nhất so với giá khởi điểm trong thời gian đấu giá."
            , "Bạn chỉ cần bấm chọn sim số đẹp mà mình mong muốn, sau đó đặt mức giá mà mình có thể trả. Bạn có thể trả mức giá cao hơn khi thấy một người khác đang đặt giá cao hơn bạn. Khi thời gian đấu giá sim kết thúc, người trả giá cao nhất sẽ được thông báo trúng đấu giá và tiến hành thủ tục nhận sim."
            , "Người tham gia đấu giá có thể đặt chế độ tự động đấu giá, tự cài đặt mức giá mà mình có thể trả cho sim đang đấu giá, mà không cần liên tục theo dõi phiên đấu giá. Ứng dụng sẽ thông báo cho bạn khi có người trả mức giá cao hơn bạn trong đấu giá xuôi."
        ]
    },
    {
        header:
            "2. Hướng dẫn tạo phiên đấu giá xuôi trên ứng dụng SimHT"
        ,
        content: [
            , "Khi bạn có tài khoản, bạn có thể tạo phiên đấu giá. Bạn chỉ cần bấm vào nút “Tạo đấu giá”, điền số sim mà bạn muốn đưa lên sàn. Sim đấu giá cần được xác nhận các thông tin nên app sẽ yêu cầu bạn điền vào thông tin nhà mạng, tên chủ sim, kèm ảnh chụp chứng minh thư, thẻ căn cước 2 mặt để tiến hành xác nhận."
            , "Sau đó, bạn cần điền vào các thông tin: loại đấu giá (xuôi – ngược), giá khởi điểm, giá mua ngay, bước giá, thời gian bắt đầu và kết thúc, sau đó nhà đấu giá sẽ duyệt các thông tin của sim đấu giá trước khi lên sàn."
            , ""
            , ""
            , ""
            , ""
        ]
    },

];

const AuctionManualScreen = (props) => {
    const ExitButton = () => {
        return (
            // Nút Thoát
            <TouchableOpacity className="p-1 rounded-full bg-white mx-1 "
                onPress={() => {
                    props.navigation.closeDrawer();
                }}>
                <Ionicons name="chevron-back-outline" color="black" size={26}></Ionicons>
            </TouchableOpacity>
        );
    }
    const Title = () => {
        return (
            <View className="flex-1 items-center justify-center">
                <Text style={{ color: "white", fontWeight: "bold", fontSize: responsiveFontSize(2.2) }}>Hướng dẫn đấu giá</Text>
            </View>

        );
    }
    return (
        <SafeAreaView>

            <View className="flex-row p-2" style={{ zIndex: 1000, marginTop: StatusBar.currentHeight }} backgroundColor={argonTheme.COLORS.ERROR}>
                <ExitButton />
                <Title />
            </View>

            <ScrollView className="mx-2" style={{ marginBottom: responsiveHeight(10) }}>
                <Text style={styles.textHeader}>
                    HƯỚNG DẪN ĐẤU GIÁ XUÔI
                </Text>
                {
                    paragraph.map(para => {
                        return (
                            <View>
                                <Text style={styles.texSubHeader}>
                                    {para.header}
                                </Text>
                                {
                                    para.content.map(content => {
                                        return (
                                            <Text style={styles.textContent}>
                                                {content}
                                            </Text>
                                        )
                                    })
                                }

                            </View>
                        )
                    })
                }


            </ScrollView>

        </SafeAreaView>
    )


}
const styles = StyleSheet.create({
    container: {
        backgroundColor: 'white',
    },
    overview: {
        height: 'auto',
        borderRadius: 3,
        padding: 10,
        margin: 4,
        shadowOpacity: .1,
        shadowRadius: 3,
        elevation: 1,

        shadowColor: 'black',

    },
    textRow: {
        textAlign: "auto",
    },
    textHeader: {
        fontWeight: "bold",
        fontSize: responsiveFontSize(2.2),
    },
    texSubHeader: {
        fontWeight: "bold",
        fontSize: responsiveFontSize(2),
        color: argonTheme.COLORS.ERROR,
    },
    findSim: {
        fontWeight: "bold",
        fontSize: responsiveFontSize(2.4),
        color: argonTheme.COLORS.ERROR,
    },
    emphasizTxt: {
        fontWeight: "bold",
        fontSize: responsiveFontSize(2.1),
        marginLeft: 5,
        marginRight: 5,
    },
    textContent: {
        textAlign: "justify",
        marginLeft: 5,
        marginRight: 5,
        fontSize: responsiveFontSize(2.1)
    },
    textParentContent: {
        textAlign: "justify",
        fontSize: responsiveFontSize(2.1)
    },
    cellTableTxt: {
        textAlign: "justify",
        fontSize: responsiveFontSize(1.9)
    },
    cellTable: {
        borderWidth: 1,
        borderColor: 'black',
        flex: 1,
        alignItems: "center",
        width: 100,
    },
    point: {
        alignItems: "center",
        flex: 1,
        backgroundColor: argonTheme.COLORS.ERROR,
        width: "auto",
        margin: 1,
        marginTop: 20,
        marginBottom: 20,
        padding: 15,
        borderRadius: 10

    },
    pointTxt: {
        color: "white",
        fontWeight: "bold",
        fontSize: responsiveFontSize(2.2)
    },
    improveSim: {
        alignItems: "center",
        flex: 1,
        backgroundColor: argonTheme.COLORS.ERROR,
        width: "auto",
        margin: 1,
        padding: 15,
        borderRadius: 10
    },
    bottomSim: {
        flexDirection: "row",
        width: "100%",
        alignItems: "center",
        padding: 5,
        margin: 5,


        justifyContent: "center",
    },
    buttonSim: {
        backgroundColor: "white",
        padding: 5,
        margin: 5,
        borderRadius: 5,
    }
});

export default AuctionManualScreen;