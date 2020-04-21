using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class OrgManagerStructureMapping
    {
        [DataMember]
        public int StructureId { get; set; }

        [DataMember]
        public string StructureName { get; set; }

        [DataMember]
        public Dictionary<int, int> EntityMapping { get; set; }
    }
}