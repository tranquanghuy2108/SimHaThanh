import React, { createContext, useState, useContext } from "react";
import axios from "axios";
import Config from "../constants/Config";
import { AuthContext } from "./AuthContext";
import { SetLoadingContext } from "./SetLoadingContext";

const FengShuiContext = createContext();

const FengShuiProvider = ({ children }) => {

  const { userToken } = useContext(AuthContext);

  const { SetLoading } = useContext(SetLoadingContext);

  const [fortuneData, SetFortuneDataState] = useState(null);

  const [searchFortuneData, SetSearchFortuneDataState] = useState(null);


  const [pageIndex, SetPageIndexState] = useState(1);
  const [yearBirth, SetYearBirthState] = useState(null);
  const [monthBirth, SetMonthBirthState] = useState(null);
  const [dateBirth, SetDateBirthState] = useState(null);
  const [hourBirth, SetHourBirthState] = useState(null);
  const [minuteBirth, SetMinuteBirthState] = useState(null);
  const [isMale, SetIsMaleState] = useState(true);
  const [valueSimData, SetValueSimState] = useState(null);

  async function processSearchAsyncTask(responseArray) {
    try {
      if (searchFortuneData != null) {
        if (responseArray != null) {
          if (responseArray.simPhongThuys != null) {
            SetSearchFortuneDataState(prevState => ({
              ...prevState,
              simPhongThuys: responseArray.simPhongThuys
            }));
          }
        }
      }
      else {
        SetSearchFortuneDataState(responseArray);
      }



    } catch (error) {
      // Xử lý lỗi nếu có
      console.error('Error:', error);
    }
  }

  async function processPagingAsyncTask(responseArray) {
    try {
      if (searchFortuneData != null) {
        if (responseArray != null) {
          if (responseArray.simPhongThuys != null) {
            SetSearchFortuneDataState(prevState => ({
              ...prevState,
              simPhongThuys: [...prevState.simPhongThuys, ...responseArray.simPhongThuys]
            }));
          }
        }
      }
      else{
        SetSearchFortuneDataState(responseArray);
      }

    } catch (error) {
      // Xử lý lỗi nếu có
      console.error('Error:', error);
    }
  }


  const FotureTelling = (simNumber, yearOfBirth, monthOfBirth, dateOfBirth, hourOfBirth, minuteOfBirth, isMale) => {
    SetLoading(true);
    axios.post(Config.BASE_URL + '/api/sim-phong-thuy/xem-diem-sim',
      {
        "simNumber": simNumber,
        "yearOfBirth": yearOfBirth,
        "monthOfBirth": monthOfBirth,
        "dateOfBirth": dateOfBirth,
        "hourOfBirth": hourOfBirth,
        "minuteOfBirth": minuteOfBirth,
        "isMale": isMale
      },
      {
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json',
          'Authorization': 'Bearer ' + userToken
        },
      }).then((response) => {
        SetFortuneDataState(response.data);
        SetLoading(false);
        return true;
      }).catch((error) => {
        SetFortuneDataState(null);
        SetLoading(false);
        return false;
      });
  }
  const SearchPagingFotureSim = () => {
    SetLoading(true);
    axios.post(Config.BASE_URL + '/api/sim-phong-thuy/tim-sim-phong-thuy',
      {
        "pageIndex": pageIndex + 1,
        "pageSize": 50,
        "yearOfBirth": yearBirth,
        "monthOfBirth": monthBirth,
        "dateOfBirth": dateBirth,
        "hourOfBirth": hourBirth,
        "minuteOfBirth": minuteBirth,
        "isMale": isMale,
      },
      {
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json',
          'Authorization': 'Bearer ' + userToken
        },
      }).then((response) => {
        SetPageIndexState(pageIndex + 1);
        processPagingAsyncTask(response.data);
        SetLoading(false);
        return true;
      }).catch((error) => {
        SetSearchFortuneDataState(null);
        SetLoading(false);
        return false;
      });
  }

  ///
  const SearchFotureSim = (year, month, day, hour, minute, isMale) => {
    SetLoading(true);
    axios.post(Config.BASE_URL + '/api/sim-phong-thuy/tim-sim-phong-thuy',
      {

        "pageIndex": 1,
        "pageSize": 50,
        "yearOfBirth": year,
        "monthOfBirth": month,
        "dateOfBirth": day,
        "hourOfBirth": hour,
        "minuteOfBirth": minute,
        "isMale": isMale
      },
      {
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json',
          'Authorization': 'Bearer ' + userToken
        },
      }).then((response) => {

        SetYearBirthState(year);
        SetMonthBirthState(month);
        SetDateBirthState(day);
        SetHourBirthState(hour);
        SetMinuteBirthState(minute);
        SetIsMaleState(isMale);
        processSearchAsyncTask(response.data);
        SetLoading(false);
        return true;
      }).catch((error) => {
        SetSearchFortuneDataState(null);
        SetLoading(false);
        return false;
      });
  }
  const ValuateSim = (simNumber) => {
    SetLoading(true);
    axios.post(Config.BASE_URL + `/api/sim-phong-thuy/dinh-gia-sim?simNumber=${simNumber}`,
      {
      },
      {
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json',
          'Authorization': 'Bearer ' + userToken
        },
      }).then((response) => {
        var simResult = {
          "simNumber":simNumber, 
          "simValue":response.data
        }
        SetValueSimState(simResult);
        SetLoading(false);
        return true;
      }).catch((error) => {
        SetValueSimState(null);
        SetLoading(false);
        return false;
      });
  }
  const ResetValuaSimData = () => {
    SetValueSimState(null);
  }
  ///
  return (
    <FengShuiContext.Provider value={{
      fortuneData, searchFortuneData, yearBirth, monthBirth, dateBirth, hourBirth, minuteBirth, isMale, valueSimData,
      FotureTelling, SearchFotureSim, SearchPagingFotureSim, ValuateSim, ResetValuaSimData
    }}>
      {children}
    </FengShuiContext.Provider>
  );
}

export { FengShuiContext, FengShuiProvider }