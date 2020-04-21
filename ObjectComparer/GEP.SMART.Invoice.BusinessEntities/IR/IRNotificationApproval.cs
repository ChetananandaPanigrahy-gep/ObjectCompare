using Gep.Cumulus.CSM.Entities;
using GEP.Cumulus.Documents.Entities;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.IR
{
    public class NotificationIRApproval
    {
        public long DocumentCode { get; set; }
        public List<ApproverDetails> PendingApprover { get; set; }
        public List<ApproverDetails> PastApprover { get; set; }
        public string EventName { get; set; }
        public DocumentStatus DocumentStatus { get; set; }
        public string ApprovalType { get; set; }
    }
}