using GEP.SMART.Invoice.BusinessEntities.Old;
using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class DelivertoLocation
    {
        public DelivertoLocation()
        {
            Address = new P2PAddressOld();
        }

        [DataMember]
        public int DelivertoLocationId { get; set; }

        [DataMember]
        public int ShiptoLocationId { get; set; }

        [DataMember]
        public string DelivertoLocationName { get; set; }

        [DataMember]
        public string DelivertoLocationNumber { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public P2PAddressOld Address { get; set; }

        [DataMember]
        public string DeliverTo { get; set; }

        [DataMember]
        public string TelephoneNumber { get; set; }
    }
}