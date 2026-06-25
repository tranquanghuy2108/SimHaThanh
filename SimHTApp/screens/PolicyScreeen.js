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
            "1. Giới thiệu"
        ,

        content: [
            , "Thế giới Sim tôn trọng và tận tâm bảo vệ sự riêng tư của người dùng. Chính sách Bảo vệ riêng tư này nhằm giải quyết những thông tin nhận biết cá nhân (sau đây gọi là “Dữ liệu”) có thể được chúng tôi thu thập."
            , "Chính sách Bảo vệ riêng tư này không áp dụng đối với những bên tham gia mà chúng tôi không kiểm soát hoặc những người không phải nhân viên, đại lý của chúng tôi hoặc nằm trong quyền kiểm soát của chúng tôi."
            , "Xin vui lòng dành chút thời gian đọc kỹ Quy định sử dụng để hiểu rõ hơn về các hành vi được phép và không được phép thực hiện tại hệ thống Thế giới Sim."
        ]
    },
    {

        header:
            "2. Thu thập dữ liệu"
        ,
        content: [
            , "Quy trình đăng ký tư vấn của chúng tôi khuyến khích khách hàng nhập lên số điện thoại, email và yêu cầu riêng. Việc cung cấp những thông tin khác cho chúng tôi hay không tùy thuộc vào quyết định của bạn."
            , "Chúng tôi không tự động ghi nhận những thông tin nếu như quý khách không nhập lên và đồng ý với điều khoản của chúng tôi."

        ]
    },

    {
        header:
            "3. Sử dụng dữ liệu"
        ,
        content: [
            , "Chúng tôi có thể sử dụng Dữ liệu để tùy biến và cải tiến nhằm phục vụ bạn tốt hơn.Chúng tôi sẽ cố gắng để Dữ liệu của bạn không bị các bên thứ ba khai thác, ngoại trừ các trường hợp:"
            , "- Được quy định khác trong bản Chính sách Bảo vệ Riêng tư này;"
            , "- Chúng tôi được bạn chấp thuận, như đồng ý hoặc chấm dứt chia sẻ dữ liệu;"
            , "- Một dịch vụ do website của chúng tôi cung cấp yêu cầu sự tương tác với một bên thứ ba hoặc do bên thứ ba cung cấp theo các quy trình hành pháp hoặc luật pháp;"
            , "- Chúng tôi phát hiện việc bạn sử dụng website này vi phạm Chính sách Bảo vệ Riêng tư, Quy định sử dụng hoặc các hướng dẫn sử dụng khác do chúng tôi đặt ra nhằm bảo vệ quyền lợi và / hoặc tài sản hợp pháp của mình."
        ]
    },
    {
        header:
            "4. Cookies"
        ,
        content: [
            , "Cookie là một mẩu nhỏ thông tin gửi đến trình duyệt Internet từ máy chủ và lưu lại trên ổ cứng.Cookie không thể đọc thông tin trên ổ cứng của bạn hay thông tin của các cookie được gửi đến bởi các trang Web khác."
            , "Cookie vô hại với hệ thống của bạn.Chúng tôi dùng Cookie để thống kê các trang thuộc hệ thống Thế giới Sim mà các bạn đã truy cập, và trong lần ghé thăm kế tiếp của bạn, bạn sẽ truy cập những trang đó nhanh hơn."
            , "Cũng như nhiều website khác, chúng tôi thiết lập và sử dụng cookie để nâng cao sự cảm thụ của bạn, cũng như duy trì thiết lập cá nhân của bạn… Website của chúng tôi có thể đăng quảng cáo, và trong trường hợp đó có thể thiết lập và truy cập các cookie trên máy tính của bạn và phụ thuộc vào chính sách bảo vệ sự riêng tư của các bên cung cấp quảng cáo."
            , "Tuy nhiên, các công ty quảng cáo không được truy cập vào cookie của chúng tôi.Những công ty đó thường sử dụng các đoạn mã riêng để theo dõi số lượt truy cập của bạn đến website của chúng tôi.Trong thời gian bạn truy cập Thế giới Sim, Thế giới Sim hoặc các nhà tài trợ có thể gửi “cookie” đến máy tính của bạn."
            , "Bạn cũng có thể chọn từ chối tất cả các cookie được gửi đến.Nếu bạn chọn như vậy có thể một số tính năng của Thế giới Sim cũng như các website khác, sẽ không hoạt động tốt."
        ]
    },


    {
        header:
            "5. Thay đổi điều khoản"
        ,
        content: [
            , "Chúng tôi có thể thay đổi các điều khoản của bản Chính sách Bảo vệ Riêng tư này cho phù hợp với điều kiện thực tế.Chúng tôi sẽ thông báo về những thay đổi lớn bằng cách đặt thông báo trên site của chúng tôi hoặc gửi thư điện tử tới địa chỉ e - mail mà bạn đã cung cấp và được đặt trong thiết lập người dùng của bạn."

        ]
    },

    {
        header:
            "6. Từ chối đảm bảo"
        ,
        content: [
            , "Mặc dù Chính sách Bảo vệ riêng tư đặt ra những tiêu chuẩn về Dữ liệu và chúng tôi luôn cố gắng hết mình để đáp ứng, chúng tôi không bị buộc phải bảo đảm những tiêu chuẩn đó.Có thể có những nhân tố vượt ra ngoài tầm kiểm soát của chúng tôi có thể dẫn đến việc Dữ liệu bị tiết lộ.Vì thế, chúng tôi không chịu trách nhiệm bảo đảm Dữ liệu luôn được duy trì ở tình trạng hoàn hảo hoặc không bị tiết lộ."
        ]
    },
    {
        header:
            "Trân trọng cảm ơn Quý khách hàng đã luôn tin tưởng, lựa chọn và sử dụng dịch vụ của chúng tôi!"
        ,
        content: [
            , ""
            , ""
            , ""
            , ""
        ]
    },
];

const PolicyScreeen = (props) => {
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
                <Text style={{ color: "white", fontWeight: "bold", fontSize: responsiveFontSize(2.2) }}>Chính sách và điều khoản</Text>
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

export default PolicyScreeen;