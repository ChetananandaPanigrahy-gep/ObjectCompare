using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities.SmartFlowEngine
{
    [DataContract]
    [Serializable]
    public class InvoiceExcelUploadInfo
    {
        [DataMember]
        public string TransactionId { get; set; }

        [DataMember]
        public string SmartFlowType { get; set; }

        [DataMember]
        public string SFEClaimCheckId { get; set; }
    }
}