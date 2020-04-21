using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class InvoiceCustomColumns
    {
        [DataMember]
        public int ObjectTypeId { get; set; }

        [DataMember]
        public int ObjectTypeValue { get; set; }

        [DataMember]
        public string ColumnDefinition { get; set; }
    }
}