namespace GEP.SMART.Invoice.BusinessEntities
{
    public class ItemDetails
    {
        public string CurrencyCode { get; set; }
        public long InvoiceLineItemId { get; set; }
        public long P2PLineItemID { get; set; }
        public string ItemNumber { get; set; }
        public string Description { get; set; }
        public long CategoryID { get; set; }
        public int ItemTypeID { get; set; }
        public string ItemType { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public string UOM { get; set; }
        public decimal Total { get; set; }
        public decimal RemainingAmount { get; set; }
    }
}