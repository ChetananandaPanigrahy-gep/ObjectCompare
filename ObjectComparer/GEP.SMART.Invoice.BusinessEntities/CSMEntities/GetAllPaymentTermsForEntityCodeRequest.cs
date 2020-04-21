using System;
using System.Collections.Generic;
using System.Text;

namespace GEP.SMART.Invoice.BusinessEntities.CSMEntities
{
    public class GetAllPaymentTermsForEntityCodeRequest
    {

        public long LOBEntityDetailCode { get; set; } = -1;

        public string CultureCode { get; set; }

        public long EntityDetailCode { get; set; } = -1;

        public long PartnerCode { get; set; } = -1;

        public string SearchText { get; set; }

        public int PageIndex { get; set; } = 0;

        public int PageSize { get; set; } = 0;

        public bool IsPartnerSpecific { get; set; }
    }
}
