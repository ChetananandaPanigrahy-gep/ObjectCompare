using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities.Old
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(ExternalTaxesOld))]
    [System.Xml.Serialization.XmlInclude(typeof(ExternalTaxesOld))]
    public class CommonExternalResponse
    {
        [DataMember]
        public long DocumentCode { get; set; }

        [DataMember]
        public string ResponseIdentifier { get; set; }

        [DataMember]
        public short Status { get; set; }

        [DataMember]
        public DateTime DateCreated { get; set; }

        [DataMember]
        public long CreatedBy { get; set; }

        [DataMember]
        public DateTime DateModified { get; set; }

        [DataMember]
        public long ModifiedBy { get; set; }

        [DataMember]
        public List<ExternalResponseError> ExternalErrors { get; set; }
    }

    public class ExternalResponse : CommonExternalResponse
    {
        [DataMember]
        public List<ExternalTaxesOld> ExternalTaxes { get; set; }
    }

    public class InvoiceExternalResponse : CommonExternalResponse
    {
        [DataMember]
        public string BuyerReferenceNumber { get; set; }
    }

    [DataContract]
    [Serializable]
    public class ExternalResponseError
    {
        [DataMember]
        public long DocumentItemId { get; set; }

        [DataMember]
        public long LineNumber { get; set; }

        [DataMember]
        public byte Severity { get; set; }

        [DataMember]
        public long ErrorCode { get; set; }

        [DataMember]
        public string ErrorCategory { get; set; }

        [DataMember]
        public string ErrorProductCode { get; set; }

        [DataMember]
        public string ErrorMessage { get; set; }
    }
}