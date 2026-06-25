import React, { createContext, useState, useContext } from "react";
import axios from "axios";
import Config from "../constants/Config";
import { AuthContext } from "./AuthContext";
import { SetLoadingContext } from "./SetLoadingContext";

const DataPackageContext = createContext();
const DataPackageProvider = ({ children }) => {

    const { userToken } = useContext(AuthContext);
    const { SetLoading } = useContext(SetLoadingContext);
    //
    const [simDataPackages, SetSimDataPackageState] = useState(null);
    const GetSimDataPackage = () => {
        SetLoading(true);
        axios.get(Config.BASE_URL + '/api/sim/get-data-sim',
            {
                headers: {
                    Accept: 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + userToken
                },
            }).then((response) => {
                SetSimDataPackageState(response.data);
                SetLoading(false);
                return true;
            }).catch((error) => {
                console.error('GetSimDataPackage Err: ', error);
                SetSimDataPackageState(null);
                SetLoading(false);
                return false;
            });
    }

    //

    return (
        <DataPackageContext.Provider value={{
            GetSimDataPackage, simDataPackages
        }}>
            {children}
        </DataPackageContext.Provider>
    );
}

export { DataPackageContext, DataPackageProvider }