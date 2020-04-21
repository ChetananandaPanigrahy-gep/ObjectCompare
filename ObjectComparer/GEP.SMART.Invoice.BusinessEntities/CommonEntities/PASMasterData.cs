using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class PASMasterData
    {
        [DataMember]
        public string PASName { get; set; }

        [DataMember]
        public string ClientPASCode { get; set; }

        [DataMember]
        public long PASCode { get; set; }
    }
}