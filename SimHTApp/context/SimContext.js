
import React, { createContext, useState, useContext } from "react";
import axios from "axios";
import Config from "../constants/Config";
import { AuthContext } from "./AuthContext";
import { SetLoadingContext } from "./SetLoadingContext";
import {
  ToastAndroid
} from "react-native";
const SimContext = createContext();

const SimProvider = ({ children }) => {

  const { userToken, userInfos } = useContext(AuthContext)
  const { SetLoading } = useContext(SetLoadingContext);


  const [packageSimDatas,SetPackageSimState] = useState([]);


  const GetPackageSimData = () => {
    SetLoading(true);
    axios.get(Config.BASE_URL + '/api/sim/package-of-sim-data',
      {
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json',
          'Authorization': 'Bearer ' + userToken
        },
      }).then((response) => {
        SetPackageSimState(response.data);
        SetLoading(false);
        return true;
      }).catch((error) => {
        console.error('Error: ', error);
        SetPackageSimState([])
        SetLoading(false);
        return false;
      });
  }






  return (
    <SimContext.Provider value={{

        packageSimDatas,GetPackageSimData,
    }}>
      {children}
    </SimContext.Provider>
  );



}

export { SimContext, SimProvider }