using Newtonsoft.Json;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class DocumentWorkgroup
    {
        [JsonIgnore]
        public long DocumentCode { get; set; }

        public long WorkGroupId { get; set; }
        public string WorkGroupDisplayName { get; set; }
    }
}