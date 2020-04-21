using Gep.Cumulus.CSM.Entities;
using GEP.Cumulus.Documents.Entities;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace GEP.SMART.Invoice.BusinessEntities.Requests
{
    [ExcludeFromCodeCoverage]
    public class InvoiceProcessingRequest
    {
        public long DocumentId { get; set; }
        public Invoice InvObj { get; set; }
        public bool IsInvoiceBlock { get; set; }
        public bool IsMultiPO { get; set; }
        public int OrderSource { get; set; }
        public long LOBEntityDetailCode { get; set; }
        public long OrderId { get; set; }
        public List<long> OrderIds { get; set; }
        public long PartnerCode { get; set; }
        public bool IsSystemAcknowledged { get; set; }
        public bool IsERS { get; set; }
        public long ReceiptId { get; set; }
        public DocumentSourceType DocumentSourceTypeInfo { get; set; } = DocumentSourceType.None;
        public DocumentType FulfilmentDocType { get; set; } = DocumentType.None;
        public long InvoiceId { get => this.DocumentId; set => this.DocumentId = value; }
        public bool FailedInvoiceProcess { get; set; }
    }
}