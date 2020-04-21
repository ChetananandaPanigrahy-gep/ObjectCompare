using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class InvoiceResponse
    {
        [DataMember]
        public long InvoiceId { get; set; }

        [DataMember]
        public string InvoiceNumber { get; set; }

        [DataMember]
        public DateTime DateCreated { get; set; }

        [DataMember]
        public long LOBEntityDetailCode { get; set; }

        [DataMember]
        public int TaxIntegrattionType { get; set; }

        [DataMember]
        public long PartnerCode { get; set; }
    }
}