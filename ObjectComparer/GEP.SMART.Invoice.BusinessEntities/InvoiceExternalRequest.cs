using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [KnownType(typeof(P2PAddress))]
    [System.Xml.Serialization.XmlInclude(typeof(P2PAddress))]
    [DataContract]
    [Serializable]
    public class InvoiceExternalRequest : Invoice
    {
        [DataMember]
        public P2PAddress VendorAddress { get; set; }

        [DataMember]
        public P2PAddress ShiptoAddress { get; set; }

        [DataMember]
        public bool IsAudited { get { return true; } }

        [DataMember]
        public TaxIntegrattionType TaxIntegrattionType { get; set; }

        [DataMember]
        public long BuyerPartnerCode { get; set; }

        [DataMember]
        public P2PAddress OrderingLocationAddress { get; set; }

        [DataMember]
        public string TaxDeterminationDate { get { return this.createdOn.ToString("yyyy-MM-dd"); } }
    }

    [DataContract]
    [Serializable]
    public class EntityTypeAndAddress
    {
        [DataMember]
        public ExternalRequestSource ExternalRequestSource { get; set; }

        [DataMember]
        public List<EntityAddress> EntityDetails { get; set; }
    }

    public class EntityAddress
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public P2PAddress Address { get; set; }
    }

    public class ComplianceExternalRequest : InvoiceExternalRequest
    {
        [DataMember]
        public InvoiceComplianceStatus ValidationStatus { get; set; }

        [DataMember]
        public InvoiceComplianceStatus SignatureStatus { get; set; }

        [DataMember]
        public InvoiceArchivalStatus ArchivalStatus { get; set; }

        [DataMember]
        public string AttachmentURL { get; set; }

        [DataMember]
        public string AttachmentType { get; set; }

        [DataMember]
        public string SenderInfo { get; set; }

        [DataMember]
        public string ReceiverInfo { get; set; }
    }

    public class TaxExternalRequest : InvoiceExternalRequest
    {
        [DataMember]
        public TaxIntegrattionType TaxIntegrattionType { get; set; }
    }
}