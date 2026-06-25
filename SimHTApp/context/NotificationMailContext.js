import React, { createContext, useState, useContext } from "react";
import axios from "axios";
import Config from "../constants/Config";
import { AuthContext } from "./AuthContext";
import { SetLoadingContext } from "./SetLoadingContext";


const NotificationMailContext = createContext();
const NotificationMailProvider = ({ children }) => {

    const { userInfos, userToken } = useContext(AuthContext);
    const { SetLoading } = useContext(SetLoadingContext);
    //

    const [notificationDatas, SetNotificationState] = useState(null);


    const GetMyNotifications = () => {
        axios.post(Config.BASE_URL + '/api/noti/get-my-noti',
            userInfos.id
            ,
            {
                headers: {
                    Accept: 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + userToken
                },
            }).then((response) => {
                SetNotificationState(response.data.data);
                SetLoading(false);
                return true;
            }).catch((error) => {
                SetNotificationState(null);
                SetLoading(false);
                return false;
            });
    }

    //
    const ReadNotification = (notifiID) => {
        SetLoading(true);

        axios.post(Config.BASE_URL + '/api/noti/read-noti',

            {
                "ids": notifiID === null ? []: [notifiID],
                "userId": userInfos.id
            }
            ,
            {
                headers: {
                    Accept: 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + userToken
                },
            }).then((response) => {
                GetMyNotifications();
                SetLoading(false);                
                return true;
            }).catch((error) => {
                SetLoading(false);
                return false;
            });
    }


    return (
        <NotificationMailContext.Provider value={{
            GetMyNotifications,ReadNotification,
            notificationDatas
        }}>
            {children}
        </NotificationMailContext.Provider>
    );

}

export { NotificationMailContext, NotificationMailProvider }