using System.Collections.Generic;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public interface ICustomAttr
    {
        Dictionary<string, List<dynamic>> CustomAttributes { get; set; }
    }
}