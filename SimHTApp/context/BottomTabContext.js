import React, { createContext, useState } from "react";

const BottomTabContext = createContext();

const BottomTabProvider = ({ children }) => {
  const [currentSearchKey, SetCurrentSearchState] = useState("");
  const [orderKeyWordSearch, SetOrderKeyWorkSearchState] = useState("");
  const [searchDataKey, SetSearchDataState] = useState("");
  const [searchMySimKey, SetSearchMySimState] = useState("");
  const [unReadMessCount, SetUnReadMessCount] = useState(0);
  const [isCollabPopUpVisible, setCollabPopUpVisible] = useState(false);
  const [isEnterCodeCollabPopUpVisible, setEnterCodeCollabPopUpVisible] =
    useState(false);
  const [isCreateCollabPopUpVisible, setCreateCollabPopUpVisible] =
    useState(false);

  const [simGroupDatas, SetSimGroupState] = useState([]);

  const toggleCollabPopUp = () => {
    setCollabPopUpVisible(!isCollabPopUpVisible);
  };
  const toggleEnterCodeCollabPopUp = () => {
    setEnterCodeCollabPopUpVisible(!isEnterCodeCollabPopUpVisible);
  };
  const toggleCreateCollabPopUp = () => {
    setCreateCollabPopUpVisible(!isCreateCollabPopUpVisible);
  };

  const SetCurrentSearch = (searchKey) => {
    SetCurrentSearchState(searchKey);
  };
  const SetOrderKeyWorkSearch = (keyword) => {
    SetOrderKeyWorkSearchState(keyword);
  };

  const SetDataKeySearch = (keyword) => {
    SetSearchDataState(keyword);
  };
  const SetSearchMySim = (keyword) => {
    SetSearchMySimState(keyword);
  };

  const SetSimGroupData = (_simGroupData) => {
    SetSimGroupState(_simGroupData);
  };

  return (
    <BottomTabContext.Provider
      value={{
        SetCurrentSearch,
        SetOrderKeyWorkSearch,
        SetDataKeySearch,
        SetSearchMySim,
        currentSearchKey,
        orderKeyWordSearch,
        searchDataKey,
        searchMySimKey,
        SetUnReadMessCount,
        unReadMessCount,
        toggleCollabPopUp,
        toggleEnterCodeCollabPopUp,
        toggleCreateCollabPopUp,
        isCollabPopUpVisible,
        isEnterCodeCollabPopUpVisible,
        isCreateCollabPopUpVisible,

        simGroupDatas,
        SetSimGroupData,
      }}
    >
      {children}
    </BottomTabContext.Provider>
  );
};

export { BottomTabContext, BottomTabProvider };
