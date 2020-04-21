using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class InvoiceIRMapping
    {
        public long InvoiceId { get; set; }
        public List<long> InvoiceReconciliationIds { get; set; }
    }
}