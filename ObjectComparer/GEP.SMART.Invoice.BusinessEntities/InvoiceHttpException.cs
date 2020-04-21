using System;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [Serializable]
    public class InvoiceHttpException : Exception
    {
        public int StatusCode { get; set; }

        public InvoiceHttpException()
        {
        }

        public InvoiceHttpException(string message, int statusCode)
            : base(message)
        {
            this.StatusCode = statusCode;
        }
    }
}