namespace GEP.SMART.Invoice.BusinessEntities
{
    public class PaymentDeliveryDetails
    {
        public PaymentDeliveryDetails()
        {
            ShipTo = new IdNameAndAddress() { name = "", nameandnumber = "", address = "" };
            BillTo = new IdNameAddressAndContact() { name = "", nameandnumber = "", address = "" };
            DeliverTo = new IdNameAndAddress() { name = "", nameandnumber = "", address = "" };
        }

        public long DocumentCode { get; set; }
        public IdNameAndAddress ShipTo { get; set; }
        public IdNameAddressAndContact BillTo { get; set; }
        public IdNameAndValue PaymentTerms { get; set; }
        public IdNameAndAddress DeliverTo { get; set; }
        public string OrderContactEmail { get; set; }
        public string DeliverToStr { get; set; }
    }
}