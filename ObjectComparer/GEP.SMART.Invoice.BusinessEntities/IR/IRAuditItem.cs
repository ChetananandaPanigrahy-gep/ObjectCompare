namespace GEP.SMART.Invoice.BusinessEntities.IR
{
    public class IRAuditItem
    {
        public long InvoiceItemId { get; set; }

        public IdAndName category { get; set; }

        public IdNameAndAddress shipTo { get; set; }

        public IdNameAndAddress ShipFromLocation { get; set; }
    }
}