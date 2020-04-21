using Gep.Cumulus.CSM.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using QuestionBankEntities = GEP.Cumulus.QuestionBank.Entities;

namespace GEP.SMART.Invoice.BusinessEntities.Old
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(OrderItem))]
    [KnownType(typeof(ItemType))]
    [KnownType(typeof(ItemSourceType))]
    [KnownType(typeof(ItemExtendedType))]
    [KnownType(typeof(DocumentItemShippingDetail))]
    [KnownType(typeof(FileUploadDetails))]
    [KnownType(typeof(Taxes))]
    [KnownType(typeof(QuestionBankEntities.Question))]
    [KnownType(typeof(ExternalTaxesOld))]
    [System.Xml.Serialization.XmlInclude(typeof(ItemType))]
    [System.Xml.Serialization.XmlInclude(typeof(ItemSourceType))]
    [System.Xml.Serialization.XmlInclude(typeof(ItemExtendedType))]
    [System.Xml.Serialization.XmlInclude(typeof(DocumentItemShippingDetail))]
    [System.Xml.Serialization.XmlInclude(typeof(OrderItem))]
    [System.Xml.Serialization.XmlInclude(typeof(FileUploadDetails))]
    [System.Xml.Serialization.XmlInclude(typeof(Taxes))]
    [System.Xml.Serialization.XmlInclude(typeof(QuestionBankEntities.Question))]
    [System.Xml.Serialization.XmlInclude(typeof(ExternalTaxesOld))]
    public class P2PItem : EntityBase
    {
        private List<FileUploadDetails> itemImages = new List<FileUploadDetails>();
        private string _billable = "NonBillable";
        private string _capitalized = "No";

        [DataMember]
        public long DocumentItemId { get; set; }

        [DataMember]
        public long P2PLineItemId { get; set; }

        [DataMember]
        public long DocumentId { get; set; }

        [DataMember]
        public long ItemLineNumber { get; set; }

        [DataMember]
        public string ShortName { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public decimal? UnitPrice { get; set; }

        [DataMember]
        public decimal Quantity { get; set; }

        [DataMember]
        public decimal? RemainingCreditAmount { get; set; }

        [DataMember]
        public decimal? RemainingCreditQuantity { get; set; }

        [DataMember]
        public decimal? RemainingCreditTax { get; set; }

        [DataMember]
        // ReSharper disable InconsistentNaming
        public string UOM { get; set; }

        // ReSharper restore InconsistentNaming

        [DataMember]
        public string StandardUOM { get; set; }

        [DataMember]
        public string UOMDesc { get; set; }

        [DataMember]
        public bool AllowDecimalsForUom { get; set; }

        [DataMember]
        public string Currency { get; set; }

        [DataMember]
        public decimal PartnerCode { get; set; }

        [DataMember]
        public string ManufacturerName { get; set; }

        [DataMember]
        public string ManufacturerPartNumber { get; set; }

        [DataMember]
        public long CategoryId { get; set; }

        [DataMember]
        public ItemType ItemType { get; set; }

        [DataMember]
        public ItemExtendedType ItemExtendedType { get; set; }

        [DataMember]
        public decimal? Efforts { get; set; }

        [DataMember]
        public ItemExtendedType ExtendedType { get; set; }

        [DataMember]
        public ItemSourceType SourceType { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public List<DocumentItemShippingDetail> DocumentItemShippingDetails { get; set; }

        [DataMember]
        public DateTime? StartDate { get; set; }

        [DataMember]
        public DateTime? EndDate { get; set; }

        [DataMember]
        public decimal? AdditionalCharges { get; set; }

        [DataMember]
        public decimal? ShippingCharges { get; set; }

        [DataMember]
        public decimal? Tax { get; set; }

        [DataMember]
        public bool IsTaxExempt { get; set; }

        [DataMember]
        public DateTime? DateRequested { get; set; }

        [DataMember]
        public DateTime? DateNeeded { get; set; }

        [DataMember]
        public Cumulus.Documents.Entities.DocumentStatus ItemStatus { get; set; }

        [DataMember]
        public decimal MinimumOrderQuantity { get; set; }

        [DataMember]
        public decimal MaximumOrderQuantity { get; set; }

        [DataMember]
        public int Banding { get; set; }

        [DataMember]
        public string PartnerName { get; set; }

        [DataMember]
        public string CategoryName { get; set; }

        [DataMember]
        public long ItemCode { get; set; }

        [DataMember]
        public decimal? ItemTotalAmount { get; set; }

        [DataMember]
        public decimal? ItemTotalValue { get; set; }

        [DataMember]
        public decimal? ItemTotalTaxValue { get; set; }

        [DataMember]
        public int IsProcurable { get; set; }

        [DataMember]
        public string Billable
        {
            get; set;
        }

        [DataMember]
        public Nullable<bool> InventoryType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly"), DataMember]
        public List<FileUploadDetails> ItemImages
        {
            get { return itemImages; }
            set { itemImages = value; }
        }

        [DataMember]
        public int Unspsc { get; set; }

        [DataMember]
        public string ClientPartnerCode { get; set; }

        [DataMember]
        public string ItemNumber { get; set; }

        [DataMember]
        public SplitType SplitType { get; set; }

        [DataMember]
        public bool AccountingStatus { get; set; }

        [DataMember]
        public string SupplierPartId { get; set; }

        [DataMember]
        public string SupplierPartAuxiliaryId { get; set; }

        [DataMember]
        public List<AssetTag> AssetTags { get; set; }

        [DataMember]
        public List<Taxes> Taxes { get; set; }

        [DataMember]
        public List<Comments> Comments { get; set; }

        [DataMember]
        public bool isDefault { get; set; }

        [DataMember]
        public long CatalogItemId { get; set; }

        [DataMember]
        public string ContractNo { get; set; }

        [DataMember]
        public DateTime? ContractStartDate { get; set; }

        [DataMember]
        public DateTime? ContractEndDate { get; set; }

        [DataMember]
        public decimal? ContractValue { get; set; }

        [DataMember]
        public decimal? ContractVolume { get; set; }

        [DataMember]
        public string PaymentTerms { get; set; }

        [DataMember]
        public Int32 PaymentTermId { get; set; }

        [DataMember]
        public string ContractName { get; set; }

        [DataMember]
        public int CommentCount { get; set; }

        [DataMember]
        public string ClientCategoryId { get; set; }

        [DataMember]
        public string Capitalized
        {
            get { return string.IsNullOrWhiteSpace(_capitalized) ? "No" : _capitalized; }
            set { _capitalized = value; }
        }

        [DataMember]
        public string CapitalCode { get; set; }

        [DataMember]
        public string ExtContractRef { get; set; }

        [DataMember]
        public Nullable<long> AccountNumber { get; set; }

        [DataMember]
        public bool IsContracted { get; set; }

        [DataMember]
        public bool IsBlanket { get; set; }

        [DataMember]
        public int TypeOfItem { get; set; }

        [DataMember]
        public MatchType MatchType { get; set; }

        [DataMember]
        public decimal ItemReceivingTolerance { get; set; }

        [DataMember]
        public string PartnerContactName { get; set; }

        [DataMember]
        public long PartnerContactId { get; set; }

        [DataMember]
        public string OrderLocationName { get; set; }

        [DataMember]
        public long OrderLocationId { get; set; }

        [DataMember]
        public long RemitToLocationId { get; set; }

        [DataMember]
        public long OrderLocationAddressCode { get; set; }

        [DataMember]
        public long RemitToLocationAddressCode { get; set; }

        [DataMember]
        public long ShipFromLocationAddressCode { get; set; }

        [DataMember]
        public long ReceiptLineItemNumber { get; set; }

        [DataMember]
        public string EmailId { get; set; }

        [DataMember]
        public string PhoneNo { get; set; }

        [DataMember]
        public bool IsChecked { get; set; }

        [DataMember]
        public long TrasmissionMode { get; set; }

        [DataMember]
        public string TransmissionValue { get; set; }

        [DataMember]
        public byte AllowEditAndInspect { get; set; }

        [DataMember]
        public long PartnerConfigurationId { get; set; }

        [DataMember]
        public long PunchoutCartReqId { get; set; }

        [DataMember]
        public long CustomAttrFormId { get; set; }

        [DataMember]
        public string GTIN { get; set; }

        [DataMember]
        public int ContractItemLineNumber { get; set; }

        [DataMember]
        public decimal RecoupmentPercentage { get; set; }

        [DataMember]
        public decimal ItemAdvanceAmount { get; set; }

        [DataMember]
        public int AdjustmentType { get; set; }

        [DataMember]
        public int AdvanceItemCount { get; set; }

        [DataMember]
        public string ManufacturerSupplierCode { get; set; }

        [DataMember]
        public string ManufacturerModel { get; set; }

        [DataMember]
        public bool IsQuestionnaireError { get; set; }

        [DataMember]
        public List<Questionnaire> CustomAttributes { get; set; }

        [DataMember]
        public decimal OverallItemLimit { get; set; }

        [DataMember]
        public decimal OverallItemTaxLimit { get; set; }

        [DataMember]
        public decimal RuleExtendedType { get; set; }

        [DataMember]
        public decimal OrderItemTotal { get; set; }

        [DataMember]
        public bool IsOverallLimitAllowed { get; set; }

        [DataMember]
        public bool ERS { get; set; }

        [DataMember]
        public DateTime? promisedDate { get; set; }

        [DataMember]
        public DateTime? estimatedDeliveryDate { get; set; }

        [DataMember]
        public Int64 leadTime { get; set; }

        [DataMember]
        public ItemCharge ItemCharge { get; set; }

        [DataMember]
        public string UpdatedBy { get; set; }

        [DataMember]
        public string UpdatedVia { get; set; }

        [DataMember]
        public int ChargeItemCount { get; set; }

        [DataMember]
        public List<ItemChargeExtension> lstLineItemCharges { get; set; }

        [DataMember]
        public List<NotesOrAttachments> ListNotesOrAttachments { get; set; }

        [DataMember]
        public int SublineItemCount { get; set; }

        [DataMember]
        public List<ItemCharge> ItemChargesForSubLine { get; set; }

        [DataMember]
        public List<QuestionBankEntities.QuestionResponse> ListQuestionResponse { get; set; }

        [DataMember]
        public long ContractItemId { get; set; }

        [DataMember]
        public string ContractLineRef { get; set; }

        [DataMember]
        public bool IsEnforceLineReference { get; set; }

        [DataMember]
        public bool IsValid { get; set; }

        [DataMember]
        public decimal PreviouslyShippedQuantity { get; set; }

        [DataMember]
        public string BlanketNumber { get; set; }

        [DataMember]
        public string SupplierItemNumber { get; set; }

        [DataMember]
        public decimal TaxRate { get; set; }

        [DataMember]
        public string TaxErrorMessage { get; set; }

        [DataMember]
        public long OrderContact { get; set; }

        [DataMember]
        public long OrderingLocationId { get; set; }

        [DataMember]
        public long ShipFromLocationId { get; set; }

        [DataMember]
        public string ShipFromLocationName { get; set; }

        [DataMember]
        public long SmartFormId { get; set; }

        [DataMember]
        public List<ExternalTaxesOld> ExternalTaxes { get; set; }
    }
}