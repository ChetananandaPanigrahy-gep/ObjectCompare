namespace GEP.SMART.Invoice.BusinessEntities.IR
{
    public class IRSupplierDetails
    {
        public Partner Partner { get; set; }
        public ContactDetails OrderingLocation { get; set; }
        public ContactDetails PartnerContact { get; set; }
        public ContactDetails RemittoLocation { get; set; }
        public string ClientPartnerCode { get; set; }
        public string SupplierIdentificationValue { get; set; }
    }
}