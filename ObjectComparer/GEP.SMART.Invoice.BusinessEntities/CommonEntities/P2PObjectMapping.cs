using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class P2PObjectMapping
    {
        [DataMember]
        public long srcObjectId { get; set; }

        [DataMember]
        public long tgtObjectId { get; set; }

        [DataMember]
        public long mappingObjectId { get; set; }

        [DataMember]
        public Level level { get; set; }
    }
}