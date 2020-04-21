using System;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class AcceptanceLog
    {
        public long AcceptanceLogId { get; set; }
        public string InstanceId { get; set; }
        public long DocumentCode { get; set; }
        public long ActionerId { get; set; }
        public long ProxyActionerId { get; set; }
        public string ProxyActionerName { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Status { get; set; }
        public DateTime StatusDate { get; set; }
        public long CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public DateTime DateCreated { get; set; }
        public int LevelNo { get; set; }
        public string ExceptionType { get; set; }
        public string ResolverType { get; set; }
        public string PreviousResolverType { get; set; }
        public ActionerType ActionerType { get; set; }
    }
}