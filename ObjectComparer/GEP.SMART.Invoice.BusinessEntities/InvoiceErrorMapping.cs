using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class InvoiceErrorMapping
    {
        #region Properties

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public long InvoiceId { get; set; }

        [DataMember]
        public long LineItemId { get; set; }

        [DataMember]
        public string ErrorJson { get; set; }

        [DataMember]
        public string ErrorCodes { get; set; }

        [DataMember]
        public bool IsResolved { get; set; }

        #endregion Properties
    }
}