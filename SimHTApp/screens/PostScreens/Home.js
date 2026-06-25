import React, { useEffect, useState,useContext } from "react";
import {
    FlatList,
    RefreshControl
} from "react-native";
import { observer } from "mobx-react";
import ItemSeperator from "../../components/PostComponents/ItemSeperator";
import Post from "../../components/PostComponents/Post";
import { PostContext} from "../../context/PostContext";
import { AuthContext } from "../../context/AuthContext";

const Home = ({ }) => {
    const { postDatas,imageDatas,postLikeDatas,commentCountDatas} = useContext(PostContext);
    const { GetPosts ,GetImageOfPosts,GetPostLikes,GetPostCommentCount} = useContext(PostContext);

    const [refreshing, setRefreshing] = useState(false);
    const {userInfos} = useContext(AuthContext);

    const handleRefresh = () => {
        setRefreshing(true);
        GetPosts(1,50);
        setRefreshing(false);
        console.log("dang refresh")
    };

    useEffect(() => {
        GetPosts(1,50);
        
    }, []);

    if(postDatas){

        postDatas.map(post =>{
            GetImageOfPosts(post.id,1,50);
            GetPostLikes(post.id,1,50);
            GetPostCommentCount(post.id);
        });
    }
    const [loading, setLoading] = useState(true)

    const renderFooter = () => {
       return null;
    };

    useEffect(() => {
        setTimeout(() => { setLoading(false) }, 2000) //for loading posts demo
    }, [])


    return postDatas !== null ? (
        <FlatList
            data={postDatas} //use data from state instead
            showsVerticalScrollIndicator={false}
            style={{ flex: 1 }}
            keyExtractor={(data) => data.id}
            ItemSeparatorComponent={ItemSeperator}
            ListFooterComponent={renderFooter}
            onEndReachedThreshold={0.5}
            refreshControl={
                <RefreshControl refreshing={refreshing} onRefresh={handleRefresh} />
            }
            renderItem={({ item }) => <Post
                showFullLines={false}
                post={item}
                likeCount={postLikeDatas !=null ? postLikeDatas.filter(x =>x.postID ==item.id).length:0}
                commentCount = {commentCountDatas != null ? (foundData = commentCountDatas.find(x => x.postID === item.id)) ? foundData.totalComment : 0 : 0}
                isMeLike = {postLikeDatas !=null ? postLikeDatas.some(x => x.postID === item.id && x.userID === userInfos.id):false}
                images={imageDatas !=null ? imageDatas.filter(x =>x.postId ==item.id).map(x=>x.imageUrl):null}
                key={item.id} />}
        />
    ): null;
};
export default observer(Home);

