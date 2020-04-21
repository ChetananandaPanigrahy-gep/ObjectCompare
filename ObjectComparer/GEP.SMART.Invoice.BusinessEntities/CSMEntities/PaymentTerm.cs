using System;
using System.Collections.Generic;
using System.Text;

namespace GEP.SMART.Invoice.BusinessEntities.CSMEntities
{
    public class PaymentTerm
    {
        public int PaymentTermId { get; set; }
        public string PaymentTermName { get; set; }
        public bool IsDefault { get; set; }
        public int? NoOfDays { get; set; }
    }
}
