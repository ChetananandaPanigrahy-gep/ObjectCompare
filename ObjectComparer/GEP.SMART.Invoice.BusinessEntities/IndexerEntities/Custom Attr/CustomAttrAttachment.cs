using Newtonsoft.Json;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class CustomAttrAttachment : IAttachment
    {
        [JsonIgnore]
        public long AttachmentId { get; set; }

        public string FileName { get; set; }
        public long DocumentCode { get; set; }
        public string Content { get; set; }
    }
}