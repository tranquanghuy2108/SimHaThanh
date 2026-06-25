import React, { createContext, useEffect, useState, useContext } from "react";
import { View, TextInput, TouchableOpacity, Text, StyleSheet, RefreshControl, Modal, Button, ScrollView, Image, FlatList, ActivityIndicator } from 'react-native';
import MasonryList from '@react-native-seoul/masonry-list';
import { PostContext } from "../../context/PostContext";
import Ionicons from 'react-native-vector-icons/Ionicons';
import { argonTheme } from "../../constants";
import { responsiveFontSize } from "react-native-responsive-dimensions";

const CommentTree = ({ comments }) => {
    const { SetReplyComment } = useContext(PostContext);
    const ReplyComment = (commentID, commentName) => {
        SetReplyComment(
            {
                replyCommentID: commentID,
                replyCommentName: commentName + " ",
            }
        );
    }
    const renderComment = comment => {
        const childComments = comments.filter(c => c.parentCommentID === comment.id);

        return (

            <View key={comment.id} className="p-2" style={{ width: 300 }}>
                <View className="flex-row">
                    {/* Left */}
                    <View>
                        <Image
                            source={{ uri: `data:image/jpeg;base64,${comment.avatarURL}` }}
                            style={{ height: 40, width: 40, resizeMode: 'contain', borderRadius: 30 }}
                        />

                    </View>

                    {/* Right */}
                    <View className="mx-2" >

                        <View className="rounded-xl p-2 bg-stone-200">
                            <Text className="font-bold">{comment.fullName}</Text>
                            <View>
                                <Text style={styles.textComment}> {comment.content}</Text>
                            </View>
                        </View>
                        <View className="item-start">
                            <TouchableOpacity
                                onPress={() => ReplyComment(comment.id, comment.fullName)}
                            >
                                <Text className="font-bold">Phản hồi</Text>
                            </TouchableOpacity>
                        </View>

                    </View>

                </View>

                {/* Reply */}
                <View key={comment.id} className="ml-7">
                    {childComments.map(childComment => renderComment(childComment))}
                </View>
            </View>
        );
    };

    const rootComments = comments.filter(comment => comment.parentCommentID === null);

    return <View>{rootComments.map(comment => renderComment(comment))}</View>;
}


const CommentInput = ({ postID, onRefreshDatas }) => {
    const [cmtContent, SetContent] = useState('');
    const { replyComment, SetReplyComment } = useContext(PostContext);
    const { CreatePostComment } = useContext(PostContext);
    const handleInputChange = (text) => {
        SetContent(text);
    };

    const handleInputSubmit = () => {
        CreatePostComment(postID, replyComment == null ? null : replyComment.replyCommentID, cmtContent);
     

        SetContent('');
        SetReplyComment(null);

    }

    const CancleReply = () => {
        SetReplyComment(null);
    }
    return (
        <View style={{backgroundColor:"white"}}>
            {
                replyComment && (
                    <View className="flex-row mx-4 jutify-center items-center p-2">
                        <Text>Phản hồi đến {replyComment.replyCommentName}</Text>
                        <TouchableOpacity
                            className="mx-2"
                            onPress={CancleReply}
                        >
                            <Text className="font-bold">Hủy</Text>
                        </TouchableOpacity>
                    </View>
                )
            }
            <View className="mx-4 flex-row items-center rounded-2xl" style={{ height: 55, width: '90%'}}>

                <TextInput

                    placeholder='Viết bình luận'
                    placeholderTextColor={'gray'}
                    className="flex-1 text-base pl-2 tracking-wider"
                    editable={true}
                    onChangeText={text => handleInputChange(text)}
                    value={cmtContent}
                    muliline
                />
                <TouchableOpacity
                    onPress={handleInputSubmit}
                >
                    <View className="handleInputSubmit">
                        <Ionicons name="navigate-outline" color="green" size={30}></Ionicons>
                    </View>
                </TouchableOpacity>
            </View>

        </View>
    );
}

const PostComment = ({ postID, visible, onClickClose, onRefreshDatas }) => {
    const { commentDatas, isLoadComment } = useContext(PostContext);
    const [refreshing, setRefreshing] = useState(false);

    const handleRefresh = () => {
        setRefreshing(true);
        onRefreshDatas();
        setRefreshing(false);
    };
    return (
        <Modal visible={visible} transparent>
            <View style={styles.popupContainer} >

                {
                    isLoadComment && (
                        <View style={{ position: 'absolute', zIndex: 2000, backgroundColor: 'rgba(0, 0, 0, 0.6)',width:'100%',height:'100%',    justifyContent: 'center',
                        alignItems: 'center',} } >
                            <View style={{ }} className="justify-center items-center">
                                {
                                    <ActivityIndicator size="large" color={argonTheme.COLORS.ERROR} />
                                }
                            </View>
                            </View>
                    )
                }


                <View style={styles.popupContent}>
                    <View>

                        <TouchableOpacity
                            onPress={onClickClose}
                        >
                            <View className="">
                                <Ionicons name="chevron-back-outline" color="black" size={30}></Ionicons>
                            </View>
                        </TouchableOpacity>

                    </View>
                    <ScrollView
                        refreshControl={
                            <RefreshControl refreshing={refreshing} onRefresh={handleRefresh} />
                        }
                    >

                        <View styles={{ width: 300, padding: 2 }}>
                            {
                                commentDatas.length == 0 && (
                                    <View className="items-center">
                                        <Text className="font-bold">Chưa Có Bình Luận</Text>
                                        <Text>Hãy để lại bình luận đầu tiên!</Text>
                                    </View>
                                )

                            }

                            <CommentTree comments={commentDatas} />
                        </View>

                    </ScrollView>
                </View>

            </View>
            <View className="items-center justify-center bg-stone-100" style={{}}>
                <CommentInput postID={postID} onRefreshDatas={onRefreshDatas} />
            </View>

        </Modal>
    );
};

const styles = StyleSheet.create({
    textComment:{
        textAlign: "justify",
        marginLeft: 5,
        marginRight: 5,
        fontSize: responsiveFontSize(2.1)
    },
    popupContainer: {
        flex: 1,
        justifyContent: 'center',
        alignItems: 'center',
        backgroundColor: 'rgba(0, 0, 0, 0.5)',
        ZIndex: 999
    },
    popupContent: {
        backgroundColor: 'rgba(255, 255, 255, 1)',
        height: '99%',
        width: '98%',
        padding: 10,
        borderRadius: 5,

    },
    popupText: {
        fontSize: 18,
        marginBottom: 10,
    },
    closeButton: {
        backgroundColor: 'blue',
        paddingHorizontal: 20,
        paddingVertical: 10,
        borderRadius: 8,
        alignSelf: 'flex-end',
    },
    closeButtonText: {
        color: 'white',
        fontSize: 16,
    },
    buttonText: {
        color: 'white',
        fontSize: 16,
    },

});

export default PostComment;