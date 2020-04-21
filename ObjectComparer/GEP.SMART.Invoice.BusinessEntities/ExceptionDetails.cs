using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class ExceptionDetails
    {
        public string Title { get; set; }
        public decimal? OrderValue { get; set; }
        public decimal InvoiceValue { get; set; }
        public decimal AcceptedValue { get; set; }
        public decimal ReceivedValue { get; set; }
        public decimal TotalInvoiceValue { get; set; }
        public MatchType OrderMatchType { get; set; }
        public int TotalRecords { get; set; }
        public int MatchStatus { get; set; }
        public decimal? PercentTolerance { get; set; }
        public decimal? ValueTolerance { get; set; }
        public int RequesterAccess { get; set; }
        public int ReceiverAccess { get; set; }
        public int ItemStatus { get; set; }
        public ItemType ItemType { get; set; }
        public ItemExtendedType ItemExtendedType { get; set; }
        public ICollection<MatchStatus> lstMatchStatus { get; set; } //Used to store All exception headers . Only first element has this list filled.
        public decimal UseTax { get; set; }
        public decimal? OrderPercentValue { get; set; }
        public decimal InvoicePercentValue { get; set; }
        public long OrderP2PLineItemId { get; set; }
        public long InvoiceItemId { get; set; }
        public string PartnerItemNumber { get; set; }
        public string BuyerItemNumber { get; set; }
        public string LineNumber { get; set; }
        public string ContractNumber { get; set; }
        public string PartnerStatus { get; set; }
        public string PartnerName { get; set; }
        public int OverrideFlag { get; set; }
        public string ItemMatchType { get; set; }
        public DateTime? PartnerInvoiceDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public decimal? OrderAmount { get; set; }
        public string DocumentStatus { get; set; }
        public string OrderContact { get; set; }
        public string InvoiceOrderContact { get; set; }
        public string OrderCurrency { get; set; }
        public string InvoiceCurrency { get; set; }
        public string OrderedUOM { get; set; }
        public string InvoiceUOM { get; set; }
        public string Description { get; set; }
        public int IsOverridable { get; set; }
        public long OrderId { get; set; }
        public long OrderLineNumber { get; set; }
        public string OrderNumber { get; set; }
        public IList<AcceptanceLog> ResolverDetails { get; set; }
        public bool AllowMultipleResolvers { get; set; }
        public int ResolverType { get; set; }
        public DateTime? ServiceEndDate { get; set; }
    }
}