using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class DocumentLOB
    {
        /// <summary>
        /// Document Code.
        /// </summary>
        [DataMember]
        public long documentCode { get; set; }

        /// <summary>
        /// Entity Detail Code.
        /// </summary>
        [DataMember]
        public long entityDetailCode { get; set; }

        /// <summary>
        /// Entity Id.
        /// </summary>
        [DataMember]
        public long entityId { get; set; }

        /// <summary>
        /// EntityCode
        /// </summary>
        [DataMember]
        public string entityCode { get; set; }

        /// <summary>
        /// EntityDisplayName.
        /// </summary>
        [DataMember]
        public string entityDisplayName { get; set; }

        /// <summary>
        /// PreferenceLOBType
        /// </summary>
        [DataMember]
        public preferenceLOBType preferenceLobType { get; set; }
    }
}