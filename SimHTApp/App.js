import React, { useCallback, useEffect, useState, useRef } from "react";
import { Image, View, Text, Button, Platform } from "react-native";
import {
  SafeAreaProvider,
  initialWindowMetrics,
} from "react-native-safe-area-context";
import * as SplashScreen from "expo-splash-screen";
import * as Font from "expo-font";
import { Asset } from "expo-asset";
import { isRunningInExpoGo } from "expo";
import { Block, GalioProvider } from "galio-framework";
// Before rendering any navigation stack
import { enableScreens } from "react-native-screens";
enableScreens();

import { argonTheme } from "./constants";
import AppNav from "./navigation/AppNav";
import { AuthProvider } from "./context/AuthContext";
import { FilterProvider } from "./context/FilterContext";
import { SearchProvider } from "./context/SearchContext";
import { OrderProvider } from "./context/OrderContext";
import { HomeProvider } from "./context/HomeContext";
import { FengShuiProvider } from "./context/FengShuiContext.js";
import { CollaboratorProvider } from "./context/CollaboratorContext";
import { BarNotificationProvider } from "./context/BarNotificationContext.js";
import { SetLoadingProvider } from "./context/SetLoadingContext.js";
import { BottomTabProvider } from "./context/BottomTabContext.js";
import { AutionProvider } from "./context/AutionContext.js";
import { VNPTProvider } from "./context/VNPTContext.js";
import { DataPackageProvider } from "./context/DataPackageContext.js";
import { TouristPackageProvider } from "./context/TouristPackageContext.js";
import { SimDataProvider } from "./context/SimDataContext.js";
import { MySimProvider } from "./context/MySimContext.js";
import { SendBirdProvider } from "./context/SendbirdContext.js";
import { SimProvider } from "./context/SimContext.js";
//sendbird
import Config from "./constants/Config.js";
import platformServices from "./SendBirdComponents/ExpoNativeModule.js";
import { SendbirdUIKitContainer } from "@sendbird/uikit-react-native";
import AsyncStorage from "@react-native-async-storage/async-storage";
import { PostProvider } from "./context/PostContext.js";
import { InstallmentProvider } from "./context/InstallmentContext.js";
import { NotificationMailProvider } from "./context/NotificationMailContext.js";

import { EscrowWalletProvider } from "./context/EscrowWalletContext.js";

const isAndroidExpoGo = Platform.OS === "android" && isRunningInExpoGo();

// Giữ splash cho đến khi view gốc layout xong. Đặc biệt trên iOS,
// modal điều khoản có thể hiển thị phía trên splash nếu splash chưa được ẩn.
SplashScreen.preventAutoHideAsync().catch(() => undefined);

export default function App() {
  const [appIsReady, setAppIsReady] = useState(false);
  const [rootViewIsReady, setRootViewIsReady] = useState(false);

  useEffect(() => {
    async function prepare() {
      try {
        // Pre-load fonts, make any API calls you need to do here
        await Font.loadAsync({
          ArgonExtra: require("./assets/font/argon.ttf"),
        });
      } catch (e) {
        console.warn(e);
      } finally {
        // Tell the application to render
        setAppIsReady(true);
      }
    }
    prepare();
  }, []);

  const onLayoutRootView = useCallback(async () => {
    if (appIsReady && !rootViewIsReady) {
      try {
        await SplashScreen.hideAsync();
      } finally {
        // Không để lỗi splash chặn navigation/login vĩnh viễn.
        setRootViewIsReady(true);
      }
    }
  }, [appIsReady, rootViewIsReady]);

  if (!appIsReady) {
    return null;
  }
  const userProfile = {
    onCreateChannel: (selectedUsers) => {
      // Implement your logic for creating a channel
    },
    // Other userProfile properties...
  };

  return (
    <SafeAreaProvider
      initialMetrics={initialWindowMetrics}
      style={{ flex: 1, backgroundColor: argonTheme.COLORS.ERROR }}
    >
      <SendbirdUIKitContainer
        appId={Config.SEND_BIRD_APP_ID}
        chatOptions={{
          localCacheStorage: AsyncStorage,
          // Expo Go on Android cannot provide an FCM device token. Keep this
          // enabled for development and production builds, where FCM is available.
          enableAutoPushTokenRegistration: !isAndroidExpoGo,
        }}
        platformServices={platformServices}
        uikitOptions={{
          groupChannel: {
            enableVoiceMessage: false,
          },
        }}
        userProfile={userProfile}
      >
      <AuthProvider>
        <SetLoadingProvider>
          <BarNotificationProvider>
            <NotificationMailProvider>
              <BottomTabProvider>
                <SendBirdProvider>
                  <HomeProvider>
                    <AutionProvider>
                      <EscrowWalletProvider>
                        <VNPTProvider>
                          <DataPackageProvider>
                            <TouristPackageProvider>
                              <InstallmentProvider>
                                <FengShuiProvider>
                                  <PostProvider>
                                    <OrderProvider>
                                      <CollaboratorProvider>
                                        <SimProvider>
                                          <SearchProvider>
                                            <SimDataProvider>
                                              <MySimProvider>
                                                <FilterProvider>
                                                  <View style={{ flex: 1 }} onLayout={onLayoutRootView}>
                                                      <GalioProvider
                                                        alioProvider
                                                        theme={argonTheme}
                                                      >
                                                        <Block flex>
                                                          {rootViewIsReady ? <AppNav /> : null}
                                                          </Block>
                                                        </GalioProvider>
                                                  </View>
                                                </FilterProvider>
                                              </MySimProvider>
                                            </SimDataProvider>
                                          </SearchProvider>
                                        </SimProvider>
                                      </CollaboratorProvider>
                                    </OrderProvider>
                                  </PostProvider>
                                </FengShuiProvider>
                              </InstallmentProvider>
                            </TouristPackageProvider>
                          </DataPackageProvider>
                        </VNPTProvider>
                      </EscrowWalletProvider>
                    </AutionProvider>
                  </HomeProvider>
                </SendBirdProvider>
              </BottomTabProvider>
            </NotificationMailProvider>
          </BarNotificationProvider>
        </SetLoadingProvider>
      </AuthProvider>
      </SendbirdUIKitContainer>
    </SafeAreaProvider>
  );
}
