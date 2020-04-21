using Gep.Cumulus.CSM.Entities;
using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class RemittanceDetails
    {
        public long Id { get; set; }
        public string InvoiceNumber { get; set; }
        public long InvoiceId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentReferenceNumber { get; set; }
        public string PaymentRemittanceId { get; set; }
        public string PaymentMethod { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal AdjustmentAmount { get; set; }
        public string Currency { get; set; }
        public string OrderNumber { get; set; }
        public string ClientPartnerCode { get; set; }
        public RemittanceStatus RemittanceStatus { get; set; }
        public bool IsDeleted { get; set; }
        public List<Comments> Comments { get; set; }
        public int PrecessionValue { get; set; }
        public bool IsCreditMemo { get; set; }
        public string SourceSytemName { get; set; }
        public DateTime? SchedulePayDate { get; set; }
    }
}