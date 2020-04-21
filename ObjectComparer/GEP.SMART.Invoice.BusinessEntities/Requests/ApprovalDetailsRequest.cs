namespace GEP.SMART.Invoice.BusinessEntities.Requests
{
    public class ApprovalDetailsRequest
    {
        public string InstanceId { get; set; }
        public bool IsInstanceActive { get; set; }
        public string Currency { get; set; }
        public int WfDocTypeId { get; set; }
        public long DocumentCode { get; set; }
        public decimal DocumentAmount { get; set; }
    }
}