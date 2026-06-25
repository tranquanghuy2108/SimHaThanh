import React, { createContext, useState, useContext } from "react";
import axios from "axios";
import Config from "../constants/Config";
import { AuthContext } from "./AuthContext";
import { SetLoadingContext } from "./SetLoadingContext";
import { ToastAndroid } from "react-native";
const AutionContext = createContext();

const AutionProvider = ({ children }) => {
  const { userInfos, userToken } = useContext(AuthContext);
  const { SetLoading } = useContext(SetLoadingContext);
  //

  const [currentAuctionData, SetCurrentAuctionState] = useState(null);
  const [myAuctionData, SetMyAuctionState] = useState(null);
  const [allAuctionData, SetAllAuctionState] = useState(null);
  const [pageIndex, SetPageIndexState] = useState(1);

  async function processAsyncTask(responseArray) {
    try {
      const newSearchResult = [];

      if (responseArray != null) {
        responseArray.map((item) => {
          if (!newSearchResult.some((element) => element.id === item.id)) {
            newSearchResult.push(item);
          }
        });
      }
      SetAllAuctionState(newSearchResult);
    } catch (error) {
      // Xử lý lỗi nếu có
      console.error("Error:", error);
    }
  }

  async function processPagingAsyncTask(responseArray) {
    try {
      const newSearchResult = [];
      if (allAuctionData != null) {
        allAuctionData.map((item) => {
          newSearchResult.push(item);
        });
      }

      if (responseArray != null) {
        responseArray.map((item) => {
          if (!newSearchResult.some((element) => element.id === item.id)) {
            newSearchResult.push(item);
          }
        });
      }
      SetAllAuctionState(newSearchResult);
    } catch (error) {
      // Xử lý lỗi nếu có
      console.error("Error:", error);
    }
  }

  const GetCurrentAuction = () => {
    SetLoading(true);
    axios
      .post(
        Config.BASE_URL + "/api/auction/get-current-auction",
        {},
        {
          headers: {
            Accept: "application/json",
            "Content-Type": "application/json",
            Authorization: "Bearer " + userToken,
          },
        },
      )
      .then((response) => {
        SetCurrentAuctionState(response.data.data);
        SetLoading(false);
        return true;
      })
      .catch((error) => {
        SetCurrentAuctionState(null);
        SetLoading(false);
        return false;
      });
  };

  //
  const GetMyAuction = () => {
    SetLoading(true);
    axios
      .post(Config.BASE_URL + `/api/auction/get-my-auction`, userInfos.id, {
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
          Authorization: "Bearer " + userToken,
        },
      })
      .then((response) => {
        SetMyAuctionState(response.data.data);
        SetLoading(false);
        return true;
      })
      .catch((error) => {
        SetMyAuctionState(null);
        SetLoading(false);
        return false;
      });
  };

  const Bidding = (auctionID, price) => {
    SetLoading(true);
    axios
      .post(
        Config.BASE_URL + `/api/auction/bidding-auction`,
        {
          id: 1111,
          auctionId: auctionID,
          userId: userInfos.id,
          userName: userInfos.username,
          price: parseInt(price),
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
        if (response.data.code === "1") {
          ToastAndroid.showWithGravity(
            "Tham gia đấu giá thành công!",
            ToastAndroid.SHORT,
            ToastAndroid.BOTTOM,
          );
          GetMyAuction();
          GetAllAuction();
          GetCurrentAuction();
        } else {
          ToastAndroid.showWithGravity(
            `Tham gia thất bại. ${response.data.message}`,
            ToastAndroid.LONG,
            ToastAndroid.BOTTOM,
          );
        }

        SetLoading(false);
        return true;
      })
      .catch((error) => {
        ToastAndroid.showWithGravity(
          `Tham gia thất bại. ${error.response.data.message}`,
          ToastAndroid.LONG,
          ToastAndroid.BOTTOM,
        );
        SetLoading(false);
        return false;
      });
  };

  //
  const GetAllAuctionPaging = () => {
    SetLoading(true);
    var currentPage = pageIndex + 1;
    axios
      .post(
        Config.BASE_URL + `/api/auction/get-all-auction`,
        {
          isPaged: true,
          pageIndex: currentPage,
          pageSize: 50,
          keyword: "",
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
        processPagingAsyncTask(response.data.data);
        SetPageIndexState(currentPage);
        SetLoading(false);
        return true;
      })
      .catch((error) => {
        SetPageIndexState([]);
        SetLoading(false);
        return false;
      });
  };

  const GetAllAuction = () => {
    SetLoading(true);
    axios
      .post(
        Config.BASE_URL + `/api/auction/get-all-auction`,
        {
          isPaged: true,
          pageIndex: 1,
          pageSize: 50,
          keyword: "",
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
        processAsyncTask(response.data.data);
        SetLoading(false);
        return true;
      })
      .catch((error) => {
        SetPageIndexState([]);
        SetLoading(false);
        return false;
      });
  };

  return (
    <AutionContext.Provider
      value={{
        currentAuctionData,
        myAuctionData,
        allAuctionData,
        GetCurrentAuction,
        Bidding,
        GetMyAuction,
        GetAllAuction,
        GetAllAuctionPaging,
      }}
    >
      {children}
    </AutionContext.Provider>
  );
};

export { AutionContext, AutionProvider };
