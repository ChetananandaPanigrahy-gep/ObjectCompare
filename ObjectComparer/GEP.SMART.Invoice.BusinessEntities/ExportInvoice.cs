using GEP.SMART.Invoice.BusinessEntities.ExportDataSetEntities;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class ExportInvoice : Export
    {
        public InvoiceDataSet InvoiceDataSet { get; set; }
    }
}