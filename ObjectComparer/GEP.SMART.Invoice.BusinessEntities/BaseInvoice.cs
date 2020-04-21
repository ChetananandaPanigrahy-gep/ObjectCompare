using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [KnownType(typeof(IdAndName))]
    [KnownType(typeof(HeaderEntity))]
    [KnownType(typeof(IdNameAddressAndContact))]
    [KnownType(typeof(IdNameAndAddress))]
    [KnownType(typeof(IdNameAndEmail))]
    [KnownType(typeof(IdAndDate))]
    [KnownType(typeof(ToleranceDetails))]
    [KnownType(typeof(FOBDetails))]
    [KnownType(typeof(IdCodeAndDesc))]
    [KnownType(typeof(Tax))]
    [System.Xml.Serialization.XmlInclude(typeof(IdNameAndAddress))]
    [System.Xml.Serialization.XmlInclude(typeof(IdNameAddressAndContact))]
    [System.Xml.Serialization.XmlInclude(typeof(IdAndName))]
    [System.Xml.Serialization.XmlInclude(typeof(HeaderEntity))]
    [System.Xml.Serialization.XmlInclude(typeof(IdNameAndEmail))]
    [System.Xml.Serialization.XmlInclude(typeof(IdAndDate))]
    [System.Xml.Serialization.XmlInclude(typeof(ToleranceDetails))]
    [System.Xml.Serialization.XmlInclude(typeof(FOBDetails))]
    [System.Xml.Serialization.XmlInclude(typeof(IdCodeAndDesc))]
    [System.Xml.Serialization.XmlInclude(typeof(Tax))]
    [DataContract]
    [Serializable]
    public abstract class BaseInvoice : P2PDocument
    {
        [DataMember]
        public int invoiceSource { get; set; }

        [DataMember]
        public IdAndName partner { get; set; }

        [DataMember]
        public string clientPartnerCode { get; set; }

        [DataMember]
        public int invoiceLocationId { get; set; }

        [DataMember]
        public IdNameAndValue paymentTerms { get; set; }

        [DataMember]
        public IdAndName matchType { get; set; }

        [DataMember]
        public IdAndName erpOrderType { get; set; }

        [DataMember]
        public IdNameAndEmail partnerContact { get; set; }

        [DataMember]
        public IdNameAndAddress invoicingLocation { get; set; }

        [DataMember]
        public IdAndName purchaseType { get; set; }

        [DataMember]
        public IdNameAndAddress remittoLocation { get; set; }

        [DataMember]
        public DateTime? partnerInvoiceDate { get; set; }

        [DataMember]
        public string PartnerInvoiceNumber { get; set; }

        [DataMember]
        public string orderNumber { get; set; }

        [DataMember]
        public int businessUnitId { get; set; }

        [DataMember]
        public long buyerId { get; set; }

        [DataMember]
        public List<InvoiceMatchStatus> matchStatus { get; set; }

        [DataMember]
        public string orderName { get; set; }

        [DataMember]
        public IdAndName extendedStatus { get; set; }

        [DataMember]
        public decimal orderTotal { get; set; }

        [DataMember]
        public DateTime orderDate { get; set; }

        [DataMember]
        public bool updateStakeHolderDetails { get; set; }

        [DataMember]
        public IdAndName invoiceOrigin { get; set; }

        [DataMember]
        public DateTime receivedDate { get; set; }

        [DataMember]
        public decimal? UseTax { get; set; }

        [DataMember]
        public List<Tax> taxItems { get; set; }

        [DataMember]
        public IdNameAndEmail orderContact { get; set; }

        [DataMember]
        public long orderId { get; set; }

        [DataMember]
        public string businessUnitName { get; set; }

        [DataMember]
        public IdAndName invoiceCreatedFrom { get; set; }

        [DataMember]
        public IdAndName orderStatus { get; set; }

        [DataMember]
        public IdAndName orderPartner { get; set; }

        [DataMember]
        public int closingOrderStatus { get; set; }

        [DataMember]
        public decimal? invoiceTotalAmount { get; set; }

        [DataMember]
        public decimal amountDifferenceBetweenOrderInvoice { get; set; }

        [DataMember]
        public long programId { get; set; }

        [DataMember]
        public IdNameAndAddress orderingLocation { get; set; }

        [DataMember]
        public long orderingLocationId { get; set; }

        [DataMember]
        public int orderSourceSystemId { get; set; }

        [DataMember]
        public string orderCurrency { get; set; }

        [DataMember]
        public Int32 orderPaymentTermId { get; set; }

        [DataMember]
        public IdAndName invoiceStatus { get; set; }

        [DataMember]
        public DateTime submittedOn { get; set; }

        [DataMember]
        public long CurrentDateMinusInvoiceDate { get; set; }

        [DataMember]
        public long IsOrderAndInvoiceContactSame { get; set; }

        [DataMember]
        public long IsOrderAndInvoiceCurrencySame { get; set; }

        [DataMember]
        public string buyerVatNumber { get; set; }

        [DataMember]
        public string workOrderNumber { get; set; }

        [DataMember]
        public VATValues vat { get; set; }

        [DataMember]
        public long remittoLocationId { get; set; }

        [DataMember]
        public FOBDetails fobDetails { get; set; }

        [DataMember]
        public string ItemExtendedTypeIds { get; set; }

        [DataMember]
        public bool IsflipCustomFields { get; set; }

        [DataMember]
        public long ImageId { get; set; }

        [DataMember]
        public long OldImageId { get; set; }

        [DataMember]
        public List<FileUploadDetails> FileDetails { get; set; }

        [DataMember]
        public List<KeyValuePair<string, string>> InvoiceActionMenu { get; set; }

        [DataMember]
        public List<InvoiceError> ErrorList { get; set; }

        [DataMember]
        public int identificationId { get; set; }

        [DataMember]
        public string supplierIdentificationValue { get; set; }

        [DataMember]
        public List<VATValues> vatValues { get; set; }

        [DataMember]
        public List<string> supplierVatValues { get; set; }

        [DataMember]
        public IdAndName interfaceStatus { get; set; }

        [DataMember]
        public List<Gep.Cumulus.Partner.Entities.UserLOBMapping> ServingLOBs { get; set; }

        [DataMember]
        public int InvoiceCreator { get; set; }

        [DataMember]
        public int IsMultiDocInvoice { get; set; }

        [DataMember]
        public List<long> OrderIdList { get; set; }

        [DataMember]
        public DateTime? ScheduledPaymentDate { get; set; }

        [DataMember]
        public string interfaceComment { get; set; }

        [DataMember]
        public DateTime? interfaceDate { get; set; }

        [DataMember]
        public string ERPInvoiceNumber { get; set; }

        [DataMember]
        public decimal? TotalCharge { get; set; }

        [DataMember]
        public int FulfilmentDocumentType { get; set; }

        [DataMember]
        public string FulfilmentDocumentNumber { get; set; }

        [DataMember]
        public int InvoiceType { get; set; }

        [DataMember]
        public bool IsERS { get; set; }

        [DataMember]
        public string DeliveryNoteNumber { get; set; }

        [DataMember]
        public List<CustomFieldInfo> lstCustomFields { get; set; }

        [DataMember]
        public int POFulfillmentDocumentType { get; set; }

        [DataMember]
        public IdAndName documentExtendedStatus { get; set; }

        [DataMember]
        public List<Tax> taxBaseDetails { get; set; }

        [DataMember]
        public InvoiceComplianceStatus complianceStatus { get; set; }

        [DataMember]
        public InvoiceCompliance InvoiceCompliance { get; set; }

        [DataMember]
        public InvoiceArchivalStatus archivalStatus { get; set; }

        [DataMember]
        public int InvoiceCreationSource { get; set; }
    }

    [DataContract]
    [Serializable]
    public class InvoiceComplianceFieldMapping
    {
        [DataMember]
        public string FieldName { get; set; }

        [DataMember]
        public string FieldMapping { get; set; }

        [DataMember]
        public byte UserType { get; set; }

        [DataMember]
        public bool IsVisible { get; set; }

        [DataMember]
        public bool IsEditable { get; set; }
    }

    [DataContract]
    [Serializable]
    public class InvoiceCompliance
    {
        [DataMember]
        public byte ComplianceType { get; set; }

        [DataMember]
        public byte ValidationType { get; set; }

        [DataMember]
        public byte SigningType { get; set; }

        [DataMember]
        public bool IsArchivalEnabled { get; set; }

        [DataMember]
        public byte TransformationType { get; set; }

        [DataMember]
        public List<InvoiceComplianceFieldMapping> FieldMapping { get; set; }

        [DataMember]
        public Dictionary<string, P2PAddress> Addresses { get; set; }
    }
}