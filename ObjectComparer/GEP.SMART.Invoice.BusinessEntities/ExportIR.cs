using GEP.SMART.Invoice.BusinessEntities.ExportDataSetEntities;
using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(IRDataSet))]
    [System.Xml.Serialization.XmlInclude(typeof(IRDataSet))]
    public class ExportIR : Export
    {
        [DataMember]
        public ExportDataSetEntities.IRDataSet IRDataSet { get; set; }
    }
}