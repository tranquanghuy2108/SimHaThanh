import React, { useState, useContext} from 'react';
import { TouchableOpacity, Text, Image, View, TextInput, StyleSheet, SafeAreaView, ToastAndroid } from 'react-native';
import DateTimePicker from '@react-native-community/datetimepicker';
import { AppConst } from '../../constants/AppConst';
import { argonTheme } from '../../constants';
import { FengShuiContext } from '../../context/FengShuiContext';

const SearchFengShuiScreen = ({ navigation }) => {
  const { SearchFotureSim} = useContext(FengShuiContext);
  const [date, setDate] = useState(new Date(null));
  const [mode, setMode] = useState('date');
  const [show, setShow] = useState(false);

  const [name,SetName] = useState("");
  const [phoneNumber,SetPhoneNumberState] = useState("");

  // CheckBox
  const [isMaleChecked, setIsMaleChecked] = useState(false);

  const onChange = (event, selectedDate) => {
    const currentDate = selectedDate;
    setShow(false);
    setDate(currentDate);
  };

  const showMode = (currentMode) => {
    setShow(true);
    setMode(currentMode);
  };

  const showDatepicker = () => {
    showMode('date');
  };

  const showTimepicker = () => {
    showMode('time');
  };



  const handleMaleCheckboxPress = () => {
    setIsMaleChecked(!isMaleChecked);
  };



  const maleCheckboxColor = isMaleChecked ? '#1183d2' : 'transparent';
  const femaleCheckboxColor = isMaleChecked ? 'transparent' : '#1183d2';

  const PhoneChange =(text) =>{
    SetPhoneNumberState(text);
  }
  const NameChange =(text) =>{
    SetName(text);
  }

  const isValidPhoneNumber = (phoneNumber) => {
    // Loại bỏ các ký tự không phải số (nếu có)
    const sanitizedNumber = phoneNumber.replace(/\D/g, '');

    // Kiểm tra độ dài của số điện thoại
    if (sanitizedNumber.length !== 10 && sanitizedNumber.length !== 11) {
        return false;
    }

    // Kiểm tra đúng định dạng số điện thoại của Việt Nam
    const regex = /^(0[2-9]|84[2-9])(\d{8}|\d{9})$/;
    return regex.test(sanitizedNumber);
}

  return (

    <SafeAreaView>
      <View className="mt-9">

        <View testID="Body" className="px-6">
         


          <View style={styles.inputContainer} className="">
            <View style={styles.iconContainer}>
              <Image source={require('../../assets/imgs/icon_user.png')} style={{ width: 17, height: 17 }} resizeMode='contain' />
            </View>
            <TextInput
              style={styles.input}
              placeholder="Họ tên"
              placeholderTextColor="#888"
              value ={name}
              onChangeText={NameChange}
            />
          </View>

          <View style={styles.inputContainer} className="">
            <View style={styles.iconContainer}>
              <Image source={require('../../assets/imgs/icon_calendar.png')} style={{ width: 17, height: 17 }} resizeMode='contain' />
            </View>
            <TouchableOpacity onPress={showDatepicker}>
              <TextInput
                style={styles.input}
                placeholder="Ngày sinh (Dương lịch)"
                placeholderTextColor="#888"
                editable={false}
                is24Hour={true}
                value={`${date.getDate()}/${date.getMonth() + 1}/${date.getFullYear()}`}

              />
            </TouchableOpacity>
          </View>


          <View style={styles.inputContainer} className="">
            <View style={styles.iconContainer}>
              <Image source={require('../../assets/imgs/icon_clock.png')} style={{ width: 17, height: 17 }} resizeMode='contain' />
            </View>
            <TouchableOpacity onPress={showTimepicker}>
              <TextInput
                style={styles.input}
                placeholder="Giờ sinh"
                placeholderTextColor="#888"
                editable={false}
                value={`${date.getHours()}:${date.getMinutes()}`}

              />
            </TouchableOpacity>
          </View>




          {show && (
            <View>
              <DateTimePicker
                testID="dateTimePicker"
                value={date}
                mode={mode}
                is24Hour={true}
                onChange={onChange}
                display='spinner'
                minimumDate={new Date('1924-02-05')}
                maximumDate={new Date('2018-12-30')}
              />
            </View>

          )}

          <View className="flex-row justify-between ">
            <TouchableOpacity onPress={handleMaleCheckboxPress} style={styles2.container} className="">
              <View style={styles2.checkboxContainer}>
                <View style={styles2.checkboxWrapper}>
                  {isMaleChecked && <View style={[styles2.checkbox, { backgroundColor: maleCheckboxColor }]} />}
                </View>
                <Text style={styles2.label}>Nam</Text>
              </View>
            </TouchableOpacity>

            <TouchableOpacity onPress={handleMaleCheckboxPress} style={styles2.container} className="">
              <View style={styles2.checkboxContainer}>
                <View style={styles2.checkboxWrapper}>
                  {!isMaleChecked && <View style={[styles2.checkbox, { backgroundColor: femaleCheckboxColor }]} />}
                </View>
                <Text style={styles2.label}>Nữ</Text>
              </View>
            </TouchableOpacity>

          </View>


          <TouchableOpacity
            onPress={
              () => {
                if(name!=""){
                  var year = date.getFullYear();
                  var month = date.getMonth()+1;
                  var day = date.getDate();
                  var hour = date.getHours();
                  var minute = date.getMinutes();

                  SearchFotureSim(year,month,day,hour,minute,isMaleChecked);

                  navigation.navigate(AppConst.StackConst.NATIVE_STACK, { screen: AppConst.ScreenConst.SEARCH_FORTUNE_SIM_DETAIL_SCREEN });
                }
                else{
                  ToastAndroid.showWithGravity(
                    'Vui Lòng Kiểm Tra Họ Tên!',
                    ToastAndroid.SHORT,
                    ToastAndroid.BOTTOM,
                );
                }
                
              
              }
            }
            className="rounded p-2 mt-6"
            style={{ backgroundColor: argonTheme.COLORS.ERROR }}
          >
            <Text className="text-center font-bold color-white">Xem</Text>
          </TouchableOpacity>


        </View>

      </View>
    </SafeAreaView>
  )
}
const styles = StyleSheet.create({
  inputContainer: {
    flexDirection: 'row',
    alignItems: 'center',

    borderWidth: 1,
    borderColor: '#ccc',
    borderRadius: 5,
    backgroundColor: 'white',
    shadowColor: 'black',
    shadowOffset: { width: 0, height: 2 },
    shadowOpacity: 1,
    shadowRadius: 8,
    marginTop: 5,
  },
  iconContainer: {
    padding: 10,
  },
  input: {
    flex: 1,
    height: 40,
    paddingHorizontal: 10,
    color: '#333',
  },
});
const styles2 = StyleSheet.create({
  container: {
    flexDirection: 'row',
    height: 50,
    width: 150,
    borderWidth: 1,
    borderColor: '#ccc',
    borderRadius: 5,
    backgroundColor: 'white',
    shadowColor: 'black',
    shadowOffset: { width: 0, height: 2 },
    shadowOpacity: 1,
    shadowRadius: 8,
    marginTop: 5,
    marginBottom: 5
  },
  checkboxContainer: {
    flexDirection: 'row',
    alignItems: 'center',
    padding: 10,
  },
  checkboxWrapper: {
    width: 20,
    height: 20,
    borderWidth: 1,
    borderColor: '#dddddd',
    backgroundColor: '#dddddd',
    padding: 2,
    marginRight: 10,
    borderRadius: 3,
  },
  checkbox: {
    flex: 1,
    backgroundColor: '#1183d2',
    borderRadius: 3,
  },
  label: {
    fontSize: 16,
  },
});
export default SearchFengShuiScreen;