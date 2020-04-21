using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.Requests
{
    public class ActionMenuRequest
    {
        public long DocumentStatus { get; set; }
        public long DocumentSource { get; set; }
        public List<string> Activities { get; set; }
        public long InterfaceStatus { get; set; }
        public int InvoiceCreator { get; set; }
        public long LobId { get; set; }
        public int DocumentExtendedStatus { get; set; }
        public int InvoiceCreationSource { get; set; }
    }
}