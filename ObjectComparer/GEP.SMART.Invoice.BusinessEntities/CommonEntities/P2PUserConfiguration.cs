using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class P2PUserConfiguration
    {
        /// <summary>
        /// User Contact Code.
        /// </summary>
        [DataMember]
        public long ContactCode { get; set; }

        /// <summary>
        /// Document Type.
        /// </summary>
        [DataMember]
        public int DocumentType { get; set; }

        /// <summary>
        /// Config Type.
        /// </summary>
        [DataMember]
        public ConfigType ConfigType { get; set; }

        /// <summary>
        /// User's Configuration Details.
        /// </summary>
        [DataMember]
        public string ConfigDetails { get; set; }
    }
}