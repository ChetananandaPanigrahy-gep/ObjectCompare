using System;
using System.Linq;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class DM_DocumentAdditionalFields
    {
        private const byte ADDITIONAL_FIELD_CONTACT_TYPE = 4;
        public long DocumentCode { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public bool IsDeleted { get; set; }
        public int FieldType { get; set; }
        public string ContactName { get; set; }

        public long ContactCodeTop
        {
            get
            {
                if (FieldType == ADDITIONAL_FIELD_CONTACT_TYPE && !string.IsNullOrEmpty(FieldValue) && FieldValue != "0")
                {
                    return Convert.ToInt64(FieldValue.Split(',').FirstOrDefault());
                }
                return 0;
            }
        }

        public string ContactDisplayName
        {
            get
            {
                if (FieldType == ADDITIONAL_FIELD_CONTACT_TYPE && FieldValue != "0")
                {
                    var retName = ContactName;
                    var count = FieldValue.Split(',').Count();
                    if (count > 1)
                    {
                        retName += " + (" + (count - 1) + " more)";
                    }
                    return retName;
                }
                return null;
            }
        }
    }
}