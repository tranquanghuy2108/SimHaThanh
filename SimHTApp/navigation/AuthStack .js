import React from 'react';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import { NavigationContainer } from "@react-navigation/native";
import LoginScreen from '../screens/LoginScreen';
import RegisterScreen from '../screens/RegisterScreen';
import { AppConst } from '../constants/AppConst';

const Stack = createNativeStackNavigator();

export default function AuthStack() {
  return (
    <NavigationContainer>
      <Stack.Navigator initialRouteName={AppConst.ScreenConst.LOGIN_SCREEN} screenOptions={{ headerShown: false }}>
        <Stack.Screen name={AppConst.ScreenConst.LOGIN_SCREEN} component={LoginScreen} />
        <Stack.Screen name={AppConst.ScreenConst.REGISTER_SCEEN} component={RegisterScreen} />
      </Stack.Navigator>
    </NavigationContainer>

  );
}
