using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class InvoiceResultResponse
    {
        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}