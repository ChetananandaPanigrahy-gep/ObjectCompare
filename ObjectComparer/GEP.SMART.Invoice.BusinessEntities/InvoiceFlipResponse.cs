namespace GEP.SMART.Invoice.BusinessEntities
{
    public class InvoiceFlipResponse
    {
        public long InvoiceID { get; set; }
        public string Message { get; set; }
        public bool IsInvoiceCreated { get; set; }
        public string EncryptedDD { get; set; }
        public long LOBEntityDetailCode { get; set; }
        public bool AutoCreateInvoice { get; set; }
    }
}