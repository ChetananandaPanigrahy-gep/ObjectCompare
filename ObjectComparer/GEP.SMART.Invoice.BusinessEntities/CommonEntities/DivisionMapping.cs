using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class DivisionMapping
    {
        [DataMember]
        public long DivisionEntityCode { get; set; }

        [DataMember]
        public long? EntityDetailCode { get; set; }

        [DataMember]
        public int? EntityId { get; set; }
    }
}