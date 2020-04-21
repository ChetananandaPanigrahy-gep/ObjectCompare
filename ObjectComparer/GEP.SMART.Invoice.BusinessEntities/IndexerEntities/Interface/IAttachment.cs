namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public interface IAttachment
    {
        long AttachmentId { get; }
        string Content { get; set; }
        long DocumentCode { get; }
    }
}