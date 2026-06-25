import React, { useContext, useEffect, useState } from 'react';
import { AuthContext } from '../context/AuthContext';
import { ActivityIndicator, View } from 'react-native';
import AuthStack from './AuthStack ';
import AppStack from './AppStack';
import AsyncStorage from '@react-native-async-storage/async-storage';
export default function AppNav() {
  const { userInfos,SetUserInfoByStorage ,SetUserTokenByStorage } = useContext(AuthContext);
  const [isCheckComplete, SetCheckComplete] = useState(false);

  const checkLoginStatus = async () => {
    try {
      const storedUserInfo = await AsyncStorage.getItem("UserInfo");
      const storedUserToken = await AsyncStorage.getItem("UserToken");
      if (storedUserInfo!=null && storedUserToken!=null) {
        SetUserInfoByStorage(JSON.parse(storedUserInfo));
        SetUserTokenByStorage(JSON.parse(storedUserToken));
        SetCheckComplete(true);
      } else {

        SetCheckComplete(true);
      }
    } catch (error) {
      SetCheckComplete(true);
    }
  };

  useEffect(()=>{
    checkLoginStatus();
  },[])

  return (
    isCheckComplete ? 
      (userInfos !== null ? <AppStack /> : <AuthStack />) :
      
      (
        <View style={{ flex: 1, justifyContent: 'center', alignItems: 'center' }}>
          <ActivityIndicator size={'large'} />
        </View>
      )
  );
}