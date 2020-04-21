using Newtonsoft.Json;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class P2P_RequisitionLink
    {
        public string DocumentNumber { get; set; }
        public string DocumentName { get; set; }
        public long RequesterOnBehalfOfCode { get; set; }
        public string RequesterOnBehalfOfName { get; set; }
        public long Creator { get; set; }

        [JsonIgnore]
        public long OrderId { get; set; }

        [JsonIgnore]
        public long ReceiptId { get; set; }

        [JsonIgnore]
        public long InvoiceId { get; set; }

        [JsonIgnore]
        public long CreditMemoId { get; set; }
    }
}