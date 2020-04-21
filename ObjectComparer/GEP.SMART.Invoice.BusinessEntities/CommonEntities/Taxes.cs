using Gep.Cumulus.CSM.Entities;
using GEP.SMART.Invoice.BusinessEntities.Old;
using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(TaxType))]
    [KnownType(typeof(SplitType))]
    [System.Xml.Serialization.XmlInclude(typeof(SplitType))]
    [System.Xml.Serialization.XmlInclude(typeof(TaxType))]
    public class Taxes : EntityBase
    {
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
        public TaxType TaxType { get; set; }

        [DataMember]
        public SplitType TaxMode { get; set; }

        [DataMember]
        public decimal TaxValue { get; set; }

        [DataMember]
        public string TaxCode { get; set; }

        [DataMember]
        public long OrderSplitItemId { get; set; }

        [DataMember]
        public bool IsInvSplitDeleted { get; set; }

        [DataMember]
        public DocumentType DocumentTypeCode { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public bool IsManual { get; set; }

        [DataMember]
        public bool IsAccrueTax { get; set; }

        [DataMember]
        public bool IsInterfaceTax { get; set; }

        [DataMember]
        public decimal TaxPercentage { get; set; }

        [DataMember]
        public bool IsFLippedFromOrder { get; set; }

        [DataMember]
        public TaxLevelType TaxLevelType { get; set; }

        [DataMember]
        public long LineNumber { get; set; }

        [DataMember]
        public TaxMode TaxModeType { get; set; }

        [DataMember]
        public P2PAddressOld TaxAddress { get; set; }

        [DataMember]
        public string AuthorityName { get; set; }

        [DataMember]
        public decimal Taxbase { get; set; }
    }
}