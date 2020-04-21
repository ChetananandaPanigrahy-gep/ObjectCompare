using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class ChargeMaster
    {
        [DataMember]
        public long ChargeMasterId { get; set; }

        [DataMember]
        public string ChargeName { get; set; }

        [DataMember]
        public string ChargeDescription { get; set; }

        [DataMember]
        public int ChargeTypeCode { get; set; }

        [DataMember]
        public string EDICode { get; set; }

        [DataMember]
        public bool IsAllowance { get; set; }

        [DataMember]
        public int CalculationBasisId { get; set; }

        [DataMember]
        public string CalculationBasis { get; set; }

        [DataMember]
        public long EntityDetailCode { get; set; }

        [DataMember]
        public int GLDetailId { get; set; }

        [DataMember]
        public bool IsIncludeForTax { get; set; }

        [DataMember]
        public bool IsEditableOnInvoice { get; set; }

        [DataMember]
        public bool IsIncludeForRetainage { get; set; }

        [DataMember]
        public decimal TolerancePercentage { get; set; }

        [DataMember]
        public bool IsEditableOnOrder { get; set; }

        [DataMember]
        public string ChargeTypeName { get; set; }
    }
}