using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class Contract
    {
        [DataMember]
        public DateTime? ContractExpiryDate { get; set; }

        [DataMember]
        public String ContractNumber { get; set; }

        [DataMember]
        public String ContractName { get; set; }

        [DataMember]
        public Double? ContractValue { get; set; }

        [DataMember]
        public String PaymentTerms { get; set; }

        [DataMember]
        public int ComplianceType { get; set; }
    }
}