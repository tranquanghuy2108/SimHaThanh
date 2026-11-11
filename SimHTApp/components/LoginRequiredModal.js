import React from "react";
import { Modal, StyleSheet, Text, TouchableOpacity, View } from "react-native";
import { argonTheme } from "../constants";

const LoginRequiredModal = ({ visible, onBack, onLogin }) => (
  <Modal
    visible={visible}
    transparent
    animationType="fade"
    statusBarTranslucent
    onRequestClose={onBack}
  >
    <View style={styles.backdrop}>
      <View style={styles.container}>
        <Text style={styles.title}>
          Chức năng này yêu cầu đăng nhập hệ thống. Bạn có muốn đăng nhập.
        </Text>

        <View style={styles.buttonGroup}>
          <TouchableOpacity
            style={[styles.button, styles.backButton]}
            onPress={onBack}
            activeOpacity={0.8}
            accessibilityRole="button"
          >
            <Text style={styles.buttonText} numberOfLines={1}>
              Trở về
            </Text>
          </TouchableOpacity>

          <TouchableOpacity
            style={[styles.button, styles.loginButton]}
            onPress={onLogin}
            activeOpacity={0.8}
            accessibilityRole="button"
          >
            <Text style={styles.buttonText} numberOfLines={1}>
              Đăng nhập
            </Text>
          </TouchableOpacity>
        </View>
      </View>
    </View>
  </Modal>
);

const styles = StyleSheet.create({
  backdrop: {
    flex: 1,
    alignItems: "center",
    justifyContent: "center",
    paddingHorizontal: 24,
    backgroundColor: "rgba(0, 0, 0, 0.5)",
  },
  container: {
    width: "100%",
    maxWidth: 380,
    padding: 24,
    borderRadius: 16,
    backgroundColor: "white",
  },
  title: {
    marginBottom: 24,
    color: "#303030",
    fontSize: 18,
    fontWeight: "700",
    lineHeight: 26,
    textAlign: "center",
  },
  buttonGroup: {
    width: "100%",
    alignItems: "center",
    gap: 12,
  },
  button: {
    width: "50%",
    height: 44,
    flexShrink: 0,
    alignItems: "center",
    justifyContent: "center",
    paddingHorizontal: 12,
    borderRadius: 8,
  },
  backButton: {
    backgroundColor: "#8C8C8C",
  },
  loginButton: {
    backgroundColor: argonTheme.COLORS.ERROR,
  },
  buttonText: {
    color: "white",
    fontSize: 16,
    fontWeight: "700",
  },
});

export default LoginRequiredModal;
