using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities.Old
{
    [DataContract]
    [Serializable]
    public class P2PAddressOld
    {
        [DataMember]
        public long AddressId { get; set; }

        [DataMember]
        public string AddressLine1 { get; set; }

        [DataMember]
        public string AddressLine2 { get; set; }

        [DataMember]
        public string AddressLine3 { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string Zip { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string CountryCode { get; set; }

        [DataMember]
        public string StateCode { get; set; }

        [DataMember]
        public string StateName { get; set; }

        [DataMember]
        public string FaxNo { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }

        [DataMember]
        public string CountryName { get; set; }

        [DataMember]
        public string ISDCountryCode { get; set; }

        [DataMember]
        public string AreaCode { get; set; }

        [DataMember]
        public string County { get; set; }

        [DataMember]
        public string PostCode { get; set; }

        [DataMember]
        public string GeoCode { get; set; }
    }
}