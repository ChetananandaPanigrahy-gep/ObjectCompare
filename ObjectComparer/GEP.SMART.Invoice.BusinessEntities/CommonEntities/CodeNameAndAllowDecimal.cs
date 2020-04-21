using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    /// <summary>
    /// Class to hold code and name combination.
    /// </summary>
    [DataContract]
    [Serializable]
    public class CodeNameAndAllowDecimal
    {
        /// <summary>
        /// Code.
        /// </summary>
        [DataMember]
        public String code { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        [DataMember]
        public String name { get; set; }

        [DataMember]
        public bool AllowDecimal { get; set; }
    }
}