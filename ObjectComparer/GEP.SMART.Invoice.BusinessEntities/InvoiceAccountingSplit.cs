using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    /// <summary>
    /// Base class for requisition accounting split.
    /// </summary>
    [KnownType(typeof(SplitEntity))]
    [System.Xml.Serialization.XmlInclude(typeof(SplitEntity))]
    [DataContract]
    [Serializable]
    public class InvoiceAccountingSplit : P2PAccountingSplit
    {
    }
}