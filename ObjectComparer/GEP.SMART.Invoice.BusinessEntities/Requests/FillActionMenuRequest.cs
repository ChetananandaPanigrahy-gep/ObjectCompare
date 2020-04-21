using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.Requests
{
    public class FillActionMenuRequest : ActionMenuRequest
    {
        public List<string> CurrentSteps { get; set; }

        public string UserAccessType { get; set; }
    }
}