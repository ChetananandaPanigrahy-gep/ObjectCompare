using REDataModel;

namespace GEP.SMART.Invoice.BusinessEntities.Requests
{
    public class SubmissionCheckRequest
    {
        public long DocumentCode { get; set; }
        public int DocumentTypeId { get; set; }
        public BusinessCase BusinessCase { get; set; } = BusinessCase.SubmissionCheck;
        public string ValidationTypes { get; set; } = string.Empty;
    }
}