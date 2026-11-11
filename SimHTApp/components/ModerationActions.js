import React, { useState } from "react";
import { Alert, StyleSheet, Text, TouchableOpacity, View } from "react-native";
import Ionicons from "react-native-vector-icons/Ionicons";
import { argonTheme } from "../constants";

const ModerationActions = ({ onReport, onBlock, disabled = false, compact = false }) => {
  const [isSubmitting, setSubmitting] = useState(false);

  const runAction = async (action, successMessage) => {
    if (isSubmitting || disabled) return;
    try {
      setSubmitting(true);
      await action();
      Alert.alert("Đã tiếp nhận", successMessage);
    } catch (error) {
      Alert.alert("Không thể thực hiện", "Vui lòng thử lại sau hoặc liên hệ hỗ trợ Sim Hà Thành.");
    } finally {
      setSubmitting(false);
    }
  };

  const confirmReport = () => {
    Alert.alert(
      "Báo cáo nội dung",
      "Báo cáo sẽ được chuyển cho đội ngũ kiểm duyệt. Chúng tôi xem xét và xử lý trong vòng 24 giờ.",
      [
        { text: "Hủy", style: "cancel" },
        {
          text: "Báo cáo",
          style: "destructive",
          onPress: () => runAction(onReport, "Báo cáo đã được chuyển đến đội ngũ kiểm duyệt."),
        },
      ],
    );
  };

  const confirmBlock = () => {
    Alert.alert(
      "Chặn người dùng",
      "Người này sẽ bị chặn và nội dung của họ sẽ bị ẩn ngay khỏi feed/chat của bạn. Báo cáo cũng được gửi đến đội ngũ kiểm duyệt.",
      [
        { text: "Hủy", style: "cancel" },
        {
          text: "Chặn",
          style: "destructive",
          onPress: () => runAction(onBlock, "Người dùng đã bị chặn và nội dung đã được ẩn khỏi feed của bạn."),
        },
      ],
    );
  };

  if (disabled) return null;

  return (
    <View style={[styles.container, compact && styles.compactContainer]}>
      <TouchableOpacity
        accessibilityRole="button"
        accessibilityLabel="Báo cáo nội dung"
        style={styles.action}
        onPress={confirmReport}
      >
        <Ionicons name="flag-outline" size={compact ? 16 : 18} color="#6b7280" />
        <Text style={[styles.label, compact && styles.compactLabel]}>Báo cáo</Text>
      </TouchableOpacity>
      <TouchableOpacity
        accessibilityRole="button"
        accessibilityLabel="Chặn người dùng"
        style={styles.action}
        onPress={confirmBlock}
      >
        <Ionicons name="ban-outline" size={compact ? 16 : 18} color={argonTheme.COLORS.ERROR} />
        <Text style={[styles.label, styles.blockLabel, compact && styles.compactLabel]}>Chặn</Text>
      </TouchableOpacity>
    </View>
  );
};

const styles = StyleSheet.create({
  container: { flexDirection: "row", alignItems: "center", gap: 14, marginTop: 8 },
  compactContainer: { gap: 10, marginTop: 5 },
  action: { flexDirection: "row", alignItems: "center", gap: 4, paddingVertical: 4 },
  label: { color: "#6b7280", fontSize: 13, fontWeight: "600" },
  blockLabel: { color: argonTheme.COLORS.ERROR },
  compactLabel: { fontSize: 12 },
});

export default ModerationActions;
