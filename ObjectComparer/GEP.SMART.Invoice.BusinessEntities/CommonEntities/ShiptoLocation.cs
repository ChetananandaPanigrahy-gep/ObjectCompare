using GEP.SMART.Invoice.BusinessEntities.Old;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class ShiptoLocation
    {
        public ShiptoLocation()
        {
            Address = new P2PAddressOld();
        }

        [DataMember]
        public int ShiptoLocationId { get; set; }

        [DataMember]
        public string ShiptoLocationName { get; set; }

        [DataMember]
        public string ShiptoLocationNumber { get; set; }

        [DataMember]
        public P2PAddressOld Address { get; set; }

        [DataMember]
        public Boolean IsAdhoc { get; set; }

        [DataMember]
        public Boolean AllowForFutureReference { get; set; }

        [DataMember]
        public string ContactPerson { get; set; }

        [DataMember]
        public string TelephoneNumber { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public string MappingEntity { get; set; }

        [DataMember]
        public string LOBEntityCode { get; set; }

        [DataMember]
        public List<BZOrgEntity> lstOrgEntity { get; set; }

        [DataMember]
        public bool IsDefault { get; set; }

        [DataMember]
        public List<GEP.SMART.Invoice.BusinessEntities.Old.RegistrationDetails> lstShipLocation { get; set; }
    }
}