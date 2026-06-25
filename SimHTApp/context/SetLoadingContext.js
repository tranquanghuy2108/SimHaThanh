import React, { createContext, useState } from "react";


const SetLoadingContext = createContext();

const SetLoadingProvider = ({ children }) => {

    const [isLoading,SetLoadingState] = useState(false);

    const SetLoading = ( loading) =>{
        SetLoadingState(loading);
    }
    return (
        <SetLoadingContext.Provider value={{
            isLoading,SetLoading

        }}>
            {children}
        </SetLoadingContext.Provider>
    );
}
export { SetLoadingContext, SetLoadingProvider }