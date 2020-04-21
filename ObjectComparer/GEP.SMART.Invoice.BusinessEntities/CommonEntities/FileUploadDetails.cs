using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class FileUploadDetails
    {
        [DataMember]
        public long FileId { get; set; }

        [DataMember]
        public string FileName { get; set; }

        [DataMember]
        public string FileUri { get; set; }

        [DataMember]
        public string FileContentType { get; set; }

        [DataMember]
        public string FileExtension { get; set; }
    }
}