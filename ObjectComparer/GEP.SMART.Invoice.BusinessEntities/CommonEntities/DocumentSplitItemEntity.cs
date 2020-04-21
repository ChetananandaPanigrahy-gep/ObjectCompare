using Gep.Cumulus.CSM.Entities;
using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class DocumentSplitItemEntity : EntityBase
    {
        [DataMember]
        public long DocumentSplitItemEntityId { get; set; }

        [DataMember]
        public long DocumentSplitItemId { get; set; }

        [DataMember]
        public int SplitAccountingFieldId { get; set; }

        [DataMember]
        public string SplitAccountingFieldValue { get; set; }

        [DataMember]
        public string EntityDisplayName { get; set; }

        [DataMember]
        public int EntityTypeId { get; set; }

        [DataMember]
        public string EntityCode { get; set; }

        [DataMember]
        public int CodeCombinationOrder { get; set; }

        [DataMember]
        public int UiId { get; set; }

        [DataMember]
        public long ParentEntityDetailCode { get; set; }

        [DataMember]
        public string EntityType { get; set; }

        [DataMember]
        public string ParentEntityDetailCodeString { get; set; }

        [DataMember]
        public bool IsMandatory { get; set; }

        [DataMember]
        public bool IsAccountingEntity { get; set; }

        [DataMember]
        public int StructureId { get; set; }

        [DataMember]
        public string EntityCodeId { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string FieldName { get; set; }
    }
}