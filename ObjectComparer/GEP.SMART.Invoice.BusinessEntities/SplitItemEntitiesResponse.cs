namespace GEP.SMART.Invoice.BusinessEntities
{
    public class SplitItemEntitiesResponse
    {
        public long SplitItemId { get; set; }
        public string EntityCode { get; set; }
        public string EntityDisplayName { get; set; }
        public int EntityTypeId { get; set; }
        public string Title { get; set; }
    }
}