using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    /// <summary>
    /// Class to hold location with contact information of master data entities in JSON object for document db.
    /// </summary>
    [DataContract]
    [Serializable]
    public class IdNameAddressAndContact
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
        /// Address.
        /// </summary>
        [DataMember]
        public String address { get; set; }

        /// <summary>
        /// Contact.
        /// </summary>
        [DataMember]
        public String contact { get; set; }

        [DataMember]
        public String nameandnumber { get; set; }
    }
}