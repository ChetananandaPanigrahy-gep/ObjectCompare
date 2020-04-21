using Gep.Cumulus.CSM.Entities;
using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class SplitAccountingFields : EntityBase
    {
        public SplitAccountingFields()
        {
        }

        public SplitAccountingFields(SplitAccountingFields value)
        {
            foreach (PropertyInfo prop in value.GetType().GetProperties())
                GetType().GetProperty(prop.Name).SetValue(this, prop.GetValue(value, null), null);
        }

        public void set(SplitAccountingFields value)
        {
            if (!ReferenceEquals(value, null))
            {
                this.EntityDetailCode = value.EntityDetailCode;
                this.EntityCode = value.EntityCode;
                this.DisplayName = value.DisplayName;
                this.EntityDisplayName = value.EntityDisplayName;
            }
        }

        [DataMember]
        public int SplitAccountingFieldId { get; set; }

        [DataMember]
        public string FieldName { get; set; }

        [DataMember]
        public FieldControls FieldControls { get; set; }

        [DataMember]
        public int FieldOrder { get; set; }

        [DataMember]
        public int ParentSplitAccountingFieldId { get; set; }

        [DataMember]
        public bool IsMandatory { get; set; }

        [DataMember]
        public int EntityTypeId { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string IsDeleted { get; set; }

        [DataMember]
        public DocumentType DocumentType { get; set; }

        [DataMember]
        public int CodeCombinationOrder { get; set; }

        [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
        public string EntityCode { get; set; }

        [DataMember]
        public long EntityDetailCode { get; set; }

        [DataMember]
        public long ParentEntityDetailCode { get; set; }

        [DataMember]
        public string ParentEntityCode { get; set; }

        [DataMember]
        public LevelType LevelType { get; set; }

        [DataMember]
        public ParentEntityType ParentEntityType { get; set; }

        [DataMember]
        public MappingType MappingType { get; set; }

        [DataMember]
        public bool PopulateDefault { get; set; }

        [DataMember]
        public string ParentEntityDetailCodeString { get; set; }

        [DataMember]
        public FieldControls CatalogItemControlType { get; set; }

        [DataMember]
        public DataDisplayStyle DataDisplayStyle { get; set; }

        [DataMember]
        public int AutoSuggestURLId { get; set; }

        [DataMember]
        public int StructureId { get; set; }

        [DataMember]
        public long LOBEntityDetailCode { get; set; }

        [DataMember]
        public long AEEntityDetailCode { get; set; }

        [DataMember]
        public string EntityDisplayName { get; set; }

        [DataMember]
        public bool IsAccountingEntity { get; set; }

        [DataMember]
        public int ParentFieldConfigId { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public bool EnableShowLookup { get; set; }
    }
}