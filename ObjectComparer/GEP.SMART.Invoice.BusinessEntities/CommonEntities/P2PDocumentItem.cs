using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using QuestionBankEntities = GEP.Cumulus.QuestionBank.Entities;

namespace GEP.SMART.Invoice.BusinessEntities
{
    /// <summary>
    /// Class for document item across P2P.
    /// </summary>
    [KnownType(typeof(IdAndName))]
    [KnownType(typeof(CodeAndName))]
    [KnownType(typeof(Note))]
    [KnownType(typeof(Tax))]
    [KnownType(typeof(Tax))]
    [System.Xml.Serialization.XmlInclude(typeof(Tax))]
    [System.Xml.Serialization.XmlInclude(typeof(Note))]
    [System.Xml.Serialization.XmlInclude(typeof(IdAndName))]
    [System.Xml.Serialization.XmlInclude(typeof(CodeAndName))]
    [System.Xml.Serialization.XmlInclude(typeof(Tax))]
    [DataContract]
    [Serializable]
    public abstract class P2PDocumentItem
    {
        /// <summary>
        /// Flag for tax exempt.
        /// </summary>
        [DataMember]
        public Boolean isTaxExempt { get; set; }

        /// <summary>
        /// Item status.
        /// </summary>
        [DataMember]
        public Byte status { get; set; }

        /// <summary>
        /// Split type.
        /// </summary>
        [DataMember]
        public Int16 splitType { get; set; }

        /// <summary>
        /// Item Id.
        /// </summary>
        [DataMember]
        public Int64 id { get; set; }

        /// <summary>
        /// Serial number.
        /// </summary>
        [DataMember]
        public Int64 lineNumber { get; set; }

        /// <summary>
        /// Document code.
        /// </summary>
        [DataMember]
        public Int64 documentCode { get; set; }

        /// <summary>
        /// P2P line item id.
        /// </summary>
        [DataMember]
        public Int64 p2PLineItemId { get; set; }

        /// <summary>
        /// Catalog item id.
        /// </summary>
        [DataMember]
        public Int64? catalogItemId { get; set; }

        /// <summary>
        /// Taxes.
        /// </summary>
        [DataMember]
        public Double? taxes { get; set; }

        /// <summary>
        /// Quantity.
        /// </summary>
        [DataMember]
        public Double quantity { get; set; }

        /// <summary>
        /// minQuantity.
        /// </summary>
        [DataMember]
        public Double? minQuantity { get; set; }

        /// <summary>
        /// maxQuantity.
        /// </summary>
        [DataMember]
        public Double? maxQuantity { get; set; }

        /// <summary>
        /// banding.
        /// </summary>
        [DataMember]
        public Double? banding { get; set; }

        /// <summary>
        /// Unit price.
        /// </summary>
        [DataMember]
        public Double? unitPrice { get; set; }

        /// <summary>
        /// Other charges.
        /// </summary>
        [DataMember]
        public Double? otherCharges { get; set; }

        /// <summary>
        /// Shipping charges.
        /// </summary>
        [DataMember]
        public Double? shippingCharges { get; set; }

        /// <summary>
        /// Contract value.
        /// </summary>
        [DataMember]
        public Double? contractValue { get; set; }

        /// <summary>
        /// Contract Name.
        /// </summary>
        [DataMember]
        public string contractName { get; set; }

        /// <summary>
        /// End date.
        /// </summary>
        [DataMember]
        public DateTime? endDate { get; set; }

        /// <summary>
        /// Start date.
        /// </summary>
        [DataMember]
        public DateTime? startDate { get; set; }

        /// <summary>
        /// Created date.
        /// </summary>
        [DataMember]
        public DateTime createdOn { get; set; }

        /// <summary>
        /// Last modified date.
        /// </summary>
        [DataMember]
        public DateTime lastModifiedOn { get; set; }

        /// <summary>
        /// Contract expiry date.
        /// </summary>
        [DataMember]
        public DateTime? contractExpiryDate { get; set; }

        /// <summary>
        /// Item name.
        /// </summary>
        [DataMember]
        public String name { get; set; }

        /// <summary>
        /// Image URL.
        /// </summary>
        [DataMember]
        public String imageURL { get; set; }

        /// <summary>
        /// Buyer item number.
        /// </summary>
        [DataMember]
        public String buyerItemNumber { get; set; }

        /// <summary>
        /// Item description.
        /// </summary>
        [DataMember]
        public String description { get; set; }

        /// <summary>
        /// Manufacturer name.
        /// </summary>
        [DataMember]
        public String manufacturer { get; set; }

        /// <summary>
        /// Contract number.
        /// </summary>
        [DataMember]
        public String contractNumber { get; set; }

        /// <summary>
        /// Partner item number.
        /// </summary>
        [DataMember]
        public String partnerItemNumber { get; set; }

        /// <summary>
        /// Manufacturer part number.
        /// </summary>
        [DataMember]
        public String manufacturerPartNumber { get; set; }

        /// <summary>
        /// Supplier part auxiliary id.
        /// </summary>
        [DataMember]
        public String supplierPartAuxiliaryId { get; set; }

        /// <summary>
        /// Item type.
        /// </summary>
        [DataMember]
        public IdAndName type { get; set; }

        /// <summary>
        /// Unit of measure.
        /// </summary>
        [DataMember]
        public CodeAndName uom { get; set; }

        /// <summary>
        /// Item source.
        /// </summary>
        [DataMember]
        public IdAndName source { get; set; }

        /// <summary>
        /// Item partner.
        /// </summary>
        [DataMember]
        public IdAndName partner { get; set; }

        /// <summary>
        /// Category.
        /// </summary>
        [DataMember]
        public IdAndName category { get; set; }

        /// <summary>
        /// Contract.
        /// </summary>
        [DataMember]
        public IdAndName contract { get; set; }

        /// <summary>
        /// Created by user.
        /// </summary>
        [DataMember]
        public IdAndName createdBy { get; set; }

        /// <summary>
        /// Last modified by user.
        /// </summary>
        [DataMember]
        public IdAndName lastModifiedBy { get; set; }

        /// <summary>
        /// Comments and attachments.
        /// </summary>
        [DataMember]
        public List<Note> notes { get; set; }

        /// <summary>
        /// Tax details
        /// </summary>
        [DataMember]
        public List<Tax> taxItems { get; set; }

        /// <summary>
        /// Tax details
        /// </summary>
        [DataMember]
        public List<Tax> accrueTaxItems { get; set; }

        /// <summary>
        /// Tax Percentage
        /// </summary>
        [DataMember]
        public decimal taxPercentage { get; set; }

        /// <summary>
        /// Is Deleted
        /// </summary>
        [DataMember]
        public bool isDeleted { get; set; }

        /// <summary>
        /// Custom Attribues
        /// </summary>
        [DataMember]
        public List<QuestionBankEntities.QuestionResponse> ItemCustomAttribs { get; set; }

        [DataMember]
        public String ManufacturerModel { get; set; }

        [DataMember]
        public bool ERS { get; set; }

        [DataMember]
        public DateTime? promisedDate { get; set; }

        [DataMember]
        public DateTime? estimatedDeliveryDate { get; set; }

        [DataMember]
        public Int64 leadTime { get; set; }

        [DataMember]
        public IdAndName ContractItems { get; set; }

        [DataMember]
        public List<QuestionBankEntities.QuestionResponse> ListQuestionResponse { get; set; }

        [DataMember]
        public List<ItemCharge> ItemChargesForSubLine { get; set; }

        [DataMember]
        public List<IdAndName> CustomAttrQuestionSetCodesForItem { get; set; }

        /// <summary>
        /// Is EnforceLineReference
        /// </summary>
        [DataMember]
        public bool IsEnforceLineReference { get; set; }

        [DataMember]
        public string OrderingStatus { get; set; }

        [DataMember]
        public bool AccountingStatus { get; set; }

        [DataMember]
        public bool IsCopy { get; set; }

        [DataMember]
        public long CopyLineItemId { get; set; }

        [DataMember]
        public decimal OverallItemLimit { get; set; }

        [DataMember]
        public IdAndName InvoiceApprover { get; set; }

        /// <summary>
        /// Contract Item Id
        /// </summary>
        [DataMember]
        public long ContractItemId { get; set; }

        [DataMember]
        public IdNameAndAddress ShipFromLocation { get; set; }

        [DataMember]
        public string ContractLineRef { get; set; }

        /// <summary>
        /// External Tax details
        /// </summary>
        [DataMember]
        public List<Tax> externalTaxItems { get; set; }

        /// <summary>
        /// External Tax details
        /// </summary>
        [DataMember]
        public virtual double? LineItemAmount
        {
            get
            {
                return (this.quantity * this.unitPrice == null ? 0 : this.quantity * this.unitPrice) + (this.shippingCharges == null ? 0 : this.shippingCharges)
                    + (this.otherCharges == null ? 0 : this.otherCharges) + (this.taxes == null ? 0 : this.taxes);
            }
            set { }
        }
    }
}