using Newtonsoft.Json;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class DM_DocumentLOB
    {
        [JsonIgnore]
        public long DocumentCode { get; set; }

        public string LobName { get; set; }
        public long LobId { get; set; }
    }
}