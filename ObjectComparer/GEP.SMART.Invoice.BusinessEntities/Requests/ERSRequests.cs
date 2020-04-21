using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.Requests
{
    //[Serializable]
    public class SaveInvoiceHeaderRequest
    {
        public Order HeaderInfo { get; set; }
        
        public string FulfilmentDocumentCodes { get; set; }
    }

    public class SaveInvoiceItemsRequest
    {
        public IEnumerable<OrderItem> PoItemList { get; set; }
        public long InvoiceId { get; set; }
    }

    public class SaveInvoiceAccountingRequest
    {
        public IEnumerable<OrderItem> PoItemAccounting { get; set; }
        public long InvoiceId { get; set; }
    }

    public class SaveInternalTaxRequest
    {
        public IEnumerable<OrderItem> PoTaxItemList { get; set; }
        public long InvoiceId { get; set; }
    }

    public class SaveExternalTaxRequest
    {
        public long InvoiceId { get; set; }
    }

    public class DocumentMappingRequest
    {
        public long ReceiptId { get; set; }
    }
}