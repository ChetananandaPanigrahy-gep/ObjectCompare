using Gep.Cumulus.CSM.Entities;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.IR
{
    public class IRApproval
    {
        public string EventName { get; set; }
        public long DocumentCode { get; set; }
        public string DocumentStatus { get; set; }
        public int WfDocTypeId { get; set; }
        public long ContactCode { get; set; }
        public string UserStatus { get; set; }
        public string ApprovalType { get; set; }
        public string ReturnEntity;
        public List<ApproverDetails> ApproverDetails { get; set; }
        public int SkipType { get; set; } = 0;
        public bool IsOffLine { get; set; } = false;
        public long ActionarId { get; set; } = 0;
    }
}