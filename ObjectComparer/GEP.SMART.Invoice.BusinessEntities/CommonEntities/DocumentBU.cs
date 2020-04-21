using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class DocumentBU
    {
        /// <summary>
        /// BUCode.
        /// </summary>
        [DataMember]
        public long buCode { get; set; }

        /// <summary>
        /// DocumentCode.
        /// </summary>
        [DataMember]
        public long documentCode { get; set; }

        [DataMember]
        public string buName { get; set; }
    }
}