using Newtonsoft.Json;
using System;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class DocumentAddressDetails
    {
        [JsonIgnore]
        public long DocumentCode { get; set; }

        public Nullable<long> LocationId { get; set; }
        public string LocationName { get; set; }
        public Nullable<long> PartnerCode { get; set; }
        public Nullable<byte> SequenceId { get; set; }
        public bool IsDeleted { get; set; }
        public string ClientLocationCode { get; set; }
        public Nullable<long> AddressCode { get; set; }
        public Nullable<int> LocationTypeId { get; set; }
    }
}