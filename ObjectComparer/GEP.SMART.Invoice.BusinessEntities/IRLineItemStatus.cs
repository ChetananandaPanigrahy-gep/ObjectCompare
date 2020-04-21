using GEP.Cumulus.Documents.Entities;
using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(MatchStatus))]
    [System.Xml.Serialization.XmlInclude(typeof(MatchStatus))]
    public class IRLineItemStatus
    {
        [DataMember]
        public long DocumentStakeholderId { get; set; }

        [DataMember]
        public long InvoiceItemId { get; set; }

        [DataMember]
        public DocumentStatus LineItemStatus { get; set; }

        [DataMember]
        public DateTime DateCreated { get; set; }

        [DataMember]
        public DateTime DateModified { get; set; }

        [DataMember]
        public MatchStatus MatchedStatus { get; set; }
    }
}