import React, { memo, useContext } from "react";
import { StyleSheet, Text, TouchableOpacity } from "react-native";
import { SimDataContext } from "../context/SimDataContext";

const SimDataCard = ({ item, setButtonIndex }) => {
  const { updatedSubscriptionArray } = useContext(SimDataContext);
  const isSelected = updatedSubscriptionArray.includes(item.id);

  return (
    <TouchableOpacity
      accessibilityRole="checkbox"
      accessibilityState={{ checked: isSelected }}
      activeOpacity={0.8}
      onPress={() => setButtonIndex(item.id)}
      style={[styles.card, isSelected && styles.selectedCard]}
    >
      <Text numberOfLines={2} style={[styles.text, isSelected && styles.selectedText]}>
        {item.name}
      </Text>
    </TouchableOpacity>
  );
};

const styles = StyleSheet.create({
  card: {
    alignItems: "center",
    backgroundColor: "#fff",
    borderColor: "#dedede",
    borderRadius: 8,
    borderWidth: StyleSheet.hairlineWidth,
    justifyContent: "center",
    margin: "1.5%",
    minHeight: 42,
    paddingHorizontal: 8,
    paddingVertical: 6,
    width: "47%",
  },
  selectedCard: {
    backgroundColor: "#eef7ff",
    borderColor: "#1575b6",
    borderWidth: 1,
  },
  text: {
    color: "#333",
    fontSize: 13,
    textAlign: "center",
  },
  selectedText: {
    color: "#1575b6",
    fontWeight: "700",
  },
});

export default memo(SimDataCard);
