using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    /// <summary>
    /// Class for keeping comments and attachments.
    /// </summary>
    [KnownType(typeof(IdAndName))]
    [KnownType(typeof(URLandName))]
    [System.Xml.Serialization.XmlInclude(typeof(IdAndName))]
    [System.Xml.Serialization.XmlInclude(typeof(URLandName))]
    [DataContract]
    [Serializable]
    public class Note
    {
        /// <summary>
        /// Id.
        /// </summary>
        [DataMember]
        public Int32 id { get; set; }

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
        /// Access type for note.
        /// </summary>
        [DataMember]
        public IdAndName accessType { get; set; }

        /// <summary>
        /// IsDeleteEnable.
        /// </summary>
        [DataMember]
        public bool IsDeleteEnable { get; set; }

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