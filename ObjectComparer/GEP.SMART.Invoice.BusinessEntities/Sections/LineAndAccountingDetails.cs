using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class LineAndAccountingDetails
    {
        public List<LineItem> Items { get; set; }
    }

    public class LineItem
    {
        public IdNameAndAddress ShipFromLocation { get; set; }
        public IdNameAndEmail OrderContact { get; set; }
        public IdNameAndAddress OrderingLocation { get; set; }
        public IdNameAndEmail PartnerContact { get; set; }
        public string OrderNumber { get; set; }
        public string OrderName { get; set; }
        public decimal? OrderLineValue { get; set; }
        public decimal? TotalAllowance { get; set; }
        public double? RemainingInvoiceAmount { get; set; }
        public IdNameAndAddress DeliverTo { get; set; }
        public int Status { get; set; }
        public int SplitType { get; set; }
        public long Id { get; set; }
        public long LineNumber { get; set; }
        public long DocumentCode { get; set; }
        public IdAndName DocumentStatus { get; set; }
        public long P2PLineItemId { get; set; }
        public long? CatalogItemId { get; set; }
        public double? Taxes { get; set; }
        public long? TaxRate { get; set; }
        public decimal? TaxPercentage { get; set; }
        public List<Tax> TaxItems { get; set; }
        public double Quantity { get; set; }
        public double? UnitPrice { get; set; }
        public double? OtherCharges { get; set; }
        public double? ShippingCharges { get; set; }
        public double? ContractValue { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public DateTime? ContractExpiryDate { get; set; }
        public string Name { get; set; }
        public BuyerItemNumber BuyerItemNumber { get; set; }
        public Description Description { get; set; }
        public string Manufacturer { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public string ManufacturerModel { get; set; }
        public string ContractNumber { get; set; }
        public string PartnerItemNumber { get; set; }
        public decimal OrderedQuantity { get; set; }
        public IdAndName Type { get; set; }
        public DateTime? NeedByDate { get; set; }
        public DateTime? RequestedDate { get; set; }
        public CodeAndName ShippingMethod { get; set; }
        public string InventoryType { get; set; }
        public string Inventory { get; set; }
        public string InventoryDisplayType { get; set; }
        public string DeliverToStr { get; set; }
        public bool IsDeleted { get; set; }
        public IdNameAndAddress ShipTo { get; set; }
        public CodeNameAndAllowDecimal Uom { get; set; }
        public IdAndName Source { get; set; }
        public string ClientPartnerCode { get; set; }
        public IdNameAndCode Partner { get; set; }
        public IdAndName Category { get; set; }
        public IdAndName CreatedBy { get; set; }
        public IdAndName LastModifiedBy { get; set; }
        public IdAndName ItemStatus { get; set; }
        public decimal OverallItemLimit { get; set; }
        public bool IsTaxExempt { get; set; }
        public Contract Contract { get; set; }
        public bool AllowDecimal { get; set; }
        public IdAndName ContractItems { get; set; }
        public string ManufacturerName { get; set; }
        public string PartnerContactEmail { get; set; }
        public string PartnerContactNumber { get; set; }
        public string SentForBidding { get; set; }
        public IdAndName SupplierDispatchMode { get; set; }
        public IdAndName MatchType { get; set; }
        public int MatchStatus { get; set; }
        public long TrasmissionMode { get; set; }
        public string TransmissionValue { get; set; }
        public int LineStatus { get; set; }
        public string LineStatusValue { get; set; }
        public decimal ExternalTax { get; set; }
        public List<ItemChargeExtension> ChargeItems { get; set; }
        public List<InvoiceAccountingSplit> Splits { get; set; }
        public List<Tax> ExternalTaxItems { get; set; }
        public decimal? OrderUnitPrice { get; set; }
        public long? OrderItemId { get; set; }
        public long? OrderLineNumber { get; set; }
        public bool HasComments { get; set; }
        public decimal AccrueTaxes { get; set; }
        public List<Tax> AccrueTaxItems { get; set; }
        public List<CustomFieldInfo> LstCustomFields { get; set; }
        public FulfilmentDocumentInfo FulfilmentDocumentInfo { get; set; }
        public string PriceType { get; set; }
        public string JobTitle { get; set; }
        public string ContingentWorkerName { get; set; }
        public decimal Margin { get; set; }
        public decimal BaseRate { get; set; }
        public string ReportingManager { get; set; }
        public DateTime? FirstReceiptDate { get; set; }
        public DateTime? LastReceiptDate { get; set; }

        public decimal AcceptedQuantity { get; set; }
    }

    public class BuyerItemNumber
    {
        public string code { get; set; }
    }

    public class Description
    {
        public string desc { get; set; }
    }
}