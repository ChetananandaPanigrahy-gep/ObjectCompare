using System;
using System.Collections.Generic;
using System.Text;

namespace GEP.SMART.Invoice.BusinessEntities.CSMEntities
{
    public class GetDefaultCurrencyExchangeRateByConversionDateResponseEntity
    {
        public string ToCurrencyCode { get; set; }
        public string FromCurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public DateTime EffectiveDate { get; set; }
    }
}
