using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    /// <summary>
    /// Class for header level entities.
    /// </summary>
    [DataContract]
    [Serializable]
    public class HeaderEntity
    {
        /// <summary>
        /// Entity type
        /// </summary>
        [DataMember]
        public Int32 entityType { get; set; }

        /// <summary>
        /// Id.
        /// </summary>
        [DataMember]
        public Int64? id { get; set; }

        /// <summary>
        /// Header entity id.
        /// </summary>
        [DataMember]
        public Int64 headerEntityId { get; set; }

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