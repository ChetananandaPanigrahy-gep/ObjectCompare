using GEP.Cumulus.Documents.Entities;

namespace GEP.SMART.Invoice.BusinessEntities.IR
{
    public class AcceptRejectByMail
    {
        public long ContactCode { get; set; }
        public long DocumentCode { get; set; }
        public ActionKey Actionkey { get; set; }
        public MatchStatus MatchStatus { get; set; } = MatchStatus.None;
        public long LobEntityDetailCode { get; set; } = 0;
    }
}