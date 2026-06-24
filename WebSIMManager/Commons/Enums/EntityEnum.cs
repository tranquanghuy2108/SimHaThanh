namespace Commons.Enums
{
    public enum Gender
    {
        Male,
        Female,
    }

    public enum Subscription
    {
        Prepay,
        Postpaid,
        Data,
    }

    public enum StatusOrder
    {
        Order,
        WaitingApproved,
        Cancel,
        Approved,
        Success,
    }

    public enum PaymentType
    {
        COD,
        Online,
        Company,
        Installment,
    }

    public enum SearchType
    {
        sosim,
        gia,
        mang,
        loai,
        namsinh,
        dauso,
    }

    public enum SortBy
    {
        Normal,
        PriceASC,
        PriceDES,
    }

    public enum SupportContactType
    {
        Telephone,
        Telegram,
        Skype,
        Zalo,
    }

    public enum ApprovedStatus
    {
        Waiting = 1,
        Approved,
        Reject,
    }

    public enum DebtCategory
    {
        CNPS = 1,
        Staff,
        Agent,
        Bank,
        Shipping,
    }

    public enum DebtReceiveType
    {
        All = 1,
        Receivables,
        Liabilities,
    }

    public enum LogActionType
    {
        LoginSys,
        UpdateData,
    }

    public enum SimOnAppStatus
    {
        OnSales,
        Sold,
        WaitingApproved,
        All,
    }

    public enum CashActionType
    {
        NapTien = 1,
        RutTien,
        MuaSim,
        DauGia,
        Khac,
    }

    public enum FormOfPayment
    {
        Direct = 1,
        Banking,
    }

    public enum TypeOfPage
    {
        News,
        Contact,
        FengShui,
        SIMPricing,
    }

    public enum TypePriceSimOrder
    {
        Defaul,
        ForAgent,
        ForCollaborators,
    }

    public enum TypeOfReceived
    {
        Thu,
        Chi,
    }

    public enum FormatPhoneNumber
    {
        F0XXX_XXX_XXX,
        F0XXX_XX_XXXX,
        F0XXX_X_XXXXX,
        F0XXX_XX_XX_XX,
        F0X_XX_XX_XX_XX,
        F0X_XXXX_XXXX,
        F0XXX_XXXX_XX,
        F0XX_XXXX_XXX,
        F0XXX_XXXXXX,
        F0XXXX_XXX_XX,
        F0XXXX_XXXXX,
        F0XXX_X_XXXX_X,
        F0XXX_XX_XXX_X,
    }

    public enum SIMProductType
    {
        Normal,
        Data,
        Tourist,
    }
}
