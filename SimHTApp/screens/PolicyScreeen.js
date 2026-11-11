import React from "react";
import {
  SafeAreaView,
  ScrollView,
  StatusBar,
  StyleSheet,
  Text,
  TouchableOpacity,
  View,
} from "react-native";
import Ionicons from "react-native-vector-icons/Ionicons";
import { argonTheme } from "../constants";
import { TermsAndCommunityContent } from "../components/CommunityGuidelinesModal";

const PolicyScreeen = ({ navigation }) => (
  <SafeAreaView style={styles.safeArea}>
    <StatusBar translucent backgroundColor={argonTheme.COLORS.ERROR} />
    <View style={styles.header}>
      <TouchableOpacity
        style={styles.backButton}
        onPress={() => navigation.goBack()}
        accessibilityRole="button"
        accessibilityLabel="Quay lại"
      >
        <Ionicons name="chevron-back-outline" color="white" size={26} />
      </TouchableOpacity>
      <Text style={styles.headerTitle}>Điều khoản sử dụng</Text>
      <View style={styles.headerSpacer} />
    </View>
    <View style={styles.body}>
      <ScrollView contentContainerStyle={styles.content}>
        <TermsAndCommunityContent />
      </ScrollView>
    </View>
  </SafeAreaView>
);

const styles = StyleSheet.create({
  safeArea: {
    flex: 1,
    backgroundColor: argonTheme.COLORS.ERROR,
  },
  header: {
    alignItems: "center",
    backgroundColor: argonTheme.COLORS.ERROR,
    flexDirection: "row",
    minHeight: 54,
    paddingHorizontal: 12,
  },
  backButton: {
    alignItems: "center",
    height: 40,
    justifyContent: "center",
    width: 40,
  },
  headerTitle: {
    color: "white",
    flex: 1,
    fontSize: 18,
    fontWeight: "700",
    textAlign: "center",
  },
  headerSpacer: {
    width: 40,
  },
  body: {
    backgroundColor: "white",
    flex: 1,
  },
  content: {
    padding: 16,
    paddingBottom: 32,
  },
});

export default PolicyScreeen;
