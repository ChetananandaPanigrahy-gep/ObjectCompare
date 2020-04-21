using Newtonsoft.Json;
using System;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class P2P_OrdersLink
    {
        public string DocumentName { get; set; }
        public string DocumentNumber { get; set; }
        public Nullable<decimal> PartnerCode { get; set; }
        public Nullable<int> ShiptoLocationID { get; set; }
        public Nullable<long> Creator { get; set; }
        public Nullable<long> OrderContactCode { get; set; }

        [JsonIgnore]
        public long InvoiceId { get; set; }

        [JsonIgnore]
        public long OrderId { get; set; }

        [JsonIgnore]
        public long ReceiptId { get; set; }
    }
}