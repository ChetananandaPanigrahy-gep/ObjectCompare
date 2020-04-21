using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class IdNameAndEmail
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
        /// email.
        /// </summary>
        [DataMember]
        public String email { get; set; }

        /// <summary>
        /// fax.
        /// </summary>
        [DataMember]
        public String fax { get; set; }

        /// <summary>
        /// Adress.
        /// </summary>
        [DataMember]
        public String address { get; set; }

        /// <summary>
        /// Phone.
        /// </summary>
        [DataMember]
        public String phone { get; set; }
    }
}