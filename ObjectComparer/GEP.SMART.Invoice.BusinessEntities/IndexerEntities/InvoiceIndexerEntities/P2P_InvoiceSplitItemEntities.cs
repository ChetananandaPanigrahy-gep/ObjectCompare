namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class P2P_InvoiceSplitItemEntities
    {
        public long InvoiceItemId { get; set; }
        public int SplitAccountingFieldConfigId { get; set; }
        public string SplitAccountingFieldValue { get; set; }
        //Public string EntityCode { get; set; }
        //public long InvoiceSplitItemEntityId { get; set; }
        //public long InvoiceSplitItemId { get; set; }

        //[JsonIgnore]
        //public virtual P2P_InvoiceSplitItems P2P_InvoiceSplitItems { get; set; }
        //public virtual P2P_SplitAccountingFieldConfigurations P2P_SplitAccountingFieldConfigurations { get; set; }
    }
}