using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class FulfilmentDocumentInfo
    {
        [DataMember]
        public long InvoiceItemId { get; set; }

        [DataMember]
        public long FulfilmentDocumentItemId { get; set; }

        [DataMember]
        public long FulfilmentDocumentCode { get; set; }

        [DataMember]
        public string FulfilmentDocumentNumber { get; set; }

        [DataMember]
        public string FulfilmentDocumentNumberURL { get; set; }

        [DataMember]
        public string FulfilmentDocumentStatus { get; set; }

        [DataMember]
        public int FulfilmentDocumentType { get; set; }

        [DataMember]
        public string FieldSupervisor { get; set; }
    }
}