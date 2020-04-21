using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class P2P_IR_Doc : EntityBase, IDocument, ICustomAttr
    {
        public long IRId { get; set; }
        public long InvoiceId { get; set; }
        public decimal? ItemTotal { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Shipping { get; set; }
        public decimal? AdditionalCharges { get; set; }
        public decimal? IRAmount { get; set; }
        public string BaseCurrency { get; set; }
        public decimal? ConversionAmount { get; set; }
        public ICollection<P2P_IRItems> P2P_IRItems { get; set; }
        public virtual DM_Documents DM_Documents { get; set; }
        public string InvoiceDocumentNumber { get; set; }
        public string InvoiceDocumentName { get; set; }
        public int? InvoiceDocumentStatus { get; set; }
        public DateTime InvoiceDateCreated { get; set; }
        public string PartnerInvoiceNumber { get; set; }
        public decimal? PartnerCode { get; set; }
        public long? RemittoLocationId { get; set; }
        public int? ShiptoLocationId { get; set; }
        public int? BilltoLocationID { get; set; }
        public DateTime? PartnerInvoiceDate { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public decimal? OrderPartnerCode { get; set; }
        public long? PartnerContactCode { get; set; }
        public DateTime? DateReceived { get; set; }
        public byte? InvoiceSource { get; set; }
        public long? OrderContact { get; set; }
        public int? DelivertoLocationID { get; set; }
        public decimal? InvoiceTotalAmount { get; set; }
        public long? ProgramId { get; set; }
        public int? PaymentTermId { get; set; }
        public string WorkOrderNo { get; set; }
        public string CapitalCode { get; set; }

        public byte? InvoiceType
        {
            get { return (byte)((InvoiceSource == 2) ? 2 : 1); } //2 = Scanned Non PO inv; 1/3 = Scanned/General PO invoice
        }

        public P2P_OrdersLink P2P_Orders { get; set; }
        public ICollection<P2P_InvoiceRemittanceDetails> P2P_InvoiceRemittanceDetails { get; set; }
        public ICollection<P2P_RequisitionLink> P2P_Requisition { get; set; }

        // Referencing Parent Names
        public string PartnerName { get; set; }

        public string OrderContactName { get; set; }
        public string RemittoLcoationName { get; set; }
        public string ShiptoLocationName { get; set; }
        public string BilltoLocationName { get; set; }
        public string PartnerContactName { get; set; }
        public string PaymentTermName { get; set; }
        public string DelivertoLocationName { get; set; }
        public string ProgramName { get; set; }
        public string EntityDescription { get; set; }
        public Dictionary<string, List<dynamic>> CustomAttributes { get; set; }
        public long? SubmittedByCC { get; set; }
        public string ApprovalSubmittedBy { get; set; }
        public DateTime? ApprovalSubmittedOn { get; set; }
        public string PendingApprovers { get; set; }
        public string ERPInvoiceNumber { get; set; }
        public DateTime? ScheduledPaymentDate { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public string ExceptionType { get; set; }
        public string ClientPartnercode { get; set; }
        public List<int> InvoiceExceptionCodes { get; set; }
        public string PurchaseTypeName { get; set; }
        public byte? PurchaseType { get; set; }

        //used for indexing
        public Dictionary<string, object> metadata { get; set; }
    }
}