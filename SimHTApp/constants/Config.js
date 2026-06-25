const SEND_BIRD_APP_ID = "8A3987D2-65D2-4685-99F7-2F9519CADAF1";
export default {
  BASE_URL: "https://api.simhathanh.vn",
  SEND_BIRD_APP_ID: SEND_BIRD_APP_ID, //Sendbird
  SEND_BIRD_API_TOKEN: "3d75e76855d910aeff8c56e25b9f1103795c0063",
  SENDBIRD_URL: `https://api-${SEND_BIRD_APP_ID}.sendbird.com/v3`,
  VINAPHONE_CUSTOMER_ID: "262897",
  SEND_BIRD_SUPPORT_ID: "supportSimHT",
  AUCTION_WAIT_COUNT: 1,
  SP_CONTACT: {
    ZALO: "Zalo",
    CALL: "Call",
  },
  SEARCH_SIM_SORT_TYPE: {
    NORMAL: 0,
    LOW_PRICE: 1,
    HIGH_PRICE: 2,
  },
  SEARCH_MY_SIM_SORT_TYPE: {
    SELLING: 0,
    SOLD: 1,
    WAIT_APPROVED: 2,
  },
  PAY_ORDER_TYPE: {
    DIRECT: "Trực tiếp",
    INSTALLMENT: "Trả góp",
  },
};
