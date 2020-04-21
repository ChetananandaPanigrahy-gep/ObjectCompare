using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class InvoiceError
    {
        #region Properties

        [DataMember]
        public int ErrorCode { get; set; }

        [DataMember]
        public string ErrorName { get; set; }

        [DataMember]
        public string ErrorDisplayText { get; set; }

        [DataMember]
        public string ErrorData { get; set; }

        [DataMember]
        public string FieldMapping { get; set; }

        [DataMember]
        public bool IsResolvable { get; set; }

        [DataMember]
        public bool IsError { get; set; }

        [DataMember]
        public string ClientErrorCode { get; set; }

        [DataMember]
        public int ErrorType { get; set; }

        #endregion Properties
    }
}