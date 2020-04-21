using Gep.Cumulus.CSM.Entities;
using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class P2PContact
    {
        [DataMember]
        public Address Address { get; set; }

        [DataMember]
        public string ClientContactCode { get; set; }

        [DataMember]
        public long ContactCode { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember(Name = "UserType")]
        public P2PUserType UserType { get; set; }
    }

    [DataContract]
    [Serializable]
    public enum P2PUserType
    {
        [EnumMember(Value = "Buyer")]
        Buyer = 0,

        [EnumMember(Value = "Supplier")]
        Supplier = 1,

        [EnumMember(Value = "Both")]
        Both = 2,
    }
}