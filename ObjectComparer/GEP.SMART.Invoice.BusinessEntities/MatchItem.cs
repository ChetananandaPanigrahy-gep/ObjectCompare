using Gep.Cumulus.CSM.Entities;
using System;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class MatchItem
    {
        public long DocumentId { get; set; }

        public long ItemId { get; set; }

        public long P2PItemId { get; set; }

        public int MatchItemId { get; set; }

        public MatchStatus MatchItemStatus { get; set; }

        public DocumentType DocumentType { get; set; }

        public MatchType MatchType { get; set; }

        public decimal Quantity { get; set; }

        public decimal ReceivedQuantity { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? Tax { get; set; }

        public decimal? ExternalTax { get; set; }

        public decimal? VendorTax { get; set; }

        public decimal? ShippingCharges { get; set; }

        public decimal? AdditionalCharges { get; set; }

        public decimal? TotalAllowance { get; set; }

        public decimal? ItemValue { get { return (Quantity * UnitPrice) - TotalAllowance; } }

        public decimal MatchedQuantity { get; set; }

        public decimal MatchedItemValue { get; set; }

        public decimal MatchedTax { get; set; }

        public decimal MatchedShippingCharges { get; set; }

        public string UOM { get; set; }

        public decimal MatchedAdditionalCharges { get; set; }

        public ToleranceDetails ToleranceDetails { get; set; }

        public ItemType ItemType { get; set; }

        public ItemExtendedType ItemExtendedType { get; set; }

        public string ExceptionMessage { get; set; }

        public decimal OriginalQuantity { get; set; }

        public decimal ItemReceivingTolerance { get; set; }

        public decimal InvoiceAdvanceAmount { get; set; }

        public decimal OrderAdvanceAmount { get; set; }

        public decimal MatchedInvoiceAdvanceAmount { get; set; }

        public int ChargeTypeCode { get; set; }

        public long OrderId { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime InvoiceCreationDate { get; set; }

        public int DateBlockExceptionToleranceInDays { get; set; }

        public int FulfilmentDocumentItemId { get; set; }

        public int FulfilmentDocumentType { get; set; }

        public int DocumentStatus { get; set; }

        public decimal ItemTotalValue { get; set; }

        public decimal ItemTotalTaxValue { get; set; }

        public decimal ItemTotalForAggregation { get; set; }

        public decimal ItemTaxForAggregation { get; set; }

        public decimal? TotalReceivedAmount { get; set; }

        public decimal MatchedAmount { get; set; }

        public decimal CreditAmount { get; set; }
    }
}