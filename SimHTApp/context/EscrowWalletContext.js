
import React, { createContext, useState, useContext } from "react";
import axios from "axios";
import Config from "../constants/Config";
import { AuthContext } from "./AuthContext";
import { SetLoadingContext } from "./SetLoadingContext";
import {
    ToastAndroid
} from "react-native";
import { AppConst } from "../constants/AppConst";
const EscrowWalletContext = createContext();

const EscrowWalletProvider = ({ children }) => {

    const { userToken, userInfos } = useContext(AuthContext)
    const { SetLoading } = useContext(SetLoadingContext);

    const [moneyEscrowData, SetMoneyEscrowState] = useState(0);

    const [escrowHistoryData, SetEscrowHistoryState] = useState([]);

    //GetMoneyEscrow
    const GetMoneyEscrow = () => {
 
        axios.post(Config.BASE_URL + '/api/CashBook/tien-trong-quy',
            userInfos.id
            ,
            {
                headers: {
                    Accept: 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + userToken
                },
            }).then((response) => {
                SetMoneyEscrowState(response.data);
                SetLoading(false);
                return true;

            }).catch((error) => {
                SetMoneyEscrowState(null);
                SetLoading(false);
                return false;
            });
    }
    //Get Escrow History 
    const GetEcrowHistory = async  (cashActionType) => {
      try {
        const response = await axios.post(
          Config.BASE_URL + '/api/CashBook/get-ki-quy',
          {
            cashActionType: cashActionType,
            userId: userInfos.id
          },
          {
            headers: {
              Accept: 'application/json',
              'Content-Type': 'application/json',
              Authorization: 'Bearer ' + userToken
            }
          }
        );
        SetEscrowHistoryState(response.data);
        SetLoading(false);
        return false;
      } catch (error) {
        SetEscrowHistoryState([]);
        SetLoading(false);
        return false;
      }
    }


    //GetMoneyEscrow
    const PushPopEscrow = async (isPush, money, description, note) => {
        try {
          SetLoading(true);
          var currentTime = new Date();
      
          const response = await axios.post(
            Config.BASE_URL + '/api/CashBook/ki-quy',
            {
              "id": 0,
              "userId": userInfos.id,
              "cashActionType": isPush ? AppConst.CashType.PUSH_ESCROW_MONEY : AppConst.CashType.POP_ESCROW_MONEY,
              "onApp": true,
              "receivables": isPush ? money : 0,
              "liabilities": isPush ? 0 : money,
              "description": description,
              "note": note,
              "approvedStatus": 5,
              "approvedBy": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
              "approvedTime": "2024-05-02T04:02:15.489Z",
              "createBy": userInfos.id,
              "createTime": currentTime,
            },
            {
              headers: {
                Accept: 'application/json',
                'Content-Type': 'application/json',
                'Authorization': 'Bearer ' + userToken
              },
            }
          );
            
          if (response.data.code === "1") {
            ToastAndroid.showWithGravity(
              response.data.message,
              ToastAndroid.SHORT,
              ToastAndroid.BOTTOM
            );
            SetLoading(false);
            return true;
          } else {
            ToastAndroid.showWithGravity(
              `Thao tác thất bại. ${response.data.message}`,
              ToastAndroid.SHORT,
              ToastAndroid.BOTTOM
            );
            SetLoading(false);
            return false;
          }
        } catch (error) {
          ToastAndroid.showWithGravity(
            `Thao tác thất bại!`,
            ToastAndroid.SHORT,
            ToastAndroid.BOTTOM
          );
          SetLoading(false);
          return false;
        }
      };
    return (
        <EscrowWalletContext.Provider value={{
            moneyEscrowData,escrowHistoryData
            ,
            GetMoneyEscrow, PushPopEscrow,GetEcrowHistory
        }}>
            {children}
        </EscrowWalletContext.Provider>
    );
}

export { EscrowWalletContext, EscrowWalletProvider }