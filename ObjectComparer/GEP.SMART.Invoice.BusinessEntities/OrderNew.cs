using Gep.Cumulus.CSM.Entities;
using Gep.Cumulus.Partner.Entities;
using GEP.Cumulus.Documents.Entities;
using GEP.Cumulus.QuestionBank.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [KnownType(typeof(IdAndName))]
    [KnownType(typeof(HeaderEntity))]
    [KnownType(typeof(OrderItem))]
    [KnownType(typeof(IdNameAddressAndContact))]
    [KnownType(typeof(IdNameAndAddress))]
    [KnownType(typeof(IdNameAndEmail))]
    [KnownType(typeof(IdAndDate))]
    [KnownType(typeof(ToleranceDetails))]
    [KnownType(typeof(FOBDetails))]
    [KnownType(typeof(IdCodeAndDesc))]
    [KnownType(typeof(CodeAndName))]
    [System.Xml.Serialization.XmlInclude(typeof(IdNameAndAddress))]
    [System.Xml.Serialization.XmlInclude(typeof(IdNameAddressAndContact))]
    [System.Xml.Serialization.XmlInclude(typeof(OrderItem))]
    [System.Xml.Serialization.XmlInclude(typeof(IdAndName))]
    [System.Xml.Serialization.XmlInclude(typeof(HeaderEntity))]
    [System.Xml.Serialization.XmlInclude(typeof(IdNameAndEmail))]
    [System.Xml.Serialization.XmlInclude(typeof(IdAndDate))]
    [System.Xml.Serialization.XmlInclude(typeof(ToleranceDetails))]
    [System.Xml.Serialization.XmlInclude(typeof(FOBDetails))]
    [System.Xml.Serialization.XmlInclude(typeof(IdCodeAndDesc))]
    [System.Xml.Serialization.XmlInclude(typeof(CodeAndName))]
    [DataContract]
    [Serializable]
    public class Order : P2PDocument
    {
        /// <summary>
        /// Order items.
        /// </summary>
        [DataMember]
        public List<OrderItem> items { get; set; }

        [DataMember]
        public IdAndName orderSource { get; set; }

        [DataMember]
        public IdAndName partner { get; set; }

        [DataMember]
        public string clientPartnerCode { get; set; }

        [DataMember]
        public int orderLocationId { get; set; }

        [DataMember]
        public IdAndName paymentTerms { get; set; }

        [DataMember]
        public IdAndName matchType { get; set; }

        [DataMember]
        public IdAndDate submitted { get; set; }

        [DataMember]
        public IdAndDate acknowledged { get; set; }

        [DataMember]
        public long parentDocumentCode { get; set; }

        [DataMember]
        public ToleranceDetails toleranceDetails { get; set; }

        [DataMember]
        public IdAndName invoicingStatus { get; set; }

        [DataMember]
        public IdAndName receivingStatus { get; set; }

        [DataMember]
        public long blanketDocumentCode { get; set; }

        [DataMember]
        public DateTime? blanketStartDate { get; set; }

        [DataMember]
        public DateTime? blanketEndDate { get; set; }

        [DataMember]
        public decimal blanketAmount { get; set; }

        [DataMember]
        public int releaseOrderCount { get; set; }

        [DataMember]
        public IdAndName orderContact { get; set; }

        [DataMember]
        public string revisionNumber { get; set; }

        [DataMember]
        public string blanketDocumentNumber { get; set; }

        [DataMember]
        public decimal consumedAmount { get; set; }

        [DataMember]
        public long partnerStatusCode { get; set; }

        [DataMember]
        public bool isInternalItemExist { get; set; }

        [DataMember]
        public int closingOrderStatus { get; set; }

        [DataMember]
        public IdAndName trasmission { get; set; }

        //[DataMember]
        //public List<RequisitionDetails> lstRequisitionDetails { get; set; }

        [DataMember]
        public IdAndName pOSignatory { get; set; }

        [DataMember]
        public DateTime cancelledDate { get; set; }

        [DataMember]
        public DateTime closedDate { get; set; }

        [DataMember]
        public bool isDisableAccrual { get; set; }

        [DataMember]
        public bool isCloseForReceiving { get; set; }

        [DataMember]
        public bool isCloseForInvoicing { get; set; }

        [DataMember]
        public bool preventAccurals { get; set; }

        [DataMember]
        public string entityDescription { get; set; }

        /// <summary>
        /// Partner contact.
        /// </summary>
        [DataMember]
        public IdNameAndEmail partnerContact { get; set; }

        [DataMember]
        public IdNameAndAddress orderingLocation { get; set; }

        /// <summary>
        /// Dashboard Property
        /// </summary>
        [DataMember]
        public bool isDisableAccFlag { get; set; }

        [DataMember]
        public bool isReOpen { get; set; }

        [DataMember]
        public long locationId { get; set; }

        [DataMember]
        public string clientLocationCode { get; set; }

        [DataMember]
        public decimal materialReceivingTolerance { get; set; }

        [DataMember]
        public decimal serviceReceivingTolerance { get; set; }

        [DataMember]
        public List<long> termsAndConditions { get; set; }

        [DataMember]
        public IdAndName interfaceStatus { get; set; }

        [DataMember]
        public string interfaceComment { get; set; }

        [DataMember]
        public DateTime? interfaceDate { get; set; }

        // required in Interface sync to differentiate between live orders and migrated  order
        [DataMember]
        public bool isMigratedPO { get; set; }

        [DataMember]
        public decimal requisitionTotalAmount { get; set; }

        [DataMember]
        public decimal requisitionItemTotalValue { get; set; }

        [DataMember]
        public decimal parentOrderTotalAmount { get; set; }

        [DataMember]
        public decimal parentOrderItemTotalValue { get; set; }

        [DataMember]
        public decimal orderRequisitionTotalAmountDiff { get; set; }

        [DataMember]
        public decimal orderRequisitionTotalAmountDiffPerc { get; set; }

        [DataMember]
        public decimal orderRequisitionItemTotalAmountDiff { get; set; }

        [DataMember]
        public decimal orderRequisitionItemTotalAmountDiffPerc { get; set; }

        [DataMember]
        public decimal orderPrevOrderTotalAmountDiff { get; set; }

        [DataMember]
        public decimal orderPrevOrderTotalAmountDiffPerc { get; set; }

        [DataMember]
        public decimal orderPrevOrderItemTotalAmountDiff { get; set; }

        [DataMember]
        public decimal orderPrevOrderItemTotalAmountDiffPerc { get; set; }

        [DataMember]
        public bool isPCardSupported { get; set; }

        [DataMember]
        public bool isPCardSupportedForOrder { get; set; }

        [DataMember]
        public int isAllNegativeItems { get; set; }

        [DataMember]
        public int consolidatedFlag { get; set; }

        [DataMember]
        public IdAndName purchaseType { get; set; }

        [DataMember]
        public string itemExtendedTypeIds { get; set; }

        [DataMember]
        public bool isAnyItemInThreeWayMatch { get; set; }

        [DataMember]
        public long partnerReconMatchTypeId { get; set; }

        [DataMember]
        public bool serviceConfirmationRecevingStatus { get; set; }

        [DataMember]
        public decimal totalCharge { get; set; }

        //[DataMember]
        //public List<StandardAndProcedureDetails> lstStandardAndProcedureDetails { get; set; }

        [DataMember]
        public int identificationValue { get; set; }

        [DataMember]
        public string buyerVATNumber { get; set; }

        [DataMember]
        public IdAndName erpOrderType { get; set; }

        [DataMember]
        public string workOrderNumber { get; set; }

        [DataMember]
        public FOBDetails fobDetails { get; set; }

        [DataMember]
        public string TransmissionValue { get; set; }

        [DataMember]
        public List<Question> ListQuestions { get; set; }

        [DataMember]
        public List<QuestionResponse> ListQuestionResponse { get; set; }

        [DataMember]
        public IdNameAndAddress remitToLocation { get; set; }

        [DataMember]
        public string parentDocumentNumber { get; set; }

        [DataMember]
        public IdAndName ParentDocumentStatus { get; set; }

        [DataMember]
        public bool isMaintainRevisionNumber { get; set; }

        [DataMember]
        public bool isInternalChangeOrderFinalize { get; set; }

        [DataMember]
        public List<DocumentStakeHolder> DocumentStakeHolderList { get; set; }

        [DataMember]
        public bool isAllowCreateASN { get; set; }

        [DataMember]
        public IdAndName SourceSystemId { get; set; }

        [DataMember]
        public string PartnerSourceSystemValue { get; set; }

        [DataMember]
        public OrderExtendedStatus OrderExtendedStatus { get; set; }

        [DataMember]
        public TaxIntegrattionType TaxIntegrationType { get; set; }

        [DataMember]
        public string CountryCode { get; set; }

        [DataMember]
        public List<VATValues> VATValues { get; set; } //Cannot use the p2pdocument VAT Property as it is not a List

        [DataMember]
        public string identificationName { get; set; }

        [DataMember]
        public List<TermsAndCondition> termsAndConditionsModelList { get; set; }

        [DataMember]
        public bool isShipToChanged { get; set; }

        [DataMember]
        public List<UserLOBMapping> DocumentLOBDetails { get; set; }

        [DataMember]
        public bool isToleranceEditable { get; set; } = true;

        [DataMember]
        public List<Contact> SupplierContingentWorkersList { get; set; }

        [DataMember]
        public long receiptCreated { get; set; }

        [DataMember]
        public long serviceConfirmationCreated { get; set; }

        [DataMember]
        public long ASNCreated { get; set; }

        [DataMember]
        public CodeAndName ContractNumber { get; set; }

        [DataMember]
        public string ContractExpiryDateFormatted { get; set; }

        [DataMember]
        public List<ErrorValidation> ErrorValidationCodes { get; set; }

        [DataMemberAttribute]
        public int UpdatePOStatusInterfaceSetting { get; set; }

        [DataMember]
        public bool IsInvalidDocumentCode { get; set; }
    }
}