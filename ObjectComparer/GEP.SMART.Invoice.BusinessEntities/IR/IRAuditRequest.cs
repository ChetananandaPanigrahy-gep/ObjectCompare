namespace GEP.SMART.Invoice.BusinessEntities.IR
{
    public class IRAuditRequest
    {
        public long irId { get; set; }

        public IRAudit irAudit { get; set; }
    }
}