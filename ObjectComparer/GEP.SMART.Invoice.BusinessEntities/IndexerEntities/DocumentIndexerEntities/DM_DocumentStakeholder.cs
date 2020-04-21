using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class DM_DocumentStakeholder
    {
        public DM_DocumentStakeholder()
        {
            //this.DM_DocumentStakeholderPrivileges = new HashSet<DM_DocumentStakeholderPrivileges>();
        }

        public long DocumentStakeholderId { get; set; }
        public long PartnerCode { get; set; }
        public Nullable<long> ContactCode { get; set; }
        public long DocumentCode { get; set; }
        public int StakeholderType { get; set; }
        public Nullable<int> StakeholderDocumentStatus { get; set; }
        public bool IsDeleted { get; set; }
        public string CompanyLegalName { get; set; }
        public string ContactName { get; set; }
        public string StakeholderDocumentStatusName { get; set; }
        public string StakeholderTypeName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<DocumentAddressDetails> DocumentAddressDetailsList { get; set; }

        public string UniqueSHContact
        {
            get
            {
                return (ContactCode != null) ? string.Format(Constants.UniqueSHTemplate, StakeholderType, ContactCode) : null;
            }
        }

        public string UniqueSHPartner
        {
            get
            {
                return string.Format(Constants.UniqueSHTemplate, StakeholderType, PartnerCode);
            }
        }
    }
}