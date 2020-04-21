using System.Collections.Generic;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class CustomAttrWrapper
    {
        public long DocumentCode { get; set; }
        public ICollection<CustomAttr> CustomAttributes { get; set; }
        public ICollection<CustomAttrAttachment> CustomAttrAttachments { get; set; }
    }
}