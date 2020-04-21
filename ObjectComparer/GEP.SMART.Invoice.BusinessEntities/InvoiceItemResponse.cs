using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class InvoiceItemResponse
    {
        [DataMember]
        public long InvoiceId { get; set; }

        [DataMember]
        public long InvoiceItemId { get; set; }

        [DataMember]
        public long P2PLineItemId { get; set; }

        [DataMember]
        public long ItemLineNumber { get; set; }
    }
}