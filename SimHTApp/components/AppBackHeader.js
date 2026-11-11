import React from "react";
import { StyleSheet, Text, TouchableOpacity, View } from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
import Ionicons from "react-native-vector-icons/Ionicons";
import { argonTheme } from "../constants";

const AppBackHeader = ({ navigation, title }) => {
  const handleBack = () => {
    if (navigation.canGoBack?.()) {
      navigation.goBack();
      return;
    }

    navigation.getParent?.()?.goBack();
  };

  return (
    <SafeAreaView edges={["top"]} style={styles.safeArea}>
      <View className="flex-row p-2" style={styles.header}>
        <TouchableOpacity
          className="p-1 rounded-full bg-white mx-1"
          accessibilityRole="button"
          accessibilityLabel="Trở lại"
          onPress={handleBack}
        >
          <Ionicons name="chevron-back-outline" color="black" size={26} />
        </TouchableOpacity>
        <View className="flex-1 items-center justify-center">
          <Text style={styles.title}>{title}</Text>
        </View>
      </View>
    </SafeAreaView>
  );
};

const styles = StyleSheet.create({
  safeArea: {
    backgroundColor: argonTheme.COLORS.ERROR,
  },
  header: {
    backgroundColor: argonTheme.COLORS.ERROR,
    zIndex: 1000,
  },
  title: {
    color: "white",
    fontSize: 16,
    fontWeight: "bold",
  },
});

export default AppBackHeader;
