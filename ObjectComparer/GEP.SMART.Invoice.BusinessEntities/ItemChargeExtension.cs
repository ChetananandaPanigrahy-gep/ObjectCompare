using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class ItemChargeExtension : ItemCharge
    {
        [DataMember]
        public List<InvoiceSplitItems> ItemSplitsDetails { get; set; }

        [DataMember]
        public long InvoiceItemId { get; set; }
    }
}