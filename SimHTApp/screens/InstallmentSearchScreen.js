import React, { useState, useContext, useRef, useEffect } from 'react';
import { TouchableOpacity, Text, Image, View, TextInput, StyleSheet, SafeAreaView, ToastAndroid } from 'react-native';
import DateTimePicker from '@react-native-community/datetimepicker';
import { AppConst } from '../constants/AppConst';
import Ionicons from 'react-native-vector-icons/Ionicons';
import { argonTheme } from '../constants';
import { FengShuiContext } from '../context/FengShuiContext';
import { responsiveFontSize } from 'react-native-responsive-dimensions';
import { Dropdown } from 'react-native-element-dropdown';
import { addMonths, differenceInDays, isAfter } from 'date-fns';
import { InstallmentContext } from '../context/InstallmentContext';

const BorrowTimeDatas = [
  {
    "id": 1,
    "name": "1 Tháng",
    "value": 1
  },
  {
    "id": 2,
    "name": "2 Tháng",
    "value": 2
  },
  {
    "id": 3,
    "name": "3 Tháng",
    "value": 3
  },
  {
    "id": 6,
    "name": "6 Tháng",
    "value": 6
  },
  {
    "id": 12,
    "name": "12 Tháng",
    "value": 12
  },
]
const ConvertCurrency = (numberString) => {
  if(isNaN(parseInt(numberString))){
    return "0 VND";
  }
  else{
    const formattedNumber = parseInt(numberString, 10).toLocaleString('vi-VN', {
      style: 'currency',
      currency: 'VND',
  });
  const convertedNumber = formattedNumber.replace('₫', 'VND');
  return convertedNumber;
  }

}
const ConvertCurrencyNumber = (numberString) => {
  if(isNaN(parseInt(numberString))){
    return "";
  }
  else
  {
    const number = parseInt(numberString.replace(/\D/g, ''), 10);
    const formattedNumber = number.toLocaleString('vi-VN');
    return formattedNumber;
  }
 
};
const ReverseConvertCurrencyNumber = (formattedNumber) => {
  const numberString = formattedNumber.replace(/\D/g, '');
  const number = parseInt(numberString, 10);
  return number.toString();
};

const InstallmentSearchScreen = ({ navigation }) => {

  const [simPrice, SetSimPriceState] = useState("");
  const [borrowTime, SetBorrowTimeState] = useState(1);
  const [isFocus, setIsFocus] = useState(false);
  const [payFirst, SetPayFirstState] = useState("");
  const [payAfter, SetPayAfterState] = useState("");

  const [payMonth, SetPayMonthState] = useState("");

  const PriceSimChange = (text) => {
   
    SetSimPriceState(ReverseConvertCurrencyNumber(text));


  }

  const {installmentConfig,} = useContext(InstallmentContext);

  useEffect(() => {
    if (installmentConfig != null) {
      var firstPay = (installmentConfig.installment_MinimumPaymentRate / 100) * parseInt(simPrice);
      var afterPay = parseInt(simPrice) - firstPay;
      if (!isNaN(firstPay) && !isNaN(afterPay)) {
        SetPayFirstState(firstPay.toString());
        SetPayAfterState(afterPay.toString());
      }

      const currentDate = new Date(); // Lấy ngày hiện tại
      // Tính ngày cần tính

      const targetDate = addMonths(currentDate, borrowTime);

      // Kiểm tra nếu targetDate nằm sau ngày hiện tại
      if (isAfter(targetDate, currentDate)) {
        // Tính số ngày
        const dayDiff = differenceInDays(targetDate, currentDate);
        console.log(dayDiff);
        var interestRate = installmentConfig.installment_DailyInterestRate; //Lãi suất tính trên 1 triệu
        var monthPay = (afterPay / parseInt(borrowTime)) + (((afterPay /1000000)*interestRate ) * (dayDiff/parseInt(borrowTime)));

        if (!isNaN(monthPay)) {
          SetPayMonthState(monthPay.toString());
        }


      }

    }


  }, [simPrice, borrowTime])



  const isValidPhoneNumber = (simPrice) => {
    // Loại bỏ các ký tự không phải số (nếu có)
    const sanitizedNumber = simPrice.replace(/\D/g, '');

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
          <Text style={styles.headerText}>Giá Trị Sim</Text>
          <View style={styles.inputContainer} >
            {/* <View style={styles.iconContainer}>
              <Image source={require('../assets/imgs/icon_mobile.png')} style={{ width: 17, height: 17 }} resizeMode='contain' />
            </View> */}
            <TextInput
              style={styles.input}
              placeholder="Nhập Giá Trị Sim"
              keyboardType='numeric'
              placeholderTextColor="#888"
              value={ConvertCurrencyNumber(simPrice)}
              onChangeText={PriceSimChange}

            />
          </View>


          <Text style={styles.headerText}>% Trả Trước</Text>
          <View style={styles.inputContainer} >
            {/* <View style={styles.iconContainer}>
              <Image source={require('../assets/imgs/icon_mobile.png')} style={{ width: 17, height: 17 }} resizeMode='contain' />
            </View> */}
            <TextInput
              style={styles.input}
              placeholder=""
              keyboardType='numeric'
              placeholderTextColor="#888"
              value={installmentConfig.installment_MinimumPaymentRate.toString()}
              editable={false}


            />
          </View>

          <Text style={styles.headerText}>Tiền Trả Trước</Text>
          <View style={styles.inputContainer} >
            {/* <View style={styles.iconContainer}>
              <Image source={require('../assets/imgs/icon_mobile.png')} style={{ width: 17, height: 17 }} resizeMode='contain' />
            </View> */}
            <TextInput
              style={styles.input}
              placeholder=""
              keyboardType='numeric'
              placeholderTextColor="#888"
              value={ConvertCurrency(payFirst)}
              editable={false}
              onChangeText={PriceSimChange}

            />
          </View>
          <Text style={styles.headerText}>Tiền Trả Góp</Text>
          <View style={styles.inputContainer} >
            {/* <View style={styles.iconContainer}>
              <Image source={require('../assets/imgs/icon_mobile.png')} style={{ width: 17, height: 17 }} resizeMode='contain' />
            </View> */}
            <TextInput
              style={styles.input}
              placeholder=""
              keyboardType='numeric'
              placeholderTextColor="#888"
              editable={false}
              value={ConvertCurrency(payAfter)}
              onChangeText={PriceSimChange}

            />
          </View>
          <Text style={styles.headerText}>Thời Hạn Trả Góp</Text>
          <Dropdown
            style={[styles5.dropdown, isFocus && { borderColor: 'green' }]}
            placeholderStyle={styles5.placeholderStyle}
            selectedTextStyle={styles5.selectedTextStyle}
            inputSearchStyle={styles5.inputSearchStyle}
            iconStyle={styles5.iconStyle}
            data={BorrowTimeDatas}

            maxHeight={300}
            labelField="name"
            valueField="id"

            value={borrowTime}
            onFocus={() => setIsFocus(true)}
            onBlur={() => setIsFocus(false)}
            onChange={item => {
              // setValue(item.id);
              SetBorrowTimeState(item.value);
              console.log("VAlue la:" + item.id);
              setIsFocus(false);
            }}

          />

          <Text style={styles.headerText}>Lãi suất (tính cho 1tr/1 ngày)</Text>
          <View style={styles.inputContainer} >
            {/* <View style={styles.iconContainer}>
              <Image source={require('../assets/imgs/icon_mobile.png')} style={{ width: 17, height: 17 }} resizeMode='contain' />
            </View> */}
            <TextInput
              style={styles.input}
              placeholder=""
              keyboardType='numeric'
              placeholderTextColor="#888"
              value={ConvertCurrency(installmentConfig.installment_DailyInterestRate)}
              editable={false}


            />
          </View>

          <View style={{ borderWidth: 1, width: '100%', marginTop: 10, marginBottom: 10 }}>

          </View>

          <Text style={styles.headerText}>Số Tiền Phải Trả Hàng Tháng</Text>
          <View style={styles.inputContainer} >
            <TextInput
              style={styles.input}
              placeholder=""
              keyboardType='numeric'
              placeholderTextColor="#888"
              editable={false}
              value={ConvertCurrency(payMonth)}
              onChangeText={PriceSimChange}

            />
          </View>

        </View>

      </View>
    </SafeAreaView>
  )
}
const styles = StyleSheet.create({
  headerText: {
    fontWeight: "bold",
    fontSize: responsiveFontSize(2)
  },
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

const styles5 = StyleSheet.create({
  container: {
    backgroundColor: 'white',
    padding: 16,
  },
  dropdown: {
    height: 50,
    borderColor: 'gray',
    borderWidth: 0.5,
    borderRadius: 8,
    paddingHorizontal: 8,
  },
  icon: {
    marginRight: 5,
  },
  label: {
    position: 'absolute',
    backgroundColor: 'white',
    left: 22,
    top: 8,
    zIndex: 999,
    paddingHorizontal: 8,
    fontSize: 14,
  },
  placeholderStyle: {
    fontSize: 16,
  },
  selectedTextStyle: {
    fontSize: 16,
  },
  iconStyle: {
    width: 20,
    height: 20,
  },
  inputSearchStyle: {
    height: 40,
    fontSize: 16,
  },
});
export default InstallmentSearchScreen;