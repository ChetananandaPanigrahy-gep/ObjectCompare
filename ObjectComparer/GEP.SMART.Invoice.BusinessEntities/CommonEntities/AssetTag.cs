using Gep.Cumulus.CSM.Entities;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class AssetTag : EntityBase
    {
        [DataMember]
        public long AssetTagId { get; set; }

        [DataMember]
        public long ReceiptItemId { get; set; }

        [DataMember]
        public string SerialNumber { get; set; }

        [DataMember]
        public string AssetKey { get; set; }

        [DataMember]
        public long AssetLocationId { get; set; }

        [DataMember]
        public string AssetLocation { get; set; }

        [DataMember]
        public int AssetLocationType { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public string ErrorCode { get; set; }

        [DataMember]
        public string AssetLocationCode { get; set; }

        [DataMember]
        public bool AssetReturn { get; set; }

        [DataMember]
        public string ItemNumber { get; set; }

        [DataMember]
        public string SupplierItemNumber { get; set; }

        [DataMember]
        public string DocumentNumber { get; set; }

        [DataMember]
        public bool IsError { get; set; }

        [DataMember]
        public string ErrorMessage { get; set; }

        [DataMember]
        public long LineNumber { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string ItemControlType { get; set; }
    }
}