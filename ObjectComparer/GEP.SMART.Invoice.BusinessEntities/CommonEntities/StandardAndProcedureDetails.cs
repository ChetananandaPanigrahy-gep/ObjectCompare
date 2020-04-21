using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class StandardAndProcedureDetails
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public long P2PItemId { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string RevisionNumber { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string FullTexts { get; set; }

        [DataMember]
        public Boolean IsDeleted { get; set; }
    }
}