import { useEffect, useContext } from 'react'
import { GroupChannelListScreen } from '../SendBirdComponents/Fragment';
import { SendBirdContext } from '../context/SendbirdContext';
import { SafeAreaView, StatusBar, TouchableOpacity, View,Text } from 'react-native';
import { argonTheme } from '../constants';
import Ionicons from 'react-native-vector-icons/Ionicons';
import { responsiveFontSize } from 'react-native-responsive-dimensions';
const ChatScreen = ({ navigation }) => {
  const { GetUnreadMessageCount } = useContext(SendBirdContext);
  useEffect(() => {
    const unsubscribe = navigation.addListener('focus', () => {
      GetUnreadMessageCount();
    });

    return unsubscribe;
  }, [navigation]);
  const ExitButton = () => {
    return (
        // Nút Thoát
        <TouchableOpacity className="p-1 rounded-full bg-white mx-1 "
            onPress={() => {
                props.navigation.closeDrawer();
            }}>
            <Ionicons name="chevron-back-outline" color="black" size={26}></Ionicons>
        </TouchableOpacity>
    );
}
const Title = () => {
    return (
        <View className="flex-1 items-center justify-center">
            <Text style={{ color: "white", fontWeight: "bold", fontSize: responsiveFontSize(2.5) }}>Chat</Text>
        </View>

    );
}
  return (
    <View style={{zIndex: 10000, position: 'absolute', top: 0, left: 0, right: 0, height: "100%" }}>
      <View className="flex-row p-2" style={{ zIndex: 1000, marginTop: StatusBar.currentHeight }} backgroundColor={argonTheme.COLORS.ERROR}>
        
        <Title />
      </View>
      <GroupChannelListScreen
      >
      </GroupChannelListScreen>
    </View>


  );
};
export default ChatScreen;