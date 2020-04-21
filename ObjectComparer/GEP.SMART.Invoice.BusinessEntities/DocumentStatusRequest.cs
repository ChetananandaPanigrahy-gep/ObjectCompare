using Gep.Cumulus.CSM.Entities;
using GEP.Cumulus.Documents.Entities;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class DocumentStatusRequest
    {
        public P2PDocumentType DocType { get; set; }

        public long DocumentId { get; set; }

        public DocumentStatus DocumentStatus { get; set; }

        public decimal PartnerCode { get; set; }

        public bool IsInterface { get; set; }

        public POTransmissionMode POTransmissionMode { get; set; }

        public string POTransmissionValue { get; set; }

        public string OrderSource { get; set; }

        public int SourceSystemId { get; set; }

        public bool IsAutoCreatedOrder { get; set; }

        public bool Resent { get; set; }

        public bool EmailBlockingforSupplier { get; set; }

        public bool IsAcknowledgeByBuyer { get; set; }

        public List<Comments> CommentList { get; set; }

        public bool IsBuyerInvoiceVisibleToSupplier { get; set; }
    }
}