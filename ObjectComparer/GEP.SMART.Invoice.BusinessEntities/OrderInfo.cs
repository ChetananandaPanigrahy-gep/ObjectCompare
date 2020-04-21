using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class OrderInfo
    {
        public string OrderNumber { get; set; }
        public string OrderName { get; set; }
        public decimal TotalAmount { get; set; }
        public long OrderId { get; set; }
        public KeyValuePair<long, string> OrderPartner { get; set; }
        public DateTime OrderDate { get; set; }
        public ContactDetails OrderContact { get; set; }
        public ContactDetails OrderingLocation { get; set; }
        public int ClosingOrderStatus { get; set; }
    }
}