using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class InvoiceSections
    {
        public List<FileUploadDetails> ScannedImageDetails { get; set; }
        public BasicDetails InvoiceBasicDetails { get; set; }
        public ErrorDetails ErrorDetails { get; set; }
        public ExceptionDetails ExceptionType { get; set; }
        public SupplierDetails SupplierDetails { get; set; }
        public StakeholderDetails StakeholderDetails { get; set; }
        public PaymentDeliveryDetails PaymentDeliveryDetails { get; set; }
        public RemittanceDetails RemittanceDetails { get; set; }
        public CustomAttribute CustomAttribute { get; set; }
        public LineAndAccountingDetails LineAndAccountingDetails { get; set; }
    }
}