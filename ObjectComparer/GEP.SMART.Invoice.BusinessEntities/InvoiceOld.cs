using Gep.Cumulus.Partner.Entities;
using GEP.Cumulus.Documents.Entities;
using GEP.Cumulus.QuestionBank.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities.Old
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(MatchStatus))]
    [KnownType(typeof(InvoiceSource))]
    [KnownType(typeof(InvoiceOrigin))]
    [KnownType(typeof(P2PDocumentType))]
    [KnownType(typeof(InvoiceOperation))]
    [KnownType(typeof(InvoiceMatchStatus))]
    [KnownType(typeof(InvoiceExceptionOverride))]
    [KnownType(typeof(List<ItemChargeExtension>))]
    [System.Xml.Serialization.XmlInclude(typeof(MatchStatus))]
    [System.Xml.Serialization.XmlInclude(typeof(InvoiceSource))]
    [System.Xml.Serialization.XmlInclude(typeof(InvoiceOrigin))]
    [System.Xml.Serialization.XmlInclude(typeof(P2PDocumentType))]
    [System.Xml.Serialization.XmlInclude(typeof(List<ItemChargeExtension>))]
    public class Invoice : P2PDocument
    {
        public Invoice()
        {
            ShiptoLocation = new ShiptoLocation();
            DelivertoLocation = new DelivertoLocation();
            DocumentAdditionalEntitiesInfoList = new Collection<DocumentAdditionalEntityInfo>();
        }

        [DataMember]
        public string PartnerInvoiceNumber { get; set; }

        [DataMember]
        public string ClientPartnerCode { get; set; }

        [DataMember]
        public decimal PartnerCode { get; set; }

        [DataMember]
        public long PartnerContactCode { get; set; }

        [DataMember]
        public long RemittoLocationId { get; set; }

        [DataMember]
        public int ShiptoLocationId { get; set; }

        [DataMember]
        public int DelivertoLocationId { get; set; }

        [DataMember]
        public string PaymentTerms { get; set; }

        [DataMember]
        public DateTime? PartnerInvoiceDate { get; set; }

        [DataMember]
        public string OrderNumber { get; set; }

        [DataMember]
        public int BusinessUnitId { get; set; }

        [DataMember]
        public string PartnerName { get; set; }

        [DataMember]
        public ShiptoLocation ShiptoLocation { get; set; }

        [DataMember]
        public DelivertoLocation DelivertoLocation { get; set; }

        [DataMember]
        public long BuyerId { get; set; }

        [DataMember]
        public List<KeyValuePair<MatchStatus, int>> MatchStatus { get; set; }

        [DataMember]
        public string OrderName { get; set; }

        [DataMember]
        public long OrderDocumentCode { get; set; }

        [DataMember]
        public List<long> OrderIdList { get; set; }

        [DataMember]
        public BilltoLocation BilltoLocation { get; set; }

        [DataMember]
        public InvoiceExtendedStatus ExtendedStatus { get; set; }

        [DataMember]
        public string PartnerContactName { get; set; }

        [DataMember]
        public bool IsMemo { get; set; }

        [DataMember]
        public List<InvoiceItem> InvoiceItems { get; set; }

        [DataMember]
        public InvoiceSource InvoiceSource { get; set; }

        [DataMember]
        public decimal OrderTotal { get; set; }

        [DataMember]
        public DateTime OrderDate { get; set; }

        [DataMember]
        public bool UpdateStakeHolderDetail { get; set; }

        [DataMember]
        public List<FileUploadDetails> FileDetails { get; set; }

        [DataMember]
        public InvoiceOrigin InvoiceOrigin { get; set; }

        [DataMember]
        public DateTime ReceivedDate { get; set; }

        [DataMember]
        public decimal? UseTax { get; set; }

        [DataMember]
        public long OrderContact { get; set; }

        [DataMember]
        public long OrderId { get; set; }

        [DataMember]
        public string BusinessUnitName { get; set; }

        [DataMember]
        public Int32 PaymentTermId { get; set; }

        [DataMember]
        public InvoiceCreatedFrom InvoiceCreatedFrom { get; set; }

        [DataMember]
        public DocumentStatus OrderStatus { get; set; }

        [DataMember]
        public decimal? OrderPartnerCode { get; set; }

        [DataMember]
        public string OrderPartnerName { get; set; }

        [DataMember]
        public int ClosingOrderStatus { get; set; }

        [DataMember]
        public decimal? InvoiceTotalAmount { get; set; }

        [DataMember]
        public P2PContact OrderContactDetails { get; set; }

        [DataMember]
        public long ProgramId { get; set; }

        [DataMember]
        public decimal AmountDifferenceBetweenOrderInvoice { get; set; }

        [DataMember]
        public int OrderSourceSystemId { get; set; }

        [DataMember]
        public PartnerLocation OrderingLocation { get; set; }

        [DataMember]
        public long OrderingLocationId { get; set; }

        [DataMember]
        public List<InvoiceError> ErrorList { get; set; }

        [DataMember]
        public string OrderingLocationCountryCode { get; set; }

        [DataMember]
        public Int32 OrderPaymentTermId { get; set; }

        [DataMember]
        public string OrderCurrency { get; set; }

        //start : added for save bulk invoices from Excel
        [DataMember]
        public string RemittoLocation { get; set; }

        [DataMember]
        public string RemittoLocationCode { get; set; }

        [DataMember]
        public string OrderContactName { get; set; }

        [DataMember]
        public string ShiptoLocationName { get; set; }

        [DataMember]
        public string DelivertoLocationName { get; set; }

        [DataMember]
        public string BilltoLocationName { get; set; }

        [DataMember]
        public string PartnerOrderContactName { get; set; }

        [DataMember]
        public string Action { get; set; }

        [DataMember]
        public InvoiceOperation OperationType { get; set; }

        //End : added for save bulk invoices from Excel

        [DataMember]
        public long CurrentDateMinusInvoiceDate { get; set; }

        [DataMember]
        public long IsOrderAndInvoiceContactSame { get; set; }

        [DataMember]
        public long IsOrderAndInvoiceCurrencySame { get; set; }

        [DataMember]
        public bool IsPCardSupported { get; set; }

        [DataMember]
        public List<InvoiceExceptionOverride> ExceptionOverride { get; set; }

        [DataMember]
        public DocumentStatus InvoiceStatus { get; set; }

        [DataMember]
        public DateTime SubmittedOn { get; set; }

        [DataMember]
        public string PaymentRequestNumber { get; set; }

        [DataMember]
        public string PaymentRequestName { get; set; }

        //[DataMember]
        //public long OrderRequester { get; set; }

        [DataMember]
        public long PaymentRequestContact { get; set; }

        [DataMember]
        public int ReferenceNumber { get; set; }

        [DataMember]
        public int BilltoLocationId { get; set; }

        [DataMember]
        public bool ShowInternalCancelAction { get; set; }

        [DataMember]
        public string InvoiceTotalAmountText { get; set; }

        [DataMember]
        public int PurchaseType { get; set; }

        [DataMember]
        public string ItemExtendedTypeIds { get; set; }

        [DataMember]
        public long PartnerReconMatchTypeId { get; set; }

        [DataMember]
        public int InvoiceType { get; set; }

        [DataMember]
        public string PurchaseTypeDescription { get; set; }

        [DataMember]
        public string BuyerVATNumber { get; set; }

        [DataMember]
        public decimal AvailableAdvanceTotal { get; set; }

        [DataMember]
        public decimal RecoupmentRate { get; set; }

        [DataMember]
        public List<QuestionResponse> ListQuestionResponse { get; set; }

        [DataMember]
        public List<InvoiceMatchStatus> MatchStatuses { get; set; }

        [DataMember]
        public bool IsBusinessUnitChanged { get; set; }

        [DataMember]
        public decimal OverAllLimit { get; set; }

        [DataMember]
        public decimal AllInvoicesTotalAmount { get; set; }

        [DataMember]
        public string CountryCode { get; set; }

        [DataMember]
        public int HeaderTaxCodeCount { get; set; }

        [DataMember]
        public string TaxCodes { get; set; }

        [DataMember]
        public bool? Billable { get; set; }

        [DataMember]
        public List<Taxes> lstTaxes { get; set; }

        [DataMember]
        public string PartnerContactEmailAddress { get; set; }

        [DataMember]
        public List<CreditMemoItemTaxCode> lstCreditMemoItemTaxCodes { get; set; }

        [DataMember]
        public long ReviewerContactCode { get; set; }

        [DataMember]
        public string DocumentStatus { get; set; }

        [DataMember]
        public string InvoiceCreatedBy { get; set; }

        [DataMember]
        public string InvoiceNumber { get; set; }

        [DataMember]
        public string InvoiceName { get; set; }

        [DataMember]
        public string CurrencyCode { get; set; }

        [DataMember]
        public string ShiptoLocationNumber { get; set; }

        [DataMember]
        public string DelivertoLocationNumber { get; set; }

        [DataMember]
        public string AddressLine1 { get; set; }

        [DataMember]
        public string AddressLine2 { get; set; }

        [DataMember]
        public string AddressLine3 { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string Zip { get; set; }

        [DataMember]
        public string ItemTotal { get; set; }

        [DataMember]
        public decimal? InvoicePartnerCode { get; set; }

        [DataMember]
        public decimal? TotalCharge { get; set; }

        [DataMember]
        public decimal? TotalAllowance { get; set; }

        [DataMember]
        public decimal? Discount { get; set; }

        [DataMember]
        public DateTime DateSubmitted { get; set; }

        [DataMember]
        public string InvoiceSourceName { get; set; }

        [DataMember]
        public long SubmittedBy { get; set; }

        [DataMember]
        public string CreatedByName { get; set; }

        [DataMember]
        public string EmailId { get; set; }

        [DataMember]
        public string UpdatedVia { get; set; }

        [DataMember]
        public long ImageId { get; set; }

        [DataMember]
        public long OldImageId { get; set; }

        [DataMember]
        public List<KeyValuePair<long, int>> LstItemOverrideEx { get; set; }

        [DataMember]
        public new List<ItemChargeExtension> lstItemCharge { get; set; }

        [DataMember]
        public int OrderPurchaseType { get; set; }

        [DataMember]
        public int POBasedNewLinesCount { get; set; }

        [DataMember]
        public int OrderLinkedDocumentTypeCode { get; set; }

        [DataMember]
        public long InvoiceSourceId { get; set; }

        [DataMember]
        public int IsMultiDocInvoice { get; set; }

        [DataMember]
        public int InvoiceCreator { get; set; }

        [DataMember]
        public DateTime? ScheduledPaymentDate { get; set; }

        [DataMember]
        public long BlanketDocumentCode { get; set; }

        [DataMember]
        public bool UserType { get; set; }

        [DataMember]
        public int IsERS { get; set; }

        [DataMember]
        public string DeliveryNoteNumber { get; set; }

        [DataMember]
        public List<CustomFieldInfo> lstCustomFields { get; set; }

        [DataMember]
        public InvoiceComplianceStatus complianceStatus { get; set; }

        [DataMember]
        public long FulfilmentDocumentCode { get; set; }

        [DataMember]
        public int FulfilmentDocumentStatus { get; set; }

        [DataMember]

        public int StructureId { get; set; }
    }

    public class InvoiceRelatedDetails
    {
        public Invoice objInvoice { get; set; }

        //public List<ERPOrderType> objLstERPOrderType { get; set; }
        public List<P2PItemCheckedStatus> AllDocumentItemsCheckedStatus { get; set; }

        public List<PartnerLocation> lstRemitToLocations { get; set; }
        public List<Contact> lstPartnerContacts { get; set; }
        public PartnerDetails objPartnerDetails { get; set; }
        public Contact objBuyerContactDetails { get; set; }
        public PartnerDetails objBuyerPartnerDetails { get; set; }
        public List<UserLOBMapping> allServingUserLOBMapping { get; set; }
        public Contact objReviewerContactDetails { get; set; }
    }

    [DataContract]
    [Serializable]
    [KnownType(typeof(ExcelItemColumns))]
    [System.Xml.Serialization.XmlInclude(typeof(ExcelItemColumns))]
    public class InvoiceItemErrorResponse
    {
        [DataMember]
        public int ReferenceNumber { get; set; }

        [DataMember]
        public string PartnerInvoiceNumber { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string ItemLineNumber { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public List<ExcelItemColumns> FieldMapping { get; set; }

        [DataMember]
        public List<InvoiceSplitItemErrorResponse> lstInvoiceSplitItemErrorResponse { get; set; }

        [DataMember]
        public List<InvoiceTaxCodeErrorResponse> lstInvoiceTaxCodeErrorResponse { get; set; }
    }

    [DataContract]
    [Serializable]
    [KnownType(typeof(ExcelSetupColumns))]
    [System.Xml.Serialization.XmlInclude(typeof(ExcelSetupColumns))]
    [System.Xml.Serialization.XmlInclude(typeof(InvoiceItemErrorResponse))]
    [System.Xml.Serialization.XmlInclude(typeof(InvoiceCustomattributeErrors))]
    public class InvoiceErrorResponse
    {
        [DataMember]
        public string SupplierInvoiceNumber { get; set; }

        [DataMember]
        public string DocumentCode { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public List<ExcelSetupColumns> FieldMapping { get; set; }

        [DataMember]
        public List<InvoiceItemErrorResponse> lstInvoiceItemErrorResponse { get; set; }

        [DataMember]
        public List<InvoiceCustomattributeErrors> lstInvoiceCustomattributeErrors { get; set; }

        [DataMember]
        public string DocumentStatus { get; set; }

        [DataMember]
        public string InvoiceTransmissionStatus { get; set; }

        [DataMember]
        public List<InvoiceTaxCodeErrorResponse> lstInvoiceTaxCodeErrorResponse { get; set; }
    }

    [DataContract]
    [Serializable]
    public class InvoiceResultResponse
    {
        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Message { get; set; }
    }

    [DataContract]
    [Serializable]
    [KnownType(typeof(ExcelSetupColumns))]
    [KnownType(typeof(ExcelItemColumns))]
    [KnownType(typeof(InvoiceItemErrorResponse))]
    [KnownType(typeof(InvoiceErrorResponse))]
    [KnownType(typeof(InvoiceResultResponse))]
    [System.Xml.Serialization.XmlInclude(typeof(ExcelSetupColumns))]
    [System.Xml.Serialization.XmlInclude(typeof(ExcelItemColumns))]
    [System.Xml.Serialization.XmlInclude(typeof(InvoiceItemErrorResponse))]
    [System.Xml.Serialization.XmlInclude(typeof(InvoiceErrorResponse))]
    [System.Xml.Serialization.XmlInclude(typeof(InvoiceResultResponse))]
    public class InvoiceResponse
    {
        [DataMember]
        public List<InvoiceErrorResponse> lstInvoiceErrorResponse { get; set; }

        [DataMember]
        public InvoiceResultResponse invoiceResultResponse { get; set; }
    }

    public class P2PInvoiceResponse : P2PDocumentResponse
    {
        [DataMember]
        public decimal? UseTax { get; set; }

        [DataMember]
        public InvoiceItem invoiceItem { get; set; }
    }

    public class P2PInvoiceUploadInfo
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string UserContext { get; set; }

        [DataMember]
        public string UserEmail { get; set; }

        [DataMember]
        public string UploadedFileId { get; set; }

        [DataMember]
        public string UploadedFileName { get; set; }

        [DataMember]
        public string UploadedFileType { get; set; }

        [DataMember]
        public string UploadedFileUri { get; set; }

        [DataMember]
        public string ProcessedFileId { get; set; }

        [DataMember]
        public string ProcessedFileName { get; set; }

        [DataMember]
        public string ProcessedFileType { get; set; }

        [DataMember]
        public string ProcessedFileUri { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public int Total { get; set; }

        [DataMember]
        public int Processed { get; set; }

        [DataMember]
        public int UnProcessed { get; set; }

        [DataMember]
        public string BuyerCompanyName { get; set; }

        [DataMember]
        public string ProcessedResult { get; set; }

        [DataMember]
        public string ProcessedResultXml { get; set; }

        [DataMember]
        public string RequestedTime { get; set; }

        [DataMember]
        public string CompletionTime { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public long CreatedBy { get; set; }

        [DataMember]
        public string InvoiceNumbers { get; set; }

        [DataMember]
        public List<InvoiceResultResponse> lstInvoiceResultResponse { get; set; }

        [DataMember]
        public int ExcelFileType { get; set; }

        [DataMember]
        public bool ProcessedStatus { get; set; }

        [DataMember]
        public string Error { get; set; }

        [DataMember]
        public string ErrorTrace { get; set; }
    }

    public class P2PInvoiceCustomFieldInfo
    {
        [DataMember]
        public string CustomFieldName { get; set; }

        [DataMember]
        public bool IsVisible { get; set; }

        [DataMember]
        public bool IsMandatory { get; set; }

        [DataMember]
        public bool IsHeaderLevel { get; set; }

        [DataMember]
        public bool IsText { get; set; }
    }

    public class KeyValue
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Value { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public bool IsDefault { get; set; }
    }

    //[DataContract]
    //[Serializable]
    //[KnownType(typeof(ExcelItemColumns))]
    //[System.Xml.Serialization.XmlInclude(typeof(ExcelAccountingColumns))]
    public class InvoiceSplitItemErrorResponse
    {
        [DataMember]
        public int ReferenceNumber { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string ItemLineNumber { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public List<ExcelAccountingColumns> FieldMapping { get; set; }

        [DataMember]
        public List<InvoiceSplitItemAccountingErrors> AccountingFieldMapping { get; set; }
    }

    public class InvoiceCustomattributeErrors
    {
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string FieldName { get; set; }

        [DataMember]
        public string FieldValue { get; set; }
    }

    public class InvoiceSplitItemAccountingErrors
    {
        [DataMember]
        public int SplitNumber { get; set; }

        [DataMember]
        public string FieldName { get; set; }

        [DataMember]
        public string FieldValue { get; set; }
    }

    public class InvoiceTaxCodeErrorResponse
    {
        [DataMember]
        public int ReferenceNumber { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string ItemLineNumber { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string TaxCode { get; set; }

        [DataMember]
        public List<ExcelTaxCodesColumns> FieldMapping { get; set; }

        [DataMember]
        public List<TaxCodeErrors> LstTaxCodeErrors { get; set; }
    }

    public class TaxCodeErrors
    {
        [DataMember]
        public string TaxCode { get; set; }

        [DataMember]
        public string FieldName { get; set; }

        [DataMember]
        public string ErrorMessage { get; set; }
    }

    public class CreditMemoItemTaxCode
    {
        [DataMember]
        public long CreditMemoId { get; set; }

        [DataMember]
        public int DocumentStatus { get; set; }

        [DataMember]
        public long CreditMemoItemId { get; set; }

        [DataMember]
        public long InvoiceItemId { get; set; }

        [DataMember]
        public int TaxId { get; set; }

        [DataMember]
        public string TaxCode { get; set; }
    }
}