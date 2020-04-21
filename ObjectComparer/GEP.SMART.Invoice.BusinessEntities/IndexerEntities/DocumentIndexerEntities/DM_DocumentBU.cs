using Newtonsoft.Json;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class DM_DocumentBU
    {
        [JsonIgnore]
        public long DocumentCode { get; set; }

        public long BUCode { get; set; }
        public string EntityDisplayName { get; set; }
        //public bool IsActive { get; set; }
    }
}