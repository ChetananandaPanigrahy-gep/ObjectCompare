using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class InvoiceExceptionOverride
    {
        [DataMember]
        public int MatchStatus { get; set; }

        [DataMember]
        public bool OverrideFlag { get; set; }

        [DataMember]
        public bool IsOverridable { get; set; }
    }
}