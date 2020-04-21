namespace GEP.SMART.Invoice.BusinessEntities.CSMEntities
{
    public class GetCurrencyAutoSuggestResponse
    {
        public int CurrencyId { get; set; }
        public string CurrencyCode { get; set; }
        public string Symbol { get; set; }
        public string CountryAbbrevationCode { get; set; }
        public string CurrencyName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
    }
}