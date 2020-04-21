using System;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class IRApprovalDetail
    {
        public string IRName { get; set; }
        public string IRNumber { get; set; }
        public string OrderNumber { get; set; }
        public decimal? TotalValue { get; set; }
        public string SupplierInvoiceNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceCreationDate { get; set; }
        public DateTime? IRCreationDate { get; set; }
        public string Currecny { get; set; }
        public string SupplierName { get; set; }
        public string PaymentTerms { get; set; }
        public string BuyerName { get; set; }
        public string BuyerPhone1 { get; set; }
        public string BuyerPhone2 { get; set; }
        public string OrderingLocation { get; set; }
        public DateTime? SupplierInvoicedate { get; set; }
        public string OrderName { get; set; }
        public long IRId { get; set; }
    }
}