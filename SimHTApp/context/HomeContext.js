import React, { createContext, useEffect, useContext, useState } from "react";
import AsyncStorage from "@react-native-async-storage/async-storage";
import axios from "axios";
import Config from "../constants/Config";
import { AuthContext } from "./AuthContext";

import { SetLoadingContext } from "./SetLoadingContext";
const HomeContext = createContext();

const SimTypeInit = [
  {
    id: 1,
    name: "Ngũ quý",
    format: "AAAAA",
    description:
      "*00000,*11111,*22222,*33333,*44444,*55555,*66666,*77777,*88888,*99999",
    type: 0,
  },
  {
    id: 2,
    name: "Tứ quý",
    format: "AAAA",
    description: "*0000,*1111,*2222,*3333,*4444,*5555,*6666,*7777,*8888,*9999",
    type: 0,
  },
  {
    id: 24,
    name: "Tứ quý giữa",
    format: "AAAA.",
    description: "",
    type: 0,
  },
  {
    id: 4,
    name: "Tam hoa kép",
    format: "AAA.BBB",
    description: "",
    type: 0,
  },
  {
    id: 6,
    name: "Tam hoa",
    format: ".AAA",
    description: "*000,*111,*222,*333,*444,*555,*666,*777,*888,*999",
    type: 0,
  },
  {
    id: 3,
    name: "Taxi",
    format: "BAA.BAA",
    description: "",
  },
  {
    id: 7,
    name: "Tiến đơn 5",
    format: "ABCDE",
    description: "",
  },
  {
    id: 8,
    name: "Tiến đơn 4",
    format: "ABCD",
    description: "",
  },
  {
    id: 9,
    name: "Tiến 3 kép",
    format: "ABC.ABC",
    description: "",
  },
  {
    id: 12,
    name: "Tiến đơn 3",
    format: "ABC",
    description: "*012,*123,*234,*345,*456,*567,*678,*789",
  },
  {
    id: 28,
    name: "Số gánh",
    format: "ABA",
    description: "",
  },
  {
    id: 26,
    name: "Gánh đôi",
    format: "ABA.CDC",
    description: "",
  },
  {
    id: 15,
    name: "Lộc phát",
    format: "68",
    description: "*68",
  },
  {
    id: 13,
    name: "Thần tài",
    format: "79-39",
    description: "*79,*39",
  },
  {
    id: 20,
    name: "Ông địa",
    format: "78-38",
    description: "*78,*38",
  },
  {
    id: 10,
    name: "Số đặc biệt",
    format: "SPECIAL",
    description: "",
  },
  {
    id: 11,
    name: "Tiến đặc biệt",
    format: "SPECIAL_UP",
    description: "",
  },
  {
    id: 31,
    name: "Năm sinh",
    format: "19bx",
    description: "",
  },

  {
    id: 23,
    name: "Tiến giữa",
    format: "123.xxx",
    description: "*012*,*123*,*234*,*345*,*456*,*567*,*678*,*789*",
  },
  {
    id: 30,
    name: "Sim số đẹp",
    format: "AB.CB.DB",
    description: "",
  },

  {
    id: 16,
    name: "Phát lộc",
    format: "86",
    description: "*86",
  },
  {
    id: 17,
    name: "Cửu cửu",
    format: "99",
    description: "*99",
  },
  {
    id: 18,
    name: "Phát phát",
    format: "88",
    description: "*88",
  },
];

const HomeProvider = ({ children }) => {
  const [flashSaleData, SetFlashSaleData] = useState(null);
  const [dayPromotionData, SetDayPromotion] = useState(null);
  const [lasUpdateData, SetLastUpdateSim] = useState(null);
  const [simTypeDatas, SetSimTypes] = useState(null);
  const [netWorkDatas, SetNetWorks] = useState(null);

  const { userToken } = useContext(AuthContext);

  const [popUpData, SetPopUpDataState] = useState(null);
  const [isPopupVisible, setPopupVisibleState] = useState(false);
  const { SetLoading } = useContext(SetLoadingContext);

  const SetPopUpVisible = (active) => {
    setPopupVisibleState(active);
  };
  const SetPopUpData = (data) => {
    SetPopUpDataState(data);
  };

  const GetNetWorkTypes = () => {
    SetLoading(true);
    axios
      .get(Config.BASE_URL + "/api/sim/all-network-infos", {
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
          Authorization: "Bearer " + userToken,
        },
      })
      .then((response) => {
        SetNetWorks(response.data);
        SetLoading(false);
        return true;
      })
      .catch((error) => {
        SetLoading(false);
        return false;
      });
  };

  const GetSimTypes = async () => {
    SetLoading(true);
    try {
      const response = await axios.get(
        Config.BASE_URL + "/api/sim/all-simtype-infos",
        {
          headers: {
            Accept: "application/json",
            "Content-Type": "application/json",
            Authorization: "Bearer " + userToken,
          },
        },
      );
      SetSimTypes(response.data);
      SetLoading(false);
      return true;
    } catch (error) {
      SetLoading(false);
      return false;
    }
  };
  const GetSimTypesFake = async () => {
    SetSimTypes(SimTypeInit);
  };

  const GetFlashSale = async () => {
    SetLoading(true);
    try {
      const response = await axios.get(
        Config.BASE_URL + "/api/sim/sim-flash-sale",
        {
          headers: {
            Accept: "application/json",
            "Content-Type": "application/json",
            Authorization: "Bearer " + userToken,
          },
        },
      );
      SetFlashSaleData(response.data);
      SetLoading(false);
      return true;
    } catch (error) {
      SetLoading(false);
      return false;
    }
  };
  const GetDayPromotion = async () => {
    SetLoading(true);
    try {
      const response = await axios.get(
        Config.BASE_URL + "/api/sim/sim-sale-on-day",
        {
          headers: {
            Accept: "application/json",
            "Content-Type": "application/json",
            Authorization: "Bearer " + userToken,
          },
        },
      );
      SetDayPromotion(response.data);
      SetLoading(false);
      return true;
    } catch (error) {
      SetLoading(false);
      return false;
    }
  };
  const GetSimLastUpdate = async () => {
    SetLoading(true);
    try {
      const response = await axios.get(
        Config.BASE_URL + "/api/sim/sim-last-update",
        {
          headers: {
            Accept: "application/json",
            "Content-Type": "application/json",
            Authorization: "Bearer " + userToken,
          },
        },
      );
      SetLastUpdateSim(response.data);
      SetLoading(false);
      return true;
    } catch (error) {
      SetLoading(false);
      return false;
    }
  };
  return (
    <HomeContext.Provider
      value={{
        flashSaleData,
        dayPromotionData,
        lasUpdateData,
        simTypeDatas,
        netWorkDatas,
        GetFlashSale,
        GetDayPromotion,
        GetNetWorkTypes,
        GetSimLastUpdate,
        GetSimTypes,
        GetSimTypesFake,
        isPopupVisible,
        popUpData,
        SetPopUpVisible,
        SetPopUpData,
      }}
    >
      {children}
    </HomeContext.Provider>
  );
};
export { HomeContext, HomeProvider };
