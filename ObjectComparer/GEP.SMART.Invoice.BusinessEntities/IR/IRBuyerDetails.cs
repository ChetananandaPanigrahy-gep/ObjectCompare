namespace GEP.SMART.Invoice.BusinessEntities.IR
{
    public class IRBuyerDetails
    {
        public string BuyerCompanyName { get; set; }
        public ContactDetails OrderContact { get; set; }
        public VATValues VAT { get; set; }
    }
}