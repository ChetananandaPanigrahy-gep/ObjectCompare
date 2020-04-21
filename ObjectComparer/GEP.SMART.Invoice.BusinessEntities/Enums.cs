using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public enum DocumentOrigin
    {
        [EnumMember(Value = "CreatedBySupplier")]
        CreatedBySupplier = 0,

        [EnumMember(Value = "CreatedByBuyer")]
        CreatedByBuyer = 1
    }

    [DataContract]
    [Serializable]
    public enum TemplateTypeReference
    {
        [EnumMember(Value = "By User Local Culture")]
        ByUserLocalCulture = 1,

        [EnumMember(Value = "By Supplier Local Culture")]
        BySupplierLocalCulture = 2,

        [EnumMember(Value = "By Division_EntityCode_EntityDetailCode")]
        ByDivision_EntityCode_EntityDetailCode = 3,

        [EnumMember(Value = "By Division")]
        ByDivision = 4
    }

    [DataContract]
    [Serializable]
    public enum ShipToLocationDefaultingCriteria
    {
        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        LoggedinUser = 1,

        [EnumMember(Value = "2")]
        OrderContact = 2,

        [EnumMember(Value = "3")]
        HeaderEntity = 3,
    }

    [DataContract]
    [Serializable]
    public enum ExcelFileType
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "InvoiceExcel")]
        InvoiceExcel = 1,

        [EnumMember(Value = "InvoiceExcelTemplate")]
        InvoiceExcelTemplate = 2,

        [EnumMember(Value = "InvoiceExcelMasterTemplate")]
        InvoiceExcelMasterTemplate = 3,

        [EnumMember(Value = "BuyerInvoiceExcelTemplate")]
        BuyerInvoiceExcelTemplate = 4,

        [EnumMember(Value = "BuyerInvoiceExcelMasterTemplate")]
        BuyerInvoiceExcelMasterTemplate = 5,

        [EnumMember(Value = "SupplierInvoiceExcelTemplate")]
        SupplierInvoiceExcelTemplate = 6,

        [EnumMember(Value = "SupplierBuyerInvoiceExcelMasterTemplate")]
        SupplierBuyerInvoiceExcelMasterTemplate = 7,

        [EnumMember(Value = "ReceiptAssetOrSerialTagTemplate")]
        ReceiptAssetOrSerialTagTemplate = 8
    }

    [DataContract]
    [Serializable]
    public enum InvoiceResultCode
    {
        [EnumMember(Value = "Success")]
        Success = 1,

        [EnumMember(Value = "Fail")]
        Fail = 0,
    }

    [DataContract]
    [Serializable]
    public enum DateFormatType
    {
        [EnumMember(Value = "1")]
        commentdate = 1,

        [EnumMember(Value = "2")]
        formattedUtcDate = 2,

        [EnumMember(Value = "3")]
        DefaultDate = 3,

        [EnumMember(Value = "4")]
        CustomDate = 4,

        [EnumMember(Value = "5")]
        CustomDateDateFirst = 5,

        [EnumMember(Value = "6")]
        CustomDateMonthFirst = 6
    }

    [DataContract]
    [Serializable]
    public enum ItemHistoryIconType
    {
        [EnumMember(Value = "0")]
        GrayNoHistory = 0,

        [EnumMember(Value = "1")]
        OrangeHasExceptions = 1,

        [EnumMember(Value = "2")]
        GreenNoExceptions = 2
    }

    [DataContract]
    [Serializable]
    public enum Operations
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "Create")]
        Create = 1,

        [EnumMember(Value = "Update")]
        Update = 2,

        [EnumMember(Value = "Delete")]
        Delete = 3
    }

    [DataContract]
    [Serializable]
    public enum ParentEntityType
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "Organization")]
        Organization = 1,

        [EnumMember(Value = "Accounting")]
        Accounting = 2,

        [EnumMember(Value = "Independent")]
        Independent = 3,
    }

    [DataContract]
    [Serializable]
    public enum MappingType
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "Direct")]
        Direct = 1,

        [EnumMember(Value = "Reverse")]
        Reverse = 2,
    }

    [DataContract]
    [Serializable]
    public enum DataDisplayStyle
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "EntityCodeDescription")]
        EntityCodeDescription = 1,

        [EnumMember(Value = "DescriptionEntityCode")]
        DescriptionEntityCode = 2,

        [EnumMember(Value = "Description")]
        Description = 3
    }

    [DataContract]
    [Serializable]
    public enum LevelType
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "HeaderLevel")]
        HeaderLevel = 1,

        [EnumMember(Value = "ItemLevel")]
        ItemLevel = 2,

        [EnumMember(Value = "Both")]
        Both = 3
    }

    [DataContract]
    [Serializable]
    public enum FieldControls
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "Label")]
        Lable = 1,

        [EnumMember(Value = "TextBox")]
        TextBox = 2,

        [EnumMember(Value = "AutoSuggestTextBox")]
        AutoSuggestTextBox = 3,

        [EnumMember(Value = "CustomAttributes")]
        CustomAttributes = 4
    }

    [DataContract]
    [Serializable]
    public enum SourceType
    {
        [EnumMember(Value = "ItemMaster")]
        ItemMaster = 0,

        [EnumMember(Value = "Supplier")]
        Supplier = 1,

        [EnumMember(Value = "BPO")]
        BPO = 2
    }

    [DataContract]
    [Serializable]
    public enum preferenceLOBType
    {
        [EnumMember(Value = "-1")]
        All = -1,

        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        Belong = 1,

        [EnumMember(Value = "2")]
        Serve = 2,
    }

    [DataContract]
    [Serializable]
    public enum OnEvent
    {
        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        OnSubmit = 1,

        [EnumMember(Value = "2")]
        OnSendToSupplier = 2,

        [EnumMember(Value = "3")]
        SaveAsDraft = 3,

        [EnumMember(Value = "4")]
        OnSubmitFromManageApproval = 4,

        [EnumMember(Value = "5")]
        OnApprove = 5,

        [EnumMember(Value = "6")]
        OnDemandTaxCalculation = 6,

        [EnumMember(Value = "7")]
        OnAutoCreateDocument = 7
    }

    [DataContract]
    [Serializable]
    public enum ConfigType
    {
        [EnumMember(Value = "0")]
        HeaderLevel = 0,

        [EnumMember(Value = "1")]
        GridLevel = 1
    }

    [DataContract]
    [Serializable]
    public enum NoteOrAttachmentType
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "File")]
        File = 1,

        [EnumMember(Value = "Notes")]
        Notes = 2,

        [EnumMember(Value = "ExternalLink")]
        ExternalLink = 3
    }

    [DataContract]
    [Serializable]
    public enum NoteOrAttachmentAccessType
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "Internal")]
        Internal = 1,

        [EnumMember(Value = "External")]
        External = 2
    }

    #region Invoice Enums

    //[DataContract]
    //[Serializable]
    //public enum MatchStatus
    //{
    //    [EnumMember(Value = "None")]
    //    None = 0,
    //    [EnumMember(Value = "Matched")]
    //    Matched = 1,
    //    [EnumMember(Value = "Exception")]
    //    Exception = 2,
    //    [EnumMember(Value = "MatchedQuantity")]
    //    MatchedQuantity = 3,
    //    [EnumMember(Value = "UnderQuantity")]
    //    UnderQuantity = 4,
    //    [EnumMember(Value = "OverQuantity")]
    //    OverQuantity = 5,
    //    [EnumMember(Value = "UnreceivedQuantity")]
    //    UnreceivedQuantity = 6,
    //    [EnumMember(Value = "MatchedUnitPrice")]
    //    MatchedUnitPrice = 7,
    //    [EnumMember(Value = "UnderUnitPrice")]
    //    UnderUnitPrice = 8,
    //    [EnumMember(Value = "OverUnitPrice")]
    //    OverUnitPrice = 9,
    //    [EnumMember(Value = "MatchedItemValue")]
    //    MatchedItemValue = 10,
    //    [EnumMember(Value = "UnderItemValue")]
    //    UnderItemValue = 11,
    //    [EnumMember(Value = "OverItemValue")]
    //    OverItemValue = 12,
    //    [EnumMember(Value = "MatchedItemTotal")]
    //    MatchedItemTotal = 13,
    //    [EnumMember(Value = "UnderItemTotal")]
    //    UnderItemTotal = 14,
    //    [EnumMember(Value = "OverItemTotal")]
    //    OverItemTotal = 15,
    //    [EnumMember(Value = "MatchedTax")]
    //    MatchedTax = 16,
    //    [EnumMember(Value = "UnderTax")]
    //    UnderTax = 17,
    //    [EnumMember(Value = "OverTax")]
    //    OverTax = 18,
    //    [EnumMember(Value = "MatchedShipping")]
    //    MatchedShipping = 19,
    //    [EnumMember(Value = "UnderShipping")]
    //    UnderShipping = 20,
    //    [EnumMember(Value = "OverShipping")]
    //    OverShipping = 21,
    //    [EnumMember(Value = "MatchedCharges")]
    //    MatchedCharges = 22,
    //    [EnumMember(Value = "UnderCharges")]
    //    UnderCharges = 23,
    //    [EnumMember(Value = "OverCharges")]
    //    OverCharges = 24,
    //    [EnumMember(Value = "MatchedTotalAmount")]
    //    MatchedTotalAmount = 25,
    //    [EnumMember(Value = "UnderTotalAmount")]
    //    UnderTotalAmount = 26,
    //    [EnumMember(Value = "OverTotalAmount")]
    //    OverTotalAmount = 27,
    //    [EnumMember(Value = "MatchedUOM")]
    //    MatchedUOM = 28,
    //    [EnumMember(Value = "UnmatchedUOM")]
    //    UnmatchedUOM = 29,
    //    [EnumMember(Value = "MatchedWithTolerance")]
    //    MatchedWithTolerance = 30,
    //    [EnumMember(Value = "MatchedWithToleranceQuantity")]
    //    MatchedWithToleranceQuantity = 31,
    //    [EnumMember(Value = "MatchedWithToleranceUnitPrice")]
    //    MatchedWithToleranceUnitPrice = 32,
    //    [EnumMember(Value = "MatchedWithToleranceTax")]
    //    MatchedWithToleranceTax = 33,
    //    [EnumMember(Value = "MatchedWithToleranceShipping")]
    //    MatchedWithToleranceShipping = 34,
    //    [EnumMember(Value = "MatchedWithToleranceCharges")]
    //    MatchedWithToleranceCharges = 35,
    //    [EnumMember(Value = "MatchedWithToleranceItemTotal")]
    //    MatchedWithToleranceItemTotal = 36,
    //    [EnumMember(Value = "MatchedWithToleranceTotalAmount")]
    //    MatchedWithToleranceTotalAmount = 37,
    //    [EnumMember(Value = "NonPOException")]
    //    NonPOException = 38,
    //    [EnumMember(Value = "ItemMismatch")]
    //    ItemMismatch = 39,
    //    [EnumMember(Value = "BlockedForPayment")]
    //    BlockedForPayment = 40,
    //    [EnumMember(Value = "MatchedWithOverride")]
    //    MatchedWithOverride = 41,
    //    [EnumMember(Value = "ApprovalRequiredException")]
    //    ApprovalRequiredException = 42,
    //    [EnumMember(Value = "ExpiredInvoiceException")]
    //    ExpiredInvoiceException = 43,
    //    [EnumMember(Value = "InvalidPOException")]
    //    InvalidPOException = 44,
    //    [EnumMember(Value = "InvalidRequesterException")]
    //    InvalidRequesterException = 45,
    //    [EnumMember(Value = "InvalidCurrencyException")]
    //    InvalidCurrencyException = 46,
    //    [EnumMember(Value = "MatchedApprovalRequired")]
    //    MatchedApprovalRequired = 47,
    //    [EnumMember(Value = "MatchedExpiredInvoice")]
    //    MatchedExpiredInvoice = 48,
    //    [EnumMember(Value = "MatchedInvalidPO")]
    //    MatchedInvalidPO = 49,
    //    [EnumMember(Value = "MatchedInvalidRequester")]
    //    MatchedInvalidRequester = 50,
    //    [EnumMember(Value = "MatchedInvalidCurrency")]
    //    MatchedInvalidCurrency = 51,
    //    [EnumMember(Value = "AdvancesException")]
    //    AdvancesException = 52,
    //    [EnumMember(Value = "RecoupmentException")]
    //    RecoupmentException = 55,
    //    [EnumMember(Value = "PrimeRevenue")]
    //    PrimeRevenue = 500,
    //    [EnumMember(Value = "DownPayment")]
    //    DownPayment = 501,
    //    [EnumMember(Value = "Manual")]
    //    Manual = 502
    //}

    [DataContract]
    [Serializable]
    public enum ExtendedStatus
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "FullyInvoiced")]
        FullyInvoiced = 1,

        [EnumMember(Value = "PartiallyInvoiced")]
        PartiallyInvoiced = 2,

        [EnumMember(Value = "OverInvoiced")]
        OverInvoiced = 3,

        [EnumMember(Value = "NotInvoiced")]
        NotInvoiced = 4
    }

    [DataContract]
    [Serializable]
    public enum InvoiceExtendedStatus
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "InvoiceReconciliationInProgress")]
        InvoiceReconciliationInProgress = 1,

        [EnumMember(Value = "InvoiceReconciled")]
        InvoiceReconciled = 2,

        [EnumMember(Value = "IRRejected")]
        IRRejected = 3,

        [EnumMember(Value = "IRCancelled")]
        IRCancelled = 4
    }

    //[DataContract]
    //[Serializable]
    //public enum ItemType
    //{
    //    [EnumMember(Value = "None")]
    //    None = 0,

    //    [EnumMember(Value = "Material")]
    //    Material = 1,

    //    [EnumMember(Value = "Service")]
    //    Service = 2,

    //    [EnumMember(Value = "Advance")]
    //    Advance = 3,

    //    [EnumMember(Value = "Charge")]
    //    Charge = 4
    //}

    //[DataContract]
    //[Serializable]
    //public enum ItemExtendedType
    //{
    //    [EnumMember(Value = "0")]
    //    None = 0,

    //    [EnumMember(Value = "1")]
    //    Material = 1,

    //    [EnumMember(Value = "2")]
    //    Fixed = 2,

    //    [EnumMember(Value = "3")]
    //    Variable = 3,

    //    [EnumMember(Value = "4")]
    //    ServiceActivity = 4,

    //    [EnumMember(Value = "5")]
    //    MileStone = 5,

    //    [EnumMember(Value = "6")]
    //    Progress = 6,

    //    [EnumMember(Value = "7")]
    //    Advance = 7,

    //    [EnumMember(Value = "8")]
    //    Charge = 8

    //}

    //[DataContract]
    //[Serializable]
    //public enum MatchType
    //{
    //    [EnumMember(Value = "0")]
    //    None = 0,

    //    [EnumMember(Value = "1")]
    //    TwoWayMatch = 1,

    //    [EnumMember(Value = "2")]
    //    ThreeWayMatch = 2,

    //    [EnumMember(Value = "3")]
    //    FourWayMatch = 3,

    //}

    [DataContract]
    [Serializable]
    public enum InvoiceSource
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "ScannedPOInvoice")]
        ScannedPOInvoice = 1,

        [EnumMember(Value = "ScannedNonPOInvoice")]
        ScannedNonPOInvoice = 2,

        [EnumMember(Value = "OrderInvoice")]
        OrderInvoice = 3,

        [EnumMember(Value = "PaymentRequestInvoice")]
        PaymentRequestInvoice = 4,

        [EnumMember(Value = "ServiceConfirmationInvoice")]
        ServiceConfirmationInvoice = 5,

        [EnumMember(Value = "ExcelUploadInvoice")]
        ExcelUploadInvoice = 6,

        [EnumMember(Value = "ERSInvoice")]
        ERSInvoice = 7
    }

    //[DataContract]
    //[Serializable]
    //public enum ReceiptSource
    //{
    //    [EnumMember(Value = "None")]
    //    None = 0,

    //    [EnumMember(Value = "PO")]
    //    PO = 1,

    //    [EnumMember(Value = "ASN")]
    //    ASN = 2
    //}

    [DataContract]
    [Serializable]
    public enum InvoiceOrigin
    {
        [EnumMember(Value = "CreatedBySupplier")]
        CreatedBySupplier = 0,

        [EnumMember(Value = "CreatedByBuyer")]
        CreatedByBuyer = 1
    }

    [DataContract]
    [Serializable]
    public enum InvoiceCreatedFrom
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "Web")]
        Web = 1,

        [EnumMember(Value = "Interface")]
        Interface = 2
    }

    [DataContract]
    [Serializable]
    public enum InvoiceOperation
    {
        [EnumMember(Value = "Create")]
        Create = 0,

        [EnumMember(Value = "Update")]
        Update = 1,

        [EnumMember(Value = "Delete")]
        Delete = 2
    }

    //[DataContract]
    //[Serializable]
    //public enum InvoiceResultCode
    //{
    //    [EnumMember(Value = "Success")]
    //    Success = 1,

    //    [EnumMember(Value = "Fail")]
    //    Fail = 0,

    //}

    [DataContract]
    [Serializable]
    public enum InvoiceCreationSource
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "Excel")]
        Excel = 1,

        [EnumMember(Value = "OCR")]
        OCR = 2
    }

    [DataContract]
    [Serializable]
    public enum ExceptionStatus
    {
        [EnumMember(Value = "Header")]
        Header = 1,

        [EnumMember(Value = "Line")]
        Line = 2
    }

    [DataContract]
    [Serializable]
    public enum InvoiceExcelTemplateHandler
    {
        [EnumMember(Value = "0")]
        DownloadTemplate = 0,

        [EnumMember(Value = "1")]
        ExportTemplate = 1,

        [EnumMember(Value = "2")]
        UploadTemplate = 2,

        [EnumMember(Value = "3")]
        DownloadErrorLog = 3
    }

    [DataContract]
    [Serializable]
    public enum InvoiceMasterDataRowSetting
    {
        [EnumMember(Value = "0")]
        ApplyValidationFirstRow = 9,

        [EnumMember(Value = "1")]
        DataExportToExcelFirstRow = 9,

        ExcelLastRow = 65000
    }

    [DataContract]
    [Serializable]
    public enum InvoiceExcelMasterDataColumns
    {
        [EnumMember(Value = "1")]
        PartnerValue = 1,

        [EnumMember(Value = "2")]
        PartnerName = 2,

        [EnumMember(Value = "3")]
        RemittoLocationValue = 3,

        [EnumMember(Value = "4")]
        RemittoLocationName = 4,

        [EnumMember(Value = "5")]
        BilltoLocationValue = 5,

        [EnumMember(Value = "6")]
        BilltoLocationName = 6,

        [EnumMember(Value = "7")]
        ShiptoLocationValue = 7,

        [EnumMember(Value = "8")]
        ShiptoLocationName = 8,

        [EnumMember(Value = "9")]
        DelivertoLocationValue = 9,

        [EnumMember(Value = "10")]
        DelivertoLocationName = 10
    }

    [DataContract]
    [Serializable]
    public enum InvoiceExcelMasterDataFields
    {
        [EnumMember(Value = "1")]
        Operation = 1,

        [EnumMember(Value = "2")]
        Action = 2,

        [EnumMember(Value = "3")]
        UOMValue = 3,

        [EnumMember(Value = "4")]
        UOMName = 4,

        [EnumMember(Value = "5")]
        OrderContactValue = 5,

        [EnumMember(Value = "6")]
        OrderContactName = 6,

        [EnumMember(Value = "7")]
        PartnerOrderingContactValue = 7,

        [EnumMember(Value = "8")]
        PartnerOrderingContactName = 8,

        [EnumMember(Value = "9")]
        PaymentTerms = 9,

        [EnumMember(Value = "10")]
        Currency = 10,

        [EnumMember(Value = "11")]
        ItemType = 11,

        [EnumMember(Value = "12")]
        TaxExempt = 12,

        [EnumMember(Value = "13")]
        CustomFieldSetup = 13,

        [EnumMember(Value = "14")]
        CustomFieldItem = 14,

        [EnumMember(Value = "15")]
        SplitType = 15,

        [EnumMember(Value = "16")]
        TaxLevelType = 16,

        [EnumMember(Value = "17")]
        TaxMode = 17,

        [EnumMember(Value = "18")]
        TaxCode = 18,

        [EnumMember(Value = "19")]
        TaxDescription = 19,

        [EnumMember(Value = "20")]
        TaxPercentage = 20,

        [EnumMember(Value = "21")]
        TaxType = 21,

        [EnumMember(Value = "22")]
        JurisdictionCode = 22,

        [EnumMember(Value = "23")]
        JurisdictionName = 23,

        [EnumMember(Value = "24")]
        CountryName = 24,

        [EnumMember(Value = "25")]
        IsIncludeShipping = 25
    }

    [DataContract]
    [Serializable]
    public enum InvoiceAccountingSplitColumn
    {
        [EnumMember(Value = "0")]
        LineReferenceNumber = 0,

        [EnumMember(Value = "1")]
        SplitType = 1,

        [EnumMember(Value = "2")]
        SplitValue = 2,

        [EnumMember(Value = "3")]
        ErrorMessages = 3
    }

    [DataContract]
    [Serializable]
    public enum InvoiceExcelTemplateRowStartIndex
    {
        [EnumMember(Value = "0")]
        InvoiceLinesRowStartIndex = 3,

        [EnumMember(Value = "1")]
        InvoiceAccountingSplitRowStartIndex = 3,

        [EnumMember(Value = "3")]
        InvoiceAccountingMasterRowStartIndex = 9,

        [EnumMember(Value = "4")]
        InvoiceFieldValueMasterRowStartIndex = 9,
    }

    [DataContract]
    [Serializable]
    public enum AutoCreateIRRules
    {
        [EnumMember(Value = "MissingReceiptException")]
        MissingReceiptException = 1
    }

    [DataContract]
    [Serializable]
    public enum ResolverTypes
    {
        [EnumMember(Value = "REQUESTER")]
        DOCREQUESTER = 0,

        [EnumMember(Value = "RECEIVER")]
        RECEIVER = 1,

        [EnumMember(Value = "ORDERCONTACT")] // buyer
        ORDERCONTACT = 2,

        [EnumMember(Value = "ENTITYOWNER")]
        ENTITYOWNER = 3,

        [EnumMember(Value = "USERID")]
        USERID = 4,

        [EnumMember(Value = "GROUPID")]
        GROUPID = 5,

        [EnumMember(Value = "TAXMANAGERS")]
        TAXMANAGERS = 6
    }

    [DataContract]
    [Serializable]
    public enum RuleParameterTypes
    {
        [EnumMember(Value = "DOCREQUESTER")]
        DOCREQUESTER = 0,

        [EnumMember(Value = "RECEIVER")]
        RECEIVER = 1,

        [EnumMember(Value = "ORDERCONTACT")] // buyer
        ORDERCONTACT = 2,

        [EnumMember(Value = "ALLDOCREQUESTERS")]
        ALLDOCREQUESTERS = 3,

        [EnumMember(Value = "ENTITYOWNER")]
        ENTITYOWNER = 4,

        [EnumMember(Value = "USERID")]
        USERID = 5,

        [EnumMember(Value = "GROUPID")]
        GROUPID = 6,

        [EnumMember(Value = "TAXMANAGERIDS")]
        TAXMANAGERIDS = 7,

        [EnumMember(Value = "TAXMANAGERGROUPIDS")]
        TAXMANAGERGROUPIDS = 8
    }

    [DataContract]
    [Serializable]
    public enum TaxToleraceConfiguration
    {
        [EnumMember(Value = "1")]
        PecentageComparision = 1,

        [EnumMember(Value = "2")]
        AmountComparision = 2
    }

    [DataContract]
    [Serializable]
    public enum ExternalRequestSource
    {
        [EnumMember(Value = "-1")]
        All = -1,

        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        VendorAddress = 1,

        [EnumMember(Value = "2")]
        HeaderShipToAddress = 2,

        [EnumMember(Value = "3")]
        LineShipToAddress = 3,

        [EnumMember(Value = "4")]
        HeaderAccountingAddress = 4,

        [EnumMember(Value = "5")]
        LineAccountingAddress = 5,

        [EnumMember(Value = "6")]
        LineShipFrom = 6,

        [EnumMember(Value = "7")]
        RemitToAddress = 7
    }

    [DataContract]
    [Serializable]
    public enum ExternalTaxResponse
    {
        [EnumMember(Value = "0")]
        Success = 0,

        [EnumMember(Value = "1")]
        InternalError = 1,

        [EnumMember(Value = "2")]
        ExternalError = 2
    }

    #endregion Invoice Enums

    [DataContract]
    public enum RemittanceStatus
    {
        None = 0,
        Cancelled = 1,
        Paid = 2
    }

    [DataContract]
    [Serializable]
    public enum MatchStatus
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "Matched")]
        Matched = 1,

        [EnumMember(Value = "Exception")]
        Exception = 2,

        [EnumMember(Value = "MatchedQuantity")]
        MatchedQuantity = 3,

        [EnumMember(Value = "UnderQuantity")]
        UnderQuantity = 4,

        [EnumMember(Value = "OverQuantity")]
        OverQuantity = 5,

        [EnumMember(Value = "UnreceivedQuantity")]
        UnreceivedQuantity = 6,

        [EnumMember(Value = "MatchedUnitPrice")]
        MatchedUnitPrice = 7,

        [EnumMember(Value = "UnderUnitPrice")]
        UnderUnitPrice = 8,

        [EnumMember(Value = "OverUnitPrice")]
        OverUnitPrice = 9,

        [EnumMember(Value = "MatchedItemValue")]
        MatchedItemValue = 10,

        [EnumMember(Value = "UnderItemValue")]
        UnderItemValue = 11,

        [EnumMember(Value = "OverItemValue")]
        OverItemValue = 12,

        [EnumMember(Value = "MatchedItemTotal")]
        MatchedItemTotal = 13,

        [EnumMember(Value = "UnderItemTotal")]
        UnderItemTotal = 14,

        [EnumMember(Value = "OverItemTotal")]
        OverItemTotal = 15,

        [EnumMember(Value = "MatchedTax")]
        MatchedTax = 16,

        [EnumMember(Value = "UnderTax")]
        UnderTax = 17,

        [EnumMember(Value = "OverTax")]
        OverTax = 18,

        [EnumMember(Value = "MatchedShipping")]
        MatchedShipping = 19,

        [EnumMember(Value = "UnderShipping")]
        UnderShipping = 20,

        [EnumMember(Value = "OverShipping")]
        OverShipping = 21,

        [EnumMember(Value = "MatchedCharges")]
        MatchedCharges = 22,

        [EnumMember(Value = "UnderCharges")]
        UnderCharges = 23,

        [EnumMember(Value = "OverCharges")]
        OverCharges = 24,

        [EnumMember(Value = "MatchedTotalAmount")]
        MatchedTotalAmount = 25,

        [EnumMember(Value = "UnderTotalAmount")]
        UnderTotalAmount = 26,

        [EnumMember(Value = "OverTotalAmount")]
        OverTotalAmount = 27,

        [EnumMember(Value = "MatchedUOM")]
        MatchedUOM = 28,

        [EnumMember(Value = "UnmatchedUOM")]
        UnmatchedUOM = 29,

        [EnumMember(Value = "MatchedWithTolerance")]
        MatchedWithTolerance = 30,

        [EnumMember(Value = "MatchedWithToleranceQuantity")]
        MatchedWithToleranceQuantity = 31,

        [EnumMember(Value = "MatchedWithToleranceUnitPrice")]
        MatchedWithToleranceUnitPrice = 32,

        [EnumMember(Value = "MatchedWithToleranceTax")]
        MatchedWithToleranceTax = 33,

        [EnumMember(Value = "MatchedWithToleranceShipping")]
        MatchedWithToleranceShipping = 34,

        [EnumMember(Value = "MatchedWithToleranceCharges")]
        MatchedWithToleranceCharges = 35,

        [EnumMember(Value = "MatchedWithToleranceItemTotal")]
        MatchedWithToleranceItemTotal = 36,

        [EnumMember(Value = "MatchedWithToleranceTotalAmount")]
        MatchedWithToleranceTotalAmount = 37,

        [EnumMember(Value = "NonPOException")]
        NonPOException = 38,

        [EnumMember(Value = "ItemMismatch")]
        ItemMismatch = 39,

        [EnumMember(Value = "BlockedForPayment")]
        BlockedForPayment = 40,

        [EnumMember(Value = "MatchedWithOverride")]
        MatchedWithOverride = 41,

        [EnumMember(Value = "ApprovalRequiredException")]
        ApprovalRequiredException = 42,

        [EnumMember(Value = "ExpiredInvoiceException")]
        ExpiredInvoiceException = 43,

        [EnumMember(Value = "InvalidPOException")]
        InvalidPOException = 44,

        [EnumMember(Value = "InvalidRequesterException")]
        InvalidRequesterException = 45,

        [EnumMember(Value = "InvalidCurrencyException")]
        InvalidCurrencyException = 46,

        [EnumMember(Value = "MatchedApprovalRequired")]
        MatchedApprovalRequired = 47,

        [EnumMember(Value = "MatchedExpiredInvoice")]
        MatchedExpiredInvoice = 48,

        [EnumMember(Value = "MatchedInvalidPO")]
        MatchedInvalidPO = 49,

        [EnumMember(Value = "MatchedInvalidRequester")]
        MatchedInvalidRequester = 50,

        [EnumMember(Value = "MatchedInvalidCurrency")]
        MatchedInvalidCurrency = 51,

        [EnumMember(Value = "AdvancesException")]
        AdvancesException = 52,

        [EnumMember(Value = "MatchedWithToleranceExternalTax")]
        MatchedWithToleranceExternalTax = 53,

        [EnumMember(Value = "OverriddenExternalTax")]
        OverriddenExternalTax = 54,

        [EnumMember(Value = "RecoupmentException")]
        RecoupmentException = 55,

        [EnumMember(Value = "MissingReceiptException")]
        MissingReceiptException = 56,

        [EnumMember(Value = "OverQuantityReceipt")]
        OverQuantityReceipt = 57,

        [EnumMember(Value = "OverQuantityOrder")]
        OverQuantityOrder = 58,

        [EnumMember(Value = "DateBlockException")]
        DateBlockException = 59,

        [EnumMember(Value = "OverriddenShipping")]
        OverriddenShipping = 60,

        [EnumMember(Value = "OverriddenCharges")]
        OverriddenCharges = 61,

        [EnumMember(Value = "OverriddenItemTotal")]
        OverriddenItemTotal = 62,

        [EnumMember(Value = "OverriddenTotalAmount")]
        OverriddenTotalAmount = 63,

        [EnumMember(Value = "OverriddenLineValue")]
        OverriddenLineValue = 64,

        [EnumMember(Value = "MatchedExternalTax")]
        MatchedExternalTax = 65,

        [EnumMember(Value = "UnderExternalTax")]
        UnderExternalTax = 66,

        [EnumMember(Value = "OverExternalTax")]
        OverExternalTax = 67,

        [EnumMember(Value = "PrimeRevenue")]
        PrimeRevenue = 500,

        [EnumMember(Value = "DownPayment")]
        DownPayment = 501,

        [EnumMember(Value = "Manual")]
        Manual = 502,

        [EnumMember(Value = "MissingServiceConfirmationException")]
        MissingServiceConfirmationException = 68,

        [EnumMember(Value = "MissingReceiptFixedLineException")]
        MissingReceiptFixedLineException = 69
    }

    [DataContract]
    [Serializable]
    public enum ItemType
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "Material")]
        Material = 1,

        [EnumMember(Value = "Service")]
        Service = 2,

        [EnumMember(Value = "Advance")]
        Advance = 3,

        [EnumMember(Value = "Charge")]
        Charge = 4
    }

    [DataContract]
    [Serializable]
    public enum ItemExtendedType
    {
        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        Material = 1,

        [EnumMember(Value = "2")]
        Fixed = 2,

        [EnumMember(Value = "3")]
        Variable = 3,

        [EnumMember(Value = "4")]
        ServiceActivity = 4,

        [EnumMember(Value = "5")]
        MileStone = 5,

        [EnumMember(Value = "6")]
        Progress = 6,

        [EnumMember(Value = "7")]
        Advance = 7,

        [EnumMember(Value = "8")]
        Charge = 8,

        [EnumMember(Value = "9")]
        ContingentWorker = 9,

        [EnumMember(Value = "10")]
        Expense = 10
    }

    [DataContract]
    [Serializable]
    public enum MatchType
    {
        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        TwoWayMatch = 1,

        [EnumMember(Value = "2")]
        ThreeWayMatch = 2,

        [EnumMember(Value = "3")]
        FourWayMatch = 3,
    }

    public enum TaxType
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "City")]
        City = 1,

        [EnumMember(Value = "District")]
        District = 2,

        [EnumMember(Value = "Country")]
        Country = 3,

        [EnumMember(Value = "State")]
        State = 4,

        [EnumMember(Value = "Federal")]
        Federal = 5
    }

    [DataContract]
    [Serializable]
    public enum SplitType
    {
        [EnumMember(Value = "None")]
        None = 2,

        [EnumMember(Value = "Quantity")]
        Quantity = 0,

        [EnumMember(Value = "Percentage")]
        Percentage = 1
    }

    [DataContract]
    [Serializable]
    public enum TaxLevelType
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "Header Level")]
        HeaderLevel = 1,

        [EnumMember(Value = "Line Level")]
        LineLevel = 2
    }

    [DataContract]
    [Serializable]
    public enum TaxMode
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "Percentage")]
        Percentage = 1,

        [EnumMember(Value = "Amount")]
        Amount = 2
    }

    [DataContract]
    [Serializable]
    public enum ItemSourceType
    {
        [EnumMember(Value = "0")]
        Other = 0,

        [EnumMember(Value = "1")]
        Manual = 1,

        [EnumMember(Value = "2")]
        Hosted = 2,

        [EnumMember(Value = "3")]
        Punchout = 3,

        [EnumMember(Value = "4")]
        Template = 4,

        [EnumMember(Value = "5")]
        Internal = 5,

        [EnumMember(Value = "6")]
        PurchaseRequest = 6,

        [EnumMember(Value = "8")]
        HostedAndInternal = 8,

        [EnumMember(Value = "9")]
        Quote = 9
    }

    [DataContract]
    [Serializable]
    public enum P2PDocumentType
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "Requisition")]
        Requisition = 1,

        [EnumMember(Value = "Order")]
        Order = 2,

        [EnumMember(Value = "Catalog")]
        Catalog = 6,

        [EnumMember(Value = "Invoice")]
        Invoice = 9,

        [EnumMember(Value = "Receipt")]
        Receipt = 10,

        [EnumMember(Value = "Template")]
        Template = 13,

        [EnumMember(Value = "InvoiceReconciliation")]
        InvoiceReconciliation = 14,

        [EnumMember(Value = "ScannedImage")]
        ScannedImage = 15,

        [EnumMember(Value = "ReturnNote")]
        ReturnNote = 20,

        [EnumMember(Value = "Item")]
        Item = 21,

        [EnumMember(Value = "CreditMemo")]
        CreditMemo = 22,

        [EnumMember(Value = "Program")]
        Program = 24,

        [EnumMember(Value = "PaymentRequest")]
        PaymentRequest = 27,

        [EnumMember(Value = "BlanketOrder")]
        BlanketOrder = 30,

        [EnumMember(Value = "ServiceConfirmation")]
        ServiceConfirmation = 31,

        [EnumMember(Value = "TimeSheet")]
        TimeSheet = 39,

        [EnumMember(Value = "ASN")]
        ASN = 34,

        [EnumMember(Value = "Interfaces")]
        Interfaces = 100,

        [EnumMember(Value = "Portal")]
        Portal = 101,

        /// <summary>
        /// ProcurementProfile
        /// </summary>
        [EnumMember(Value = "ProcurementProfile")]
        ProcurementProfile = 38,

        /// <summary>
        /// TaxMaster
        /// </summary>
        [EnumMember(Value = "TaxMaster")]
        TaxMaster = 102
    }

    [DataContract]
    [Serializable]
    public enum ADRIdentifier
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "DocumentCode")]
        DocumentCode = 1,

        [EnumMember(Value = "DocumentItemId")]
        DocumentItemId = 2,

        [EnumMember(Value = "DocumentSplitItemId")]
        DocumentSplitItemId = 3,

        [EnumMember(Value = "DocumentSplitItemEntityId")]
        DocumentSplitItemEntityId = 4,

        [EnumMember(Value = "lineNumber")]
        lineNumber = 5,

        [EnumMember(Value = "UiID")]
        UiID = 6
    }

    [DataContract]
    [Serializable]
    public enum ExcelItemColumns
    {
        [EnumMember(Value = "0")]
        ReferenceNumber = 0,

        [EnumMember(Value = "1")]
        LineNumber = 1,

        [EnumMember(Value = "2")]
        ItemType = 2,

        [EnumMember(Value = "3")]
        ItemNumber = 3,

        [EnumMember(Value = "4")]
        SupplierItemNumber = 4,

        [EnumMember(Value = "5")]
        ItemDescription = 5,

        [EnumMember(Value = "6")]
        Quantity = 6,

        [EnumMember(Value = "7")]
        UOM = 7,

        [EnumMember(Value = "8")]
        UnitPrice = 8,

        [EnumMember(Value = "9")]
        ServiceStartDate = 9,

        [EnumMember(Value = "10")]
        ServiceEndDate = 10,

        [EnumMember(Value = "11")]
        TaxExempt = 11,

        [EnumMember(Value = "12")]
        Taxes = 12,

        [EnumMember(Value = "13")]
        OtherCharges = 13,

        [EnumMember(Value = "14")]
        ShippingandFreight = 14,

        [EnumMember(Value = "15")]
        ShiptoLocationCode = 15,

        [EnumMember(Value = "16")]
        DelivertoLocationCode = 16,

        [EnumMember(Value = "17")]
        ContractNumber = 17,

        [EnumMember(Value = "18")]
        LineComments = 18,

        [EnumMember(Value = "19")]
        ProcessingStatus = 19,

        [EnumMember(Value = "20")]
        ProcessingComments = 20,

        [EnumMember(Value = "21")]
        Billable = 21,

        [EnumMember(Value = "22")]
        Capitalized = 22,

        [EnumMember(Value = "23")]
        CapitalCode = 23,

        [EnumMember(Value = "24")]
        Category = 24
    }

    [DataContract]
    [Serializable]
    public enum ExcelSetupColumns
    {
        [EnumMember(Value = "0")]
        Operation = 0,

        [EnumMember(Value = "1")]
        Action = 1,

        [EnumMember(Value = "2")]
        ReferenceNumber = 2,

        [EnumMember(Value = "3")]
        SupplierCode = 3,

        [EnumMember(Value = "4")]
        SupplierName = 4,

        [EnumMember(Value = "5")]
        PurchaseOrderNumber = 5,

        [EnumMember(Value = "6")]
        SupplierInvoiceNumber = 6,

        [EnumMember(Value = "7")]
        SupplierInvoiceDate = 7,

        [EnumMember(Value = "8")]
        InvoiceReceivedDate = 8,

        [EnumMember(Value = "9")]
        RemittoLocationCode = 9,

        [EnumMember(Value = "10")]
        OrderContact = 10,

        [EnumMember(Value = "11")]
        BilltoLocationCode = 11,

        [EnumMember(Value = "12")]
        ShiptoLocationCode = 12,

        [EnumMember(Value = "13")]
        DelivertoLocationCode = 13,

        [EnumMember(Value = "14")]
        SupplierOrderingContact = 14,

        [EnumMember(Value = "15")]
        PaymentTerms = 15,

        [EnumMember(Value = "16")]
        Currency = 16,

        [EnumMember(Value = "17")]
        InvoiceAmount = 17,

        [EnumMember(Value = "18")]
        HeaderComments = 18,

        [EnumMember(Value = "19")]
        ProcessingStatus = 19,

        [EnumMember(Value = "20")]
        ProcessingComments = 20,

        [EnumMember(Value = "21")]
        CapitalCode = 21,

        [EnumMember(Value = "22")]
        WorkOrderNumber = 22,

        [EnumMember(Value = "23")]
        ERPOrderType = 23,

        [EnumMember(Value = "24")]
        BudgetId = 24,

        [EnumMember(Value = "25")]
        DocumentStatus = 25,

        [EnumMember(Value = "26")]
        InvoiceTransmissionStatus = 26
    }

    [DataContract]
    [Serializable]
    public enum ExcelTaxCodesColumns
    {
        [EnumMember(Value = "0")]
        ReferenceNumber = 0,

        [EnumMember(Value = "1")]
        TaxType = 1,

        [EnumMember(Value = "2")]
        LineNumber = 2,

        [EnumMember(Value = "3")]
        TaxCode = 3,

        [EnumMember(Value = "4")]
        TaxMode = 4,

        [EnumMember(Value = "5")]
        TaxValue = 5,

        [EnumMember(Value = "6")]
        ProcessingStatus = 6,

        [EnumMember(Value = "7")]
        ProcessingComments = 7
    }

    [DataContract]
    [Serializable]
    public enum ExcelAccountingColumns
    {
        [EnumMember(Value = "0")]
        ReferenceNumber = 0,

        [EnumMember(Value = "1")]
        LineNumber = 1,

        [EnumMember(Value = "2")]
        SplitType = 2,

        [EnumMember(Value = "3")]
        Value = 3,

        [EnumMember(Value = "4")]
        ProcessingStatus = 4,

        [EnumMember(Value = "5")]
        ProcessingComments = 5,

        [EnumMember(Value = "6")]
        SplitNumber = 6,
    }

    [DataContract]
    [Serializable]
    public enum OrderSource
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "ManualOrder")]
        ManualOrder = 1,

        [EnumMember(Value = "RequisitionOrder")]
        RequisitionOrder = 2,

        [EnumMember(Value = "ConfirmingOrder")]
        ConfirmingOrder = 3,

        [EnumMember(Value = "CatalogOrder")]
        CatalogOrder = 4,

        [EnumMember(Value = "ChangeOrder")]
        ChangeOrder = 5,

        [EnumMember(Value = "ChangeRequest")]
        ChangeRequest = 6,

        [EnumMember(Value = "FlipToOrder")]
        FlipToOrder = 7,

        [EnumMember(Value = "BlanketOrder")]
        BlanketOrder = 8,

        [EnumMember(Value = "ReleaseOrder")]
        ReleaseOrder = 9,

        [EnumMember(Value = "InternalChangeOrder")]
        InternalChangeOrder = 10

        //Need to finalise about Change Order and Modification Order
    }

    [DataContract]
    [Serializable]
    public enum POTransmissionMode
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "Portal")]
        Portal = 1,

        [EnumMember(Value = "Cxml")]
        CxmlEDI = 2,

        [EnumMember(Value = "Email")]
        Email = 3,

        [EnumMember(Value = "CallAndSubmit")]
        CallAndSubmit = 4,

        [EnumMember(Value = "Fax")]
        Fax = 5
    }

    [DataContract]
    [Serializable]
    public enum TaxIntegrattionType
    {
        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        VertaxIntegration = 1,

        [EnumMember(Value = "2")]
        OneSourceIntegration = 2
    }

    [DataContract]
    [Serializable]
    public enum AccountingSplitMode
    {
        [EnumMember(Value = "SplitByItemTotal")]
        SplitByItemTotal = 1,

        [EnumMember(Value = "SplitByItemValuePlusTax")]
        SplitByItemValuePlusTax = 2,

        [EnumMember(Value = "SplitByItemValue")]
        SplitByItemValue = 3
    }

    [DataContract]
    [Serializable]
    public enum Level
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "Header")]
        Header = 1,

        [EnumMember(Value = "Item")]
        Item = 2,

        [EnumMember(Value = "Distribution")]
        Distribution = 3,

        [EnumMember(Value = "Category")]
        Category = 4
    }

    [DataContract]
    [Serializable]
    public enum InterfaceStatus
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "QueuedForERPProcessing")]
        QueuedForERPProcessing = 1,

        [EnumMember(Value = "SendingToERPInProgress")]
        SendingToERPInProgress = 2,

        [EnumMember(Value = "SentToERP")]
        SentToERP = 3,

        [EnumMember(Value = "AcceptedByERP")]
        AcceptedByERP = 4,

        [EnumMember(Value = "RejectedByERP")]
        RejectedByERP = 5,

        [EnumMember(Value = "CancelledByERP")]
        CancelledByERP = 6,

        [EnumMember(Value = "CancellationFailed")]
        CancellationFailed = 7,

        [EnumMember(Value = "SendingToERPFailed")]
        SendingToERPFailed = 8,

        [EnumMember(Value = "CancellationToERPInProgress")]
        CancellationToERPInProgress = 9,

        [EnumMember(Value = "PickedUpForProcessing")]
        PickedUpForProcessing = 99,

        [EnumMember(Value = "UpdatedPickedUpForProcessing")]
        UpdatedPickedUpForProcessing = 100
    }

    [DataContract]
    [Serializable]
    public enum RequisitionTrackStatus
    {
        [EnumMember(Value = "Predicted")]
        Predicted = 0,

        [EnumMember(Value = "ApprovalPending")]
        ApprovalPending = 1,

        [EnumMember(Value = "Approved")]
        Approved = 2,

        [EnumMember(Value = "Rejected")]
        Rejected = 3
    }

    [DataContract]
    [Serializable]
    public enum MenuIndex
    {
        Procurement = 13,
        Invoice = 18,
        InvoiceReconcillation = 30
    }

    [DataContract]
    [Serializable]
    public enum FailureAction
    {
        None = 0,
        Approval = 1,
        SendForProcessing = 2,
        Acceptance = 3,
        SendToBuyer = 4,
        SendToSupplier = 5
    }

    [DataContract]
    [Serializable]
    public enum DocumentExtendedStatus
    {
        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        InternalCancellationInProgress = 1,

        [EnumMember(Value = "2")]
        InternalCancellationSuccess = 2,

        [EnumMember(Value = "3")]
        InternalCancellationFailed = 3,

        [EnumMember(Value = "4")]
        ReturnInProgress = 4,

        [EnumMember(Value = "5")]
        ReturnSuccess = 5,

        [EnumMember(Value = "6")]
        ReturnFailed = 6,

        [EnumMember(Value = "7")]
        ValidationInProgress = 7,

        [EnumMember(Value = "8")]
        InvoiceVerified = 8,

        [EnumMember(Value = "9")]
        InvoiceNotVerified = 9,

        [EnumMember(Value = "10")]
        AcceptedByMuleSoft = 10,

        [EnumMember(Value = "11")]
        RejectedByMuleSoft = 11,

        [EnumMember(Value = "12")]
        CORejected = 12,

        [EnumMember(Value = "13")]
        COInProgress = 13
    }

    [DataContract]
    [Serializable]
    public enum RuleValidationType
    {
        [EnumMember(Value = "Error")]
        Error = 1,

        [EnumMember(Value = "Warning")]
        Warning = 2,

        [EnumMember(Value = "Informative")]
        Informative = 3,

        [EnumMember(Value = "ComplianceError")]
        ComplianceError = 4
    }

    [DataContract]
    [Serializable]
    public enum InvoiceComplianceStatus
    {
        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        SignaturePending = 1,

        [EnumMember(Value = "2")]
        SignatureDone = 2,

        [EnumMember(Value = "3")]
        SignatureFailed = 3,

        [EnumMember(Value = "4")]
        ValidationPending = 4,

        [EnumMember(Value = "5")]
        ValidationDone = 5,

        [EnumMember(Value = "6")]
        ValidationFailed = 6
    }

    [DataContract]
    public enum InvoiceComplianceType
    {
        None = 0,
        PostAudit = 1,
        Clearance = 2
    }

    [DataContract]
    public enum InvoiceComplianceAPIType
    {
        None = 0,
        ValidationAPI = 1,
        SignatureAPI = 2
    }

    [DataContract]
    public enum InvoiceArchivalStatus
    {
        None = 0,
        ArchivalPending = 1,
        NotArchived = 2,
        Archived = 3
    }

    public enum WorkFlowDocType
    {
        POInvoice = 9,
        NONPOInvoice = 10
    }

    [DataContract]
    [Serializable]
    public enum SmartFlowTypes
    {
        [EnumMember]
        InvoiceOCR,

        [EnumMember]
        InvoiceExcelUpload,

        [EnumMember]
        AutoCreateIR
    }

    public enum UploadRequestType
    {
        UnDefinedRequest = 0,
        SourcingSupplierResposes = 1,
        SoucingLineItemResponses = 2,
        SoucingResponses = 3,
        DownloadZip = 4,
        SourcingImportEventPartnerSide = 5,
        ImportScoringQuestionResponses = 6,
        SourcingImportBuyerLineItem = 7,
        SourcingImportPartnerLineItem = 8,
        ImportQuantitativeScoreCardResponse = 9,
        UploadPartners = 10,
        SourcingImportBuyerSurvey = 11,
        SourcingImportBuyerGuideline = 12,
        ImportPartnerScoreCardQuestionRespose = 14,
        ImportTeamMemberScoreCardQuestionRespose = 15,
        ImportPartnerFormQuestionRespose = 16,
        ImportTeamMemberFormQuestionRespose = 17,
        SourcingImportPricesheetCommentsPDF = 18,
        SourcingImportPricesheetCommentsWORD = 19,
        SourcingImportBuyerInitialBid = 20,
        P2PImportInvoiceExcel = 21,
        P2PUploadInvoiceExcelTemplate = 22,
        P2PUploadInvoiceMasterDataTemplate = 23,
        P2PExportInvoice = 24,
        SourcingImportPartnerQuestionaire = 25,
        P2PUploadInvoiceExcelTemplateByBPC = 26,
        SpendNewFeedbackFileImport = 27,
        SpendManageFeedbackFileImport = 28,
        SourcingImportBuyerMultipleGuideline = 29,
        P2PUploadInvoiceMasterDataTemplateByBPC = 30,
        SourcingImportAllBuyerLineItem = 31,
        SourcingImportRXFEventAsExcel = 32,
        P2PUploadOrderedReport = 33,
        SourcingImportSplitDetailsAwarding = 34,
        SourcingImportBonusMalus = 35,
        P2PUploadReceiptAssetTagExcelTemplate = 36,
        P2PFillingMasterDataReceiptAssetTagExcel = 37,
        ImportApprovalMatrixResponse = 38,
        Sourcing2ImportBuyerPrciesheet = 39,
        Sourcing2ImportSupplierPrciesheet = 40,
        Sourcing2ImportSupplierQuestion = 41,
        Sourcing2ImportBuyerQuestion = 42,
        Sourcing2ImportSupplierAllocation = 43,
        EvaluatorImportQuestionnaireCommentScore = 44,
        Sourcing2ImportSupplierQuestionEventLevel = 45,
        Sourcing2ImportBuyerQuestionEventLevel = 46,
        BillOfMaterialUploadRequestType = 47,
        BillOfMaterialLogExport = 48,
        BillOfMaterialFileUri = 49,
        SRC2ImportBuyerMultipleGuideline = 50,
        ShouldCostImportExcel = 51,
        ShouldCostErrorLog = 52,
        CostElementUploadRequest = 53,
        CostElementDownloadRequest = 54,
        Sourcing2ImportBuyerAnalyzeColumns = 55,
        Sourcing2ImportBuyerAnalyzeColumnsRwb = 56,
        ShouldCostExportExcel = 57,
        Sourcing2ImportBuyerMultiplePricesheet = 58,
        Sourcing2ImportSupplierMultiplePricesheet = 59,
        DemandPlanningImportExcel = 60,
        ShouldCostAttachment = 61,
        UploadActivityBulkUser = 88
    }

    public enum UploadStatus
    {
        NotStarted = 0,
        InProgress = 1,
        Complete = 2,
        Error = 3,
        InvalidFile = 4,
        NoNewRecords = 5
    }

    public enum ActionerType
    {
        OriginalAcceptor = 0,
        ProxyAcceptor = 1
    }
}

namespace GEP.SMART.Invoice.New.BusinessEntities
{
    public enum MatchType
    {
        P2P_CMN_None = 0,
        P2P_CMN_TwoWayMatch = 1,
        P2P_CMN_ThreeWayMatch = 2,
        P2P_CMN_FourWayMatch = 3
    }
}