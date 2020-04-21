using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class ErrorDetails
    {
        public long DocumentCode { get; set; }
        public List<InvoiceError> ErrorList { get; set; } // header level error list
        public List<ErrorItem> Items { get; set; } // line level errors
    }

    public class ErrorItem
    {
        public long DocumentCode { get; set; }
        public long DocumentItemId { get; set; }
        public long LineNumber { get; set; }
        public List<InvoiceError> ErrorList { get; set; }
    }
}