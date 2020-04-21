using Gep.Cumulus.CSM.Entities;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class InvoiceUserExecutionContext : IInvoiceUserExecutionContext
    {
        public UserExecutionContext Context { get; set; }
    }
}