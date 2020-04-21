using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class ExportTemplate
    {
        [DataMember]
        public int DocumentTypeCode { get; set; }

        [DataMember]
        public string CultureCode { get; set; }

        [DataMember]
        public long? DivisionEntityCode { get; set; }

        [DataMember]
        public int? EntityId { get; set; }

        [DataMember]
        public long? EntityDetailCode { get; set; }

        [DataMember]
        public string TemplateHTML { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public long? CreatedBy { get; set; }

        [DataMember]
        public DateTime DateCreated { get; set; }

        [DataMember]
        public long? ModifiedBy { get; set; }

        [DataMember]
        public DateTime? DateModified { get; set; }

        [DataMember]
        public bool IsLandscape { get; set; }

        [DataMember]
        public string TimeZone { get; set; }

        [DataMember]
        public int? IsMultiDocInvoice { get; set; }
    }
}