using Gep.Cumulus.Partner.Entities;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    public class BZInvoice
    {
        [DataMember]
        public Old.Invoice Invoice { get; set; }

        [DataMember]
        public PartnerLocation RemitToLocation { get; set; }

        [DataMember]
        public List<string> Attachments { get; set; }

        [DataMember]
        public P2PContact SupplierContact { get; set; }

        [DataMember]
        public P2PContact BuyerContact { get; set; }

        [DataMember]
        public string ClientPartnerCode { get; set; }

        [DataMember]
        public string OrderRevisionNumber { get; set; }

        [DataMember]
        public string CompanyCode { get; set; }

        [DataMember]
        public string BusinessUnitCode { get; set; }

        [DataMember]
        public bool IsBackInvoice { get; set; }

        [DataMember]
        public long IRDocumentCode { get; set; }

        [DataMember]
        public bool IsLineLevelUpdate { get; set; }

        [DataMember]
        public string PaymentType { get; set; }
    }
}