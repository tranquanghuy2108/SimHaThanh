import React, { createContext, useState, useContext } from "react";
import axios from "axios";
import Config from "../constants/Config";
import { AuthContext } from "./AuthContext";
import { SetLoadingContext } from "./SetLoadingContext";
import { ToastAndroid } from "react-native";
const SimDataContext = createContext();

const SimDataProvider = ({ children }) => {
  const { userToken } = useContext(AuthContext);
  const { SetLoading } = useContext(SetLoadingContext);
  const [keyWord, SetKeyWordState] = useState("");
  const [sortType, SetSortByState] = useState(0);
  const [pageIndex, SetPageIndexState] = useState(1);
  const [searchResult, SetSearchResultState] = useState(null);

  const [subscriptionTypes, SetSubscriptionState] = useState([]);

  //
  const [isDeleteAllFilter, SetDeleteAllFilter] = useState(false);

  const [updatedSubscriptionArray, SetUpdateSubscriptionArrayState] = useState(
    [],
  );

  const [updateSortBy, setUpdateSortByState] = useState(sortType);

  const [resetFrameState, SetResetFrameState] = useState(false);

  const [packageSimDatas, SetPackageSimState] = useState([]);

  const [countryData, SetCountryState] = useState([]);

  const SetUpdateSubscriptionArray = (subTyp) => {
    SetUpdateSubscriptionArrayState(subTyp);
  };
  const setUpdateSortBy = (_sortType) => {
    setUpdateSortByState(_sortType);
  };
  const SetResetFrame = (status) => {
    SetResetFrameState(status);
  };

  async function processSearchAsyncTask(responseArray) {
    try {
      // Use the response array directly to avoid extra iteration/copy cost
      SetSearchResultState(responseArray ? Array.from(responseArray) : []);
    } catch (error) {
      console.error("Error:", error);
    }
  }
  async function processPagingAsyncTask(responseArray) {
    try {
      // Concatenate new results onto existing state efficiently
      SetSearchResultState((prev) => {
        const prevArray = prev && Array.isArray(prev) ? prev : [];
        const addArray =
          responseArray && Array.isArray(responseArray) ? responseArray : [];
        return prevArray.concat(addArray);
      });
    } catch (error) {
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
        Config.BASE_URL + "/api/sim/search-sim-data",
        {
          isPaged: true,
          pageIndex: pageIndex + 1,
          pageSize: 50,
          keyword: keyWord,
          productTypeIds: subscriptionTypes,
          sortBy: sortType,
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
        console.error("Error: ", error);
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

  const search = (keyWorkS, subscriptionTypeS, options = {}) => {
    if (!(options && options.suppressLoading)) SetLoading(true);
    console.log("[Search] start, keyword:", keyWorkS);
    const _searchStart = Date.now();

    if (keyWorkS == null) {
      keyWorkS = keyWord;
    }
    if (subscriptionTypeS == null) {
      subscriptionTypeS = subscriptionTypes;
    }
    var newSimType = [];
    axios
      .post(
        Config.BASE_URL + "/api/sim/search-sim-data",
        {
          isPaged: true,
          pageIndex: 1,
          pageSize: 50,
          keyword: keyWorkS,
          productTypeIds: subscriptionTypeS,
          sortBy: Config.SEARCH_SIM_SORT_TYPE.NORMAL,
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
        SetKeyWordState(keyWorkS);
        SetSubscriptionState(subscriptionTypeS);
        SetSortByState(Config.SEARCH_SIM_SORT_TYPE.NORMAL);
        processSearchAsyncTask(response.data);
        if (!(options && options.suppressLoading)) SetLoading(false);
        console.log(`[Search] duration: ${Date.now() - _searchStart} ms`);
        console.log(
          "[Search] result count:",
          response.data ? response.data.length : 0,
        );
        return true;
      })
      .catch((error) => {
        console.error("Error: ", error);
        ToastAndroid.showWithGravity(
          "Tìm kiếm thất bại!",
          ToastAndroid.SHORT,
          ToastAndroid.BOTTOM,
        );
        if (!(options && options.suppressLoading)) SetLoading(false);
        console.log(`[Search] duration: ${Date.now() - _searchStart} ms`);
        console.log("[Search] failed for keyword:", keyWorkS);
        return false;
      });
  };

  const searchFilter = (subscriptionX, sortByX) => {
    SetLoading(true);
    axios
      .post(
        Config.BASE_URL + "/api/sim/search-sim-data",
        {
          isPaged: true,
          pageIndex: 1,
          pageSize: 50,
          keyword: keyWord,
          productTypeIds: subscriptionX,
          sortBy: sortByX,
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
        SetSubscriptionState(subscriptionX);
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
        Config.BASE_URL + "/api/sim/search-sim-data",
        {
          isPaged: true,
          pageIndex: 1,
          pageSize: 50,
          keyword: keyWord,
          productTypeIds: [],
          sortBy: sortType,
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
        SetSubscriptionState([]);
        SetSortByState(0);
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

  const GetPackageSimData = () => {
    axios
      .get(Config.BASE_URL + "/api/sim/package-of-sim-data", {
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
          Authorization: "Bearer " + userToken,
        },
      })
      .then((response) => {
        SetPackageSimState(response.data);
        SetLoading(false);
        return true;
      })
      .catch((error) => {
        console.error("Error: ", error);
        SetPackageSimState([]);
        SetLoading(false);
        return false;
      });
  };
  //
  const GetCountry = () => {
    axios
      .get(Config.BASE_URL + "/api/sim/get-country", {
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
          Authorization: "Bearer " + userToken,
        },
      })
      .then((response) => {
        SetCountryState(response.data);
        SetLoading(false);
        return true;
      })
      .catch((error) => {
        console.error("Error: ", error);
        SetCountryState([]);
        SetLoading(false);
        return false;
      });
  };
  return (
    <SimDataContext.Provider
      value={{
        SetSortBy,
        searchFilter,
        search,
        searchPaging,
        ResetSearchFilter,
        DeleteAllFilter,
        SetKeyWord,
        SetUpdateSubscriptionArray,
        setUpdateSortBy,
        SetResetFrame,
        pageIndex,
        searchResult,
        subscriptionTypes,
        keyWord,
        updatedSubscriptionArray,
        updateSortBy,
        sortType,
        isDeleteAllFilter,
        resetFrameState,

        packageSimDatas,
        GetPackageSimData,
        countryData,
        GetCountry,
      }}
    >
      {children}
    </SimDataContext.Provider>
  );
};

export { SimDataContext, SimDataProvider };
