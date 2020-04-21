using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities.Old
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(TaxType))]
    [KnownType(typeof(SplitType))]
    [KnownType(typeof(Old.P2PAddressOld))]
    [System.Xml.Serialization.XmlInclude(typeof(SplitType))]
    [System.Xml.Serialization.XmlInclude(typeof(TaxType))]
    [System.Xml.Serialization.XmlInclude(typeof(Old.P2PAddressOld))]
    public class ExternalTaxes
    {
        [DataMember]
        public long LineNumber { get; set; }

        [DataMember]
        public long DocumentTaxId { get; set; }

        [DataMember]
        public long DocumentItemId { get; set; }

        [DataMember]
        public long DocumentItemSplitId { get; set; }

        [DataMember]
        public long TaxId { get; set; }

        [DataMember]
        public string TaxDescription { get; set; }

        [DataMember]
        public string TaxCode { get; set; }

        [DataMember]
        public string TaxType { get; set; }

        [DataMember]
        public string AuthorityName { get; set; }

        [DataMember]
        public SplitType TaxMode { get; set; }

        [DataMember]
        public decimal TaxValue { get; set; }

        [DataMember]
        public decimal TaxRate { get; set; }

        [DataMember]
        public decimal AppliedTaxValue { get; set; }

        [DataMember]
        public decimal AppliedTaxRate { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public string ResponseId { get; set; }

        [DataMember]
        public decimal TaxBase { get; set; }

        [DataMember]
        public Old.P2PAddressOld TaxAddress { get; set; }

        [DataMember]
        public decimal TotalTaxAmount { get; set; }
    }
}