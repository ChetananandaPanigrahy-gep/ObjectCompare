using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class Settings
    {
        public Dictionary<string, object> DocumentSettings { get; set; }
        public Dictionary<string, object> CommonSettings { get; set; }
        public Dictionary<string, object> CatalogSettings { get; set; }
        public Dictionary<string, object> MultiOrgSettings { get; set; }
        public Dictionary<string, object> CatalogAccessSettings { get; set; }
        public Dictionary<string, object> TaxSettings { get; set; }
        public Dictionary<string, object> PortalSettings { get; set; }
    }
}