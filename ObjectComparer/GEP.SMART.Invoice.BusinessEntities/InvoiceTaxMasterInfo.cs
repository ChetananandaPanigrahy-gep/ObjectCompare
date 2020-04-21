using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities.Old
{
    public class InvoiceTaxMasterInfo
    {
        [DataMember]
        public string TaxCode { get; set; }

        [DataMember]
        public string TaxDescription { get; set; }

        [DataMember]
        public decimal TaxPercentage { get; set; }

        [DataMember]
        public string TaxType { get; set; }

        [DataMember]
        public string IsIncludeShipping { get; set; }

        [DataMember]
        public string JurisdictionCode { get; set; }

        [DataMember]
        public string JurisdictionName { get; set; }

        [DataMember]
        public string CountryName { get; set; }

        [DataMember]
        public long TaxEntityDetailCode { get; set; }
    }
}