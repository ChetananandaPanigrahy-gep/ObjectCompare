using System;
using System.Globalization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class Utils
    {
        private int maxPrecisionVal;

        /// <summary>
        /// Initializes a new instance of the <see cref="Utils"/> class.
        /// </summary>
        public Utils()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Utils"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public Utils(int value)
        {
            maxPrecisionVal = value;
        }

        /// <summary> Get a Format number based on culture. </summary>
        /// <param name="value">        The value. </param>
        /// <param name="cultureInfo">  Information describing the culture. </param>
        /// <returns>   The formatted number. </returns>
        public string FormatNumber(decimal value, CultureInfo cultureInfo)
        {
            string result = string.Empty;
            decimal number = Math.Round(value, maxPrecisionVal);
            string roundTripped = number.ToString().TrimEnd('0');
            if (cultureInfo == null)
                return value.ToString();

            if (roundTripped.Split('.')[1].Length <= 1)
            {
                result = number.ToString("N", cultureInfo); //to remove the currency symbol from the value
            }
            else
            {
                result = number.ToString(string.Format("N{0}", roundTripped.Split('.')[1].Length), cultureInfo);
            }

            return result.Trim();
        }

        /// <summary>   Gets a formated date based on culture. </summary>
        /// <param name="date">         The date. </param>
        /// <param name="cultureInfo">  Information describing the culture. </param>
        /// <returns>   The date. </returns>
        public string GetDate(string date, CultureInfo cultureInfo)
        {
            if (cultureInfo == null)
                return (date != null && date != string.Empty) ? Convert.ToString(Convert.ToDateTime(date).ToString("dd/MM/yyyy")) : string.Empty;
            string dateTime = string.Empty;
            if (date != string.Empty && date != "")
            {
                dateTime = Convert.ToDateTime(date).ToString("d", cultureInfo);
            }
            return dateTime;
        }
    }
}