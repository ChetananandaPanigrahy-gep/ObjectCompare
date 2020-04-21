using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class CustomAttrs
    {
        public CustomAttrs()
        {
            CustomAttrQuestionSetCodesForHeader = new List<KeyValuePair<long, string>>();
            CustomAttrQuestionSetCodesForItem = new List<KeyValuePair<long, string>>();
            CustomAttrQuestionSetCodesForSplit = new List<KeyValuePair<long, string>>();
        }

        public long CustomAttrFormIdForHeader { get; set; }

        public long CustomAttrFormIdForItem { get; set; }

        public long CustomAttrFormIdForSplit { get; set; }

        public List<KeyValuePair<long, string>> CustomAttrQuestionSetCodesForHeader { get; set; }

        public List<KeyValuePair<long, string>> CustomAttrQuestionSetCodesForItem { get; set; }

        public List<KeyValuePair<long, string>> CustomAttrQuestionSetCodesForSplit { get; set; }
    }
}