using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.ExportDataSetEntities
{
    public class IRDataSet
    {
        public List<IR> IR { get; set; }
        public List<HeaderLevelCharges> HeaderLevelCharges { get; set; }
        public List<IRHeaderException> IRHeaderException { get; set; }
        public List<IRLineItemException> IRLineItemException { get; set; }
        public List<SublineLevelCharges> SublineLevelCharges { get; set; }
    }

    public class IR
    {
        public string OrderNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string PartnerInvoiceNumber { get; set; }
        public string PartnerInvoiceDate { get; set; }
        public string PaymentTerms { get; set; }
        public long RemittoLocationId { get; set; }
        public bool RemittoLocationIdSpecified { get; set; }
        public string BuyerName { get; set; }
        public string IRCreatedDate { get; set; }
        public string RemitToLocationName { get; set; }
        public string RemitToAddressline1 { get; set; }
        public string RemitToAddressline2 { get; set; }
        public string RemitToAddressline3 { get; set; }
        public string RemitToZip { get; set; }
        public string RemitToCountryName { get; set; }
        public string RemitToState { get; set; }
        public string RemitToCity { get; set; }
        public string IRType { get; set; }
        public string IdentificationValue { get; set; }
        public string SupplierIdentificationValue { get; set; }
        public string ERPInvoiceNumber { get; set; }
        public string ScheduledPaymentDate { get; set; }
        public string TimeSheetNumber { get; set; }
    }

    public class IRHeaderException
    {
        public int MatchStatus { get; set; }
        public bool MatchStatusSpecified { get; set; }
    }

    public class IRLineItemException
    {
        public long IRItemId { get; set; }
        public bool IRItemIdSpecified { get; set; }
        public int MatchStatus { get; set; }
        public bool MatchStatusSpecified { get; set; }
    }
}