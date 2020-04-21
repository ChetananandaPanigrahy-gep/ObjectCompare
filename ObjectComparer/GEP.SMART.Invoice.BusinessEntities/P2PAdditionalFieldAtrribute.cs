using System;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class P2PAdditionalFieldAtrribute
    {
        public int AdditionalFieldID { get; set; }

        public string AdditionalFieldValue { get; set; }

        public string AdditionalFieldCode { get; set; }
        public string AdditionalFieldName { get; set; }

        public int FeatureId { get; set; }

        public Int64 AdditionalFieldDetailCode { get; set; }

        public int FieldOrder { get; set; }

        public bool isDeleted { get; set; }
    }
}