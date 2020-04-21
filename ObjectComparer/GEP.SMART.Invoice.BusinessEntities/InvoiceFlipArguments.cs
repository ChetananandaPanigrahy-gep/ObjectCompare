using Gep.Cumulus.CSM.Entities;
using GEP.Cumulus.Documents.Entities;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class InvoiceFlipArguments
    {
        public long orderId { get; set; }
        public int userType { get; set; }
        public long userId { get; set; }
        public DocumentType FulfilmentDocType { get; set; }
        public string lstFulfilmentDocs { get; set; }
        public int invoiceType { get; set; }
        public long partnerCode { get; set; }
        public bool autoCreateInvoice { get; set; }
        public DocumentSourceType DocumentSourceTypeInfo { get; set; }
        public long RemitToLocationId { get; set; }
    }
}