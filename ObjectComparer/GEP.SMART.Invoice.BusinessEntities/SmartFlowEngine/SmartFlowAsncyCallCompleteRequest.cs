using System;
using System.Collections.Generic;
using System.Text;

namespace GEP.SMART.Invoice.BusinessEntities.SmartFlowEngine
{
    public class SmartFlowAsncyCallCompleteRequest
    {
        public string SFEStatusId { get; set; }

        public string Status { get; set; }

        public string Message { get; set; }
    }
}
