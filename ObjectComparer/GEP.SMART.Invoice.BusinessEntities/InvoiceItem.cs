using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    /// <summary>
    /// Class for base invoice item.
    /// </summary>
    [KnownType(typeof(InvoiceAccountingSplit))]
    [KnownType(typeof(IdAndName))]
    [KnownType(typeof(IdNameAndAddress))]
    [System.Xml.Serialization.XmlInclude(typeof(IdNameAndAddress))]
    [System.Xml.Serialization.XmlInclude(typeof(IdAndName))]
    [System.Xml.Serialization.XmlInclude(typeof(InvoiceAccountingSplit))]
    [DataContract]
    [Serializable]
    public class InvoiceItem : P2PDocumentItem
    {
        [DataMember]
        public List<InvoiceAccountingSplit> splits { get; set; }

        [DataMember]
        public decimal orderedQuantity { get; set; }

        [DataMember]
        public decimal? orderUnitPrice { get; set; }

        [DataMember]
        public decimal? orderLineValue { get; set; }

        [DataMember]
        public decimal invoiceAmount { get; set; }

        [DataMember]
        public decimal remainingInvoiceAmount { get; set; }

        [DataMember]
        public decimal lineAmountDiff { get; set; }

        [DataMember]
        public long pOLineItemNumber { get; set; }

        [DataMember]
        public decimal useTax { get; set; }

        [DataMember]
        public bool accrueUseTax { get; set; }

        [DataMember]
        public long orderItemId { get; set; }

        [DataMember]
        public string imageUrl { get; set; }

        [DataMember]
        public decimal? invoicePaidAmount { get; set; }

        [DataMember]
        public decimal invoicePaidQuantity { get; set; }

        [DataMember]
        public decimal orderShipping { get; set; }

        [DataMember]
        public decimal orderAdditionalCharges { get; set; }

        [DataMember]
        public decimal orderTax { get; set; }

        [DataMember]
        public decimal invocingTax { get; set; }

        [DataMember]
        public decimal validateInvoiceAmount { get; set; }

        [DataMember]
        public DateTime orderDate { get; set; }

        [DataMember]
        public int referenceNumber { get; set; }

        [DataMember]
        public string isTaxExemptText { get; set; }

        [DataMember]
        public string itemTypeName { get; set; }

        [DataMember]
        public string taxText { get; set; }

        [DataMember]
        public string unitPriceText { get; set; }

        [DataMember]
        public IdAndName evaluator { get; set; }

        [DataMember]
        public DateTime? needByDate { get; set; }

        [DataMember]
        public String deliverToStr { get; set; }

        [DataMember]
        public CodeAndName shippingMethod { get; set; }

        [DataMember]
        public int matchStatus { get; set; }

        [DataMember]
        public IdNameAndAddress shipTo { get; set; }

        [DataMember]
        public P2PAddress shipToAddress { get; set; }

        [DataMember]
        public IdNameAndAddress deliverTo { get; set; }

        [DataMember]
        public IdAndName matchType { get; set; }

        [DataMember]
        public Contract Contract { get; set; }

        [DataMember]
        public IdAndName ItemStatus { get; set; }

        [DataMember]
        public String capitalized { get; set; }

        [DataMember]
        public String capitalCode { get; set; }

        [DataMember]
        public decimal accrueTaxes { get; set; }

        [DataMember]
        public List<InvoiceError> ErrorList { get; set; }

        [DataMember]
        public long orderId { get; set; }

        [DataMember]
        public string orderNumber { get; set; }

        [DataMember]
        public string orderName { get; set; }

        [DataMember]
        public IdNameAndEmail orderContact { get; set; }

        [DataMember]
        public long orderingLocationId { get; set; }

        [DataMember]
        public IdNameAndAddress orderingLocation { get; set; }

        [DataMember]
        public decimal orderTotal { get; set; }

        [DataMember]
        public int closingOrderStatus { get; set; }

        [DataMember]
        public long orderLineNumber { get; set; }

        [DataMember]
        public string PriceType { get; set; }

        [DataMember]
        public string JobTitle { get; set; }

        [DataMember]
        public string ContingentWorkerName { get; set; }

        [DataMember]
        public decimal Margin { get; set; }

        [DataMember]
        public decimal BaseRate { get; set; }

        [DataMember]
        public string ReportingManager { get; set; }

        [DataMember]
        public DateTime? firstReceiptDate { get; set; }

        [DataMember]
        public DateTime? lastReceiptDate { get; set; }

        [DataMember]
        public long ShipFromLocationId { get; set; }

        [DataMember]
        public decimal ExternalTax { get; set; }

        [DataMember]
        public List<ExternalTaxesOld> ExternalTaxes { get; set; }

        [DataMember]
        public long ERPLineReferenceNumber { get; set; }

        [DataMember]
        public P2PAddress ShipFromLocationAddress { get; set; }

        [DataMember]
        public FulfilmentDocumentInfo FulfilmentDocumentInfo { get; set; }

        [DataMember]
        public List<CustomFieldInfo> lstCustomFields { get; set; }

        [DataMember]
        public bool AllowDecimal { get; set; }

        [DataMember]
        public Catalog Catalog { get; set; }

        [DataMember]
        public decimal? TotalCharge { get; set; }

        [DataMember]
        public decimal TotalAllowance { get; set; }

        [DataMember]
        public List<ItemChargeExtension> lstLineItemCharges { get; set; }

        [DataMember]
        public override double? LineItemAmount
        {
            get
            {
                return ((this.unitPrice == null || this.unitPrice == 0 || this.quantity == null) ? 0 : ((this.quantity * this.unitPrice) - decimal.ToDouble(this.TotalAllowance)));
            }
            set { }
        }

        [DataMember]
        public decimal AcceptedQuantity { get; set; }
    }
}