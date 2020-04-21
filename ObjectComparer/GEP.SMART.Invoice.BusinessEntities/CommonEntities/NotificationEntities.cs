using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class NotificationEntities
    {
        [DataMember]
        public long EntityId { get; set; }

        [DataMember]
        public string EntityName { get; set; }

        [DataMember]
        public string EntityDisplayName { get; set; }

        [DataMember]
        public int LevelType { get; set; }
    }
}