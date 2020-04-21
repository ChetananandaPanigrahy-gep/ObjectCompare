using System.Diagnostics.CodeAnalysis;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [ExcludeFromCodeCoverage]
    public class InvoiceProcessingSettings
    {
        public int PrecessionValue { get; set; }

        public int PrecessionValueForTotal { get; set; }

        public int CodeCombinationFieldId { get; set; }

        public string CodeCombinationFieldValue { get; set; }

        public int GlobalInvoiceComplianceValue { get; set; }

        public int EntityMappedToComplianceCountry { get; set; }

        public int PrecessionValueForTaxesAndCharges { get; set; }
    }
}