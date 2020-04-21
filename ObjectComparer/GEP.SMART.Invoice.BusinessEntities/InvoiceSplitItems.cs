using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(DocumentSplitItemEntity))]
    [System.Xml.Serialization.XmlInclude(typeof(DocumentSplitItemEntity))]
    public class InvoiceSplitItems : DocumentSplitItems
    {
        [DataMember]
        public List<DocumentSplitItemEntity> DocumentSplitItemEntities { get; set; }
    }
}