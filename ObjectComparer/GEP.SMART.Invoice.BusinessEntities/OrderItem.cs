using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities.Old
{
    [DataContract]
    [Serializable]
    public class OrderItem : Old.P2PItem
    {
        [DataMember]
        public decimal ReceivedQuantity { get; set; }

        [DataMember]
        public decimal InvoicedQuantity { get; set; }

        [DataMember]
        public int ActiveItemCount { get; set; }

        [DataMember]
        public decimal InvoicedUnitPrice { get; set; }

        [DataMember]
        public DateTime InvoicedStartDate { get; set; }

        //Required for Interface to send or receive  accounting detail as a part of item.
        [DataMember]
        public List<OrderSplitItems> ItemSplitsDetail { get; set; }

        [DataMember]
        public string Requestor { get; set; }

        [DataMember]
        public string RequisitionNumber { get; set; }

        [DataMember]
        public decimal? ParentItemUnitPrice { get; set; }

        [DataMember]
        public DateTime? ParentItemDateNeeded { get; set; }

        [DataMember]
        public int InvoiceCount { get; set; }

        [DataMember]
        public decimal InvoiceTotalQuantity { get; set; }

        [DataMember]
        public decimal InvoiceTotalAmount { get; set; }

        [DataMember]
        public int ReceiptsCount { get; set; }

        [DataMember]
        public decimal ReceiptTotalAcceptedQuantity { get; set; }

        [DataMember]
        public int ReturnNoteCount { get; set; }

        [DataMember]
        public decimal ReturnNoteTotalReturnedQuantity { get; set; }

        [DataMember]
        public ItemHistoryIconType ItemHistoryIconType { get; set; }

        [DataMember]
        public OrderItem ParentOrderItems { get; set; }

        [DataMember]
        public bool IsDisableAccrual { get; set; }

        [DataMember]
        public bool IsCloseForReceiving { get; set; }

        [DataMember]
        public bool IsCloseForInvoicing { get; set; }

        [DataMember]
        public long ProgramId { get; set; }

        [DataMember]
        public bool PreventAccurals { get; set; }

        [DataMember]
        public bool ItemClosed { get; set; }

        [DataMember]
        public string ShipTo { get; set; }

        [DataMember]
        public string DeliverTo { get; set; }

        [DataMember]
        public string DeliverToFreeText { get; set; }

        [DataMember]
        public string ItemTypeName { get; set; }

        [DataMember]
        public bool isClosed { get; set; }

        [DataMember]
        public bool isOpen { get; set; }

        [DataMember]
        public int ClosingOrderStatusForLineItem { get; set; }

        [DataMember]
        public decimal RequisitionItemTotal { get; set; }

        [DataMember]
        public decimal ParentOrderItemTotal { get; set; }

        [DataMember]
        public decimal RequisitionItemValue { get; set; }

        [DataMember]
        public decimal ParentOrderItemValue { get; set; }

        [DataMember]
        public decimal OrderRequisitionItemAmountDiff { get; set; }

        [DataMember]
        public decimal OrderRequisitionItemValueDiff { get; set; }

        [DataMember]
        public decimal OrderPrevOrderItemAmountDiff { get; set; }

        [DataMember]
        public decimal OrderPrevOrderItemvalueDiff { get; set; }

        [DataMember]
        public decimal OrderRequisitionItemAmountDiffPerc { get; set; }

        [DataMember]
        public decimal OrderRequisitionItemValueDiffPerc { get; set; }

        [DataMember]
        public decimal OrderPrevOrderItemAmountDiffPerc { get; set; }

        [DataMember]
        public decimal OrderPrevOrderItemvalueDiffPerc { get; set; }

        //[DataMember]
        //public List<StandardAndProcedureDetails> lstStandardAndProcedureDetails { get; set; }

        [DataMember]
        public long ReqItemLineNumber { get; set; }

        [DataMember]
        public long Evaluator { get; set; }

        [DataMember]
        public string EvaluatorName { get; set; }

        [DataMember]
        public decimal InvoiceTotalTax { get; set; }

        //[DataMember]
        //public List<CreditMemoItem> CreditMemoItems { get; set; }

        [DataMember]
        public decimal TotalCharge { get; set; }

        [DataMember]
        public decimal ReqTotal { get; set; }

        [DataMember]
        public decimal TotalCompletion { get; set; }

        [DataMember]
        public decimal TotalReceivedAmount { get; set; }

        [DataMember]
        public string MiscellaneousCustomResponse { get; set; }

        [DataMember]
        public string CountryCode { get; set; }

        [DataMember]
        public int ShipToLocationId { get; set; }

        [DataMember]
        public int LineTaxCodeCount { get; set; }

        [DataMember]
        public string TaxCodes { get; set; }

        [DataMember]
        public int LineNumber { get; set; }

        [DataMember]
        public bool IsCopy { get; set; }

        [DataMember]
        public long CopyLineItemId { get; set; }

        [DataMember]
        public decimal CreditQuantity { get; set; }

        [DataMember]
        public decimal CreditUnitPrice { get; set; }

        [DataMember]
        public int ComplianceType { get; set; }

        [DataMember]
        public long PriceTypeId { get; set; }

        [DataMember]
        public long JobTitleId { get; set; }

        [DataMember]
        public long ContingentWorkerId { get; set; }

        [DataMember]
        public decimal Margin { get; set; }

        [DataMember]
        public decimal BaseRate { get; set; }

        [DataMember]
        public bool? IsAllowReceipts { get; set; }

        [DataMember]
        public long ReportingManagerId { get; set; }

        [DataMember]
        public string ContingentWorkerName { get; set; }

        [DataMember]
        public string JobTitleName { get; set; }

        [DataMember]
        public long RequisitionItemId { get; set; }
    }
}