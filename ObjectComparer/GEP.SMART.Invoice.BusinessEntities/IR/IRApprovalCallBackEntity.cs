namespace GEP.SMART.Invoice.BusinessEntities.IR
{
    public class ApprovalCallBackEntity
    {
        public string EventName { get; set; }
        public long DocumentCode { get; set; }
        public string DocumentStatus { get; set; }
        public int WfDocTypeId { get; set; }
        public long ContactCode { get; set; }
        public string UserStatus { get; set; }
        public string ApprovalType { get; set; }
        public string ReturnEntity { get; set; }
        public string HierarchyIds { get; set; } = null;
    }
}