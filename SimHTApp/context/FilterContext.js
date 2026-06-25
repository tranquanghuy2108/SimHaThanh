import React, { createContext, useState } from 'react';

const FilterContext = createContext();

const FilterProvider = ({ children }) => {
  const [isFilterVisible, setIsFilterVisible] = useState(false);

  const setFilterState = (state = false) =>{
    setIsFilterVisible(state);
  }
  return (
    <FilterContext.Provider value={{ isFilterVisible, setFilterState}}>
      {children}
    </FilterContext.Provider>
  );
};

export { FilterContext, FilterProvider };