using Gep.Cumulus.CSM.Entities;
using GEP.Cumulus.Documents.Entities;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class MatchDocument
    {
        public long DocumentId { get; set; }

        public DocumentType DocumentType { get; set; }

        public long PartnerStatus { get; set; }

        public int MatchDocumentId { get; set; }

        public MatchStatus MatchDocumentStatus { get; set; }

        public MatchType MatchType { get; set; }

        public decimal? Tax { get; set; }

        public decimal? ExternalTax { get; set; }

        public decimal? Shipping { get; set; }

        public decimal? ItemTotal { get; set; }

        public decimal? TotalAmount { get; set; }

        public decimal? Charges { get; set; }

        public decimal MatchedTax { get; set; }

        public decimal MatchedShipping { get; set; }

        public decimal MatchedItemTotal { get; set; }

        public decimal MatchedTotalAmount { get; set; }

        public decimal MatchedCharges { get; set; }

        public ToleranceDetails ToleranceDetails { get; set; }

        public bool AllowStatusUpdate { get; set; }

        public int ExtendedStatus { get; set; }

        public int DocumentStatus { get; set; }
        public DocumentSourceType DocumentSourceType { get; set; }

        public decimal MatchedAdvanceTotal { get; set; }

        public decimal MatchedAdjustmentTotal { get; set; }

        public decimal MatchedRecoupmentRate { get; set; }

        public decimal AdvanceTotal { get; set; }

        public decimal AdjustmentTotal { get; set; }

        public decimal RecoupmentRate { get; set; }

        public long OrderId { get; set; }

        public int FulfilmentDocumentType { get; set; }
        public long FulfilmentDocumentCode { get; set; }

        public decimal? TotalAmountForAggregation { get; set; }

        public decimal AggregatedTotalAmount { get; set; }

        public decimal ExchangeRate { get; set; }
    }
}