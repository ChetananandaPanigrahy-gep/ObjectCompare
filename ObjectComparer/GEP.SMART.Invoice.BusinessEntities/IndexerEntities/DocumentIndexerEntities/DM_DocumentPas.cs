using Newtonsoft.Json;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class DM_DocumentPas
    {
        [JsonIgnore]
        public long DocumentCode { get; set; }

        public long PasCode { get; set; }
        public string PASName { get; set; }
    }
}