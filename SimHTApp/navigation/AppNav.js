import React, { useContext, useEffect, useState } from 'react';
import { AuthContext } from '../context/AuthContext';
import { ActivityIndicator, View } from 'react-native';
import AppStack from './AppStack';
import AsyncStorage from '@react-native-async-storage/async-storage';
import CommunityGuidelinesModal, {
  COMMUNITY_TERMS_PROMPT_SEEN_KEY,
  COMMUNITY_TERMS_VERSION,
} from '../components/CommunityGuidelinesModal';
export default function AppNav() {
  const { SetUserInfoByStorage, SetUserTokenByStorage } = useContext(AuthContext);
  const [isCheckComplete, SetCheckComplete] = useState(false);
  const [isTermsChecked, setTermsChecked] = useState(false);
  const [isTermsVisible, setTermsVisible] = useState(false);

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

  useEffect(() => {
    AsyncStorage.multiGet([
      "CommunityTermsVersion",
      COMMUNITY_TERMS_PROMPT_SEEN_KEY,
    ])
      .then((entries) => {
        const acceptedVersion = entries[0][1];
        const hasSeenPrompt = entries[1][1] === "true";
        setTermsVisible(
          acceptedVersion !== COMMUNITY_TERMS_VERSION && !hasSeenPrompt,
        );
        setTermsChecked(true);
      })
      .catch(() => setTermsChecked(true));
  }, []);

  const acceptTerms = async () => {
    await AsyncStorage.multiSet([
      ["CommunityTermsVersion", COMMUNITY_TERMS_VERSION],
      [COMMUNITY_TERMS_PROMPT_SEEN_KEY, "true"],
    ]);
    setTermsVisible(false);
  };

  const closeTerms = () => {
    AsyncStorage.setItem(COMMUNITY_TERMS_PROMPT_SEEN_KEY, "true").catch(
      () => undefined,
    );
    setTermsVisible(false);
  };

  return (
    isCheckComplete && isTermsChecked ?
      (
        <>
          <AppStack />
          <CommunityGuidelinesModal
            visible={isTermsVisible}
            onAccept={acceptTerms}
            onClose={closeTerms}
            acceptLabel="Đồng ý để tiếp tục"
          />
        </>
      ) :
      
      (
        <View style={{ flex: 1, justifyContent: 'center', alignItems: 'center' }}>
          <ActivityIndicator size={'large'} />
        </View>
      )
  );
}
