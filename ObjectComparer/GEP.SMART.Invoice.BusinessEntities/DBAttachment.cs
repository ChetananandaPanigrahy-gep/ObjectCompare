using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    /// <summary>
    /// Class for holding Attachments from DB.
    /// </summary>
    [DataContract]
    [Serializable]
    public class DBAttachment
    {
        /// <summary>
        /// Comment Id.
        /// </summary>
        [DataMember]
        public Int32 commentId { get; set; }

        /// <summary>
        /// File URL.
        /// </summary>
        [DataMember]
        public String FileURL { get; set; }

        /// <summary>
        /// File Name.
        /// </summary>
        [DataMember]
        public String FileName { get; set; }

        /// <summary>
        /// fileId
        /// </summary>
        [DataMember]
        public long fileId { get; set; }
    }
}