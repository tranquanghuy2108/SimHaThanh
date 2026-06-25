
import React, { createContext, useState, useContext } from "react";
import axios from "axios";
import Config from "../constants/Config";
import { AuthContext } from "./AuthContext";
import { SetLoadingContext } from "./SetLoadingContext";
import {
    ToastAndroid
} from "react-native";
const MySimContext = createContext();

const MySimProvider = ({ children }) => {

    const { userToken, userInfos } = useContext(AuthContext)
    const { SetLoading } = useContext(SetLoadingContext);
    const [keyWord, SetKeyWordState] = useState('');
    const [sortType, SetSortByState] = useState(0);
    const [pageIndex, SetPageIndexState] = useState(1);
    const [searchResult, SetSearchResultState] = useState(null);

    const [subscriptionTypes, SetSubscriptionState] = useState([]);

    //
    const [isDeleteAllFilter, SetDeleteAllFilter] = useState(false);


    const [updatedSubscriptionArray, SetUpdateSubscriptionArrayState] = useState([]);

    const [updateSortBy, setUpdateSortByState] = useState(sortType);

    const [resetFrameState, SetResetFrameState] = useState(false);

    const SetUpdateSubscriptionArray = (subTyp) => {
        SetUpdateSubscriptionArrayState(subTyp);
    }
    const setUpdateSortBy = (_sortType) => {
        setUpdateSortByState(_sortType);
    }
    const SetResetFrame = (status) => {
        SetResetFrameState(status);
    }

    async function processSearchAsyncTask(responseArray) {
        try {
            const newSearchResult = [];


            if (responseArray != null) {
                responseArray.map(item => {
                    newSearchResult.push(item);
                })
            }


            SetSearchResultState(newSearchResult);

        } catch (error) {
            // Xử lý lỗi nếu có
            console.error('Error:', error);
        }
    }
    async function processPagingAsyncTask(responseArray) {
        try {
            const newSearchResult = [];
            if (searchResult != null) {
                searchResult.map(item => {
                    newSearchResult.push(item);
                })
            }

            if (responseArray != null) {
                responseArray.map(item => {
                    newSearchResult.push(item);
                })
            }
            SetSearchResultState(newSearchResult);

        } catch (error) {
            // Xử lý lỗi nếu có
            console.error('Error:', error);
        }
    }


    const SetSortBy = (_sortBy) => {
        const sortByParse = parseInt(_sortBy);
        SetSortByState(sortByParse);
    }
    //
    const searchPaging = () => {
        SetLoading(true);
        axios.post(Config.BASE_URL + '/api/sim/search-sim-of-agent',
            {
                "isPaged": true,
                "pageIndex": pageIndex + 1,
                "pageSize": 50,
                "keyword": keyWord,
                "userId": userInfos.id,
                "simOnAppStatus": 0,
                "sortBy": sortType,
            },
            {
                headers: {
                    Accept: 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + userToken
                },
            }).then((response) => {
                processPagingAsyncTask(response.data);
                SetPageIndexState(pageIndex + 1);
                SetLoading(false);
                return true;
            }).catch((error) => {
                ToastAndroid.showWithGravity(
                    'Tìm kiếm thất bại!',
                    ToastAndroid.SHORT,
                    ToastAndroid.BOTTOM,
                );
                SetLoading(false);
                return false;
            });
    }

    //
    const DeleteAllFilter = () => {
        SetDeleteAllFilter(true);
    }

    //
    const SetKeyWord = (keyword) => {
        SetKeyWordState(keyword);
    }

    const search = (keyWordS) => {
        SetLoading(true);

        if (keyWordS == null) {
            keyWordS = keyWord;
        }
        axios.post(Config.BASE_URL + '/api/sim/search-sim-of-agent',
            {
                "isPaged": true,
                "pageIndex": 1,
                "pageSize": 50,
                "keyword": keyWordS,
                "userId": userInfos.id,
                "simOnAppStatus": 0,
                "sortBy": Config.SEARCH_MY_SIM_SORT_TYPE.SELLING,               
            },
            {
                headers: {
                    Accept: 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + userToken
                },
            }).then((response) => {
                SetSortByState(Config.SEARCH_MY_SIM_SORT_TYPE.SELLING);
                SetKeyWordState(keyWordS);
                processSearchAsyncTask(response.data);
                SetLoading(false);
                return true;
            }).catch((error) => {
                ToastAndroid.showWithGravity(
                    'Tìm kiếm thất bại!',
                    ToastAndroid.SHORT,
                    ToastAndroid.BOTTOM,
                );
                SetLoading(false);
                return false;
            });
    }



    const searchFilter = (sortByX) => {
        SetLoading(true);
        axios.post(Config.BASE_URL + '/api/sim/search-sim-of-agent',
            {
                "isPaged": true,
                "pageIndex": 1,
                "pageSize": 50,
                "keyword": keyWord,
                "userId": userInfos.id,
                "simOnAppStatus": 0,
                "sortBy": sortByX,
            },
            {
                headers: {
                    Accept: 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + userToken
                },
            }).then((response) => {
                SetSortByState(sortByX);
                processSearchAsyncTask(response.data);
                SetLoading(false);
                return true;
            }).catch((error) => {
                ToastAndroid.showWithGravity(
                    'Tìm kiếm thất bại!',
                    ToastAndroid.SHORT,
                    ToastAndroid.BOTTOM,
                );
                SetLoading(false);
                return false;
            });
    }
    //  
    const ResetSearchFilter = () => {
        SetLoading(true);
        axios.post(Config.BASE_URL + '/api/sim/search-sim-of-agent',
            {
                "isPaged": true,
                "pageIndex": 1,
                "pageSize": 50,
                "keyword": keyWord,
                "userId": userInfos.id,
                "simOnAppStatus": 0,
                "sortBy": sortType,
            },
            {
                headers: {
                    Accept: 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + userToken
                },
            }).then((response) => { 
                SetSortByState(0);
                processSearchAsyncTask(response.data);
                SetLoading(false);

                return true;
            }).catch((error) => {
                ToastAndroid.showWithGravity(
                    'Tìm kiếm thất bại!',
                    ToastAndroid.SHORT,
                    ToastAndroid.BOTTOM,
                );
                SetLoading(false);
                return false;
            });
    }
    return (
        <MySimContext.Provider value={{
            SetSortBy, searchFilter, search, searchPaging, ResetSearchFilter, DeleteAllFilter, SetKeyWord, SetUpdateSubscriptionArray, setUpdateSortBy, SetResetFrame,
            pageIndex, searchResult, subscriptionTypes, keyWord, updatedSubscriptionArray, updateSortBy, sortType, isDeleteAllFilter, resetFrameState,
        }}>
            {children}
        </MySimContext.Provider>
    );
}

export { MySimContext, MySimProvider }