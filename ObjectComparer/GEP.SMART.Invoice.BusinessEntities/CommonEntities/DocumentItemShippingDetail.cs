using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(ShiptoLocation))]
    [System.Xml.Serialization.XmlInclude(typeof(ShiptoLocation))]
    public class DocumentItemShippingDetail
    {
        [DataMember]
        public long DocumentItemShippingId { get; set; }

        [DataMember]
        public long DocumentItemId { get; set; }

        [DataMember]
        public string ShippingMethod { get; set; }

        [DataMember]
        public ShiptoLocation ShiptoLocation { get; set; }

        [DataMember]
        public DelivertoLocation DelivertoLocation { get; set; }

        [DataMember]
        public string DeliverTo { get; set; }

        [DataMember]
        public decimal Quantity { get; set; }
    }
}