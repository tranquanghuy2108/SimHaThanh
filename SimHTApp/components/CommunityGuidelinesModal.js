import React from "react";
import {
  Linking,
  Modal,
  ScrollView,
  StyleSheet,
  Text,
  TouchableOpacity,
  View,
} from "react-native";
import { argonTheme } from "../constants";

export const COMMUNITY_TERMS_VERSION = "2026-08-13";
export const COMMUNITY_TERMS_PROMPT_SEEN_KEY = "CommunityTermsPromptSeen";

const TERMS_SECTIONS = [
  {
    title: "1. Giới thiệu",
    paragraphs: [
      "Sim Hà Thành tôn trọng và tận tâm bảo vệ sự riêng tư của người dùng. Chính sách bảo vệ riêng tư này nhằm giải quyết những thông tin nhận biết cá nhân (sau đây gọi là “Dữ liệu”) có thể được chúng tôi thu thập.",
      "Chính sách này không áp dụng đối với các bên thứ ba mà chúng tôi không kiểm soát hoặc những người không phải nhân viên, đại lý của chúng tôi hoặc nằm ngoài quyền kiểm soát của chúng tôi.",
      "Vui lòng đọc kỹ Điều khoản sử dụng để hiểu rõ các hành vi được phép và không được phép thực hiện trên hệ thống Sim Hà Thành.",
    ],
  },
  {
    title: "2. Thu thập dữ liệu",
    paragraphs: [
      "Quy trình đăng ký và tư vấn có thể yêu cầu bạn cung cấp số điện thoại, email và yêu cầu riêng. Việc cung cấp các thông tin khác hoàn toàn tùy thuộc vào quyết định của bạn.",
      "Chúng tôi không tự động ghi nhận thông tin nếu bạn không nhập và không đồng ý với điều khoản sử dụng của chúng tôi.",
    ],
  },
  {
    title: "3. Sử dụng dữ liệu",
    paragraphs: [
      "Chúng tôi có thể sử dụng Dữ liệu để tùy biến và cải tiến dịch vụ. Chúng tôi nỗ lực để Dữ liệu của bạn không bị bên thứ ba khai thác, trừ các trường hợp sau:",
      "• Được quy định trong Chính sách bảo vệ riêng tư này.",
      "• Có sự chấp thuận của bạn, chẳng hạn đồng ý hoặc chấm dứt chia sẻ Dữ liệu.",
      "• Một dịch vụ do hệ thống cung cấp yêu cầu tương tác với bên thứ ba, hoặc theo quy trình hành pháp hay luật pháp.",
      "• Chúng tôi phát hiện việc sử dụng hệ thống vi phạm chính sách riêng tư, điều khoản sử dụng hoặc hướng dẫn nhằm bảo vệ quyền lợi và tài sản hợp pháp của Sim Hà Thành.",
    ],
  },
  {
    title: "4. Cookies",
    paragraphs: [
      "Cookie là một mẩu nhỏ thông tin được gửi đến trình duyệt từ máy chủ và lưu trên thiết bị. Cookie không thể đọc thông tin khác trên ổ cứng của bạn hoặc cookie được gửi bởi các trang web khác.",
      "Chúng tôi có thể dùng cookie để thống kê các trang bạn đã truy cập, cải thiện tốc độ truy cập và duy trì thiết lập cá nhân của bạn.",
      "Bạn có thể chọn từ chối cookie. Tuy nhiên, khi đó một số tính năng của Sim Hà Thành và các website khác có thể hoạt động không đầy đủ.",
    ],
  },
  {
    title: "5. Thay đổi điều khoản",
    paragraphs: [
      "Chúng tôi có thể thay đổi các điều khoản của Chính sách bảo vệ riêng tư để phù hợp điều kiện thực tế. Với thay đổi quan trọng, chúng tôi sẽ thông báo trên hệ thống hoặc gửi email đến địa chỉ bạn đã cung cấp.",
    ],
  },
  {
    title: "6. Từ chối đảm bảo",
    paragraphs: [
      "Dù luôn nỗ lực đáp ứng các tiêu chuẩn bảo vệ Dữ liệu, có những nhân tố nằm ngoài tầm kiểm soát có thể dẫn đến việc Dữ liệu bị tiết lộ. Vì vậy, chúng tôi không thể bảo đảm tuyệt đối Dữ liệu luôn hoàn hảo hoặc không bị tiết lộ.",
    ],
  },
  {
    title: "7. Quy tắc cộng đồng và kiểm duyệt nội dung",
    paragraphs: [
      "Sim Hà Thành không khoan nhượng với nội dung hoặc hành vi phản cảm, quấy rối, đe dọa, phân biệt đối xử, bạo lực, lừa đảo, khiêu dâm, vi phạm pháp luật hoặc xâm phạm quyền của người khác.",
      "Bài viết, bình luận và tin nhắn có thể được lọc trước khi hiển thị. Bạn có thể báo cáo nội dung hoặc chặn người dùng vi phạm; khi chặn, nội dung của người đó được ẩn ngay khỏi feed và chat của bạn, đồng thời thông tin được chuyển đến đội ngũ kiểm duyệt.",
      "Đội ngũ Sim Hà Thành xem xét báo cáo trong vòng 24 giờ. Nội dung vi phạm sẽ bị gỡ và tài khoản vi phạm có thể bị đình chỉ hoặc khóa.",
    ],
  },
];

export const TermsAndCommunityContent = () => (
  <>
    {TERMS_SECTIONS.map((section) => (
      <View key={section.title} style={styles.section}>
        <Text style={styles.sectionTitle}>{section.title}</Text>
        {section.paragraphs.map((paragraph) => (
          <Text key={paragraph} style={styles.paragraph}>
            {paragraph}
          </Text>
        ))}
      </View>
    ))}
    <Text style={styles.paragraph}>
      Hỗ trợ kiểm duyệt: {" "}
      <Text
        style={styles.contactLink}
        onPress={() => Linking.openURL("tel:0911929999")}
      >
        0911 92 9999
      </Text>
      {" · "}
      <Text
        style={styles.contactLink}
        onPress={() => Linking.openURL("https://www.simhathanh.vn/lien-he")}
      >
        Liên hệ Sim Hà Thành
      </Text>
      .
    </Text>
    <Text style={styles.thanks}>
      Trân trọng cảm ơn Quý khách hàng đã tin tưởng và sử dụng dịch vụ của chúng tôi.
    </Text>
  </>
);

const CommunityGuidelinesModal = ({
  visible,
  onAccept,
  onClose,
  acceptLabel = "Tôi đồng ý",
}) => (
  <Modal visible={visible} transparent animationType="slide" onRequestClose={onClose}>
    <View style={styles.backdrop}>
      <View style={styles.sheet}>
        <Text style={styles.title}>Điều khoản sử dụng ứng dụng</Text>
        <ScrollView
          contentContainerStyle={styles.content}
          showsVerticalScrollIndicator
        >
          <TermsAndCommunityContent />
          {onAccept ? (
            <TouchableOpacity
              style={styles.acceptButton}
              onPress={onAccept}
              accessibilityRole="button"
            >
              <Text style={styles.acceptText}>{acceptLabel}</Text>
            </TouchableOpacity>
          ) : null}
          {onClose ? (
            <TouchableOpacity
              style={styles.closeButton}
              onPress={onClose}
              accessibilityRole="button"
            >
              <Text style={styles.closeText}>Đóng</Text>
            </TouchableOpacity>
          ) : null}
        </ScrollView>
      </View>
    </View>
  </Modal>
);

const styles = StyleSheet.create({
  backdrop: {
    flex: 1,
    justifyContent: "flex-end",
    backgroundColor: "rgba(0, 0, 0, 0.5)",
  },
  sheet: {
    maxHeight: "86%",
    backgroundColor: "white",
    borderTopLeftRadius: 20,
    borderTopRightRadius: 20,
    paddingHorizontal: 20,
    paddingTop: 20,
  },
  title: {
    color: argonTheme.COLORS.ERROR,
    fontSize: 19,
    fontWeight: "700",
    textAlign: "center",
    marginBottom: 12,
  },
  content: {
    paddingBottom: 28,
  },
  section: {
    marginBottom: 8,
  },
  sectionTitle: {
    color: argonTheme.COLORS.ERROR,
    fontSize: 16,
    fontWeight: "700",
    marginBottom: 4,
  },
  paragraph: {
    color: "#303030",
    fontSize: 15,
    lineHeight: 22,
    marginBottom: 9,
    textAlign: "justify",
  },
  contactLink: {
    color: "#0a6eb4",
    fontWeight: "700",
  },
  thanks: {
    color: "#303030",
    fontSize: 15,
    fontStyle: "italic",
    lineHeight: 22,
    marginTop: 4,
    textAlign: "center",
  },
  acceptButton: {
    backgroundColor: argonTheme.COLORS.ERROR,
    borderRadius: 8,
    alignItems: "center",
    marginTop: 12,
    paddingVertical: 13,
  },
  acceptText: {
    color: "white",
    fontWeight: "700",
    fontSize: 16,
  },
  closeButton: {
    borderColor: argonTheme.COLORS.ERROR,
    borderRadius: 8,
    borderWidth: 1,
    alignItems: "center",
    marginTop: 12,
    paddingVertical: 12,
  },
  closeText: {
    color: argonTheme.COLORS.ERROR,
    fontWeight: "700",
    fontSize: 16,
  },
});

export default CommunityGuidelinesModal;
