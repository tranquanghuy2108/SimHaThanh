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
            "1.  Quy tắc đấu giá & giải thích từ ngữ"
        ,
        content: [
            "Trong quy định này, các thuật ngữ dưới đây được hiểu như sau:"
            , "1.Bước giá là mức chênh lệch tối thiểu của lần trả giá sau so với lần trả giá trước liền kề trong trường hợp đấu giá theo phương thức trả giá lên. Bước giá do người có tài sản đấu giá (chủ Sim) quyết định."
            , "2.Giá khởi điểm là giá ban đầu thấp nhất của tài sản đấu giá trong trường hợp đấu giá theo phương thức trả giá lên (đấu giá xuôi); giá ban đầu cao nhất của tài sản đấu giá trong trường hợp đấu giá theo phương thức đặt giá xuống (đấu giá ngược)"
            , "3.Mức giảm giá là mức chênh lệch giá tối thiểu sau phút giảm, thường được sử dụng trong phương thức đặt giá xuống (đấu giá ngược). Mức giảm giá do người có tài sản đấu giá quyết định."
            , "4.Chủ Sim đấu giá là cá nhân, tổ chức sở hữu chính chủ Sim hoặc người có quyền đưa tài sản ra đấu giá theo thỏa thuận hoặc theo quy định của pháp luật."
            , "5.Người tham gia đấu giá là cá nhân, tổ chức có đủ điều kiện tham gia đấu giá để mua Sim đấu giá theo quy định này và quy định khác của pháp luật có liên quan."
            , "6.Người trúng đấu giá là cá nhân, tổ chức trả giá cao nhất so với giá khởi điểm hoặc bằng giá khởi điểm trong trường hợp không có người trả giá cao hơn giá khởi điểm khi đấu giá theo phương thức trả giá lên; cá nhân, tổ chức chấp nhận mức giá khởi điểm hoặc mức giá đã giảm trong trường hợp đấu giá theo phương thức đặt giá xuống."
            , "7.Bid giá là hành động mà người tham gia đấu giá trả giá cho sản phẩm."
            , "8.Đấu giá ngược(phương thức đặt giá xuống) là phương thức đấu giá, theo đó hệ thống đặt giá từ cao xuống thấp cho đến khi xác định được người chấp nhận mức giá do đấu giá viên đưa ra."
            , "9.Đấu giá xuôi(phương thức trả giá lên) là phương thức đấu giá, theo đó người tham gia đấu giá trả giá từ thấp lên cao cho đến khi xác định được người trả giá cao nhất so với giá khởi điểm trong thời gian đấu giá."
            , "10.Sim đấu giá là tài sản được phép giao dịch theo quy định của nhà mạng và pháp luật."
            , "* Hệ thống đấu giá sim không cho khách hàng hủy kết quả đấu giá sim.Để đảm bảo tính công khai, minh bạch và quyền lợi cho các khách hàng tham gia đấu giá, hệ thống không chấp nhận yêu cầu hủy Sim đã và đang đấu dưới bất cứ hình thức nào.Khách hàng tự ý bỏ kết quả đấu giá bị phạt 50% giá đã đặt, tài khoản bị khóa 30 ngày không được tham gia đấu giá."
        ]
    },
    {
        header:
            "3. Thông báo kết quả đấu giá Sim"
        ,
        content: [
            "Ngay khi kết thúc phiên đấu giá sim, hệ thống gửi email, tin nhắn thông báo tới các khách hàng đã tham gia đặt giá."
        ]
    },
    {
        header:
            "4.  Thông tin Sim đấu giá"
        ,
        content: [
            , "Thông tin Sim đấu giá được nhà đấu giá xác thực chính chủ và thông báo rõ ràng tình trạng Sim: Trả trước/trả sau, Sim cam kết (nếu có),… hình thức sang tên."
            , "Quý khách vui lòng kiểm tra kỹ lại các thông tin của Sim trước khi tiến hành đặt giá."

        ]
    },
    {
        header:
            "5. Quy định thanh toán khi đấu giá thành công"
        ,
        content: [
            , "Thời hạn thanh toán trong vòng 24 - 48 giờ làm việc kể từ lúc nhận được thông báo thắng cuộc đấu giá thành công. Thanh toán chậm phạt 0.05% số tiền thành toán/ngày chậm. Không thanh toán, quý khách sẽ bị trừ tiền phạt vào số tiền kỹ quỹ."
            , "Toàn bộ chi phí sang tên, giao dịch do chủ Sim thanh toán."
            , "- Phí đăng ký và sang tên: theo phí quy định"
            , "- Giá dịch vụ giao dịch hộ: theo phí quy định"
            , "Trường hợp có lỗi sự cố kỹ thuật, nhà đấu giá khởi động lại phiên đấu giá như các Sim khác vào phiên tiếp theo. Trường hợp các bên không đồng ý đấu giá lại kết quả sẽ được huỷ bỏ"
        ]

    },
    {
        header:
            "6. Quyền và nghĩa vụ liên quan khác của nhà tổ chức đấu giá, người tham gia đấu giá và chủ sim"
        ,
        content: [
            "Nhà tổ chức đấu giá có quyền thay đổi thậm chí hủy bỏ kết quả của phiên đấu giá khi phát hiện có gian lận của Chủ sim hoặc Người tham gia đấu giá."
            , "Nghĩa vụ của Nhà tổ chức đấu giá"
            , "- Thẩm định tính pháp lý của số sim đấu giá (Nếu sim xảy ra tranh chấp trước thời điểm Người thắng đấu giá đứng tên thì Nhà tổ chức đấu giá phải chịu trách nhiệm)."
            , "- Sắp xếp chủ sim và người thắng đấu giá giao dịch trực tiếp hoặc gián tiếp - thông qua Giao Dịch Hộ (GDH) được chỉ định bởi Nhà tổ chức đấu giá hoặc người thắng đấu giá (Nếu người thắng đấu giá chỉ định GDH thì trong trường hợp sim có tranh chấp, Nhà tổ chức đấu giá sẽ không chịu trách nhiệm)."
            , "- Hoàn thành các nghĩa vụ tài chính liên quan không quá 03 ngày kể từ ngày kết thúc phiên đấu giá"
            , "Quyền và nghĩa vụ của Chủ tài sản đấu giá (Chủ sim)"
            , "Chủ sim có nghĩa vụ cung cấp chính xác thông tin của số sim tham gia đấu giá như: tình trạng sim, lịch sử sang tên (sang từ bao giờ và ở đâu, mua từ ai ….)"
            , ""
            , ""
            , ""
            , ""
            , ""
            , ""
        ]
    }
]

const AuctionRuleScreen = (props) => {
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
                <Text style={{ color: "white", fontWeight: "bold", fontSize: responsiveFontSize(2.2) }}>Quy định đấu giá</Text>
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

export default AuctionRuleScreen;