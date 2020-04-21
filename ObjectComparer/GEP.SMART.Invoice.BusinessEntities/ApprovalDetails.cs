using GEP.Cumulus.Documents.Entities;
using GEP.SMART.Invoice.BusinessEntities.Requests;
using REDataModel;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class ApprovalDetails : ApprovalDetailsRequest
    {
        public int DocumentTypeId { get; set; }
        public BusinessCase BusinessCase { get; set; }
        public DocumentStatus ApprovalStatus { get; set; } = DocumentStatus.None;
        public BusinessEntities.Old.InvoiceReconciliation Document { get; set; }
        public List<RuleAction> Actions { get; set; }
    }
}