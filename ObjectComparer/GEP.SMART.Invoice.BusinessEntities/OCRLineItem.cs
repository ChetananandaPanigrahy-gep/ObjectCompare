namespace GEP.SMART.Invoice.BusinessEntities
{
    public class OCRLineItem
    {
        public decimal Quantity { get; set; }

        public string UnitPrice { get; set; }

        public string Tax { get; set; }

        public string Description { get; set; }

        public int LineNumber { get; set; }

        public string SupplierPartId { get; set; }

        public string ManufacturerName { get; set; }

        public string ManufacturerPartNumber { get; set; }

        public string ManufacturerModel { get; set; }

        public string UOM { get; set; }

        public string ShippingCharges { get; set; }

        public string ContractNo { get; set; }

        public string Discount { get; set; }

        public string BuyerItemNumber { get; set; }

        public string Category { get; set; }

        public int P2PLineItemId { get; set; }

        public string TaxCode { get; set; }
    }
}