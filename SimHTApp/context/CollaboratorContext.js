import React, { createContext, useState, useContext } from "react";
import axios from "axios";
import Config from "../constants/Config";
import { AuthContext } from "./AuthContext";
import { SetLoadingContext } from "./SetLoadingContext";
import { ToastAndroid } from "react-native";

const CollaboratorContext = createContext();

const CollaboratorProvider = ({ children }) => {
    const { SetLoading } = useContext(SetLoadingContext);
    const { userToken, userInfos } = useContext(AuthContext);
    const [memberRequestDatas, SetMememberRequestJoinState] = useState([]);
    const [myGroupOwnDatas, SetMyGroupOwnState] = useState([]);
    const [memberGroupDatas, SetMemberGroupState] = useState([]);
    const [groupHadJoinDatas,SetGroupHadJoinState] = useState([]);
    ///
    const CreateGroupCollab = (groupName, groupDiscount, groupDescription) => {
        if(groupDiscount==null || groupDiscount.length == 0){
            groupDiscount = [
                {
                    "id": 1,
                    "priceFrom": 0,
                    "priceTo": 0,
                    "discountPer": 0,
                    "description": ""
                }
            ]
        }
        SetLoading(true);
        axios.post(Config.BASE_URL + '/api/collaborators/create-group',
            {
                "id": 0,
                "code": "",
                "name": groupName,
                "discount": groupDiscount,
                "description": groupDescription,
                "isApp": true,
                "isForAgent": true,
                "ownerId": userInfos.id
            },
            {
                headers: {
                    Accept: 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + userToken
                },
            }).then((response) => {
                if (response.data.code === "1") 
                {
                    ToastAndroid.showWithGravity(
                        'Tạo nhóm cộng tác viên thành công!',
                        ToastAndroid.SHORT,
                        ToastAndroid.BOTTOM,
                    );

                    GetMyGroupOwn();
                }
                else 
                {
                    ToastAndroid.showWithGravity(
                        `Tạo nhóm thất bại. ${response.data.message}`,
                        ToastAndroid.SHORT,
                        ToastAndroid.BOTTOM,
                    );
                }
                SetLoading(false);
                return true;
            }).catch((error) => {
                ToastAndroid.showWithGravity(
                    `Tạo nhóm thất bại. ${error.response.data.message}`,
                    ToastAndroid.SHORT,
                    ToastAndroid.BOTTOM,
                );
                SetLoading(false);
                return false;
            });
    }
    ///
    const RequestJoinGroup = (code) => {
        SetLoading(true);
        axios.post(Config.BASE_URL + '/api/collaborators/request-join-group',
            {
                "code": code,
                "userId": userInfos.id
            },
            {
                headers: {
                    Accept: 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + userToken
                },
            }).then((response) => {
                if (response.data.code === "1") {
                    GetMemberRequestJoin();
                    ToastAndroid.showWithGravity(
                        'Gửi yêu cầu thành công!',
                        ToastAndroid.SHORT,
                        ToastAndroid.BOTTOM,
                    );

                }
                else {
                    ToastAndroid.showWithGravity(
                        `Gửi yêu cầu thất bại. ${response.data.message}`,
                        ToastAndroid.SHORT,
                        ToastAndroid.BOTTOM,
                    );
                }

                SetLoading(false);
                return true;
            }).catch((error) => {
                ToastAndroid.showWithGravity(
                    `Gửi yêu cầu thất bại. ${error.response.data.message}`,
                    ToastAndroid.SHORT,
                    ToastAndroid.BOTTOM,
                );
                SetLoading(false);
                return false;
            });
    }
    ///
    const GetMyGroupOwn = () => {
        SetLoading(true);
        axios.post(Config.BASE_URL + '/api/collaborators/get-my-group',
            userInfos.id,
            {
                headers: {
                    Accept: 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + userToken
                },
            }).then((response) => {
                SetMyGroupOwnState(response.data.data)
                SetLoading(false);
                return true;
            }).catch((error) => {
                SetMyGroupOwnState([])
                SetLoading(false);
                return false;
            });
    }


    ///
    const GetMemberRequestJoin = () => {
        SetLoading(true);
        axios.post(Config.BASE_URL + '/api/collaborators/get-member-request-join',
            userInfos.id,
            {
                headers: {
                    Accept: 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + userToken
                },
            }).then((response) => {
                SetMememberRequestJoinState(response.data.data)
                SetLoading(false);
                return true;
            }).catch((error) => {
                SetLoading(false);
                return false;
            });
    }


    ///
    const ApproveRequestJoinGroup = (requestID) => {
        SetLoading(true);
        axios.post(Config.BASE_URL + '/api/collaborators/approved-request-join-group',
            {
                "requestIds": [
                    requestID
                ],
                "isApproved": true
            },
            {
                headers: {
                    Accept: 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + userToken
                },
            }).then((response) => {
                ToastAndroid.showWithGravity(
                    'Duyệt thành công!',
                    ToastAndroid.SHORT,
                    ToastAndroid.BOTTOM,
                );
                GetMemberRequestJoin();
                SetLoading(false);
                return true;
            }).catch((error) => {
                ToastAndroid.showWithGravity(
                    `Duyệt thất bại. ${error.response.data.message}`,
                    ToastAndroid.SHORT,
                    ToastAndroid.BOTTOM,
                );
                SetLoading(false);
                return false;
            });
    }

    ///
    const GetGroupHadJoin = () =>{
        SetLoading(true);
        axios.post(Config.BASE_URL + '/api/collaborators/get-group-had-join',
            userInfos.id
            ,
            {
                headers: {
                    Accept: 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + userToken
                },
            }).then((response) => {
                SetGroupHadJoinState(response.data.data);
                SetLoading(false);
                return true;
            }).catch((error) => {
                SetGroupHadJoinState([]);
                SetLoading(false);
                return false;
            });
    }
    ///
    const GetMembersInGroup = (groupID) => {
        SetLoading(true);
        axios.post(Config.BASE_URL + '/api/collaborators/get-member-in-group',
            groupID,
            {
                headers: {
                    Accept: 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + userToken
                },
            }).then((response) => {
                SetMemberGroupState(response.data.data);
                SetLoading(false);
                return true;
            }).catch((error) => {
                SetLoading(false);
                return false;
            });
    }
    return (
        <CollaboratorContext.Provider value={{
            CreateGroupCollab, RequestJoinGroup, ApproveRequestJoinGroup, GetMemberRequestJoin, GetMyGroupOwn, GetMembersInGroup,GetGroupHadJoin,
            memberRequestDatas, myGroupOwnDatas, memberGroupDatas,groupHadJoinDatas
        }}>
            {children}
        </CollaboratorContext.Provider>
    );
}

export { CollaboratorContext, CollaboratorProvider }