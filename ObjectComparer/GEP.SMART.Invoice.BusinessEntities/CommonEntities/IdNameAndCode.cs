using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class IdNameAndCode
    {
        /// <summary>
        /// Id.
        /// </summary>
        [DataMember]
        public Int64 id { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        [DataMember]
        public String name { get; set; }

        /// <summary>
        /// Code.
        /// </summary>
        [DataMember]
        public String code { get; set; }
    }
}