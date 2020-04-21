using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class ErrorValidation
    {
        /// <summary>
        /// Code.
        /// </summary>
        [DataMember]
        public String TypeValidation { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.List<CodeAndName> ErrorValidationCode { get; set; }
    }
}