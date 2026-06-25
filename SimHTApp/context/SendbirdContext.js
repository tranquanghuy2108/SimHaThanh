
import React, { createContext, useState, useContext } from "react";
import axios from "axios";
import Config from "../constants/Config";
import { AuthContext } from "./AuthContext";
import { SetLoadingContext } from "./SetLoadingContext";
import SendBird, { UserEventHandler } from 'sendbird';
import { Alert } from "react-native";

import { BottomTabContext } from "./BottomTabContext";
const SendBirdContext = createContext();

const SendBirdProvider = ({ children }) => {

  const { userToken, userInfos } = useContext(AuthContext)
  const { SetLoading } = useContext(SetLoadingContext);
  const [unReadMessageCount, SetUnReadMessageState] = useState(0);

  const UpdateProfileSendBird = async (newName) => {
    
    try {
      const response = await axios.put(Config.SENDBIRD_URL + `/users/${userInfos.id}`, 
      {
        nickname:newName
      }
      ,
      {
        headers: {
          Accept: 'application/json',
          'Api-Token': Config.SEND_BIRD_API_TOKEN,
        },
      });
      SetLoading(false);
      return true;
    } catch (error) {
      console.error("Update userInfo Sendbird Failed: ",error);
      return false;
    }
  };
  const RegisterChatReceiver = async () => {
    const sb = new SendBird({ appId: Config.SEND_BIRD_APP_ID });

    // Kết nối tới Sendbird
    sb.connect(userInfos.id, (user, error) => {
      if (error) {
        console.error('Failed to connect to Sendbird:', error);
      } else {
        console.log('Connected to Sendbird');
      }
    });
  }
  //
  const GetUnreadMessageCount = async () => {
    try {
      const response = await axios.get(Config.SENDBIRD_URL + `/users/${userInfos.id}/unread_message_count`, {
        headers: {
          Accept: 'application/json',
          'Api-Token': Config.SEND_BIRD_API_TOKEN,
        },
      });

      var unReadValue = response.data.unread_count;
      SetUnReadMessageState(unReadValue);
      SetLoading(false);
      return true;
    } catch (error) {
      console.error('Error getting unread messages: ', error);
      SetLoading(false);
      return false;
    }
  };

  //
  return (
    <SendBirdContext.Provider value={{
      GetUnreadMessageCount, RegisterChatReceiver, UpdateProfileSendBird,
      unReadMessageCount
    }}>
      {children}
    </SendBirdContext.Provider>
  );
}

export { SendBirdContext, SendBirdProvider }