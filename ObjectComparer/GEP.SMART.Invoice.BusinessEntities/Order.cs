using Gep.Cumulus.Partner.Entities;
using GEP.Cumulus.Documents.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using QuestionBankEntities = GEP.Cumulus.QuestionBank.Entities;

namespace GEP.SMART.Invoice.BusinessEntities.Old
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(OrderItem))]
    [KnownType(typeof(OrderSource))]
    [KnownType(typeof(QuestionBankEntities.DateTimeQuestion))]
    [KnownType(typeof(DocumentStatus))]
    [System.Xml.Serialization.XmlInclude(typeof(OrderItem))]
    [System.Xml.Serialization.XmlInclude(typeof(OrderSource))]
    [System.Xml.Serialization.XmlInclude(typeof(QuestionBankEntities.DateTimeQuestion))]
    [System.Xml.Serialization.XmlInclude(typeof(DocumentStatus))]
    public class Order : P2PDocument
    {
        public Order()
        {
            ShiptoLocation = new ShiptoLocation();
            BilltoLocation = new BilltoLocation();
            DelivertoLocation = new DelivertoLocation();
        }

        [DataMember]
        public OrderSource OrderSource { get; set; }

        [DataMember]
        public decimal PartnerCode { get; set; }

        [DataMember]
        public string ClientPartnerCode { get; set; }

        [DataMember]
        public int OrderLocationId { get; set; }

        [DataMember]
        public ShiptoLocation ShiptoLocation { get; set; }

        [DataMember]
        public DelivertoLocation DelivertoLocation { get; set; }

        [DataMember]
        public BilltoLocation BilltoLocation { get; set; }

        [DataMember]
        public string PaymentTerms { get; set; }

        [DataMember]
        public MatchType MatchType { get; set; }

        [DataMember]
        public List<OrderItem> OrderItems { get; set; }

        [DataMember]
        public DateTime DateSubmitted { get; set; }

        [DataMember]
        public long SubmittedBy { get; set; }

        [DataMember]
        public DateTime DateAcknowledged { get; set; }

        [DataMember]
        public long AcknowledgedBy { get; set; }

        [DataMember]
        public string PartnerName { get; set; }

        [DataMember]
        public long ParentDocumentCode { get; set; }

        [DataMember]
        public ToleranceDetails ToleranceDetails { get; set; }

        [DataMember]
        public ExtendedStatus InvoicingStatus { get; set; }

        //[DataMember]
        //public DocumentStatus ReceivingStatus { get; set; }

        [DataMember]
        public long BlanketDocumentCode { get; set; }

        [DataMember]
        public DateTime? BlanketStartDate { get; set; }

        [DataMember]
        public DateTime? BlanketEndDate { get; set; }

        [DataMember]
        public decimal BlanketAmount { get; set; }

        [DataMember]
        public int ReleaseOrderCount { get; set; }

        [DataMember]
        public long BusinessUnitId { get; set; }

        [DataMember]
        public string BusinessUnitName { get; set; }

        [DataMember]
        public long OrderContactCode { get; set; }

        [DataMember]
        public string RevisionNumber { get; set; }

        [DataMember]
        public string BlanketDocumentNumber { get; set; }

        [DataMember]
        public decimal ConsumedAmount { get; set; }

        [DataMember]
        public long PartnerStatusCode { get; set; }

        [DataMember]
        public Int32 PaymentTermId { get; set; }

        [DataMember]
        public bool IsInternalItemExist { get; set; }

        [DataMember]
        public int ClosingOrderStatus { get; set; }

        [DataMember]
        public POTransmissionMode TrasmissionMode { get; set; }

        [DataMember]
        public string TransmissionValue { get; set; }

        [DataMember]
        public string OrderContactName { get; set; }

        [DataMember]
        public List<RequisitionDetails> lstRequisitionDetails { get; set; }

        [DataMember]
        public long POSignatoryCode { get; set; }

        [DataMember]
        public string POSignatoryName { get; set; }

        [DataMember]
        public long ProgramId { get; set; }

        [DataMember]
        public DateTime CancelledDate { get; set; }

        [DataMember]
        public DateTime ClosedDate { get; set; }

        [DataMember]
        public bool IsDisableAccrual { get; set; }

        [DataMember]
        public bool IsCloseForReceiving { get; set; }

        [DataMember]
        public bool IsCloseForInvoicing { get; set; }

        [DataMember]
        public bool PreventAccurals { get; set; }

        [DataMember]
        public string EntityDescription { get; set; }

        [DataMember]
        public string DocumentStatusName { get; set; }

        [DataMember]
        public string OrderSourceName { get; set; }

        [DataMember]
        public string InvoicingStatusName { get; set; }

        [DataMember]
        public string ReceivingStatusName { get; set; }

        [DataMember]
        public string MatchTypeName { get; set; }

        [DataMember]
        public string PartnerContactName { get; set; }

        [DataMember]
        public PartnerLocation OrderingLocation { get; set; }

        /// <summary>
        /// Dashboard Property
        /// </summary>
        [DataMember]
        public bool isDisableAccFlag { get; set; }

        [DataMember]
        public bool isReOpen { get; set; }

        [DataMember]
        public long LocationId { get; set; }

        [DataMember]
        public string ClientLocationCode { get; set; }

        [DataMember]
        public decimal MaterialReceivingTolerance { get; set; }

        [DataMember]
        public decimal ServiceReceivingTolerance { get; set; }

        [DataMember]
        public List<long> TermsAndConditions { get; set; }

        // required in Interface sync to differentiate between live orders and migrated  order
        [DataMember]
        public bool IsMigratedPO { get; set; }

        [DataMember]
        public decimal RequisitionTotalAmount { get; set; }

        [DataMember]
        public decimal RequisitionItemTotalValue { get; set; }

        [DataMember]
        public decimal ParentOrderTotalAmount { get; set; }

        [DataMember]
        public decimal ParentOrderItemTotalValue { get; set; }

        [DataMember]
        public decimal OrderRequisitionTotalAmountDiff { get; set; }

        [DataMember]
        public decimal OrderRequisitionTotalAmountDiffPerc { get; set; }

        [DataMember]
        public decimal OrderRequisitionItemTotalAmountDiff { get; set; }

        [DataMember]
        public decimal OrderRequisitionItemTotalAmountDiffPerc { get; set; }

        [DataMember]
        public decimal OrderPrevOrderTotalAmountDiff { get; set; }

        [DataMember]
        public decimal OrderPrevOrderTotalAmountDiffPerc { get; set; }

        [DataMember]
        public decimal OrderPrevOrderItemTotalAmountDiff { get; set; }

        [DataMember]
        public decimal OrderPrevOrderItemTotalAmountDiffPerc { get; set; }

        [DataMember]
        public string PartnerContactEmailAddress { get; set; }

        [DataMember]
        public long PartnerContactCode { get; set; }

        [DataMember]
        public bool IsPCardSupported { get; set; }

        [DataMember]
        public int IsAllNegativeItems { get; set; }

        [DataMember]
        public int ConsolidatedFlag { get; set; }

        [DataMember]
        public bool IsAnyItemInThreeWayMatch { get; set; }

        [DataMember]
        public long PartnerReconMatchTypeId { get; set; }

        [DataMember]
        public bool ServiceConfirmationRecevingStatus { get; set; }

        [DataMember]
        public int PurchaseType { get; set; }

        [DataMember]
        public string ItemExtendedTypeIds { get; set; }

        [DataMember]
        public int IdentificationValue { get; set; }

        [DataMember]
        public List<StandardAndProcedureDetails> lstStandardAndProcedureDetails { get; set; }

        [DataMember]
        public string BuyerVATNumber { get; set; }

        [DataMember]
        public string PurchaseTypeDescription { get; set; }

        [DataMember]
        public List<QuestionBankEntities.QuestionResponse> ListQuestionResponse { get; set; }

        [DataMember]
        public bool IsPCardSupportedForOrder { get; set; }

        [DataMember]
        public bool IsPartnerContactActive { get; set; }

        [DataMember]
        public decimal TotalCharge { get; set; }

        [DataMember]
        public bool IsBusinessUnitChanged { get; set; }

        [DataMember]
        public Int32 ParentOrderPaymentTermId { get; set; }

        [DataMember]
        public string ParentOrderPaymentTerms { get; set; }

        [DataMember]
        public long UpdatedBy { get; set; }

        [DataMember]
        public Decimal OverallTotalAmount { get; set; }

        [DataMember]
        public int OrderSourceSystemId { get; set; }

        [DataMember]
        public decimal ExchangeRate { get; set; }

        [DataMember]
        public List<ItemCharge> ItemChargesForHeader { get; set; }

        [DataMember]
        public PartnerLocation RemitToLocation { get; set; }

        [DataMember]
        public bool isMaintainRevisionNumber { get; set; }

        [DataMember]
        public bool isInternalChangeOrderFinalize { get; set; }

        [DataMember]
        public Int64 ParentDocumentStatus { get; set; }

        [DataMember]
        public long ChangeOrderCreator { get; set; }

        [DataMember]
        public bool? Billable { get; set; }

        [DataMember]
        public string CountryCode { get; set; }

        [DataMember]
        public int HeaderTaxCodeCount { get; set; }

        [DataMember]
        public string TaxCodes { get; set; }

        [DataMember]
        public int LOBEntity { get; set; }

        //Linked location- TWO-7157
        [DataMember]
        public long SourceSystemId { get; set; }

        [DataMember]
        public string PartnerSourceSystemValue { get; set; }

        [DataMember]
        public bool isAllowCreateASN { get; set; }

        [DataMember]
        public string AgreementPayloadID { get; set; }

        [DataMember]
        public TaxIntegrattionType TaxIntegrationType { get; set; }

        [DataMember]
        public bool isShipToChanged { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public decimal PrevOrderOverallTotalAmount { get; set; }

        [DataMember]
        public decimal OrderPrevOrderOverAllLimitTotalAmountDiff { get; set; }

        [DataMember]
        public int PaymentTermNoOfDays { get; set; }

        [DataMember]
        public string ContractNumber { get; set; }

        [DataMember]
        public List<QuestionBankEntities.Question> lstUserQuestionResponse { get; set; }

        [DataMember]
        public decimal CumulativePOLineTotalVsReqTotalDiffPer { get; set; }

        [DataMember]
        public decimal CumulativePOLineValueVsReqValueDiffPer { get; set; }

        [DataMember]
        public decimal CumulativePOLineTotalVsReqLineTotalDiffPer { get; set; }

        [DataMember]
        public decimal CumulativePOLineValueVsReqLineValueDiffPer { get; set; }

        [DataMember]
        public bool NewLineAddedOnOrder { get; set; }

        [DataMember]
        public int FulfillmentDocumentType { get; set; }
    }
}