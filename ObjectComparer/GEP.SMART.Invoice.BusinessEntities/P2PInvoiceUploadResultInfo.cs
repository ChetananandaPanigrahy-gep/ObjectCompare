using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class P2PInvoiceUploadResultInfo
    {
        [DataMember]
        public long DocumentCode { get; set; }

        [DataMember]
        public string PartnerInvoiceNumber { get; set; }

        [DataMember]
        public string PONumber { get; set; }

        [DataMember]
        public string PartnerName { get; set; }

        [DataMember]
        public string InvoiceAmount { get; set; }

        [DataMember]
        public string ErrorName { get; set; }

        [DataMember]
        public string DocumentStatus { get; set; }

        [DataMember]
        public string CurrencyCode { get; set; }

        [DataMember]
        public string DocumentUrl { get; set; }

        [DataMember]
        public string EPRTransmissionStatus { get; set; }
    }
}