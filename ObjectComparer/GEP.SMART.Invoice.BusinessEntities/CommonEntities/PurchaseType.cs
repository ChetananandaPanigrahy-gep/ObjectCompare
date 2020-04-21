using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class PurchaseType
    {
        [DataMember]
        public int PurchaseTypeId { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public bool IsDefault { get; set; }

        [DataMember]
        public bool IsFlexibleCharge { get; set; }

        [DataMember]
        public bool IsHeaderContractVisible { get; set; }
    }
}