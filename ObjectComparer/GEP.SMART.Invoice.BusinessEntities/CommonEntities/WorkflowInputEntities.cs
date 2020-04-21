using REDataModel;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities.Old
{
    [KnownType(typeof(RuleAction))]
    [System.Xml.Serialization.XmlInclude(typeof(RuleAction))]
    public class WorkflowInputEntities
    {
        public List<long> lstApprovers { get; set; }
        public List<RuleAction> RuleAction { get; set; }
    }
}