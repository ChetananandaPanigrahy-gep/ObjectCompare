using Gep.Cumulus.CSM.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using QuestionBankEntities = GEP.Cumulus.QuestionBank.Entities;

namespace GEP.SMART.Invoice.BusinessEntities.Old
{
    [DataContract]
    [Serializable]
    //[KnownType(typeof(Requisition))]
    //[KnownType(typeof(Order))]
    //[KnownType(typeof(Invoice))]
    //[KnownType(typeof(Receipt))]
    [KnownType(typeof(Taxes))]
    [KnownType(typeof(QuestionBankEntities.Question))]
    //[KnownType(typeof(ASN))]
    //[System.Xml.Serialization.XmlInclude(typeof(Requisition))]
    //[System.Xml.Serialization.XmlInclude(typeof(Order))]
    //[System.Xml.Serialization.XmlInclude(typeof(Invoice))]
    //[System.Xml.Serialization.XmlInclude(typeof(Receipt))]
    //[System.Xml.Serialization.XmlInclude(typeof(ASN))]
    [System.Xml.Serialization.XmlInclude(typeof(Taxes))]
    [System.Xml.Serialization.XmlInclude(typeof(P2PDocumentValidationInfo))]
    [System.Xml.Serialization.XmlInclude(typeof(QuestionBankEntities.Question))]
    public abstract class P2PDocument : GEP.Cumulus.Documents.Entities.Document
    {
        #region Properties

        [DataMember]
        public long DocumentId { get; set; }

        //[DataMember]
        //[NotNullValidator]
        //[RegexValidator("^[a-zA-Z0-9]+$")]
        //[StringLengthValidator(1, 50, Ruleset = "Group1",
        //    MessageTemplate = "DocumentName is mandatory and should not exceed 50 characters.")]
        //public string DocumentName { get; set; }

        //[DataMember]
        //public string DocumentNumber { get; set; }
        [DataMember]
        public string Currency { get; set; }

        [DataMember]
        public decimal? ItemTotalAmount { get; set; }

        [DataMember]
        public decimal? Tax { get; set; }

        [DataMember]
        public decimal? OrderTax { get; set; }

        [DataMember]
        public decimal? InvoiceOrderTaxDifference { get; set; }

        [DataMember]
        public decimal? TaxexemptionInvoiceTotal { get; set; }

        [DataMember]
        public decimal? Shipping { get; set; }

        [DataMember]
        public decimal? AdditionalCharges { get; set; }

        [DataMember]
        public decimal? TotalAmount { get; set; }

        [DataMember]
        public decimal? AdvanceTotalAmount { get; set; }

        [DataMember]
        public decimal? RecoupmentPercentage { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public string ApproveURL { get; set; }

        [DataMember]
        public string RejectURL { get; set; }

        [DataMember]
        public string CreatedByName { get; set; }

        [DataMember]
        public P2PDocumentType DocumentType { get; set; }

        [DataMember]
        public string ApproverName { get; set; }

        [DataMember]
        public string QueryString { get; set; }

        [DataMember]
        public string ClientContactCode { get; set; }

        [DataMember]
        public long PreDocumentCode { get; set; }

        [DataMember]
        public InterfaceStatus InterfaceStatus { get; set; }

        [DataMember]
        public List<Taxes> TaxesAndCharges { get; set; }

        [DataMember]
        public int MaterialItemCount { get; set; }

        [DataMember]
        public int ServiceItemCount { get; set; }

        [DataMember]
        public int AdvanceItemCount { get; set; }

        [DataMember]
        public int ChargeItemCount { get; set; }

        [DataMember]
        public bool IsCatalogItemsExists { get; set; }

        [DataMember]
        public short Precision { get; set; }

        [DataMember]
        public List<Comments> Comments { get; set; }

        [DataMember]
        public List<P2PDocumentValidationInfo> ValidationInfo { get; set; }

        [DataMember]
        public string WorkOrderNumber { get; set; }

        [DataMember]
        public int ERPOrderType { get; set; }

        [DataMember]
        public string BudgetDescription { get; set; }

        [DataMember]
        public PaymentTermDetails PaymentTermsDetails { get; set; }

        [DataMember]
        public int CommentCount { get; set; }

        [DataMember]
        public bool IsUrgent { get; set; }

        [DataMember]
        public string CapitalCode { get; set; }

        [DataMember]
        public DateTime SentForApprovalDate { get; set; }

        [DataMember]
        public DateTime ApprovedRejectedDate { get; set; }

        [DataMember]
        public long NextLineNumber { get; set; }

        [DataMember]
        public string Operation { get; set; }

        [DataMember]
        public int BudgetId { get; set; }

        [DataMember]
        public string ERPOrderTypeName { get; set; }

        [DataMember]
        public List<EntitySumCalculation> EntitySumList { get; set; }

        [DataMember]
        public int DocumentSourceSystemId { get; set; }

        [DataMember]
        public string ERPProcessStatus { get; set; }

        [DataMember]
        public bool IsPunchoutItemExists { get; set; }

        [DataMember]
        public long CustomAttrFormId { get; set; }

        [DataMember]
        public long CustomAttrFormIdForItem { get; set; }

        [DataMember]
        public long CustomAttrFormIdForSplit { get; set; }

        [DataMember]
        public DateTime DateCreated { get; set; }

        [DataMember]
        public string SecondLevelAcknowledgement { get; set; }

        [DataMember]
        public bool isAdvanced { get; set; }

        [DataMember]
        public VATValues VAT { get; set; }

        [DataMember]
        public List<Questionnaire> CustomAttributes { get; set; }

        [DataMember]
        public int FOBCodeID { get; set; }

        [DataMember]
        public int FOBLocationID { get; set; }

        [DataMember]
        public int CarriersID { get; set; }

        [DataMember]
        public int TransitTypeID { get; set; }

        [DataMember]
        public int FreightTermsID { get; set; }

        [DataMember]
        public string FOBCodeDescription { get; set; }

        [DataMember]
        public string FOBLocationDescription { get; set; }

        [DataMember]
        public string CarriersDescription { get; set; }

        [DataMember]
        public string TransitTypeDescription { get; set; }

        [DataMember]
        public string FreightTermsDescription { get; set; }

        //[DataMember]
        //public DateTime Datecreated { get; set; }

        [DataMember]
        public string FOBCode { get; set; }

        [DataMember]
        public string FOBLocationCode { get; set; }

        [DataMember]
        public string FreightTermsCode { get; set; }

        [DataMember]
        public string TransitTypeCode { get; set; }

        [DataMember]
        public string CarriersCode { get; set; }

        [DataMember]
        public List<LOBEntityConfiguration> lstLOBEntityConfiguration { get; set; }

        [DataMember]
        public bool IsOverallLimitAllowed { get; set; }

        [DataMember]
        public Collection<DocumentAdditionalEntityInfo> DocumentAdditionalEntitiesInfoList { get; set; }

        public long GetACEEntityDetailCode(List<DocumentSplitItemEntity> lstDocumentSplitItemEntity, int entityId)
        {
            if (lstDocumentSplitItemEntity != null)
            {
                DocumentSplitItemEntity documentSplitItemEntity = lstDocumentSplitItemEntity.Where(data => data.EntityTypeId == entityId).FirstOrDefault();
                if (documentSplitItemEntity != null)
                    return Convert.ToInt64(documentSplitItemEntity.SplitAccountingFieldValue);
                else
                    return 0;
            }
            else
                return 0;
        }

        public long GetACEEntityDetailCode(Collection<DocumentAdditionalEntityInfo> lstDocumentSplitItemEntity, int entityId)
        {
            if (lstDocumentSplitItemEntity != null)
            {
                DocumentAdditionalEntityInfo documentSplitItemEntity = lstDocumentSplitItemEntity.Where(data => data.EntityId == entityId).FirstOrDefault();
                if (documentSplitItemEntity != null)
                    return documentSplitItemEntity.EntityDetailCode;
                else
                    return 0;
            }
            else
                return 0;
        }

        [DataMember]
        public bool ERS { get; set; }

        [DataMember]
        public int UserDefinedApproversCount { get; set; }

        [DataMember]
        public String ItemPASCodes { get; set; }

        [DataMember]
        public List<NotesOrAttachments> ListNotesOrAttachments { get; set; }

        //[DataMember]
        //public List<ItemCharge> lstItemCharge { get; set; }

        [DataMember]
        public string OrgEntities { get; set; }

        [DataMember]
        public string FliterEntityTypeId { get; set; }

        [DataMember]
        public bool isFilterEntityChanged { get; set; }

        [DataMember]
        public string Rebillable { get; set; }

        [DataMember]
        public OnEvent OnEvent { get; set; }

        [DataMember]
        public List<GEP.SMART.Invoice.BusinessEntities.Old.RegistrationDetails> lstOrderingLocation { get; set; }

        [DataMember]
        public List<GEP.SMART.Invoice.BusinessEntities.Old.RegistrationDetails> RemitToLocationIdentificationDetails { get; set; }

        [DataMember]
        public List<GEP.SMART.Invoice.BusinessEntities.Old.RegistrationDetails> PartnerWiseIdentificationDetails { get; set; }

        //[DataMember]
        //public OrderExtendedStatus OrderExtendedStatus { get; set; }

        [DataMember]
        public List<EntitySumCalculation> EntitySumDeltaList { get; set; }

        #endregion Properties
    }

    [DataContract]
    [Serializable]
    public class EntitySumCalculation
    {
        [DataMember]
        public long EntityTypeId { get; set; }

        [DataMember]
        public string EntityCode { get; set; }

        [DataMember]
        public decimal TotalAmount { get; set; }

        [DataMember]
        public decimal OverallLimitSplitTotal { get; set; }
    }

    [DataContract]
    [Serializable]
    public class EntitiesCalculations
    {
        [DataMember]
        public int EntityTypeId { get; set; }

        [DataMember]
        public string EntityCode { get; set; }

        [DataMember]
        public long EntityDetailCode { get; set; }
    }

    [DataContract]
    [Serializable]
    public class EntityCominationSumCalculation
    {
        [DataMember]
        public List<EntitiesCalculations> EntityCombinations { get; set; }

        [DataMember]
        public decimal? TotalAmount { get; set; }

        [DataMember]
        public decimal OverallLimitSplitTotal { get; set; }
    }

    [DataContract]
    [Serializable]
    public class StandardAndProcedureDetails
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public long P2PItemId { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string RevisionNumber { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string FullTexts { get; set; }

        [DataMember]
        public Boolean IsDeleted { get; set; }
    }

    [DataContract]
    [Serializable]
    public class FOBShippingMasterData
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public Boolean IsDefault { get; set; }
    }

    [DataContract]
    [Serializable]
    public class RegistrationDetails
    {
        [DataMember]
        public string CompanyIdentificationDisplayName { get; set; }

        [DataMember]
        public string CompanyIdentification { get; set; }
    }
}

namespace GEP.SMART.Invoice.BusinessEntities
{
    /// <summary>
    /// Class for representing document across P2P.
    /// </summary>
    [KnownType(typeof(IdAndName))]
    [KnownType(typeof(CodeAndName))]
    [KnownType(typeof(Note))]
    [System.Xml.Serialization.XmlInclude(typeof(Note))]
    [System.Xml.Serialization.XmlInclude(typeof(IdAndName))]
    [System.Xml.Serialization.XmlInclude(typeof(CodeAndName))]
    [DataContract]
    [Serializable]
    public abstract class P2PDocument : Document
    {
        /// <summary>
        /// Document currency.
        /// </summary>
        [DataMember]
        public CodeAndName currency { get; set; }

        /// <summary>
        /// Business Unit.
        /// </summary>
        [DataMember]
        public IdAndName businessUnit { get; set; }

        /// <summary>
        /// Comments and attachments.
        /// </summary>
        [DataMember]
        public List<Note> notes { get; set; }

        /// <summary>
        /// BudgetId
        /// </summary>
        [DataMember]
        public int BudgetId { get; set; }

        /// <summary>
        /// Header entity 1.
        /// </summary>
        [DataMember]
        public HeaderEntity headerEntity1 { get; set; }

        /// <summary>
        /// Header entity 2.
        /// </summary>
        [DataMember]
        public HeaderEntity headerEntity2 { get; set; }

        /// <summary>
        /// Header entity 3.
        /// </summary>
        [DataMember]
        public HeaderEntity headerEntity3 { get; set; }

        /// <summary>
        /// Header entity 4.
        /// </summary>
        [DataMember]
        public HeaderEntity headerEntity4 { get; set; }

        /// <summary>
        /// Header entity 5.
        /// </summary>
        [DataMember]
        public HeaderEntity headerEntity5 { get; set; }

        /// <summary>
        /// Header entity 6.
        /// </summary>
        [DataMember]
        public HeaderEntity headerEntity6 { get; set; }

        /// <summary>
        /// Header entity 7.
        /// </summary>
        [DataMember]
        public HeaderEntity headerEntity7 { get; set; }

        /// <summary>
        /// Header entity 8.
        /// </summary>
        [DataMember]
        public HeaderEntity headerEntity8 { get; set; }

        /// <summary>
        /// Ship to address.
        /// </summary>
        [DataMember]
        public IdNameAndAddress shipTo { get; set; }

        /// <summary>
        /// Deliver to name/address.
        /// </summary>
        [DataMember]
        public IdNameAndAddress deliverTo { get; set; }

        /// <summary>
        /// Bill to address.
        /// </summary>
        [DataMember]
        public IdNameAddressAndContact billTo { get; set; }

        /// <summary>
        /// Deliver to name/address.
        /// </summary>
        [DataMember]
        public String deliverToStr { get; set; }

        /// <summary>
        /// Program Id.
        /// </summary>
        [DataMember]
        public long programId { get; set; }

        /// <summary>
        /// Other Charges.
        /// </summary>
        [DataMember]
        public decimal otherCharges { get; set; }

        /// <summary>
        /// Item Total.
        /// </summary>
        [DataMember]
        public decimal itemTotal { get; set; }

        /// <summary>
        /// Total.
        /// </summary>
        [DataMember]
        public decimal total { get; set; }

        /// <summary>
        /// Shipping.
        /// </summary>
        [DataMember]
        public decimal shipping { get; set; }

        /// <summary>
        /// Tax.
        /// </summary>
        [DataMember]
        public decimal tax { get; set; }

        [DataMember]
        public string rebillable { get; set; }

        /// <summary>
        /// Custom Attribues
        /// </summary>
        [DataMember]
        public List<Cumulus.QuestionBank.Entities.QuestionResponse> HeaderCustomAttribs { get; set; }

        /// <summary>
        /// User Configurations
        /// </summary>
        [DataMember]
        public List<P2PUserConfiguration> UserConfigurations { get; set; }

        [DataMember]
        public bool ERS { get; set; }

        [DataMember]
        public List<NotesOrAttachments> lstNotesOrAttachments { get; set; }

        [DataMember]
        public List<KeyValuePair<string, int>> lstCategoryType { get; set; }

        [DataMember]
        public List<ItemCharge> ItemChargesForHeader { get; set; }

        [DataMember]
        public ChargeMaster DefaultChargeMasterDetails { get; set; }

        [DataMember]
        public string OrderContactEmail { get; set; }

        [DataMember]
        public string OrderContactPhone { get; set; }

        [DataMember]
        public string OrderContactFax { get; set; }

        [DataMember]
        public long CustomAttrFormIdForHeader { get; set; }

        [DataMember]
        public long CustomAttrFormIdForItem { get; set; }

        [DataMember]
        public long CustomAttrFormIdForSplit { get; set; }

        [DataMember]
        public List<IdAndName> CustomAttrQuestionSetCodesForHeader { get; set; }

        [DataMember]
        public List<IdAndName> CustomAttrQuestionSetCodesForItem { get; set; }

        [DataMember]
        public List<long> CustomAttrQuestionSetCodesForSplit { get; set; }

        [DataMember]
        public VATValues VAT { get; set; }

        [DataMember]
        public List<SplitAccountingFields> HeaderSplitAccountingFields { get; set; }

        [DataMember]
        public List<SplitAccountingFields> LineSplitAccountingFields { get; set; }

        [DataMember]
        public OnEvent OnEvent { get; set; }

        [DataMember]
        public long BuyerAssignee { get; set; }

        [DataMember]
        public IdAndName buyerAssigneeName { get; set; }

        [DataMember]
        public bool IsDocumentNumberUpdatable { get; set; }

        [DataMember]
        public string ExistingDocumentNumber { get; set; }

        [DataMember]
        public CodeAndName Contract { get; set; }

        [DataMember]
        public Double? ContractValue { get; set; }

        [DataMember]
        public DateTime? ContractExpiryDate { get; set; }

        [DataMember]
        public bool EnforceLineReference { get; set; }
    }
}