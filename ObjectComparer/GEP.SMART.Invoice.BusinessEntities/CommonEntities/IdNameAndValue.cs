using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class IdNameAndValue
    {
        [DataMember]
        public Int64 id { get; set; }

        [DataMember]
        public String name { get; set; }

        [DataMember]
        public int value { get; set; }
    }
}