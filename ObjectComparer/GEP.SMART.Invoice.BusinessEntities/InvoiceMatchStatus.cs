using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public delegate void GetResolver(BusinessEntities.Old.Invoice objInvoice, long Id, InvoiceExtendedMatchStatus matchStatus);

    public class InvoiceMatchStatus
    {
        public InvoiceMatchStatus()
        { }

        public InvoiceMatchStatus(InvoiceMatchStatus i)
        {
            MatchStatus = i.MatchStatus;
            MatchLevel = i.MatchLevel;
            ExceptionTypeId = i.ExceptionTypeId;
            MatchName = i.MatchName;
            MatchDisplayName = i.MatchDisplayName;
            IsOverridable = i.IsOverridable;
            Id = i.Id;
            InvoiceId = i.InvoiceId;
            InvoiceItemId = i.InvoiceItemId;
            ResolverType = i.ResolverType;
        }

        [DataMember]
        public int MatchStatus { get; set; }

        [DataMember]
        public int MatchLevel { get; set; }

        [DataMember]
        public int ExceptionTypeId { get; set; }

        [DataMember]
        public string MatchName { get; set; }

        [DataMember]
        public string MatchDisplayName { get; set; }

        [DataMember]
        public bool IsOverridable { get; set; }

        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public long InvoiceId { get; set; }

        [DataMember]
        public long InvoiceItemId { get; set; }

        [DataMember]
        public int? ResolverType { get; set; }

        [DataMember]
        public int ExceptionTotal { get; set; }

        [DataMember]
        public bool IsExceptionFullyAccepted { get; set; }
    }

    public class InvoiceExtendedMatchStatus : InvoiceMatchStatus
    {
        public InvoiceExtendedMatchStatus()
        {
        }

        public InvoiceExtendedMatchStatus(InvoiceMatchStatus i) : base(i)
        {
        }

        public int resolverId { get; set; }        //need to remove
        public RuleParameterTypes ruleParamterType { get; set; }
        public List<KeyValuePair<long, long>> resolvers { get; set; }
        public GetResolver getResolverEvent;
        public int minAcceptanceRequired { get; set; }   //for parallel routing acceptance will be at exception level
    }
}