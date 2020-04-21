using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class TimeSheetDetails
    {
        [DataMember]
        public string PriceType { get; set; }

        [DataMember]
        public string ContingentWorkerName { get; set; }

        [DataMember]
        public string JobTitle { get; set; }

        [DataMember]
        public decimal Margin { get; set; }

        [DataMember]
        public decimal BaseRate { get; set; }

        [DataMember]
        public string ReportingManager { get; set; }

        [DataMember]
        public string TESLineNumber { get; set; }

        [DataMember]
        public string TESNumber { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string UOM { get; set; }

        [DataMember]
        public decimal Effort { get; set; }

        [DataMember]
        public long DocumentCode { get; set; }

        [DataMember]
        public string TESURL { get; set; }

        [DataMember]
        public decimal UnitPrice { get; set; }
    }
}