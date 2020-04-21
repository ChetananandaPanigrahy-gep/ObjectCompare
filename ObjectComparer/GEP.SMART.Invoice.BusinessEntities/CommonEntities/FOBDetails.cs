using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class FOBDetails
    {
        [DataMember]
        public IdCodeAndDesc FOB { get; set; }

        [DataMember]
        public IdCodeAndDesc FOBLocation { get; set; }

        [DataMember]
        public IdCodeAndDesc Carriers { get; set; }

        [DataMember]
        public IdCodeAndDesc TransitType { get; set; }

        [DataMember]
        public IdCodeAndDesc FreightTerms { get; set; }
    }
}