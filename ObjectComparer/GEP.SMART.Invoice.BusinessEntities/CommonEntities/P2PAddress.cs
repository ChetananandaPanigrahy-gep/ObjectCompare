using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class P2PAddress
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
        public string County { get; set; }

        [DataMember]
        public int CountryId { get; set; }

        [DataMember]
        public string CountryAbbrevationCode { get; set; }

        [DataMember]
        public string CountryName { get; set; }

        [DataMember]
        public long StateCode { get; set; }

        [DataMember]
        public string StateAbbrevationCode { get; set; }

        [DataMember]
        public string StateName { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Zip { get; set; }

        [DataMember]
        public string PostCode { set { } get { return Zip != null && Zip.Length > 8 ? this.Zip.Substring(0, 5) : ""; } }

        [DataMember]
        public string GeoCode { set { } get { return Zip != null && Zip.Length > 8 ? this.Zip.Substring(this.Zip.Length - 4, 4) : ""; } }

        [DataMember]
        public string ClientLocationCode { get; set; }
    }
}