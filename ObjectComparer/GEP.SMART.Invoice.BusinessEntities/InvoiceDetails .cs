using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class InvoiceDetails
    {
        public List<EntityDetails> AccessControlEntities { get; set; }
        public List<ItemDetails> ItemDetails { get; set; }
        public long OrderId { get; set; }
        public long InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public string OrderName { get; set; }
        public decimal OrderAmount { get; set; }
        public string OrderNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime SupplierInvoiceDate { get; set; }
        public DateTime InvoiceDateReceived { get; set; }
        public DateTime InvoicePaidDate { get; set; }
        public DateTime SendForPaymentDate { get; set; }
        public long SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string CurrencyCode { get; set; }
    }
}