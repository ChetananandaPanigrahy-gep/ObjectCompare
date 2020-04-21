namespace GEP.SMART.Invoice.BusinessEntities
{
    public class RelatedDocument
    {
        public long DocumentCode { get; set; }
        public Cumulus.Documents.Entities.DocumentStatus DocumentStatus { get; set; }
        public P2PDocumentType DocumentType { get; set; }
        public int DocumentCount { get; set; }
    }
}