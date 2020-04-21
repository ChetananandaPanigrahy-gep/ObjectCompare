using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class DocumentAdditionalEntityInfo
    {
        [DataMember]
        public int EntityId { get; set; }

        [DataMember]
        public long EntityDetailCode { get; set; }

        [DataMember]
        public string EntityDisplayName { get; set; }

        [DataMember]
        public string EntityCode { get; set; }

        [DataMember]
        public long ParentEntityDetailCode { get; set; }

        [DataMember]
        public int Level { get; set; }

        [DataMember]
        public int ParentEntityId { get; set; }

        [DataMember]
        public bool IsAccountingEntity { get; set; }

        [DataMember]
        public long LOBEntityDetailCode { set; get; }

        [DataMember]
        public string EntityType { get; set; }

        [DataMember]
        public int FieldOrder { get; set; }
    }
}