
import React, { createContext, useState,useContext } from "react";
import axios from "axios";
import Config from "../constants/Config";
import { AuthContext } from "./AuthContext";

import { SetLoadingContext } from "./SetLoadingContext";
import { Alert } from "react-native";
const OrderContext = createContext();

const OrderProvider = ({children})=>
{

    const {userToken,userInfos} = useContext(AuthContext);
    const [orderDatas,GetAllOrderDatas] = useState(null);
    const [orderSimDatas,GetOrderSimDatas] = useState(null);
    const {SetLoading} = useContext(SetLoadingContext);

    const CreateOrder = (payMode,simID,simPrice,discount,name,phoneNumber,address,note, orderPrice, installmentPeriod,dateOfPayment, endDateInstallment,downPayment,totalInstallPayment,monthlyInstallmentPayment, interestRate) => { 
        axios.post(Config.BASE_URL+'/api/sim/create-order', 
        {
              "id": 0,
              "userId": userInfos.id,
              "simIds": simID,
              "priceOrder": orderPrice,
              "priceOfSim": simPrice,
              "discount": discount,
              "simEmbryoFee": 0,
              "simServiceFee": 0,
              "name": name,
              "phoneNum": phoneNumber,
              "userBuyId": userInfos.id,
              "address": address,
              "pic": "c09b6c9b-3405-4abb-b39f-2faa705226d8",
              "note": note,
              "status": 0,
              "paymentType": payMode,
              "updateBy": userInfos.id,
              "installmentPeriod": installmentPeriod,
              "dateOfPayment": dateOfPayment,
              "installmentEndDate": endDateInstallment,
              "downPayment": downPayment,
              "installmentPayment": totalInstallPayment,
              "monthlyInstallmentPayment": monthlyInstallmentPayment,
              "interestRate": interestRate
        },
        {
          headers: {
            Accept: 'application/json',
            'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + userToken
          },
        }).then((response) => {
          GetAllOrder();
          Alert.alert(
            'Mua hàng thành công',
            'Cảm ơn bạn đã mua hàng!',
            [
              { text: 'OK', onPress: () => console.log('Đóng thông báo') }
            ],
            { cancelable: false }
          );
          SetLoading(false);
          return true;
        }).catch((error) => { 
          Alert.alert(
            'Mua hàng thất bại',
            'Có lỗi xảy ra. Vui lòng thử lại!',
            [
              { text: 'OK', onPress: () => console.log('Đóng thông báo') }
            ],
            { cancelable: false }
          );
          console.error("CreateSimDataOrder Err: " + error);
          SetLoading(false);
          return false;
        });
      }
      
    const CreateSimDataOrder = (productTypeId, amount, buyEsim, name, phoneNumber, address, note, orderPrice, payMode) => { 
      
      console.log("Mua sim data buyEsim " + buyEsim);
      axios.post(Config.BASE_URL+'/api/sim/create-simdata-order', 
      {
            "productTypeId": productTypeId,
            "priceOrder": orderPrice,
            "userBuyId": userInfos.id,
            "cusName": name,
            "cusPhone": phoneNumber,
            "cusAddress": address,
            "cusProvince": "",
            "amount": amount,
            "buyEsim": buyEsim,
            "cusNote": note,
            "paymentMethod": payMode
      },
      {
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json',
          'Authorization': 'Bearer ' + userToken
        },
      }).then((response) => {
        GetAllOrder();
        Alert.alert(
          'Thông báo',
          response.data.message,
          [
            { text: 'OK', onPress: () => console.log('Đóng thông báo') }
          ],
          { cancelable: false }
        );
        SetLoading(false);
        return true;
      }).catch((error) => { 
        Alert.alert(
          'Mua hàng thất bại',
          'Có lỗi xảy ra. Vui lòng thử lại!',
          [
            { text: 'OK', onPress: () => console.log('Đóng thông báo') }
          ],
          { cancelable: false }
        );
        console.error("CreateSimDataOrder Err: " + error);
        SetLoading(false);
        return false;
      });
    }

      const GetAllOrder = () => { 
        SetLoading(true);
        axios.post(Config.BASE_URL+'/api/sim/all-orders-list', 
          userInfos.id
        ,
        {
          headers: {
            Accept: 'application/json',
            'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + userToken
          },
        }).then((response) => {
          GetAllOrderDatas(response.data.data);
          SetLoading(false);
          return true;
        }).catch((error) => { 
          console.error("GetAllOrder Err: " + error);
          SetLoading(false);
          return false;
        });
      }

      const CancelOrder = (orderID) => { 
        SetLoading(true);
        axios.post(Config.BASE_URL+'/api/sim/cancel-order', 
        orderID
        ,
        {
          headers: {
            Accept: 'application/json',
            'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + userToken
          },
        }).then((response) => {
          Alert.alert(
            'Hủy đơn thành công',
            'Cảm ơn bạn đã quan tâm về sản phẩm!',
            [
              { text: 'OK', onPress: () => console.log('Đóng thông báo') }
            ],
            { cancelable: false }
          );
          GetAllOrder();
          SetLoading(false);
          return true;
        }).catch((error) => { 
          Alert.alert(
            'Hủy đơn thất bại',
            'Có lỗi xảy ra. Vui lòng thử lại!',
            [
              { text: 'OK', onPress: () => console.log('Đóng thông báo') }
            ],
            { cancelable: false }
          );
          SetLoading(false);
          return false;
        });
      }

    return(
        <OrderContext.Provider value={{
            CreateOrder,CreateSimDataOrder,GetAllOrder,CancelOrder,
            orderDatas,orderSimDatas
          }}>
            {children}
        </OrderContext.Provider>
    );
}

export {OrderContext,OrderProvider}