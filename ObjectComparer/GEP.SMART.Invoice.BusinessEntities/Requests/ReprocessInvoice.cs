using System;
using System.Collections.Generic;
using System.Text;
using Gep.Cumulus.CSM.Entities;
using GEP.Cumulus.Documents.Entities;
using System.Diagnostics.CodeAnalysis;

namespace GEP.SMART.Invoice.BusinessEntities.Requests
{
    [ExcludeFromCodeCoverage]
   public class ReprocessInvoice
    {
        public long InvoiceId { get; set; }
    }
    public class ReprocessInvoiceStatus
    {
        public long DocumentCode { get; set; }

        public int ReprocessingStatus { get; set; }
    }
    public class ReprocessInvoiceResponse
    {
        public long BPC { get; set; }

        public int DocumentType { get; set; }

        public List<ReprocessInvoiceStatus> reprocessingStatusDetails { get; set; }
    }
}
