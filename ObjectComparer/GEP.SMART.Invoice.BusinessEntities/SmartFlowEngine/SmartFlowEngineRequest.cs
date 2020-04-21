namespace GEP.SMART.Invoice.BusinessEntities.SmartFlowEngine
{
    public class SmartFlowEngineRequest
    {
        public string SmartflowId { get; set; }

        public string BuyerPartnerCode { get; set; }

        public string TransactionId { get; set; }

        public string StageId { get; set; }

        public string StageName { get; set; }

        public string ActivityId { get; set; }

        public string ActivityName { get; set; }

        public string BatchIndex { get; set; }

        public string BatchOccurrence { get; set; }

        public string SFEClaimCheckId { get; set; }

        public string SmartFlowType { get; set; }

        public string SEFStatusId { get; set; }
    }
}