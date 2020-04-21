using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class ExceptionOverride
    {
        [DataMember]
        public long InvoiceId { get; set; }

        [DataMember]
        public int ExceptionId { get; set; }

        [DataMember]
        public int Override { get; set; }

        [DataMember]
        public int IsResolved { get; set; }

        [DataMember]
        public long OverridenBy { get; set; }

        [DataMember]
        public long LineItemID { get; set; }
    }
}