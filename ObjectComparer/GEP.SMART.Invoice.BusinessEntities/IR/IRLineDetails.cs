using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.IR
{
    public class IRLineDetails
    {
        public long LineNumber { get; set; }
        public KeyValuePair<long, string> Type { get; set; }
        public KeyValuePair<long, string> Category { get; set; }
        public KeyValuePair<string, string> UOM { get; set; }
        public KeyValuePair<long, string> MatchType { get; set; }
        public KeyValuePair<string, string> ShippingMethod { get; set; }
        public KeyValuePair<long, string> ItemStatus { get; set; }
        public KeyValuePair<long, string> Source { get; set; }
        public string BuyerItemNumber { get; set; }
        public string Description { get; set; }
        public string PartnerItemNumber { get; set; }
        public double Quantity { get; set; }
        public double? UnitPrice { get; set; }
        public double? Taxes { get; set; }
        public decimal ExternalTax { get; set; }
        public double? OtherCharges { get; set; }
        public double? ShippingCharges { get; set; }
        public decimal RemainingInvoiceAmount { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal TotalAllowance { get; set; }
        public decimal OverallItemLimit { get; set; }
        public long IRItemId { get; set; }
        public long P2PLineItemId { get; set; }
        public long InvoiceItemId { get; set; }
        public string Name { get; set; }
        public long? CatalogItemId { get; set; }
        public long DocumentCode { get; set; }
        public bool IsTaxExempt { get; set; }
        public string SupplierPartAuxiliaryId { get; set; }
        public short SplitType { get; set; }
        public string DeliverToStr { get; set; }
        public int MatchStatus { get; set; }
        public bool AccrueUseTax { get; set; }
        public string Capitalized { get; set; }
        public string CapitalCode { get; set; }
        public bool AccountingStatus { get; set; }
        public string PriceType { get; set; }
        public string JobTitle { get; set; }
        public string ContingentWorkerName { get; set; }
        public decimal Margin { get; set; }
        public decimal BaseRate { get; set; }
        public string ReportingManager { get; set; }
        public long ShipFromLocationId { get; set; }
        public ContactDetails ShipFromLocation { get; set; }
        public decimal? TotalCharge { get; set; }
        public List<IRAccountingDetails> Splits { get; set; }
        public OrderLineInfo OrderLineInfo { get; set; }
        public ContactDetails ShipTo { get; set; }
        public ContactDetails DeliverTo { get; set; }
        public Contract Contract { get; set; }
        public Catalog Catalog { get; set; }
        public ManufacturerDetails ManufacturerDetails { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal TaxPercentage { get; set; }
        public List<Taxes> TaxItems { get; set; }
        public List<Taxes> ExternalTaxItems { get; set; }
        public List<CustomFieldInfo> LstCustomFields { get; set; }
        public bool HasComments { get; set; }
        public string POLineItemNumberForIR { get; set; }

        public double? LineItemAmount
        {
            get
            {
                return ((UnitPrice == null || UnitPrice == 0) ? 0 : ((Quantity * UnitPrice) - decimal.ToDouble(TotalAllowance)));
            }
            set { }
        }
    }

    public class SelectedIRLineItem
    {
        public long documentId { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
        public ItemType itemType { get; set; }
        public int typeOfUser { get; set; }
    }
}