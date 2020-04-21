using Gep.Cumulus.CSM.Entities;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public interface IInvoiceUserExecutionContext
    {
        UserExecutionContext Context { get; set; }
    }
}