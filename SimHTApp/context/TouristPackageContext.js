import React, { createContext, useState, useContext } from "react";
import axios from "axios";
import Config from "../constants/Config";
import { AuthContext } from "./AuthContext";
import { SetLoadingContext } from "./SetLoadingContext";

const TouristPackageContext = createContext();
const TouristPackageProvider = ({ children }) => {

    const { userToken } = useContext(AuthContext);
    const { SetLoading } = useContext(SetLoadingContext);
    //
    const [simTouristPackages, SetSimTouristPackageState] = useState(null);
    const GetSimTouristPackage = () => {
        SetLoading(true);
        axios.get(Config.BASE_URL + '/api/sim/get-tourist-sim',
            {
                headers: {
                    Accept: 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + userToken
                },
            }).then((response) => {
                SetSimTouristPackageState(response.data);
                SetLoading(false);
                return true;
            }).catch((error) => {
                console.error('GetSimTouristPackage Err: ', error);
                SetSimTouristPackageState(null);
                SetLoading(false);
                return false;
            });
    }

    //

    return (
        <TouristPackageContext.Provider value={{
            GetSimTouristPackage, simTouristPackages
        }}>
            {children}
        </TouristPackageContext.Provider>
    );
}

export { TouristPackageContext, TouristPackageProvider }