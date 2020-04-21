using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class OCRFieldMapping
    {
        public long ScannedImageId { get; set; }
        public long FileId { get; set; }
        public IDictionary<string, string> FieldMapper { get; set; }
        public string BUList { get; set; }
        public long LOBEntityDetailCode { get; set; }
    }
}