using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace GEP.SMART.Invoice.BusinessEntities.Requests
{
    [ExcludeFromCodeCoverage]
    public class SubmitInvoicetoBuyerRequest
    {
        public bool IsMultiPO { get; set; }
        public BusinessEntities.Invoice Invoice { get; set; }
        public long? BuyerId { get; set; }
        public long InvoiceId { get; set; }
        public long BuyerPartnerCode { get; set; }
        public string QueryString { get; set; }
        public bool? IsInvoiceBlock { get; set; }
        public long OrderDocumentCode { get; set; }
        public long DocumentCode { get; set; }
        public InvoiceSource InvoiceSource { get; set; } = InvoiceSource.OrderInvoice;
        public long ImageId { get; set; }
        public List<DocumentAdditionalEntityInfo> lstDocumentAdditionalEntityInfo { get; set; }
        public BusinessEntities.Invoice InvoiceData { get; set; }
        public long LOBEntityDetailCode { get; set; }
    }
}