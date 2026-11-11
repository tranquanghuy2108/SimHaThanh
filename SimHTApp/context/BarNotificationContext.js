import React, {
  createContext,
  useCallback,
  useEffect,
  useState,
  useRef,
} from "react";
import * as Device from "expo-device";
import Constants from "expo-constants";
import { isRunningInExpoGo } from "expo";

import { Image, SafeAreaView, View, Text, Button, Platform } from "react-native";
const BarNotificationContext = createContext();
const isAndroidExpoGo = Platform.OS === "android" && isRunningInExpoGo();
const getNotificationsModule = () => require("expo-notifications");

//Expo - Notification

const BarNotificationProvider = ({ children }) => {
  const [expoPushToken, setExpoPushToken] = useState("");
  const [notification, setNotification] = useState(false);
  const notificationListener = useRef();
  const responseListener = useRef();

  const RegisterNotification = () => {
    // Expo Go on Android does not support remote push notifications from SDK 53.
    // Development and production builds still run the full registration flow below.
    if (isAndroidExpoGo) {
      return;
    }

    const Notifications = getNotificationsModule();

    Notifications.setNotificationHandler({
      handleNotification: async () => ({
        shouldShowAlert: true,
        shouldPlaySound: true,
        shouldSetBadge: true,
      }),
    });

    registerForPushNotificationsAsync().then((token) =>
      setExpoPushToken(token)
    );

    notificationListener.current =
      Notifications.addNotificationReceivedListener((notification) => {
        setNotification(notification);
      });

    responseListener.current =
      Notifications.addNotificationResponseReceivedListener((response) => {});

    return () => {
      Notifications.removeNotificationSubscription(
        notificationListener.current
      );
      Notifications.removeNotificationSubscription(responseListener.current);
    };
  };
  //
  async function schedulePushNotification(title, body, data) {
    if (isAndroidExpoGo) {
      return;
    }

    const Notifications = getNotificationsModule();

    await Notifications.scheduleNotificationAsync({
      content: {
        title: title,
        body: body,
        data: data,
      },
      trigger: { seconds: 2 },
    });
  }

  async function registerForPushNotificationsAsync() {
    if (isAndroidExpoGo) {
      return;
    }

    const Notifications = getNotificationsModule();

    let token;

    if (Platform.OS === "android") {
      await Notifications.setNotificationChannelAsync("default", {
        name: "default",
        importance: Notifications.AndroidImportance.MAX,
        vibrationPattern: [0, 250, 250, 250],
        lightColor: "#FF231F7C",
      });
    }

    if (Device.isDevice) {
      const { status: existingStatus } =
        await Notifications.getPermissionsAsync();
      let finalStatus = existingStatus;
      if (existingStatus !== "granted") {
        const { status } = await Notifications.requestPermissionsAsync();
        finalStatus = status;
      }
      if (finalStatus !== "granted") {
        alert("Failed to get push token for push notification!");
        return;
      }
      token = (await Notifications.getExpoPushTokenAsync()).data;
    } else {
      alert("Must use physical device for Push Notifications");
    }

    return token;
  }

  return (
    <BarNotificationContext.Provider
      value={{
        RegisterNotification,
        schedulePushNotification,
      }}
    >
      {children}
    </BarNotificationContext.Provider>
  );
};

export { BarNotificationContext, BarNotificationProvider };

{
  /* <View
style={{
  flex: 1,
  alignItems: 'center',
  justifyContent: 'space-around',
}}>
<Text>Your expo push token: {expoPushToken}</Text>
<View style={{ alignItems: 'center', justifyContent: 'center' }}>
  <Text>Title: {notification && notification.request.content.title} </Text>
  <Text>Body: {notification && notification.request.content.body}</Text>
  <Text>Data: {notification && JSON.stringify(notification.request.content.data)}</Text>
</View>
<Button
  title="Press to schedule a notification"
  onPress={async () => {
    await schedulePushNotification();
  }}
/>
</View> */
}
