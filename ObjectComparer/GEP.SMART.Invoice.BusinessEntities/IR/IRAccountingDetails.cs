using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.IR
{
    public class IRAccountingDetails
    {
        public long Id { get; set; }
        public long DocumentCode { get; set; }
        public long DocumentItemId { get; set; }
        public double? Quantity { get; set; }
        public decimal? AdditionalCharges { get; set; }
        public decimal Percentage { get; set; }
        public decimal? ShippingCharges { get; set; }
        public decimal? SplitItemTotal { get; set; }
        public decimal? Tax { get; set; }
        public string ErrorCode { get; set; }
        public bool IsDeleted { get; set; }
        public int SplitType { get; set; }
        public decimal OverallLimitSplitItem { get; set; }
        public List<IRSplitEntity> SplitEntities { get; set; }
        public KeyValuePair<long, string> CreatedBy { get; set; }
        public KeyValuePair<long, string> LastModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}