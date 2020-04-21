using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.ExportDataSetEntities
{
    public class P2PDocumentDataSet
    {
        public List<AccountingDetails> AccountingDetails { get; set; }
        public List<DocumentAdditionalEntityInfo> DocumentAdditionalEntityInfo { get; set; }
        public List<DocumentBUList> DocumentBUList { get; set; }
        public List<HeaderComment> HeaderComment { get; set; }
        public List<LineItemComment> LineItemComment { get; set; }
        public List<P2PDocument> P2PDocument { get; set; }
        public List<P2PItem> P2PItem { get; set; }
        public List<Questionnaire> Questionnaire { get; set; }
        public List<RequesterDetails> RequesterDetails { get; set; }
        public List<StandardsAndProcedures> StandardsAndProcedures { get; set; }
    }

    public class AccountingDetails
    {
        public long DocumentItemID { get; set; }
        public long SplitItemEntityId { get; set; }
        public long SplitItemId { get; set; }
        public decimal Percentage { get; set; }
        public decimal Quantity { get; set; }
        public decimal SplitItemTotal { get; set; }
        public int SplitAccountingFieldConfigId { get; set; }
        public string SplitAccountingFieldValue { get; set; }
        public string EntityDisplayName { get; set; }
        public string EntityCode { get; set; }
        public int EntityTypeId { get; set; }
        public int CodeCombinationOrder { get; set; }
        public string ParentEntityDetailCode { get; set; }
        public int FieldOrder { get; set; }
        public string EntityType { get; set; }
        public decimal SplitItemTax { get; set; }
        public string EntityTitle { get; set; }
    }

    public class DocumentAdditionalEntityInfo
    {
        public string EntityDisplayName { get; set; }
        public string EntityCode { get; set; }
    }

    public class DocumentBUList
    {
        public long BusinessUnitCode { get; set; }
        public bool BusinessUnitCodeSpecified { get; set; }
        public string BusinessUnitName { get; set; }
    }

    public class HeaderComment
    {
        public string UserName { get; set; }
        public string DateCreated { get; set; }
        public string Visibility { get; set; }
        public string CommentText { get; set; }
        public string GroupText { get; set; }
    }

    public class LineItemComment
    {
        public string UserName { get; set; }
        public string DateCreated { get; set; }
        public string Visibility { get; set; }
        public string CommentText { get; set; }
        public long DocumentItemId { get; set; }
        public bool DocumentItemIdSpecified { get; set; }
        public string GroupText { get; set; }
        public string P2PLineItemId { get; set; }
    }

    public class P2PDocument
    {
        public long DocumentCode { get; set; }
        public bool DocumentCodeSpecified { get; set; }
        public string DocumentName { get; set; }
        public string DocumentNumber { get; set; }
        public string DateCreated { get; set; }
        public byte DocumentSourceTypeInfo { get; set; }
        public bool DocumentSourceTypeInfoSpecified { get; set; }
        public int DocumentStatusInfo { get; set; }
        public bool DocumentStatusInfoSpecified { get; set; }
        public int DocumentTypeInfo { get; set; }
        public bool DocumentTypeInfoSpecified { get; set; }
        public string CurrencyCode { get; set; }
        public string ShiptoLocationName { get; set; }
        public string BilltoLocationName { get; set; }
        public decimal ItemTotal { get; set; }
        public bool ItemTotalSpecified { get; set; }
        public decimal Tax { get; set; }
        public bool TaxSpecified { get; set; }
        public decimal Shipping { get; set; }
        public bool ShippingSpecified { get; set; }
        public decimal AdditionalCharges { get; set; }
        public bool AdditionalChargesSpecified { get; set; }
        public string ShiptoLocationAddressLine1 { get; set; }
        public string ShiptoLocationAddressLine2 { get; set; }
        public string ShiptoLocationAddressLine3 { get; set; }
        public string ShiptoLocationCity { get; set; }
        public string ShiptoLocationStateName { get; set; }
        public string ShiptoLocationZipCode { get; set; }
        public string ShiptoLocationCountryName { get; set; }
        public string BilltoLocationAddressLine1 { get; set; }
        public string BilltoLocationAddressLine2 { get; set; }
        public string BilltoLocationAddressLine3 { get; set; }
        public string BilltoLocationCity { get; set; }
        public string BilltoLocationZipCode { get; set; }
        public string BilltoLocationEmailAddress { get; set; }
        public string BilltoLocationFaxNo { get; set; }
        public string BilltoLocationStateName { get; set; }
        public string BilltoLocationCountryName { get; set; }
        public string PartnerName { get; set; }
        public string PartnerEmailId { get; set; }
        public string CompanyName { get; set; }
        public string PartnerAddressLine1 { get; set; }
        public string PartnerAddressLine2 { get; set; }
        public string PartnerAddressLine3 { get; set; }
        public string PartnerCity { get; set; }
        public string PartnerZipCode { get; set; }
        public string PartnerStateName { get; set; }
        public string PartnerPhone1 { get; set; }
        public string PartnerPhone2 { get; set; }
        public string BuyerEmailId { get; set; }
        public string BuyerPhone1 { get; set; }
        public string BuyerPhone2 { get; set; }
        public string PartnerCountryName { get; set; }
        public string BuyerAddressLine1 { get; set; }
        public string BuyerAddressLine2 { get; set; }
        public string BuyerAddressLine3 { get; set; }
        public string BuyerZipode { get; set; }
        public string BuyerStateName { get; set; }
        public string BuyerCity { get; set; }
        public string BuyerCountryName { get; set; }
        public string BuyerCompanyName { get; set; }
        public string RequesterName { get; set; }
        public string RequesterEmailId { get; set; }
        public string RequesterPhone { get; set; }
        public string DelivertoLocationName { get; set; }
        public string DelivertoLocationAddressLine1 { get; set; }
        public string DelivertoLocationAddressLine2 { get; set; }
        public string DelivertoLocationAddressLine3 { get; set; }
        public string DelivertoLocationCity { get; set; }
        public string DelivertoLocationStateName { get; set; }
        public string DelivertoLocationCountryName { get; set; }
        public string DelivertoLocationZipCode { get; set; }
        public string DeliverTo { get; set; }
        public string ClientLocationCode { get; set; }
        public string LocationName { get; set; }
        public string PartnerFaxNo { get; set; }
        public string DispatchMode { get; set; }
        public string CustomFieldJson { get; set; }
        public string OnBehalfOf { get; set; }
        public string IsUrgent { get; set; }
        public string HeaderLevelBU { get; set; }
        public string FormID { get; set; }
        public int HasFlexibleCharges { get; set; }
        public bool HasFlexibleChargesSpecified { get; set; }
        public string PartnerImageUrl { get; set; }
        public string DeliveryInstructions { get; set; }
        public string VATRegistrationNumber { get; set; }
        public string RegisteredNumber { get; set; }
        public string ClientPartnerCode { get; set; }
        public string InvoicingMethod { get; set; }
        public string LegalCompanyName { get; set; }
        public string PostalAddressLine1 { get; set; }
        public string PostalAddressLine2 { get; set; }
        public string PostalAddressLine3 { get; set; }
        public string RevisionNumber { get; set; }
        public decimal RequisitionTotalChange { get; set; }
        public bool RequisitionTotalChangeSpecified { get; set; }
        public string PurchaseType { get; set; }
        public string DocumentStatusDisplayName { get; set; }
        public string BuyerName { get; set; }
        public decimal formId { get; set; }
        public decimal TotalAllowance { get; set; }
        public string DeliveryNoteNumber { get; set; }
    }

    public class P2PItem
    {
        public long InvoiceItemId { get; set; }
        public int DocumentItemId { get; set; }
        public string ShortName { get; set; }
        public decimal Quantity { get; set; }
        public bool QuantitySpecified { get; set; }
        public decimal UnitPrice { get; set; }
        public bool UnitPriceSpecified { get; set; }
        public string UOMDesc { get; set; }
        public decimal Total { get; set; }
        public bool TotalSpecified { get; set; }
        public string CategoryName { get; set; }
        public string DateRequested { get; set; }
        public string DateNeeded { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxPercent { get; set; }
        public bool TaxSpecified { get; set; }
        public decimal ShippingCharges { get; set; }
        public bool ShippingChargesSpecified { get; set; }
        public decimal AdditionalCharges { get; set; }
        public bool AdditionalChargesSpecified { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public string ShiptoLocationAddressLine1 { get; set; }
        public string ShiptoLocationAddressLine2 { get; set; }
        public string ShiptoLocationAddressLine3 { get; set; }
        public string ShiptoLocationCity { get; set; }
        public string ShiptoLocationState { get; set; }
        public string ShiptoLocationZip { get; set; }
        public string ShiptoLocationCountry { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public decimal Efforts { get; set; }
        public bool EffortsSpecified { get; set; }
        public string Description { get; set; }
        public string PartnerName { get; set; }
        public byte ItemTypeID { get; set; }
        public bool ItemTypeIDSpecified { get; set; }
        public string ShippingMethod { get; set; }
        public string CurrencyCode { get; set; }
        public string ShiptoLocationName { get; set; }
        public string ItemNumber { get; set; }
        public string TaxExempt { get; set; }
        public string ItemExtendedType { get; set; }
        public string Billable { get; set; }
        public string Capitalized { get; set; }
        public string DelivertoLocationName { get; set; }
        public string DelivertoLocationAddressLine2 { get; set; }
        public string DelivertoLocationAddressLine3 { get; set; }
        public string DelivertoLocationCity { get; set; }
        public string DelivertoLocationStateName { get; set; }
        public string DelivertoLocationCountryName { get; set; }
        public string DelivertoLocationZipCode { get; set; }
        public string DelivertoLocationAddressLine1 { get; set; }
        public decimal OrderedQuantity { get; set; }
        public bool OrderedQuantitySpecified { get; set; }
        public decimal OrderedUnitPrice { get; set; }
        public bool OrderedUnitPriceSpecified { get; set; }
        public decimal InvoicedAmount { get; set; }
        public bool InvoicedAmountSpecified { get; set; }
        public decimal RemainingAmount { get; set; }
        public bool RemainingAmountSpecified { get; set; }
        public decimal ReceivedQuantity { get; set; }
        public bool ReceivedQuantitySpecified { get; set; }
        public decimal AcceptedQuantity { get; set; }
        public string ReturnedQuantity { get; set; }
        public bool AcceptedQuantitySpecified { get; set; }
        public string PartnerItemNumber { get; set; }
        public int ShiptoLocationID { get; set; }
        public bool ShiptoLocationIDSpecified { get; set; }
        public string DeliverTo { get; set; }
        public string ReasonForReturn { get; set; }
        public decimal PreviouslyReturnedQuantity { get; set; }
        public bool PreviouslyReturnedQuantitySpecified { get; set; }
        public long ItemLineNumber { get; set; }
        public bool ItemLineNumberSpecified { get; set; }
        public long ItemStatus { get; set; }
        public bool ItemStatusSpecified { get; set; }
        public string ReceivedDate { get; set; }
        public decimal ReceivedAmount { get; set; }
        public bool ReceivedAmountSpecified { get; set; }
        public string ContractNo { get; set; }
        public string P2PLineItemId { get; set; }
        public bool IsCloseForReceiving { get; set; }
        public bool IsCloseForReceivingSpecified { get; set; }
        public bool IsCloseForInvoicing { get; set; }
        public bool IsCloseForInvoicingSpecified { get; set; }
        public string ErrorJson { get; set; }
        public int MatchType { get; set; }
        public bool MatchTypeSpecified { get; set; }
        public string DispatchMode { get; set; }
        public string EnableDispatchMode { get; set; }
        public string FormID { get; set; }
        public int SourceType { get; set; }
        public bool SourceTypeSpecified { get; set; }
        public string OverallCompletion { get; set; }
        public string RemainingWork { get; set; }
        public string Effort { get; set; }
        public string ManufacturerSupplierCode { get; set; }
        public string ManufacturerModel { get; set; }
        public int HasFlexibleCharges { get; set; }
        public bool HasFlexibleChargesSpecified { get; set; }
        public decimal OverallItemLimit { get; set; }
        public string OrderLineNumber { get; set; }
        public string OrderNumber { get; set; }
        public string OrderName { get; set; }
        public string BuyerName { get; set; }
        public string ClientLocationCode { get; set; }
        public string LocationName { get; set; }
        public string OrderingLocation { get; set; }
        public string OrderingLocationAddress { get; set; }
        public string PriceType { get; set; }
        public string JobTitle { get; set; }
        public string ContingentWorkerName { get; set; }
        public decimal Margin { get; set; }
        public bool MarginSpecified { get; set; }
        public decimal BaseRate { get; set; }
        public bool BaseRateSpecified { get; set; }
        public string ReportingManager { get; set; }
        public int InventoryType { get; set; }
        public bool InventoryTypeSpecified { get; set; }
        public int LineStatus { get; set; }
        public bool LineStatusSpecified { get; set; }
        public int isProcurable { get; set; }
        public bool isProcurableSpecified { get; set; }
        public string StockReservationNumber { get; set; }
        public string ShipFromLocationName { get; set; }
        public string ShipFromLocAddress1 { get; set; }
        public string ShipFromLocAddress2 { get; set; }
        public string ShipFromLocAddress3 { get; set; }
        public string ShipFromLocCity { get; set; }
        public string ShipFromLocState { get; set; }
        public string ShipFromLocZip { get; set; }
        public string ShipFromLocCountry { get; set; }
        public decimal Recoupment { get; set; }
        public decimal TotalAllowance { get; set; }
    }

    public class Questionnaire
    {
        public long DocumentItemId { get; set; }
        public bool DocumentItemIdSpecified { get; set; }
        public long QuestionnaireCode { get; set; }
        public bool QuestionnaireCodeSpecified { get; set; }
        public string QuestionnaireTitle { get; set; }
        public int SortOrder { get; set; }
        public bool SortOrderSpecified { get; set; }
        public string QuestionText { get; set; }
        public string ResponseValue { get; set; }
    }

    public class RequesterDetails
    {
        public string RequesterName { get; set; }
        public string RequesterEmailId { get; set; }
        public string RequesterPhone { get; set; }
        public long DocumentItemId { get; set; }
        public bool DocumentItemIdSpecified { get; set; }
    }

    public class StandardsAndProcedures
    {
        public string DocumentCode { get; set; }
        public string P2PItemId { get; set; }
        public string LevelType { get; set; }
        public string Code { get; set; }
        public string RevisionNumber { get; set; }
        public string Name { get; set; }
        public string FullText { get; set; }
    }

    public class SublineLevelCharges
    {
        public int LineNumber { get; set; }
        public bool LineNumberSpecified { get; set; }
        public string ChargeTypeName { get; set; }
        public decimal ChargeAmount { get; set; }
        public bool ChargeAmountSpecified { get; set; }
    }

    public class HeaderLevelCharges
    {
        public int LineNumber { get; set; }
        public bool LineNumberSpecified { get; set; }
        public string ChargeTypeName { get; set; }
        public decimal ChargeAmount { get; set; }
        public bool ChargeAmountSpecified { get; set; }
    }
}