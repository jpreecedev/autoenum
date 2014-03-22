using System;

namespace AutoEnum
{
    /// <summary>
    /// The AddressType enumeration
    /// </summary>
    public enum AddressType
    {
	    Archive = 1,
        Billing = 2,
        Home = 3,
        MainOffice = 4,
        Primary = 5,
        Shipping = 6   
    };

    /// <summary>
    /// The ContactType enumeration
    /// </summary>
    public enum ContactType
    {
	    AccountingManager = 1,
        AssistantSalesAgent = 2,
        AssistantSalesRepresentative = 3,
        CoordinatorForeignMarkets = 4,
        ExportAdministrator = 5,
        InternationalMarketingManager = 6,
        MarketingAssistant = 7,
        MarketingManager = 8,
        MarketingRepresentative = 9,
        OrderAdministrator = 10,
        Owner = 11,
        OwnerMarketingAssistant = 12,
        ProductManager = 13,
        PurchasingAgent = 14,
        PurchasingManager = 15,
        RegionalAccountRepresentative = 16,
        SalesAgent = 17,
        SalesAssociate = 18,
        SalesManager = 19,
        SalesRepresentative = 20   
    };

    /// <summary>
    /// The PhoneNumberType enumeration
    /// </summary>
    public enum PhoneNumberType
    {
	    Cell = 1,
        Home = 2,
        Work = 3   
    };

}