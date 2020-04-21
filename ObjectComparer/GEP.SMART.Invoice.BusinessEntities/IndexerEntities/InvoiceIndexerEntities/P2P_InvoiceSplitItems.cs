using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class P2P_InvoiceSplitItems
    {
        public P2P_InvoiceSplitItems()
        {
            this.P2P_InvoiceSplitItemEntities = new HashSet<P2P_InvoiceSplitItemEntities>();
        }

        public long InvoiceSplitItemId { get; set; }
        public long InvoiceItemId { get; set; }
        public Nullable<byte> SplitType { get; set; }
        public Nullable<decimal> Percentage { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> ShippingCharges { get; set; }
        public Nullable<decimal> AdditionalCharges { get; set; }
        public Nullable<decimal> SplitItemTotal { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public string ErrorCode { get; set; }

        //[JsonIgnore]
        //public virtual P2P_InvoiceItems P2P_InvoiceItems { get; set; }
        public virtual ICollection<P2P_InvoiceSplitItemEntities> P2P_InvoiceSplitItemEntities { get; set; }
    }
}