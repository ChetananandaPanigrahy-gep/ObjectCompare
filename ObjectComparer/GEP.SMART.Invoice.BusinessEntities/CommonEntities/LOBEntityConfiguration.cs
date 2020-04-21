using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    public class LOBEntityConfiguration
    {
        [DataMember]
        public long DivisionEntityCode { get; set; }

        [DataMember]
        public int EntityId { get; set; }

        [DataMember]
        public int IdentificationTypeID { get; set; }
    }
}