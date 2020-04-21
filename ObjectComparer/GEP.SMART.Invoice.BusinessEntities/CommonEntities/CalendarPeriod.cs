using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities.Old
{
    [DataContract]
    [Serializable]
    public class CalendarPeriod
    {
        [DataMember]
        public long PeriodId { get; set; }

        [DataMember]
        public int CalendarId { get; set; }

        [DataMember]
        public string PeriodName { get; set; }

        [DataMember]
        public string PeriodCode { get; set; }

        [DataMember]
        public DateTime StartDate { get; set; }

        [DataMember]
        public DateTime EndDate { get; set; }

        [DataMember]
        public int Status { get; set; }

        [DataMember]
        public string StatusDisplayName { get; set; }

        [DataMember]
        public long CreatedBy { get; set; }

        [DataMember]
        public long UpdatedBy { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }
    }
}