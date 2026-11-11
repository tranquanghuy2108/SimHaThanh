import { Pressable, Text, View } from 'react-native';
import { useConnection } from '@sendbird/uikit-react-native';
import { useEffect } from 'react';


const SignInScreen = (_userID,_nickName) => {
    const { connect } = useConnection();
    useEffect(()=>{
        if (_userID) {
            connect(_userID, { nickname:_nickName});
        }
    },[_userID, _nickName, connect])
    
}
export default SignInScreen;
