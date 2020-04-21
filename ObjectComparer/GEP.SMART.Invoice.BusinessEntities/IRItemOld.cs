using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities.Old
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(MatchStatus))]
    [System.Xml.Serialization.XmlInclude(typeof(MatchStatus))]
    public class IRItem : InvoiceItem
    {
        [DataMember]
        public long InvoiceItemId { get; set; }

        [DataMember]
        public decimal AcceptedQuantity { get; set; }

        [DataMember]
        public string Requester { get; set; }

        [DataMember]
        public string Receiver { get; set; }

        [DataMember]
        public decimal LineAmountDiff { get; set; }
    }
}