using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class P2PVariance
    {
        [DataMember]
        public string PropName { get; set; }

        [DataMember]
        public string FromValue { get; set; }

        [DataMember]
        public string ToValue { get; set; }

        [DataMember]
        public string PropStatus { get; set; }

        [DataMember]
        public string UpdatedBy { get; set; }

        [DataMember]
        public string UpdatedVia { get; set; }

        [DataMember]
        public string UpdatedOn { get; set; }
    }

    [DataContract]
    [Serializable]
    public class P2PVarianceByLevel
    {
        [DataMember]
        public long itemMappingId { get; set; }

        [DataMember]
        public int splitIndex { get; set; }

        [DataMember]
        public Level level { get; set; }

        [DataMember]
        public List<P2PVariance> listVariance { get; set; }
    }
}