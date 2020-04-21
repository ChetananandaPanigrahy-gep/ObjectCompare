using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.IR
{
    public class IRAudit
    {
        public IdNameAndAddress shipTo { get; set; }

        public IdNameAndAddress orderingLocation { get; set; }

        public List<IRAuditItem> items { get; set; }
    }
}