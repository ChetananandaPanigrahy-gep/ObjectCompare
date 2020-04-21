using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class QuestionnaireResponse
    {
        public List<Questionnaire> ChildQuestionSets { get; set; }

        [DataMember]
        public long ChildQuestionSetCode { get; set; }

        [DataMember]
        public string ColumnText { get; set; }

        [DataMember]
        public long QuestionId { get; set; }

        [DataMember]
        public string ResponseValue { get; set; }

        [DataMember]
        public long RowId { get; set; }
    }
}