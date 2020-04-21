namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public class Constants
    {
        public const string UniqueSHTemplate = "{0}_{1}";

        #region SP Names

        public const string USP_ES_DOCUMENTSINDEXING = "usp_ES_DocumentsIndexing";
        public const string USP_ES_P2PORDERSINDEXING = "usp_ES_P2POrdersIndexing";
        public const string USP_ES_P2PINVOICESINDEXING = "usp_ES_P2PInvoicesIndexing";
        public const string USP_ES_P2PRECEIPTSINDEXING = "usp_ES_P2PReceiptsIndexing";
        public const string USP_ES_P2PIRSINDEXING = "usp_ES_P2PIRsIndexing";
        public const string USP_ES_P2PREQUISITIONINDEXING = "usp_ES_P2PRequisitionIndexing";
        public const string USP_ES_P2PRETURNNOTESINDEXING = "usp_ES_P2PReturnNotesIndexing";
        public const string USP_ES_P2PCREDITMEMOSINDEXING = "usp_ES_P2PCreditMemosIndexing";
        public const string USP_ES_PMFORMSINDEXING = "usp_ES_PMFormsIndexing";
        public const string USP_ES_PMASSESSMENTINDEXING = "usp_ES_PMAssessmentIndexing";
        public const string USP_ES_PRNPARTNERDETAILSINDEXING = "usp_ES_PRNPartnerDetailsIndexing";
        public const string USP_ES_PRNPARTNERPREFERREDCBRINDEXING = "usp_PRN_GetAllPreferredCBRForIndexing";
        public const string USP_ES_PMACTIONPLANINDEXING = "usp_ES_PMActionPlanIndexing";
        public const string USP_ES_PPSTPROJECTINDEXING = "usp_ES_PPSTProjectIndexing";
        public const string USP_ES_SRCGSOURCINGINDEXING = "usp_ES_SRCGSourcingIndexing";
        public const string USP_ES_CWCATEGORYINDEXING = "usp_ES_CWCategoryIndexing";
        public const string USP_ES_CONTRACTINDEXING = "usp_ES_ContractIndexing";
        public const string USP_ES_P2PSERVICECONFIRMATIONINDEXING = "usp_ES_P2PServiceConfirmationIndexing";
        public const string USP_ES_GETCUSTOMATTR = "USP_ES_GetSearchDataForQuestionResponse";
        public const string USP_ES_GETCUSTOMATTRFORMMAPPING = "usp_ES_GetCustomAttributesFormMappingByDocuments";
        public const string USP_ES_GETCONTRACTADDITIONALINFO = "usp_ES_GetContractAdditionalInfo";
        public const string USP_ES_GETEMAILCONFIGURATION = "usp_ES_GetEmailConfiguration";
        public const string USP_ES_GETUSERDETAILSFORINDEXING = "usp_ES_GetUserDetailsForIndexing";
        public const string USP_ES_GETREQUESTADDITIONALINFO = "usp_ES_GetRequestAdditionalInfo";
        public const string USP_ES_P2P_TIMESHEETINDEXING = "usp_ES_P2P_TimesheetIndexing";
        public const string USP_ES_GETTEMPLATEFORINDEXING = "usp_ES_P2PTemplateIndexing"; //Piyush Changes
        public const string USP_ES_P2PASNINDEXING = "usp_ES_P2PASNIndexing";
        public const string USP_ES_P2P_PP_PROCUREMENTPROFILEINDEXING = "usp_ES_P2P_PP_ProcurementProfileIndexing";

        /// <summary>
        /// Stored Procedure is used to fetch Analytics Report Details.
        /// </summary>
        public const string USP_ES_ANLTREPORTDETAILINDEXING = "usp_ES_ANLTReportDetailIndexing";

        /// <summary>
        /// Stored Procedure is used to fetch Opportunity Finder.
        /// </summary>
        public const string USP_ES_ANLTOPPORTUNITYFINDERINDEXING = "usp_ES_ANLTOpportunityFinderIndexing";

        /// <summary>
        /// Stored Procedure is used to fetch Contract Language Template Details.
        /// </summary>
        public const string USP_ES_SECTIONS_INDEXING = "usp_ES_SectionsIndexing";

        #endregion SP Names
    }
}