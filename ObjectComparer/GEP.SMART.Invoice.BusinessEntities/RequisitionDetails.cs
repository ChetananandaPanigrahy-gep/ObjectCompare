using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    public class RequisitionDetails
    {
        [DataMember]
        public string RequisitionName { get; set; }

        [DataMember]
        public string RequisitionNumber { get; set; }

        [DataMember]
        public long RequisitionId { get; set; }

        [DataMember]
        public bool IsUrgent { get; set; }

        [DataMember]
        public string Url { get; set; }
    }
}