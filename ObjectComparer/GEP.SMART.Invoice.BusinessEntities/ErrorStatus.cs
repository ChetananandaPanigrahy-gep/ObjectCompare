namespace GEP.SMART.Invoice.BusinessEntities
{
    public class ErrorStatus
    {
        public int ErrorStatusId { get; set; }
        public string EnumName { get; set; }
        public string DisplayName { get; set; }
        public string ClientErrorCode { get; set; }
        public string MappedControlName { get; set; }
        public string Operator { get; set; }
        public string ComparisonValue { get; set; }
        public bool IsComputational { get; set; }
        public bool IsResolvable { get; set; }
        public bool IsActive { get; set; }
        public bool IsMandatory { get; set; }
        public int LineItemNumber { get; set; }
    }
}