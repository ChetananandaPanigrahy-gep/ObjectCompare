using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    /// <summary>
    /// Class for holding split entities.
    /// </summary>
    [DataContract]
    [Serializable]
    public class SplitEntity
    {
        /// <summary>
        /// Entity type
        /// </summary>
        [DataMember]
        public Int32 entityType { get; set; }

        /// <summary>
        /// Accounting field configuration id.
        /// </summary>
        [DataMember]
        public Int64 fieldId { get; set; }

        /// <summary>
        /// Split entity id.
        /// </summary>
        [DataMember]
        public Int64 splitEntityId { get; set; }

        /// <summary>
        /// Id.
        /// </summary>
        [DataMember]
        public String code { get; set; }

        /// <summary>
        /// Entity code.
        /// </summary>
        [DataMember]
        public String entityCode { get; set; }

        /// <summary>
        /// Entity name.
        /// </summary>
        [DataMember]
        public String name { get; set; }

        [DataMember]
        public String title { get; set; }

        [DataMember]
        public Int64 FieldControlType { get; set; }

        [DataMember]
        public String FieldName { get; set; }

        /// <summary>
        /// Entity DisplayStyle.
        /// </summary>
        [DataMember]
        public int DataDisplayStyle { get; set; }

        /// <summary>
        /// Entity Address.
        /// </summary>
        [DataMember]
        public P2PAddress Address { get; set; }
    }
}