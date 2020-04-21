using Gep.Cumulus.CSM.Entities;
using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities.Old
{
    [DataContract]
    [Serializable]
    public class P2PItemCheckedStatus : EntityBase
    {
        [DataMember]
        public long DocumentItemId { get; set; }

        [DataMember]
        public bool IsChecked { get; set; }

        [DataMember]
        public ItemType ItemType { get; set; }

        [DataMember]
        public decimal Quantity { get; set; }

        [DataMember]
        public long ItemLineNumber { get; set; }
    }
}