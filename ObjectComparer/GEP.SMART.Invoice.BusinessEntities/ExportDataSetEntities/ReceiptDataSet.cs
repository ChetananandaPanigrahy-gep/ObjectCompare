using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.ExportDataSetEntities
{
    public class ReceiptDataSet
    {
        public List<Receipt> Receipt { get; set; }
        public List<AssetTag> AssetTag { get; set; }
    }

    public class Receipt
    {
        public string OrderNumber { get; set; }
        public string ReceivedBy { get; set; }
        public string CreatedOn { get; set; }
        public string ReceiptStatus { get; set; }
        public string ReceiptName { get; set; }
        public string ReceiptNumber { get; set; }
        public string OrderName { get; set; }
        public bool IsReturnNote { get; set; }
        public bool IsReturnNoteSpecified { get; set; }
        public string RNReceiptNumber { get; set; }
        public string LastModifiedBy { get; set; }
    }

    public class AssetTag
    {
        public string SerialNumber { get; set; }
        public string AssetKey { get; set; }
        public string AssetLocation { get; set; }
        public string AssetReturn { get; set; }
        public long DocumentItemId { get; set; }
    }
}