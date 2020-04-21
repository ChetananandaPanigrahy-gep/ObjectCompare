using GEP.Cumulus.Documents.Entities;
using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities.Old
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(MatchStatus))]
    [System.Xml.Serialization.XmlInclude(typeof(MatchStatus))]
    public class InvoiceReconciliation : Invoice
    {
        [DataMember]
        public long InvoiceId { get; set; }

        [DataMember]
        public string InvoiceNumber { get; set; }

        [DataMember]
        public DocumentStatus InvDocumentStatusInfo { get; set; }

        [DataMember]
        public int IRTypeId { get; set; }

        [DataMember]
        public decimal CumulativeTotalAmount { get; set; }

        [DataMember]
        public decimal OverInvoicingAmount { get; set; }

        [DataMember]
        public bool IsItemMismatchExceptionAccepted { get; set; }

        [DataMember]
        public bool IsBUChanged { get; set; }

        [DataMember]
        public DateTime? InvoiceSubmittedDate { get; set; }

        [DataMember]
        public DateTime? POConsumptionDate { get; set; }
    }

    [DataContract]
    [Serializable]
    public class IRDetail
    {
        [DataMember]
        public long IRId { get; set; }

        [DataMember]
        public bool AutoAcknowledgedByPartner { get; set; }
    }
}