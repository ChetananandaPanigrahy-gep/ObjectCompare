using System;
using System.Collections.Generic;

//using Nest;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class DM_Documents
    {
        public DM_Documents()
        {
            this.DM_DocumentAdditionalFields = new HashSet<DM_DocumentAdditionalFields>();
            this.DM_DocumentRegion = new HashSet<DM_DocumentRegion>();
            this.DM_DocumentStakeholder = new HashSet<DM_DocumentStakeholder>();
            this.DM_DocumentBU = new HashSet<DM_DocumentBU>();
            this.DM_DocumentPas = new HashSet<DM_DocumentPas>();
            this.DM_DocumentLinkInfo = new HashSet<DocumentLinkInfo>();
            this.DM_DocumentLOB = new HashSet<DM_DocumentLOB>();
        }

        public long DocumentCode { get; set; }
        public string DocumentName { get; set; }
        public string DocumentNumber { get; set; }
        public int DocumentTypeCode { get; set; }
        public Nullable<int> DocumentStatus { get; set; }
        public long Creator { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<int> NumberofPas { get; set; }
        public Nullable<int> NumberofRegion { get; set; }
        public Nullable<int> NumberofBU { get; set; }
        public bool IsConfidential { get; set; }
        public bool IsTemplate { get; set; }
        public bool IsBuyerVisible { get; set; }
        public bool IsSupplierVisible { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatorName { get; set; }
        public string DocumentTypeName { get; set; }
        public string DocumentStatusDesc { get; set; }
        public long LOB { get; set; }
        public Nullable<int> NumberofItems { get; set; }
        public Nullable<int> NumberofSurveys { get; set; }
        public Nullable<int> NumberofSections { get; set; }
        public Nullable<int> NumberofPartners { get; set; }
        public Nullable<int> NumberofAttachments { get; set; }
        public DateTime CurrentDate { get; set; }
        // public Nullable<long> LinkedDocumentCode { get; set; }
        // public Nullable<int> LinkedDocumentTypeCode { get; set; }
        // public byte DocumentSourceType { get; set; }
        // public string SearchKey { get; set; }

        public Nullable<double> Score { get; set; }
        public Nullable<long> BuyerPartnerCode { get; set; }
        public virtual ICollection<DM_DocumentStakeholder> DM_DocumentStakeholder { get; set; }
        public virtual ICollection<DM_DocumentAdditionalFields> DM_DocumentAdditionalFields { get; set; }
        public virtual ICollection<DM_DocumentRegion> DM_DocumentRegion { get; set; }
        public virtual ICollection<DM_DocumentBU> DM_DocumentBU { get; set; }
        public virtual ICollection<DM_DocumentPas> DM_DocumentPas { get; set; }
        public virtual ICollection<DocumentLinkInfo> DM_DocumentLinkInfo { get; set; }
        public virtual ICollection<DM_DocumentLOB> DM_DocumentLOB { get; set; }
        public virtual ICollection<DocumentWorkgroup> DM_DocumentWorkgroup { get; set; }
        public Nullable<int> InterfaceDocumentStatus { get; set; }
    }
}