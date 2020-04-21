using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class CustomAttribute
    {
        public List<Cumulus.QuestionBank.Entities.QuestionResponse> headerCustomAttributes;
        public List<CustomAttributeItems> itemCustomAttributes;
    }

    public class CustomAttributeItems
    {
        public long DocumentItemId;
        public long LineNumber;
        public List<Cumulus.QuestionBank.Entities.QuestionResponse> ListQuestionResponse;
    }
}