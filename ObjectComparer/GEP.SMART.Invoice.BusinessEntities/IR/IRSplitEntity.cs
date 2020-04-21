namespace GEP.SMART.Invoice.BusinessEntities.IR
{
    public class IRSplitEntity
    {
        public int EntityType { get; set; }
        public long FieldId { get; set; }
        public long SplitEntityId { get; set; }
        public string Code { get; set; }
        public string EntityCode { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public long FieldControlType { get; set; }
        public string FieldName { get; set; }
        public int DataDisplayStyle { get; set; }
        public long SplitItemId { get; set; }
        public string GLName { get; set; }
    }
}