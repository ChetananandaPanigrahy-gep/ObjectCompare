using Gep.Cumulus.CSM.Entities;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class SendInvoiceVM
    {
        public long DocumentId { get; set; }
        public bool IsInvoiceBlock { get; set; }
        public long OrderId { get; set; }
        public int OrderSource { get; set; }
        public long PartnerCode { get; set; }
        public bool IsSystemAcknowledged { get; set; }
        public UserExecutionContext UserExecutionContext { get; set; }
        public List<long> OrderIdList { get; set; }
        public bool isMultiPO { get; set; }
        public BusinessEntities.Invoice InvObj { get; set; }
    }
}