using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class InvoiceDetailsResponse
    {
        public List<InvoiceDetails> Invoices { get; set; }
        public long TotalItems { get; set; }
    }
}