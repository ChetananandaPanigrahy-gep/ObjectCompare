using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class ItemCharge
    {
        [DataMember]
        public long ItemChargeId { get; set; }

        [DataMember]
        public long DocumentCode { get; set; }

        [DataMember]
        public long P2PLineItemID { get; set; }

        [DataMember]
        public long LineNumber { get; set; }

        [DataMember]
        public int ItemTypeID { get; set; }

        [DataMember]
        public decimal CalculationValue { get; set; }

        [DataMember]
        public decimal ChargeAmount { get; set; }

        [DataMember]
        public string AdditionInfo { get; set; }

        [DataMember]
        public long CreatedBy { get; set; }

        [DataMember]
        public long UpdatedBy { get; set; }

        [DataMember]
        public ChargeMaster ChargeDetails { get; set; }

        [DataMember]
        public bool IsHeaderLevelCharge { get; set; }

        [DataMember]
        public decimal TotalAmount { get; set; }

        [DataMember]
        public decimal Tax { get; set; }

        [DataMember]
        public decimal AdditionalCharges { get; set; }

        [DataMember]
        public decimal TotalAllowance { get; set; }

        [DataMember]
        public decimal TotalCharge { get; set; }

        [DataMember]
        public decimal DocumentTotal { get; set; }

        [DataMember]
        public bool IsChecked { get; set; }

        [DataMember]
        public int ChargeItemCount { get; set; }

        [DataMember]
        public decimal DocumentAdditionalCharges { get; set; }

        [DataMember]
        public decimal DocumentTax { get; set; }

        [DataMember]
        public int MatchStatus { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        //[DataMember]
        //public List<InvoiceSplitItems> ItemSplitsDetails { get; set; }

        [DataMember]
        public List<OrderSplitItems> ItemSplitsDetail { get; set; }

        [DataMember]
        public List<RequisitionSplitItems> ReqItemSplitsDetail { get; set; }

        [DataMember]
        public SplitType SplitType { get; set; }

        [DataMember]
        public long DocumentItemId { get; set; }
    }
}