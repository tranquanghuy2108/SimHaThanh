import { Pressable, Text, View } from 'react-native';
import { useConnection } from '@sendbird/uikit-react-native';
import { useEffect } from 'react';


const SignInScreen = (_userID,_nickName) => {
    const { connect } = useConnection();
    useEffect(()=>{
        connect(_userID, { nickname:_nickName});
    },[])
    
}
export default SignInScreen;