using Newtonsoft.Json;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class P2P_InvoiceRemittanceDetails
    {
        public string PaymentReferenceNumber { get; set; }
        public string PaymentRemittanceId { get; set; }

        [JsonIgnore]
        public long InvoiceId { get; set; }
    }
}