using Newtonsoft.Json;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public partial class DocumentCategory
    {
        [JsonIgnore]
        public long DocumentCode { get; set; }

        public long CategoryCode { get; set; }
    }
}