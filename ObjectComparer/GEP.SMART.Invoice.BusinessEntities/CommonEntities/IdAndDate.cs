using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class IdAndDate
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
        public DateTime? date { get; set; }
    }
}