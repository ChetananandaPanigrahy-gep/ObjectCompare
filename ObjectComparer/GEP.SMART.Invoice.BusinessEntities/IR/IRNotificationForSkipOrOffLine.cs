using Gep.Cumulus.CSM.Entities;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.IR
{
    public class NotificationForSkipOrOffLine
    {
        public long DocumentCode { get; set; }
        public List<ApproverDetails> Approvers { get; set; }
        public int SkipType { get; set; } = 0;
        public bool IsOffLine { get; set; } = false;
        public long ActionarId { get; set; } = 0;
    }
}