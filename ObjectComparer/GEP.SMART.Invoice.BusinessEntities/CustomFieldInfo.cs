using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class CustomFieldInfo
    {
        [DataMember]
        public string FieldName { get; set; }

        [DataMember]
        public string FieldValue { get; set; }

        [DataMember]
        public bool IsEditable { get; set; }

        [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
        public string FieldKey { get; set; }

        [DataMember]
        public bool IsVisible { get; set; }

        [DataMember]
        public int FieldOrder { get; set; }

        [DataMember]
        public int Visibility { get; set; }
    }
}