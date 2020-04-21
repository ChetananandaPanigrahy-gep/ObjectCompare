using Gep.Cumulus.Partner.Entities;
using GEP.Cumulus.QuestionBank.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    /// <summary>
    /// Class for base requisition item.
    /// </summary>
    [KnownType(typeof(OrderAccountingSplit))]
    [KnownType(typeof(IdAndName))]
    [KnownType(typeof(IdNameAndAddress))]
    [System.Xml.Serialization.XmlInclude(typeof(IdNameAndAddress))]
    [System.Xml.Serialization.XmlInclude(typeof(IdAndName))]
    [System.Xml.Serialization.XmlInclude(typeof(OrderAccountingSplit))]
    [DataContract]
    [Serializable]
    public class OrderItem : P2PDocumentItem
    {
        public ExtendedStatus InvoicingStatus;

        [DataMember]
        public bool? inventoryType;

        [DataMember]
        public List<OrderAccountingSplit> splits { get; set; }

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
        public decimal CreditMemoAmount { get; set; }

        [DataMember]
        public int ItemExtendedType { get; set; }

        [DataMember]
        public decimal CreditMemoQuantity { get; set; }

        [DataMember]
        public decimal InvoiceQuantity { get; set; }

        [DataMember]
        public decimal InvoiceTotalQuantity { get; set; }

        [DataMember]
        public decimal InvoiceAmount { get; set; }

        [DataMember]
        public decimal InvoiceTotalTax { get; set; }

        [DataMember]
        public decimal InvoiceTotalAmount { get; set; }

        [DataMember]
        public int ReceiptsCount { get; set; }

        [DataMember]
        public int ReturnNoteCount { get; set; }

        [DataMember]
        public decimal ReturnNoteTotalReturnedQuantity { get; set; }

        [DataMember]
        public decimal ReceiptTotalAcceptedQuantity { get; set; }

        [DataMember]
        public decimal ReceiptAcceptedQuantity { get; set; }

        [DataMember]
        public decimal ReceiptTotalReceivedAmount { get; set; }

        //[DataMember]
        //public ItemHistoryIconType ItemHistoryIconType { get; set; }

        [DataMember]
        public OrderItem ParentOrderItems { get; set; }

        [DataMember]
        public bool IsDisableAccrual { get; set; }

        [DataMember]
        public bool IsCloseForReceiving { get; set; }

        [DataMember]
        public bool IsCloseForInvoicing { get; set; }

        [DataMember]
        public bool PreventAccurals { get; set; }

        [DataMember]
        public bool ItemClosed { get; set; }

        [DataMember]
        public string ShipTo { get; set; }

        [DataMember]
        public string DeliverTo { get; set; }

        [DataMember]
        public string ItemTypeName { get; set; }

        [DataMember]
        public bool isClosed { get; set; }

        [DataMember]
        public bool isOpen { get; set; }

        [DataMember]
        public long ProgramId { get; set; }

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
        //public List<CreditMemoItem> CreditMemoItems { get; set; }

        [DataMember]
        public decimal TotalCharge { get; set; }

        //[DataMember]
        //public List<StandardAndProcedureDetails> lstStandardAndProcedureDetails { get; set; }

        [DataMember]
        public long ReqItemLineNumber { get; set; }

        [DataMember]
        public IdAndName Evaluator { get; set; }

        [DataMember]
        public DateTime? needByDate { get; set; }

        /// <summary>
        /// Deliver to name/address.
        /// </summary>
        [DataMember]
        public String deliverToStr { get; set; }

        /// <summary>
        /// Shipping method.
        /// </summary>
        [DataMember]
        public CodeAndName shippingMethod { get; set; }

        /// <summary>
        /// Matching.
        /// </summary>
        [DataMember]
        public IdAndName matching { get; set; }

        /// <summary>
        /// Ship to location.
        /// </summary>
        [DataMember]
        public IdNameAndAddress shipTo { get; set; }

        /// <summary>
        /// Deliver to name/address.
        /// </summary>
        [DataMember]
        public IdNameAndAddress deliverTo { get; set; }

        [DataMember]
        public decimal ItemReceivingTolerance { get; set; }

        [DataMember]
        public DateTime? requestedDate { get; set; }

        [DataMember]
        public IdAndName ItemStatus { get; set; }

        [DataMember]
        public Contract Contract { get; set; }

        [DataMember]
        public List<Question> ListQuestions { get; set; }

        [DataMember]
        public decimal TaxRate { get; set; }

        [DataMember]
        public string TaxErrorMessage { get; set; }

        [DataMember]
        public bool AllowDecimal { get; set; }

        [DataMember]
        public long PriceTypeId { get; set; }

        [DataMember]
        public IdAndName PriceType { get; set; }

        [DataMember]
        public long JobTitleId { get; set; }

        [DataMember]
        public IdAndName JobTitle { get; set; }

        [DataMember]
        public long ContingentWorkerId { get; set; }

        [DataMember]
        public Contact ContingentWorker { get; set; }

        [DataMember]
        public decimal Margin { get; set; }

        [DataMember]
        public decimal BaseRate { get; set; }

        [DataMember]
        public IdAndName IsAllowReceipts { get; set; }

        [DataMember]
        public long ReportingManagerId { get; set; }

        [DataMember]
        public Contact ReportingManager { get; set; }

        [DataMember]
        public Int64 lineReferenceNumber { get; set; }

        [DataMember]
        public bool IsParentOrderItem { get; set; }

        [DataMember]
        public long RequisitionItemId { get; set; }

        #region TaxIntegration

        [DataMember]
        public P2PAddress shipToAddress { get; set; }

        [DataMember]
        public P2PAddress ShipFromLocationAddress { get; set; }

        [DataMember]
        public decimal ExternalTax { get; set; }

        [DataMember]
        public List<GEP.SMART.Invoice.BusinessEntities.ExternalTaxesOld> ExternalTaxes { get; set; }

        #endregion TaxIntegration

        [DataMember]
        public override double? LineItemAmount
        {
            get
            {
                return (this.quantity * this.unitPrice == null ? 0 : this.quantity * this.unitPrice) + (this.shippingCharges == null ? 0 : this.shippingCharges)
                    + (this.otherCharges == null ? 0 : this.otherCharges);
            }
            set { }
        }
    }
}