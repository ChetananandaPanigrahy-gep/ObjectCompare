using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class IdCodeAndDesc
    {
        /// <summary>
        /// Id.
        /// </summary>
        [DataMember]
        public Int32 id { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        [DataMember]
        public string code { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        [DataMember]
        public string desc { get; set; }
    }
}