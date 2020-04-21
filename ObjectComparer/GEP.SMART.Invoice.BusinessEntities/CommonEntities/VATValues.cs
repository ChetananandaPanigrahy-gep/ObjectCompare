using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class VATValues
    {
        [DataMember]
        public long LOBEntityDetailCodeIdentificationId { get; set; }

        [DataMember]
        public string IdentificationValue { get; set; }

        [DataMember]
        public string FieldDisplayValue { get; set; }

        [DataMember]
        public bool IsBuyerLocation { get; set; }

        [DataMember]
        public string SupplierIdentificationValue { get; set; }
    }
}