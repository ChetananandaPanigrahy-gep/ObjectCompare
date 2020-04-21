using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    /// <summary>
    /// Class for tax.
    /// </summary>
    [KnownType(typeof(IdAndName))]
    [System.Xml.Serialization.XmlInclude(typeof(IdAndName))]
    [DataContract]
    [Serializable]
    public class Tax
    {
        /// <summary>
        /// Tax id.
        /// </summary>
        [DataMember]
        public int taxId { get; set; }

        /// <summary>
        /// Invoice tax Id.
        /// </summary>
        [DataMember]
        public long id { get; set; }

        /// <summary>
        /// Invoice item id.
        /// </summary>
        [DataMember]
        public long itemId { get; set; }

        /// <summary>
        /// Tax percent.
        /// </summary>
        [DataMember]
        public decimal percent { get; set; }

        /// <summary>
        /// Tax code.
        /// </summary>
        [DataMember]
        public string code { get; set; }

        /// <summary>
        /// Tax description.
        /// </summary>
        [DataMember]
        public string description { get; set; }

        /// <summary>
        /// Tax type.
        /// </summary>
        [DataMember]
        public IdAndName type { get; set; }

        /// <summary>
        /// Tax value.
        /// </summary>
        [DataMember]
        public decimal value { get; set; }

        [DataMember]
        public bool IsAccrueTax { get; set; }

        [DataMember]
        public decimal taxBase { get; set; }

        /// <summary>
        /// Tax Base.
        /// </summary>
        [DataMember]
        public decimal taxbase { get; set; }

        /// <summary>
        /// Authority Name.
        /// </summary>
        [DataMember]
        public string authorityName { get; set; }

        /// <summary>
        /// taxAddress
        /// </summary>
        [DataMember]
        public BusinessEntities.Old.P2PAddressOld taxAddress { get; set; }
    }
}