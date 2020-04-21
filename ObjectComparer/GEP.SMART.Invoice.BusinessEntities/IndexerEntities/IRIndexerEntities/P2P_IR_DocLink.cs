using Newtonsoft.Json;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class P2P_IR_DocLink
    {
        public int? DocumentStatus { get; set; }

        [JsonIgnore]
        public long InvoiceId { get; set; }
    }
}