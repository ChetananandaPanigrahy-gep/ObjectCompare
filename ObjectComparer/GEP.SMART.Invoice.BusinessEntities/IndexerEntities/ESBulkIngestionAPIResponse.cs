using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.IndexerEntities
{
    public class ESBulkIngestionAPIResponse
    {
        public string Status { get; set; }
        public List<BulkIngestionAPIResponseData> Data { get; set; }
    }

    public class BulkIngestionAPIResponseData
    {
        public string IndexName { get; set; }
        public string ESTypeName { get; set; }
        public string ObjectCode { get; set; }
        public string Status { get; set; }
        public string Error { get; set; }
    }
}