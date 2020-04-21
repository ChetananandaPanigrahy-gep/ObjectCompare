using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class P2P_Invoices : EntityBase, IDocument, ICustomAttr
    {
        public P2P_Invoices()
        {
            P2P_InvoiceItems = new HashSet<P2P_InvoiceItems>();
            FulfilmentDocumentNumber = new List<string>();
        }

        public long InvoiceId { get; set; }
        public string PartnerInvoiceNumber { get; set; }
        public Nullable<decimal> PartnerCode { get; set; }
        public Nullable<long> RemittoLocationId { get; set; }
        public Nullable<int> ShiptoLocationId { get; set; }
        public Nullable<int> BilltoLocationID { get; set; }

        //public string PaymentTerms { get; set; }
        //public string CurrencyCode { get; set; }
        public Nullable<System.DateTime> PartnerInvoiceDate { get; set; }

        //public decimal ItemTotal { get; set; }
        //public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> OrderPartnerCode { get; set; }

        //public decimal UseTax { get; set; }
        //public Nullable<decimal> Shipping { get; set; }
        //public Nullable<decimal> AdditionalCharges { get; set; }
        public Nullable<decimal> InvoiceAmount { get; set; }

        //public bool IsDeleted { get; set; }
        public Nullable<long> PartnerContactCode { get; set; }

        //public int MatchStatus { get; set; }
        public Nullable<System.DateTime> DateReceived { get; set; }

        public Nullable<int> ExtendedStatus { get; set; }
        public Nullable<byte> InterfaceStatus { get; set; }
        public Nullable<byte> InvoiceSource { get; set; }

        //public byte InvoiceOrigin { get; set; }
        public Nullable<long> OrderContact { get; set; }

        public Nullable<int> DelivertoLocationID { get; set; }
        public Nullable<decimal> InvoiceTotalAmount { get; set; }
        public Nullable<long> ProgramId { get; set; }

        //public Nullable<int> BudgetId { get; set; }
        //public Nullable<System.DateTime> InvoiceDate { get; set; }
        //public string OrderNo { get; set; }
        //public string PartnerContact { get; set; }
        //public string PaymentTerms { get; set; }
        //public Nullable<decimal> TotalValue { get; set; }
        //public string TotalValueCurrencyCode { get; set; }
        public Nullable<int> PaymentTermId { get; set; }

        public string WorkOrderNo { get; set; }
        public string CapitalCode { get; set; }
        //public Nullable<int> ERPOrderType { get; set; }
        //public Nullable<System.DateTime> InvoicePaidDate { get; set; }
        //public int InvoiceCreatedFrom { get; set; }

        public DM_Documents DM_Documents { get; set; }
        public ICollection<P2P_InvoiceItems> P2P_InvoiceItems { get; set; }
        public P2P_OrdersLink P2P_Orders { get; set; }
        public P2P_IR_DocLink P2P_IR_Doc { get; set; }
        public ICollection<P2P_InvoiceRemittanceDetails> P2P_InvoiceRemittanceDetails { get; set; }
        public ICollection<P2P_RequisitionLink> P2P_Requisition { get; set; }

        //Error codes for invoice
        public List<int> InvoiceErrorCodes { get; set; }

        //Exception Type for invoice
        public List<int> InvoiceExceptionCodes { get; set; }

        // Referencing Parent Names
        public string PartnerName { get; set; }

        public string OrderContactName { get; set; }
        public string RemittoLcoationName { get; set; }
        public string ShiptoLocationName { get; set; }
        public string BilltoLocationName { get; set; }
        public string PartnerContactName { get; set; }
        public string PaymentTermName { get; set; }
        public string DelivertoLocationName { get; set; }

        //public string DeliverTo { get; set; }
        public string ProgramName { get; set; }

        //public string BudgetDesc { get; set; }
        public string EntityDescription { get; set; }

        public Nullable<int> SourceSystemId { get; set; }
        public Nullable<long> SubmittedByCC { get; set; }
        public string ApprovalSubmittedBy { get; set; }
        public Nullable<DateTime> ApprovalSubmittedOn { get; set; }
        public string PendingApprovers { get; set; }
        public Nullable<bool> Billable { get; set; }

        // Getter Properties
        public Nullable<byte> InvoiceType
        {
            get { return (byte)((InvoiceSource == 2) ? 2 : 1); } //2 = Scanned Non PO inv; 1/3 = Scanned/General PO invoice
        }

        public Dictionary<string, List<dynamic>> CustomAttributes { get; set; }
        public DateTime? InterfaceTimeStamp { get; set; }
        public string FailureComment { get; set; }
        public string ERPInvoiceNumber { get; set; }
        public DateTime? ScheduledPaymentDate { get; set; }
        public string PurchaseTypeName { get; set; }
        public Nullable<byte> PurchaseType { get; set; }
        public bool IsERS { get; set; }
        public string DeliveryNoteNumber { get; set; }
        public List<string> FulfilmentDocumentNumber { get; set; }

        //used for indexing
        public Dictionary<string, object> metadata { get; set; }
    }
}