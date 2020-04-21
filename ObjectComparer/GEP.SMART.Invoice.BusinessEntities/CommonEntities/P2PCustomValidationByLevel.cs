using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class P2PCustomValidationByLevel
    {
        [DataMember]
        public long itemMappingId { get; set; }

        [DataMember]
        public long splitId { get; set; }

        [DataMember]
        public Level level { get; set; }

        [DataMember]
        public List<long> listQuestionIds { get; set; }
    }
}