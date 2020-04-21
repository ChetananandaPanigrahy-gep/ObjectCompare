using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class P2P_IRItems
    {
        public long IRItemId { get; set; }
        public long InvoiceItemId { get; set; }
        public long IRId { get; set; }
        public long P2PLineItemId { get; set; }
        public byte? ItemTypeId { get; set; }
        public byte? ItemExtendedType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long InvoiceId { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public string Description { get; set; }
        public long? CategoryID { get; set; }
        public string ItemNumber { get; set; }
        public string SupplierPartId { get; set; }
        public string CapitalCode { get; set; }
        public string PASName { get; set; }
        public ICollection<P2P_InvoiceSplitItemEntities> P2P_InvoiceSplitItemEntities { get; set; }
    }
}