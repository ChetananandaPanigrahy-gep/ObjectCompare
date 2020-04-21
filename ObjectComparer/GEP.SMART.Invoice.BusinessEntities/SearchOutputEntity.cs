using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class SearchOutputEntity
    {
        public string Status { get; set; }
        public SearchData Data { get; set; }
        public string Message { get; set; }
        public string Trace { get; set; }
        public string Query { get; set; }
    }

    public class SearchData
    {
        public string _scroll_id { get; set; }
        public SearchHits hits { get; set; }
    }

    public class SearchHits
    {
        public int total { get; set; }
        public List<JObject> hits { get; set; }
        //public List<SearchSourceObject> hits { get; set; }
    }

    public class SearchSourceObject
    {
        public SearchOutputObject _source { get; set; }
    }

    public class SearchOutputObject
    {
        public long code { get; set; }
    }
}