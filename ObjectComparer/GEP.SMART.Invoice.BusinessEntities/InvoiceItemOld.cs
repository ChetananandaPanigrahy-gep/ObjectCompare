using Gep.Cumulus.Partner.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities.Old
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(MatchStatus))]
    [System.Xml.Serialization.XmlInclude(typeof(MatchStatus))]
    public class InvoiceItem : P2PItem,IDisposable
    {
        [DataMember]
        public List<ItemChargeExtension> lstLineItemCharge { get; set; }

        [DataMember]
        public List<ItemCharge> lstLineItemChargesForInterface { get; set; }

        [DataMember]
        public decimal OrderQuantiy { get; set; }

        [DataMember]
        public decimal? OrderUnitPrice { get; set; }

        [DataMember]
        public decimal? OrderLineValue { get; set; }

        [DataMember]
        public decimal InvoiceAmount { get; set; }

        [DataMember]
        public decimal RemainingInvoiceAmount { get; set; }

        [DataMember]
        public decimal LineAmountDiff { get; set; }

        [DataMember]
        public MatchStatus MatchStatus { get; set; }

        //Required for Interface to send or receive  accounting detail as a part of item.
        [DataMember]
        public List<InvoiceSplitItems> ItemSplitsDetails { get; set; }

        [DataMember]
        public long POLineItemNumber { get; set; }

        [DataMember]
        public decimal UseTax { get; set; }

        [DataMember]
        public bool AccrueUseTax { get; set; }

        [DataMember]
        public long OrderItemId { get; set; }

        [DataMember]
        public string ImageUrl { get; set; }

        [DataMember]
        public decimal? InvoicedPaidAmount { get; set; }

        [DataMember]
        public decimal InvoicedPaidQuantity { get; set; }

        [DataMember]
        public decimal ValidateInvoiceAmount { get; set; }

        [DataMember]
        public decimal OrderShipping { get; set; }

        [DataMember]
        public decimal OrderAdditionalCharges { get; set; }

        [DataMember]
        public decimal OrderTax { get; set; }

        [DataMember]
        public Cumulus.Documents.Entities.DocumentStatus OrderStatus { get; set; }

        [DataMember]
        public int ClosingOrderStatus { get; set; }

        [DataMember]
        public int OrderSourceSystemId { get; set; }

        [DataMember]
        public long IsOrderAndInvoiceContactSame { get; set; }

        [DataMember]
        public int OrderPurchaseType { get; set; }

        [DataMember]
        public long BlanketDocumentCode { get; set; }

        [DataMember]
        public long SubmittedBy { get; set; }

        [DataMember]
        public int OrderLinkedDocumentTypeCode { get; set; }

        [DataMember]
        public decimal OrderTotal { get; set; }

        [DataMember]
        public decimal InvoicingTax { get; set; }

        [DataMember]
        public decimal UsedTax { get; set; }

        [DataMember]
        public List<InvoiceError> ErrorList { get; set; }

        //start : added for save bulk invoices from Excel

        [DataMember]
        public string ItemTypeName { get; set; }

        [DataMember]
        public string InvoiceStartDate { get; set; }

        [DataMember]
        public string InvoiceEndDate { get; set; }

        [DataMember]
        public string UnitsDesc { get; set; }

        //End : added for save bulk invoices from Excel

        [DataMember]
        public DateTime OrderDate { get; set; }

        [DataMember]
        public int ReferenceNumber { get; set; }

        [DataMember]
        public int ShiptoLocationId { get; set; }

        [DataMember]
        public int DelivertoLocationId { get; set; }

        [DataMember]
        public string IsTaxExemptText { get; set; }

        [DataMember]
        public string ItemTypeText { get; set; }

        [DataMember]
        public string TaxText { get; set; }

        [DataMember]
        public string UnitPriceText { get; set; }

        [DataMember]
        public decimal TotalRecoupmentamount { get; set; }

        [DataMember]
        public decimal RemainingAdvanceAmount { get; set; }

        [DataMember]
        public decimal OrderAdvanceAmount { get; set; }

        [DataMember]
        public decimal AvailableAdvanceAmount { get; set; }

        [DataMember]
        public string CountryCode { get; set; }

        [DataMember]
        public int LineTaxCodeCount { get; set; }

        [DataMember]
        public string TaxCodes { get; set; }

        [DataMember]
        public List<Taxes> lstTaxes { get; set; }

        [DataMember]
        public decimal? TotalCharge { get; set; }

        [DataMember]
        public decimal? TotalAllowance { get; set; }

        [DataMember]
        public string CurrencyCode { get; set; }

        [DataMember]
        public string PaymentTermCode { get; set; }

        [DataMember]
        public DelivertoLocation DelivertoLocation { get; set; }

        [DataMember]
        public string OrderNumber { get; set; }

        [DataMember]
        public LocationDetails OrderingLocation { get; set; }

        [DataMember]
        public long orderId { get; set; }

        [DataMember]
        public long OrderDocumentCode { get; set; }

        [DataMember]
        public string OrderDocumentNumber { get; set; }

        [DataMember]
        public string OrderLineItemRevisionNumber { get; set; }

        [DataMember]
        public int InternalLineNumber { get; set; }

        [DataMember]
        public IdNameAndAddress ShipFromLocation { get; set; }

        [DataMember]
        public decimal ExternalTax { get; set; }

        //[DataMember]
        //public List<ExternalTaxesOld> ExternalTaxes { get; set; }

        [DataMember]
        public List<CustomFieldInfo> lstCustomFields { get; set; }

        [DataMember]
        public string FulfilmentDocumentNumber { get; set; }

        [DataMember]
        public string FulfilmentDocumentType { get; set; }

        [DataMember]
        public int FulfillmentDocumentLineNumber { get; set; }

        [DataMember]
        public bool? IsContractedLine { get; set; }

        [DataMember]
        public bool? PriceBookStatus { get; set; }

        [DataMember]
        public PartnerLocation ShipFromLocationInterface { get; set; }


        [DataMember]
        public decimal? MatchedItemValue { get; set; }


        private bool isDisposed;
        private IntPtr nativeResource = Marshal.AllocHGlobal(100);

        // Dispose() calls Dispose(true)
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // The bulk of the clean-up code is implemented in Dispose(bool)
        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed) return;

            // free native resources if there are any.
            if (nativeResource != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(nativeResource);
                nativeResource = IntPtr.Zero;
            }

            isDisposed = true;
        }


    }
}