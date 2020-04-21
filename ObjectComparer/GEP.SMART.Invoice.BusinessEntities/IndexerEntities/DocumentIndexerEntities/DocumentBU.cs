using Newtonsoft.Json;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public partial class DocumentBU
    {
        [JsonIgnore]
        public long DocumentCode { get; set; }

        public long BUCode { get; set; }
    }
}