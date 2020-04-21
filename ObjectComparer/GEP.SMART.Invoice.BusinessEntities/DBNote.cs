using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    /// <summary>
    /// Class for holding Notes from DB.
    /// </summary>
    [KnownType(typeof(IdAndName))]
    [KnownType(typeof(URLandName))]
    [System.Xml.Serialization.XmlInclude(typeof(IdAndName))]
    [System.Xml.Serialization.XmlInclude(typeof(URLandName))]
    [DataContract]
    [Serializable]
    public class DBNote
    {
        /// <summary>
        /// Id.
        /// </summary>
        [DataMember]
        public Int32 id { get; set; }

        /// <summary>
        /// Access type for note.
        /// </summary>
        [DataMember]
        public Int32 accessType { get; set; }

        /// <summary>
        /// Object id.
        /// </summary>
        [DataMember]
        public Int64 objectId { get; set; }

        /// <summary>
        /// Date created.
        /// </summary>
        [DataMember]
        public DateTime? createdOn { get; set; }

        /// <summary>
        /// Comment.
        /// </summary>
        [DataMember]
        public String text { get; set; }

        /// <summary>
        /// Object type.
        /// </summary>
        [DataMember]
        public String objectType { get; set; }

        /// <summary>
        /// List of attachments.
        /// </summary>
        [DataMember]
        public List<URLandName> attachmentURLs { get; set; }

        /// <summary>
        /// Created by user.
        /// </summary>
        [DataMember]
        public IdAndName createdBy { get; set; }

        /// <summary>
        /// DocumentNumber.
        /// </summary>
        [DataMember]
        public String DocumentNumber { get; set; }

        /// <summary>
        /// DocumentType.
        /// </summary>
        [DataMember]
        public Int32 DocumentType { get; set; }
    }
}