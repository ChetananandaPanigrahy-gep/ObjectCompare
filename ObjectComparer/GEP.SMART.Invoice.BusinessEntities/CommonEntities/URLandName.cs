using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    /// <summary>
    /// Class for holding URL and Name.
    /// </summary>
    [DataContract]
    [Serializable]
    public class URLandName
    {
        /// <summary>
        /// URL.
        /// </summary>
        [DataMember]
        public String url { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        [DataMember]
        public String name { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        [DataMember]
        public long fileId { get; set; }
    }
}