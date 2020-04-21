using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class MatchOrderItem
    {
        [DataMember]
        public long OrderId { get; set; }

        [DataMember]
        public long OrderItemId { get; set; }

        [DataMember]
        public long p2PLineItemId { get; set; }

        [DataMember]
        public long lineNumber { get; set; }

        [DataMember]
        public string name { get; set; }
    }
}