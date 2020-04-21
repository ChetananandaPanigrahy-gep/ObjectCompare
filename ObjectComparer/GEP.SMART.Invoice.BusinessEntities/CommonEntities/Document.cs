using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    /// <summary>
    /// Class for representing document across platform.
    /// </summary>
    [KnownType(typeof(IdAndName))]
    [KnownType(typeof(DocumentBU))]
    [KnownType(typeof(DocumentLOB))]
    [System.Xml.Serialization.XmlInclude(typeof(IdAndName))]
    [System.Xml.Serialization.XmlInclude(typeof(DocumentBU))]
    [System.Xml.Serialization.XmlInclude(typeof(DocumentLOB))]
    [DataContract]
    [Serializable]
    public abstract class Document
    {
        /// <summary>
        /// Version.
        /// </summary>
        [DataMember]
        public int version { get; set; }

        /// <summary>
        /// Id.
        /// </summary>
        [DataMember]
        public long id { get; set; }

        /// <summary>
        /// Document Id.
        /// </summary>
        [DataMember]
        public Int64 documentCode { get; set; }

        /// <summary>
        /// Created on.
        /// </summary>
        [DataMember]
        public DateTime createdOn { get; set; }

        /// <summary>
        /// Last updated on.
        /// </summary>
        [DataMember]
        public DateTime? lastModifiedOn { get; set; }

        /// <summary>
        /// Document name.
        /// </summary>
        [DataMember]
        public String name { get; set; }

        /// <summary>
        /// Document Number.
        /// </summary>
        [DataMember]
        public String number { get; set; }

        /// <summary>
        /// Document type.
        /// </summary>

        [DataMember]
        public int documentSourceType { get; set; }

        [DataMember]
        public IdAndName type { get; set; }

        /// <summary>
        /// Document Source.
        /// </summary>
        [DataMember]
        public IdAndName source { get; set; }

        /// <summary>
        /// Document status.
        /// </summary>
        [DataMember]
        public IdAndName status { get; set; }

        /// <summary>
        /// Created by.
        /// </summary>
        [DataMember]
        public IdAndName createdBy { get; set; }

        /// <summary>
        /// Last updated by.
        /// </summary>
        [DataMember]
        public IdAndName lastModifiedBy { get; set; }

        /// <summary>
        /// Document BU.
        /// </summary>
        [DataMember]
        public List<DocumentBU> documentBU { get; set; }

        /// <summary>
        /// Document LOB.
        /// </summary>
        [DataMember]
        public DocumentLOB documentLOB { get; set; }

        /// <summary>
        /// Document StakeHolders
        /// </summary>
        [DataMember]
        public List<GEP.Cumulus.Documents.Entities.DocumentStakeHolder> documentStakeHolderList { get; set; }
    }
}