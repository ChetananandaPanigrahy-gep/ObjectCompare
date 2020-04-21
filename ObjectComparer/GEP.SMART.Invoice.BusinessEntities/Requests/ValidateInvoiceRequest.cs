namespace GEP.SMART.Invoice.BusinessEntities.Requests
{
    public class ValidateInvoiceRequest
    {
        public long DocumentId { get; set; }
        public long LOBEntityDetailCode { get; set; }
        public bool ReturnResourceErrorMsgKey { get; set; }
    }
}