namespace GEP.SMART.Invoice.BusinessEntities.CSMEntities
{
    public class GetCurrencyAutoSuggestRequest
    {
        public string CultureCode { get; set; }
        public string SearchText { get; set; }
        public int NoOfRecord { get; set; }
    }
}