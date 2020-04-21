using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class ToleranceDetails
    {
        public ToleranceDetails()
        {
        }

        public ToleranceDetails(ToleranceDetails toleranceDetails)
        {
            if (toleranceDetails != null)
            {
                this.AllowTolerance = toleranceDetails.AllowTolerance;
                this.AllowToleranceEdit = toleranceDetails.AllowToleranceEdit;
                this.AllowToleranceForBlank = toleranceDetails.AllowToleranceForBlank;
                this.ChargesPercentTolerance = toleranceDetails.ChargesPercentTolerance;
                this.ChargesValueTolerance = toleranceDetails.ChargesValueTolerance;
                this.ItemTotalPercentTolerance = toleranceDetails.ItemTotalPercentTolerance;
                this.ItemTotalValueTolerance = toleranceDetails.ItemTotalValueTolerance;
                this.QuantityPercentTolerance = toleranceDetails.QuantityPercentTolerance;
                this.QuantityValueTolerance = toleranceDetails.QuantityValueTolerance;
                this.ShippingPercentTolerance = toleranceDetails.ShippingPercentTolerance;
                this.ShippingValueTolerance = toleranceDetails.ShippingValueTolerance;
                this.TaxPercentTolerance = toleranceDetails.TaxPercentTolerance;
                this.TaxValueTolerance = toleranceDetails.TaxValueTolerance;
                this.TotalAmountPercentTolerance = toleranceDetails.TotalAmountPercentTolerance;
                this.TotalAmountValueTolerance = toleranceDetails.TotalAmountValueTolerance;
                this.UnitPricePercentTolerance = toleranceDetails.UnitPricePercentTolerance;
                this.UnitPriceValueTolerance = toleranceDetails.UnitPriceValueTolerance;
                this.BaseCurrencyCode = toleranceDetails.BaseCurrencyCode;
                this.TargetCurrencyCode = toleranceDetails.TargetCurrencyCode;
            }
        }

        [DataMember]
        public bool AllowTolerance { get; set; }

        [DataMember]
        public bool AllowToleranceEdit { get; set; }

        [DataMember]
        public bool AllowToleranceForBlank { get; set; }

        [DataMember]
        public decimal? ItemTotalPercentTolerance { get; set; }

        [DataMember]
        public decimal? ItemTotalValueTolerance { get; set; }

        [DataMember]
        public decimal? TotalAmountPercentTolerance { get; set; }

        [DataMember]
        public decimal? TotalAmountValueTolerance { get; set; }

        [DataMember]
        public decimal? TaxPercentTolerance { get; set; }

        [DataMember]
        public decimal? TaxValueTolerance { get; set; }

        [DataMember]
        public decimal? ShippingPercentTolerance { get; set; }

        [DataMember]
        public decimal? ShippingValueTolerance { get; set; }

        [DataMember]
        public decimal? ChargesPercentTolerance { get; set; }

        [DataMember]
        public decimal? ChargesValueTolerance { get; set; }

        [DataMember]
        public decimal? QuantityPercentTolerance { get; set; }

        [DataMember]
        public decimal? QuantityValueTolerance { get; set; }

        [DataMember]
        public decimal? UnitPricePercentTolerance { get; set; }

        [DataMember]
        public decimal? UnitPriceValueTolerance { get; set; }

        [DataMember]
        public long ACEEntityDetailCode { get; set; }

        [DataMember]
        public long LOBEntityDetailCode { get; set; }

        [DataMember]
        public string BaseCurrencyCode { get; set; }

        [DataMember]
        public string TargetCurrencyCode { get; set; }
    }
}