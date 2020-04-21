using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class InvoiceTemplateResponse
    {
        [DataMember]
        public long FileId { get; set; }

        [DataMember]
        public long ProcessedFileId { get; set; }

        [DataMember]
        public string StatusCode { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string EncryptedDD { get; set; }
    }
}