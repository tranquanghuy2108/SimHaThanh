import React from "react";
import { View, StyleSheet, Modal,ActivityIndicator } from 'react-native';
import { argonTheme } from "../constants";

const LoadingScreen = ({ data, isVisible, onClose, isSearchScreen }) => {
  return (
    <Modal visible={isVisible} transparent>
      <View style={styles.popupContainer} >
        <View style={styles.popupContent} className = "justify-center items-center">
          {
             <ActivityIndicator size="large" color={argonTheme.COLORS.ERROR} />
          }
        </View>
      </View>
    </Modal>
  );
};

const styles = StyleSheet.create({
  popupContainer: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: 'rgba(0, 0, 0, 0.6)',
    zIndex:99999,
  },
  popupContent: {
    height: 40,
    width: 105,
    padding: 10,
    borderRadius: 5,
    zIndex:99999,
  },
  popupText: {
    fontSize: 18,
    marginBottom: 10,
  },
  closeButton: {
    backgroundColor: 'blue',
    paddingHorizontal: 20,
    paddingVertical: 10,
    borderRadius: 8,
    alignSelf: 'flex-end',
  },
  closeButtonText: {
    color: 'white',
    fontSize: 16,
  },
  buttonText: {
    color: 'white',
    fontSize: 16,
  },

});

export default LoadingScreen;