import React, { createContext, useState, useContext } from "react";
import axios from "axios";
import Config from "../constants/Config";
import { AuthContext } from "./AuthContext";
import { SetLoadingContext } from "./SetLoadingContext";
import {
  ToastAndroid
} from "react-native";
const PostContext = createContext();

const PostProvider = ({ children }) => {

  const { userToken, userInfos } = useContext(AuthContext);
  const [postDatas, SetPostDatas] = useState(null);
  const [isHitPost, SetHit] = useState(false);

  const [imageDatas, SetImageDatas] = useState([]);
  const { SetLoading } = useContext(SetLoadingContext);
  const [commentDatas, SetCommentData] = useState([]);
  const [commentCountDatas, SetCommentCountState] = useState([]);
  const [replyComment, SetReplyCommentData] = useState(null);
  const [isReloadPost, SetReloadPost] = useState(false);
  const [postLikeDatas, SetPostLikeDatasState] = useState([]);

  const [isLoadComment, SetLoadCommentState] = useState(false);

  const SetReplyComment = (replyCommentData) => {
    SetReplyCommentData(replyCommentData);
  }


  const SetHitPost = (hit) => {
    SetHit(hit);
  }
  const ReloadPost = (reload) => {
    SetReloadPost(reload);
  }
  //POST_CONTENT
  const CreatePost = (postData) => {
    SetHit(false);
    SetLoading(true);
    axios.post(Config.BASE_URL + '/api/post/create-post',
      {

        "userID": userInfos.id,
        "content": postData.content,
        "imageUrls": postData.imgs

      },
      {
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json',
          'Authorization': 'Bearer ' + userToken
        },
      }).then((response) => {
        GetPosts(1, 50);
        SetLoading(false);
        ToastAndroid.showWithGravity(
          'Bài Post đang được đăng!',
          ToastAndroid.SHORT,
          ToastAndroid.BOTTOM,
        );
        return true;
      }).catch((error) => {
        SetLoading(false);
        return false;
      });
  }
  //
  const GetPosts = (pageIndex, pageSize) => {
    SetLoading(true);
    axios.post(Config.BASE_URL + '/api/post/get-all-post',
      {
        "isPaged": true,
        "pageIndex": pageIndex,
        "pageSize": pageSize,
        "keyword": ""
      },
      {
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json',
          'Authorization': 'Bearer ' + userToken
        },
      }).then((response) => {
        SetPostDatas(response.data.data);
        SetLoading(false);
        return true;
      }).catch((error) => {
        SetLoading(false);
        return false;
      });
  }
  //POST_IMAGE
  const GetImageOfPosts = (postID, pageIndex, pageSize) => {
    axios.post(Config.BASE_URL + '/api/post/get-images-of-post',
      {
        "isPaged": true,
        "pageIndex": pageIndex,
        "pageSize": pageSize,
        "keyword": "",
        "postID": postID
      },
      {
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json',
          'Authorization': 'Bearer ' + userToken
        },
      }).then((response) => {
        var currentPostImgs = imageDatas;
        response.data.data.map(img => {
          var isExist = currentPostImgs.find(x => x.id == img.id)
          if (!isExist) {
            currentPostImgs.push(
              img
            );
          }
        })

        SetImageDatas(currentPostImgs);
        return true;

      }).catch((error) => {
        SetLoading(false);
        return false;
      });
  }

  //POST_COMMENT
  const CreatePostComment = (postID, parentCommentID, content) => {
    SetLoading(true);

    axios.post(Config.BASE_URL + '/api/post/create-post-comment',
      {
        "userID": userInfos.id,
        "postID": postID,
        "content": content,
        "parentCommentID": parentCommentID
      },
      {
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json',
          'Authorization': 'Bearer ' + userToken
        },
      }).then((response) => {
        ToastAndroid.showWithGravity(
          'Bình luận đã được gửi!',
          ToastAndroid.SHORT,
          ToastAndroid.BOTTOM,
        );
        GetPostCommentCount(postID);
        GetPostComments(postID, parentCommentID, 1, 50);
        SetLoading(false);

        return true;

      }).catch((error) => {
        SetLoading(false);

        return false;
      });
  }


  const GetPostCommentCount = (postID) => {
    axios.post(Config.BASE_URL + '/api/post/get-post-comment-count',
      {
        "userID": userInfos.id,
        "postID": postID,
      },
      {
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json',
          'Authorization': 'Bearer ' + userToken
        },
      }).then((response) => {
        var currentCommentsCount = commentCountDatas;

        var isExist = currentCommentsCount.find(x => x.postID == response.data.data.postID)
        if (isExist) {

          const index = currentCommentsCount.findIndex(item => item.postID == response.data.data.postID);
          if (index !== -1) {
            currentCommentsCount.splice(index, 1);
          }

          currentCommentsCount.push(
            response.data.data
          );

        }
        else {
          currentCommentsCount.push(
            response.data.data
          );
        }

        SetCommentCountState(currentCommentsCount);
        SetLoading(false);
        return true;

      }).catch((error) => {
        SetLoading(false);
        return false;
      });
  }
  //POST_COMMENT
  const GetPostComments = (postID, parentCommentID, pageIndex, pageSize) => {
    // SetLoading(true);
    SetLoadCommentState(true);
    axios.post(Config.BASE_URL + '/api/post/get-comments-of-post',
      {
        "isPaged": true,
        "pageIndex": pageIndex,
        "pageSize": pageSize,
        "keyword": "",
        "postID": postID
      },
      {
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json',
          'Authorization': 'Bearer ' + userToken
        },
      }).then((response) => {
        var currentPostComment = commentDatas;
        response.data.data.map(comment => {

          var isExist = currentPostComment.find(x => x.id == comment.id)
          if (!isExist) {
            currentPostComment.push(
              comment
            );
          }


        })

        SetCommentData(currentPostComment);

        SetLoadCommentState(false);
        SetLoading(false);
        return true;

      }).catch((error) => {
        SetLoadCommentState(false);
        SetLoading(false);
        return false;
      });
  }
  //
  const ResetComment = () => {
    SetCommentData([]);
  }
  //GetPostLike
  const Like = (postID) => {
    // SetLoading(true);
    axios.post(Config.BASE_URL + '/api/post/like-post',
      {
        "userID": userInfos.id,
        "postID": postID
      },
      {
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json',
          'Authorization': 'Bearer ' + userToken
        },
      }).then((response) => {
        ToastAndroid.showWithGravity(
          'Like Post thành công!',
          ToastAndroid.SHORT,
          ToastAndroid.BOTTOM,
        );
        return true;

      }).catch((error) => {
        SetLoading(false);
        return false;
      });
  }
  const UnLike = (postID) => {
    // SetLoading(true);
    axios.post(Config.BASE_URL + '/api/post/unlike-post',
      {
        "userID": userInfos.id,
        "postID": postID
      },
      {
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json',
          'Authorization': 'Bearer ' + userToken
        },
      }).then((response) => {
        ToastAndroid.showWithGravity(
          'Bỏ Like thành công!',
          ToastAndroid.SHORT,
          ToastAndroid.BOTTOM,
        );
        return true;

      }).catch((error) => {
        SetLoading(false);
        return false;
      });
  }
  const GetPostLikes = (postID, pageIndex, pageSize) => {
    axios.post(Config.BASE_URL + '/api/post/get-post-like',
      {
        "isPaged": true,
        "pageIndex": pageIndex,
        "pageSize": pageSize,
        "keyword": "",
        "postID": postID

      },
      {
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json',
          'Authorization': 'Bearer ' + userToken
        },
      }).then((response) => {
        var currentPostLikes = postLikeDatas;
        response.data.data.map(like => {

          var isExist = currentPostLikes.find(x => x.id == like.id)
          if (!isExist) {
            currentPostLikes.push(
              like
            );
          }
        })

        SetPostLikeDatasState(currentPostLikes);
        SetLoading(false);
        return true;

      }).catch((error) => {
        SetLoading(false);
        return false;
      });
  }

  //
  return (
    <PostContext.Provider value={{
      GetPosts, GetImageOfPosts, GetPostComments, ResetComment, CreatePostComment, CreatePost, SetHitPost, SetReplyComment, ReloadPost,
      GetPostLikes, Like, UnLike, GetPostCommentCount, SetLoadCommentState,

      postDatas, imageDatas, commentDatas, isHitPost, replyComment, isReloadPost, postLikeDatas, commentCountDatas, isLoadComment
    }}>
      {children}
    </PostContext.Provider>
  );
}

export { PostContext, PostProvider }