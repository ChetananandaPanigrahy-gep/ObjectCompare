namespace GEP.SMART.Invoice.BusinessEntities
{
    public class SaveInvoiceFromScanImage
    {
        public long imageId { get; set; }
        public long documentCode { get; set; }
        public long userId { get; set; }
        public int p2pDocumentSource { get; set; }
        public int p2pDocumentOrigin { get; set; }
    }
}