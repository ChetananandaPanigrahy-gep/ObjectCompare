using GEP.SMART.Invoice.BusinessEntities.Old;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class BilltoLocation
    {
        public BilltoLocation()
        {
            Address = new P2PAddressOld();
        }

        [DataMember]
        public int BilltoLocationId { get; set; }

        [DataMember]
        public string BilltoLocationName { get; set; }

        [DataMember]
        public string BilltoLocationNumber { get; set; }

        [DataMember]
        public P2PAddressOld Address { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public bool IsDefault { get; set; }

        [DataMember]
        public string LOBEntityCode { get; set; }

        [DataMember]
        public List<BZOrgEntity> lstOrgEntity { get; set; }

        [DataMember]
        public bool IsAdhoc { get; set; }

        [DataMember]
        public List<GEP.SMART.Invoice.BusinessEntities.Old.RegistrationDetails> lstBillLocation { get; set; }
    }

    public class BillTo
    {
        public int BillToLocID { get; set; }
        public string BillToLocName { get; set; }
        public string BillToLocAddress { get; set; }
        public string BillToLocContact { get; set; }
    }
}