using Gep.Cumulus.CSM.Entities;
using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class LocationDetails
    {
        /// <summary>
        /// Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }

        /// <summary>
        /// Address.
        /// </summary>
        //[DataMember]
        //public String Address { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        //[DataMember]
        //public String Nameandnumber { get; set; }

        /// <summary>
        /// AddressINfo.
        /// </summary>
        [DataMember]
        public Address AddressInfo { get; set; }
    }
}