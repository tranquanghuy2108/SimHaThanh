import React, { createContext, useState, useContext } from "react";
import axios from "axios";
import Config from "../constants/Config";
import { AuthContext } from "./AuthContext";
import { SetLoadingContext } from "./SetLoadingContext";
const InstallmentContext = createContext();

const InstallmentProvider = ({ children }) => {

  const { userInfos, userToken } = useContext(AuthContext);

  const { SetLoading } = useContext(SetLoadingContext);


 const [installmentConfig,SetInstallmentConfigState] = useState(null);

 const [installmentDatas,SetInstallmentDatas] = useState(null);

  const GetInstallmentConfig = () => {

    SetLoading(true);
    axios.post(Config.BASE_URL + '/api/tra-gop/get-installment-config',
      {

      },
      {
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json',
          'Authorization': 'Bearer ' + userToken
        },
      }).then((response) => {
        SetInstallmentConfigState(response.data);
        SetLoading(false);
        return true;
      }).catch((error) => {
        SetInstallmentConfigState(null);
        SetLoading(false);
        return false;
      });
  }

  const GetInstallmentList = ()=>{
    SetLoading(true);
    axios.post(Config.BASE_URL + `/api/tra-gop/ds-sim-tra-gop?userId=${userInfos.id}`,
      {

      },
      {
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json',
          'Authorization': 'Bearer ' + userToken
        },
      }).then((response) => {
        SetInstallmentDatas(response.data);
        SetLoading(false);
        return true;
      }).catch((error) => {
        SetInstallmentDatas(null);
        SetLoading(false);
        return false;
      });
  }
  ///
  return (
    <InstallmentContext.Provider value={{
      GetInstallmentConfig,GetInstallmentList,
      installmentConfig,installmentDatas
    }}>
      {children}
    </InstallmentContext.Provider>
  );
}

export { InstallmentContext, InstallmentProvider }