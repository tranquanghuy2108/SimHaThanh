import { useLayoutEffect } from 'react'
import { useNavigation, useRoute } from '@react-navigation/native';
import {
    useSendbirdChat,
    createGroupChannelListFragment,
    createGroupChannelCreateFragment,
    createGroupChannelFragment,
    FileViewer,
} from '@sendbird/uikit-react-native';
import { useGroupChannel } from '@sendbird/uikit-chat-hooks';
import { AppConst } from '../constants/AppConst';
import React, { useContext } from 'react';
import { Alert, Modal, StyleSheet, Text, TouchableOpacity, View } from 'react-native';


import { blockUser as blockUserRequest, notifyModerationTeam } from '../utils/moderationService';
import { argonTheme } from '../constants';
import { validateUserGeneratedText } from '../utils/contentModeration';
import { AuthContext } from '../context/AuthContext';

const UseReactNavigationHeader = () => {
    const navigation = useNavigation();
  
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

const ChatModerationModal = ({ visible, channel, currentUser, sdk, userToken, onClose, onBlocked }) => {
  const [isSubmitting, setSubmitting] = React.useState(false);
  const targetUser = channel?.members?.find(
    (member) => String(member.userId) !== String(currentUser?.userId),
  );

  const runAction = async (action, successMessage) => {
    if (!targetUser || isSubmitting) return;
    try {
      setSubmitting(true);
      await action();
      onClose();
      Alert.alert('Đã tiếp nhận', successMessage);
    } catch (error) {
      Alert.alert('Không thể thực hiện', 'Vui lòng thử lại sau hoặc liên hệ hỗ trợ Sim Hà Thành.');
    } finally {
      setSubmitting(false);
    }
  };

  const reportChat = () =>
    runAction(async () => {
      await Promise.all([
        channel.reportUser(targetUser, 'harassing', 'Người dùng báo cáo hành vi hoặc nội dung không phù hợp trong cuộc trò chuyện.'),
        notifyModerationTeam({
          reporterUserId: currentUser.userId,
          source: 'Cuộc trò chuyện',
          targetUserId: targetUser.userId,
          channelUrl: channel.url,
          content: 'Báo cáo cuộc trò chuyện từ ứng dụng.',
        }),
      ]);
    }, 'Báo cáo cuộc trò chuyện đã được chuyển đến đội ngũ kiểm duyệt.');

  const blockUser = () => {
    Alert.alert(
      'Chặn người dùng',
      'Người này sẽ không thể tiếp tục gửi tin nhắn cho bạn. Báo cáo sẽ được chuyển ngay cho đội ngũ kiểm duyệt.',
      [
        { text: 'Hủy', style: 'cancel' },
        {
          text: 'Chặn',
          style: 'destructive',
          onPress: () =>
            runAction(async () => {
              await blockUserRequest({
                userId: currentUser.userId,
                blockedUserId: targetUser.userId,
                userToken,
              });
              try {
                await sdk.blockUserWithUserId(targetUser.userId);
              } catch (error) {
                console.warn('Không thể đồng bộ chặn người dùng với Sendbird.', error);
              }
              onBlocked();
            }, 'Người dùng đã bị chặn. Cuộc trò chuyện đã được đóng khỏi màn hình của bạn.'),
        },
      ],
    );
  };

  return (
    <Modal visible={visible} transparent animationType="slide" onRequestClose={onClose}>
      <View style={styles.backdrop}>
        <View style={styles.sheet}>
          <Text style={styles.title}>An toàn cuộc trò chuyện</Text>
          <Text style={styles.description}>
            Báo cáo hoặc chặn {targetUser?.nickname || 'người dùng này'} nếu có nội dung phản cảm, quấy rối hoặc lừa đảo.
          </Text>
          <TouchableOpacity style={styles.reportButton} onPress={reportChat} disabled={!targetUser || isSubmitting}>
            <Text style={styles.buttonText}>Báo cáo cuộc trò chuyện</Text>
          </TouchableOpacity>
          <TouchableOpacity style={styles.blockButton} onPress={blockUser} disabled={!targetUser || isSubmitting}>
            <Text style={styles.buttonText}>Chặn người dùng</Text>
          </TouchableOpacity>
          <TouchableOpacity style={styles.closeButton} onPress={onClose}>
            <Text style={styles.closeText}>Đóng</Text>
          </TouchableOpacity>
        </View>
      </View>
    </Modal>
  );
};




  

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

    const { sdk, currentUser } = useSendbirdChat();
    const { userToken } = useContext(AuthContext);
    const { channel } = useGroupChannel(sdk, params.channelUrl);
    const [isModerationVisible, setModerationVisible] = React.useState(false);
    const [mediaViewer, setMediaViewer] = React.useState(null);
    if (!channel) return null;

    return (
        <>
            <GroupChannelFragment
                channel={channel}
                onChannelDeleted={() => {
                    navigation.navigate(AppConst.ScreenConst.GROUP_CHANNEL_LIST);
                }}
                onPressHeaderLeft={() => {
                    navigation.goBack();
                }}
                onPressHeaderRight={() => {
                    setModerationVisible(true);
                }}
                onPressMediaMessage={(fileMessage, deleteMessage) => {
                    setMediaViewer({ fileMessage, deleteMessage });
                }}
                onBeforeSendUserMessage={(params) => {
                    const validation = validateUserGeneratedText(params.message, {
                        required: true,
                    });
                    if (!validation.isAllowed) {
                        Alert.alert('Không thể gửi tin nhắn', validation.message);
                        throw new Error(validation.message);
                    }
                    return params;
                }}
            />
            <Modal
                visible={mediaViewer !== null}
                animationType="fade"
                presentationStyle="fullScreen"
                onRequestClose={() => setMediaViewer(null)}
            >
                {mediaViewer && (
                    <FileViewer
                        fileMessage={mediaViewer.fileMessage}
                        deleteMessage={mediaViewer.deleteMessage}
                        onClose={() => setMediaViewer(null)}
                    />
                )}
            </Modal>
            <ChatModerationModal
                visible={isModerationVisible}
                channel={channel}
                currentUser={currentUser}
                sdk={sdk}
                userToken={userToken}
                onClose={() => setModerationVisible(false)}
                onBlocked={() => navigation.navigate(AppConst.ScreenConst.GROUP_CHANNEL_LIST)}
            />
        </>
    );
};

export { GroupChannelListScreen, GroupChannelCreateScreen, GroupChannelScreen }

const styles = StyleSheet.create({
  backdrop: { flex: 1, justifyContent: 'flex-end', backgroundColor: 'rgba(0, 0, 0, 0.5)' },
  sheet: { backgroundColor: 'white', padding: 20, borderTopLeftRadius: 20, borderTopRightRadius: 20 },
  title: { color: argonTheme.COLORS.ERROR, fontSize: 19, fontWeight: '700', textAlign: 'center' },
  description: { color: '#374151', lineHeight: 21, marginTop: 12, marginBottom: 18, textAlign: 'center' },
  reportButton: { alignItems: 'center', backgroundColor: argonTheme.COLORS.ERROR, borderRadius: 8, paddingVertical: 13 },
  blockButton: { alignItems: 'center', backgroundColor: '#9f1239', borderRadius: 8, marginTop: 10, paddingVertical: 13 },
  buttonText: { color: 'white', fontWeight: '700' },
  closeButton: { alignItems: 'center', paddingTop: 16 },
  closeText: { color: '#4b5563', fontWeight: '600' },
});
