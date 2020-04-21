using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class IRType
    {
        [DataMember]
        public int IRTypeId { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public long CreatedBy { get; set; }

        [DataMember]
        public DateTime CreatedOn { get; set; }
    }
}