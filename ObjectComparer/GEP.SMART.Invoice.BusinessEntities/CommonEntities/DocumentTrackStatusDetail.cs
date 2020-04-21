using Gep.Cumulus.CSM.Entities;
using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(RequisitionTrackStatus))]
    [System.Xml.Serialization.XmlInclude(typeof(RequisitionTrackStatus))]
    public class DocumentTrackStatusDetail : EntityBase
    {
        [DataMember]
        public long RequisitionId { get; set; }

        [DataMember]
        public string InstanceID { get; set; }

        [DataMember]
        public long ApproverID { get; set; }

        [DataMember]
        public string ApproverName { get; set; }

        [DataMember]
        public string ApproverType { get; set; }

        [DataMember]
        public string ApproveURL { get; set; }

        [DataMember]
        public string RejectURL { get; set; }

        [DataMember]
        public DateTime StatusDate { get; set; }

        [DataMember]
        public RequisitionTrackStatus ApprovalTrackStatus { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }
    }
}