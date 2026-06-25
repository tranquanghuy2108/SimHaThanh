import React, { createContext, useState, useContext } from "react";
import axios from "axios";
import Config from "../constants/Config";
import { AuthContext } from "./AuthContext";
import { SetLoadingContext } from "./SetLoadingContext";
import { ToastAndroid } from "react-native";
const SearchContext = createContext();

const SearchProvider = ({ children }) => {
  const { userToken, userInfos } = useContext(AuthContext);
  const { SetLoading } = useContext(SetLoadingContext);
  const [keyWord, SetKeyWordState] = useState("");
  const [networkTypes, SetNetWorksState] = useState([]);
  const [price, SetPriceState] = useState({ min: 0, max: 0 });
  const [simTypes, SetSimTypeState] = useState(null);
  const [sortType, SetSortByState] = useState(0);
  const [pageIndex, SetPageIndexState] = useState(1);
  const [searchResult, SetSearchResultState] = useState(null);

  const [subscriptionTypes, SetSubscriptionState] = useState([]);
  const [avoidNumberTypes, SetAvoidNumberState] = useState([]);
  const [prefixTypes, SetPrefixState] = useState([]);
  const [isAvoidSixDigit, SetAvoidSixDigitState] = useState(true);
  //
  const [isDeleteAllFilter, SetDeleteAllFilter] = useState(false);

  const [simUserInfo, SetSimUserState] = useState(null);

  async function processSearchAsyncTask(responseArray) {
    try {
      // Use response array directly to reduce processing overhead
      SetSearchResultState(responseArray ? Array.from(responseArray) : []);
    } catch (error) {
      // Xử lý lỗi nếu có
      console.error("Error:", error);
    }
  }
  async function processPagingAsyncTask(responseArray) {
    try {
      SetSearchResultState((prev) => {
        const prevArray = prev && Array.isArray(prev) ? prev : [];
        const addArray =
          responseArray && Array.isArray(responseArray) ? responseArray : [];
        return prevArray.concat(addArray);
      });
    } catch (error) {
      // Xử lý lỗi nếu có
      console.error("Error:", error);
    }
  }
  const SetSortBy = (_sortBy) => {
    const sortByParse = parseInt(_sortBy);
    SetSortByState(sortByParse);
  };
  //
  const searchPaging = (options = {}) => {
    if (!(options && options.suppressLoading)) SetLoading(true);
    axios
      .post(
        Config.BASE_URL + "/api/sim/search",
        {
          isPaged: true,
          pageIndex: pageIndex + 1,
          pageSize: 50,
          keyword: keyWord,
          networkIds: networkTypes,
          simTypeIds: simTypes == null ? [] : [simTypes],
          prefixs: prefixTypes,
          productTypeIds: subscriptionTypes,
          avoidNums: avoidNumberTypes,
          avoidSixNum: isAvoidSixDigit,
          sortBy: sortType,
          priceFrom: price.min,
          priceTo: price.max,
          userId: userInfos.id,
        },
        {
          headers: {
            Accept: "application/json",
            "Content-Type": "application/json",
            Authorization: "Bearer " + userToken,
          },
        },
      )
      .then((response) => {
        processPagingAsyncTask(response.data);
        SetPageIndexState(pageIndex + 1);
        if (!(options && options.suppressLoading)) SetLoading(false);
        return true;
      })
      .catch((error) => {
        ToastAndroid.showWithGravity(
          "Tìm kiếm thất bại!",
          ToastAndroid.SHORT,
          ToastAndroid.BOTTOM,
        );
        if (!(options && options.suppressLoading)) SetLoading(false);
        return false;
      });
  };

  //
  const DeleteAllFilter = () => {
    SetDeleteAllFilter(true);
  };

  //
  const SetKeyWord = (keyword) => {
    SetKeyWordState(keyword);
  };

  //
  const search = (keyWorkS, pricesX, netWorkS, simTypeS, options = {}) => {
    if (!(options && options.suppressLoading)) SetLoading(true);

    if (keyWorkS == null) {
      keyWorkS = keyWord;
    }
    if (pricesX == null) {
      pricesX = price;
    }
    if (netWorkS == null) {
      netWorkS = networkTypes;
    }
    var newSimType = [];
    axios
      .post(
        Config.BASE_URL + "/api/sim/search",
        {
          isPaged: true,
          pageIndex: 1,
          pageSize: 50,
          keyword: keyWorkS,
          networkIds: netWorkS,
          simTypeIds:
            simTypeS == null
              ? simTypes == null
                ? []
                : [simTypes]
              : [simTypeS],
          prefixs: prefixTypes,
          productTypeIds: subscriptionTypes,
          avoidNums: avoidNumberTypes,
          avoidSixNum: isAvoidSixDigit,
          sordBy: Config.SEARCH_SIM_SORT_TYPE.NORMAL,
          priceFrom: pricesX.min,
          priceTo: pricesX.max,
          userId: userInfos.id,
        },
        {
          headers: {
            Accept: "application/json",
            "Content-Type": "application/json",
            Authorization: "Bearer " + userToken,
          },
        },
      )
      .then((response) => {
        SetNetWorksState(netWorkS);
        SetPriceState({ min: pricesX.min, max: pricesX.max });
        SetSimTypeState(simTypeS);
        SetKeyWordState(keyWorkS);
        processSearchAsyncTask(response.data);
        SetSortByState(Config.SEARCH_SIM_SORT_TYPE.NORMAL);
        if (!(options && options.suppressLoading)) SetLoading(false);
        return true;
      })
      .catch((error) => {
        ToastAndroid.showWithGravity(
          "Tìm kiếm thất bại!",
          ToastAndroid.SHORT,
          ToastAndroid.BOTTOM,
        );
        if (!(options && options.suppressLoading)) SetLoading(false);
        return false;
      });
  };
  const searchFilter = (
    networkTypesX,
    simTypesX,
    priceMin,
    priceMax,
    subscriptionX,
    avoidNumberX,
    prefixNumberX,
    isAvoidSix,
    sortByX,
  ) => {
    SetLoading(true);
    axios
      .post(
        Config.BASE_URL + "/api/sim/search",
        {
          isPaged: true,
          pageIndex: 1,
          pageSize: 50,
          keyword: keyWord,
          networkIds: networkTypesX,
          simTypeIds: simTypesX == null ? [] : [simTypesX],
          prefixs: prefixNumberX,
          productTypeIds: subscriptionX,
          avoidNums: avoidNumberX,
          avoidSixNum: isAvoidSix,
          sortBy: sortByX,
          priceFrom: priceMin,
          priceTo: priceMax,
          userId: userInfos.id,
        },
        {
          headers: {
            Accept: "application/json",
            "Content-Type": "application/json",
            Authorization: "Bearer " + userToken,
          },
        },
      )
      .then((response) => {
        SetNetWorksState(networkTypesX);
        SetPriceState({ min: priceMin, max: priceMax });
        SetSimTypeState(simTypesX);
        SetSubscriptionState(subscriptionX);
        SetAvoidNumberState(avoidNumberX);
        SetPrefixState(prefixNumberX);
        SetAvoidSixDigitState(isAvoidSix);
        SetSortByState(sortByX);
        processSearchAsyncTask(response.data);

        SetLoading(false);

        return true;
      })
      .catch((error) => {
        console.error("Error: ", error);
        ToastAndroid.showWithGravity(
          "Tìm kiếm thất bại!",
          ToastAndroid.SHORT,
          ToastAndroid.BOTTOM,
        );
        SetLoading(false);
        return false;
      });
  };
  //
  const ResetSearchFilter = () => {
    SetLoading(true);
    axios
      .post(
        Config.BASE_URL + "/api/sim/search",
        {
          isPaged: true,
          pageIndex: 1,
          pageSize: 50,
          keyword: keyWord,
          networkIds: [],
          simTypeIds: [],
          prefixs: [],
          productTypeIds: [],
          avoidNums: [],
          avoidSixNum: true,
          sortBy: sortType,
          priceFrom: 0,
          priceTo: 0,
          userId: userInfos.id,
        },
        {
          headers: {
            Accept: "application/json",
            "Content-Type": "application/json",
            Authorization: "Bearer " + userToken,
          },
        },
      )
      .then((response) => {
        SetNetWorksState([]);
        SetPriceState({ min: 0, max: 0 });
        SetSimTypeState(null);
        SetSubscriptionState([]);
        SetAvoidNumberState([]);
        SetPrefixState([]);
        SetSortByState(0);
        SetAvoidSixDigitState(true);
        processSearchAsyncTask(response.data);
        SetDeleteAllFilter(false);
        SetLoading(false);

        return true;
      })
      .catch((error) => {
        console.error("Error: ", error);
        ToastAndroid.showWithGravity(
          "Tìm kiếm thất bại!",
          ToastAndroid.SHORT,
          ToastAndroid.BOTTOM,
        );
        SetLoading(false);
        return false;
      });
  };

  const GetSimOfUserInfo = () => {
    SetLoading(true);
    axios
      .post(Config.BASE_URL + "/api/sim/sim-of-user", userInfos.id, {
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
          Authorization: "Bearer " + userToken,
        },
      })
      .then((response) => {
        SetSimUserState(response.data);
        SetLoading(false);
        return true;
      })
      .catch((error) => {
        console.error("Error: ", error);
        SetSimUserState(null);
        SetLoading(false);
        return false;
      });
  };

  return (
    <SearchContext.Provider
      value={{
        SetSortBy,
        searchFilter,
        search,
        searchPaging,
        ResetSearchFilter,
        DeleteAllFilter,
        SetKeyWord,
        pageIndex,
        searchResult,
        networkTypes,
        subscriptionTypes,
        keyWord,
        prefixTypes,
        avoidNumberTypes,
        isAvoidSixDigit,
        price,
        simTypes,
        sortType,
        isDeleteAllFilter,

        simUserInfo,
        GetSimOfUserInfo,
      }}
    >
      {children}
    </SearchContext.Provider>
  );
};

export { SearchContext, SearchProvider };
