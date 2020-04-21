using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class SmartFlowRequest
    {
        [DataMember]
        public Guid SmartflowId { get; set; }

        [DataMember]
        public SmartFlowTypes SmartFlowType { get; set; }

        [DataMember]
        public long BuyerPartnerCode { get; set; }

        [DataMember]
        public Guid TransactionId { get; set; }

        [DataMember]
        public Guid StageId { get; set; }

        [DataMember]
        public string StageName { get; set; }

        [DataMember]
        public Guid ActivityId { get; set; }

        [DataMember]
        public string ActivityName { get; set; }

        [DataMember]
        public int BatchIndex { get; set; }

        [DataMember]
        public int BatchOccurrence { get; set; }
    }
}