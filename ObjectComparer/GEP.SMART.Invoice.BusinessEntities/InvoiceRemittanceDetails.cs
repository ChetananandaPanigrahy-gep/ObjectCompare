using Gep.Cumulus.CSM.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(RemittanceStatus))]
    [System.Xml.Serialization.XmlInclude(typeof(RemittanceStatus))]
    public class InvoiceRemittanceDetails
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string InvoiceNumber { get; set; }

        [DataMember]
        public long InvoiceId { get; set; }

        [DataMember]
        public DateTime PaymentDate { get; set; }

        [DataMember]
        public string PaymentReferenceNumber { get; set; }

        [DataMember]
        public string PaymentRemittanceId { get; set; }

        [DataMember]
        public string PaymentMethod { get; set; }

        [DataMember]
        public decimal GrossAmount { get; set; }

        [DataMember]
        public decimal NetAmount { get; set; }

        [DataMember]
        public decimal DiscountAmount { get; set; }

        [DataMember]
        public decimal AdjustmentAmount { get; set; }

        [DataMember]
        public string Currency { get; set; }

        [DataMember]
        public string OrderNumber { get; set; }

        [DataMember]
        public string ClientPartnerCode { get; set; }

        [DataMember]
        public RemittanceStatus RemittanceStatus { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public List<Comments> Comments { get; set; }

        [DataMember]
        public int PrecessionValue { get; set; }

        [DataMember]
        public bool IsCreditMemo { get; set; }

        [DataMember]
        public string SourceSytemName { get; set; }

        [DataMember]
        public DateTime? SchedulePayDate { get; set; }

        [DataMember]
        public string FullRemittanceValue { get; set; }

        [DataMember]
        public string RemainingAmount { get; set; }
    }
}