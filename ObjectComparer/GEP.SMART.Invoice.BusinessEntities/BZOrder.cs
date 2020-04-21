using Gep.Cumulus.CSM.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities.Old
{
    [DataContract, Serializable]
    public class BZOrder
    {
        public BZOrder()
        {
            SupplierContact = new P2PContact();
            BuyerContact = new P2PContact();
            OrderContact = new P2PContact();
        }

        [DataMember]
        public P2PContact SupplierContact { get; set; }

        [DataMember]
        public P2PContact BuyerContact { get; set; }

        [DataMember]
        public P2PContact OrderContact { get; set; }

        [DataMember]
        public Order Order { get; set; }

        [DataMember]
        public string Requestor { get; set; }

        [DataMember]
        public string RequisitionNumber { get; set; }

        [DataMember]
        public string DefaultShipToLocation { get; set; }

        [DataMember]
        public string AccountNumber { get; set; }

        [DataMember]
        public List<TermsAndCondition> TermsAndConditionList { get; set; }

        //[DataMember]
        //public List<OrderItem> ParentOrderItems { get; set; }

        [DataMember]
        public PaymentTermDetails ParentPaymentTermsDetails { get; set; }

        [DataMember]
        public bool AddSubLines { get; set; }

        [DataMember]
        public bool OverWriteShipToIdForSupplier { get; set; }

        [DataMember]
        public List<long> RequisitionId { get; set; }
    }
}