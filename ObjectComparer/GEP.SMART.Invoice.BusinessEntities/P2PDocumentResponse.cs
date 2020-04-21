using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(P2PDocumentValidationInfo))]
    public abstract class P2PDocumentResponse
    {
        [DataMember]
        public decimal? ItemTotalAmount { get; set; }

        [DataMember]
        public decimal? Tax { get; set; }

        [DataMember]
        public decimal? Shipping { get; set; }

        [DataMember]
        public decimal? AdditionalCharges { get; set; }

        [DataMember]
        public decimal? TotalAmount { get; set; }

        [DataMember]
        public List<P2PDocumentValidationInfo> ValidationInfo { get; set; }

        [DataMember]
        public BusinessEntities.Old.P2PItemCheckedStatus ItemCheckedStatus { get; set; }
    }
}