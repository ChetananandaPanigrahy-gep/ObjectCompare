using GEP.Smart.Platform.SearchCoreIntegretor.Entities;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class POSearchItem
    {
        public string ContactCode { get; set; }

        public double Scoring { get; set; }

        public DocumentDetail DocumentDetails { get; set; }

        public DocumentSearchOutput DocumentSearchOutput { get; set; }

        public string SearchScope { get; set; }

        public string Type { get; set; }

        public string ModuleName { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }

        public string DocumentCode { get; set; }

        public string Url { get; set; }

        public string PartnerCode { get; set; }

        public string Scope { get; set; }
    }
}