// Used in both the home screen and post details screen conditionally

import React, { useEffect, useRef, useState, useContext } from "react";
import {
    View,
    Text,
    StyleSheet,
    TouchableOpacity,
    Image,
    Alert,
} from "react-native";
import { useNavigation, useRoute } from "@react-navigation/native";
import moment from 'moment';
import Ionicons from 'react-native-vector-icons/Ionicons';
import ImageGrid from "./ImageGrid";
import PostDescription from "./PostDescription";
import MaterialIcons from 'react-native-vector-icons/MaterialIcons';
import MaterialCommunityIcons from 'react-native-vector-icons/MaterialCommunityIcons';
import { observer } from "mobx-react";
import PostComment from "./PostComment";
import { PostContext } from "../../context/PostContext";
import { AppConst } from "../../constants/AppConst";
import SendBird from "sendbird";
import Config from "../../constants/Config";
import { AuthContext } from "../../context/AuthContext";
import { argonTheme } from "../../constants";
const Post = ({ post, images, preview, likeCount, isMeLike, commentCount }) => {
    const { GetPostComments, ResetComment, Like, UnLike } = useContext(PostContext);
    const [isLike, SetLikeState] = useState(false);
    const { userInfos } = useContext(AuthContext);
    const [isPopupVisible, setPopupVisible] = useState(false);

    // const { reactions, comments, shares } = post
    const navigation = useNavigation()
    const route = useRoute();
    const descRef = useRef();

    const onClickClose = () => {
        setPopupVisible(false);
        ResetComment();
    };
    useEffect(() => {
        if (isMeLike) {
            SetLikeState(true);
        }
        else {
            SetLikeState(false);
        }
    }, [isMeLike]);

    const onPressImage = (url, index, event) => {
        // preview ? navigation.navigate('FacebookFeedImagePreview', { images }) //To preview a selected single image 
        //     :
        //     navigation.navigate('FacebookFeedPostDetails', { post, index }) //index is passed to scroll to the specific image on mount
        navigation.navigate('FacebookFeedImagePreview', { images }) //To preview a selected single image 
    }

    const onPressComments = () => {
        setPopupVisible(true);
        GetPostComments(post.id, null, 1, 50);
    }
    const onPressLikeHandle = () => {
        if (isLike) {
            SetLikeState(false);
            UnLike(post.id);
        }
        else {
            Like(post.id);
            SetLikeState(true);
        }
    }
    const RefreshCommentDatas = () => {
        GetPostComments(post.id, null, 1, 50);
    }



    const onPressChat = () => {
        const sb = new SendBird({ appId: Config.SEND_BIRD_APP_ID });
        sb.connect(userInfos.id, (user, error) => {
            if (error) {
                console.error('Error connecting to Sendbird:', error);
            } else {

                var userId1 = userInfos.id;
                var userId2 = post.userID;
                const params = new sb.GroupChannelParams();
                params.isDistinct = true; // Tạo một kênh duy nhất cho hai người dùng
                params.addUserIds([userId1, userId2]);

                sb.GroupChannel.createChannel(params, (groupChannel, error) => {
                    if (error) {
                        console.error('Error creating group channel:', error);
                    } else {
                        const channelUrl = groupChannel.url;
                        navigation.navigate(AppConst.ScreenConst.GROUP_CHANNEL, { channelUrl: channelUrl });
                     

                    }
                });
            }
        });

    }


    return (
        <>
            <View style={styles.post}>

                {
                    isPopupVisible && (
                        <PostComment postID={post.id} visible={isPopupVisible} onClickClose={onClickClose} onRefreshDatas={RefreshCommentDatas} />

                    )
                }

                {
                    <View style={styles.header}>
                        <View style={[styles.row, { justifyContent: 'space-between' }]}>
                            <TouchableOpacity

                                style={styles.row}>
                                {
                                    <Image
                                        source={{ uri: `data:image/jpeg;base64,${post.avatarURL}` }}
                                        style={styles.creatorImage}
                                    />
                                }

                                <View style={{ marginHorizontal: 10 }}>
                                    <View style={styles.row}>
                                        <Text numberOfLines={1} style={styles.boldText}>{post.fullName}</Text>
                                        {
                                            <Text style={styles.creatorName}></Text>
                                        }
                                    </View>
                                    <View style={styles.row}>
                                        <Text numberOfLines={1} style={styles.lightText} >{moment(post.createTime).format('MMMM DD')} at {moment(post.createTime).format('h:mm a')}</Text>
                                    </View>
                                </View>
                            </TouchableOpacity>

                        </View>
                    </View>

                }

                {
                    post.content ? <TouchableOpacity
                        activeOpacity={0.8}
                        onPress={() => descRef.current.toggleNumberOfLines()}
                        style={styles.descriptionContainer}>
                        <PostDescription
                            desc={post.content}
                            ref={descRef}
                            showFull={route.name === 'FacebookFeedPostDetails'}
                        />
                    </TouchableOpacity> : null
                }
                {

                    <View style={{ height: images.length > 0 ? 340 : 40 }}>

                        {images.length > 0 && (
                            <ImageGrid
                                style={{ height: 300 }}
                                images={images}
                                onPress={onPressImage}
                            />

                        )}


                        <View style={styles.reactionsContainer} >

                            <View style={styles.row}>

                                {
                                    likeCount > 0 ? (
                                        <View className="flex-row items-center justify-center">

                                            {
                                                likeCount > 1 ? (
                                                    <View className="flex-row items-center justify-center">
                                                        <View style={{ backgroundColor: argonTheme.COLORS.ERROR, padding: 2, borderRadius: 62, marginRight: 2, width: 18, height: 18 }} className="items-center justify-center" >
                                                            <Ionicons name="thumbs-up" color="white" size={9}></Ionicons>
                                                        </View>
                                                        <Text style={styles.commentsText}>
                                                            {
                                                                isMeLike ?
                                                                    (
                                                                        isLike ?
                                                                            (
                                                                                `Bạn và ${likeCount - 1} người khác`
                                                                            ) :
                                                                            (

                                                                                `${likeCount - 1}`
                                                                            )

                                                                    )
                                                                    :
                                                                    (
                                                                        isLike ? (
                                                                            `Bạn và ${likeCount} người khác`
                                                                        ) :
                                                                            (

                                                                                `${likeCount}`
                                                                            )

                                                                    )

                                                            }
                                                        </Text>

                                                    </View>

                                                ) : (
                                                    <View className="flex-row items-center justify-center">

                                                        {
                                                            isMeLike ?
                                                                (
                                                                    isLike ?
                                                                        (
                                                                            <View style={{ backgroundColor: argonTheme.COLORS.ERROR, padding: 2, borderRadius: 62, marginRight: 2, width: 18, height: 18 }} className="items-center justify-center" >
                                                                                <Ionicons name="thumbs-up" color="white" size={9}></Ionicons>
                                                                            </View>

                                                                        ) :
                                                                        (

                                                                            null
                                                                        )

                                                                )
                                                                :
                                                                (
                                                                    <View style={{ backgroundColor: argonTheme.COLORS.ERROR, padding: 2, borderRadius: 62, marginRight: 2, width: 18, height: 18 }} className="items-center justify-center" >
                                                                        <Ionicons name="thumbs-up" color="white" size={9}></Ionicons>
                                                                    </View>

                                                                )

                                                        }

                                                        <Text style={styles.commentsText}>
                                                            {
                                                                isMeLike ?
                                                                    (
                                                                        isLike ?
                                                                            (
                                                                                `${userInfos.fullName}`
                                                                            ) :
                                                                            (

                                                                                null
                                                                            )

                                                                    )
                                                                    :
                                                                    (
                                                                        isLike ? (
                                                                            `Bạn và ${likeCount} người khác`
                                                                        ) :
                                                                            (

                                                                                `${likeCount}`
                                                                            )

                                                                    )

                                                            }
                                                        </Text>
                                                    </View>
                                                )

                                            }



                                        </View>

                                    ) : (
                                        <View className="flex-row items-center justify-center">



                                            {
                                                isLike ?
                                                    (
                                                        <View style={{ backgroundColor: argonTheme.COLORS.ERROR, padding: 2, borderRadius: 62, marginRight: 2, width: 18, height: 18 }} className="items-center justify-center" >
                                                            <Ionicons name="thumbs-up" color="white" size={9}></Ionicons>

                                                        </View>
                                                    ) : (null)

                                            }


                                            <Text style={styles.commentsText}>{

                                                (isLike ? (userInfos.fullName) : null)
                                            }
                                            </Text>




                                        </View>
                                    )
                                }
                                {
                                    commentCount > 0 && (
                                        <View style={{ flex: 1 }}>
                                            <TouchableOpacity
                                                activeOpacity={0.8}
                                                onPress={onPressComments}
                                            >

                                                <Text style={{ textAlign: "right", color: 'grey' }}>{`${commentCount} Bình luận`}  </Text>

                                            </TouchableOpacity>
                                        </View>




                                    )
                                }



                            </View>
                        </View>
                    </View>


                }


                <View style={styles.bottomBorder} />
                <View style={styles.buttonsContainer}>

                    <TouchableOpacity
                        activeOpacity={0.8}
                        style={styles.buttonContainer}
                        onPress={onPressLikeHandle}>
                        <Ionicons name="thumbs-up" color={isLike == false ? "gray" : argonTheme.COLORS.ERROR} size={20}></Ionicons>
                        <Text style={[styles.buttonText, { color: isLike == false ? 'gray' : argonTheme.COLORS.ERROR }]}>Thích</Text>
                    </TouchableOpacity>

                    <TouchableOpacity
                        activeOpacity={0.8}
                        style={styles.buttonContainer}
                        onPress={onPressComments}>
                        <MaterialIcons name="chat-bubble-outline" size={25} color="grey" />
                        <Text style={styles.buttonText}>Bình luận</Text>
                    </TouchableOpacity>
                    <TouchableOpacity
                        activeOpacity={0.8}
                        style={styles.buttonContainer}
                        onPress={onPressChat}>
                        <MaterialCommunityIcons name="chat-outline" size={25} color="grey" />
                        <Text style={styles.buttonText}>Chat</Text>
                    </TouchableOpacity>
                </View>
            </View>
        </>
    )
}
export default observer(Post);

const styles = StyleSheet.create({
    post: {
        width: '100%',
        backgroundColor: '#fff'
    },
    header: {
        padding: 15,
        paddingVertical: 8,
        backgroundColor: '#fff'
    },
    dots: {
        paddingVertical: 8,
    },
    row: {
        flexDirection: 'row',
        alignItems: 'center',
    },
    lightText: {
        color: 'grey'
    },
    creatorImage: {
        height: 40,
        width: 40,
        borderRadius: 20
    },
    boldText: {
        fontWeight: 'bold',
    },
    descriptionContainer: {
        marginBottom: 5,
        paddingHorizontal: 15,
        backgroundColor: '#fff'
    },
    image: {
        height: 300,
        width: '100%',
    },
    reactionsContainer: {
        top: 10,
        flexDirection: 'row',
        alignItems: 'center',
        justifyContent: 'space-between',
        marginHorizontal: 15
    },
    sharesText: {
        marginLeft: 10,
        color: 'grey'
    },
    commentsText: {
        color: 'grey'
    },
    bottomBorder: {
        height: 1,
        backgroundColor: '#ebecf0',
        marginHorizontal: 15
    },
    buttonsContainer: {
        flexDirection: 'row',
        alignItems: 'center',
        justifyContent: 'space-between',
        marginHorizontal: 15
    },
    buttonContainer: {
        backgroundColor: '#fff',
        padding: 10,
        flexDirection: 'row',
        alignItems: 'center',
    },
    buttonText: {
        color: 'grey',
        marginLeft: 8,
        fontSize: 14,
        fontWeight: 'bold'
    },
})
