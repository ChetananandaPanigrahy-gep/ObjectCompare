using Newtonsoft.Json;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class DM_DocumentRegion
    {
        [JsonIgnore]
        public long DocumentCode { get; set; }

        public long RegionCode { get; set; }
        public string RegionName { get; set; }
    }
}