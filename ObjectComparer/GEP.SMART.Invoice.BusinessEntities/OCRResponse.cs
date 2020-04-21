using System;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class OCRResponse
    {
        public Guid TransactionId { get; set; }
        public long ImageId { get; set; }
        public dynamic DocumentResponse { get; set; }
        public long InvoiceId { get; set; }
    }
}