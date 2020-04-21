using GEP.SMART.Invoice.BusinessEntities.ExportDataSetEntities;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class ExportReceipt : Export
    {
        public ReceiptDataSet ReceiptDataSet { get; set; }
    }
}