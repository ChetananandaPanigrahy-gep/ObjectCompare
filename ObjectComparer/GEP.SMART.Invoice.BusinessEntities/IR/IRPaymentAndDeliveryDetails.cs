using Gep.Cumulus.CSM.Entities;

namespace GEP.SMART.Invoice.BusinessEntities.IR
{
    public class IRPaymentAndDeliveryDetails
    {
        public ContactDetails ShipTo { get; set; }
        public ContactDetails BillTo { get; set; }
        public ContactDetails DeliverTo { get; set; }
        public string DeliverToStr { get; set; }
        public PaymentTermDetails PaymentTerms { get; set; }
    }
}