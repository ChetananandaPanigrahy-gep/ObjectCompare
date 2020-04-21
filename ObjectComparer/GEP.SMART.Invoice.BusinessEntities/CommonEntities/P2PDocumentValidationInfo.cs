using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class P2PDocumentValidationInfo
    {
        [DataMember]
        public int TabIndexId { get; set; }

        [DataMember]
        public string ErrorCodes { get; set; }
    }
}