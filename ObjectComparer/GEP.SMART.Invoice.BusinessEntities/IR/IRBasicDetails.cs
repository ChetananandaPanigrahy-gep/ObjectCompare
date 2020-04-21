using GEP.Cumulus.Documents.Entities;
using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.IR
{
    public class IRBasicDetails
    {
        public long InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public long IRId { get; set; }
        public string InvoiceReconciliationName { get; set; }
        public string InvoiceReconciliationNumber { get; set; }
        public string PartnerInvoiceNumber { get; set; }
        public string BuyerCompanyName { get; set; }
        public string ERPInvoiceNumber { get; set; }
        public DateTime? PartnerInvoiceDate { get; set; }
        public DateTime? ScheduledPaymentDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public KeyValuePair<long, string> CreatedBy { get; set; }
        public KeyValuePair<string, string> Currency { get; set; }
        public KeyValuePair<long, string> Source { get; set; }
        public KeyValuePair<long, string> Status { get; set; }
        public KeyValuePair<long, string> Type { get; set; }
        public KeyValuePair<long, string> InvoiceStatus { get; set; }
        public KeyValuePair<long, string> PurchaseType { get; set; }
        public OrderInfo OrderInfo { get; set; }
        public List<Cumulus.Documents.Entities.DocumentBU> DocumentBU { get; set; }
        public DocumentLOBDetails DocumentLOB { get; set; }
        public List<DocumentStakeHolder> DocumentStakeHolderList { get; set; }
        public int InvoiceType { get; set; }
        public int IsMultiDocInvoice { get; set; }
        public int FulfilmentDocumentType { get; set; }
        public string FulfilmentDocumentNumber { get; set; }
        public long ImageId { get; set; }
        public DocumentStatus InvDocumentStatusInfo { get; set; }
        public OnEvent OnEvent { get; set; }
        public List<SplitAccountingFields> HeaderEntities { get; set; }
        public KeyValuePair<WorkFlowDocType, string> IRApprovalSubType { get; set; }
        public KeyValuePair<int, string> IRStatusForUser { get; set; }
        public bool IsApprovalPendingForUser { get; set; }
        public bool IsIRCreator { get; set; }
        public List<KeyValuePair<MatchStatus, int>> MatchStatus { get; set; }
        public decimal InvoiceTotalAmount { get; set; }
        public string WorkOrderNumber { get; set; }
        public short ERPOrderType { get; set; }
        public int IRTypeId { get; set; }
        public bool Billable { get; set; }
        public DateTime? POConsumptionDate { get; set; }
        public DateTime? InvoiceSubmittedDate { get; set; }
    }
}