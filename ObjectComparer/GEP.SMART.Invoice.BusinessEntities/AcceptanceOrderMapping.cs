namespace GEP.SMART.Invoice.BusinessEntities
{
    public class AcceptanceOrderMapping
    {
        public AcceptanceOrderMapping()
        {
        }

        public AcceptanceOrderMapping(long orderId, int contactType, long submittedTo, int matchStatus, long itemId, long acceptOrderMapId = 0, long acceptanceOrderId = 0, bool isDeleted = false, int minAcceptanceRequired = 0)
        {
            OrderId = orderId;
            ContactType = contactType;
            SubmittedTo = submittedTo;
            MatchStatus = matchStatus;
            ItemId = itemId;
            AcceptOrderMapId = acceptOrderMapId;
            AcceptanceOrderId = acceptOrderMapId;
            IsDeleted = isDeleted;
            MinAcceptanceRequired = minAcceptanceRequired;
        }

        public long AcceptOrderMapId { get; set; }
        public long AcceptanceOrderId { get; set; }
        public long OrderId { get; set; }
        public int ContactType { get; set; }
        public long SubmittedTo { get; set; }
        public bool IsDeleted { get; set; }
        public int MatchStatus { get; set; }
        public long ItemId { get; set; }
        public int MinAcceptanceRequired { get; set; }
    }
}