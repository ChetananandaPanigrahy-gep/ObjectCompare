using System;
using System.Collections.Generic;
using System.Text;

namespace GEP.SMART.Invoice.BusinessEntities.CSMEntities
{
    public class EntityNumberRequest
    {
        public string EntityType { get; set; }
        public long LOBId { get; set; }
        public long EntityDetailCode { get; set; }
        public int PurchaseTypeID { get; set; }
    }
}
