import React, { useState, useContext, useCallback } from "react";
import { useFocusEffect } from "@react-navigation/native";
import {
  TouchableOpacity,
  Text,
  Image,
  View,
  TextInput,
  StyleSheet,
  SafeAreaView,
  ToastAndroid,
  Platform,
} from "react-native";
import DateTimePicker from "@react-native-community/datetimepicker";
import { AppConst } from "../../constants/AppConst";
import { argonTheme } from "../../constants";
import { FengShuiContext } from "../../context/FengShuiContext";
import AppBackHeader from "../../components/AppBackHeader";

const FortuneSimScreen = ({ navigation }) => {
  useFocusEffect(
    useCallback(() => {
      console.log("LOG Active Screen : FortuneSimScreen");
      return () => {
        // Optional: Add cleanup logic here if needed when the screen loses focus
      };
    }, []),
  );
  const { FotureTelling } = useContext(FengShuiContext);
  const [date, setDate] = useState(new Date(1990, 0, 1, 12, 0));
  const [mode, setMode] = useState("date");
  const [show, setShow] = useState(false);

  const [name, SetName] = useState("");
  const [phoneNumber, SetPhoneNumberState] = useState("");

  // CheckBox
  const [isMaleChecked, setIsMaleChecked] = useState(false);

  const onChange = (event, selectedDate) => {
    if (Platform.OS === "android") setShow(false);
    if (event.type === "dismissed" || !selectedDate) return;
    setDate(selectedDate);
  };

  const showMode = (currentMode) => {
    setShow(true);
    setMode(currentMode);
  };

  const showDatepicker = () => {
    showMode("date");
  };

  const showTimepicker = () => {
    showMode("time");
  };

  const handleMaleCheckboxPress = () => {
    setIsMaleChecked(!isMaleChecked);
  };

  const maleCheckboxColor = isMaleChecked ? "#1183d2" : "transparent";
  const femaleCheckboxColor = isMaleChecked ? "transparent" : "#1183d2";

  const PhoneChange = (text) => {
    SetPhoneNumberState(text);
  };
  const NameChange = (text) => {
    SetName(text);
  };

  const isValidPhoneNumber = (phoneNumber) => {
    // Loại bỏ các ký tự không phải số (nếu có)
    const sanitizedNumber = phoneNumber.replace(/\D/g, "");

    // Kiểm tra độ dài của số điện thoại
    if (sanitizedNumber.length !== 10 && sanitizedNumber.length !== 11) {
      return false;
    }

    // Kiểm tra đúng định dạng số điện thoại của Việt Nam
    const regex = /^(0[2-9]|84[2-9])(\d{8}|\d{9})$/;
    return regex.test(sanitizedNumber);
  };

  return (
    <View style={{ flex: 1 }}>
      <AppBackHeader navigation={navigation} title="Bói Sim Phong Thủy" />
      <View style={{ flex: 1 }}>
        <View className="mt-9">
        <View testID="Body" className="px-6">
          <View style={styles.inputContainer}>
            <View style={styles.iconContainer}>
              <Image
                source={require("../../assets/imgs/icon_mobile.png")}
                style={{ width: 17, height: 17 }}
                resizeMode="contain"
              />
            </View>
            <TextInput
              style={styles.input}
              placeholder="Số điện thoại"
              maxLength={10}
              keyboardType="numeric"
              placeholderTextColor="#888"
              value={phoneNumber}
              onChangeText={PhoneChange}
            />
          </View>

          <View style={styles.inputContainer}>
            <View style={styles.iconContainer}>
              <Image
                source={require("../../assets/imgs/icon_user.png")}
                style={{ width: 17, height: 17 }}
                resizeMode="contain"
              />
            </View>
            <TextInput
              style={styles.input}
              placeholder="Họ tên"
              placeholderTextColor="#888"
              value={name}
              onChangeText={NameChange}
            />
          </View>

          <TouchableOpacity
            style={styles.inputContainer}
            onPress={showDatepicker}
            activeOpacity={0.8}
          >
            <View style={styles.iconContainer}>
              <Image
                source={require("../../assets/imgs/icon_calendar.png")}
                style={{ width: 17, height: 17 }}
                resizeMode="contain"
              />
            </View>
            <TextInput
              style={styles.input}
              placeholder="Ngày sinh (Dương lịch)"
              placeholderTextColor="#888"
              editable={false}
              pointerEvents="none"
              value={`${date.getDate()}/${date.getMonth() + 1}/${date.getFullYear()}`}
            />
          </TouchableOpacity>

          <TouchableOpacity
            style={styles.inputContainer}
            onPress={showTimepicker}
            activeOpacity={0.8}
          >
            <View style={styles.iconContainer}>
              <Image
                source={require("../../assets/imgs/icon_clock.png")}
                style={{ width: 17, height: 17 }}
                resizeMode="contain"
              />
            </View>
            <TextInput
              style={styles.input}
              placeholder="Giờ sinh"
              placeholderTextColor="#888"
              editable={false}
              pointerEvents="none"
              value={`${String(date.getHours()).padStart(2, "0")}:${String(date.getMinutes()).padStart(2, "0")}`}
            />
          </TouchableOpacity>

          {show && (
            <View>
              <DateTimePicker
                testID="dateTimePicker"
                value={date}
                mode={mode}
                is24Hour={true}
                onChange={onChange}
                display={Platform.OS === "ios" ? "spinner" : "default"}
                {...(mode === "date" && {
                  minimumDate: new Date(1924, 1, 5),
                  maximumDate: new Date(),
                })}
              />
              {Platform.OS === "ios" && (
                <TouchableOpacity
                  style={styles.pickerDoneButton}
                  onPress={() => setShow(false)}
                >
                  <Text style={styles.pickerDoneText}>Xong</Text>
                </TouchableOpacity>
              )}
            </View>
          )}

          <View className="flex-row justify-between ">
            <TouchableOpacity
              onPress={handleMaleCheckboxPress}
              style={styles2.container}
              className=""
            >
              <View style={styles2.checkboxContainer}>
                <View style={styles2.checkboxWrapper}>
                  {isMaleChecked && (
                    <View
                      style={[
                        styles2.checkbox,
                        { backgroundColor: maleCheckboxColor },
                      ]}
                    />
                  )}
                </View>
                <Text style={styles2.label}>Nam</Text>
              </View>
            </TouchableOpacity>

            <TouchableOpacity
              onPress={handleMaleCheckboxPress}
              style={styles2.container}
              className=""
            >
              <View style={styles2.checkboxContainer}>
                <View style={styles2.checkboxWrapper}>
                  {!isMaleChecked && (
                    <View
                      style={[
                        styles2.checkbox,
                        { backgroundColor: femaleCheckboxColor },
                      ]}
                    />
                  )}
                </View>
                <Text style={styles2.label}>Nữ</Text>
              </View>
            </TouchableOpacity>
          </View>

          <TouchableOpacity
            onPress={() => {
              if (name != "" && isValidPhoneNumber(phoneNumber)) {
                var year = date.getFullYear();
                var month = date.getMonth() + 1;
                var day = date.getDate();
                var hour = date.getHours();
                var minute = date.getMinutes();
                FotureTelling(
                  phoneNumber,
                  year,
                  month,
                  day,
                  hour,
                  minute,
                  isMaleChecked,
                );
                navigation.navigate(AppConst.StackConst.NATIVE_STACK, {
                  screen: AppConst.ScreenConst.FORTUNE_SIM_DETAIL_SCREEN,
                });
              } else {
                if (name == "" && isValidPhoneNumber(phoneNumber)) {
                  ToastAndroid.showWithGravity(
                    "Vui Lòng Kiểm Tra Họ Tên!",
                    ToastAndroid.SHORT,
                    ToastAndroid.BOTTOM,
                  );
                } else if (!isValidPhoneNumber(phoneNumber) && name != "") {
                  ToastAndroid.showWithGravity(
                    "Vui Lòng Kiểm Tra Số Điện Thoại!",
                    ToastAndroid.SHORT,
                    ToastAndroid.BOTTOM,
                  );
                } else {
                  ToastAndroid.showWithGravity(
                    "Vui Lòng Kiểm Tra Họ Tên và Số Điện Thoại!",
                    ToastAndroid.SHORT,
                    ToastAndroid.BOTTOM,
                  );
                }
              }
            }}
            className="rounded p-2 mt-6"
            style={{ backgroundColor: argonTheme.COLORS.ERROR }}
          >
            <Text className="text-center font-bold color-white">Xem</Text>
          </TouchableOpacity>
        </View>
        </View>
      </View>
    </View>
  );
};
const styles = StyleSheet.create({
  inputContainer: {
    flexDirection: "row",
    alignItems: "center",

    borderWidth: 1,
    borderColor: "#ccc",
    borderRadius: 5,
    backgroundColor: "white",
    shadowColor: "black",
    shadowOffset: { width: 0, height: 1 },
    shadowOpacity: 0.3,
    shadowRadius: 2,
    elevation: 2,
    marginTop: 5,
  },
  iconContainer: {
    padding: 10,
  },
  input: {
    flex: 1,
    height: 40,
    paddingHorizontal: 10,
    color: "#333",
  },
  pickerDoneButton: {
    alignSelf: "flex-end",
    paddingHorizontal: 20,
    paddingVertical: 10,
  },
  pickerDoneText: {
    color: argonTheme.COLORS.ERROR,
    fontSize: 16,
    fontWeight: "700",
  },
});
const styles2 = StyleSheet.create({
  container: {
    flexDirection: "row",
    height: 50,
    width: 150,
    borderWidth: 1,
    borderColor: "#ccc",
    borderRadius: 5,
    backgroundColor: "white",
    shadowColor: "black",
    shadowOffset: { width: 0, height: 1 },
    shadowOpacity: 0.3,
    shadowRadius: 2,
    elevation: 2,
    marginTop: 5,
    marginBottom: 5,
  },
  checkboxContainer: {
    flexDirection: "row",
    alignItems: "center",
    padding: 10,
  },
  checkboxWrapper: {
    width: 20,
    height: 20,
    borderWidth: 1,
    borderColor: "#dddddd",
    backgroundColor: "#dddddd",
    padding: 2,
    marginRight: 10,
    borderRadius: 3,
  },
  checkbox: {
    flex: 1,
    backgroundColor: "#1183d2",
    borderRadius: 3,
  },
  label: {
    fontSize: 16,
  },
});
export default FortuneSimScreen;
