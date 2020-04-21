using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [KnownType(typeof(InvoiceItem))]
    [System.Xml.Serialization.XmlInclude(typeof(InvoiceItem))]
    [DataContract]
    [Serializable]
    public class Invoice : BaseInvoice
    {
        [DataMember]
        public List<InvoiceItem> items { get; set; }
    }

    [Serializable]
    public class InputDuplicate
    {
        public string PartnerInvoiceNumber { get; set; }
        public string InvoiceAmount { get; set; }
        public string PartnerInvoiceDate { get; set; }
        public string DateReceived { get; set; }
        public string OrderNo { get; set; }
        public string PartnerCode { get; set; }
        public string BpcCode { get; set; }
        public string BUIds { get; set; }
        public string InvoiceId { get; set; }
    }
}