import React, { createContext, useCallback, useContext, useMemo, useState } from "react";
import { AuthContext } from "./AuthContext";
import LoginRequiredModal from "../components/LoginRequiredModal";

const LoginRequiredContext = createContext(null);

const LoginRequiredProvider = ({ children, onLogin }) => {
  const { isAuthenticated } = useContext(AuthContext);
  const [isVisible, setVisible] = useState(false);

  const showLoginRequired = useCallback(() => setVisible(true), []);
  const hideLoginRequired = useCallback(() => setVisible(false), []);

  const requireLogin = useCallback(
    (action) => {
      if (!isAuthenticated) {
        showLoginRequired();
        return false;
      }

      if (typeof action === "function") action();
      return true;
    },
    [isAuthenticated, showLoginRequired],
  );

  const contextValue = useMemo(
    () => ({
      isAuthenticated,
      requireLogin,
      showLoginRequired,
      hideLoginRequired,
    }),
    [hideLoginRequired, isAuthenticated, requireLogin, showLoginRequired],
  );

  const handleLogin = () => {
    hideLoginRequired();
    onLogin();
  };

  return (
    <LoginRequiredContext.Provider value={contextValue}>
      {children}
      <LoginRequiredModal
        visible={isVisible}
        onBack={hideLoginRequired}
        onLogin={handleLogin}
      />
    </LoginRequiredContext.Provider>
  );
};

const useLoginRequired = () => {
  const context = useContext(LoginRequiredContext);
  if (!context) {
    throw new Error("useLoginRequired must be used inside LoginRequiredProvider");
  }
  return context;
};

export {
  LoginRequiredProvider,
  useLoginRequired,
};
