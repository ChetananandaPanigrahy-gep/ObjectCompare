namespace GEP.SMART.Invoice.BusinessEntities
{
    public class OrderLineInfo : OrderInfo
    {
        public long OrderLineNumber { get; set; }
        public decimal OrderedQuantity { get; set; }
        public decimal? OrderUnitPrice { get; set; }
        public decimal OrderItemTax { get; set; }
    }
}