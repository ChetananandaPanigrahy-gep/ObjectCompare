using Gep.Cumulus.CSM.Entities;
using System;
using System.Runtime.Serialization;

//Where did we use this in P2P OR OLD Invocie
namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(TaxType))]
    [KnownType(typeof(SplitType))]
    [System.Xml.Serialization.XmlInclude(typeof(SplitType))]
    [System.Xml.Serialization.XmlInclude(typeof(TaxType))]
    public class ExternalTaxesOld : EntityBase
    {
        [DataMember]
        public long? LineNumber { get; set; }

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
        public TaxType TaxType { get; set; }

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
        public string AuthorityName { get; set; }

        [DataMember]
        public Old.P2PAddressOld TaxAddress { get; set; }

        [DataMember]
        public decimal? TotalTaxAmount { get; set; }

        [DataMember]
        public string EffectiveTaxLevel { get; set; }

        [DataMember]
        public string LocationCode { get; set; }

        [DataMember]
        public string OfficialName { get; set; }

        [DataMember]
        public string TaxRateCode { get; set; }
    }
}