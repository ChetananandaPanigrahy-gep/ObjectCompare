using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.ExportDataSetEntities
{
    public class InvoiceDataSet
    {
        public List<BillToLocationRegistrationDetails> BillToLocationRegistrationDetails { get; set; }
        public List<HeaderLevelCharges> HeaderLevelCharges { get; set; }
        public List<Invoice> Invoice { get; set; }
        public List<InvoiceHeaderException> InvoiceHeaderException { get; set; }
        public List<InvoiceLineItemException> InvoiceLineItemException { get; set; }
        public List<OrderLocationRegistrationDetails> OrderLocationRegistrationDetails { get; set; }
        public List<SublineLevelCharges> SublineLevelCharges { get; set; }
        public List<TaxBaseDetails> TaxBaseDetails { get; set; }
    }

    public class BillToLocationRegistrationDetails
    {
        public string CompanyIdentificationDisplayName { get; set; }
        public string CompanyIdentification { get; set; }
    }

    public class Invoice
    {
        public string OrderNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string PartnerInvoiceNumber { get; set; }
        public string PartnerInvoiceDate { get; set; }
        public string PaymentTerms { get; set; }
        public long RemittoLocationId { get; set; }
        public bool RemittoLocationIdSpecified { get; set; }
        public string BuyerName { get; set; }
        public string RemitToLocationName { get; set; }
        public string RemitToAddressline1 { get; set; }
        public string RemitToAddressline2 { get; set; }
        public string RemitToAddressline3 { get; set; }
        public string RemitToZip { get; set; }
        public string RemitToCountryName { get; set; }
        public string RemitToState { get; set; }
        public string RemitToCity { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceCreatedDate { get; set; }
        public string InvoiceReceviedOn { get; set; }
        public string OrderName { get; set; }
        public string ErrorJson { get; set; }
        public string IdentificationValue { get; set; }
        public string SupplierIdentificationValue { get; set; }
        public string OrderSubmittedDate { get; set; }
        public string PartnerImageUrl { get; set; }
        public string Rebillable { get; set; }
        public string DueDate { get; set; }
        public string ERPInvoiceNumber { get; set; }
        public string ScheduledPaymentDate { get; set; }
        public string TimeSheetNumber { get; set; }
    }

    public class InvoiceHeaderException
    {
        public int MatchStatus { get; set; }
        public bool MatchStatusSpecified { get; set; }
    }

    public class InvoiceLineItemException
    {
        public long InvoiceItemId { get; set; }
        public bool InvoiceItemIdSpecified { get; set; }
        public int MatchStatus { get; set; }
        public bool MatchStatusSpecified { get; set; }
    }

    public class OrderLocationRegistrationDetails
    {
        public string CompanyIdentificationDisplayName { get; set; }
        public string CompanyIdentification { get; set; }
    }

    public class TaxBaseDetails
    {
        public string TaxCode { get; set; }
        public string TaxDescription { get; set; }
        public decimal TaxRate { get; set; }
        public bool TaxRateSpecified { get; set; }
        public decimal TaxAmount { get; set; }
        public bool TaxAmountSpecified { get; set; }
        public decimal TaxBase { get; set; }
        public bool TaxBaseSpecified { get; set; }
    }
}