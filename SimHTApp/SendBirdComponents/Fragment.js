import { useLayoutEffect } from 'react'
import { useNavigation, useRoute, View, Text } from '@react-navigation/native';
import {
    useSendbirdChat,
    createGroupChannelListFragment,
    createGroupChannelCreateFragment,
    createGroupChannelFragment,
} from '@sendbird/uikit-react-native';
import SendBird from 'sendbird';
import { useGroupChannel } from '@sendbird/uikit-chat-hooks';
import { AppConst } from '../constants/AppConst';
import OrderScreen from '../screens/OrderScreen';

import React, { useContext } from 'react';
import { Pressable } from 'react-native';


import { GroupChannelListContexts, GroupChannelListModule } from '@sendbird/uikit-react-native';
import { Icon } from '@sendbird/uikit-react-native-foundation';

const UseReactNavigationHeader = () => {
    const navigation = useNavigation();
    const fragment = useContext(GroupChannelListContexts.Fragment);
    const typeSelector = useContext(GroupChannelListContexts.TypeSelector);
  
    useLayoutEffect(() => {
      // Hiển thị tiêu đề và nút "Create Channel" trong react-navigation header.
      navigation.setOptions({
        headerShown: false,
      });
    }, []);
  
    // Ẩn header của @sendbird/uikit-react-native.
    return null;
  };

const GroupChannelListFragment = createGroupChannelListFragment({
    Header: UseReactNavigationHeader,
  });
const GroupChannelCreateFragment = createGroupChannelCreateFragment();
const GroupChannelFragment = createGroupChannelFragment();//Một phòng chat cụ thể




  

//Danh sách các phòng chat
const GroupChannelListScreen = () => {
    const navigation = useNavigation();

    return (
        
        <GroupChannelListFragment

            onPressCreateChannel={(channelType) => {
                // Navigate to GroupChannelCreate function.
                navigation.navigate(AppConst.ScreenConst.GROUP_CHANNEL_CREATE, { channelType });
            }}
            onPressChannel={(channel) => {
                // Navigate to GroupChannel function.
                navigation.navigate(AppConst.ScreenConst.GROUP_CHANNEL, { channelUrl: channel.url });
            }}

        />

    );
};
//Show các userID, click user để tạo phòng
const GroupChannelCreateScreen = () => {
    const navigation = useNavigation();

    return (
        <GroupChannelCreateFragment

            onCreateChannel={async (channel) => {
                // Navigate to GroupChannel function.
                navigation.replace(AppConst.ScreenConst.GROUP_CHANNEL, { channelUrl: channel.url });
            }}
            onPressHeaderLeft={() => {
                // Go back to the previous screen.
                navigation.goBack();

            }}
        />
    );
};
//Một phòng chat cụ thể giữa 2 người
const GroupChannelScreen = () => {
    const navigation = useNavigation();
    const { params } = useRoute();

    const { sdk } = useSendbirdChat();
    const { channel } = useGroupChannel(sdk, params.channelUrl);
    if (!channel) return null;

    return (
        <GroupChannelFragment
            channel={channel}
            onChannelDeleted={() => {
                // Navigate to GroupChannelList function.
                navigation.navigate(AppConst.ScreenConst.GROUP_CHANNEL_LIST);
            }}
            onPressHeaderLeft={() => {
                // Go back to the previous screen.
                navigation.goBack();
            }}
            onPressHeaderRight={() => {
                // Navigate to GroupChannelSettings function.
                navigation.navigate('GroupChannelSettings', { channelUrl: params.channelUrl });
            }}
        />
    );
};

export { GroupChannelListScreen, GroupChannelCreateScreen, GroupChannelScreen }