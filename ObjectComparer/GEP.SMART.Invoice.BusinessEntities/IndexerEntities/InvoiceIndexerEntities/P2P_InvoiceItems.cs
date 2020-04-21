using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class P2P_InvoiceItems
    {
        public P2P_InvoiceItems()
        {
            //  this.P2P_InvoiceSplitItems = new HashSet<P2P_InvoiceSplitItems>();
            this.P2P_InvoiceSplitItemEntities = new HashSet<P2P_InvoiceSplitItemEntities>();
        }

        public long InvoiceItemId { get; set; }
        public long P2PLineItemID { get; set; }
        public long InvoiceId { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public string Description { get; set; }
        public Nullable<long> CategoryID { get; set; }
        public string ItemNumber { get; set; }
        public string SupplierPartId { get; set; }
        public string CapitalCode { get; set; }
        public string PASName { get; set; }
        public ICollection<P2P_InvoiceSplitItemEntities> P2P_InvoiceSplitItemEntities { get; set; }

        //public decimal UnitPrice { get; set; }
        //public decimal Quantity { get; set; }
        //public string UOM { get; set; }
        //public string CurrencyCode { get; set; }
        //public byte ItemApprovalStatus { get; set; }
        //public Nullable<decimal> AdditionalCharges { get; set; }
        //public Nullable<decimal> ShippingCharges { get; set; }
        //public Nullable<decimal> Tax { get; set; }
        //public decimal UseTax { get; set; }
        //public bool IsDeleted { get; set; }
        //public System.DateTime DateCreated { get; set; }
        //public System.DateTime DateModified { get; set; }
        //public long CreatedBy { get; set; }
        //public long UpdatedBy { get; set; }
        //public int MatchStatus { get; set; }
        //public bool AccountingStatus { get; set; }
        //public byte SplitType { get; set; }
        //public bool IsTaxExempt { get; set; }
        //public Nullable<System.DateTime> StartDate { get; set; }
        //public Nullable<System.DateTime> EndDate { get; set; }
        //public byte ItemTypeId { get; set; }
        //public byte ItemExtendedType { get; set; }
        //public byte SourceType { get; set; }
        //public bool AccrueUseTax { get; set; }
        //public string UOMDescription { get; set; }
        //public string Billable { get; set; }
        //public string Capitalized { get; set; }
        //public bool IsChecked { get; set; }
        //public Nullable<long> CatalogItemId { get; set; }
        //public long LineNumber { get; set; }
        //public virtual ICollection<P2P_InvoiceSplitItems> P2P_InvoiceSplitItems { get; set; }

        //[JsonIgnore]
        //public virtual ICollection<P2P_InvoiceItemMatching> P2P_InvoiceItemMatching { get; set; }

        //[JsonIgnore]
        //public virtual P2P_Invoices P2P_Invoices { get; set; }

        //[ElasticProperty(Type = FieldType.Nested, Index = FieldIndexOption.Analyzed)]
        //public virtual P2P_LineItems P2P_LineItems { get; set; }

        //[ElasticProperty(Type = FieldType.Nested, Index = FieldIndexOption.Analyzed)]
        //public virtual ICollection<P2P_InvoiceLineItemShippingDetails> P2P_InvoiceLineItemShippingDetails { get; set; }

        //[ElasticProperty(Type = FieldType.Nested, Index = FieldIndexOption.Analyzed)]

        //[ElasticProperty(Type = FieldType.Nested, Index = FieldIndexOption.Analyzed)]
        //public virtual ICollection<P2P_InvoiceTaxes> P2P_InvoiceTaxes { get; set; }
    }
}