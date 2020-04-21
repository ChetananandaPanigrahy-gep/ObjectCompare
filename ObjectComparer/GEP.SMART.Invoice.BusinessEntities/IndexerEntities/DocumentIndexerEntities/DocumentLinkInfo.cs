using Newtonsoft.Json;
using System;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class DocumentLinkInfo
    {
        [JsonIgnore]
        public long SourceDocumentCode { get; set; }

        public Nullable<int> SourceDocumentTypeCode { get; set; }
        public Nullable<long> LinkedDocumentCode { get; set; }
        public Nullable<int> LinkedDocumentTypeCode { get; set; }
    }
}