using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class RequisitionType
    {
        [DataMember]
        public int RequisitionTypeId { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public bool IsDefault { get; set; }

        [DataMember]
        public bool IsAllowReceipt { get; set; }
    }

    public class UOM
    {
        [DataMember]
        public string Key { get; set; }

        [DataMember]
        public string Value { get; set; }

        [DataMember]
        public bool AllowDecimal { get; set; }
    }
}