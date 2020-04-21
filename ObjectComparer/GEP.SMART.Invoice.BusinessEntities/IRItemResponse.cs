using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class IRItemResponse
    {
        public long DocumentItemId { get; set; }
        public int ItemLineNumber { get; set; }
        public long P2PLineItemId { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public string UOM { get; set; }
        public decimal UnitPrice { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ItemTotalValue { get; set; }
        public decimal Tax { get; set; }
        public decimal ExternalTax { get; set; }
        public string LegalCompanyName { get; set; }
        public string ShiptoLocationName { get; set; }
        public string ShiptoAddressLine1 { get; set; }
        public string ShiptoAddressLine2 { get; set; }
        public string ShiptoAddressLine3 { get; set; }
        public string DelivertoLocationName { get; set; }
        public string DelivertoAddressLine1 { get; set; }
        public string DelivertoAddressLine2 { get; set; }
        public string DelivertoAddressLine3 { get; set; }
        public string CategoryName { get; set; }
        public string ItemType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string BuyerItemNumber { get; set; }
        public List<IRSplitItemResponse> SplitItems { get; set; }
    }
}