using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class IRSplitItemResponse
    {
        public long DocumentItemId { get; set; }
        public long SplitItemId { get; set; }
        public SplitType SplitType { get; set; }
        public decimal SplitQuantity { get; set; }
        public decimal SplitItemTotal { get; set; }
        public List<SplitItemEntitiesResponse> SplitItemEntities { get; set; }
    }
}