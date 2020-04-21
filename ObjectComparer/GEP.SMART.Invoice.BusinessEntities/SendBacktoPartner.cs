using GEP.Cumulus.Documents.Entities;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class SendBacktoPartner
    {
        public long documentCode { get; set; }
        public decimal partnerCode { get; set; }
        public long invoiceId { get; set; }
        public DocumentStatus documentStatus { get; set; } = DocumentStatus.None;
        public long LOBId { get; set; }
        public int ACEntityId { get; set; }
    }
}