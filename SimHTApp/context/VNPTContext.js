import React, { createContext, useState, useContext } from "react";
import axios from "axios";
import Config from "../constants/Config";
import { AuthContext } from "./AuthContext";
import { SetLoadingContext } from "./SetLoadingContext";

const VNPTContext = createContext();
const VNPTProvider = ({ children }) => {

    const { userToken } = useContext(AuthContext);
    const { SetLoading } = useContext(SetLoadingContext);
    //

    const [vinaPackageDatas, SetVinaPackageState] = useState(null);


    const GetPackageOfSim = (phoneNumber) => {
        SetLoading(true);
        axios.post(Config.BASE_URL + '/api/vnpt/cac-goi-cho-thue-bao-vnpt',
            phoneNumber
            ,
            {
                headers: {
                    Accept: 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + userToken
                },
            }).then((response) => {
                SetVinaPackageState(response.data);
                SetLoading(false);
                return true;
            }).catch((error) => {
                console.error('Error: ', error);
                SetVinaPackageState(null);
                SetLoading(false);
                return false;
            });
    }
    return (
        <VNPTContext.Provider value={{
            GetPackageOfSim, vinaPackageDatas

        }}>
            {children}
        </VNPTContext.Provider>
    );
}

export { VNPTContext, VNPTProvider }