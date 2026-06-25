import React, { useContext, useState } from 'react';
import { argonTheme } from '../constants';
import * as Clipboard from 'expo-clipboard';

import {
  responsiveHeight,
  responsiveWidth,
  responsiveFontSize
} from "react-native-responsive-dimensions";
import Ionicons from 'react-native-vector-icons/Ionicons';
import {
  StyleSheet,
  StatusBar,
  View,
  TouchableOpacity,
  SafeAreaView,
  Text,
  ScrollView,
  TextInput,
  ToastAndroid

} from "react-native";
import Config from '../constants/Config';
import { AuthContext } from '../context/AuthContext';
import { EscrowWalletContext } from '../context/EscrowWalletContext';

const ConvertCurrency = (numberString) => {
  const formattedNumber = parseInt(numberString, 10).toLocaleString('vi-VN', {
    style: 'currency',
    currency: 'VND',
  });
  const convertedNumber = formattedNumber.replace('₫', 'VND');
  return convertedNumber;
}

const ConvertCurrencyNumber = (numberString) => {
  if (isNaN(parseInt(numberString))) {
      return "";
  }
  else {
      const number = parseInt(numberString.replace(/\D/g, ''), 10);
      const formattedNumber = number.toLocaleString('vi-VN');
      return formattedNumber;
  }

};
const ReverseCurrencyNumber = (formattedNumber) => {
  const numberString = formattedNumber.replace(/\D/g, '');
  const number = parseInt(numberString, 10);
  return number.toString();
};



const EscrowWalletPopScreen = (props) => {
  const { userInfos } = useContext(AuthContext);
  const {moneyEscrowData} = useContext(EscrowWalletContext);
  const {PushPopEscrow} = useContext(EscrowWalletContext);

  const ExitButton = () => {
    return (
      // Nút Thoát
      <TouchableOpacity className="p-1 rounded-full bg-white mx-1 "
        onPress={() => {
          props.navigation.closeDrawer();
        }}>
        <Ionicons name="chevron-back-outline" color="black" size={26}></Ionicons>
      </TouchableOpacity>
    );
  }
  const Title = () => {
    return (
      <View className="flex-1 items-center justify-center">
        <Text style={{ color: "white", fontWeight: "bold", fontSize: responsiveFontSize(2.2) }}>Rút ký quỹ</Text>
      </View>

    );
  }




  const [bankName, SetBankNameState] = useState("");
  const [bankBranch, SetBankBranchState] = useState("");
  const [bankAccountNumber, SetBankAccountNum] = useState("");
  const [bankAccountName, SetBankAccountName] = useState("");
  const [money, SetMoneyState] = useState("");

  const onChangeBankName = (text) => {
    SetBankNameState(text);
  }
  const onChangeBankBranch = (text) => {
    SetBankBranchState(text);
  }
  const onChangeBankAccountNumber = (text) => {
    SetBankAccountNum(text);
  }
  const onChangeBankAccountName = (text) => {
    SetBankAccountName(text);
  }

  const onChangeMoney = (text) => {
    SetMoneyState(ReverseCurrencyNumber(text));
  }
  const ResetInformation = () =>{
    SetBankNameState("");
    SetBankBranchState("");
    SetBankAccountNum("");
    SetBankAccountName("");
    SetMoneyState("");
  }
  const CheckInformation = async () => {
    if (bankName != "" && bankBranch != "" && bankAccountNumber != "" && bankAccountName != "" && ReverseCurrencyNumber(money)  != "") {
      if (parseInt(ReverseCurrencyNumber(money)) > parseInt(moneyEscrowData)) {
        ToastAndroid.showWithGravity(
          "Số tiền rút phải bé hơn số tiền có trong ví!",
          ToastAndroid.SHORT,
          ToastAndroid.BOTTOM
        );
      } else {
        var description = `
          NGÂN HÀNG: ${bankName},
          CHI NHÁNH: ${bankBranch},
          SỐ TÀI KHOẢN: ${bankAccountNumber},
          TÊN TÀI KHOẢN: ${bankAccountName.toUpperCase()},
          SỐ TIỀN: ${ConvertCurrency(ReverseCurrencyNumber(money))},
          NỘI DUNG: ${`RKQ ${userInfos.username}`},
        `;
        var result = await PushPopEscrow(false, parseInt(ReverseCurrencyNumber(money)), description, "RÚT TIỀN");
    
        if (result) {
          ResetInformation();
          props.navigation.closeDrawer();
        } else {
    
        }
      }
    
    }
    else {
      const missingFields = [];

      if (bankName === "") {
        missingFields.push("Ngân hàng");
      }
      if (bankBranch === "") {
        missingFields.push("Chi nhánh");
      }

      if (bankAccountNumber === "") {
        missingFields.push("Số tài khoản");
      }

      if (bankAccountName === "") {
        missingFields.push("Tên tài khoản");
      }
      if (ReverseCurrencyNumber(money) === "") {
        missingFields.push("Số tiền");
      }

      if (missingFields.length === 0) {

      }
      else if (missingFields.length === 5) {
          ToastAndroid.showWithGravity(
              "Vui lòng kiểm tra Thông Tin!",
              ToastAndroid.SHORT,
              ToastAndroid.BOTTOM,
          );
      } else {
          ToastAndroid.showWithGravity(
              "Vui lòng kiểm tra " + missingFields.join(", ") + " !",
              ToastAndroid.SHORT,
              ToastAndroid.BOTTOM,
          );
      }

    }
  }
  return (
    <SafeAreaView style={{}}>

      <View className="flex-row p-2" style={{ zIndex: 1000, marginTop: StatusBar.currentHeight }} backgroundColor={argonTheme.COLORS.ERROR}>
        <ExitButton />
        <Title />
      </View>

      <ScrollView className="mx-2" style={{ marginBottom: responsiveHeight(10) }}>
        <View >
          <View style={styles2.card2}>
            <Text style={styles2.nameText}>{userInfos.fullName.toUpperCase()}</Text>
            <Text style={styles2.moneyText}>{`${ConvertCurrency(moneyEscrowData)}`}</Text>
          </View>
          <Text style={styles2.cardContentText}>Ngân hàng</Text>
          <View style={styles.Inputcontainer}>
            <TextInput
              style={styles.input}
              autoFocus
              placeholder="Nhập ngân hàng"
              placeholderTextColor="#888"

              value={bankName}
              onChangeText={onChangeBankName}


            />

          </View>
          <Text style={styles2.cardContentText}>Chi nhánh</Text>
          <View style={styles.Inputcontainer}>
            <TextInput
              style={styles.input}

              placeholder="Nhập chi nhánh"
              placeholderTextColor="#888"

              value={bankBranch}
              onChangeText={onChangeBankBranch}


            />

          </View>

          <Text style={styles2.cardContentText}>Số tài khoản</Text>
          <View style={styles.Inputcontainer}>
            <TextInput
              style={styles.input}

              placeholder="Nhập số tài khoản"
              placeholderTextColor="#888"

              value={bankAccountNumber}
              onChangeText={onChangeBankAccountNumber}


            />

          </View>
          <Text style={styles2.cardContentText}>Tên tài khoản</Text>
          <View style={styles.Inputcontainer}>
            <TextInput
              style={styles.input}

              placeholder="Nhập tên tài khoản"
              placeholderTextColor="#888"

              value={bankAccountName}
              onChangeText={onChangeBankAccountName}


            />

          </View>

          <Text style={styles2.cardContentText}>Số tiền</Text>
          <View style={styles.Inputcontainer}>
            <TextInput
              style={styles.input}

              placeholder="Nhập số tiền"
              placeholderTextColor="#888"
              keyboardType='numeric'
              value={ConvertCurrencyNumber(money)}
              onChangeText={onChangeMoney}


            />

          </View>

          <TouchableOpacity activeOpacity={.9}

            style={styles2.orderButton}
            onPress={() => {

              CheckInformation();
            }}
          >
            <Text style={{}}>
              <Ionicons name="download-outline" color="white" size={15}></Ionicons>
              <Text style={{ color: "white", fontWeight: "bold" }} >
                {` RÚT TIỀN`}

              </Text>
            </Text>

          </TouchableOpacity>

        </View>
      </ScrollView>

    </SafeAreaView>
  )


}

const styles2 = StyleSheet.create({

  card: {
    backgroundColor: '#e6e6e6',
    marginRight: 1,
    marginLeft: 1,
    marginTop: 5,
    marginBottom: 5,
    padding: 10,
    borderRadius: 5,
  },
  card2: {
    backgroundColor: 'white',
    shadowColor: 'black',
    shadowOffset: { width: 1, height: 1 },
    shadowOpacity: 1,
    shadowRadius: 4,
    marginRight: 1,
    marginLeft: 1,
    marginTop: 15,
    marginBottom: 5,
    padding: 12,
    elevation: 5,
    borderRadius: 5,
  },

  card3: {
    backgroundColor: 'white',
    shadowColor: 'black',
    shadowOffset: { width: 1, height: 1 },
    shadowOpacity: 1,
    shadowRadius: 4,
    marginRight: 1,
    marginLeft: 1,
    marginTop: 5,
    marginBottom: 5,
    padding: 10,
    elevation: 5,
    borderRadius: 5,
  },
  nameText: {
    fontSize: responsiveFontSize(1.8),
  },
  moneyText: {
    fontSize: responsiveFontSize(2.2),
    fontWeight: "bold",
  },
  cardRow: {
    flexDirection: "row"
  },
  cardHeader: {
    width: "40%",
  },

  cardContent: {
    flex: 1,
  },
  cardHeaderText: {
    fontSize: responsiveFontSize(2)
  },
  cardContentText: {
    fontWeight: "bold",
    fontSize: responsiveFontSize(2),
    textAlign: "left",
    alignItems: "flex-start"
  },
  manualText: {
    fontSize: responsiveFontSize(2),
    textAlign: "justify",
  },
  manualTextNotice: {
    fontSize: responsiveFontSize(2),
    textAlign: "justify",
    color: argonTheme.COLORS.ERROR,
    fontWeight: "bold"
  }
  ,
  orderButton: {
    borderRadius: 10,
    flexDirection: "row",
    alignContent: "center",
    justifyContent: "center",
    borderColor: 'grey',
    padding: 10,
    alignItems: "center",
    backgroundColor: argonTheme.COLORS.ERROR,
    marginTop: 10,

  },
});

const styles = StyleSheet.create({
  Inputcontainer: {
    marginTop: 5,
    marginBottom: 5,
    flexDirection: 'row',
    borderRadius: 5,
    borderWidth: 1,
    borderColor: '#ccc',
    backgroundColor: 'white'
  },
  container: {
    backgroundColor: 'black',
  },
  overview: {
    height: 'auto',
    borderRadius: 3,
    padding: 10,
    margin: 4,
    shadowOpacity: .1,
    shadowRadius: 3,
    elevation: 1,

    shadowColor: 'black',

  },
  textRow: {
    textAlign: "auto",
  },
  textHeader: {
    fontWeight: "bold",
    fontSize: responsiveFontSize(2.2),
  },
  texSubHeader: {
    fontWeight: "bold",
    fontSize: responsiveFontSize(2),
    color: argonTheme.COLORS.ERROR,
  },
  findSim: {
    fontWeight: "bold",
    fontSize: responsiveFontSize(2.4),
    color: argonTheme.COLORS.ERROR,
  },
  emphasizTxt: {
    fontWeight: "bold",
    fontSize: responsiveFontSize(2.1),
    marginLeft: 5,
    marginRight: 5,
  },
  textContent: {
    textAlign: "justify",
    marginLeft: 5,
    marginRight: 5,
    fontSize: responsiveFontSize(2.1)
  },
  textParentContent: {
    textAlign: "justify",
    fontSize: responsiveFontSize(2.1)
  },
  cellTableTxt: {
    textAlign: "justify",
    fontSize: responsiveFontSize(1.9)
  },
  cellTable: {
    borderWidth: 1,
    borderColor: 'black',
    flex: 1,
    alignItems: "center",
    width: 100,
  },
  point: {
    alignItems: "center",
    flex: 1,
    backgroundColor: argonTheme.COLORS.ERROR,
    width: "auto",
    margin: 1,
    marginTop: 20,
    marginBottom: 20,
    padding: 15,
    borderRadius: 10

  },
  pointTxt: {
    color: "white",
    fontWeight: "bold",
    fontSize: responsiveFontSize(2.2)
  },
  improveSim: {
    alignItems: "center",
    flex: 1,
    backgroundColor: argonTheme.COLORS.ERROR,
    width: "auto",
    margin: 1,
    padding: 15,
    borderRadius: 10
  },
  bottomSim: {
    flexDirection: "row",
    width: "100%",
    alignItems: "center",
    padding: 5,
    margin: 5,


    justifyContent: "center",
  },
  buttonSim: {
    backgroundColor: "white",
    padding: 5,
    margin: 5,
    borderRadius: 5,
  },
  input: {
    flex: 1,
    paddingVertical: 8,
    paddingHorizontal: 10,
    color: '#333',
    height: 35,
  },
  button: {
    backgroundColor: argonTheme.COLORS.ERROR,
    borderTopRightRadius: 5,
    borderBottomRightRadius: 5,
    paddingVertical: 8,
    paddingHorizontal: 12,
    marginLeft: 'auto',
    height: 35,
    alignItems: 'flex-end',
  },
});

export default EscrowWalletPopScreen;