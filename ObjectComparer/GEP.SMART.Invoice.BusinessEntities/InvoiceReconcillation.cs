using GEP.Cumulus.Documents.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [KnownType(typeof(IRItem))]
    [System.Xml.Serialization.XmlInclude(typeof(IRItem))]
    [DataContract]
    [Serializable]
    public class InvoiceReconciliation : BaseInvoice
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
        public List<RequisitionType> RequisitionType { get; set; }

        [DataMember]
        public string buyerCompanyName { get; set; }

        [DataMember]
        public List<IRItem> items { get; set; }

        [DataMember]
        public List<KeyValuePair<MatchStatus, int>> MatchStatus { get; set; }

        [DataMember]
        public int InvoiceType { get; set; }

        [DataMember]
        public bool IsItemMismatchExceptionAccepted { get; set; }

        [DataMember]
        public List<Dictionary<string, string>> ActiveChangeOrderDetails { get; set; }

        [DataMember]
        public DateTime? InvoiceSubmittedDate { get; set; }

        [DataMember]
        public DateTime? POConsumptionDate { get; set; }
    }

    public class Item
    {
        public int P2PLineItemId { get; set; }
        public int InvoiceItemId { get; set; }
    }
}