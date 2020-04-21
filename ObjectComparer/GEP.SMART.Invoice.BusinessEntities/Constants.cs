namespace GEP.SMART.Invoice.BusinessEntities
{
    public static class SqlConstants
    {
        public const string COL_IRDOCUMENT_CODE = "IRDocumentcode";

        public const string USP_P2P_GETPUNCHOUTITEMSBYPUNCHOUTCARTREQID = "usp_P2P_GetPunchoutItemsByPunchoutCartReqId";
        public const string USP_P2P_GETALLEXTRINSICVALUESBYPARTNERCODE = "USP_P2P_GETALLEXTRINSICVALUESBYPARTNERCODE";

        public const string usp_P2P_GetIRItemCharges = "usp_P2P_GetIRItemCharges";
        public const string usp_P2P_GetRequisitionItemCharges = "usp_P2P_GetRequisitionItemCharges";

        public const string usp_P2P_GetTaxItemsByEntityID = "usp_P2P_GetTaxItemsByEntityID";

        #region "NotificationEntities"

        public const string USP_P2P_GetAllEntityDetailsByDocumentCode = "usp_P2P_GetAllEntityDetailsByDocumentCode";

        #endregion "NotificationEntities"

        public const string USP_P2P_GET_REQUISITION_ITEM_COUNT = "usp_P2P_Get_RequisitionItemCount";
        public const string COL_TOTAL_PUNCHOUT_ITEMS_COUNT = "TotalPunchoutItemCount";
        public const string USP_P2P_GETALLPURCHASETYPEDETAILS = "usp_P2P_GetAllPurchaseTypeDetails";
        public const string COL_PURCHASE_TYPE_DESCRIPTION = "PurchaseTypeDescription";
        public const string COL_IS_ALLOWED_FOR_BIDDING = "IsAllowedforBidding";
        public const string COL_PARTNERCOMPANYIDENTIFICATIONID = "PartnerCompanyIdentificationId";
        public const string COL_COMPANYIDENTIFICATIONTYPEID = "CompanyIdentificationTypeId";
        public const string USP_P2P_IR_GETACCEPTANCEINSTANCEID = "usp_P2P_IR_GetAcceptanceInstanceId";

        public const string USP_P2P_GETENTITYMANAGERMAPPINGBYSTRUCTUREID =
            "USP_P2P_GetEntityManagerMappingByStructureId";

        public const string USP_P2P_IR_GETACTIONREQUIREDMESSAGEFORNOTIFICATIONMAIL =
            "usp_P2P_IR_GetActionRequiredMessageForNotificationMail";

        public const string USP_P2P_IR_GETIRLASTACCEPTORCONTACTCODE = "usp_P2P_IR_GetIRLastAcceptorContactCode";
        public const string USP_P2P_IR_GETACTIVECHANGEORDERDETAILSFORIR = "usp_P2P_IR_GetActiveChangeOrderDetailsForIR";

        public const string USP_P2P_INV_UPDATEINVOICEDOCUMENTEXTENDEDSTATUS =
            "usp_P2P_INV_UpdateInvoiceDocumentExtendedStatus";

        public const string usp_P2P_INV_GETCOMPUTEDTAXBASEDETAILS = "usp_P2P_INV_GetComputedTaxBaseDetails";
        public const string USP_P2P_INV_SAVEINVOICESOURCEDETAILS = "usp_P2P_INV_SaveInvoiceSourceDetails";
        public const string USP_P2P_GETACCOUNTINGDATABYDOCUMENTCODE = "usp_P2P_GetAccountingDataByDocumentCode";

        #region InvoiceDetailsByOrderId 4221

        public const string USP_P2P_INV_GETINVOICEDETAILSBYORDERID = "usp_P2P_INV_GetInvoiceDetailsByOrderId";
        public const string COL_ORDERNUMBER = "OrderNumber";
        public const string COL_ORDERNAME = "OrderName";
        public const string COL_INVOICEID = "InvoiceId";
        public const string COL_INVOICENUMBER = "InvoiceNumber";
        public const string COL_SUPPLIERINVOICEDATE = "SupplierInvoiceDate";
        public const string COL_INVOICEDATERECIEVED = "InvoiceDateReceived";
        public const string COL_INVOICEPAIDDATE = "InvoicePaidDate";
        public const string COL_SENDFORPAYMENTDATE = "SendForPaymentDate";
        public const string COL_SUPPLIERCODE = "SupplierCode";
        public const string COL_SUPPLIERNAME = "SupplierName";
        public const string COL_INVOICELINEITEMID = "InvoiceLineItemId";
        public const string COL_P2PLINEITEMID = "P2PLineItemID";
        public const string COL_CATEGORYID = "CategoryID";
        public const string COL_CATEGORYNAME = "CategoryName";
        public const string COL_LINEITEMUNITPRICE = "LineItemUnitPrice";
        public const string COL_LINEITEMCATEGORYID = "LineItemCategoryID";
        public const string COL_LINEITEMCURRENCYCODE = "LineItemCurrencyCode";
        public const string COL_LINEITEMUOM = "LineItemUOM";
        public const string COL_LINEITEMQUANTITY = "LineItemQuantity";
        public const string COL_LINETOTAL = "LineTotal";
        public const string COL_LINEITEMCATEGORY = "LineItemCategory";
        public const string COL_TOTALITEMCOUNT = "TotalItemCount";
        public const string COL_REMAININGAMOUNT = "RemainingAmount";
        public const string COL_ITEMTYPEID = "ItemTypeID";

        #endregion InvoiceDetailsByOrderId 4221

        public const string USP_P2P_ISINVOICEMULTIPO = "usp_P2P_IsInvoiceMultiPO";

        public const string COL_TAXES = "Taxes";
        public const string COL_SHIPPINGCHARGES = "Shipping Charges";
        public const string COL_OTHER_CHARGES = "Other Charges";
        public const string COL_VALUE = "Value";

        public const string USP_P2P_INV_GETINVOICEUPLOADRESULTBYID = "usp_P2P_INV_GetInvoiceUploadResultById";
        public const string COL_FAILED = "Failed";
        public const string COL_INTERFACECOMMENT = "InterfaceComment";
        public const string COL_INTERFACEDATE = "InterfaceDate";

        public const string USP_P2P_IR_UPDATACCEPTANCEFORDELTAEXCEPTIONS =
            "USP_P2P_IR_UpdateAcceptanceForDeltaExceptions";

        #region Exception Types

        public const string USP_P2P_INV_GetExceptionDetails = "USP_P2P_INV_GetExceptionDetails";

        #endregion Exception Types

        #region Custom Attribute

        public const string usp_P2P_INV_GetCustomAttribute = "usp_P2P_INV_GetCustomAttribute";

        #endregion Custom Attribute

        public const string usp_P2P_INV_UPDATECMANDIRSTATUS = "usp_P2P_INV_UpdateCMAndIrStatus";

        public const string USP_P2P_INV_VALIDATEERRORCODESUPPLIERINTERFACEDOCUMENT =
            "usp_P2P_INV_ValidateErrorCodeSupplierInterfaceDocument";

        public const string COL_FULFILMENT_DOCUMENT_LINENUMBER = "FulfillmentDocumentLineNumber";

        public const string usp_P2P_INV_GETINVOICEALLOWANCEANDCHARGEDETAILS =
            "usp_P2P_INV_GetInvoiceAllowanceAndChargeDetails";

        #region SectionWise SP

        public const string USP_P2P_INV_GETBASICDETAILS = "usp_P2P_INV_GETBASICDETAILS";
        public const string USP_P2P_INV_GETSTAKEHOLDERDETAILS = "USP_P2P_INV_GETSTAKEHOLDERDETAILS";
        public const string USP_P2P_INV_GETPAYMENTDELIVERYDETAILS = "USP_P2P_INV_GETPAYMENTDELIVERYDETAILS";
        public const string USP_P2P_INV_GetSupplierDetails = "USP_P2P_INV_GetSupplierDetails";
        public const string USP_P2P_INV_GETREMITTANCEDETAILS = "USP_P2P_INV_GETREMITTANCEDETAILS";
        public const string USP_P2P_INV_GETERRORDETAILS = "USP_P2P_INV_GETERRORDETAILS";
        public const string USP_P2P_INV_GETALLLINEANDACCOUNTINGDETAILS = "usp_P2P_INV_GetAllLineAndAccountingDetails";

        #endregion SectionWise SP

        #region IR Sections SPs

        public const string USP_P2P_IR_GETBASICDETAILS = "USP_P2P_IR_GetBasicDetails";
        public const string USP_P2P_IR_GETBUYERDETAILS = "USP_P2P_IR_GetBuyerDetails";
        public const string USP_P2P_IR_GETSUPPLIERDETAILS = "USP_P2P_IR_GetSupplierDetails";
        public const string USP_P2P_IR_GETPAYMENTDELIVERYDETAILS = "USP_P2P_IR_GetPaymentDeliveryDetails";
        public const string USP_P2P_IR_GETLINEDETAILS = "USP_P2P_IR_GetLineDetails";
        public const string USP_P2P_IR_GETCUSTOMATTRFORMID = "USP_P2P_IR_GetCustomAttrFormId";
        public const string USP_P2P_IR_GETMATCHSTATUS = "USP_P2P_IR_GetMatchStatus";

        #endregion IR Sections SPs

        #region Requisition

        #region Requisition Columns

        public const string COL_BILLTOID = "BillToId";
        public const string COL_BILLTOEMAIL = "BillToEmail";
        public const string COL_BILLTOFAX = "BillToFax";
        public const string COL_BILLTOADDRESS1 = "BillToAddress1";
        public const string COL_BILLTOADDRESS2 = "BillToAddress2";
        public const string COL_BILLTOADDRESS3 = "BillToAddress3";
        public const string COL_BILLTOCOUNTRY = "BillToCountry";
        public const string COL_BUSINESSUNITID = "BusinessUnitId";
        public const string COL_CREATEDBYID = "CreatedById";
        public const string COL_CREATEDBYFNAME = "CreatedByFirstName";
        public const string COL_CREATEDBYLNAME = "CreatedByLastName";
        public const string COL_CURRENCYSYMBOL = "CurrencySymbol";
        public const string COL_DELIVERTOID = "DeliverToId";
        public const string COL_DELTOADDRESS1 = "DeliverToAddress1";
        public const string COL_DELTOADDRESS2 = "DeliverToAddress2";
        public const string COL_DELTOADDRESS3 = "DeliverToAddress3";
        public const string COL_DELIVERTOSTR = "DeliverToStr";
        public const string COL_DOCUMENTCODE = "DocumentCode";
        public const string COL_LASTMODIFIEDON = "LastModifiedOn";
        public const string COL_NUMBER = "Number";
        public const string COL_DOCUMENTSOURCETYPE = "DocumentSourceType";
        public const string COL_OBOID = "OBOId";
        public const string COL_OBO_FNAME = "OBOFirstName";
        public const string COL_OBO_LNAME = "OBOLastName";
        public const string COL_SHIPTOID = "ShipToId";
        public const string COL_SHIPTOADDRESS1 = "ShipToAddress1";
        public const string COL_SHIPTOADDRESS2 = "ShipToAddress2";
        public const string COL_SHIPTOADDRESS3 = "ShipToAddress3";
        public const string COL_SHIPTOCITY = "ShipToCity";
        public const string COL_SHIPTOZIP = "ShipToZip";
        public const string COL_SHIPTOSTATE = "ShipToState";
        public const string COL_SHIPTOCOUNTRY = "ShipToCountry";
        public const string COL_ORDLOCADDRESS1 = "OrderLocAddress1";
        public const string COL_ORDLOCADDRESS2 = "OrderLocAddress2";
        public const string COL_ORDLOCADDRESS3 = "OrderLocAddress3";
        public const string COL_ORDLOCCITY = "OrderLocCity";
        public const string COL_ORDLOCZIP = "OrderLocZip";
        public const string COL_ORDLOCSTATE = "OrderLocState";
        public const string COL_ORDLOCCOUNTRY = "OrderLocCountry";
        public const string COL_SOURCEID = "SourceId";
        public const string COL_WORKORDER = "WorkOrder";
        public const string COL_HEADERENTITYID = "HeaderEntityId";
        public const string COL_ENTITYNAME = "EntityName";
        public const string COL_LASTMODIFIEDBYID = "LastModifiedById";
        public const string COL_LASTMODIFIEDBYFNAME = "LastModifiedByFirstName";
        public const string COL_LASTMODIFIEDBYLNAME = "LastModifiedByLastName";
        public const string COL_MANUFACTURER = "Manufacturer";
        public const string COL_NEEDBYDATE = "NeedByDate";
        public const string COL_OTHERCHARGES = "OtherCharges";
        public const string COL_PARTNERINTERFACECODE = "PartnerInterfaceCode";
        public const string COL_REQUESTEDDATE = "RequestedDate";
        public const string COL_TAXPERCENT = "TaxPercent";
        public const string COL_TAXTYPEID = "TaxTypeId";
        public const string COL_FIELDCONFIGID = "FieldConfigId";
        public const string COL_REQSPLITITEMENTITYID = "RequisitionSplitItemEntityId";
        public const string COL_GLNAME = "GLName";
        public const string COL_ACCESSTYPE = "AccessType";
        public const string COL_OBJECTID = "ObjectId";
        public const string COL_OBJECTTYPE = "ObjectType";
        public const string COL_COMMENTID = "CommentId";
        public const string COL_FILEURL = "FileURL";

        public const string COL_REQUISITION_ID = "RequisitionID";
        public const string COL_REQUISITION_NAME = "RequisitionName";
        public const string COL_REQUISITION_NUMBER = "RequisitionNumber";
        public const string COL_REQUESTER_ID = "RequesterID";

        public const string COL_BUID = "BUID";
        public const string COL_BUSINESSUNITNAME = "BusinessUnitName";
        public const string COL_REQUISITION_STATUS = "RequisitionStatus";
        public const string COL_REQUISITION_AMOUNT = "RequisitionAmount";
        public const string COL_REQUISITION_ITEM_TOTAL = "RequisitionItemTotal";
        public const string COL_REQUISITION_TAX = "RequisitionTax";
        public const string COL_REQUISITION_TRNMODE = "TrasmissionMode";
        public const string COL_REQUISITION_TRNVALUE = "TransmissionValue";

        public const string COL_REQUESTER_NAME = "RequesterName";
        public const string COL_APPROVE_URL = "ApproveURL";
        public const string COL_REJECT_URL = "RejectURL";
        public const string COL_TOTAL_RECORDS = "TotalRecords";
        public const string COL_DOCUMENT_TYPE = "DocumentType";
        public const string COL_DOCUMENT_CREATED = "DateCreated";

        public const string COL_APPROVER_ID = "ApproverId";
        public const string COL_PROXYAPPROVERID = "ProxyApproverId";
        public const string COL_APPROVALTYPE = "ApprovalType";
        public const string COL_APPROVER_TYPE = "ApproverType";
        public const string COL_TRACK_DATE = "StatusDate";
        public const string COL_TRACK_STATUS = "ApprovalStatus";
        public const string COL_TRACK_ISDELETED = "IsDeleted";
        public const string COL_REQUISITION_INSTANCEID = "InstanceID";
        public const string COL_REQUISITION_SOURCE = "RequisitionSource";
        public const string COL_REQSTATUS = "ReqStatus";
        public const string COL_ERROR_MESSAGE = "ErrorMessage";
        public const string COL_REQENTITYID = "ReqEntityId";
        public const string COL_PARENTDOCUMENTITEMTOTAL = "ParentDocumentItemTotal";

        public const string COL_ONBEHALFOF = "OnBehalfOf";
        public const string COL_ONBEHALFOFNAME = "OnBehalfOfName";
        public const string COL_ONBEHALFOFEMAIL = "OnBehalfOfEmail";
        public const string COL_IS_CATALOG_ITEMS_EXISTS = "IsCatalogItemsExists";
        public const string COL_IS_PUNCHOUT_ITEMS_EXISTS = "IsPunchoutItemExists";
        public const string COL_REQUESTER_EMAIL_ID = "RequesterEmailID";
        public const string COL_CATALOGITEMPARTNERID = "CatalogItemPartnerId";
        public const string COL_LEGALCOMPANYNAME = "LegalCompanyName";
        public const string COL_CATALOGITEMID = "CatalogItemId";

        public const string COL_NOOFSENDFORBIDDDINGITEMS = "SentforBiddingItems";
        public const string COL_NOOFPARTIALLYORDEREDITEMS = "PartiallyOrderedItems";
        public const string COL_NOOFFULLYORDEREDITEMS = "FullyOrderedItems";
        public const string COL_NOOFUNORDEREDITEMS = "UnOrderedItems";
        public const string COL_NOOFNONSUPPORTEDITEMS = "NonSupportedItems";
        public const string COL_REQUISITIONTOTALCHANGE = "RequisitionTotalChange";
        public const string COL_CO_REQUESTER_ID = "CORequesterID";
        public const string COL_CO_REQUESTER_NAME = "CORequesterName";
        public const string COL_CO_REQUESTER_EMAIL_ID = "CORequesterEmailID";
        public const string COL_BUDGETORYSTATUS = "BudgetoryStatus";
        public const string COL_REQ_UPLOADDETAIL_ID = "RequisitionUploadLogID";

        public const string COL_BUYERASSIGNEE = "BuyerAssignee";
        public const string COL_REQ_PROCESSEDXMLRESULT = "ProcessedXMLResult";
        public const string COL_REQ_REQUESTTYPE = "RequestType";
        public const string COL_REQ_ERROR = "ERROR";
        public const string COL_REQ_ERRORTRACE = "ERRORTRACE";
        public const string COL_BUYERASSIGNEENAME = "buyerAssigneeName";
        public const string COL_VENDORNUMBER = "VendorNumber";
        public const string COL_ISMAPPEDWITHBU = "IsMappedWithBU";
        public const string COL_EVENTCODE = "EventCode";

        #endregion Requisition Columns

        #region Requisition StoreProcedures

        public const string usp_P2P_INV_GetDocumentBasicDetailsDocumentnumber =
            "usp_P2P_PO_GetDocumentBasicDetailsDocumentnumberForInvoice";

        public const string USP_P2P_REQ_DELETELINEITEMS = "usp_P2P_REQ_DeleteLineItems";
        public const string USP_P2P_REQ_SAVEREQUISITIONUPLOADLOG = "usp_P2P_REQ_SaveRequisitionUploadLog";
        public const string USP_P2P_REQ_GETREQUISITIONUPLOADLOG = "usp_P2P_REQ_GetRequisitionUploadLog";

        public const string USP_P2P_REQ_PRORATELINEITEMTAXANDSHIPPING = "usp_P2P_REQ_ProrateLineItemTaxandShipping";
        public const string USP_P2P_PO_PRORATELINEITEMTAXANDSHIPPING = "usp_P2P_PO_ProrateLineItemTaxandShipping";

        public const string USP_P2P_GETALLCUSTOMATTRIBSBYDOCUMENTCODE = "usp_P2P_GetAllCustomAttribsByDocumentCode";
        public const string USP_P2P_REQ_GETALLDISPLAYDETAILS = "usp_P2P_REQ_GetAllDisplayDetails";

        public const string USP_P2P_REQ_GETREQUISITIONLINEITEMSBYREQUISITIONID =
            "usp_P2P_REQ_GetRequisitionLineItemsByRequisitionId";

        public const string USP_P2P_REQ_UPDATEREQUSITIONSTATUSBYID = "usp_P2P_REQ_UpdateRequsitionStatusById";
        public const string USP_P2P_REQ_SAVEREQUISITIONAPPROVERDETAILS = "usp_P2P_REQ_SaveRequisitionApproverDetails";

        public const string USP_P2P_REQ_SAVEREQUISITIONTRACKSTATUSDETAILS =
            "usp_P2P_REQ_SaveRequisitionTrackStatusDetails";

        public const string USP_P2P_REQ_GETP2PLANDINGPAGE = "usp_P2P_REQ_GetP2PLandingPage";
        public const string USP_P2P_REQ_GETREQUISITIONBASICDETAILSBYID = "usp_P2P_REQ_GetRequisitionBasicDetailsById";
        public const string USP_P2P_REQ_GETREQUISITIONENTITYDETAILSBYID = "usp_P2P_REQ_GetRequisitionEntityDetailsById";
        public const string USP_P2P_REQ_GENERATEDEFAULTREQUISITIONNAME = "usp_P2P_REQ_GenerateDefaultRequisitionName";
        public const string USP_P2P_REQ_SAVEREQUISITION = "usp_P2P_REQ_SaveRequisition";
        public const string USP_P2P_REQ_SAVEREQUISITIONITEM = "usp_P2P_REQ_SaveRequisitionItem";
        public const string USP_P2P_REQ_SAVEREQITEMADDITIONALDETAILS = "usp_P2P_REQ_SaveReqItemsAdditionalDetails";
        public const string USP_P2P_REQ_SAVEREQADDITIONALENTITYDETAILS = "usp_P2P_REQ_SaveReqAdditionalEntityDetails";
        public const string USP_P2P_REQ_GETALLPARTNERSBYID = "usp_P2P_REQ_GetAllPartnersById";
        public const string USP_P2P_REQ_SAVEREQUISITIONITEMPARTNERS = "usp_P2P_REQ_SaveRequisitionItemPartners";
        public const string USP_P2P_REQ_SAVEREQUISITIONITEMSHIPPING = "usp_P2P_REQ_SaveRequisitionItemShippingDetails";
        public const string USP_P2P_REQ_SAVEREQUISITIONITEMOTHER = "usp_P2P_REQ_SaveRequisitionItemOthers";

        public const string USP_P2P_REQ_GETTRACKSTATUSDETAILBYID = "usp_P2P_REQ_GetTrackStatusDetailsByID";

        public const string USP_P2P_VALIDATEBUDGETACCOUNTINGDETAILS = "usp_P2P_ValidateBudgetAccountingDetails";
        public const string USP_P2P_VALIDATE_BY_DOCUMENT_CODE = "usp_P2P_ValidateByDocumentCode";

        public const string USP_P2P_REQ_UPDATEREQUISITIONSTATUSBYORDERITEMID =
            "usp_P2P_REQ_UpdateRequisitionStatusByOrderItemId";

        public const string USP_P2P_PO_CALCULATEREQSTATUSBYORDERID = "usp_P2P_PO_CalculateReqStatusByOrderId";
        public const string USP_P2P_PO_DELETEORDERREQMAPPING = "usp_P2P_PO_DeleteOrderReqMapping";
        public const string USP_P2P_REQ_SAVEBUSINESSUNIT = "usp_P2P_REQ_SaveBusinessUnit";
        public const string USP_P2P_REQ_GETBUSINESSUNIT = "usp_P2P_REQ_GetBusinessUnit";
        public const string USP_P2P_REQ_GETALLREQUISITIONFORLEFTPANEL = "usp_P2P_REQ_GetAllRequisitionForLeftPanel";
        public const string USP_P2P_REQ_ADDTEMPLATEITEMSINREQ = "usp_P2P_REQ_AddTemplateItemsInReq";
        public const string USP_P2P_GETREQUISITIONADDITIONALDETAILS = "usp_P2P_GetRequisitionAdditionalDetails";
        public const string USP_P2P_GETORDERADDITIONALDETAILS = "usp_P2P_GetOrderAdditionalDetails";

        public const string USP_P2P_REQ_GETREQUISITIONACCOUNTINGDETAILSBYITEMID =
            "USP_P2P_REQ_GetRequisitionAccountingDetailsByItemId";

        public const string USP_P2P_REQ_SAVEREQUISITIONACCOUNTINGDETAILS =
            "usp_P2P_REQ_SaveRequisitionAccountingDetails";

        public const string USP_P2P_REQ_SAVEREQUISITIONACCOUNTINGDETAILSV2 =
            "usp_P2P_REQ_SaveRequisitionAccountingDetailsV2";

        public const string USP_P2P_GETINVOICEADDITIONALDETAILS = "usp_P2P_GetInvoiceAdditionalDetails";
        public const string USP_P2P_GETRECEIPTADDITIONALDETAILS = "usp_P2P_GetReceiptAdditionalDetails";
        public const string USP_P2P_INV_SAVEINVOICEACCOUNTINGDETAILS = "usp_P2P_INV_SaveInvoiceAccountingDetails";
        public const string USP_P2P_INV_UPDATEEXCEPTIONREOLVERDETAILS = "usp_P2P_INV_UpdateExceptionResolverDetails";

        public const string USP_P2P_GETALLSPLITACCOUNTINGFIELDSWITHDEFAULTVALUES =
            "usp_P2P_GetAllSplitAccountingFieldsWithDefaultValues";

        public const string USP_P2P_REQ_GETREQUISITIONADVPAYMENTACCOUNTINGDETAILSBYITEMID =
            "USP_P2P_REQ_GetRequisitionAdvPaymentAccountingDetailsByItemId";

        public const string USP_P2P_REQ_GETDOCUMENTIDBYDOCUMENTCODE = "usp_P2P_REQ_GetDocumentIdByDocumentCode";
        public const string USP_P2P_GETIRADDITIONALDETAILS = "usp_P2P_GetIRAdditionalDetails";

        public const string USP_P2P_REQ_COPYREQUISITIONTOREQUISITION = "usp_P2P_REQ_CopyRequisitiontoRequisition";

        public const string USP_P2P_CHECKVIEWACCESSOFENTITY = "usp_P2P_CheckViewAccessOfEntity";
        public const string USP_P2P_REQ_GETALLCATEGORIESBYREQID = "usp_P2P_REQ_GetAllCategoriesByReqId";

        public const string USP_P2P_PR_GETALLCATEGORIESBYPAYMENTREQUESTID =
            "usp_P2P_PR_GetAllCategoriesByPaymentRequestId";

        public const string USP_P2P_REQ_GETREQUISITION_ENTITIES = "usp_P2P_REQ_GetRequisitionEntities";
        public const string USP_P2P_REQ_UPDATETAXONHEADERSHIPTO = "usp_P2P_REQ_UpdateTaxOnHeaderShipTo";
        public const string USP_P2P_REQ_CALCULATE_AND_UPDATELINEITEMTAX = "usp_P2P_REQ_CalculateAndUpdateLineItemTax";
        public const string USP_P2P_REQ_DELETEALLSPLITSBYDOCUMENTID = "usp_P2P_REQ_DeleteAllSplitsByDocumentId";
        public const string USP_P2P_REQ_DELETESPLITSBYITEMID = "usp_P2P_REQ_DeleteSplitsByItemId";
        public const string USP_P2P_PO_GETORDERDETAILSFOREXPORTPDFBYID = "usp_P2P_PO_GetOrderDetailsForExportPDFById";
        public const string USP_P2P_REQ_GETOBOUSERBYDOCUMENTCODE = "usp_P2P_REQ_GetOBOUserByDocumentCode";

        public const string USP_P2P_REQ_GETREQUISITIONBYIDFORNOTIFICATION =
            "usp_P2P_REQ_GetRequisitionByIdForNotification";

        public const string USP_P2P_REQ_GETVALIDATIONERRORCODEBYID = "usp_P2P_REQ_GetValidationErrorCodeById";

        public const string USP_P2P_REQ_SAVEREQUISITIONACCOUNTINGAPPLYTOALL =
            "usp_P2P_REQ_SaveRequisitionAccountingApplyToAll";

        public const string USP_P2P_REQ_PRORATEHEADERTAXANDSHIPPING = "usp_P2P_REQ_ProrateHeaderTaxAndShipping";

        public const string USP_P2P_REQ_GETDOCUMENTBASICDETAILSDOCUMENTNUMBER =
            "usp_P2P_REQ_GetDocumentBasicDetailsDocumentnumber";

        public const string USP_P2P_REQ_UPDATEREQITEMONPARTNERCHANGE = "usp_P2P_REQ_UpdateReqItemOnPartnerChange";
        public const string USP_P2P_REQ_GETPREFERREDPARTNERBYREQITEMID = "usp_P2P_REQ_getPreferredPartnerByReqItemId";

        public const string USP_P2P_REQ_GETPREFERREDPARTNERBYCATALOGITEMID =
            "usp_P2P_REQ_getPreferredPartnerByCatalogItemId";

        public const string USP_P2P_REQ_GETALLITEMIDSBYREQID = "usp_P2P_REQ_GetAllItemIdsByReqId";
        public const string USP_P2P_REQ_REQUISITIONCATALOGITEMACCESS = "usp_P2P_REQ_RequisitionCatalogItemAccess";

        public const string USP_P2P_REQ_REQUISITIONOBOUSERCATALOGITEMACCESS =
            "usp_P2P_REQ_RequisitionOBOUserCatalogItemAccess";

        public const string USP_P2P_REQ_UPDATEBILLTOLOCATION = "usp_P2P_REQ_UpdateBillToLocation";

        public const string USP_P2P_REQ_GETALLREQUISITIONDETAILSBYREQUISITIONID =
            "usp_P2P_REQ_GetAllRequisitionDetailsByRequisitionId";

        public const string USP_P2P_GETAPPROVEDREJECTEDDOCSINFO = "usp_P2P_GetApprovedRejectedDocsInfo";

        public const string USP_P2P_REQ_GETREQUISITIONCAPITALCODECOUNTBYID =
            "usp_P2P_REQ_GetRequisitionCapitalCodeCountById";

        public const string USP_P2P_REQ_VALIDATEINTERFACEDOCUMENT = "usp_P2P_REQ_ValidateInterfaceDocument";
        public const string USP_P2P_INV_UPDATERELEVANTIRFORINVOICE = "USP_P2P_INV_UpdateRelevantIRForInvoice";

        public const string USP_P2P_PO_GETREQUISITIONDETAILSFOREXPORTPDFBYID =
            "usp_P2P_REQ_GetRequisitionDetailsForExportPDFById";

        public const string USP_P2P_GETACESSCONTROLENTITYFROMSPLITS = "usp_P2P_GetAcessControlEntityFromSplits";
        public const string USP_P2P_REQ_UPDATELINETYPEBYPURCHASETYPE = "usp_P2P_REQ_UpdateLineTypeByPurchaseType";
        public const string USP_P2P_REQ_SAVEADVANCEDPAYMENTITEM = "usp_P2P_REQ_SaveAdvancedPaymentItem";

        public const string USP_P2P_REQ_GETREQHEADERDETAILSBYID_FOR_INTERFACE =
            "usp_P2P_REQ_GetHeaderDetailsByIdForInterface";

        public const string USP_P2P_REQ_GETREQLINEITEMS_FOR_INTERFACE = "usp_P2P_REQ_GetLineItemsForInterface";
        public const string USP_P2P_REQ_UPDATEINTERFACESTATUS = "usp_P2P_REQ_UpdateInterfaceStatus";
        public const string usp_DM_GetAutoSaveDocument = "usp_DM_GetAutoSaveDocument";
        public const string usp_DM_AutoSaveDocument = "usp_DM_AutoSaveDocument";
        public const string usp_DM_DeleteAutoSaveDocument = "usp_DM_DeleteAutoSaveDocument";
        public const string USP_P2P_REQ_GETREQUISITIONDETAILSFORRFXTOPO = "usp_P2P_REQ_GetRequisitionDetailsForRFXToPO";
        public const string USP_P2P_GetContractItemsByContractNumber = "USP_P2P_GetContractItemsByContractNumber";
        public const string USP_P2P_REQ_ValidateContractNumber = "USP_P2P_REQ_ValidateContractNumber";
        public const string USP_P2P_REQ_GETSAVEDVIEWS_WORKBENCH = "usp_P2P_GetSavedViews";
        public const string USP_P2P_REQ_INSERTUPDATESAVEDVIEWS_WORKBENCH = "usp_P2P_InsertUpdateSavedViewInfo";
        public const string USP_P2P_REQ_DELETEAVEDVIEWS_WORKBENCH = "usp_p2p_deletesavedviewinfo";

        public const string USP_P2P_REQ_UPDATEREQUISITIONITEMAUTOSOURCEPROCESSFLAG =
            "USP_P2P_REQ_UpdateRequisitionItemAutoSourceProcessFlag";

        public const string USP_P2P_PO_SAVEREQUISITIONORDERMAPPING = "USP_P2P_PO_SaveRequisitionOrderMapping";

        public const string USP_P2P_REQ_SAVEREQUISITIONNOTESORATTACHMENTS =
            "usp_P2P_REQ_SaveRequisitionNotesOrAttachments";

        public const string USP_P2P_REQ_GETREQUISITIONNOTESORATTACHMENTS =
            "usp_P2P_REQ_GetRequisitionNotesOrAttachments";

        public const string USP_P2P_REQ_DELETEREQUISITIONNOTESORATTACHMENTS =
            "usp_P2P_REQ_DeleteRequisitionNotesOrAttachments";

        public const string USP_P2P_GETCATEGORYTYPES = "usp_p2p_getcategorytypes";
        public const string USP_P2P_REQ_ASSIGNBUYERTOREQUISITIONITEMS = "usp_P2P_REQ_AssignBuyerToRequisitionItems";
        public const string USP_P2P_REQ_GETLISTOFASSIGNBUYERS = "usp_REQ_GetListofAssignBuyers";
        public const string USP_P2P_REQ_GETLINEITEMSFORWORKBENCH = "usp_P2P_REQ_GetLineItemsForWorkBench";
        public const string USP_P2P_REQ_PRORATETAX = "usp_P2P_REQ_ProrateTax";
        public const string USP_P2P_INV_GETREQUISITIONHEADERTAXES = "usp_P2P_REQ_GetRequisitionHeaderTaxes";
        public const string USP_P2P_INV_UPDATEREQUISITIONHEADERTAXES = "usp_P2P_REQ_UpdateRequisitionHeaderTaxes";

        public const string USP_P2P_REQ_UPDATEBUYERTOREQUISITIONITEMS = "USP_P2P_REQ_UpdateBuyerToRequisitionItems";
        public const string USP_P2P_REQ_GETPOITEMSFORWORKBENCH = "usp_P2P_REQ_GetPOItemsForWorkBench";
        public const string USP_P2P_REQ_CHANGEREQUISITIONREQUEST = "usp_P2P_REQ_ChangeRequisitionRequest";
        public const string USP_P2P_REQ_UPDATERFXANDPOMAPPING = "usp_P2P_REQ_UpdateRfxAndPoMapping";
        public const string USP_P2P_REQ_GETREVISIONNUMBERBYDOCUMENTCODE = "usp_P2P_REQ_GetRevisionNumberByDocumentCode";
        public const string USP_P2P_COPYREQUISITIONEXISTINGTONEW = "usp_P2P_CopyRequisitionExistingToNew";
        public const string USP_P2P_REQ_REVOKECHANGEREQUISITION = "usp_P2P_REQ_RevokeChangeRequisition";
        public const string USP_P2P_REQ_VALIDATEREQWORKBENCHITEMS = "USP_P2P_REQ_ValidateReqWorkbenchItems";

        public const string USP_P2P_REQ_SAVEREQUISITIONCHARGEACCOUNTINGDETAILS =
            "usp_P2P_REQ_SaveRequisitionChargeAccountingDetails";

        public const string USP_P2P_REQ_GETLINEITEMCHARGES = "usp_P2P_REQ_GetLineItemCharges";
        public const string USP_P2P_DELETEREQUISITIONTEMCHARGE = "usp_P2P_DeleteRequisitiontemCharge";

        public const string USP_P2P_REQ_SAVEREQUISITIONCHARGEDEFAULTACCOUNTING =
            "usp_P2P_REQ_SaveRequisitionChargeDefaultAccounting";

        public const string USP_P2P_REQ_SAVEREQUISITIONCHARGEDEFAULTACCOUNTINGFORINTERFACE =
            "usp_P2P_REQ_SaveRequisitionChargeDefaultAccountingforInterface";

        public const string USP_P2P_REQ_CheckBiddingInProgress = "usp_P2P_REQ_CheckBiddingInProgress";

        public const string USP_P2P_REQ_VALIDATEDOCUMENTBEFORENEXTACTION =
            "usp_P2p_Req_ValidateDocumentBeforeNextAction";

        public const string USP_P2P_REQ_SAVEBUYERASSIGNEE = "usp_p2p_Req_SaveBuyerAssignee";
        public const string USP_P2P_REQ_SAVEREQUISITIONDEATILS = "usp_P2P_REQ_SaveRequisitionDetails";
        public const string USP_P2P_REQ_SAVEREQUISITIONENTITYDETAILS = "usp_P2P_REQ_SaveRequisitionEntityDetails";
        public const string USP_P2P_REQ_SAVEREQITEMSHIPPING = "usp_P2P_REQ_SaveReqItemShippingDetails";

        public const string USP_P2P_VALIDATEITEMDETAILSTOBEDERIVEDFROMINTERFACE =
            "usp_P2P_ValidateItemDetailsToBeDerivedFromInterface";

        public const string USP_P2P_DERIVEITEMDETAILS = "usp_P2P_DeriveItemDetails";
        public const string USP_P2P_SAVEFLIPPEDQUESTIONSRESPONSES = "usp_P2P_SaveFlippedQuestionResponses";

        #endregion Requisition StoreProcedures

        #region Notes And Attachements

        public const string COL_NOTES_ATTACH_ID = "NotesOrAttachmentId";
        public const string COL_NOTES_ATTACH_DESC = "NoteOrAttachmentDescription";
        public const string COL_NOTES_ATTACH_NAME = "NoteOrAttachmentName";
        public const string COL_NOTES_ATTACH_TYPE = "NoteOrAttachmentType";
        public const string COL_NOTES_ATTACH_ACCESSTYPE = "AccessTypeId";
        public const string COL_NOTES_ATTACH_MODIFIEDDATE = "ModifiedDate";
        public const string COL_NOTES_ATTACH_ITEMID = "RequisitionItemId";
        public const string COL_NOTES_ATTACH_REQID = "RequisitionId";
        public const string COL_NOTES_ATTACH_CATEGORYTYPEID = "CategoryTypeId";
        public const string COL_NOTES_ATTACH_CAT_DESC = "CategoryTypeDescription";
        public const string COL_NOTES_ATTACH_CAT_ID = "CategoryTypeId";
        public const string COL_NOTES_ATTACH_FILESIZE = "FileSize";

        #endregion Notes And Attachements

        #region Requisition LineItem Columns

        public const string COL_REQUISITION_ITEM_ID = "RequisitionItemID";
        public const string COL_UOM_AllowDecimal = "UOMAllowDecimal";
        public const string COL_P2P_LINE_ITEM_ID = "P2PLineItemID";
        public const string COL_SHORT_NAME = "ShortName";
        public const string COL_DESCRIPTION = "Description";
        public const string COL_UNIT_PRICE = "UnitPrice";
        public const string COL_PERCENTAGE = "Percentage";
        public const string COL_QUANTITY = "Quantity";
        public const string COL_RECEIVED_QUANTITY = "ReceivedQuantity";
        public const string COL_UOM = "UOM";
        public const string COL_STANDARD_UOM = "StandardUOM";
        public const string COL_UOM_DESC = "UOMDescription";
        public const string COL_UOMDesc = "UOMDesc";
        public const string COL_CommentText = "CommentText";
        public const string COL_DATE_REQUESTED = "DateRequested";
        public const string COL_DATE_NEEDED = "DateNeeded";
        public const string COL_MANUFACTURER_NAME = "ManufacturerName";
        public const string COL_MANUFACTURER_PART_NUMBER = "ManufacturerPartNumber";
        public const string COL_CATEGORY_ID = "CategoryID";
        public const string COL_CATEGORY_NAME = "CategoryName";
        public const string COL_ITEM_TYPE_ID = "ItemTypeID";
        public const string COL_ITEM_EXTENDED_TYPE = "ItemExtendedType";
        public const string COL_EFFORTS = "Efforts";
        public const string COL_TOTAL_ITEMS_COUNT = "TotalItemCount";
        public const string COL_LINE_ITEM_TAX = "Tax";
        public const string COL_LINE_ITEM_EXTERNAL_TAX = "ExternalTax";
        public const string COL_LINE_ITEM_VENDOR_TAX = "VendorTax";
        public const string COL_INVOICETOTAL_TAX = "InvoiceTotalTax";
        public const string COL_START_DATE = "StartDate";
        public const string COL_END_DATE = "EndDate";
        public const string COL_TOTAL_AMOUNT = "TotalAmount";
        public const string COL_ITEM_TOTAL_AMOUNT = "ItemTotalAmount";
        public const string COL_CREATED_BY_NAME = "CreatedByName";
        public const string COL_PARTNER_NAME = "PartnerName";
        public const string COL_Partner_Contact_Name = "PartnerContactName";
        public const string COL_SOURCE_TYPE = "SourceType";
        public const string COL_REQITEM_SHIPPING_ID = "ReqLineItemShippingID";
        public const string COL_ITEM_CODE = "ItemCode";
        public const string COL_IS_PROCURABLE = "IsProcurable";
        public const string COL_ITEM_STATUS = "ItemStatus";
        public const string COL_INVOICING_STATUS = "InvoicingStatus";
        public const string COL_RECEIVING_STATUS = "ReceivingStatus";
        public const string COL_ACCOUNTING_STATUS = "AccountingStatus";
        public const string COL_ORDERENTITYID = "OrderEntityId";
        public const string COL_BLANKET_DOCUMENTCODE = "BlanketDocumentCode";
        public const string COL_BLANKET_STARTDATE = "BlanketStartDate";
        public const string COL_BLANKET_ENDDATE = "BlanketEndDate";
        public const string COL_BLANKET_AMOUNT = "BlanketValue";
        public const string COL_RELEASE_ORDER_COUNT = "ReleaseOrderCount";
        public const string COL_BLANKET_DOCUMENTNUMBER = "BlanketDocumentNumber";
        public const string COL_CONSUMED_AMOUNT = "ConsumedAmount";
        public const string COL_PARTNER_STATUSCODE = "PartnerStatusCode";
        public const string COL_BILLABLE = "Billable";
        public const string COL_INVENTORYTYPE = "InventoryType";
        public const string COL_PROCUREMENTSTATUS = "ProcurementStatus";
        public const string COL_CAPITALIZED = "Capitalized";
        public const string COL_ORDERTAX = "OrderTax";
        public const string COL_ORDERSHIPPING = "OrderShipping";
        public const string COL_ORDERADDITIONALCHARGES = "OrderAdditionalCharges";
        public const string COL_INVOICEORDERTAXDIFFERENCE = "InvoiceOrderTaxDifference";
        public const string COL_TAXEXEMPTEDINVOICETOTAL = "TaxexemptionInvoiceTotal";
        public const string COL_INVOICINGTAX = "InvoicingTax";
        public const string COL_USEDTAX = "UsedTax";
        public const string COL_ACCOUNTNUMBER = "AccountNumber";
        public const string COL_TYPEOFITEM = "TypeOfItem";
        public const string COL_PARTNERCONTACTNAME = "PartnerContactName";
        public const string COL_PARTNERCONTACTID = "PartnerContactId";
        public const string COL_ORDERLOCATIONID = "OrderLocationId";
        public const string COL_ORDERLOCATIONNAME = "OrderLocationName";
        public const string COL_ORDERLOCATIONADDRESS = "OrderLocationAddress";
        public const string COL_ORDERLOCATIONCODE = "OrderLocationCode";
        public const string COL_REQITEMTOTAL = "ReqItemTotal";
        public const string COL_REQTOTAL = "ReqTotal";
        public const string COL_REQITEMVALUE = "ReqItemValue";
        public const string COL_PARENTPOITEMTOTAL = "ParentPOItemTotal";
        public const string COL_PARENTPOITEMVALUE = "ParentPOItemValue";
        public const string COL_DISPATCHMODE = "DispatchMode";
        public const string COL_REQ_ITEM_LINENUMBER = "ReqItemLineNumber";
        public const string COL_PROMISEDDATE = "PromisedDate";
        public const string COL_ESTIMATEDDELIVERYDATE = "EstimatedDeliveryDate";
        public const string COL_LEADTIME = "LeadTime";
        public const string COL_CREATEDON = "CreatedOn";
        public const string COL_PartnerEmailId = "PartnerEmailId";
        public const string COL_OVERALLITEMLIMIT = "OverallItemLimit";
        public const string COL_OVERALLITEMTAXLIMIT = "OverallItemTaxLimit";
        public const string COL_RULEEXTENDEDTYPE = "RuleExtendedType";
        public const string COL_ORDERTOTAL = "OrderItemTotal";
        public const string COL_ISOVERALLLIMITALLOWED = "IsOverallLimitAllowed";
        public const string COL_OVERALLLIMIT = "OverAllLimit";
        public const string COL_BUYERCONTACTCODE = "BuyerContactCode";
        public const string COL_ERRORSTRING = "ErrorString";
        public const string COL_ISERSENABLED = "IsERSEnabled";
        public const string COL_SOURCEQUESTIONID = "SourceQuestionId";
        public const string COL_TARGETQUESTIONID = "TargetQuestionId";
        public const string COL_SOURCEDOCUMENTTYPE = "SourceDocumentType";
        public const string COL_TARGETDOCUMENTTYPE = "TargetDocumentType";
        public const string COL_SOURCECHOICEID = "SourceChoiceId";
        public const string COL_TARGETCHOICEID = "TargetChoiceId";
        public const string COL_PREVORDEROVERALLTOTALAMOUNT = "PrevOrderOverallTotalAmount";

        public const string COL_PartnerAddressLine1 = "PartnerAddressLine1";
        public const string COL_PartnerAddressLine2 = "PartnerAddressLine2";
        public const string COL_PartnerAddressLine3 = "PartnerAddressLine3";
        public const string COL_PartnerCity = "PartnerCity";
        public const string COL_PartnerZipCode = "PartnerZipCode";
        public const string COL_PartnerStateName = "PartnerStateName";
        public const string COL_PartnerCountryName = "PartnerCountryName";
        public const string COL_PartnerPhone1 = "PartnerPhone1";
        public const string COL_PartnerPhone2 = "PartnerPhone2";
        public const string COL_BuyerAddressLine1 = "BuyerAddressLine1";
        public const string COL_BuyerAddressLine2 = "BuyerAddressLine2";
        public const string COL_BuyerAddressLine3 = "BuyerAddressLine3";
        public const string COL_BuyerStateName = "BuyerStateName";
        public const string COL_BuyerZipode = "BuyerZipode";
        public const string COL_BuyerCity = "BuyerCity";
        public const string COL_BuyerCountryName = "BuyerCountryName";
        public const string COL_BuyerPhone1 = "BuyerPhone1";
        public const string COL_BuyerPhone2 = "BuyerPhone2";
        public const string COL_BuyerEmailId = "BuyerEmailId";
        public const string COL_formId = "formId";
        public const string COL_HasFlexibleCharges = "HasFlexibleCharges";
        public const string COL_PartnerImageUrl = "PartnerImageUrl";
        public const string COL_TotalAllowance = "TotalAllowance";
        public const string COL_SUPPLIERADDRESS = "SupplierAddress";

        #endregion Requisition LineItem Columns

        #region Requisition LineItem StoreProcedures

        public const string USP_P2P_REQ_GETREQUISITIONLINEITEMS = "usp_P2P_REQ_GetRequisitionLineItems";
        public const string USP_P2P_REQ_UPDATEREQUISITIONSEARCHINDEXKEY = "usp_P2P_REQ_UpdateRequisitionSearchIndexKey";
        public const string USP_P2P_REQ_GETALLLINEITEMSBYID = "usp_P2P_REQ_GetAllLineItemsById";
        public const string USP_P2P_REQ_DELETELINEITEMBYID = "usp_P2P_REQ_DeleteLineItemById";
        public const string USP_P2P_REQ_UPDATEITEMQUANTITY = "usp_P2P_REQ_UpdateItemQuantity";
        public const string USP_P2P_REQ_GETPARTNERDETAILSBYLIID = "usp_P2P_REQ_GetPartnerDetailsByLiId";
        public const string USP_P2P_REQ_GETSHIPPINGSPLITDETAILSBYLIID = "usp_P2P_REQ_GetShippingSplitDetailsByLiId";
        public const string USP_P2P_REQ_GETOTHERITEMDETAILSBYLIID = "usp_P2P_REQ_GetOtherItemDetailsByLiId";
        public const string USP_P2P_SAVECATALOGREQUISITION = "usp_P2P_SaveCatalogRequisition";

        public const string USP_P2P_UPDATEPROCUREMENTSTATUSBYREQITEMID =
            "usp_P2P_REQ_UpdateProcurementStatusByReqItemId";

        public const string USP_P2P_SAVECATALOGORDER = "usp_P2P_SaveCatalogOrder";
        public const string USP_P2P_REQ_GETLINEITEMTAXDETAILS = "usp_P2P_REQ_GetLineItemTaxDetails";

        public const string USP_P2P_REQ_GETREQUISITIONITEMACCOUNTINGSTATUS =
            "usp_P2P_REQ_GetRequisitionItemAccountingStatus";

        public const string USP_P2P_REQ_COPYLINEITEM = "usp_P2P_REQ_CopyLineItem";
        public const string USP_P2P_REQ_UPDATETAXONLINEITEM = "usp_P2P_REQ_UpdateTaxOnLineItem";
        public const string USP_P2P_REQ_UPDATEORGENTITIESFROMCATALOG = "usp_P2P_REQ_UpdateOrgEntitiesFromCatalog";

        public const string USP_P2P_REQ_UPDATEORGENTITIESFROMCATALOGBYITEMID =
            "usp_P2P_REQ_UpdateOrgEntitiesFromCatalogByItemId";

        public const string USP_P2P_REQ_DELETELINEITEMSBYORGENTITYCODE = "usp_P2P_REQ_DeleteLineItemsByOrgEntityCode";
        public const string USP_P2P_REQ_DELETELINEITEMSONBUCHANGE = "usp_P2P_REQ_DeleteLineItemsOnBUChange";
        public const string USP_P2P_REQ_SAVECONTRACTINFORMATION = "usp_P2P_REQ_SaveContractInformation";
        public const string USP_P2P_DELETELINEITEMSBYEXTENDEDTYPEIDS = "USP_P2P_REQ_DeleteLineItemsByExtendedTypeIds";
        public const string USP_P2P_REQ_GETALLQUESTIONNAIRE = "usp_P2P_REQ_GetAllQuestionnaire";
        public const string USP_P2P_PO_GETALLQUESTIONNAIRE = "usp_P2P_PO_GetAllQuestionnaire";

        public const string USP_P2P_UPDATEREQLINESTATUSONRFXCREATEORUPDATE =
            "usp_P2P_REQ_UpdateReqLineStatusonRFXCreateorUpdate";

        public const string USP_P2P_REQ_SAVEITEM = "usp_P2P_SaveRequisitionItem";
        public const string USP_P2P_ValidatePartnerMappedWithOrgEntity = "USP_P2P_ValidatePartnerMappedWithOrgEntity";

        #endregion Requisition LineItem StoreProcedures

        #region Requisition TableTypes

        public const string TVP_P2P_REQUISITIONITEM = "tvp_P2P_RequisitionItem";
        public const string TVP_P2P_SETTINGVALUES = "tvp_P2P_SettingValues";
        public const string TVP_P2P_LINEITEMSTAXANDSHIPPING = "tvp_P2P_LineItemsTaxandShipping";
        public const string TVP_P2P_NOTESORATTACHMENTS = "tvp_P2P_NotesOrAttachmentsIds";
        public const string TVP_P2P_REQUISITIONITEMBUYERUPDATE = "tvp_P2P_RequisitionItemBuyerUpdate";

        #endregion Requisition TableTypes

        #endregion Requisition

        #region Order

        #region Order Columns

        public const string COL_ORDER_ID = "OrderID";
        public const string COL_ORDER_NAME = "OrderName";
        public const string COL_ORDER_NUMBER = "OrderNumber";
        public const string COL_ORDER_STATUS = "OrderStatus";
        public const string COL_ORDER_SOURCE = "OrderSource";
        public const string COL_ORDER_LOCATIONID = "OrderLocationID";
        public const string COL_MATCHTYPE = "MatchType";
        public const string COL_ITEMTOTAL = "ItemTotal";
        public const string COL_ORDERAMOUNT = "OrderAmount";
        public const string COL_ORDERSUBMITTEDBY = "SubmittedBy";
        public const string COL_OrderSubmittedDate = "OrderSubmittedDate";
        public const string COL_Rebillable = "Rebillable";
        public const string COL_DueDate = "DueDate";
        public const string COL_EXTENDEDSTATUS = "ExtendedStatus";
        public const string COL_DATEACKNOWLEDGED = "DateAcknowledged";
        public const string COL_ORDER_CONTACTCODE = "OrderContactCode";
        public const string COL_ORDER_ORDERCONTACTEMAIL = "OrderContactEmail";
        public const string COL_ORDER_ORDERCONTACTCODE = "OrderContactCode";
        public const string COL_ORDER_ISINTERNALITEMEXIST = "IsInternalItemExist";
        public const string COL_CLOSING_ORDER_STATUS = "ClosingOrderStatus";
        public const string COL_TRASMISSIONMODE = "TrasmissionMode";
        public const string COL_TRANSMISSIONVALUE = "TransmissionValue";
        public const string COL_ACKNOWELEDGED_BY = "AcknowledgedBy";
        public const string COL_ORDER_TYPE = "OrderType";
        public const string COL_PARENTITEM_UNITPRICE = "ParentItemUnitPrice";
        public const string COL_PARENTITEM_DATENEEDED = "ParentItemDateNeeded";
        public const string COL_POSIGNATORYCODE = "POSignatoryCode";
        public const string COL_POSIGNATORYNAME = "POSignatoryName";
        public const string COL_PARENTDOCUMENTCODE = "ParentDocumentCode";
        public const string COL_REVISIONNUMBER = "RevisionNumber";
        public const string COL_ISCLOSEFORRECEIVING = "IsCloseForReceiving";
        public const string COL_ISCLOSEFORINVOICING = "IsCloseForInvoicing";
        public const string COL_ISENFORCELINEREFERENCE = "IsEnforceLineReference";
        public const string COL_MATERIAL_RECEIVING_TOLERANCE = "MaterialReceivingTolerance";
        public const string COL_SERVICE_RECEIVING_TOLERANCE = "ServiceReceivingTolerance";
        public const string COL_ITEM_RECEIVING_TOLERANCE = "ItemReceivingTolerance";
        public const string COL_ISRESENT = "RESENT";
        public const string COL_ISORDERANDINVOICECONTACTSAME = "IsOrderAndInvoiceContactSame";
        public const string COL_CURRENTDATEMINUSINVOICEDATE = "CurrentDateMinusInvoiceDate";
        public const string COL_ISORDERANDINVOICECURRENCYSAME = "IsOrderAndInvoiceCurrencySame";
        public const string COL_IS_ALL_NEGATIVE_ITEMS = "IsAllNegativeItems";
        public const string COL_ENTITYDETAILCODECCPGPC = "EntityDetailCode";
        public const string COL_ENTITYDESCRIPTIONCCPGPC = "EntityDescription";
        public const string COL_ISANYITEMINTHREEWAYMATCH = "IsAnyItemInThreeWayMatch";
        public const string COL_ServiceConfirmationRecevingStatus = "ServiceConfirmationRecevingStatus";
        public const string COL_INVOICEADVANCEAMOUNT = "InvoiceAdvanceAmount";
        public const string COL_INVOICEADJUSTMENTAMOUNT = "InvoiceAdjustmentAmount";
        public const string COL_ORDERADVANCEAMOUNT = "OrderAdvanceAmount";
        public const string COL_ADJUSTEDINVOICETOTAL = "AdjustedInvoiceTotal";
        public const string COL_AvailableADVANCEAMOUNT = "AvailableAdvanceAmount";
        public const string COL_ISADVANCED = "isAdvanced";
        public const string COL_QUANTITYVARIANCE = "QuantityVariance";
        public const string COL_UNITPRICEVARIANCE = "UnitPriceVariance";
        public const string COL_SHIPPINGCHARGESVARIANCE = "ShippingChargesVariance";
        public const string COL_TAXVARIANCE = "TaxVariance";
        public const string COL_ADDITIONALCHARGESVARIANCE = "AdditionalChargesVariance";
        public const string COL_ORDERAMOUNTVARIANCE = "OrderAmountVariance";
        public const string COL_LINEITEMVARIANCE = "LineItemVariance";
        public const string COL_PO_SPLIT_ITEM_ENTITYID = "OrderSplitItemEntityId";
        public const string COL_OLDORDERAMOUNT = "OldOrderAmount";
        public const string COL_IS_PCARDSUPPORTEDFORORDER = "IsPCardSupportedForOrder";
        public const string COL_SC_NUMBER = "ServiceConfirmationNumber";
        public const string COL_IS_PARTNERCONTACTACTIVE = "IsPartnerContactActive";
        public const string COL_PARENTORDERPAYMENTTERMID = "ParentOrderPaymentTermId";
        public const string COL_PARENTORDERPAYMENTTERMS = "ParentOrderPaymentTerms";
        public const string COL_ERS = "ERS";
        public const string COL_EXCHANGE_RATE = "ExchangeRate";
        public const string COL_ISMAINTAINREVISIONNUMBER = "isMaintainRevisionNumber";
        public const string COL_ISINTERNALCHANGEORDERFINALIZE = "isInternalChangeOrderFinalize";
        public const string COL_PARENTDOCUMENTSTATUSID = "ParentDocumentStatus";
        public const string COL_ORDER_NOTIFICATION_TO_CONTACTCODE = "NotificationToContactCode";
        public const string COL_ORDER_NOTIFICATION_TO_EMAILID = "NotificationContactToEmail";
        public const string COL_ORDER_NOTIFICATION_CC_CONTACTCODE = "NotificationCcContactCode";
        public const string COL_ORDER_NOTIFICATION_CC_EMAILID = "NotificationContactCcEmail";
        public const string COL_CHANGE_ORDER_CREATOR = "ChangeOrderCreator";
        public const string COL_DOCUMENT_STAKEHOLDER_ID = "DocumentStakeholderId";
        public const string COL_STAKEHOLDER_DOCUMENT_STATUS = "StakeholderDocumentStatus";
        public const string COL_STAKEHOLDER_TYPE_INFO = "StakeholderType";
        public const string COL_CONTACT_NAME = "ContactName";
        public const string COL_PROXY_CONTACT_CODE = "ProxyContactCode";
        public const string COL_ISALLOWCREATEASN = "IsAllowCreateASN";
        public const string COL_ERROR_MESSAGE_KEY = "ErrorMessageKey";
        public const string COL_ERROR_MESSAGE_VALUE = "ErrorMessageValue";
        public const string usp_P2P_PO_UpdateInterfaceDocumentStatus = "usp_P2P_PO_UpdateInterfaceDocumentStatus";
        public const string COL_ORDEREXTENDEDSTATUS = "OrderExtendedStatus";

        #endregion Order Columns

        #region Order StoredProcedures

        public const string USP_P2P_PO_GETALLDISPLAYDETAILS = "usp_P2P_PO_GetAllDisplayDetails";
        public const string USP_P2P_GETCOSTCENTERPLANTCODEPURCGROUP = "usp_P2P_GetCostCenterPlantCodePurcDept";

        public const string USP_P2P_PO_GETORDERBASICDETAILSBYID = "usp_P2P_PO_GetOrderBasicDetailsById";

        public const string USP_P2P_PO_GETORDERBASICDETAILSBYIDFORITEMS =
            "usp_P2P_PO_GetOrderBasicDetailsByIdForLineItems";

        public const string USP_P2P_PO_GETORDERDETAILSFORAPPROVAL = "usp_P2P_PO_GetOrderDetailsForApproval";
        public const string USP_P2P_PO_GENERATEDEFAULTORDERNAME = "usp_P2P_PO_GenerateDefaultOrderName";
        public const string USP_P2P_PO_CREATREQUISTIONORDER = "usp_P2P_PO_CreateRequistionOrder";
        public const string USP_P2P_PO_GETORDERLINEITEMS = "usp_P2P_PO_GetOrderLineItems";
        public const string USP_P2P_PO_GETORDERLINEITEMS_FOR_INTERFACE = "usp_P2P_PO_GetOrderLineItemsForInterface";
        public const string USP_P2P_PO_GETREQUISITIONNUMBERFROMORDERID = "usp_P2P_PO_GetRequisitionNumberFromOrderId";
        public const string USP_P2P_PO_GETALLORDERSFORLEFTPANEL = "usp_P2P_PO_GetAllOrdersForLeftPanel";

        public const string USP_P2P_PO_GETALLREQUISITIONSFORORDERLEFTPANEL =
            "usp_P2P_PO_GetAllRequisitionsForOrderLeftPanel";

        public const string USP_P2P_PO_SAVEORDERITEMPARTNERS = "usp_P2P_PO_SaveOrderItemPartners";
        public const string USP_P2P_PO_SAVEORDERITEMSHIPPING = "usp_P2P_PO_SaveOrderItemShippingDetails";
        public const string USP_P2P_PO_SAVEORDERITEMSHIPPING_TUNED = "usp_P2P_PO_SaveOrderItemShippingDetailsTuned";
        public const string USP_P2P_PO_SAVEORDER = "usp_P2P_PO_SaveOrder";

        public const string USP_P2P_GETREQUISITIONITEMSCOUNTBYPARTNERCODE =
            "usp_P2P_GetRequisitionItemsCountByPartnerCode";

        public const string USP_P2P_PO_UPDATEORDERSTATUS = "usp_P2P_PO_UpdateOrderStatus";
        public const string USP_P2P_PO_ADDREQUISITIONSTOORDER = "USP_P2P_PO_AddRequisitionsToOrder";
        public const string USP_P2P_PO_VALIDATEDOCUMENTBEFORENEXTACTION = "usp_P2P_PO_ValidateDocumentBeforeNextAction";
        public const string USP_P2P_PO_GETINVOICINGSTATUSBYID = "usp_P2P_PO_GetInvoicingStatusById";
        public const string USP_P2P_PO_CALCULATEPORECEIVINGSTATUS = "usp_P2P_PO_CalculatePOReceivingStatus";

        public const string USP_P2P_PO_RECALCULATEPORECEIVINGSTATUSBYORDERID =
            "usp_P2P_PO_UpdateChangeOrderReceivingStatus";

        public const string USP_P2P_PO_RECALCULATEPOINVOICINGSTATUSBYORDERID =
            "usp_P2P_PO_UpdateChangeOrderInvoicingStatus";

        public const string USP_P2P_PO_GETORDERINFOBYDOCUMENTCODE = "usp_P2P_PO_GetOrderInfoByDocumentCode";
        public const string USP_P2P_PO_GETORDERINVOICINGSTATUS = "usp_P2P_PO_GetOrderInvoicingStatus";
        public const string USP_P2P_PO_CHANGEORDERREQUEST = "usp_P2P_PO_ChangeOrderRequest";
        public const string USP_P2P_PO_CANCELCHANGEORDER = "usp_P2P_PO_CancelChangeOrder";
        public const string USP_P2P_PO_GETALLINVOICESANDRECEIPTS = "usp_P2P_PO_GetAllInvoicesAndReceipts";

        public const string USP_P2P_PO_GETPRIVOUSORDERVERSION_AND_REMOVEORDERITEMS =
            "usp_P2P_PO_GetPreviousOrderVersion";

        public const string USP_P2P_PO_REJECTCHANGEREQUEST = "usp_P2P_PO_RejectChangeRequest";
        public const string USP_P2P_PO_COMPARECHANGEREQUESTTOORDER = "usp_P2P_PO_CompareChangeRequestToOrder";
        public const string USP_P2P_PO_CHECKORDERVERSIONEXISTS = "usp_P2P_PO_CheckOrderVersionExists";
        public const string USP_P2P_PO_SAVEORDERITEMSTATUS = "usp_P2P_PO_SaveOrderItemStatus";
        public const string USP_P2P_PO_GETALLDOCUMENTSFORCANCELEDORDER = "usp_P2P_PO_GetAllDocForCanceledOrder";
        public const string USP_P2P_PO_UPDATEORDERCANCELLEDDATE = "usp_P2P_PO_UpdateOrderCancelledDate";
        public const string USP_P2P_PO_SAVEORDERACCOUNTINGDETAILS = "usp_P2P_PO_SaveOrderAccountingDetails";
        public const string USP_P2P_PO_SAVEORDERACCOUNTINGDETAILS2 = "usp_P2P_PO_SaveOrderAccountingDetailsV2";

        public const string USP_P2P_PO_SAVEORDERCHARGEACCOUNTINGDETAILSV2 =
            "usp_P2P_PO_SaveOrderChargeAccountingDetailsV2";

        public const string USP_P2P_PO_GETORDERACCOUNTINGDETAILSBYITEMID =
            "USP_P2P_PO_GetOrderAccountingDetailsByItemId";

        public const string USP_P2P_DELETE_REQUISITIONBY_DOCUMENTCODE = "usp_P2P_DeleteRequisitionByDocumentCode";

        public const string USP_P2P_PO_GENERATEDEFAULTORDERNAMEFORFLIPTOORDER =
            "usp_P2P_PO_GenerateDefaultOrderNameforFliptoOrder";

        public const string USP_P2P_PO_GETALLCATEGORIESBYORDERID = "usp_P2P_PO_GetAllCategoriesByOrderId";
        public const string USP_P2P_PO_GETORDER_ENTITIES = "usp_P2P_PO_GetOrderEntities";
        public const string USP_P2P_PO_GETALLCHANGEORDERSBYINVOICEORIR = "usp_P2P_PO_GetAllChangeOrdersByInvoiceorIR";
        public const string USP_P2P_GETRELATEDDOCUMENTS = "usp_P2P_GetRelatedDocuments";
        public const string USP_P2P_GETRELATEDDOCUMENTSDETAILS = "usp_P2P_GetRelatedDocumentsDetails";
        public const string USP_P2P_PO_GETORDERIDBYORDERNUMBERANDSTATUS = "usp_P2P_PO_GetOrderIdByOrderNumberAndStatus";
        public const string USP_P2P_GENERATELOCATIONCODE = "usp_P2P_GenerateLocationCode";
        public const string USP_P2P_PO_GETORDERENTITYDETAILSBYID = "usp_P2P_PO_GetOrderEntityDetailsById";
        public const string USP_P2P_PO_SAVEORDERADDITIONALENTITYDETAILS = "usp_P2P_PO_SaveOrderAdditionalEntityDetails";

        public const string USP_P2P_PO_GETORDERDETAILSFORCOMPARISIONBYID =
            "usp_P2P_PO_GetOrderDetailsForComparisionById";

        public const string USP_P2P_PO_GETORDERITEMDETAILSFORCOMPARISIONBYID =
            "usp_P2P_PO_GetOrderItemDetailsForComparisionById";

        public const string USP_P2P_PO_COMPAREACCOUNTINGDETAILSFORAPPROVAL =
            "usp_P2P_PO_CompareAccountingDetailsForApproval";

        public const string USP_P2P_PO_UPDATEINTERFACESTATUS = "usp_P2P_PO_UpdateInterfaceStatus";
        public const string USP_P2P_PO_CREATERELEASEORDER = "usp_P2P_PO_CreateReleaseOrder";
        public const string USP_P2P_PO_GETLINEITEMTAXDETAILS = "usp_P2P_PO_GetLineItemTaxDetails";

        public const string USP_P2P_PO_GETLINEITEMTAXDETAILS_FORLISTOFDOCUMENTITEMIDS =
            "usp_P2P_PO_GetLineItemTaxDetails_ForListOfDocumentItemIds";

        public const string USP_P2P_PO_PRORATELINEITEMTAX = "usp_P2P_PO_ProrateLineItemTax";
        public const string USP_P2P_PO_PRORATESHIPPINGANDFREIGHT = "usp_P2P_PO_ProrateShippingAndFreight";
        public const string USP_P2P_PO_UPDATETAXONHEADERSHIPTO = "usp_P2P_PO_UpdateTaxOnHeaderShipTo";
        public const string USP_P2P_PO_CALCULATE_AND_UPDATELINEITEMTAX = "usp_P2P_PO_CalculateAndUpdateLineItemTax";
        public const string USP_P2P_PO_GETMODIFIEDITEMSINCHANGEORDER = "usp_P2P_PO_GetModifiedItemsInChangeOrder";
        public const string USP_P2P_PO_GETORDERSFORINTERFACE = "usp_P2P_PO_GetOrdersForInterface";
        public const string USP_P2P_PO_GETORDERITEMIDBYP2PLIID = "usp_P2P_PO_GetOrderItemIdByP2PLiId";
        public const string USP_P2P_PO_GETCATALOGNONCATALOGCHECK = "usp_P2P_PO_GetCatalogNonCatalogCheck";

        public const string USP_P2P_PO_UPDATECONSUMEDAMOUNTFORBLANKETORDER =
            "usp_P2P_PO_UpdateConsumedAmountForBlanketOrder";

        public const string USP_P2P_PO_PRORATEHEADERTAXANDSHIPPING = "usp_P2P_PO_ProrateHeaderTaxAndShipping";
        public const string USP_P2P_PO_GETVALIDATIONERRORCODEBYID = "usp_P2P_PO_GetValidationErrorCodeById";
        public const string USP_P2P_PO_SAVEORDERACCOUNTINGAPPLYTOALL = "usp_P2P_PO_SaveOrderAccountingApplyToAll";
        public const string USP_P2P_PO_GETALLACTIVEPAYMENTTERMS = "usp_P2P_PO_GetAllActivePaymentTerms";
        public const string USP_P2P_GETPAYMENTTERMSBYID = "usp_P2P_GetPaymentTermsById";
        public const string USP_P2P_PO_GETGLDETAILS = "usp_P2P_PO_GetGLDetails";
        public const string USP_P2P_PO_GETORGENTITYDETAILS = "usp_P2P_PO_GetOrgEntityDetails";
        public const string USP_P2P_GETINTERFACECONFIGURATIONDETAILS = "usp_P2P_GetInterfaceConfigurationDetails";
        public const string USP_P2P_PO_VALIDATEINTERFACEDOCUMENT = "usp_P2P_PO_ValidateInterfaceDocument";

        public const string USP_P2P_PO_UPDATEEDOCUMENTITEMRECEIVEINGSTATUS =
            "usp_P2P_PO_UpdateDocumentItemReceivingStatus";

        public const string USP_P2P_GETWORKFLOWDOCTYPEFORDOCUMENT = "usp_P2P_GetWorkflowDocTypeForDocument";
        public const string USP_P2P_PO_GETALLORDERSFORAUTOCLOSE = "usp_P2P_PO_GetAllOrdersForAutoClose";
        public const string USP_P2P_PO_UPDATEORDER_REQ_MAPPING = "usp_P2P_PO_UpdateOrderReqMapping";
        public const string USP_P2P_PO_DELETE_ALL_LINEITEMS_BY_ORDERID = "usp_P2P_PO_DeleteAllLineItemsByOrderId";
        public const string USP_P2P_PO_COPY_ORDERS_TO_ORDER = "usp_P2P_PO_CopyOrdersToOrder";
        public const string USP_P2P_PO_GETALLITEMIDSBYORDID = "usp_P2P_PO_GetAllItemIdsByOrdId";
        public const string USP_P2P_PO_GETORDERHEADERDETAILSBYID = "usp_P2P_PO_GetOrderHeaderDetailsById";

        public const string USP_P2P_PO_GETORDERHEADERDETAILSBYID_FOR_INTERFACE =
            "usp_P2P_PO_GetOrderHeaderDetailsByIdForInterface";

        public const string USP_P2P_PO_ORDERCATALOGITEMACCESS = "usp_P2P_PO_OrderCatalogItemAccess";
        public const string USP_P2P_PO_ADDTEMPLATEITEMSINORDER = "usp_P2P_PO_AddTemplateItemInOrder";
        public const string USP_P2P_PO_GETVALIDATIONFORCLOSINGORDER = "usp_P2P_PO_GetValidationForClosingOrder";
        public const string USP_P2P_PO_UPDATECLOSINGORDERSTATUS = "usp_P2P_PO_UpdateClosingOrderStatus";
        public const string USP_P2P_PO_CHECKCREATEINVOICEFORORDER = "usp_P2P_PO_CheckCreateInvoiceForOrder";
        public const string USP_P2P_PO_VALIDATEBLANKETORDER = "usp_P2P_PO_ValidateBlanketOrder";
        public const string USP_P2P_SAVEPOTRANSMISSIONMODE = "usp_P2P_SavePOTransmissionMode";
        public const string USP_P2P_PO_UPDATEORGENTITIESFROMCATALOG = "usp_P2P_PO_UpdateOrgEntitiesFromCatalog";
        public const string USP_P2P_COPYORDEREXISTINGTONEW = "usp_P2P_CopyOrderExistingToNew";
        public const string USP_P2P_PO_UPDATECONSUMEDAMOUNT = "usp_P2P_PO_UpdateConsumedAmount";
        public const string USP_P2P_PO_UPDATEBILLTOLOCATION = "usp_P2P_PO_UpdateBillToLocation";
        public const string USP_P2P_PO_DELETESPLITSBYITEMID = "usp_P2P_PO_DeleteSplitsByItemId";

        public const string USP_P2P_PO_DELETECHARGEANDSPLITSITEMSBYITEMCHARGEID =
            "usp_P2P_PO_DeleteChargeAndSplitsItemsByItemChargeId";

        public const string USP_P2P_REQ_DELETECHARGEANDSPLITSITEMSBYITEMCHARGEID =
            "usp_P2P_REQ_DeleteChargeAndSplitsItemsByItemChargeId";

        public const string usp_P2P_PO_CalculateInterfaceChargeItemSplitDetails =
            "usp_P2P_PO_CalculateInterfaceChargeItemSplitDetails";

        public const string USP_P2P_PO_CALCULATEINTERFACEITEMSPLITDETAILS =
            "usp_P2P_PO_CalculateInterfaceItemSplitDetails";

        public const string usp_P2P_REQ_CalculateInterfaceChargeItemSplitDetails =
            "usp_P2P_REQ_CalculateInterfaceChargeItemSplitDetails";

        public const string USP_P2P_PO_DELETELINEITEMSBYORGENTITYCODE = "usp_P2P_PO_DeleteLineItemsByOrgEntityCode";
        public const string USP_P2P_PO_GETALLORDERDETAILSBYORDERID = "usp_P2P_PO_GetAllOrderDetailsByOrderId";

        public const string USP_P2P_PO_GETALLORDERDETAILSBYORDERIDFORVIEWCHANGES =
            "usp_P2P_PO_GetAllOrderDetailsByOrderIdForViewChanges";

        public const string USP_P2P_PO_DELETELINEITEMSONBUCHANGE = "usp_P2P_PO_DeleteLineItemsOnBUChange";
        public const string USP_WF_GETMANAGERFORORGENTITY = "usp_WF_GetManagerForORGEntity";

        public const string USP_P2P_PO_UPDATEORGENTITIESFROMCATALOGBYITEMID =
            "usp_P2P_PO_UpdateOrgEntitiesFromCatalogByItemId";

        public const string USP_P2P_PO_GETORDERCAPITALCODECOUNTBYID = "usp_P2P_PO_GetOrderCapitalCodeCountById";
        public const string USP_P2P_PO_CONFIRMINGORDERREQUEST = "usp_P2P_PO_ConfirmingOrderRequest";
        public const string USP_P2P_PO_SAVECONTRACTINFORMATION = "usp_P2P_PO_SaveContractInformation";
        public const string USP_P2P_PO_GETORDERHEADERDETAILBYID = "usp_P2P_PO_GetOrderHeaderDetailById";
        public const string USP_P2P_PO_GETORDERITEMSCHANGED = "usp_P2P_PO_GetOrderItemsChanged";
        public const string USP_P2P_PO_GETALLCHANGEORDERSBYORDER = "usp_P2P_PO_GetAllChangeOrdersByOrder";
        public const string USP_P2P_PO_GETALLUSER = "usp_P2P_PO_GetAllUser";
        public const string USP_P2P_PO_UPDATEACCRUALDASHBOARD = "usp_P2P_PO_UpdateAccrualDashBoard";
        public const string USP_P2P_PO_GETORDERLISTFORCLOSINGORDER = "usp_P2P_PO_GetOrderListForClosingOrder";
        public const string USP_P2P_INV_SAVECONTRACTINFORMATION = "usp_P2P_INV_SaveContractInformation";
        public const string USP_P2P_PO_GETCONTRACTNUMBERBYORDERID = "usp_P2P_PO_GetContractNumberByOrderId";

        public const string USP_P2P_REQ_CALCULATEINTERFACEITEMSPLITDETAILS =
            "usp_P2P_REQ_CalculateInterfaceItemSplitDetails";

        public const string USP_P2P_PO_UPDATELINEITEMSCLOSEORDERSTATUS = "usp_P2P_PO_UpdateLineItemsCloseOrderStatus";

        public const string USP_P2P_REQ_GETALLPARTNERCODEANDORDERINGLOCATIONID =
            "usp_P2P_REQ_GetAllPartnerCodeAndOrderinglocationId";

        public const string USP_P2P_REQ_GETLISTERRORCODESBYORDERIDS = "usp_P2P_REQ_GetListErrorCodesByOrderIds";

        public const string USP_P2P_REQ_GETALLPARTNERCODEANDORDERINGLOCATION =
            "usp_P2P_REQ_GetAllPartnerCodeAndOrderinglocation";

        public const string USP_P2P_PO_GETORDERSBYPARTNERCODE = "usp_P2P_PO_GetOrdersByPartnerCode";
        public const string USP_P2P_INV_UPDATEDISPATCHHISTORY = "usp_P2P_PO_UpdateDispatchHistory";
        public const string USP_P2P_PO_GETDISPATCHDETAILS = "usp_p2p_PO_GetDispatchDetails";
        public const string USP_P2P_PO_INSERTUPDATELINEITEMTAXES = "usp_P2P_PO_InsertUpdateLineItemTaxes";
        public const string USP_P2P_VALIDATESHIPTOBILLTOFROMINTERFACE = "usp_P2P_ValidateShipToBillToFromInterface";
        public const string USP_P2P_REQ_INSERTUPDATELINEITEMTAXES = "usp_P2P_REQ_InsertUpdateLineItemTaxes";
        public const string USP_P2P_PO_GETSPLITDETAILS = "usp_P2P_PO_GetSplitDetails";
        public const string USP_P2P_REQ_GETSPLITDETAILS = "usp_P2P_REQ_GetSplitDetails";
        public const string USP_P2P_PO_GETREVISIONNUMBERBYDOCUMENTCODE = "usp_P2P_PO_GetRevisionNumberByDocumentCode";
        public const string USP_P2P_PO_GETREVISIONNUMBERFORRO = "usp_P2P_PO_GetRevisionNumberForRO";
        public const string USP_P2P_REC_GETREVISIONNUMBERBYDOCUMENTCODE = "usp_P2P_REC_GetRevisionNumberByDocumentCode";
        public const string USP_P2P_REC_GETRECEIPTIDBYRETURNNOTEID = "usp_P2P_REC_GetReceiptIdByReturnNoteId";
        public const string USP_P2P_PO_GETREQUISITIONNUMBERSBYORDERID = "usp_P2P_PO_GetRequisitionNumbersByOrderId";
        public const string USP_P2P_PO_UPDATEORDER_CREDITMEMO_MAPPING = "usp_P2P_PO_UpdateOrderCreditMemoMapping";
        public const string USP_P2P_PO_GETALLITEMIDSBYORDERID = "usp_P2P_PO_GetAllItemIdsByOrderdId";
        public const string USP_P2P_PO_DELETELINEITEMSBYEXTENDEDTYPEIDS = "USP_P2P_PO_DeleteLineItemsByExtendedTypeIds";
        public const string USP_P2P_PO_UPDATELINETYPEBYPURCHASETYPE = "usp_P2P_PO_UpdateLineTypeByPurchaseType";
        public const string USP_P2P_UPDATE_BULK_DOCUMENT_STATUS = "usp_P2P_UpdateBulkMatchingStatus";
        public const string USP_P2P_PO_GetFOBDETAILSFORINTERFACE = "usp_P2P_GetFOBDetailsForInterface";
        public const string USP_P2P_INV_GETDISPATCHDETAILS = "usp_p2p_INV_GetDispatchDetails";
        public const string USP_P2P_PO_VALIDATEPOFOREDITSHIPTOONCO = "usp_p2p_PO_ValidatePOForEditShipToOnCO";
        public const string USP_P2P_PO_GETORDERREPORTCONFIGURATION = "usp_P2P_PO_GetOrderReportConfiguration";

        public const string USP_P2P_PO_GETORDERDETAILSFOREXCELREPORTBYPARTNER =
            "usp_P2P_PO_GetOrderDetailsForExcelReportByPartner";

        public const string USP_P2P_PO_GETALLPOSWITHOUTINVOICEORRECEIPT = "usp_P2P_PO_GetALLPOsWithoutInvoiceOrReceipt";
        public const string USP_P2P_FLIPBLANKETACCOUNTINGDETAILSTOORDER = "usp_P2P_FlipBlanketAccountingDetailstoOrder";
        public const string USP_P2P_SAVEINTERFACEDOCUMENTS = "USP_P2P_SaveInterfaceDocuments";
        public const string USP_P2P_REC_CREATERECEIPTRETURNNOTECOPY = "usp_P2P_REC_CreateReceiptReturnNoteCopy";

        public const string USP_P2P_REC_UPDATERECEIPTRETURNNOTEDOCUMENTSTATUS =
            "usp_P2P_REC_UpdateReceiptReturnNoteDocumentStatus";

        public const string USP_P2P_PR_DELETELINEITEMSONBUCHANGE = "usp_P2P_PR_DeleteLineItemsOnBUChange";
        public const string usp_P2P_REC_GetAllReturnNotesByReceiptId = "usp_P2P_REC_GetAllReturnNotesByReceiptId ";
        public const string USP_P2P_PO_GETORDERVERSIONDETAILS = "usp_P2P_PO_GetOrderVersionDetails";
        public const string USP_P2P_REC_REVOKERECEIPTRETURNNOTE = "usp_P2P_REC_RevokeReceiptReturnNote";

        public const string USP_P2P_REC_GETNOTIFICATIONDETAILSBYRETURNNOTEID =
            "usp_P2P_REC_GetNotificationDetailsByReturnNoteId";

        public const string usp_P2P_PO_UPDATEPAYMENTTERMS = "usp_P2P_PO_UpdatePaymentTerms";

        public const string usp_P2P_PO_GETORDERSDETAILTOSENDNOTIFICATION =
            "usp_P2P_PO_GetOrdersDetailToSendNotification";

        public const string USP_P2P_PO_GETORDERNOTESORATTACHMENTS = "usp_P2P_PO_GetOrderNotesOrAttachments";
        public const string USP_P2P_PO_SAVEITEMORDERNOTESORATTACHMENTS = "usp_P2P_PO_SaveOrderNotesOrAttachments";
        public const string USP_P2P_PO_DELETEORDERNOTESORATTACHMENTS = "usp_P2P_PO_DeleteOrderNotesOrAttachments";

        public const string USP_P2P_GETCUSTOMATTRIBUTESWITHORDERID = "USP_P2P_GETCUSTOMATTRIBUTESWITHORDERID";
        public const string USP_P2P_GETALLQUESTIONNAIREBYFORMCODES = "usp_P2P_GetAllQuestionnaireByFormCodes";
        public const string usp_P2P_PO_GETORDERDETAILTOSENDNOTIFICATION = "usp_P2P_PO_GetOrderDetailToSendNotification";
        public const string USP_P2P_VALIDATEASL = "usp_P2P_ValidateASL";
        public const string USP_P2P_PO_UPDATEORDERMATCHTYPE = "usp_P2P_PO_UpdateOrderMatchType";
        public const string USP_DM_GETDOCUMENTSTAKEHOLDERDETAILS = "usp_DM_GetDocumentStakeholderDetails";
        public const string USP_P2P_PO_UPDATEBULKLINEITEMSTATUS = "usp_P2P_PO_UpdateBulkLineItemStatus";
        public const string USP_P2P_PO_GETTAXDETAILS = "usp_P2P_PO_GetTaxDetails";
        public const string USP_P2P_PO_GETBLANKETDETAILS = "usp_P2P_PO_GetBlanketDetails";
        public const string USP_P2P_GETBUYERASSIGNEE_DETAILS = "usp_P2P_GetBuyerAssignee_Details";
        public const string USP_P2P_GETQUESTIONNAIREROWCHOICES = "usp_P2P_GetQuestionnaireRowChoices";
        public const string USP_P2P_PO_GETAllORDERSMANAGEMASSUPDATE = "usp_P2P_PO_GetAllOrdersManageMassUpdate";
        public const string USP_P2P_PO_GETAllORDERITEMSMANAGEMASSUPDATE = "usp_P2P_PO_GetAllOrderItemsManageMassUpdate";

        public const string USP_P2P_GETCUSTOMATTRIBUTESROWMAPPINGBYSOURCEDESTINATION =
            "usp_P2P_GetCustomAttributesRowMappingBySourceDestination";

        public const string USP_P2P_INV_CALCULATEINTERFACEITEMSPLITDETAILS =
            "usp_P2P_INV_CalculateInterfaceItemSplitDetails";

        public const string USP_P2P_ASN_GETASNIDBYASNNUMBERANDSTATUS = "usp_P2P_ASN_GetAsnIdByASNNumberAndStatus";
        public const string USP_P2P_GETCLIENTPARTNERCODE = "usp_p2p_Getclientpartnercode";
        public const string USP_P2P_CHECKHASRULEFORUSERDEFINEDAPPROVER = "usp_P2P_CheckHasRuleForUserDefinedApprover";
        public const string USP_P2P_CHECKDATAPRESENTFORSTATICAPPROVAL = "usp_P2P_CheckDataPresentForStaticApproval";

        public const string USP_P2P_GETRULEIDSMARKEDOFFLINEFORSTATICAPPROVAL =
            "usp_P2P_GetRuleIdsMarkedOfflineForStaticApproval";

        #endregion Order StoredProcedures

        #region Order LineItem Columns

        public const string COL_ORDER_ITEM_ID = "OrderItemID";
        public const string COL_POITEM_SHIPPING_ID = "OrderLineItemShippingID";
        public const string COL_POITEM_INVOICED_QUANTITY = "InvoicedQuantity";
        public const string COL_POITEM_RECEIVED_QUANTITY = "ReceivedQuantity";
        public const string COL_ACTIVEITEMCOUNT = "ActiveItemCount";
        public const string COL_ITEMLINENUMBER = "ItemLineNumber";
        public const string COL_INTERNALLINENUMBER = "InternalLineNumber";
        public const string COL_LINENUMBER = "LineNumber";
        public const string COL_SUPPLIERPARTID = "SupplierPartId";
        public const string COL_CATALOGITEMNUMBER = "CatalogItemNumber";
        public const string COL_ITEMNUMBER = "ItemNumber";
        public const string COL_SUPPLIERAUXILIARYPARTID = "SupplierPartAuxiliaryId";
        public const string COL_POITEM_INVOICED_UNITPRICE = "InvoicedUnitPrice";
        public const string COL_POITEM_INVOICED_STARTDATE = "InvoicedStartDate";
        public const string COL_LINEITEMNAME = "LineItemName";
        public const string COL_REQUESTEDQUANTITY = "RequestedQuantity";
        public const string COL_ORDEREDQUANTITY = "OrderedQuantity";
        public const string COL_ORDEREDAMOUNT = "OrderedAmount";
        public const string COL_ISNOTIFICATION = "isNotification";
        public const string COL_INVOICECOUNT = "InvoiceCount";
        public const string COL_INVOICETOTALQUANTITY = "InvoiceTotalQuantity";
        public const string COL_ORDERINVOICETOTALAMOUNT = "InvoiceTotalAmount";
        public const string COL_RECEIPTSCOUNT = "ReceiptsCount";
        public const string COL_RECEIPTTOTALACCEPTEDQUANTITY = "ReceiptTotalAcceptedQuantity";
        public const string COL_RETURNNOTECOUNT = "ReturnNoteCount";
        public const string COL_RETURNNOTETOTALRETURNEDQUANTITY = "ReturnNoteTotalReturnedQuantity";
        public const string COL_ITEMHISTORYICONTYPE = "ItemHistoryIconType";
        public const string COL_ISCONTRACTED = "IsContracted";
        public const string COL_ISBLANKET = "IsBlanket";
        public const string COL_ITEMMATCHTYPE = "MatchType";
        public const string COL_ALLOWEDITANDINSPECT = "AllowEditInspect";
        public const string COL_PARTNERCONFIGURATIONID = "PartnerConfigurationId";
        public const string COL_PUNCHOUTCARTREQID = "PunchoutCartReqId";
        public const string COL_P2PItemId = "P2PItemId";
        public const string COL_ISQUESTIONNAIREERROR = "IsQuestionnaireError";

        public const string COL_Evaluator = "Evaluator";
        public const string COL_EvaluatorName = "EvaluatorName";
        public const string COL_TOTALCHARGE = "TotalCharge";
        public const string COL_CONTRACTITEMID = "ContractItemId";
        public const string COL_CONTRACTITEMDESCRIPTION = "ContractItemDescription";
        public const string COL_ITEMERS = "ERS";
        public const string COL_TOTALCOMPLETION = "TotalCompletion";
        public const string COL_TOTALRECEIVEDAMOUNT = "TotalReceivedAmount";
        public const string COL_TAXRATE = "TaxRate";
        public const string COL_TaxAmount = "TaxAmount";
        public const string COL_TAXERRORMESSAGE = "TaxErrorMessage";
        public const string COL_OLD_ORDERITEMID = "OldOrderItemId";
        public const string COL_POITEM_CREDIT_QUANTITY = "CreditQuantity";

        public const string COL_MATCH_STATUS = "MatchStatus";
        public const string COL_FIRST_RECEIPTDATE = "FirstReceivedDate";
        public const string COL_LAST_RECEIPTDATE = "LastReceivedDate";

        #endregion Order LineItem Columns

        #region Order LineItem StoredProcedures

        public const string USP_P2P_PO_GETALLLINEITEMSBYID = "usp_P2P_PO_GetAllLineItemsById";
        public const string USP_P2P_PO_GETREQUESTERSFORORDERBYID = "usp_P2P_PO_GetRequestersForOrderById";

        public const string USP_P2P_PO_GETORDERFORCANCELORDERNOTIFICATION =
            "usp_P2P_PO_GetOrderForCancelOrderNotification";

        public const string USP_P2P_PO_GETALLINVOICESFORCANCELORDERNOTIFICATION =
            "usp_P2P_PO_GetAllInvoicesForCancelOrderNotification";

        public const string USP_P2P_PO_GETPARTNERDETAILSBYLIID = "usp_P2P_PO_GetPartnerDetailsByLiId";
        public const string USP_P2P_PO_GETSHIPPINGSPLITDETAILSBYLIID = "usp_P2P_PO_GetShippingSplitDetailsByLiId";
        public const string USP_P2P_PO_GETOTHERITEMDETAILSBYLIID = "usp_P2P_PO_GetOtherItemDetailsByLiId";
        public const string USP_P2P_PO_SAVEORDERITEM = "usp_P2P_PO_SaveOrderItem";
        public const string USP_P2P_PO_SAVEESTIMATEDDATESORDERITEMS = "usp_P2P_PO_SaveTempLineItems";
        public const string USP_P2P_PO_UPDATEPROMISEDATE = "usp_P2P_PO_UpdatePromiseDate";

        public const string USP_P2P_PO_DELETELINEITEMBYID = "usp_P2P_PO_DeleteLineItemById";
        public const string USP_P2P_PO_GETALLMANUALLINEITEMSBYID = "usp_P2P_PO_GetAllManualLineItemsById";
        public const string USP_P2P_PO_UPDATELINEITEMSTATUS = "usp_P2P_PO_UpdateLineItemStatus";
        public const string USP_P2P_PO_GETALLORDERSBYREQUISITIONID = "usp_P2P_PO_GetAllOrdersByRequisitionId";

        public const string USP_P2P_PO_GETDOCUMENTBASICDETAILSDOCUMENTNUMBER =
            "usp_P2P_PO_GetDocumentBasicDetailsDocumentnumber";

        public const string USP_P2P_PO_GETORDERFORNOTIFICATION = "usp_P2P_PO_GetOrderForNotification";

        public const string USP_P2P_PO_GETORDERFYINOTIFICATION_ADHOCAPPROVAL =
            "usp_P2P_PO_GetOrderFYINotification_AdhocApproval";

        public const string USP_P2P_PO_GETORDERITEMACCOUNTINGSTATUS = "usp_P2P_PO_GetOrderItemAccountingStatus";
        public const string USP_P2P_PO_UPDATEPOITEMONPARTNERCHANGE = "usp_P2P_PO_UpdatePOItemOnPartnerChange";
        public const string USP_P2P_PO_GETPREFERREDPARTNERBYORDERID = "usp_P2P_PO_GetPreferredPartnerByOrderId";
        public const string USP_P2P_PO_GETORDERINFOFORNOTIFICATION = "usp_P2P_PO_GetOrderInfoForNotification";
        public const string USP_P2P_PO_RESETORDERITEMNUMBERSEQUENCE = "usp_P2P_PO_ResetOrderItemNumberSequence";
        public const string USP_P2P_PO_SAVEORDERITEMOTHER = "usp_P2P_PO_SaveOrderItemOther";
        public const string USP_P2P_PO_UPDATETAXONLINEITEM = "usp_P2P_PO_UpdateTaxOnLineItem";

        public const string USP_P2P_PO_UPDATETAXONHEADERWITHOUTTAXMASTER =
            "usp_P2P_PO_UpdateTaxOnHeaderWithoutTaxMaster";

        public const string USP_P2P_PO_GETALLDOCUMENTITEMSCHECKEDSTATUS = "usp_P2P_PO_GetAllDocumentItemsCheckedStatus";
        public const string USP_P2P_PO_UPDATEORDERITEMCHECKEDSTATUS = "usp_P2P_PO_UpdateOrderItemCheckedStatus";
        public const string USP_P2P_PO_UPDATELINEITEMSHIPTOLOCATION = "usp_P2P_PO_UpdateLineItemShipToLocation";

        public const string USP_P2P_PO_GETALLORDERREQUISITIONITEMSBYREQUISITIONID =
            "usp_P2P_PO_GetAllOrderRequisitionItemsByRequisitionId";

        public const string USP_P2P_REC_GETORDERDEATILSFORRECEIPTINTERFACE =
            "usp_P2P_REC_GetOrderDeatilsForReceiptInterface";

        public const string USP_P2P_REC_GETRECEIPTDEATILSFORRRTURNNOTE = "usp_P2P_REC_GetReceiptDeatilsForReturnNote";
        public const string USP_P2P_PO_SAVEORDERADVANCEDITEM = "usp_P2P_PO_SaveAdvancedPaymentItem";

        public const string USP_P2P_PO_GETORDERADVANCEDACCOUNTINGDETAILSBYITEMID =
            "USP_P2P_PO_GetOrderAdvancedAccountingDetailsByItemId";

        public const string USP_P2P_PO_SAVE_ADV_ORDER_DEFAULT_ACCOUNTING =
            "usp_P2P_PO_SaveAdvancePaymentDefaultAccounting";

        public const string USP_P2P_SAVEITEMNEEDBYDATE = "usp_P2P_saveItemNeedByDate";
        public const string USP_P2P_CHECKCANCELADVITEMVALIDATION = "usp_P2P_CheckCancelAdvItemValidation";
        public const string USP_P2P_PO_GetFOBPODetailsId = "usp_P2P_PO_GetFOBPODetailsById";

        public const string USP_P2P_VALIDATEITEMMANDATORYQUESTIONRESPONSES =
            "usp_P2P_ValidateItemMandatoryQuestionResponses";

        public const string USP_P2P_GETALLTOLERANCEDETAILS = "usp_P2P_GetAllToleranceDetails";

        public const string USP_P2P_SAVEFLIPTOORDERSPLITSANDSHIPPINGDETAILS =
            "usp_P2P_SaveFlipToOrderSplitsAndShippingDetails";

        public const string USP_P2P_REC_CANCELLINEITEM = "usp_P2P_REC_CancelLineItem";
        public const string USP_P2P_REQITEMSHIPPINGDETAILS = "usp_P2P_SaveRequisitionItemShippingDetails";
        public const string USP_P2P_REQITEMTAXDETAILS = "usp_P2P_SaveRequisitionItemTaxDetails";

        #endregion Order LineItem StoredProcedures

        #region Order Tolerance Columns

        public const string COL_TOLERANCE_ID = "ToleranceId";
        public const string COL_ALLOW_TOLERANCE = "AllowTolerance";
        public const string COL_ALLOW_TOLERANCE_EDIT = "AllowToleranceEdit";
        public const string COL_ALLOW_TOLERANCE_FOR_BLANK = "AllowToleranceForBlank";
        public const string COL_ITEM_TOTAL_PERCENT_TOLERANCE = "ItemTotalPercentTolerance";
        public const string COL_ITEM_TOTAL_VALUE_TOLERANCE = "ItemTotalValueTolerance";
        public const string COL_TOTAL_AMOUNT_PERCENT_TOLERANCE = "TotalAmountPercentTolerance";
        public const string COL_TOTAL_AMOUNT_VALUE_TOLERANCE = "TotalAmountValueTolerance";
        public const string COL_TAX_PERCENT_TOLERANCE = "TaxPercentTolerance";
        public const string COL_TAX_VALUE_TOLERANCE = "TaxValueTolerance";
        public const string COL_SHIPPING_PERCENT_TOLERANCE = "ShippingPercentTolerance";
        public const string COL_SHIPPING_VALUE_TOLERANCE = "ShippingValueTolerance";
        public const string COL_CHARGES_PERCENT_TOLERANCE = "ChargesPercentTolerance";
        public const string COL_CHARGES_VALUE_TOLERANCE = "ChargesValueTolerance";
        public const string COL_QUANTITY_PERCENT_TOLERANCE = "QuantityPercentTolerance";
        public const string COL_QUANTITY_VALUE_TOLERANCE = "QuantityValueTolerance";
        public const string COL_UNIT_PRICE_PERCENT_TOLERANCE = "UnitPricePercentTolerance";
        public const string COL_UNIT_PRICE_VALUE_TOLERANCE = "UnitPriceValueTolerance";
        public const string COL_PERCENTTOLERANCE = "PercentTolerance";
        public const string COL_VALUETOLERANCE = "ValueTolerance";
        public const string COL_REQACCESS = "REQACCESS";
        public const string COL_RECACCESS = "RECACCESS";
        public const string COL_LINEITEMSTATUS = "LineItemStatus";
        public const string COL_INVOICEPERCENTVALUE = "InvoicePercentValue";
        public const string COL_ORDERPERCENTVALUE = "OrderPercentValue";

        #endregion Order Tolerance Columns

        #region TimesheetColumns

        public const string COL_TS_REPORTINGMANAGERNAME = "ReportingManagerName";

        public const string COL_TS_HASCOMMENTS = "HasComments";
        public const string COL_TS_TIMESHEETID = "TimesheetId";
        public const string COL_TS_DOCUMENTNUMBER = "TimesheetNumber";
        public const string COL_TS_ORDERNUMBER = "OrderNumber";
        public const string COL_TS_PARTNERTIMESHEETNUMBER = "PartnerTimesheetNumber";
        public const string COL_TS_DESCRIPTION = "Description";
        public const string COL_TS_SUPPLIERNAME = "SupplierName";
        public const string COL_TS_ORDERID = "OrderId";
        public const string COL_CURRENCY_CODE = "CurrencyCode";
        public const string COL_TS_CREATEDBY = "CreatedBy";
        public const string COL_TS_ORDERNAME = "OrderName";
        public const string COL_TS_DATECREATED = "DateCreated";
        public const string COL_TS_SUBMITTEDBY = "SubmittedBy";
        public const string COL_TS_DATESUBMITTED = "DateSubmitted";
        public const string COL_TS_CUSTOMERCONTACT = "CustomerContact";
        public const string COL_TS_CUSTOMERCONTACTEMAIL = "CustomerContactEmail";
        public const string COL_TS_LINENUMBER = "LineNumber";
        public const string COL_TS_ORDERLINENUMBER = "OrderLineNumber";
        public const string COL_TS_CONTRACTNUMBER = "ContractNumber";
        public const string COL_TS_QUANTITY = "Quantity";
        public const string COL_TS_UOM = "UOM";
        public const string COL_TS_PRICE = "Price";
        public const string COL_TS_LINEVALUE = "LineValue";
        public const string COL_TS_STARTDATE = "StartDate";
        public const string COL_TS_ENDDATE = "EndDate";
        public const string COL_TS_TIMESHEETSTARTDATE = "TimesheetStartDate";
        public const string COL_TS_TIMESHEETENDDATE = "TimesheetEndDate";
        public const string COL_TS_ITEMTYPE = "ItemType";
        public const string COL_TS_LINEDESCRIPTION = "LineDescription";
        public const string COL_TS_CONTACTCODE = "ContactCode";
        public const string COL_TS_SUBMITTEDBYNAME = "SubmittedByName";
        public const string COL_TS_CUSTOMERCONTACTCODE = "CustomerContactCode";
        public const string COL_TS_CREATORCONTACTCODE = "CreatorContactCode";
        public const string COL_SUPPLIERCONTACT = "SupplierContact";
        public const string COL_SUPPLIERCONTACTCODE = "SupplierContactCode";
        public const string COL_SUPPLIERCONTACTEMAIL = "SupplierContactEmail";
        public const string COL_CUSTOMERCONTACTEMAIL = "CustomerContactEmail";
        public const string COL_ORDERCONTACTEMAIL = "OrderContactEmail";
        public const string COL_SUBMITTEDBYEMAIL = "SubmittedByEmail";
        public const string COL_SUBMITTEDBYNAME = "SubmittedByName";
        public const string COM_TS_TOTALAMOUNT = "TimesheetAmount";
        public const string COM_TS_INVOICEAMOUNT = "InvoiceAmount";
        public const string COL_TS_REQUESTER = "Requester";
        public const string COL_TS_DATEMODIFIED = "DateModified";
        public const string COL_TS_REPORTINGMANAGERID = "reportingmanagerid";
        public const string COL_TS_REPORTINGMANAGER = "ReportingManager";
        public const string COL_TS_REPORTINGMANAGEREMAIL = "ReportingManagerEmail";
        public const string COL_TS_CONTINGENTWORKERID = "contingentworkerid";
        public const string COL_TS_CONTINGENTWORKER = "ContingentWorker";
        public const string COL_TS_CONTINGENTWORKERMAIL = "ContingentWorkerEmail";
        public const string COL_TS_DECISIONDATE = "DecisionDate";
        public const string COL_BUYERADMINCONTACTCODE = "BuyerAdminContactCode";
        public const string COL_BUYERADMINCONTACTEMAIL = "BuyerAdminContactEmail";
        public const string COL_BUYERADMINCONTACT = "BuyerAdminContact";

        #endregion TimesheetColumns

        #region Order Tolerance StoredProcedures

        public const string USP_P2P_PO_GETORDERTOLERANCEDETAILSBYID = "usp_P2P_PO_GetOrderToleranceDetailsById";
        public const string USP_P2P_PO_SAVETOLERANCEDETAILS = "usp_P2P_PO_SaveToleranceDetails";

        #endregion Order Tolerance StoredProcedures

        #region Order SavePoTermsMapping StoredProcedures

        public const string USP_P2P_PO_SAVEPOTERMSMAPPING = "usp_P2P_PO_SavePoTermsMapping";

        #endregion Order SavePoTermsMapping StoredProcedures

        #region Order TableTypes

        public const string TVP_P2P_ORDERITEM = "tvp_P2P_OrderItem";
        public const string TVP_P2P_PO_ITEMS = "tvp_P2P_PO_Items";
        public const string TVP_P2P_ORDERITEMS = "tvp_P2P_OrderItems";
        public const string TVP_P2P_REQITEMS = "tvp_P2P_RequisitionItems";
        public const string TVP_ITEMPARTNERDEATAILS = "tvp_ItemPartnerDeatails";
        public const string TVP_P2P_ORDERITEMSHIPPINGDETAILS = "tvp_P2P_ItemShippingDetails";
        public const string TVP_P2P_ITEMOTHERDETAILS = "tvp_P2P_ItemOtherDetails";
        public const string TVP_P2P_ORDERTEMPITEMS = "tvp_P2P_PO_TempLineItems";
        public const string TVP_P2P_ORDERNOTESORATTACHMENTS = "tvp_P2P_OrderItemsNotesOrAttachments";
        public const string TVP_LONG = "tvp_Long";
        public const string TVP_P2P_DocumentItems = "tvp_P2P_DocumentItems";
        public const string TVP_P2P_Document = "tvp_P2P_Document";

        public const string TVP_P2P_REQITEMSHIPPING = "tvp_P2P_RequisitionItemShipping";
        public const string TVP_P2P_REQTAXDETAILS = "tvp_P2P_RequisitionItemTax";

        #endregion Order TableTypes

        #region Interface Order TableTypes

        public const string TVP_P2P_HEADERBILLTO = "tvp_P2P_HeaderBillTo";
        public const string TVP_P2P_HEADERSHIPTO = "tvp_P2P_HeaderShipTo";
        public const string TVP_P2P_LINELEVELSHIPTO = "tvp_P2P_LinelevelShipTo";
        public const string TVP_P2P_HEADERDELIVERTO = "tvp_P2P_HeaderDeliverTo";
        public const string TVP_P2P_LINELEVELDELIVERTO = "tvp_P2P_LinelevelDeliverTo";

        #endregion Interface Order TableTypes

        #region Order DispatchHistory

        public const string COL_ACTION = "ActionInfo";
        public const string COL_PERFORMEDBY = "PerformedBy";
        public const string COL_DATEPERFORMED = "DatePerformed";
        public const string COL_ADDITIONALINFO = "AdditionalInfo";

        #endregion Order DispatchHistory

        #endregion Order

        #region Common Entity

        #region Common Columns

        public const string COL_LOCATIONID = "LocationId";
        public const string COL_APPROVAL_STATUS = "ApprovalStatus";
        public const string COL_PROCUREMENT_STATUS = "ProcurementStatus";
        public const string COL_PARTNER_CODE = "PartnerCode";
        public const string COL_OrderingLocationID = "OrderingLocationID";
        public const string COL_LocationTypeId = "LocationTypeId";
        public const string COL_AccessControlOrgEntityDetailCodes = "AccessControlOrgEntityDetailCodes";
        public const string COL_NonOrgEntityDetailCodes = "NonOrgEntityDetailCodes";
        public const string COL_PARTNER_CONTACT_CODE = "PartnerContactCode";
        public const string COL_PARTNER_CONTACT_EMAIL = "PartnerContactEmail";
        public const string COL_PARTNER_CONTACTID = "PartnerContactId";
        public const string COL_PARTNER_CONTACT_NUMBER = "PartnerContactNumber";

        public const string COL_PARTNER_CONTACT_FAX = "PartnerContactFax";
        public const string COL_PARTNER_CONTACT_PHONE = "PartnerContactPhone";
        public const string COL_PARTNER_CONTACT_ADDRESS1 = "PCAaddress1";
        public const string COL_PARTNER_CONTACT_ADDRESS2 = "PCAaddress2";
        public const string COL_PARTNER_CONTACT_ADDRESS3 = "PCAaddress3";
        public const string COL_PARTNER_CONTACT_CITY = "PCACity";
        public const string COL_PARTNER_CONTACT_STATE = "PCAState";
        public const string COL_PARTNER_CONTACT_ZIP = "PCAZip";
        public const string COL_PARTNER_CONTACT_COUNTRY = "PCACountry";
        public const string COL_PARTNER_CONTACT_COUNTRYCODE = "PCACountryCode";
        public const string COL_PARTNER_CONTACT_STATECODE = "PCAStateCode";
        public const string COL_PARTNER_INVOICE_NUMBER = "PartnerInvoiceNumber";
        public const string COL_COMPANY_NAME = "CompanyName";
        public const string COL_CONTACT_CODE = "ContactCode";
        public const string COL_EMAIL_ID = "EmailId";
        public const string COL_PHONE_NO = "PhoneNo";
        public const string COL_EXTENSION_NO1 = "ExtensionNo1";
        public const string COL_EXTENSION_NO2 = "ExtensionNo2";
        public const string COL_MOBILE_NO = "MobileNo";
        public const string COL_PHONE_NO1 = "PhoneNo1";
        public const string COL_PHONE_NO2 = "PhoneNo2";
        public const string COL_CURRENCY = "CurrencyCode";
        public const string COL_ALLOCATEDBUDGET = "AllocatedBudget";
        public const string COL_SHIPTOLOCATION_ID = "ShiptoLocationID";
        public const string COL_DELIVERTOLOCATION_ID = "DelivertoLocationId";
        public const string COL_BILLTOLOCATIONID = "BilltoLocationID";
        public const string COL_PAYMENTTERMS = "PaymentTerms";
        public const string COL_PAYMENTTERMSID = "PaymentTermsId";
        public const string COL_TAX = "Tax";
        public const string COL_TaxExempt = "TaxExempt";
        public const string COL_UseTax = "Tax";
        public const string COL_ISTAXEXEMPT = "IsTaxExempt";
        public const string COL_SHIPPING = "Shipping";
        public const string COL_ADDITIONAL_CHARGES = "AdditionalCharges";
        public const string COL_IS_DELETED = "IsDeleted";
        public const string COL_IS_PROXY_DELETED = "IsProxyDeleted";
        public const string COL_DATE_CREATED = "DateCreated";
        public const string COL_DATE_MODIFIED = "DateModified";
        public const string COL_DATE_SUBMITTED = "DateSubmitted";
        public const string COL_SUBMITTED_BY = "SubmittedBy";
        public const string COL_SUBMITTED_ON = "SubmittedOn";
        public const string COL_CREATED_BY = "CreatedBy";
        public const string COL_MODIFIED_BY = "ModifiedBy";
        public const string COL_BANDING = "Banding";
        public const string COL_MAX_ORDER_QUANTITY = "MaximumOrderQuantity";
        public const string COL_MIN_ORDER_QUANTITY = "MinimumOrderQuantity";
        public const string COL_APPROVER_NAME = "ApproverName";
        public const string COL_DOCUMENT_SOURCE = "DocumentSource";
        public const string COL_DOCUMENT_SOURCE_TYPE = "DocumentSourceType";
        public const string COL_ITEM_TOTAL = "ItemTotal";
        public const string COL_SHIPPING_CHARGES = "ShippingCharges";
        public const string COL_ItemImageFileId = "FileId";
        public const string COL_ItemImageFileName = "FileName";
        public const string COL_ItemImageUri = "FileUri";
        public const string COL_BUCODE = "BUCode";
        public const string COL_UNSPSCKEY = "UNSPSCKey";
        public const string COL_SPLITITEMID = "SplitItemId";
        public const string COL_ACCRUEUSETAX = "AccrueUseTax";
        public const string COL_AMOUNT = "Amount";
        public const string COL_BUYERCOMPANYNAME = "BuyerCompanyName";
        public const string COL_LINKEDDOCUMENTCODE = "LinkedDocumentCode";
        public const string COL_REQUESTERID = "RequesterID";
        public const string COL_PAYMENTTERMID = "PaymentTermId";
        public const string COL_PAYMENTTERMNAME = "PaymentTermName";
        public const string COL_PAYMENTTERMCODE = "PaymentTermCode";
        public const string COL_PAYMENTTERMDISCOUNT = "Discount";
        public const string COL_PAYMENTTERMDISCOUNTDAYS = "DiscountDays";
        public const string COL_PAYMENTTERMNOOFDAYS = "NoOfDays";
        public const string COL_P2PITEMID = "P2PItemId";
        public const string COL_CONTRACTNO = "ContractNo";
        public const string COL_CONTRACTSTARTDATE = "ContractStartDate";
        public const string COL_CONTRACTENDDATE = "ContractEndDate";
        public const string COL_CONTRACTVALUE = "ContractValue";
        public const string COL_CONTRACTVOLUME = "ContractVolume";
        public const string COL_CONTRACTNAME = "ContractName";
        public const string COL_COMMENTCOUNT = "CommentCount";
        public const string COL_EXCEPTIONS = "Exceptions";
        public const string COL_IMAGEID = "ImageId";
        public const string COL_CLIENTCATEGORYID = "ClientCategoryId";
        public const string COL_POCONTACTCODE = "POContactCode";
        public const string COL_CLIENT_PARTNERCODE = "ClientPartnerCode";
        public const string COL_ISURGENT = "IsUrgent";
        public const string COL_DELIVERTO = "DeliverTo";
        public const string COL_ENTITYDETAILCODE = "EntityDetailCode";
        public const string COL_FULLNAME = "FullName";
        public const string COL_NEXTLINENUMBER = "NextLineNumber";
        public const string COL_CANCELLED_DATE = "CancelledDate";
        public const string COL_CLOSED_DATE = "ClosedDate";
        public const string COL_IS_RESOLVED = "IsResolved";
        public const string COL_CONTACT_NUMBER = "ContactNumber";
        public const string COL_CREATED_DATE = "CreatedDate";
        public const string COL_ISREASSIGNED = "IsReassigned";
        public const string COL_IS_PCARDSUPPORTED = "IsPCardSupported";
        public const string COL_ISCATALOGITEM = "IsCatalogItem";
        public const string COL_SUPPLIERPARTNUMBER = "SupplierPartNumber";
        public const string COL_PARENTDOCUMENTNUMBER = "ParentDocumentNumber";
        public const string COL_ADDRESSCODE = "AddressCode";
        public const string COL_PHONENO1 = "PhoneNo1";
        public const string COL_EXTENSIONNO1 = "ExtensionNo1";
        public const string COL_PHONENO2 = "PhoneNo2";
        public const string COL_EXTENSIONNO2 = "ExtensionNo2";
        public const string COL_FAXNO = "FaxNo";
        public const string COL_SRCITEMID = "SrcItemId";
        public const string COL_TGTITEMID = "TgtItemId";
        public const string COL_GTIN = "GTIN";
        public const string COL_ContractItemLineNumber = "ContractItemLineNumber";
        public const string COL_ITEMADVANCEAMOUNT = "ItemAdvanceAmount";
        public const string COL_ADVANCETOTAL = "AdvanceTotalAmount";
        public const string COL_RECOUPMENTPERCENTAGE = "RecoupmentPercentage";
        public const string COL_Recoupment = "Recoupment";
        public const string COL_RemainingAmount = "RemainingAmount";
        public const string COL_ADJUSTMENTTYPE = "AdjustmentType";
        public const string COL_TOTALRECOUPMENTAMOUNT = "TotalRecoupmentamount";
        public const string COL_REMAININGADVANCEAMOUNT = "RemainingAdvanceAmount";
        public const string COL_REMAININGADVADJAMOUNT = "RemainingAdvAdjAmount";
        public const string COL_RECOUPMENTRATE = "RecoupmentRate";
        public const string COL_OVERALLTOTALAMOUNT = "OverallTotalAmount";
        public const string COL_UPDATEDBY = "UpdatedBy";
        public const string COL_UPDATEDON = "UpdatedOn";
        public const string COL_UPDATEDVIA = "UpdatedVia";
        public const string COL_ROLE = "Role";
        public const string COL_ORG_ENTITYCODE = "OrgEntityCode";
        public const string COL_USERDEFINEDAPPROVALCOUNT = "CountOfApprovers";
        public const string COL_ItemPASCodes = "ItemPASCodes";
        public const string COL_DEFAULTCURRENCYCODE = "DefaultCurrencyCode";
        public const string COL_ENTITYID = "EntityId";
        public const string COL_SOURCEENTITYID = "SourceEntityId";
        public const string COL_ENTITYDISPLAYNAME = "EntityDisplayName";
        public const string COL_ENTITYCODE = "EntityCode";
        public const string COL_ENTITYDESCRIPTION = "EntityDescription";
        public const string COL_ISACTIVE = "IsActive";
        public const string COL_PARENTENTITYDETAILCODE = "ParentEntityDetailCode";
        public const string COL_ENTITYKEY = "EntityKey";
        public const string COL_ENTITYDEFAULTNAME = "EntityDefaultName";
        public const string COL_ISLOB = "IsLOB";
        public const string COL_ISBRIDGE = "IsBridge";
        public const string COL_ISORGENTITY = "IsOrgEntity";
        public const string COL_Extended_Error_Code = "ExtendedErrorCode";
        public const string COL_FIELDFORASSET = "FileIdForAsset";
        public const string COL_FILENAMEFORASSET = "FileNameForAsset";
        public const string COL_PASNAME = "PASName";
        public const string COL_CLIENT_PASCODE = "Client_PASCode";
        public const string COL_PASCODE = "PASCode";
        public const string COL_TAXINTEGRATION = "TaxIntegration";
        public const string COL_DIVISION = "Division";
        public const string COL_INVOICESOURCEID = "InvoiceSourceId";
        public const string COL_ACCEPTANCESTATUS = "AcceptStatus";
        public const string COL_NEWRESOLVER = "NewResolver";
        public const string COL_PREVIOUSRESOLVER = "PreviousResolver";
        public const string COL_CUMULATIVETOTALAMOUNT = "CumulativeTotalAmount";
        public const string COL_ISTASKPENDINGFORACTIONER = "IsTaskPendingForActioner";
        public const string COL_ISTASKPENDINGFORPROXYACTIONER = "IsTaskPendingForProxyActioner";
        public const string COL_LOCATIONTYPE = "LocationType";

        #endregion Common Columns

        #region Common Entity StoreProcedures

        public const string USP_P2P_GETALLSUPPLIERLOCBYLOBAndOrgEntity =
            "usp_P2P_GetAllSupplierLocationsByLOBandOrgEntity";

        public const string USP_P2P_GETALLSUPPLIERSBYLOBAndOrgEntity =
            "usp_P2P_GetAllSupplierContactsByLOBandOrgEntity";

        public const string USP_P2P_GETALLCATEGORIESBYLOB = "usp_P2P_GetAllCategoriesByLOB";
        public const string USP_P2P_GETALLUOMS = "usp_P2P_GetAllUOMs";
        public const string USP_P2P_GETALLSHIPPINGMETHODS = "usp_P2P_GetAllShippingMethods";
        public const string USP_P2P_GETDEFAULTSHIPPINGMETHOD = "usp_P2P_GetDefaultShippingMethod";
        public const string USP_P2P_GETALLSHIPTOLOCATIONS = "usp_P2P_GetAllShipToLocations";
        public const string USP_P2P_GETDEFAULTSHIPTOLOCATIONSBYLOBBU = "usp_P2P_GetDefaultShipToLocationsByLOBBU";
        public const string USP_P2P_GETSHIPTOLOCATIONBYID = "usp_P2P_GetShipToLocationById";
        public const string USP_P2P_GETALLBILLTOLOCATIONS = "usp_P2P_GetAllBillToLocations";

        public const string USP_WF_CHECKORIGINALAPPROVERNOTIFICATIONSTATUS =
            "usp_WF_CheckOriginalApproverNotificationStatus";

        public const string USP_WF_GETDOCUMENTLISTFORDELEGATEAPPROVERS = "usp_WF_GetDocumentListForDelegateApprovers";
        public const string USP_P2P_GETBILLTOLOCATIONBYID = "usp_P2P_GetBillToLocationById";
        public const string USP_P2P_GETALLDOCUMENTS = "usp_P2P_GetAllDocuments";
        public const string USP_P2P_GETSHIPTOLOCATIONIDBYADDRESS = "usp_P2P_GetShipToLocationIdByAddress";
        public const string USP_P2P_INSERTSHIPTOLOCATION = "usp_P2P_InsertShiptoLocation";
        public const string USP_P2P_INSERTSHIPTOLOCATIONFROMINTERFACE = "usp_P2P_InsertShiptoLocationFromInterface";

        public const string USP_BZ_INSERTPARTNERINTERFACE_DOCUMENT_MAPPING =
            "usp_BZ_InsertPartnerInterfaceDocumentMapping";

        public const string USP_BZ_GETALLSCANNEDDOCUMENTFILEID = "usp_BZ_GetAllScannedDocumentFileId";

        public const string USP_P2P_VALIDATEINTERNALCATALOGITEMS = "usp_P2P_ValidateInternalCatalogItems";
        public const string USP_P2P_UPDATESHIPTOLOCATION = "usp_P2P_UpdateShiptoLocation";
        public const string USP_P2P_VALIDATEPAYMENTTERMS = "usp_P2P_ValidatePaymentTerms";

        public const string USP_P2P_SAVEFLIPPEDQUESTIONSRESPONSESFROMINTERFACE =
            "usp_P2P_SaveFlippedQuestionResponsesFromInterface";

        public const string USP_P2P_GETBILLTOLOCBYNAME = "usp_P2P_GetBillToLocationByName";
        public const string USP_P2P_GETBILLTOLOCATIONIDBYADDRESS = "usp_P2P_GetBillToLocationIdByAddress";
        public const string USP_P2P_SAVEBILLTOLOCATION = "usp_P2P_SaveBillToLocation";
        public const string USP_P2P_GETALLSHIPTOLOCATIONBYNUMBER = "usp_P2P_GetAllShipToLocationByNumber";
        public const string USP_P2P_UPDATEBASECURRENCY = "usp_P2P_UpdateBaseCurrency";
        public const string USP_P2P_GETDEFAULTBILLTOLOCATION = "usp_P2P_GetDefaultBillToLocation";

        public const string USP_P2P_VALIDATEALLACCOUNTINGCODECOMBINATION =
            "usp_P2P_ValidateAllAccountingCodeCombination";

        public const string USP_P2P_GETALLBILLTOLOCATIONBYNUMBER = "usp_P2P_GetAllBillToLocationByNumber";
        public const string USP_P2P_GETALLERPORDERTYPES = "usp_P2P_GetAllERPOrderTypes";
        public const string USP_P2P_GETRELATEDDOCUMENTSFORCOMMENTS = "usp_P2P_GetRelatedDocumentsForComments";
        public const string USP_P2P_GETALLBUDGETID = "usp_P2P_GetAllBudgetIds";
        public const string USP_P2P_GETDOCUMENTLISTFORAUTOACCEPTIR = "usp_P2P_GetDocumentListForAutoAcceptIR";

        public const string USP_P2P_GETRELATEDLINEITEMSFORCOMMENTS = "usp_P2P_GetRelatedLineItemsForComments";
        public const string USP_P2P_GETAVAILABLEFUNDS = "usp_p2p_GetAvailableFunds";
        public const string USP_P2P_GETALLUOMSBYCATALOGITEMID = "usp_P2P_GetAllUOMsByCatalogItemId";
        public const string USP_P2P_GETCONTRACTDATABYCATALOGITEMID = "usp_P2P_GetContractDataByCatalogItemId";
        public const string USP_P2P_CATALOGCONTRACTEXPIRY = "usp_P2P_CatalogContractExpiry";
        public const string USP_P2P_GETDELIVERTOLOCATIONBYID = "usp_P2P_GetDeliverToLocationById";
        public const string USP_P2P_GETALLDELIVERTOLOCATIONS = "usp_P2P_GetAllDeliverToLocations";
        public const string USP_P2P_GETDELIVERTOLOCATIONBYNUMBER = "usp_P2P_GetDeliverToLocationByNumber";
        public const string USP_BZ_GETPARTNERCODEBYCONFIGURATIONID = "usp_BZ_GetPartnerCodeByConfigurationId";
        public const string USP_P2P_GETFIRSTACCOUNTINGSPLITREQUESTER = "usp_P2P_GetFirstAccountingSplitRequester";
        public const string USP_P2P_GETORGENTITYMAPPEDWITHCATALOGITEM = "USP_P2P_GetOrgEntityMappedWithCatalogItem";
        public const string USP_P2P_SAVEADHOCUSERS = "usp_P2P_SaveAdhocUsers";
        public const string USP_P2P_APPLYDATATOALLSELECTEDLINEITEMS = "usp_P2P_SelectiveApplyToAll";
        public const string USP_P2P_GETBUBASEDREQUESTER = "usp_P2P_GetBUBasedRequester";
        public const string USP_P2P_GETCONTACTDETAILSBYCONTACTCODE = "usp_P2P_GetContactDetailsByContactCode";
        public const string USP_P2P_REQSELECTIVEAPPLYTOALLBYRATIO = "usp_P2P_REQSelectiveApplyToAllByRatio";
        public const string USP_P2P_POSELECTIVEAPPLYTOALLBYRATIO = "usp_P2P_POSelectiveApplyToAllByRatio";
        public const string USP_P2P_INVOICESELECTIVEAPPLYTOALLBYRATIO = "usp_P2P_InvoiceSelectiveApplyToAllByRatio";
        public const string USP_P2P_GETPARTNERDETAILSFORINTERFACE = "usp_P2P_GetPartnerDetailsForInterface";
        public const string USP_WF_GETDOCUMENTSFORDELEGATION = "usp_WF_GetDocumentsForDelegation";
        public const string USP_WF_SAVEDOCUMENTDELEGATIONREQUEST = "usp_WF_SaveDocumentDelegationRequest";
        public const string USP_WF_RESETDOCUMENTDELEGATIONREQUEST = "usp_WF_ResetDocumentDelegationRequest";
        public const string USP_WF_SETDOCUMENTDELEGATIONREQUEST = "usp_WF_SetDocumentDelegationRequest";
        public const string USP_P2P_GETPARTERCONTACTSBYLOCATIONID = "usp_P2P_GetPartercontactsByLocationId";
        public const string USP_P2P_GETPARTNERANDCONTACTCODEDETAILS = "usp_P2P_GetPartnerAndContactCodeDetails";

        public const string USP_PRN_GETPARTNERCONATACTBYPARTNERCODEANDLOCATIONCODE =
            "usp_PRN_GetPartnerConatactByPartnerCodeAndLocationCode";

        public const string USP_P2P_GETALLSHIPTOLOCATIONBYNAMES = "usp_P2P_GetAllShipToLocationByNames";
        public const string USP_P2P_GETALLDELIVERTOLOCATIONBYNAMES = "usp_P2P_GetAllDeliverToLocationByNames";
        public const string USP_P2P_GETALLBILLTOLOCATIONBYNAMES = "usp_P2P_GetAllBillToLocationByNames";
        public const string USP_P2P_GETALLUOMBYUOMS = "usp_P2P_GetAllUOMByUOMs";
        public const string USP_P2P_GETACTIVEPAYMENTTERMS = "usp_P2P_GetActivePaymentTerms";
        public const string USP_P2P_GETUOMDETAILSBYSTANDARDUOM = "usp_P2P_GetUOMDetailsByStandardUOM";
        public const string USP_P2P_GETPURCHASETYPES = "usp_P2P_GetPurchaseTypes";

        public const string USP_P2P_GETPURCHASETYPEITEMEXTENDEDTYPEMAPPING =
            "usp_P2P_GetPurchaseTypeItemExtendedTypeMapping";

        public const string USP_P2P_GETITEMIDMAPPING = "usp_P2P_GetItemIdMapping";
        public const string USP_P2P_GETALLSPLITITEMIDSBYDOCUMENTID = "usp_P2P_GetAllSplitItemIdsByDocumentId";
        public const string USP_P2P_GETITEMFORMMAPPINGBYCATALOGID = "usp_P2P_GetItemFormMappingByCatalogId";
        public const string USP_P2P_GETALLITEMIDSBYDOCUMENTID = "usp_P2P_GetAllItemIdsByDocumentId";
        public const string USP_P2P_CUSTOMATTRFORMID = "usp_P2P_CustomAttrFormId";
        public const string USP_P2P_UPDATEALLPERIODONSPLITSBYNEEDBYDATE = "usp_P2P_UpdateAllPeriodonSplitsbyNeedbyDate";
        public const string USP_P2P_GetListOfShipToLocations = "usp_P2P_GetListOfShipToLocations";
        public const string USP_P2P_GetListOfBillToLocations = "usp_P2P_GetListOfBillToLocations";

        public const string USP_P2P_GetListOfCatalogItemIdsNotAllowedAccess =
            "usp_P2P_GetListOfCatalogItemIdsNotAllowedAccess";

        public const string USP_P2P_UPDATEPERIODONSPLITSBYNEEDBYDATE = "usp_P2P_UpdatePeriodonSplitsbyNeedbyDate";
        public const string USP_P2P_UPDATEACCOUNTINGSTATUS = "usp_P2P_UpdateAccountingStatus";
        public const string USP_P2P_GETIDENTIFICATIONNUMBERVALUES = "usp_P2P_GetIdentificationValues";
        public const string USP_P2P_GETUSERCONFIGURATIONS = "USP_P2P_GetUserConfigurations";
        public const string USP_P2P_SAVEUSERCONFIGURATIONS = "USP_P2P_SaveUserConfigurations";

        public const string USP_P2P_GetListOfCatalogItemIdsNotAllowedAccessLatestNow =
            "[USP_P2P_GetListOfCatalogItemsIdsNotAllowedAccess]";

        public const string USP_P2P_REMOVECONTRACTNOONBUCHANGE = "usp_P2P_RemoveContractNoOnBUChange";
        public const string USP_P2P_PO_GETALLSHIPTOLOCATIONSMASTERLIST = "usp_P2P_GetAllShiptoLocationsMasterList";
        public const string USP_P2P_ValidateDocumentCheck = "usp_P2P_ValidateDocumentCheck";

        public const string USP_P2P_GETSHIPTOLOCATIONBYDEFAULTMAPPEDENTITY =
            "usp_P2P_GetShipToLocationByDefaultMappedEntity";

        public const string USP_P2P_GETALLADDITIONALFIELDS = "USP_P2P_GetAllEntityFieldsDetail";
        public const string USP_P2P_GETLOBBYDOCUMENTCODE = "usp_P2P_GetLOBByDocumentCode";
        public const string USP_REQ_GETMAPPEDQUESTIONS = "USP_REQ_GetMappedQuestions";
        public const string USP_GET_ENTITY_SEARCH_RESULTS = "usp_P2P_GetEntityDetailsBySearchResults";
        public const string USP_P2P_GETALLINVOICEACTIONS = "usp_P2P_GetAllInvoiceActions";
        public const string USP_P2P_GETORGENTITIES = "usp_P2P_GetOrgEntities";

        public const string USP_P2P_GETALLPARTNERLOCATIONIDENFITICATIONDETAILS =
            "usp_P2P_GetAllPartnerLocationIdenfiticationDetails";

        public const string USP_P2P_REQ_GETREQUISITIONDETAILSFORBULKUPLOADREQLINES =
            "usp_P2P_REQ_GetRequisitionDetailsForBulkUploadReqLines";

        public const string USP_P2P_REQ_VALIDATEITEMNUMBER = "usp_P2P_REQ_ValidateItemNumber";
        public const string USP_P2P_GETTAXINTEGRATIONBYMAPPEDENTITY = "usp_P2P_GetTaxintegrationByMappedEntity";
        public const string USP_P2P_INSERTDELIVERTOLOCATION = "usp_P2P_InsertDelivertoLocation";

        #region Combination Code

        public const string USP_SaveAccountingCombinationCode = "usp_SaveAccountingCombinationCode";

        public const string USP_SAVEACCOUNTINGCOMBINATIONCODEFORINTERFACE =
            "usp_SaveAccountingCombinationCodeForInterface";

        public const string USP_GetAllCombinationCode = "usp_GetAllAccountingCombinationCodes";
        public const string USP_UpdateLastReadTime = "usp_UpdateLastReadTime";
        public const string USP_ValidateOrgEntity = "usp_ValidateOrgEntity";

        #endregion Combination Code

        #endregion Common Entity StoreProcedures

        #region Common Entity Columns

        public const string COL_UOM_CODE = "UOMCode";
        public const string COL_UOM_DESCRIPTION = "UOMDescription";
        public const string COL_UOM_ALLOWDECIMAL = "AllowDecimal";
        public const string COL_ERPORDERTYPEID = "ERPOrderTypeID";
        public const string COL_ERPORDERTYPE = "ERPOrderType";
        public const string COL_WORKORDERNO = "WorkOrderNo";
        public const string COL_CAPITALCODE = "CapitalCode";
        public const string COL_EXTCONTRACTREF = "ExtContractRef";
        public const string COL_BUDGETID = "BudgetId";
        public const string COL_BUDGETIDDESC = "BudgetIdDesc";
        public const string COL_INVOICEACTIONID = "InvoiceActionId";
        public const string COL_ACTIONNAME = "Action";

        public const string COL_SHIPPINGMETHOD_NAME = "ShippingMethodName";
        public const string COL_SHIPPINGMETHOD = "ShippingMethod";
        public const string COL_ShiptoLocationAddressLine1 = "ShiptoLocationAddressLine1";
        public const string COL_ShiptoLocationAddressLine2 = "ShiptoLocationAddressLine2";
        public const string COL_ShiptoLocationAddressLine3 = "ShiptoLocationAddressLine3";
        public const string COL_ShiptoLocationCity = "ShiptoLocationCity";
        public const string COL_ShiptoLocationStateName = "ShiptoLocationStateName";
        public const string COL_ShiptoLocationZipCode = "ShiptoLocationZipCode";
        public const string COL_ShiptoLocationCountryName = "ShiptoLocationCountryName";
        public const string COL_ShiptoLocationCountry = "ShiptoLocationCountry";

        public const string COL_SHIPTOLOC_ID = "ShiptoLocationID";
        public const string COL_SHIPTOLOC_NAME = "ShiptoLocationName";
        public const string COL_SHIPTOLOC_IsDefault = "IsDefault";
        public const string COL_SHIPTOLOC_NUMBER = "ShiptoLocationNumber";
        public const string COL_SHIPTOLOC_ISADHOC = "IsAdhoc";
        public const string COL_SHIPTOLOC_ALLOWFORFUTUREREFERENCE = "AllowForFutureReference";
        public const string COL_SHIPTOLOC_CONTACTPERSON = "ContactPerson";
        public const string COL_ADDRESS1 = "AddressLine1";
        public const string COL_ADDRESS2 = "AddressLine2";
        public const string COL_ADDRESS3 = "AddressLine3";
        public const string COL_CITY = "City";
        public const string COL_STATE = "State";
        public const string COL_ZIP = "Zip";
        public const string COL_COUNTRY = "Country";
        public const string COL_COUNTRYCODE = "CountryCode";
        public const string COL_COUNTRYABBREVATIONCODE = "CountryAbbrevationCode";
        public const string COL_COUNTY = "County";
        public const string COL_STATECODE = "StateCode";
        public const string COL_STATENAME = "StateName";
        public const string COL_SHIPTO_MAPPINGENTITY = "MappingEntity";

        public const string COL_SHIPTO_COUNTRYNAME = "CountryName";

        public const string COL_BILLTOLOC_ID = "BilltoLocationID";
        public const string COL_BILLTOLOC_NAME = "BilltoLocationName";
        public const string COL_BILLTOLOC_NUMBER = "BilltoLocationNumber";
        public const string COL_ISDEFAULT = "IsDefault";
        public const string COL_ISDELETE = "IsDeleted";
        public const string COL_ADDRESSID = "AddressID";
        public const string BILLTO_COL_ADDRESS1 = "BillToAddressLine1";
        public const string BILLTO_COL_ADDRESS2 = "BillToAddressLine2";
        public const string BILLTO_COL_ADDRESS3 = "BillToAddressLine3";
        public const string BILLTO_COL_CITY = "BillToCity";
        public const string BILLTO_COL_STATE = "BillToState";
        public const string BILLTO_COL_STATECODE = "BillToStateCode";
        public const string BILLTO_COL_COUNTRYCODE = "BillToCountryCode";
        public const string BILLTO_COL_COUNTRYNAME = "BillToCountryName";
        public const string BILLTO_COL_ZIP = "BillToZip";
        public const string BILLTO_COL_FAXNO = "BillToFaxNo";
        public const string BILLTO_COL_EmailAddress = "BillToEmailAddress";
        public const string BILLTO_COL_BilltoLocationAddressLine1 = "BilltoLocationAddressLine1";
        public const string BILLTO_COL_BilltoLocationAddressLine2 = "BilltoLocationAddressLine2";
        public const string BILLTO_COL_BilltoLocationAddressLine3 = "BilltoLocationAddressLine3";
        public const string BILLTO_COL_BilltoLocationCity = "BilltoLocationCity";
        public const string BILLTO_COL_BilltoLocationStateName = "BilltoLocationStateName";
        public const string BILLTO_COL_BilltoLocationZipCode = "BilltoLocationZipCode";
        public const string BILLTO_COL_BilltoLocationCountryName = "BilltoLocationCountryName";
        public const string BILLTO_COL_BilltoLocationFaxNo = "BilltoLocationFaxNo";
        public const string BILLTO_COL_BilltoLocationEmailAddress = "BilltoLocationEmailAddress";

        public const string OL_COL_LocationId = "LocationId";
        public const string OL_COL_LocationCode = "ClientLocationCode";
        public const string OL_COL_LocationName = "LocationName";
        public const string OL_COL_ADDRESS1 = "OLAddressLine1";
        public const string OL_COL_ADDRESS2 = "OLAddressLine2";
        public const string OL_COL_ADDRESS3 = "OLAddressLine3";
        public const string OL_COL_CITY = "OLCity";
        public const string OL_COL_STATE = "OLState";
        public const string OL_COL_ZIP = "OLZip";
        public const string OL_COL_COUNTRY = "OLCountry";
        public const string OL_COL_COUNTRYCODE = "OLCountryCode";
        public const string OL_COL_STATECODE = "OLStateCode";
        public const string OL_COL_STATENAME = "OLState";
        public const string OL_COL_orderLocationNameAndAddress = "orderLocationNameAndAddress";

        public const string OL_COL_remitToLocSupplierNameAndAddress = "remitToLocSupplierNameAndAddress";

        public const string RL_COL_LocationId = "RemitTolocationID";
        public const string RL_COL_LocationName = "RemitToLocationName";
        public const string RL_COL_ADDRESS1 = "RemitToAddressLine1";
        public const string RL_COL_ADDRESS2 = "RemitToAddressLine2";
        public const string RL_COL_ADDRESS3 = "RemitToAddressLine3";
        public const string RL_COL_CITY = "RemitToCity";
        public const string RL_COL_STATE = "RemitToState";
        public const string RL_COL_STATENAME = "RemitToStateName";
        public const string RL_COL_ZIP = "RemitToZip";
        public const string RL_COL_RemitToCountryName = "RemitToCountryName";
        public const string COL_InvoiceReceviedOn = "InvoiceReceviedOn";

        public const string RL_COL_COUNTRY = "RemitToCountry";

        public const string COL_DELIVERTOLOC_ID = "DelivertoLocationID";
        public const string COL_DELIVERTOLOC_NAME = "DelivertoLocationName";
        public const string COL_DELIVERTOLOC_NUMBER = "DelivertoLocationNumber";
        public const string DEL_COL_ADDRESS1 = "DeliverToAddressLine1";
        public const string DEL_COL_ADDRESS2 = "DeliverToAddressLine2";
        public const string DEL_COL_ADDRESS3 = "DeliverToAddressLine3";
        public const string DEL_COL_CITY = "DeliverToCity";
        public const string DEL_COL_STATE = "DeliverToState";
        public const string DEL_COL_ZIP = "DeliverToZip";
        public const string DEL_COL_COUNTRYCODE = "DeliverToCountryCode";
        public const string DEL_COL_COUNTRY = "DeliverToCountry";
        public const string DEL_COL_STATECODE = "DeliverToStateCode";
        public const string DEL_COL_DelivertoLocationAddressLine1 = "DelivertoLocationAddressLine1";
        public const string DEL_COL_DelivertoLocationAddressLine2 = "DelivertoLocationAddressLine2";
        public const string DEL_COL_DelivertoLocationAddressLine3 = "DelivertoLocationAddressLine3";
        public const string DEL_COL_DelivertoLocationCity = "DelivertoLocationCity";
        public const string DEL_COL_DelivertoLocationStateName = "DelivertoLocationStateName";
        public const string DEL_COL_DelivertoLocationCountryName = "DelivertoLocationCountryName";
        public const string DEL_COL_DelivertoLocationZipCode = "DelivertoLocationZipCode";

        public const string COL_REMITTOLOCATIONNAME = "LocationName";
        public const string COL_COUNTRYID = "CountryId";
        public const string COL_COUNTRYNAME = "CountryName";
        public const string COL_STATECOUNTRYID = "StatecountryId";
        public const string COL_STATEABBREVATIONCODE = "StateAbbrevationCode";
        public const string COL_CLIENTLOCATIONCODE = "ClientLocationCode";
        public const string COL_REMITTOLOCATIONCODE = "RemittoLocationCode";

        public const string COL_REMITTOLOCATION = "RemittoLocation";

        public const string COL_DOCUMENT_CODE = "DocumentCode";
        public const string COL_DOCUMENT_NAME = "DocumentName";
        public const string COL_DOCUMENT_NUMBER = "DocumentNumber";
        public const string COL_DOCUMENT_STATUS = "DocumentStatus";
        public const string COL_TOTAL_ITEM_RECORD = "TotalItemRecord";
        public const string COL_INVOICEEXTENDEDSTATUS = "InvoiceExtendedStatus";
        public const string COL_POLINEITEMNUMBER = "POLineItemNumber";

        public const string SFL_COL_LOCATIONID = "ShipFromLocationId";
        public const string SFL_COL_LOCATIONCODE = "ShipFromLocationCode";
        public const string SFL_COL_LOCATIONNAME = "ShipFromLocationName";
        public const string SFL_COL_ADDRESS1 = "ShipFromLocAddress1";
        public const string SFL_COL_ADDRESS2 = "ShipFromLocAddress2";
        public const string SFL_COL_ADDRESS3 = "ShipFromLocAddress3";
        public const string SFL_COL_CITY = "ShipFromLocCity";
        public const string SFL_COL_ZIP = "ShipFromLocZip";
        public const string SFL_COL_COUNTRY = "ShipFromLocCountry";
        public const string SFL_COL_STATENAME = "ShipFromLocState";

        public const string COL_TERMS_AND_CONDITIONS = "TermsAndConditionId";

        public const string COL_DOC_AUTHORNAME = "AuthorName";
        public const string COL_DOC_DOCUMENTAMOUNT = "DocumentAmount";
        public const string COL_DOC_TYPEOFDOCUMENT = "TypeOfDocument";
        public const string COL_DOC_DATEOFAPPROVAL = "DateofApproval";
        public const string COL_DOC_APPROVEDDATE = "ApprovedDate";
        public const string COL_DOCUMENT_ITEM_ID = "DocumentItemId";
        public const string COL_ISCHECKED = "IsChecked";
        public const string COL_DOCUMENT_SPLIT_ITEM_ID = "DocumentSplitItemId";

        public const string COL_ENABLEORIGINALAPPROVERNOTIFICATIONS = "EnableOriginalApproverNotifications";
        public const string COL_ADDTASKFORORIGINALAPPROVER = "AddTaskForOriginalApprover";
        public const string COL_DATEFROM = "DateFrom";
        public const string COL_DATETO = "DateTo";
        public const string COL_DOCTYPEID = "DocTypeId";
        public const string COL_WFDOCTYPEID = "WFDocTypeId";

        public const string COL_INTERFACESTATUS = "InterfaceStatus";

        public const string COL_CONTACTCODE = "ContactCode";
        public const string COL_FIRSTNAME = "FirstName";
        public const string COL_LASTNAME = "LastName";

        public const string COL_PENDING_VALUE = "PendingValue";
        public const string COL_UTILIZED_VALUE = "UtilizedValue";
        public const string COL_TARGET_CURRENCYCODE = "TargetCurrencyCode";

        public const string COL_PARTNERRECONMATCHTYPEID = "PartnerReconMatchTypeId";
        public const string COL_CONFIGTYPE = "ConfigType";
        public const string COL_CONFIGDETAILS = "ConfigDetails";
        public const string COL_SELECTED = "Selected";
        public const string COL_INCLUDED = "Included";
        public const string COL_EXCLUDED = "Excluded";
        public const string COL_REMITTOLOCATIONID = "RemitToLocationId";
        public const string COL_ORDERTOLOCATIONID = "OrderToLocationId";
        public const string COL_PARTNERSOURCESYSTEMVALUE = "PartnerSourceSystemValue";
        public const string COL_REMITTOLOCATION_CODE = "RemitToLocationAddressCode";
        public const string COL_ORDERTOLOCATION_CODE = "OrderingLocationAddressCode";
        public const string COL_SELECTEDITEMS = "selectedItems";
        public const string COL_PURCHASETYPEDESC = "PurchaseTypeDesc";
        public const string COL_PROGRAMDESC = "ProgramDesc";
        public const string COL_PRICEBOOKSTATUS = "PriceBookStatus";

        #region Combination Code Column

        public const string COL_CombinationCode = "Code";
        public const string COL_DateModified = "DateModified";
        public const string COL_CCStructureId = "CCStructureId";

        #endregion Combination Code Column

        #endregion Common Entity Columns

        #region Invoice External Tax

        public const string COL_TaxRateCode = "TaxRateCode";
        public const string COL_EffectiveTaxLevel = "EffectiveTaxLevel";
        public const string COL_LocationCode = "LocationCode";
        public const string COL_OfficialName = "OfficialName";

        #endregion Invoice External Tax

        #region Table Types

        public const string TVP_P2P_OrgEntity = "TVP_P2P_OrgEntity";
        public const string TVP_P2P_INTERNALCATALOGITEMS = "tvp_P2P_InternalCatalogItems";
        public const string TVP_P2P_USERLIST = "tvp_P2P_UserList";
        public const string TVP_TAXCODES = "tvp_TaxCodes";
        public const string TVP_ORG_ENTITYCODES = "tvp_ORG_EntityCodes";
        public const string TVP_ADDRESS = "tvp_Address";
        public const string TVP_WF_DOCUMENTDELEGATION = "tvp_WF_DocumentDelegation";
        public const string TVP_P2P_STANDARDUOMLIST = "tvp_P2P_StandardUOMList";
        public const string TVP_P2P_IDS = "tvp_P2P_Ids";
        public const string TVP_P2P_FORMCODEOBJECTINSTANCEID = "tvp_P2P_FormCodeObjectInstanceId";
        public const string TVP_ORG_ENTITYIDS = "tvp_ORGEntityCodesList";
        public const string TVP_P2P_KEYVALUE = "tvp_P2P_KeyValue";
        public const string TVP_OrgEntity = "tvp_OrgEntity";
        public const string TVP_P2P_SourceEntityDetails = "tvp_P2P_SourceEntityDetails";
        public const string TVP_P2P_TargetEntityDetails = "tvp_P2P_TargetEntityDetails";
        public const string TVP_P2P_CUSTOMATTRIBUTEQUESTIONTEXT = "tvp_P2P_CustomAttributeQuestionText";
        public const string TVP_P2P_INVOICEDOCUMENTUPDATE = "tvp_P2P_InvoiceDocumentUpdate";
        public const string TVP_P2P_INV_EXCEPTIONRESOLVERSDETAILS = "TVP_P2P_INV_ExceptionResolversDetails";

        #endregion Table Types

        #endregion Common Entity

        #region OCR Attributes

        #region SPs

        public const string USP_P2P_INV_GETFIELDMAPPINGDETAILSFOROCRINVOICEPROCESSING = "usp_P2P_INV_GetFieldMappingDetailsForOCRInvoiceProcessing";
        public const string USP_P2P_INV_VALIDATEERRORCODEOCRDOCUMENT = "usp_P2P_INV_ValidateErrorCodeOcrDocument";
        public const string USP_P2P_INV_GETINVOICEHEADERDETAILSBYORDERNUMBER = "usp_P2P_INV_GetInvoiceHeaderDetailsByOrderNumber";
        public const string USP_P2P_INV_SAVEOCRRESPONSES = "usp_P2P_INV_SaveOCRResponses";
        public const string USP_OCR_GETRESPONSE = "usp_OCR_GetResponse";
        public const string USP_OCR_GETERRORSTATUS = "usp_OCR_GetErrorStatus";
        public const string USP_OCR_UPDATEHEADERINFO = "usp_OCR_UpdateHeaderInfo";
        public const string USP_OCR_GETAIRESPONSE = "usp_OCR_GetAIResponse";

        #endregion SPs

        #region Fields

        public const string COL_OCRFIELDNAME = "OCRFieldName";
        public const string COL_INVOICEOBJFIELDNAME = "InvoiceObjFieldName";
        public const string COL_BULIST = "BUList";
        public const string COL_EMAILID = "EmailID";
        public const string COL_TRANSACTIONID = "TransactionId";
        public const string COL_DOCUMENTRESPONSE = "DocumentResponse";

        #endregion Fields

        #endregion OCR Attributes

        #region Invoice

        #region Invoice Columns

        public const string COL_INVOICE_ID = "InvoiceId";
        public const string COL_INVOICE_NAME = "DocumentName";
        public const string COL_INVOICE_NUMBER = "DocumentNumber";
        public const string COL_INVOICE_PARTNERINVOICENUMBER = "PartnerInvoiceNumber";
        public const string COL_INVOICE_PARTNERINVOICEDATE = "PartnerInvoiceDate";
        public const string COL_BU = "BU";
        public const string COL_INVOICE_REMITTOLOCATIONID = "RemittoLocationId";
        public const string COL_INVOICE_SHIPTOLOCATIONID = "ShipToLocationId";
        public const string COL_MATCHSTATUS = "MatchStatus";
        public const string COL_MATCHLEVEL = "MatchLevel";
        public const string COL_EXCEPTIONTYPEID = "ExceptionTypeId";
        public const string COL_EXCEPTIONTYPE = "ExceptionType";
        public const string COL_MATCHNAME = "MatchName";
        public const string COL_MATCHDISPLAYNAME = "DisplayName";
        public const string COL_INV_NAME = "InvoiceName";
        public const string COL_INV_NUMBER = "InvoiceNumber";
        public const string COL_INV_NONPOINVOICE = "NonPOInvoice";
        public const string COL_ORDER_DOCUMENTCODE = "OrderDocumentCode";
        public const string COL_ORDER_DOCUMENTNUMBER = "OrderDocumentNumber";
        public const string COL_ORDER_CREATED_DATE = "OrderCreatedDate";
        public const string COL_INVOICESOURCE = "InvoiceSource";
        public const string COL_INVOICEORIGIN = "InvoiceOrigin";
        public const string COL_DATERECEIVED = "DateReceived";
        public const string COL_USETAX = "UseTax";
        public const string COL_ISINVSPLITDELETED = "IsInvSplitDeleted";
        public const string COL_ORDERCONTACT = "OrderContact";
        public const string COL_ORDERP2PLINEITEMID = "OrderP2PLineItemId";
        public const string COL_MATERIAL_ITEM_COUNT = "MaterialItemCount";
        public const string COL_SERVICE_ITEM_COUNT = "ServiceItemCount";
        public const string COL_ADVANCE_ITEM_COUNT = "AdvanceItemCount";
        public const string COL_CHARGE_ITEM_COUNT = "ChargeItemCount";
        public const string COL_SUBLINEITEMCOUNT = "SublineItemCount";
        public const string COL_INVOICEDOCSTATUS = "InvoiceDocStatusInfo";
        public const string COL_INVOICE_CREATED_FROM = "InvoiceCreatedFrom";
        public const string COL_InvoiceCreatedDate = "InvoiceCreatedDate";
        public const string COL_ORDER_PARTNER_CODE = "OrderPartnerCode";
        public const string COL_ORDER_PARTNER_NAME = "OrderPartnerName";
        public const string COL_BUYERITEMNUMBER = "BuyerItemNumber";
        public const string COL_INVOICETOTALAMOUNT = "InvoiceTotalAmount";
        public const string COL_ORDER_SOURCESYSTEMID = "OrderSourceSystemId";
        public const string COL_INVOICE_ERRORSTATUSID = "ErrorstatusId";
        public const string COL_INVOICE_ERRORENUM = "EnumName";
        public const string COL_INVOICE_ERRORDATA = "ErrorData";
        public const string COL_INVOICE_MAPPEDCONTROLNAME = "MappedControlName";
        public const string COL_INVOICE_ISRESOLVABLE = "IsResolvable";
        public const string COL_INVOICE_OPERATOR = "Operator";
        public const string COL_INVOICE_ISCOMPUTATIONAL = "IsComputational";
        public const string COL_INVOICE_ISMANDATORY = "IsMandatory";
        public const string COL_INVOICE_COMPARISON_VALUE = "ComparisonValue";
        public const string COL_INVOICE_ERRORSTATUS = "ErrorStatus";
        public const string COL_INVOICE_ERRORDISPLAYNAME = "DisplayName";
        public const string TVP_P2P_INVOICEERROR = "tvp_P2P_InvoiceError";
        public const string COL_ERROR_JSON = "ErrorJson";
        public const string COL_ORDER_PAYMENTTERMID = "OrderPaymentTermId";
        public const string COL_ORDER_CURRENCY = "OrderCurrencyCode";
        public const string COL_INVOICE_STATUS = "InvoiceStatus";
        public const string COL_INVOICE_ORDER_REQUESTER = "OrderRequester";
        public const string COL_INVOICE_ITEMTOTAL = "InvoiceItemTotal";
        public const string COL_INVOICE_TAX = "InvoiceTax";
        public const string COL_INVOICE_SHIPPINGCHARGES = "InvoiceShippingCharges";
        public const string COL_INVOICE_ADDITIONALCHARGES = "InvoiceAdditionalCharges";
        public const string COL_INVOICE_TOTALAMOUNT = "InvoiceTotalAmount";
        public const string COL_INVOICE_USETAX = "InvoiceUseTax";
        public const string COL_INVOICEORDERCONTACT = "InvoiceOrderContact";
        public const string COL_INVOICECURRENCY = "InvoiceCurrency";
        public const string COL_INVOICEORDERCURRENCY = "InvoiceOrderCurrency";
        public const string COL_CLIENTCONTACTCODE = "ClientContactcode";
        public const string COL_clientContactCode = "clientContactCode";
        public const string COL_clientEmailId = "clientEmailId";
        public const string COL_ERP_PROCESSSTATUS = "ERPProcessStatus";
        public const string COL_INVOICE_DATECREATED = "DateCreated";
        public const string COL_INVOICE_DATEBLOCKEXCEPTIONTOLERANCEINDAYS = "DateBlockExceptionToleranceInDays";
        public const string COL_INVOICE_SECONDLEVELACKNOWLEDGEMENT = "SecondLevelAcknowledgement";
        public const string COL_INVOICE_SHOWINTERNALCANCELACTION = "ShowInternalCancelAction";
        public const string COL_EXCEPTIONDESCRIPTION = "Description";
        public const string COL_HEADERTAXCODECOUNT = "HeaderTaxCodeCount";
        public const string COL_TAXCODES = "TaxCodes";
        public const string COL_TAXCODE = "TaxCode";
        public const string COL_INV_SPLIT_ITEM_ENTITYID = "InvoiceSplitItemEntityId";
        public const string COL_INVOICE_FileExtension = "FileExtension";
        public const string COL_INV_REJECTIONCOMMENTS = "RejectionComments";
        public const string COL_INV_REVIEWER_CONTACT_CODE = "ReviewerContactCode";
        public const string COL_INV_REVIEWER_NAME = "ReviewerName";
        public const string COL_PARTNER_INVOICE_Date = "PartnerInvoiceDate";
        public const string COL_INVOICE_SHIPTOLOCATIONNUMBER = "ShiptoLocationNumber";
        public const string COL_INVOICE_AMOUNT = "InvoiceAmount";
        public const string COL_INVOICE_INVOICENUMBER = "InvoiceNumber";
        public const string COL_INVOICE_CREATEDBYNAME = "CreatedByName";
        public const string COL_INVOICE_PARTNERCONTACTNAME = "PartnerContactName";
        public const string COL_INVOICE_TotalAmout = "TotalAmout";
        public const string COL_INVOICE_TotalCharge = "TotalCharge";
        public const string COL_INVOICE_TotalAllowance = "TotalAllowance";
        public const string COL_INV_USETAX = "UseTax";
        public const string COL_INV_SHORTNAME = "ShortName";
        public const string COL_INV_Quantity = "Quantity";
        public const string COL_INV_UseTax = "UseTax";
        public const string COL_INV_SHIPTOZIPCODE = "ZipCode";
        public const string COL_INV_SHIPTOSTATECODE = "ShipToStateCode";
        public const string COL_INV_SHIPTOCOUNTRYCODE = "ShipToCountryCode";
        public const string COL_INV_SHIPTOCOUNTRY = "ShipToCountry";
        public const string COL_INV_PARTNERPAYMENTTYPE = "PartnerPaymentType";
        public const string COL_ORDERPURCHASETYPE = "OrderPurchaseType";
        public const string COL_POBASEDNEWLINESCOUNT = "POBasedNewLinesCount";
        public const string COL_ORDERLINKEDDOCUMENTTYPECODE = "OrderLinkedDocumentTypeCode";
        public const string COL_INVOICECREATOR = "InvoiceCreator";
        public const string COL_ISMULTIDOCINVOICE = "IsMultiDocInvoice";
        public const string COL_ORDER_LINENUMBER = "OrderLineNumber";
        public const string COL_SCHEDULED_PAYMENTDATE = "ScheduledPaymentDate";
        public const string COL_RESOLVER_TYPE = "ResolverType";
        public const string COL_ERPINVOICENUMBER = "ERPInvoiceNumber";
        public const string COL_TES_NUMBER = "TESNumber";
        public const string COL_PRICE_TYPE = "PriceType";
        public const string COL_CONTINGENT_WORKER_NAME = "ContingentWorkerName";
        public const string COL_JOB_TITLE = "JobTitle";
        public const string COL_MARGIN = "Margin";
        public const string COL_BASE_RATE = "BaseRate";
        public const string COL_REPORTING_MANAGER = "ReportingManager";
        public const string COL_INV_QUANTITY = "Quantity";
        public const string COL_SERVICEENDDATE = "ServiceEndDate";
        public const string COL_INVOICECREATIONDATE = "InvoiceCreationDate";
        public const string COL_TotalCharge = "TotalCharge";
        public const string COL_FULFILMENTDOCUMENT_CODE = "FulfilmentDocumentCode";
        public const string COL_FULFILMENT_DOCUMENT_TYPE = "FulfilmentDocumentType";
        public const string COL_FULFILMENT_DOCUMENT_NUMBER = "FulfilmentDocumentNumber";
        public const string COL_EXCEPTIONTOTAL = "ExceptionTotal";
        public const string COL_ISEXCEPTIONFULLYACCEPTED = "IsExceptionFullyAccepted";
        public const string COL_TYPE = "Type";
        public const string COL_IsERS = "IsERS";
        public const string COL_DELIVERYNOTENUMBER = "DeliveryNoteNumber";
        public const string COL_FULFILMENT_DOCUMENT_ITEMID = "FulfilmentDocumentItemId";
        public const string COL_FULFILMENT_DOCUMENT_STATUS = "FulfilmentDocumentStatus";
        public const string COL_FIELD_SUPERVISOR = "FieldSupervisor";
        public const string COL_FIELD_VALUE = "FieldValue";
        public const string COL_FIELD_KEY = "FieldKey";
        public const string COL_VISIBILITY = "Visibility";
        public const string COL_PO_FulfillmentDocumentType = "POFulfillmentDocumentType";
        public const string COL_TOTAL_AMOUNT_FOR_AGGREGATION = "TotalAmountForAggregation";
        public const string COL_ITEM_TOTAL_FOR_AGGREGATION = "ItemTotalForAggregation";
        public const string COL_ITEM_TAX_FOR_AGGREGATION = "TaxForAggregation";
        public const string COL_COLUMNDEFINITION = "ColumnDefinition";
        public const string COL_OBJECTTYPEID = "ObjectTypeId";
        public const string COL_OBJECTTYPEVALUE = "ObjectTypeValue";
        public const string COL_FILE_ID = "FileId";
        public const string COL_COMPLIANCESTATUS = "ComplianceStatus";
        public const string COL_ARCHIVALSTATUS = "ArchivalStatus";
        public const string COL_INVOICECREATIONSOURCE = "InvoiceCreationSource";
        public const string COL_ACCEPTED_QUANTITY = "AcceptedQuantity";
        public const string COL_POCONSUMPTIONDATE = "POConsumptionDate";
        public const string COL_INVOICESUBMITTEDDATE = "InvoiceSubmittedDate";
        public const string COL_MATCHEDITEMVALUE = "MatchedItemValue";
        #endregion Invoice Columns

        #region Invoice Compliance

        public const string COL_FIELD_MAPPING = "FieldMapping";
        public const string COL_USERTYPE = "UserType";
        public const string COL_COMPLIANCETYPE = "ComplianceType";
        public const string COL_VALIDATIONTYPE = "ValidationType";
        public const string COL_SIGNINGTYPE = "SigningType";
        public const string COL_TRANSFORMATIONTYPE = "TransformationType";
        public const string COL_ISARCHIVALENABLED = "IsArchivalEnabled";
        public const string USP_P2P_INV_GETINVOICECOMPLIANCEDETAILS = "usp_P2P_INV_GetInvoiceComplianceDetails";
        public const string USP_P2P_INV_UPDATEINVOICEGLOBALCOMPLIANCEANDARCHIVALDETAILS = "usp_p2p_Inv_UpdateInvoiceGlobalComplianceAndArchivalDetails";

        public const string USP_P2P_INV_GETCOUNTRYSPECIFICCOMPLIANCETYPEANDAPIINFO =
            "usp_P2P_INV_GetCountrySpecificComplianceTypeAndAPIInfo";

        #endregion Invoice Compliance

        #region Invoice Upload info

        public const string COL_ID = "Id";
        public const string COL_USERCONTEXT = "UserContext";
        public const string COL_USEREMAIL = "UserEmail";
        public const string COL_UPLOADEDFILEID = "UploadedFileId";
        public const string COL_UPLOADEDFILENAME = "UploadedFileName";
        public const string COL_UPLOADEDFILETYPE = "UploadedFileType";
        public const string COL_UPLOADEDFILEURI = "UploadedFileUri";
        public const string COL_PROCESSEDFILEID = "ProcessedFileId";
        public const string COL_PROCESSEDFILENAME = "ProcessedFileName";
        public const string COL_PROCESSEDFILETYPE = "ProcessedFileType";
        public const string COL_PROCESSEDFILEURI = "ProcessedFileUri";
        public const string COL_PROCESSEDRESULT = "ProcessedResult";
        public const string COL_PROCESSEDRESULTXML = "ProcessedResultXml";
        public const string COL_TOTAL = "Total";
        public const string COL_PROCESSED = "Processed";
        public const string COL_UNPROCESSED = "UnProcessed";
        public const string COL_PROCESSEDCOUNT = "ProcessedCount";
        public const string COL_USERNAME = "Username";
        public const string COL_REQUESTEDTIME = "RequestedTime";
        public const string COL_COMPLETIONTIME = "CompletionTime";
        public const string COL_ERRORNAME = "ErrorName";
        public const string COL_DISPLAYDOCUMENTSTATUSDESC = "DisplayDocumentStatusDESC";
        public const string COL_EXCELFILETYPE = "ExcelFileType";

        #endregion Invoice Upload info

        #region InvoiceRemittanceDetails

        public const string COL_REMITTANCE_ID = "Id";
        public const string COL_PAYMENT_DATE = "PaymentDate";
        public const string COL_PAYMENT_REF_NO = "PaymentReferenceNumber";
        public const string COL_PAYMENT_REMITTANCE_ID = "PaymentRemittanceId";
        public const string COL_PAYMENT_METHOD = "PaymentMethod";
        public const string COL_NET_AMOUNT = "NetAmount";
        public const string COL_IRTYPEID = "IRTypeId";
        public const string COL_GROSS_AMOUNT = "GrossAmount";
        public const string COL_DISCOUNT_AMOUNT = "DiscountAmount";
        public const string COL_ADJUSTMENT_AMOUNT = "AdjustmentAmount";
        public const string COL_REMITTANCE_STATUS = "RemittanceStatus";
        public const string COL_REMITTANCE_ISCREDITMEMO = "IsCreditMemo";
        public const int COL_HEDDERlEVEL = 0;
        public const int COL_ITEMLEVEL = 1;
        public const string COL_SCHEDULE_PAY_DATE = "SchedulePayDate";
        public const string COL_FULL_REMITTANCE_VALUE = "FullRemittanceValue";
        public const string COL_REMAINING_AMOUNT = "RemainingAmount";

        #endregion InvoiceRemittanceDetails

        #region Invoice LineItem Columns

        public const string COL_INVOICE_ITEM_ID = "InvoiceItemId";
        public const string COL_IR_ITEM_ID = "IRItemId";
        public const string COL_INVOICE_POITEMQUANTITY = "POItemQuantity";
        public const string COL_INVOICE_POITEMUNITPRICE = "POItemUnitPrice";
        public const string COL_INVOICE_LINEITEMSHIPPINGID = "InvoiceLineItemShippingID";
        public const string COL_INVOICE_INVOICEAMOUNT = "InvoicingAmount";
        public const string COL_INVOICE_REMAININGINVOICEAMOUNT = "RemainingInvoiceAmount";
        public const string COL_LINEAMOUNTDIFF = "LineAmountDiff";
        public const string COL_INVOICE_MATCHSTATUS = "MatchStatus";
        public const string COL_PARTNERITEMNUMBER = "PartnerItemNumber";
        public const string COL_CONTRACTNUMBER = "ContractNumber";
        public const string COL_INVOICE_ITEMMATCHTYPE = "ItemMatchType";
        public const string COL_ORDER_START_DATE = "OrderStartDate";
        public const string COL_POITEMLINENUMBER = "POItemLineNumber";
        public const string COL_LINETAXCODECOUNT = "LineTaxCodeCount";
        public const string COL_ITEMCONTROLTYPE = "ItemControlType";

        #endregion Invoice LineItem Columns

        #region Charge Item Column

        public const string COL_CHARGE_CHARGEAMOUNT = "ChargeAmount";
        public const string COL_CHARGE_CALCULATIONVALUE = "CalculationValue";
        public const string COL_CHARGE_ISALLIWANCE = "IsAllowance";
        public const string COL_CHARGE_INVOICEITEMID = "InvoiceItemId";
        public const string COL_CHARGE_ITEMCHARGEID = "ItemChargeId";

        #endregion Charge Item Column

        #region Dynamic Discount Columns

        public const string COL_DISCOUNT = "Discount($)";
        public const string COL_DISCOUNTPERCENTAGE = "Discount(%)";
        public const string COL_INVOICE_PAYDATE = "InvoicePayDate";
        public const string COL_INVOICE_PAY_AMOUNT = "InvoicePayAmount";
        public const string COL_INVITATION_ID = "InvitationId";
        public const string COL_DYNAMICDISCOUNT_STATUS = "Status";
        public const string COL_DYNAMICDISCOUNT_STATUS_DISPLAY_NAME = "DynamicDiscountStatusDisplayName";
        public const string COL_DYNAMICDISCOUNT_PAYDATE = "DynamicDiscountPayDate";
        public const string COL_DYNAMICDISCOUNT_PAY_AMOUNT = "DynamicDiscountPayAmount";
        public const string COL_DYNAMICDISCOUNT_STARTDATE = "StartDate";
        public const string COL_DYNAMICDISCOUNT_ENDDATE = "EndDate";
        public const string COL_DYNAMICDISCOUNT_DISCOUNTDETAILSKEY = "DiscountDetailsKey";
        public const string COL_DYNAMICDISCOUNT_DISCOUNTDETAILSVALUE = "DiscountDetailsValue";
        public const string COL_CREATEDBY = "CreatedBy";

        #endregion Dynamic Discount Columns

        #region Program Columns

        public const string COL_PROGRAM_ID = "ProgramId";
        public const string COL_PROGRAM_NAME = "ProgramName";
        public const string COL_ENFORCEMENTID = "EnforcementId";
        public const string COL_DISPLAYNAME = "DisplayName";
        public const string COL_PARENTID = "ParentId";
        public const string COL_OWNER = "Owner";
        public const string COL_AUTHOR = "Author";
        public const string COL_SPONSOR = "Sponsor";
        public const string COL_PROGRAM_DESCRIPTION = "Description";
        public const string COL_BUDGET = "Budget";
        public const string COL_COMMITTEDFUNDS = "CommittedFunds";
        public const string COL_OBLIGATEDFUNDS = "ObligatedFunds";
        public const string COL_EXPENSEDFUNDS = "ExpensedFunds";
        public const string COL_AVAILABLEFUNDS = "AvailableFunds";
        public const string COL_DATEACTIVATED = "DateActivated";
        public const string COL_DATEINACTIVATED = "DateInActivated";
        public const string COL_DATEDELETED = "DateDeleted";
        public const string COL_DATECLOSED = "DateClosed";
        public const string COL_DOCUMENT_COUNT = "DocumentCount";
        public const string COL_ADJUSTMENT_NUMBER = "AdjustmentNumber";
        public const string COL_FORMID = "FormId";
        public const string COL_ITEMFORMID = "ItemFormId";
        public const string COL_SPLITFORMID = "SplitFormId";
        public const string COL_HASCOMMENTS = "HasComments";
        public const string COL_LEVEL = "Level";
        public const string COL_ISSUBMIT = "IsSubmit";

        #endregion Program Columns

        #region Invoice Tax Master Info Columns

        public const string COL_JURISDICTION_CODE = "JurisdictionCode";
        public const string COL_JURISDICTION_NAME = "JurisdictionName";

        #endregion Invoice Tax Master Info Columns

        #region Invoice StoredProcedures

        public const string USP_P2P_INV_GETINVOICEITEMS = "usp_P2P_INV_GetInvoiceItems";
        public const string USP_P2P_INV_GETALLDISPLAYDERAILS = "usp_P2P_INV_GetAllDisplayDetails";
        public const string USP_P2P_INV_GETINVOICEBASICDETAILSBYID = "usp_P2P_INV_GetInvoiceBasicDetailsById";
        public const string USP_P2P_INV_GETBASICDETAILSBYIDFORINTERFACE = "usp_P2P_INV_GetBasicDetailsByIdForInterface";
        public const string USP_P2P_INV_GETCHARGEMASTERDETAILSBYLOBID = "usp_P2P_INV_GetChargeMasterDetailsByLobId";
        public const string TVP_P2P_ITEMCHARGES = "tvp_P2P_ItemCharges";
        public const string USP_P2P_SAVEALLREQUISITIONITEMCHARGES = "usp_P2P_SaveAllRequisitionItemCharges";
        public const string USP_P2P_DELETEREQUISITIONITEMCHARGEBYID = "usp_P2P_DeleteRequisitionItemChargeById";
        public const string USP_P2P_INV_SAVEINVOICEITEMCHARGES = "usp_P2P_INV_SaveInvoiceItemCharges";

        public const string USP_P2P_INV_GETINVOICEBUYERANDPARTNERDETAILS =
            "usp_P2P_INV_GetInvoiceBuyerAndPartnerDetails";

        public const string USP_P2P_INV_GETALLLINEITEMSBYID = "usp_P2P_INV_GetAllLineItemsById";
        public const string USP_P2P_INV_GETALLLINEITEMSBYIDFORINTERFACE = "usp_P2P_INV_GetAllLineItemsByIdForInterface";
        public const string USP_P2P_INV_GETPARTNERDETAILSBYLIID = "usp_P2P_INV_GetPartnerDetailsByLiId";
        public const string USP_P2P_INV_GETSHIPPINGSPLITDETAILSBYLIID = "usp_P2P_INV_GetShippingSplitDetailsByLiId";
        public const string USP_P2P_INV_GETSHIPPINGSPLITDETAILSBYINVID = "usp_P2P_INV_GetShippingSplitDetailsByInvId";
        public const string USP_P2P_INV_GETOTHERITEMDETAILSBYLIID = "usp_P2P_INV_GetOtherItemDetailsByLiId";
        public const string USP_P2P_INV_SAVEINVOICEITEM = "usp_P2P_INV_SaveInvoiceItem";
        public const string USP_P2P_INV_GETINVOICEINFOFORNOTIFICATIONS = "usp_P2P_INV_GetInvoiceInfoForNotifications";
        public const string USP_P2P_INV_GETINVOICEENTITYDETAILSBYID = "usp_P2P_INV_GetInvoiceEntityDetailsById";
        public const string USP_P2P_INV_GETDOCUMENTDETAILSBYNUMBER = "usp_P2P_INV_GetDocumentDetailsByNumber";

        public const string USP_P2P_INV_GETALLDOCUMENTITEMSCHECKEDSTATUS =
            "usp_P2P_INV_GetAllDocumentItemsCheckedStatus";

        public const string USP_P2P_INV_GETINVOICERELATEDLOCATIONDETAILS =
            "usp_P2P_INV_GetInvoiceRelatedLocationDetails";

        public const string USP_P2P_INV_GETALLMATCHSTATUSBYID = "usp_P2P_INV_GetAllMatchStatusById";

        public const string USP_P2P_INV_SAVEINVOICEITEMPARTNERS = "usp_P2P_INV_SaveInvoiceItemPartners";
        public const string USP_P2P_INV_SAVEINVOICEITEMSHIPPING = "usp_P2P_INV_SaveInvoiceItemShippingDetails";
        public const string USP_P2P_INV_GENERATEDEFAULTINVOICENAME = "usp_P2P_INV_GenerateDefaultInvoiceName";

        public const string USP_P2P_INV_GETALLLINEITEMSBYINVOICEIDFORLEFTPANEL =
            "usp_P2P_INV_GetAllLineItemsByInvoiceIdForLeftPanel";

        public const string USP_P2P_INV_DELETELINEITEMBYID = "usp_P2P_INV_DeleteLineItembyId";
        public const string USP_P2P_INV_SAVEINVOICE = "usp_P2P_INV_SaveInvoice";

        public const string USP_P2P_INV_SAVEINVOICEADDITIONALENTITYDETAILS =
            "usp_P2P_INV_SaveInvoiceAdditionalEntityDetails";

        public const string USP_P2P_INV_UPDATERECEIVEDATE = "usp_P2P_INV_UpdateReceiveDate";
        public const string USP_P2P_INV_CREATEINVOICEORDER = "usp_P2P_INV_CreateInvoiceOrder";
        public const string USP_P2P_INV_CREATEINVOICEFROMPAYMENTREQUEST = "usp_P2P_INV_CreateInvoiceFromPaymentRequest";

        public const string USP_P2P_INV_CREATEINVOICEFROMSERVICECONFIRMATION =
            "usp_P2P_INV_CreateInvoiceFromServiceConfirmation";

        public const string USP_P2P_INV_CREATEINVOICESCANIMAGE = "usp_P2P_INV_CreateInvoiceScanImage";
        public const string USP_P2P_INV_VALIDATEINTERFACEINVOICESTATUS = "usp_P2P_INV_ValidateInterfaceInvoiceStatus";

        public const string USP_P2P_INV_VALIDATEINTERFACEINVOICESTATUSBATCH =
            "usp_P2P_INV_ValidateInterfaceInvoiceStatusBatch";

        public const string USP_P2P_INV_UPDATEINVOICEMATCHINGSTATUSFORINTERFACE =
            "usp_P2P_INV_UpdateInvoiceMatchingStatusForInterface";

        public const string USP_P2P_INV_GETINVOICEDETAILSFORINTERFACE = "usp_P2P_INV_GetInvoiceDetailsForInterface";
        public const string USP_P2P_INV_DELETESPLITITEMSBYITEMID = "usp_P2P_Inv_DeleteSplitItemsByItemId";
        public const string USP_P2P_INV_GETALLORDERITEMSBYORDERID = "usp_P2P_INV_GetAllOrderItemsByOrderId";
        public const string USP_P2P_REQ_DELETESPLITITEMSBYITEMID = "usp_P2P_REQ_DeleteSplitItemsByItemId";

        public const string USP_P2P_INV_GETINVOICEORDERID = "usp_P2P_INV_GetInvoiceOrderId";
        public const string USP_P2P_INV_GETIRBYINVOICEID = "usp_P2P_INV_GetIRByInvoiceId";
        public const string USP_P2P_INV_COPYINVOICE = "usp_P2P_INV_CopyInvoice";
        public const string USP_P2P_INV_VALIDATEPARTNERINVOICENUMBER = "usp_P2P_INV_ValidatePartnerInvoiceNumber";

        public const string USP_P2P_INV_GETBASICDETAILBYSUPPLIERINVOICENUMBER =
            "usp_P2P_INV_GetBasicDetailBySupplierInvoiceNumber";

        public const string USP_P2P_INV_GETINVOICEDETAILSBYINVOICENUMBERANDSTATUS =
            "usp_P2P_INV_GetInvoiceDetailsByInvoiceNumberAndStatus";

        public const string USP_P2P_INV_UPDATEINTERFACESTATUS = "usp_P2P_INV_UpdateInterfaceStatus";
        public const string USP_P2P_INV_UPDATEINVOICEPAYMENTDETAILS = "usp_P2P_INV_UpdateInvoicePaymentDetails";
        public const string USP_P2P_INV_UPDATEEXTENDEDSTATUS = "usp_P2P_INV_UpdateExtendedStatus";
        public const string USP_P2P_INV_GETREMITTANCEDETAILSBYINVOICEID = "usp_P2P_INV_GetRemittanceDetailsByInvoiceID";

        public const string USP_P2P_INV_GETREMITTANCEDETAILSHISTORYBYINVOICEID =
            "usp_P2P_INV_GetRemittanceDetailsHistoryByInvoiceID";

        public const string USP_P2P_INV_GETREMITTANCEDETAILSBYPAYMENTREFERENCENUMBER =
            "usp_P2P_INV_GetRemittanceDetailsByPaymentReferenceNumber";

        public const string USP_P2P_INV_VALIDATEDOCUMENT = "usp_P2P_INV_ValidateDocument";
        public const string USP_P2P_INV_VALIDATECANCELINVOICE = "usp_P2P_INV_ValidateCancelInvoice";

        public const string USP_P2P_INV_GETINVOICEIDBYPARTNERINVOICENUMBER =
            "usp_P2P_INV_GetInvoiceIdByPartnerInvoiceNumber";

        public const string USP_P2P_INV_COPYORDERITEMSTOINVOICE = "usp_P2P_INV_CopyOrderItemsToInvoice";
        public const string USP_P2P_INV_GETSCANNEDIMAGEIDSBYINVOICEID = "usp_P2P_INV_GetScannedImageIdsByInvoiceId";
        public const string USP_P2P_INV_GETORDERDETAILSFORINVOICE = "usp_P2P_INV_GetOrderDetailsForInvoice";
        public const string USP_P2P_INV_GETALLORDERFORINVOICES = "usp_P2P_INV_GetAllOrderForInvoices";
        public const string USP_P2P_INV_GETINVOICELINEITEMTAXES = "usp_P2P_INV_GetInvoiceLineItemTaxes";
        public const string USP_P2P_INV_UPDATEINVOICELINEITEMTAXES = "usp_P2P_INV_UpdateInvoiceLineItemTaxes";
        public const string USP_P2P_INV_INSERTUPDATELINEITEMTAXES = "usp_P2P_INV_InsertUpdateLineItemTaxes";

        public const string USP_P2P_INV_GETINVOICEHEADERANDITEMTAXBYITEMID =
            "usp_P2P_INV_GetInvoiceHeaderAndItemTaxByItemId";

        public const string USP_P2P_INV_DELETELINEITEMTAXBYID = "usp_P2P_INV_DeleteLineItemTaxById";
        public const string USP_P2P_INV_CALCULATE_AND_UPDATELINEITEMTAX = "usp_P2P_INV_CalculateAndUpdateLineItemTax";
        public const string USP_P2P_INV_CALCULATELINEITEMTAX = "usp_P2P_INV_CalculateLineItemTax";
        public const string USP_P2P_INV_GETALLITEMSFORUSETAX = "usp_P2P_INV_GetAllItemsForUseTax";
        public const string USP_P2P_INV_GETLINEITEMTAXESFORUSETAX = "usp_P2P_INV_GetLineItemTaxesForUseTax";
        public const string USP_P2P_INV_GETINVSPLITSQTYFORUSETAX = "usp_P2P_INV_GetInvSplitsQtyForUseTax";
        public const string USP_P2P_INV_UPDATEUSETAX = "usp_P2P_INV_UpdateUseTax";

        public const string USP_P2P_INV_FLIP_ACCOUNTING_SPLIT_FROM_PO_TO_INVOICE =
            "usp_P2P_INV_FlipAccountingSplitFromPOToInvoice";

        public const string USP_P2P_INV_FLIP_ACCOUNTING_SPLIT_FROM_SC_TO_INVOICE =
            "usp_P2P_INV_FlipAccountingSplitFromServiceConfirmationToInvoice";

        public const string USP_P2P_INV_UPDATESPLITACCOUNTINGDETAILS = "usp_P2P_INV_UpdateSplitAccountingDetails";
        public const string USP_P2P_INV_UPDATEORDERINVOICEMAPPING = "usp_P2P_INV_UpdateOrderInvoiceMapping";
        public const string USP_P2P_INV_SAVEINVOICEITEMOTHER = "usp_P2P_INV_SaveInvoiceItemOther";
        public const string USP_P2P_INV_PRORATESHIPPINGANDFREIGHT = "usp_P2P_INV_ProrateShippingAndFreight";
        public const string USP_P2P_INV_SAVEACCRUEDTAXDETAILS = "usp_P2P_INV_SaveAccruedTaxDetails";
        public const string USP_P2P_INV_GETINVOICESFORINTERFACE = "usp_P2P_INV_GetInvoicesForInterface";
        public const string USP_P2P_INV_GETINVOICEFORNOTIFICATION = "usp_P2P_INV_GetInvoiceForNotification";

        public const string USP_P2P_INV_GETTIMESHEETDETAILSFORINVOICENOTIFICATION =
            "Usp_p2p_INV_GetTimesheetDetailsForInvoiceNotification";

        public const string USP_P2P_INV_SAVEINVOICEDEFAULTACCOUNTING = "usp_P2P_INV_SaveInvoiceDefaultAccounting";
        public const string USP_P2P_INV_GETVALIDATIONERRORCODEBYID = "usp_P2P_INV_GetValidationErrorCodeById";
        public const string USP_P2P_INV_PRORATEHEADERTAXANDSHIPPING = "usp_P2P_INV_ProrateHeaderTaxAndShipping";
        public const string USP_P2P_INV_VALIDATEINTERFACEREMITTANCEDTLS = "usp_P2P_INV_ValidateInterfaceRemittanceDtls";
        public const string USP_P2P_INV_SAVEINVOICEACCOUNTINGAPPLYTOALL = "usp_P2P_INV_SaveInvoiceAccountingApplyToAll";
        public const string USP_P2P_INV_GETALLITEMIDSBYINVOICEID = "usp_P2P_INV_GetAllItemIdsByInvoiceId";

        public const string USP_P2P_INV_GETINVOICEDETAILSFOREXPORTPDFBYID =
            "usp_P2P_Invoice_GetInvoiceDetailsForExportPDFById";

        public const string USP_P2P_INV_DELETELINEITEMSBYDOCUMENTCODE = "usp_P2P_INV_DeleteLineItemsByDocumentCode";
        public const string USP_P2P_INV_UPDATEBILLTOLOCATION = "usp_P2P_INV_UpdateBillToLocation";
        public const string USP_P2P_INV_PRORATETAX = "usp_P2P_INV_ProrateTax";
        public const string USP_P2P_INV_GETALLINVOICEDETAILSBYINVOICEID = "usp_P2P_INV_GetAllInvoiceDetailsByInvoiceId";
        public const string USP_P2P_IR_GETALLIRDETAILSBYIRID = "usp_P2P_IR_GetAllIRDetailsByIRId";
        public const string USP_P2P_INV_DELETELINEITEMSBYORGENTITYCODE = "usp_P2P_INV_DeleteLineItemsByOrgEntityCode";
        public const string USP_P2P_INV_SAVEACCOUNTINGFROMPO = "usp_P2P_INV_SaveAccountingFromPO";
        public const string USP_P2P_INV_DELETELINEITEMSONBUCHANGE = "usp_P2P_INV_DeleteLineItemsOnBUChange";
        public const string USP_P2P_INV_UPDATEINVOICEITEMCHECKEDSTATUS = "usp_P2P_INV_UpdateInvoiceItemCheckedStatus";
        public const string USP_P2P_INV_DELETEUNCHECKEDINVOICEITEMS = "usp_P2P_INV_DeleteUnCheckedInvoiceItems";
        public const string USP_P2P_INV_VALIDATEINVOICEPAYMENTUPDATE = "usp_P2P_INV_ValidateInvoicePaymentUpdate";
        public const string USP_P2P_INV_VALIDATEINTERFACEDOCUMENT = "usp_P2P_INV_ValidateInterfaceDocument";

        public const string USP_P2P_INV_VALIDATESUPPLIERINTERFACEDOCUMENT =
            "usp_P2P_INV_ValidateSupplierInterfaceDocument";

        public const string USP_P2P_INV_VALIDATEBUYERINTERFACEDOCUMENT = "usp_P2P_INV_ValidateBuyerInterfaceDocument";

        public const string USP_P2P_INV_UPDATEORGENTITIESFROMCATALOGBYITEMID =
            "usp_P2P_INV_UpdateOrgEntitiesFromCatalogByItemId";

        public const string USP_P2P_INV_GETINVOICECAPITALCODECOUNTBYID = "usp_P2P_INV_GetInvoiceCapitalCodeCountById";
        public const string USP_P2P_INV_PRORATEHEADERUSETAX = "usp_P2P_INV_ProrateHeaderUseTax";

        public const string USP_P2P_INV_GETINVDETAILSBYPARTNERINVNOANDLOCCODE =
            "usp_P2P_INV_GetInvDetailsByPartnerInvNoAndLocCode";

        public const string USP_P2P_INV_UPDATEIRDETAILSBYINVOICEID = "UpdateIRDetailsByInvoiceId";
        public const string USP_P2P_INV_GETCONTRACTUTILIZATIONBYID = "usp_P2P_INV_GetContractUtilizationbyId";
        public const string USP_P2P_INV_SAVEEXCEPTIONFOROVERRIDE = "usp_P2P_INV_SaveExceptionForOverride";
        public const string USP_P2P_INV_GETOVERRIDEEXCEPTION = "USP_P2P_INV_GetOverrideException";
        public const string USP_P2P_INV_GETALLOVERRIDEEXCEPTION = "USP_P2P_INV_GetALLOverrideException";
        public const string USP_P2P_INV_GETALLMATCHINGSTATUS = "usp_P2P_INV_GetAllMatchingStatus";
        public const string USP_P2P_INV_GETALLERRORSTATUS = "usp_P2P_INV_GetAllErrorStatus";
        public const string USP_P2P_INV_SAVEINVOICEERRORDETAILS = "usp_P2P_INV_SaveInvoiceErrorDetails";
        public const string USP_P2P_INV_UPDATEPROCEEDFORPAYMENT = "usp_P2P_INV_UpdateProceedForPayment";

        public const string USP_P2P_INV_VALIDATEERRORCODEBUYERINTERFACEDOCUMENT =
            "usp_P2P_INV_ValidateErrorCodeBuyerInterfaceDocument";

        public const string USP_PRN_GETACTIVECONTACTCODEBYCLIENTCONTACTCODEFORINTERFACE =
            "usp_PRN_GetActiveContactCodeByClientContactCodeForInterface";

        public const string UPS_P2P_INV_UPDATEPROCEEDFORPAYMENTINBULK = "usp_P2P_INV_UpdateProceedForPaymentInBulk";

        public const string USP_P2P_INV_VALIDATEPARTNERINVOICENUMBERBYORDER =
            "usp_P2P_INV_ValidatePartnerInvoiceNumberByOrder";

        public const string USP_P2P_INV_GETINVOICERESPONSEDETAILS = "usp_P2P_INV_GetInvoiceResponseDetails";
        public const string USP_P2P_INV_GETALLERRORSBYINVOICEID = "usp_P2P_INV_GetAllErrorsByInvoiceId";
        public const string USP_P2P_INV_SAVEITEMEXCEPTIONFOROVERRIDE = "usp_P2P_INV_SaveItemExceptionForOverride";
        public const string USP_P2P_INV_SAVEITEMEXCEPTIONSFOROVERRIDE = "usp_P2P_INV_SaveItemExceptionsForOverride";
        public const string USP_P2P_INV_SAVEEXCEPTIONSFOROVERRIDE = "usp_P2P_INV_SaveExceptionsForOverride";

        public const string USP_P2P_INV_GETPAYMENTREQUESTDETAILSFORNOTIFICATION =
            "usp_P2P_PR_GetPaymentRequestDetailsForNotification";

        public const string USP_P2P_INV_FLIP_ACCOUNTING_SPLIT_FROM_PR_TO_INVOICE =
            "usp_P2P_INV_FlipAccountingSplitFromPRToInvoice";

        public const string USP_P2P_INV_SAVEINVOICEUPLOADINFO = "usp_P2P_INV_SaveInvoiceUploadInfo";
        public const string USP_P2P_INV_GETINVOICEUPLOADINFO = "usp_P2P_INV_GetInvoiceUploadInfo";
        public const string USP_P2P_INV_UPDATETAXONHEADERSHIPTO = "usp_P2P_INV_UpdateTaxOnHeaderShipTo";
        public const string USP_P2P_INV_PRORATELINEITEMTAX = "usp_P2P_INV_ProrateLineItemTax";
        public const string USP_P2P_INV_UPDATELINEITEMTAX = "usp_P2P_INV_UpdateLineItemTax";

        public const string USP_P2P_INV_GETLINEITEMTAXDETAILS_FORLISTOFDOCUMENTITEMIDS =
            "usp_P2P_INV_GetLineItemTaxDetails_ForListOfDocumentItemIds";

        public const string USP_P2P_INV_GETTAXDETAILFORLINEITEM = "usp_P2P_INV_GetTaxDetailForLineItem";

        public const string USP_P2P_INV_EXPORTINVOICETOEXCEL = "usp_P2P_INV_ExportInvoiceToExcel";
        public const string USP_P2P_INV_EXPORTINVOICEITEMSTOEXCEL = "usp_P2P_INV_ExportInvoiceItemsToExcel";
        public const string USP_P2P_INV_GETINVOICEUPLOADRESULTINFO = "usp_P2P_INV_GetInvoiceUploadResultInfo";
        public const string USP_P2P_INV_GETINVOICEMASTERTEMPLATEINFO = "usp_P2P_INV_GetInvoiceMasterTemplateInfo";

        public const string USP_P2P_GETPROCESSEDINVOICEDETAILSFORINTERFACE =
            "usp_P2P_GetProcessedInvoiceDetailsForInterface";

        public const string USP_P2P_INV_GETMATCHSTATUSBYINVOICEID = "usp_P2P_INV_GetMatchStatusByInvoiceId";
        public const string USP_P2P_INV_GETORDERITEMSFORMAPPING = "usp_P2P_INV_GetOrderItemsForMapping";
        public const string USP_P2P_INV_UPDATECANCELINVOICEDETAILS = "usp_P2P_INV_UpdateCancelInvoiceDetails";
        public const string USP_P2P_INV_UPDATELINETYPEBYPURCHASETYPE = "usp_P2P_INV_UpdateLineTypeByPurchaseType";
        public const string USP_P2P_INV_SAVEINVOICEITEMFROMSUPPLIER = "usp_P2P_INV_SaveInvoiceItemfromsupplier";

        public const string USP_P2P_INV_VALIDATEORDEREXISTSSTANDARDINVOICE =
            "usp_P2P_INV_ValidateOrderExistsStandardInvoice";

        public const string USP_P2P_INV_SAVEAINVOICEDVANCEITEM = "usp_P2P_INV_SaveInvoiceAdvanceItem";
        public const string USP_P2P_INV_GETINVOICEHEADERTAXES = "usp_P2P_INV_GetInvoiceHeaderTaxes";
        public const string USP_P2P_INV_UPDATEINVOICEHEADERTAXES = "USP_P2P_INV_UPDATEINVOICEHEADERTAXES";
        public const string USP_P2P_INV_GETINVOICETAXMASTERINFO = "usp_P2P_INV_GetInvoiceTaxMasterInfo";
        public const string USP_P2P_INV_SAVEINVOICEACCOUNTINGDETAILSV2 = "usp_P2P_INV_SaveInvoiceAccountingDetailsV2";
        public const string USP_P2P_INV_SAVEREVIEWERASSTAKEHOLDER = "usp_P2P_INV_SaveReviewerAsStakeholder";
        public const string USP_P2P_INVV2_SAVEINVOICEITEM = "usp_P2P_INVV2_SaveInvoiceItem";
        public const string USP_P2P_INV_GetInvoiceV2EntityDetailsById = "usp_P2P_INV_GetInvoiceV2EntityDetailsById";

        public const string USP_P2P_INVOICE_GETALLCHANGEINVOICEBYINVOICE =
            "usp_P2P_invoice_GetAllChangeInvoiceByInvoice";

        public const string USP_P2P_INVOICE_GETINVOICEHEADERDETAILBYID = "usp_P2P_Invoice_GetInvoiceHeaderDetailById";
        public const string usp_P2P_INV_UPDATEINVOICEITEMSHIPPINGDETAILS = "usp_P2P_INV_UpdateInvoiceItemShippingDetails";

        public const string USP_P2P_INV_GETALLINVOICEDETAILSBYINVOICEIDFORVIEWCHANGES =
            "usp_P2P_INV_GetAllInvoiceDetailsByInvoiceIdForViewChanges";

        public const string USP_P2P_INV_GETINVOICEITEMSCHANGED = "usp_P2P_INV_GetInvoiceItemsChanged";
        public const string USP_P2P_IR_SAVEIRITEMOTHER_V2 = "usp_P2P_IR_SaveIRItemOtherV2";
        public const string USP_P2P_INV_SAVEINVOICEACCOUNTING = "usp_P2P_INV_SaveInvoiceAccounting";
        public const string USP_P2P_INV_VALIDATEINTERFACEUPDATEDOCUMENT = "usp_P2P_INV_ValidateInterfaceUpdateDocument";
        public const string USP_PRN_GETPARTNERIDENTIFICATIONDETAILS = "usp_PRN_GetPartnerIdentificationDetails";
        public const string USP_P2P_INV_SAVEEXCELUPLOADLOG = "usp_P2P_INV_SaveExcelUploadLog";
        public const string USP_P2P_INV_UPDATEERPINVOICENUMBER = "usp_P2P_INV_UpdateERPInvoiceNumber";

        public const string USP_P2P_INV_GETALLTIMESHEETSASSOCIATEDWITHINVOICE =
            "usp_P2P_INV_GetAllTimesheetsAssociatedWithInvoice";

        public const string USP_P2P_INV_SAVEINVOICEFROMSOURCEDOCUMENT = "usp_P2P_INV_SaveInvoiceFromSourceDocument";

        public const string USP_P2P_INV_SAVEINVOICEITEMFROMSOURCEDOCUMENT =
            "usp_P2P_INV_SaveInvoiceItemsFromSourceDocument";

        public const string USP_P2P_INV_SAVEINVOICEITEMFROMSERVICECONFIRMATIONDOCUMENT =
            "usp_P2P_INV_SaveInvoiceItemsFromServiceConfirmationDocument";

        public const string USP_P2P_INV_SAVEFULFILMENTDOCUMENTINVOICEMAPPING =
            "usp_P2P_INV_SaveFulfilmentDocumentInvoiceMapping";

        public const string USP_P2P_INV_GETUSERMAPPEDENTITIES = "usp_P2P_INV_GetUserMappedEntities";

        public const string USP_P2P_INV_GETALLUNINVOICEDFULFILMENTDOCUMENTCODESBYORDERID =
            "usp_P2P_INV_GetAllUnInvoicedFulfilmentDocumentCodesByOrderId";

        public const string USP_P2P_INV_CHECKINVOICEDFULFILLMENTDOCMENTS =
            "usp_P2P_INV_CheckInvoicedFulfillmentDocuments";

        public const string USP_P2P_INV_UPDATESCHEDULEDPAYMENTDATE = "usp_P2P_INV_UpdateScheduledPaymentDate";

        public const string USP_P2P_INV_GETALLFULFILMENTDOCUMENTIDSBYINVOICEID =
            "usp_P2P_INV_GetFulfilmentDocumentsByInvoiceId";

        public const string USP_P2P_INV_INSERTUPDATELINEITEMEXTERNALTAXES =
            "usp_P2P_INV_InsertUpdateLineItemExternalTaxes";

        public const string USP_P2P_INV_INSERTUPDATEEXTERNALRESPONSE = "usp_P2P_SaveExternalResponse";
        public const string USP_P2P_INV_INSERTUPDATEEXTERNALERRORS = "usp_P2P_INV_SaveExternalResponseErrors";
        public const string USP_P2P_INV_GETINVOICEITEMIDSBYINVOICEID = "usp_P2P_INV_GetInvoiceItemIdsByInvoiceId";

        public const string USP_P2P_INV_SAVEINVOICEFULFILMENTDOCUMENTINVOICEITEMMAPPING =
            "usp_P2P_INV_SaveFulfilmentDocumentInvoiceItemMapping";

        public const string usp_P2P_INV_GETINVOICEHEADERDETAILS = "usp_P2P_INV_GetInvoiceHeaderDetails";
        public const string USP_P2P_INV_UPDATEINVOICETOTALAMOUNT = "usp_P2P_INV_UpdateInvoiceTotalAmount";

        public const string USP_P2P_INV_UPDATELINEITEMTAXWITHEXTERNALTAX =
            "usp_P2P_INV_UpdateLineItemTaxWithExternalTax";

        public const string USP_P2P_INV_GETALLEXTERNALERRORDETAILS = "USP_P2P_GetAllExternalRequestErrorDetails";

        public const string USP_P2P_INV_GETEXTERNALERRORSFORNOTIFICATION =
            "usp_P2P_INV_GetExternalErrorsForNotification";

        public const string USP_P2P_INV_SAVECUSTOMFIELDS = "usp_P2P_INV_SaveCustomFields";
        public const string USP_P2P_INV_GETCUSTOMFIELDS = "usp_P2P_INV_GetCustomFields";
        public const string USP_P2P_INV_GETINVOICEBASICHEADERDETAILS = "usp_P2P_INV_GetInvoiceBasicHeaderDetails";
        public const string USP_P2P_INV_GETINVOICECUSTOMCOLUMNS = "usp_P2P_INV_GetInvoiceCustomColumns";
        public const string usp_P2P_INV_SAVEBULKADDITIONALDETAIL = "usp_P2P_INV_SaveBulkAdditionalDetail";
        public const string USP_P2P_INV_GETACTIVEEVENTCODES = "usp_P2P_INV_GetActiveEventCodes";
        public const string USP_P2P_INV_GETINVOICEDOCUMENTSTATUS = "usp_P2P_INV_GetInvoiceDocumentStatus";
        public const string USP_P2P_INV_VALIDATEINVOICEPAYMENTREQUESTMAPPING = "usp_P2P_INV_ValidateInvoicePaymentRequestMapping";
        public const string USP_INT_FLIP_ACCOUNTING_SPLIT_FROM_PO_TO_INVOICE = "usp_INT_FlipAccountingSplitFromPOToInvoice";
        public const string USP_P2P_INV_GETINVOICEFULFILMENTDOCUMENTTYPE = "usp_P2P_INV_GetInvoiceFulfilmentDocumentType";
        public const string USP_P2P_INV_SAVEINVOICEACCOUNTINGAUDITS = "usp_P2P_INV_SaveInvoiceAccountingAudits";
        public const string USP_P2P_INV_GETINVOICEACCOUNTINGAUDIT = "usp_P2P_INV_GetInvoiceAccountingAudit";
        public const string USP_P2P_INV_GETINVOICEIDBYIMAGEID = "usp_P2P_INV_GetInvoiceIdByImageId";
        public const string USP_P2P_INV_DELETEINVOICELINESBYINVOICEITEMID = "usp_P2P_INV_DeleteInvoiceLinesByInvoiceItemId";
        public const string USP_P2P_INV_UPDATEINVOICESUBMITTEDDATEANDPOCONSUMPTIONDATE = "usp_P2P_INV_UpdateInvoiceSubmittedDateAndPOConsumptionDate";
        public const string USP_P2P_INV_UPDATEOCRLINEDETAILS = "usp_P2P_INV_UpdateOCRLineDetails";

        #endregion Invoice StoredProcedures

        #region Invoice Types

        public const string TVP_P2P_INVOICEITEMS = "tvp_P2P_InvoiceItems";
        public const string TVP_P2P_INVOICEITEMTAXES = "tvp_P2P_InvoiceItemTaxes";
        public const string TVP_P2P_INV_ERRORDETAILS = "tvp_P2P_INV_ErrorDetails";
        public const string TVP_P2P_INV_MATCHLIST = "tvp_P2P_INV_MatchList";
        public const string TVP_P2P_INV_DETAILS = "tvp_P2P_Inv_Details";
        public const string TVP_P2P_INV_INVOICEITEMS = "tvp_P2P_INV_InvoiceItems";
        public const string tvp_P2P_INV_ORDERIDLIST = "tvp_P2P_INV_OrderIdList";
        public const string TVP_P2P_INVOICEITEMSHIPPINGDETAILS = "tvp_P2P_INV_ItemShippingDetails";
        public const string TVP_P2P_IR_ITEMOTHERDETAILS = "tvp_P2P_IR_ItemOtherDetails";
        public const string TVP_P2P_ExceptionOverrides = "tvp_P2P_ExceptionOverrides";
        public const string TVP_P2P_INVOICEITEMEXTERNALTAXES = "tvp_P2P_InvoiceItemExternalTaxes";
        public const string TVP_P2P_INVOICEEXTERNALERRORS = "tvp_P2P_InvoiceExternalResponseError";
        public const string TVP_P2P_INVOICECUSTOMFIELDS = "tvp_P2P_InvoiceCustomFields";
        public const string TVP_P2P_INV_INVOICEITEMCHARGE = "tvp_P2P_INV_InvoiceItemCharge";
        public const string TVP_P2P_INV_OCRLINEDETAILS = "tvp_P2P_INV_OCRLineDetails";

        #endregion Invoice Types

        #endregion Invoice

        #region Invoice Reconciliation

        public const string USP_P2P_IR_CREATEIRFROMINVOICE = "usp_P2P_IR_CreateIRfromInvoice";
        public const string USP_P2P_IR_GENERATEDEFAULTIRNAME = "usp_P2P_IR_GenerateDefaultIRName";
        public const string USP_P2P_IR_GETIRBASICDETAILSBYID = "usp_P2P_IR_GetIRBasicDetailsById";
        public const string USP_P2P_IR_GETALLLINEITEMSBYID = "usp_P2P_IR_GetAllLineItemsById";
        public const string USP_P2P_IR_GETALLLINEITEMSFORLEFTPANEL = "usp_P2P_IR_GetAllLineItemsForLeftPanel";
        public const string USP_P2P_IR_SAVEITEMSTATUS = "usp_P2P_IR_SaveItemStatus";
        public const string USP_P2P_IR_CALCULATEIRSTATUS = "usp_P2P_IR_CalculateIRStatus";
        public const string USP_P2P_IR_GETIRINFOFORNOTIFICATION = "usp_P2P_IR_GetIRInfoForNotification";
        public const string USP_P2P_IR_GETIRDETAILSBYORDERID = "usp_P2P_IR_GetIRDetailsByOrderId";
        public const string USP_P2P_IR_GETPREVIOUSORDERDETAILSFORIR = "usp_P2P_IR_GetPreviousOrderDetailForIR";
        public const string USP_P2P_IR_UPDATECHANGEORDERITEM = "usp_P2P_IR_UpdateChangeOrderItem";
        public const string USP_P2P_IR_GETRECEIVERDETAILSOFITEM = "usp_P2P_IR_GetReceiverDetailsOfItem";
        public const string USP_P2P_IR_GETNEXTACTIONONIR = "usp_P2P_IR_GetNextActionOnIR";
        public const string USP_P2P_IR_SAVEIRORDERDETAILS = "usp_P2P_IR_SaveIROrderDetails";
        public const string USP_P2P_IR_GETIRLINEITEMTAXES = "usp_P2P_IR_GetIRLineItemTaxes";
        public const string USP_P2P_UPDATEINVOICEORDERMAPPING = "usp_P2P_UpdateInvoiceOrderMapping";
        public const string USP_P2P_IR_GETORDERITEMSFOREXCEPTIONPOPUP = "usp_P2P_IR_GetOrderItemsforExceptionPopup";
        public const string USP_P2P_IR_RESETPOINVOICEITEMMAPPING = "usp_P2P_IR_ResetPOInvoiceItemMapping";
        public const string USP_P2P_IR_APPROVALSUBTYPE = "usp_P2P_IR_ApprovalSubType";
        public const string USP_P2P_IR_GETREQUESTERFORIRAPPROVAL = "usp_P2P_IR_GetRequesterForIRApproval";
        public const string USP_P2P_IR_GETNEXTACCEPTORFORIRACCEPTANCE = "usp_P2P_IR_GetNextAcceptorForIRAcceptance";
        public const string USP_P2P_IR_GETCOUNTACCEPTANCECYCLEFORIR = "usp_P2P_IR_GetCountAcceptanceCycleForIR";
        public const string USP_P2P_IR_GETIRDETAILSFORIRAPPROVAL = "usp_P2P_IR_GetIRDetailsForApproval";
        public const string USP_P2P_IR_GETALLCATEGORIESBYIRID = "usp_P2P_IR_GetAllCategoriesByIRId";
        public const string USP_P2P_IR_GETIRENTITIES = "usp_P2P_IR_GetIREntities";
        public const string USP_P2P_IR_UPDATE_IR_ACCOUNTING_WITH_PO = "usp_P2P_IR_UpdateIRAccountingWithPO";
        public const string USP_P2P_IR_GETIRENTITYDETAILSBYID = "usp_P2P_IR_GetIREntityDetailsById";
        public const string USP_P2P_IR_GETIRDETAILSFOREXPORTPDFBYID = "usp_P2P_IR_GetIRDetailsForExportPDFById";
        public const string USP_P2P_IR_GETIRDETAILSFORNOTIFICATION = "usp_P2P_IR_GetIRDetailsForNotification";
        public const string USP_P2P_IR_GETVALIDATIONERRORCODEBYID = "usp_P2P_IR_GetValidationErrorCodeById";
        public const string USP_P2P_IR_SAVEIRBASICDETAILS = "usp_P2P_IR_SaveIRBasicDetails";
        public const string USP_P2P_IR_GETIRTYPES = "usp_P2P_IR_GetIRTypes";
        public const string USP_P2P_IR_SAVEIRACCOUNTINGAPPLYTOALL = "usp_P2P_IR_SaveIRAccountingApplyToAll";
        public const string USP_P2P_IR_GETALLITEMIDSBYIRID = "usp_P2P_IR_GetAllItemIdsByIRId";
        public const string USP_P2P_IR_DELETEIRBYDOCUMENTID = "usp_P2P_IR_DeleteIRbyDocumentId";

        public const string USP_DM_REMOVEDOCUMENTBUBYCONTACTCODESDOCUMENTCODE =
            "usp_DM_RemoveDocumentBUByContactCodesDocumentCode";

        public const string USP_P2P_IR_SAVEACCEPTANCELOG = "usp_P2P_IR_SaveAcceptanceLog";
        public const string USP_P2P_IR_UPDATEACCEPTANCELOG = "usp_P2P_IR_UpdateAcceptanceLog";
        public const string USP_P2P_IR_COUNTREMAININGACCEPTANCEREQUIRED = "usp_P2P_IR_CountRemainingAcceptanceRequired";
        public const string USP_P2P_IR_UPDATEIRSUBTYPE = "usp_P2P_IR_UpdateIRSubType";
        public const string USP_P2P_IR_GETACCEPTORSLIST = "usp_P2P_IR_GetAcceptorsList";
        public const string USP_P2P_IR_GETACCEPTANCETRACKSTATUSDETAILS = "usp_P2P_IR_GetAcceptanceTrackStatusDetails";
        public const string USP_P2P_IR_GETREQUESTERFORDOCUMENT = "usp_P2P_IR_GetRequesterForDocument";
        public const string USP_P2P_IR_GETBUYERFORDOCUMENT = "usp_P2P_IR_GetBuyerForDocument";
        public const string USP_P2P_IR_GETIRSTATUS = "usp_P2P_IR_GetIRStatus";
        public const string USP_P2P_IR_GETHASCOMMENTS = "usp_P2P_IR_GetHasComments";
        public const string USP_P2P_IR_DISABLEIRACCEPTANCEORDER = "usp_P2P_IR_DisableIRAcceptanceOrder";
        public const string USP_P2P_IR_GETMATCHSTATUSBYIRID = "usp_P2P_IR_GetMatchStatusByIRId";
        public const string USP_P2P_IR_GETINVOICEIDBYIRID = "USP_P2P_IR_GetInvoiceIdByIRId";
        public const string USP_P2P_GETVAT = "USP_P2P_GETVAT";
        public const string USP_P2P_SaveAndGetVATForCreditMemo = "USP_P2P_SaveAndGetVATForCreditMemo";
        public const string usp_P2P_CM_GetstructureIdByCREDITMEMOId = "usp_P2P_CM_GetStructureIdByCreditMemoId";
        public const string USP_P2P_IR_GETALLDISPLAYDETAILS = "usp_P2P_IR_GetAllDisplayDetails";
        public const string USP_P2P_IR_COUNTACCEPTANCE = "usp_P2P_IR_CountAcceptance";
        public const string USP_P2P_IR_DISABLEACCEPTANCEINSTANCE = "usp_P2P_IR_DisableAcceptanceInstance";
        public const string USP_P2P_IR_GETMULTIREQUESTERFORDOCUMENT = "usp_P2P_IR_GetMultiRequesterForDocument";
        public const string USP_P2P_IR_GETMULTIRECEIVERFORDOCUMENT = "usp_P2P_IR_GetMultiReceiverForDocument";
        public const string USP_P2P_IR_GETMULTIBUYERFORDOCUMENT = "usp_P2P_IR_GetMultiBuyerForDocument";
        public const string USP_P2P_IR_MODIFYACCEPTORDETAILS = "usp_P2P_IR_ModifyAcceptorDetails";
        public const string USP_P2P_IR_MODIFYSTAKEHOLDERSTATUS = "usp_P2P_IR_ModifyStakeholderDetails";
        public const string USP_P2P_IR_GETSTAKEHOLDERTYPEINFO = "usp_P2P_IR_GetStakeholderTypeInfo";
        public const string USP_P2P_INV_REASSIGNRESOLVERFOREXCPETIONS = "USP_P2P_INV_ReassignResolverforExceptions";

        public const string USP_P2P_IR_UPDATEACCEPTANCELOGFORREASSIGNMENT =
            "usp_P2P_IR_UpdateAcceptanceLogForReassignment";

        public const string USP_P2P_IR_GETALLINVOICESPLITSBASEDONPROPERTY =
            "usp_P2P_IR_GetAllInvoiceSplitsBasedOnProperty";

        public const string USP_P2P_IR_RESETOVERRIDDENEXCEPTIONS = "usp_P2P_IR_ResetOverridenExceptions";
        public const string USP_P2P_IR_RESOLVEOVERRIDDENEXCEPTIONS = "usp_P2P_IR_ResolveOverriddenExceptions";
        public const string USP_P2P_IR_SAVEIRBULKADDITIONALDETAIL = "usp_P2P_IR_SaveIRBulkAdditionalDetail";
        public const string USP_P2P_IR_GETLISTIRID = "usp_P2P_IR_GetListIrId";
        public const string USP_P2P_IR_INSERTUPDATELINEITEMEXTERNALTAXES = "usp_P2P_IR_InsertUpdateLineItemExternalTaxes";
        public const string USP_IR_OVERRIDECALCULATEDTAXUSINGAPPLICALBETAX = "usp_IR_overrideCalculatedTaxUsingApplicalbeTax";
        public const string USP_IR_COPYINVOICEEXTERNALTAXTOIREXTERNALTAX = "usp_IR_CopyInvoiceExternalTaxToIRExternalTax";
        public const string USP_P2P_IR_GETSTAKEHOLDERATTRIBUTES = "usp_P2P_IR_GetStakeHolderAttributes";
        public const string USP_P2P_IR_SAVEIRAUDIT = "usp_P2P_IR_SaveIRAudit";
        public const string USP_P2P_IR_GETIRAUDIT = "usp_P2P_IR_GetIRAudit";
        public const string usp_P2P_IR_CLEARIREXTERNALTAXES = "usp_P2P_IR_ClearIRExternalTaxes";
        public const string USP_P2P_IR_GETINVOICEITEMEXTERNALTAXES = "usp_P2P_IR_GetInvoiceItemExternalTaxes";
        public const string USP_P2P_IR_GETCHANGEORDERUPDATEDLINES = "usp_P2P_IR_GetChangeOrderUpdatedLines";

        #endregion Invoice Reconciliation

        #region IR Reminder Notificaitons

        public const string USP_P2P_IR_GETIRDETAILSFORACCEPTANCEREMINDERNOTIFICATION = "usp_P2P_IR_GetIRDetailsForAcceptanceReminderNotification";
        public const string NOTN_ACCEPTANCESTATUS = "AcceptanceStatus";

        #endregion IR Reminder Notificaitons

        #region "Exception Routing"

        public const string USP_P2P_IR_GETENTITYOWNERSFORIRACCEPTANCE = "usp_P2P_IR_GetEntityOwnersForIRAcceptance";
        public const string USP_P2P_IR_GETCONTACTCODES_BY_ORGENTITYCODE = "usp_P2P_IR_GetContactCodesByOrgEntityCode";

        #endregion "Exception Routing"

        #region IR Columns

        public const string COL_IRDOCUMENT_ID = "DocumentId";
        public const string COL_IRDOCUMENT_NAME = "IRDocumentName";
        public const string COL_IRDOCUMENT_NUMBER = "IRDocumentNumber";
        public const string COL_ADDRESS1BILL = "AddressLine1Bill";
        public const string COL_ADDRESS2BILL = "AddressLine2Bill";
        public const string COL_ADDRESS3BILL = "AddressLine3Bill";
        public const string COL_CITYBILL = "CityBill";
        public const string COL_STATEBILL = "StateBill";
        public const string COL_ZIPBILL = "ZipBill";
        public const string COL_STAKEHOLDER_NAME = "StakeHolderName";
        public const string COL_STAKEHOLDER_TYPE = "StakeHolderType";
        public const string COL_IRENTITYID = "IREntityId";

        public const string COL_PARTNERCOMPANY_NAME = "PartnerCompanyName";
        public const string COL_IRAMOUNT = "IRamount";
        public const string COL_ORDERCONTACTEMAILID = "OrderContactEmailId";
        public const string COL_IRCONTACTEMAILID = "IRContactEmailId";
        public const string COL_IRCONTACTNAME = "IRContactName";
        public const string COL_IRCONTACTCODE = "IRContactCode";
        public const string COL_AUTOACKNOWLEDGED_BY_PARTNER = "AutoAcknowledgedByPartner";
        public const string COL_ACTIONPERFORMED = "ActionPerformed";
        public const string COL_ACCEPTANCELOGID = "AcceptanceLogId";
        public const string COL_ACTIONERID = "ActionerId";
        public const string COL_PROXYACTIONERID = "ProxyActionerId";
        public const string COL_PROXYACTIONERNAME = "ProxyActionerName";
        public const string COL_NAME = "Name";
        public const string COL_DESIGNATION = "Designation";
        public const string COL_STATUS = "Status";
        public const string COL_PREVIOUS_RESOLVER_TYPE = "PreviousResolverType";
        public const string COL_CURRENTACTIONPERFORMEDONEXCEPTION = "CurrentActionPerformedOnException";
        public const string COL_ContactType = "ContactType";

        #endregion IR Columns

        #region Matching

        #region Match Columns

        public const string COL_DOCUMENT_ID = "DocumentId";
        public const string COL_PARTNER_STATUS = "PartnerStatus";
        public const string COL_ITEM_ID = "ItemId";
        public const string COL_ITEMVALUE = "ItemValue";
        public const string COL_DOCUMENTTYPE_CODE = "DocumentTypeCode";
        public const string COL_TITLE = "Title";
        public const string COL_ORDER_VALUE = "OrderValue";
        public const string COL_INVOICE_VALUE = "InvoiceValue";
        public const string COL_ACCEPTED_VALUE = "AcceptedValue";
        public const string COL_RECEIVED_VALUE = "ReceivedValue";
        public const string COL_TOTAL_INVOICE_VALUE = "TotalInvoiceValue";
        public const string COL_MATCH_STATUS_ID = "MatchStatusId";
        public const string COL_ALLOWSTATUSUPDATE = "AllowStatusUpdate";
        public const string COL_MATCH_MATCHINGDISPLAYNAME = "DisplayName";
        public const string COL_ORIGINALQUANTITY = "OriginalQuantity";
        public const string COL_MATCH_STATUS_IDS = "MatchStatusIds";
        public const string COL_MATCH_STATUS_DISPLAYNAMES = "MatchStatusDisplayNames";
        public const string COL_ORDERLINENUMBER = "OrderLineNumber";
        public const string COL_CREDITAMOUNT = "CreditAmount";
        public const string COL_MATCHED_TAX = "MatchedTax";
        public const string COL_MATCHED_SHIPPING = "MatchedShipping";
        public const string COL_MATCHED_CHARGES = "MatchedCharges";
        public const string COL_MATCHED_ITEM_TOTAL = "MatchedItemTotal";
        public const string COL_MATCHED_TOTAL_AMOUNT = "MatchedTotalAmount";
        public const string COL_MATCHED_ADVANCE_TOTAL = "MatchedAdvanceTotal";
        public const string COL_MATCHED_QUANTITY = "MatchedQuantity";
        public const string COL_MATCHED_AMOUNT = "MatchedAmount";
        public const string COL_MATCHED_ADDITIONAL_CHARGES = "MatchedAdditionalCharges";
        public const string COL_MATCHED_ITEM_VALUE = "MatchedItemValue";
        public const string COL_MATCHED_ADJUSTMENT_TOTAL = "MatchedAdjustmentTotal";
        public const string COL_MATCHED_RECOUPMENT_RATE = "MatchedRecoupmentRate";

        #endregion Match Columns

        #region Match StoreProcedures

        public const string USP_P2P_INV_GETALLDOCUMENTFORMATCHING = "usp_P2P_INV_GetAllDocumentForMatching";
        public const string USP_P2P_INV_SENDBACKTOPARTNERDETAILS = "USP_P2P_INV_SendBacktoPartnerDetails";

        public const string USP_P2P_INV_GETALLDOCUMENTFORMATCHINGAGGREGATATION =
            "usp_P2P_INV_GetAllDocumentForMatchingWithAggregation";

        public const string USP_P2P_INV_GETALLITEMSFORMATCHINGAGGREGATATION =
            "usp_P2P_INV_GetAllItemsForMatchingWithAggregation";

        public const string USP_P2P_INV_GETALLITEMSFORMATCHING = "usp_P2P_INV_GetAllItemsForMatching";
        public const string USP_P2P_INV_SAVEITEMMATCHING = "usp_P2P_INV_SaveItemMatching";
        public const string USP_P2P_INV_SAVEDOCUMENTMATCHING = "usp_P2P_INV_SaveDocumentMatching";
        public const string USP_P2P_INV_GET_EXCEPTION_DETAILS_BY_CODE = "usp_P2P_INV_getExceptionDetailsByCode";
        public const string USP_P2P_INV_GETLASTINVOICEID = "usp_P2P_INV_GetLastInvoiceId";
        public const string USP_P2P_INV_GETALLORDERFORMATCHING = "usp_P2P_INV_GetAllOrderForMatching";

        public const string USP_P2P_GETDOCUMENTSBYPARTNERCODEFORMATCHING =
            "usp_P2P_GetDocumentsByPartnerCodeForMatching";

        public const string USP_P2P_INV_GETALLCHARGELINESFORMATCHING = "usp_P2P_INV_GetAllChargeLinesForMatching";
        public const string USP_P2P_INV_SAVEINVOICEEXTENDEDITEMMATCHING = "usp_P2P_INV_SaveInvoiceExtendedItemMatching";

        public const string USP_P2P_INV_GETREMAININGEXCEPTIONSFORINVOICES =
            "usp_P2P_INV_GetRemainingExceptionsForInvoices";

        #endregion Match StoreProcedures

        #endregion Matching

        #region Receipt

        #region Receipt Columns

        public const string COL_RECEIPT_ID = "ReceiptId";
        public const string COL_RECEIPT_NAME = "RecepitName";
        public const string COL_RECEIPT_RECEIVED_QUANTITY = "ReceivedQuantity";
        public const string COL_RECEIPT_ACCEPTED_QUANTITY = "AcceptedQuantity";
        public const string COL_RECEIPT_ITEM_ID = "ReceiptItemId";
        public const string COL_RECEIPT_ACCEPTED_PREVIOUS_QUANTITY = "PreviouslyAcceptedQuantity";
        public const string COL_RECEIPT_ACCEPTED_PREVIOUS_AMOUNT = "PreviouslyAcceptedAmount";
        public const string COL_RECEIPT_ACCEPTED_LATER_QUANTITY = "AcceptedLaterQuantity";
        public const string COL_RECEIPT_POITEMQUANTITY = "POItemQuantity";
        public const string COL_RECEIPT_POITEMUNITPRICE = "POItemUnitPrice";
        public const string COL_RECEIVERID = "ReceiverId";
        public const string COL_RECEIVERNAME = "ReceiverName";
        public const string COL_RECEIVEREMAILID = "ReceiverEmailId";
        public const string COL_RECEIPT_STATUS = "ReceiptStatus";
        public const string COL_RECEIPT_RETURNED_PREVIOUS_QUANTITY = "PreviouslyReturnedQuantity";
        public const string COL_RECEIPT_RECEIVED_AMOUNT = "ReceivedAmount";
        public const string COL_RECEIPT_ITEM_NUMBER = "ReceiptItemNumber";

        public const string COL_ASSETTAGID = "AssetTagId";
        public const string COL_SERIALNUMBER = "SerialNumber";
        public const string COL_ASSETKEY = "AssetKey";
        public const string COL_ASSETLOCATIONID = "AssetLocationId";
        public const string COL_ASSETLOCATIONTYPE = "AssetLocationType";
        public const string COL_ASSETLOCATION = "AssetLocation";
        public const string COL_ASSETLOCATIONCODE = "AssetLocationCode";
        public const string COL_REMAININGQUANTITY = "RemainingQuantity";
        public const string COL_ASSETRETURN = "AssetReturn";
        public const string COL_ASSETTAGSCOUNT = "AssetTagsCount";
        public const string COL_RECEIVEDDATE = "ReceivedDate";
        public const string COL_CANCELLEDQUANTITY = "CancelledQuantity";

        public const string COL_ERRORCODE = "ErrorCode";
        public const string COL_ERRORCATEGORY = "ErrorCategory";
        public const string COL_ERRORCLIENTCODE = "ClientErrorCode";
        public const string COL_ERRORMESSAGE = "ErrorMessage";
        public const string COL_RECEIPT_ISRETURNNOTE = "IsReturnNote";
        public const string COL_RECEIPT_RETURNNOTETYPE = "ReturnNoteType";
        public const string COL_RECEIPT_PARTNERRMANUMBER = "PartnerRMANumber";
        public const string COL_RECEIPT_RETURNEDQUANTITY = "ReturnedQuantity";
        public const string COL_RECEIPT_ITEM_REASONFORRETURN = "ReasonForReturn";
        public const string COL_RECEIPT_ITEM_REASONID = "ReasonID";
        public const string COL_RECEIPT_RECEIPTNUMBER = "ReceiptNumber";
        public const string COL_RECEIPT_RECEIPTNAME = "ReceiptName";
        public const string COL_RECEIPT_RECEIPTSOURCE = "ReceiptSource";
        public const string COL_RECEIPT_HASRETURNNOTE = "HasReturnNote";

        public const string COL_RECEIPT_REASONID = "ReasonId";
        public const string COL_RECEIPT_REASONFORRETURN = "ReasonForReturn";
        public const string COL_RECEIPT_CONTACTNAME = "ReceiptContactName";
        public const string COL_RECEIPT_CONTACT_EMAIL = "ReceiptContactEmail";
        public const string COL_RECEIPT_CONTACTID = "ReceiptContactId";
        public const string COL_RECEIPT_ISINTERFACEUPDATE = "IsInterfaceUpdate";
        public const string COL_RECEIPT_ITEM_REASONFORRETURNCODE = "ReasonForReturnCode";
        public const string COL_RECEIPT_EXCESS_RECEIPT_ITEMIDS = "ExcessReceiptItemIds";
        public const string COL_RECEIPTITEMLINENUMBER = "ReceiptLineNumber";
        public const string COL_RETURN_NOTE_ID = "ReturnNoteId";
        public const string COL_DELIVERYNOTE = "Delivery Note";
        public const string COL_DOCUMENTDATE = "Document Date";

        #endregion Receipt Columns

        #region Receipt StoreProcedures

        public const string USP_P2P_REC_GETALLORDERFORRECEIPTLEFTPANEL = "usp_P2P_REC_GetAllOrderForReceiptLeftPanel";
        public const string USP_P2P_REC_GETALLREQUISITIONFORLEFTPANEL = "usp_P2P_REC_GetAllRequisitionForLeftPanel";
        public const string USP_P2P_REC_GETRECEIPTBASICDETAILSBYID = "usp_P2P_REC_GetReceiptBasicDetailsByID";

        public const string USP_P2P_REC_GETRECEIPTBASICDETAILSBYID_FOR_INTERFACE =
            "usp_P2P_REC_GetReceiptBasicDetailsByIDForInterface";

        public const string USP_P2P_REC_GETALLLINEITEMSBYID = "usp_P2P_REC_GetAllLineItemsById";

        public const string USP_P2P_REC_GETALLLINEITEMSBYID_FOR_INTERFACE =
            "usp_P2P_REC_GetAllLineItemsByIdForInterface";

        public const string USP_P2P_REC_CREATERECEIPTFROMORDER = "usp_P2P_REC_CreateReceiptFromOrder";
        public const string USP_P2P_REC_GENERATEDEFAULTRECEIPTNAME = "usp_P2P_REC_GenerateDefaultReceiptName";
        public const string USP_P2P_REC_SAVERECEIPT = "usp_P2P_REC_SaveReceipt";
        public const string USP_P2P_REC_SAVE_RECEIPT_ITEM = "usp_P2P_REC_SaveReceiptItem";
        public const string USP_P2P_REC_DELETELINEITEMBYID = "usp_P2P_REC_DeleteLineItemById";
        public const string USP_P2P_REC_VALIDATE_DOCUMENT_BY_CODE = "USP_P2P_REC_Validate_Document_By_Code";
        public const string USP_P2P_REC_CALCULATE_STATUS = "usp_P2P_REC_CalculateStatus";
        public const string USP_P2P_REC_UPDATEITEMSFROMIR = "usp_P2P_REC_UpdateItemsFromIR";
        public const string USP_P2P_REC_GETRECEIPTITEMSASSETTAGSBYRECID = "usp_P2P_REC_GetReceiptItemsAssetTagsByRecId";
        public const string USP_P2P_REC_VALIDATERECEIPTASSETTAGS = "USP_P2P_REC_ValidateReceiptAssetTags";
        public const string USP_P2P_REC_GETRECEIPTLINEITEMDEATILSBYID = "usp_P2P_REC_GetReceiptLineItemDeatilsById";
        public const string USP_P2P_REC_SAVERECEIPTITEMSASSETTAGS = "usp_P2P_REC_SaveReceiptItemsAssetTags";

        public const string USP_P2P_REC_DELETE_ALL_ASSETTAG_OF_RECEIPT_ITEM =
            "usp_P2P_REC_DeleteAllAssetTagOfReceiptItem";

        public const string USP_P2P_REC_GETDOCUMENTBASICDETAILSDOCUMENTNUMBER =
            "usp_P2P_REC_GetDocumentBasicDetailsDocumentnumber";

        public const string USP_P2P_REC_GETRECEIPTIDBYNUMBERANDSTATUS =
            "usp_P2P_REC_GetReceiptIdByReceiptNumberAndStatus";

        public const string USP_P2P_REC_UPDATEINTERFACESTATUS = "usp_P2P_REC_UpdateInterfaceStatus";
        public const string USP_P2P_REC_GETRECEIPTSFORINTERFACE = "usp_P2P_REC_GetReceiptsForInterface";
        public const string USP_P2P_REC_VALIDATEINTERFACEDOCUMENT = "usp_P2P_REC_ValidateInterfaceDocument";
        public const string USP_P2P_REC_GETALLITEMIDSBYRECEIPTID = "usp_P2P_REC_GetAllItemIdsByReceiptId";
        public const string USP_P2P_RET_CREATERETURNNOTEFROMRECEIPT = "usp_P2P_RET_CreateReturnNotefromReceipt";
        public const string USP_P2P_RET_GETRETURNNOTEADDITIONALDETAILS = "usp_P2P_GetReturnNoteAdditionalDetails";
        public const string USP_P2P_REC_UPDATEQUANTITY = "usp_P2P_REC_UpdateQuantity";
        public const string USP_P2P_RET_GETREASONFORRETURN = "usp_P2P_RET_GetReasonForReturn";
        public const string USP_P2P_REC_VALIDATEDOCUMENT = "usp_P2P_REC_ValidateDocument";
        public const string USP_P2P_REC_GETDETAILSFOREXPORTPDFBYID = "usp_P2P_REC_GetDetailsForExportPDFById";

        public const string USP_P2P_REC_GETALLDOCUMENTITEMSCHECKEDSTATUS =
            "usp_P2P_REC_GetAllDocumentItemsCheckedStatus";

        public const string USP_P2P_REC_GETALLLEFTPANELLINEITEMSBYID = "usp_P2P_REC_GetAllLeftPanelLineItemsById";
        public const string USP_P2P_PO_VALIDATERECEIPTCREATION = "usp_P2P_PO_ValidateReceiptCreation";
        public const string USP_P2P_REC_VALIDATEERTFORSELECTEDITEMS = "usp_P2P_REC_ValidateERTForSelectedItems";

        public const string USP_P2P_GETNOTIFICAITONDETAILSFOREXTERNALRECEIPTS =
            "usp_P2P_GetNotificaitonDetailsForExternalReceipts";

        public const string USP_P2P_RET_VALIDATEINTERFACEDOCUMENT = "usp_P2P_RET_ValidateInterfaceDocument";
        public const string USP_P2P_REC_ISRETURNNOTE = "usp_P2P_REC_IsReturnNote";

        public const string USP_P2P_REC_SAVEASSETORSERIALEXCELUPLOADREQUETDETAILS =
            "usp_P2P_REC_SaveAssetOrSerialExcelUploadInfo";

        public const string USP_P2P_REC_GETRECEIPTASSETORSERIALUPLOADINFO =
            "usp_P2P_REC_GetReceiptAssetOrSerialUploadInfo";

        public const string USP_P2P_REC_SAVEASSETORSERIALEXCELDETAILS = "usp_P2P_REC_SaveAssetOrSerialExcelDetails";

        public const string USP_P2P_REC_GETRECEIPTITEMSASSETTAGSBYRECIDFROMSTG =
            "usp_P2P_REC_GetReceiptItemsAssetTagsfromStg";

        public const string USP_P2P_REC_SAVEBULKRECEIPTASSETTAGSFORSTGTABLE =
            "usp_P2P_REC_SaveBulkReceiptItemsAssetTags_Staging";

        public const string USP_P2P_REC_SAVEBULKRECEIPTASSETTAGS = "usp_P2P_REC_SaveBulkReceiptItemsAssetTags";
        public const string USP_P2P_REC_GETITEMACCEPTEDQUANTITY = "usp_P2P_REC_GetItemAcceptedQuantity";

        public const string USP_P2P_REC_GETALLSHIPTOLOCATIONFORASSETTAGSBULKUPLOAD =
            "usp_P2P_REC_GetAllShipToLocationsForAssetTagsBulkUpload";

        public const string USP_P2P_REC_GETITEMDETAILSFORMASTERDATA = "usp_P2P_REC_GetItemDetailsForMasterData";

        #endregion Receipt StoreProcedures

        #region Receipts Items Asset Tags

        public const string TVP_P2P_REC_ASSETTAGS = "tvp_P2P_REC_AssetTags";
        public const string TVP_LOBENTTTYDETAILCODES = "tvp_LOBEntityDetailCodes";
        public const string TVP_P2P_REC_ASSETTAGSFORSTGTABLE = "tvp_P2P_REC_AssetTagsForStgTable";

        #endregion Receipts Items Asset Tags

        #region Return Note

        #region Return Note Stored Procedures

        public const string USP_P2P_RET_GETRETURNNOTEITEMSBYRETURNNOTEID =
            "usp_P2P_RET_GetReturnNoteItemsByReturnNoteId";

        public const string USP_P2P_RET_SAVERETURNNOTEITEMS = "usp_P2P_RET_SaveReturnNoteItems";
        public const string USP_P2P_RET_DELETEDOCUMENTBYDOCUMENTCODE = "usp_P2P_RET_DeleteDocumentByDocumentCode";
        public const string USP_P2P_REC_UPDATERECEIPTITEMCHECKEDSTATUS = "usp_P2P_REC_UpdateReceiptItemCheckedStatus";
        public const string USP_P2P_RET_UPDATERETURNNOTEITEMREASON = "usp_P2P_RET_UpdateReturnNoteItemReason";

        public const string USP_P2P_REC_GETRETURNNOTEDETAILSFORINTERFACE =
            "usp_P2P_REC_GetReturnNoteDetailsForInterface";

        #endregion Return Note Stored Procedures

        public const string TVP_P2P_RET_RETURNNOTEITEMS = "tvp_P2P_RET_ReturnNoteItems";
        public const string TVP_P2P_DOCUMENTITEMCHKSTATUS = "tvp_P2P_DocumentItemChkStatus";
        public const string TVP_P2P_RET_RETURNNOTEITEMSSTATUS = "tvp_P2P_RET_ReturnNoteItemsStatus";

        #endregion Return Note

        #endregion Receipt

        #region Split Accounting Fields

        #region Split Accounting Columns

        public const string COL_PARENTENTITYCODE = "ParentEntityCode";
        public const string COL_SPLITACCOUNTINGFIELD_CONFIGID = "SplitAccountingFieldConfigId";
        public const string COL_FIELD_NAME = "FieldName";
        public const string COL_FIELD_CONTROL_TYPE = "FieldControlType";
        public const string COL_FIELD_ORDER = "FieldOrder";
        public const string COL_PARENT_FIELD_CONFIG_ID = "ParentFieldConfigId";
        public const string COL_ISMANDATORY = "IsMandatory";
        public const string COL_ENTITY_TYPE_ID = "EntityTypeId";
        public const string COL_ERROR_CODE = "ErrorCode";
        public const string COL_CATALOG_ITEM_CONTROL_TYPE = "CatalogItemControlType";
        public const string COL_DATA_DISPLAY_STYLE = "DataDisplayStyle";
        public const string COL_AUTO_SUGGEST_URL_ID = "AutoSuggestURLId";
        public const string COL_IS_ACCOUNTING_ENTITY = "IsAccountingEntity";
        public const string COL_REQUISITION_SPLIT_ITEM_ID = "RequisitionSplitItemId";
        public const string COL_ORDER_SPLIT_ITEM_ID = "OrderSplitItemId";
        public const string COL_PAYMENTREQUEST_SPLIT_ITEM_ID = "PaymentRequestSplitItemId";
        public const string COL_STRUCTUREID = "StructureId";
        public const string COL_STRUCTURENAME = "StructureName";
        public const string COL_ORGMANAGERMAPPINGID = "OrgManagerMappingId";

        public const string COL_SPLIT_TYPE = "SplitType";
        public const string COL_SPLIT_ITEM_TOTAL = "SplitItemTotal";
        public const string COL_SPLIT_ACCOUNTING_FIELD_CONFIG_ID = "SplitAccountingFieldConfigId";
        public const string COL_SPLIT_ACCOUNTING_FIELD_VALUE = "SplitAccountingFieldValue";
        public const string COL_ENTITY_DISPLAY_NAME = "EntityDisplayName";
        public const string COL_ENTITY_DISPLAY_NAMES = "EntityDisplayNames";
        public const string COL_ENTITY_CODE = "EntityCode";
        public const string COL_ENTITY_ID = "EntityId";
        public const string COL_CODE_COMBINATION_ORDER = "CodeCombinationOrder";
        public const string COL_INVOICE_SPLIT_ITEM_ID = "InvoiceSplitItemId";
        public const string COL_ACCOUNTINGSTATUS = "AccountingStatus";
        public const string COL_SPLIT_ITEM_ERRORCODE = "ErrorCode";
        public const string COL_SPLIT_ITEM_DISPLAYNAME = "DisplayName";
        public const string COL_SPLIT_ITEM_PARENNTENTITYDETAILCODE = "ParentEntityDetailCode";
        public const string COL_SPLIT_ITEM_ENTITYDETAILCODE = "EntityDetailCode";
        public const string COL_LEVEL_TYPE = "LevelType";
        public const string COL_LEVELNO = "LevelNo";
        public const string COL_PARENT_ENTITY_TYPE = "ParentEntityType";
        public const string COL_MAPPING_TYPE = "MappingType";
        public const string COL_ENTITY_TYPE = "EntityType";
        public const string COL_TAB_ID = "TabIndexId";
        public const string COL_POPULATE_DEFAULT = "PopulateDefault";
        public const string COL_SIGNATORS_NAME = "SignatorsName";
        public const string COL_LOBENTITYDETAILCODE = "LOBEntityDetailCode";
        public const string COL_AEENTITYDETAILCODE = "AEEntityDetailCode";
        public const string COL_ORDERTOLERANCEDETAILS = "OrderToleranceDetails";
        public const string COL_UPDATED_BY = "UpdatedBy";
        public const string COL_SPLIT_UPDATED_ON = "UpdatedOn";
        public const string COL_SPLIT_UPDATED_VIA = "UpdatedVia";
        public const string COL_SPLIT_Number = "SplitNumber";
        public const string COL_PREFERENCE_LOB_TYPE = "PreferenceLOBType";

        #endregion Split Accounting Columns

        #region Derive Header entity

        public const string USP_P2P_GETSPLITACCOUNTINGFIELDSWITHDEFAULTVALUESFORINTERFACE =
            "usp_P2P_GetSplitAccountingFieldsWithDefaultValuesForInterface";

        public const string TVP_P2P_HEADERENTITYDETAILS = "tvp_P2P_HeaderEntityDetails";
        public const string COL_LOBENTITYCODE = "LOBEntityCode";

        #endregion Derive Header entity

        #region Requisition work bench Saved views

        public const string COL_REQ_SAVEDVIEW_ID = "SavedViewInfoId";
        public const string COL_REQ_SAVEDVIEW_NAME = "ViewName";
        public const string COL_REQ_SAVEDVIEW_COLUMNLIST = "ColumnList";
        public const string COL_REQ_SAVEDVIEW_FILTERS = "Filters";
        public const string COL_REQ_SAVEDVIEW_SORTCOLUMN = "SortColumn";
        public const string COL_REQ_SAVEDVIEW_SORTORDER = "SortOrder";
        public const string COL_REQ_SAVEDVIEW_GROUPCOLUMN = "GroupColumn";
        public const string COL_REQ_SAVEDVIEW_ISDEFAULTVIEW = "IsDefaultView";
        public const string COL_REQ_SAVEDVIEW_ISSYSTEMDEFAULT = "IsSystemDefault";

        #endregion Requisition work bench Saved views

        #region Split Accounting TableTypes

        public const string TVP_CHARGEITEMID = "tvp_ChargeItemId";
        public const string TVP_P2P_ORDERHEADERCHARGEITEM = "tvp_P2P_OrderHeaderChargeItem";
        public const string TVP_P2P_ORDERLINELEVELCHARGEITEM = "tvp_P2P_OrderLineLevelChargeItem";

        public const string TVP_P2P_REQUISITIONHEADERCHARGEITEM = "tvp_P2P_RequisitionHeaderChargeItem";
        public const string TVP_P2P_REQUISITIONLINELEVELCHARGEITEM = "tvp_P2P_RequisitionLineLevelChargeItem";

        public const string TVP_P2P_SPLITITEMS = "tvp_P2P_SplitItems";
        public const string TVP_P2P_SPLITITEMSENTITIES = "tvp_P2P_SplitItemsEntities";
        public const string TVP_P2P_INTERFACESPLITITEMS = "tvp_P2P_InterfaceSplitItems";
        public const string TVP_P2P_INTERFACESUBLINESSPLITITEMS = "tvp_P2P_InterfaceSublinesSplitItems";
        public const string TVP_P2P_INTERFACESUBLINESHEADERSPLITITEMS = "tvp_P2P_InterfaceSublinesHeaderSplitItems";
        public const string TVP_P2P_INVOICEHEADERCHARGEITEM = "tvp_P2P_InvoiceHeaderChargeItem";
        public const string TVP_P2P_INVOICELINELEVELCHARGEITEM = "tvp_P2P_InvoiceLineLevelChargeItem";
        public const string TVP_P2P_INVOICELINELEVELMATCHSTATUS = "tvp_P2P_InvoiceLineLevelMatchStatus";
        public const string TVP_P2P_DOCUMENTADDITIONALENTITY = "tvp_P2P_DocumentAdditionalEntity";
        public const string TVP_P2P_DOCUMENTCODE = "tvp_P2P_DocumentCode";
        public const string TVP_P2P_ENTITYDETAILCODES = "tvp_P2P_EntityDetailCodes";
        public const string TVP_P2P_ORDERITEMTAXES = "tvp_P2P_OrderItemTaxes";
        public const string TVP_P2P_CUSTOMATTRIBUTES = "tvp_P2P_CustomAttributes";
        public const string TVP_P2P_BLANKETITEMMAPPING = "tvp_P2P_BlanketItemMapping";
        public const string TVP_P2P_REQUISITIONITEMTAXES = "tvp_P2P_RequisitionItemTaxes";
        public const string TVP_P2P_PO_ExternalCodeCombination = "tvp_P2P_PO_ExternalCodeCombination";
        public const string TVP_P2P_PO_UpdateLineAccountingStatus = "tvp_P2P_PO_UpdateLineAccountingStatus";
        public const string USP_P2P_INV_GETSPLITDETAILS = "usp_P2P_INV_GetSplitDetails";
        public const string USP_P2P_INV_GETINVOICEDETAILBYDOCUMENTCODE = "usp_P2P_INV_GetInvoiceDetailByDocumentCode";

        #endregion Split Accounting TableTypes

        #region Split Accounting Stored Procedures

        public const string USP_P2P_GETALLSPLITACCOUNTINGFIELDCONFIGURATIONS =
            "usp_P2P_GetAllSplitAccountingFieldConfigurations";

        public const string USP_P2P_INV_GETINVOICEACCOUNTINGDETAILSBYITEMID =
            "usp_P2P_INV_GetInvoiceAccountingDetailsByItemId";

        public const string USP_P2P_REQ_CHECK_REQUISITION_ACCOUNTING_SPLIT_VALIDATIONS =
            "usp_P2P_REQ_CheckRequisitionAccountingSplitValidations";

        public const string USP_P2P_PO_CHECKACCOUNTINGSPLITVALIDATIONS = "USP_P2P_PO_CheckAccountingSplitValidations";
        public const string USP_P2P_GETALLSPLITACCOUNTINGDEFAULTVALUES = "usp_P2P_GetAllSplitAccountingDefaultValues";

        public const string USP_P2P_REQ_SAVEREQUISITION_DEFAULT_ACCOUNTINGDETAILS =
            "usp_P2P_REQ_SaveRequisitionDefaulAccounting";

        public const string USP_P2P_REQ_PRORATE_LINEITEM_TAX = "usp_P2P_REQ_ProrateLineItemTax";
        public const string USP_P2P_REQ_PRORATESHIPPINGANDFREIGHT = "usp_P2P_REQ_ProrateShippingAndFreight";
        public const string USP_P2P_PO_SAVEORDER_DEFAULT_ACCOUNTING = "usp_P2P_PO_SaveOrderDefaultAccounting";

        public const string USP_P2P_PR_SAVEPAYMENTREQUEST_DEFAULT_ACCOUNTING =
            "usp_P2P_PR_SavePaymentRequestDefaultAccounting";

        public const string USP_P2P_REQ_SAVE_REQ_ADVANCEDPAYMENT_DEFAULT_ACCOUNTINGDETAILS =
            "usp_P2P_REQ_SaveAdvancePaymentDefaulAccounting";

        public const string USP_P2P_REQ_SAVE_INV_ADVANCEDPAYMENT_DEFAULT_ACCOUNTINGDETAILS =
            "usp_P2P_INV_SaveAdvancePaymentDefaultAccounting";

        public const string USP_P2P_INV_GETALLSPLITACCOUNTINGCODESBYDOCUMENTTYPE =
            "USP_P2P_INV_GETALLSPLITACCOUNTINGCODESBYDOCUMENTTYPE";

        public const string USP_P2P_REQ_GETALLSPLITACCOUNTINGCODESBYDOCUMENTTYPE =
            "USP_P2P_REQ_GETALLSPLITACCOUNTINGCODESBYDOCUMENTTYPE";

        public const string USP_P2P_REQ_BULKCOPYREQUISITIONLINEITEMS = "usp_P2P_REQ_BulkCopyRequisitionLineItems";
        public const string USP_P2P_REQ_WEBBULKCOPYREQUISITIONLINEITEMS = "usp_P2P_REQ_WebBulkCopyRequisitionLineItems";

        public const string USP_P2P_REQ_DELETEREQUISITIONUPLOADSTAGINGDATA =
            "usp_P2P_REQ_DeleteRequisitionUploadStagingData";

        public const string USP_P2P_GETALLSPLITITEMIDSBYDOCUMENTCODE = "usp_P2P_GetAllSplitItemIDsByDocumentCode";

        public const string USP_P2P_INV_VALIDATEACCOUNTINGCODECOMBINATION =
            "usp_P2P_INV_ValidateAccountingCodeCombination";

        public const string USP_P2P_INV_VALIDATECODECOMBINATIONSUCCESSBYINVOICEID =
            "usp_P2P_INV_ValidateCodeCombinationSuccessByInvoiceId";

        #endregion Split Accounting Stored Procedures

        #endregion Split Accounting Fields

        #region My Task //Note : Need to remove once Localization is implemented

        public const string SENT_FOR_APPROVAl = "Send for Approval";
        public const string APPROVE = "Approve";
        public const string REJECT = "Reject";
        public const string FINALIZE = "Finalize";
        public const string SUBMIT_TO_BUYER = "Submit to Buyer";
        public const string ACKNOWLEDGE = "Acknowledge";
        public const string SUBMIT_TO_PARTNER = "Submit to Partner";
        public const string ACCEPT = "Accept";
        public const string OVERRIDE = "Override";
        public const string REASSIGNED = "Reassigned";
        public const string NOTIFY_SENT_BACK = "Sent Back";
        public const string NOTIFY_ACCEPTED = "Accepted";
        public const string NOTIFY_REJECTED = "Rejected";
        public const string OVERRIDDEN = "Overridden";

        #endregion My Task //Note : Need to remove once Localization is implemented

        #region ScannedImage

        #region ScannedImage Procedure

        public const string USP_P2P_SI_SAVESCANNEDIMAGEFILEMAPPING = "usp_P2P_SI_SaveScannedImageFileMapping";
        public const string USP_P2P_SI_GETALLSCANNEDINVOICEFILEID = "usp_P2P_SI_GetAllScannedInvoiceFileId";
        public const string USP_P2P_SI_GETINVOICESFORSCANNEDIMAGE = "usp_P2P_SI_GetInvoicesForScannedImage";
        public const string USP_P2P_SI_GETSCANNEDIMAGEADDITIONALDETAILS = "usp_P2P_SI_GetScannedImageAdditionalDetails";
        public const string USP_P2P_SI_UPDATESCANNEDIMAGEBYDOCUMENTCODE = "usp_P2P_SI_UpdateScannedImageByDocumentCode";
        public const string USP_P2P_SI_GETIMAGEBYFILEID = "usp_P2P_SI_GetImageByFileId";
        public const string USP_P2P_SI_GETIMAGEBYDOCUMENTCODE = "usp_P2P_SI_GetImageByDocumentCode";
        public const string USP_P2P_SI_MAPSCANNEDIMAGETOINVOICE = "usp_P2P_SI_MapScannedImageToinvoice";
        public const string USP_P2P_SI_UPDATESCANNEDIMAGEFORCREDITMEMO = "usp_P2P_SI_UpdateScannedImageForCreditMemo";
        public const string USP_P2P_SI_GETALLSCANNEDCREDITMEMOFILEID = "usp_P2P_SI_GetAllScannedCreditMemoFileId";

        #endregion ScannedImage Procedure

        #endregion ScannedImage

        #region Tax and Charges

        #region Tax Columns

        public const string COL_TAXID = "TaxId";
        public const string COL_TAX_DESC = "TaxDescription";
        public const string COL_TAX_TYPE = "TaxType";
        public const string COL_TAX_MODE = "TaxMode";
        public const string COL_TAX_VALUE = "TaxValue";
        public const string COL_TAX_CODE = "TaxCode";
        public const string COL_TAX_ISMANUAL = "IsManual";
        public const string COL_TAX_ISACCRUETAX = "IsAccrueTax";
        public const string COL_TAX_ISINTERFACETAX = "IsInterfaceTax";
        public const string COL_TAX_PERCENTAGE = "TaxPercentage";
        public const string COL_TAX_ISFLIPPEDFROMORDER = "IsFLippedFromOrder";
        public const string COL_TAX_ISINCLUDESHIPPING = "IsIncludeShipping";
        public const string COL_TAX_TAXBASE = "TaxBase";
        public const string COL_TAX_AUTHORITYNAME = "AuthorityName";
        public const string COL_TAX_TAXSTATE = "StateName";
        public const string COL_TAX_TAXCOUNTY = "County";
        public const string COL_TAX_TAXCITY = "City";
        public const string COL_TAX_TAXPOSTCODE = "PostCode";
        public const string COL_TAX_TAXGEOCODE = "GeoCode";
        public const string COL_TAX_TAXCOUNTRY = "CountryName";

        #endregion Tax Columns

        #region Stored Procedures

        public const string USP_P2P_REQ_CALCULATELINEITEMTAX = "usp_P2P_REQ_CalculateLineItemTax";
        public const string USP_P2P_PO_CALCULATELINEITEMTAX = "usp_P2P_PO_CalculateLineItemTax";
        public const string USP_P2P_INV_RECALCULATELINEITEMTAX = "usp_P2P_INV_ReCalculateLineItemTax";
        public const string USP_P2P_REQ_GETITEMDISPATCHMODE = "usp_P2P_REQ_GetItemsDispatchMode";

        public const string USP_P2P_SAVETAXMASTERFROMINTERFACE = "usp_P2P_SaveTaxMasterFromInterface";

        public const string TVP_P2P_INVOICETAXES = "tvp_P2P_InvoiceTaxes";
        public const string TVP_PTL_TAXMASTER = "tvp_PTL_TaxMaster";
        public const string TVP_P2P_REQUISITIONTAXES = "tvp_P2P_RequisitionTaxes";
        public const string TVP_P2P_TAXMASTER = "tvp_P2P_TaxMaster";
        public const string TVP_P2P_TAXJURISDICTIONS = "tvp_P2P_TaxJurisdictions";
        public const string TVP_P2P_JURISDICTIONORGENTITIES = "tvp_P2P_JurisdictionOrgEntities";
        public const string TVP_P2P_JURISDICTIONSHIPTOLOCATIONS = "tvp_P2P_JurisdictionShipToLocations";

        #endregion Stored Procedures

        #endregion Tax and Charges

        #region Notification

        public const string COL_ORDER_CONTACT_NAME = "OrderContactName";
        public const string COL_BUYER_COMPANY_NAME = "BuyerCompanyName";
        public const string COL_ORDER_CONTACT_EMAIL = "OrderContactEmail";
        public const string COL_ORDER_CONTACT_PHONE = "OrderContactPhone";
        public const string COL_PARTNER_INVOICING_CONTACTNAME = "PartnerInvoicingContactName";
        public const string COL_PARTNER_INVOICING_EMAIL = "PartnerInvoicingEmailId";
        public const string COL_BUYER_EMAIL = "BuyerEmailId";
        public const string COL_BUYER_CONTACT_NAME = "BuyerContactName";
        public const string COL_COMMENT = "Comment";
        public const string COL_DOCUMENTBUSE = "DocumentBUs";

        #endregion Notification

        #region Notification lables

        public const string NOTN_ParentOrderNumber = "[ParentOrderNumber]";
        public const string NOTN_SupplierName = "[SupplierName]";
        public const string NOTN_SupplierInvoiceNumber = "[SupplierInvoiceNumber]";
        public const string NOTN_SupplierCompanyName = "[SupplierCompanyName]";
        public const string NOTN_SupplierLegalCompanyName = "[SupplierLegalCompanyName]";
        public const string NOTN_SupplierInvoicingContactName = "[SupplierInvoicingContactName]";
        public const string NOTN_Supplier_Name = "[Supplier Name]";
        public const string NOTN_SupplierUserName = "[SupplierUserName]";
        public const string NOTN_SupplierUserEmailID = "[SupplierUserEmailID]";

        #endregion Notification lables

        #region Credit Memo

        public const string COL_INVOICEDQUANTITY = "InvoicedQuantity";
        public const string COL_INVOICEDAMOUNT = "InvoicedAmount";
        public const string COL_ORDEREDUNITPRICE = "OrderedUnitPrice";
        public const string COL_CREDITMEMO_ID = "CreditMemoId";
        public const string COL_CREDITMEMO_ITEMID = "CreditMemoItemId";

        public const string TVP_P2P_CM_DETAILS = "tvp_P2P_CM_Details";

        #region Credit Memo StoredProcedures

        public const string TVP_P2P_CREDITMEMOITEM = "tvp_P2P_CreditMemoItem";
        public const string TVP_P2P_CREDITMEMOITEMFORINTERFACE = "tvp_P2P_CreditMemoItemForInterface";

        public const string USP_P2P_CM_VALIDATEPARTNERMEMONUMBER = "usp_P2P_CM_ValidatePartnerMemoNumber";
        public const string USP_P2P_CM_FLIPCREDITMEMOFROMINVOICE = "usp_P2P_CM_FlipCreditMemoFromInvoice";
        public const string USP_P2P_CM_GENERATEDEFAULTCREDITMEMONAME = "usp_P2P_CM_GenerateDefaultCreditMemoName";
        public const string USP_P2P_CM_UPDATERECEIVEDATE = "usp_P2P_CM_UpdateReceiveDate";
        public const string USP_P2P_CM_FLIPACCOUNTINGSPLITFROMINVTOCM = "usp_P2P_CM_FlipAccountingSplitFromINVToCM";
        public const string USP_P2P_GETCREDITMEMOADDITIONALDETAILS = "usp_P2P_GetCreditMemoAdditionalDetails";
        public const string USP_P2P_GETALLDEFAULTENTITYVALUES = "usp_P2P_GetAllDefaultEntityValues";
        public const string USP_P2P_GETCREDITMEMOQUANTITY = "usp_P2P_GetCreditMemoQuantity";
        public const string USP_P2P_GETPOBasedCREDITMEMOQUANTITY = "usp_P2P_GetPOBasedCreditMemoQuantity";
        public const string USP_P2P_GEINVOICEQUANTITYAMOUNT = "usp_P2P_GeInvoiceQuantityAmount";
        public const string USP_P2P_GETORDERQUANTITYAMOUNT = "usp_P2P_GetOrderQuantityAmount";
        public const string USP_P2P_CM_VALIDATEINTERFACEDOCUMENT = "usp_P2P_CM_ValidateInterfaceDocument";
        public const string USP_P2P_CM_FLIPCREDITMEMOFROMORDER = "usp_P2P_CM_FlipCreditMemoFromOrder";

        public const string USP_P2P_CM_SAVESTANDALONECREDITMEMOFROMINTERFACE =
            "usp_P2P_CM_SaveStandAloneCreditMemoFromInterface";

        public const string USP_P2P_CM_VALIDATEBUYERINTERFACEDOCUMENT = "usp_P2P_CM_ValidateBuyerInterfaceDocument";
        public const string USP_P2P_CM_FLIPACCOUNTINGSPLITFROMPOTOCM = "usp_P2P_CM_FlipAccountingSplitFromPOToCM";
        public const string USP_P2P_CM_CREATECREDITMEMOSCANIMAGE = "usp_P2P_CM_CreateCreditMemoScanImage";
        public const string USP_P2P_CM_GETSCANNEDIMAGEIDSBYCREDITMEMOID = "usp_P2P_CM_GetScannedImageIdsByCreditMemoId";

        public const string USP_P2P_CM_VALIDATEINTERFACECREDITMEMOSTATUSBATCH =
            "usp_P2P_CM_ValidateInterfaceCreditMemoStatusBatch";

        public const string USP_P2P_CM_GETCREDITMEMODETAILSFORINTERFACE = "usp_P2P_CM_GetCreditMemoDetailsForInterface";

        public const string USP_P2P_CM_VALIDATEINTERFACESTANDALONECREDITMEMO =
            "usp_P2P_CM_ValidateInterfaceStandaloneCreditMemo";

        public const string USP_P2P_CM_GETCREDITMEMOITEMDETAILSFROMINTERFACE =
            "usp_P2P_CM_GetCreditMemoItemDetailsFromInterface";

        public const string USP_P2P_CM_PRORATETAX = "usp_P2P_CM_ProrateTax";
        public const string USP_P2P_CM_GETCMENTITYDETAILSBYID = "usp_P2P_CM_GetCMEntityDetailsById";

        public const string USP_P2P_CM_SAVECREDITMEMOADDITIONALENTITYDETAILS =
            "usp_P2P_CM_SaveCreditMemoAdditionalEntityDetails";

        public const string USP_P2P_CM_HEADERLEVELTAX = "usp_P2P_CM_Headerleveltax";

        public const string USP_P2P_CM_PRORATEHEADERSHIPPINGANDADDITIONALCHARGES =
            "usp_P2P_CM_ProrateHeaderShippingAndAdditionalCharges";

        public const string USP_P2P_CM_GETPARTNERDETAILSFORCREDITMEMO = "usp_P2P_CM_GetPartnerDetailsForCreditMemo";

        #endregion Credit Memo StoredProcedures

        #endregion Credit Memo

        #region Dynamic Discount sp's

        public const string USP_P2P_DD_GETINVOICEDETAILSFORDYNAMICDISCOUNT =
            "usp_P2P_DD_GetInvoiceDetailsForDynamicDiscount";

        public const string USP_P2P_DD_SAVEPARTNERINVITATION = "usp_P2P_DD_SavePartnerInvitation";
        public const string USP_P2P_DD_SAVEPARTNERRESPONSE = "usp_P2P_DD_SavePartnerResponse";
        public const string USP_P2P_DD_GETDYNAMICDISCOUNTDETAILS = "usp_P2P_DD_GetDynamicDiscountDetails";
        public const string USP_P2P_DD_SAVEDYNAMICDISCOUNTDETAILS = "usp_P2P_DD_SaveDynamicDiscountDetails";

        #endregion Dynamic Discount sp's

        #region Program sp's

        public const string USP_P2P_PG_GETENFORCEMENTS = "usp_P2P_PG_GetEnforcements";
        public const string USP_P2P_PG_SAVEPROGRAM = "usp_P2P_PG_SaveProgram";
        public const string USP_P2P_PG_GETPROGRAMBASICDETAILSBYID = "usp_P2P_PG_GetProgramBasicDetailsById";
        public const string USP_P2P_PG_GENERATEDEFAULTPROGRAMNAME = "usp_P2P_PG_GenerateDefaultProgramName";
        public const string USP_P2P_PG_GETPARENTPROGRAMS = "usp_P2P_PG_GetParentPrograms";
        public const string USP_P2P_PG_GETAllActivePROGRAMS = "usp_P2P_PG_GetAllActivePrograms";
        public const string USP_P2P_PG_UPDATEPROGRAMDATES = "usp_P2P_PG_UpdateProgramDates";
        public const string USP_P2P_PG_VALIDATEBUDGET = "usp_P2P_PG_ValidateBudget";
        public const string USP_P2P_PG_GETPROGRAMADDITIONALDETAILS = "usp_P2P_PG_GetProgramAdditionalDetails";
        public const string USP_P2P_PG_VALIDATECHILDPROGRAMSTATUS = "usp_P2P_PG_ValidateChildProgramStatus";
        public const string USP_P2P_PG_SAVEDOCUMENTMAPPING = "usp_P2P_PG_SaveDocumentMapping";
        public const string USP_P2P_PG_GETPROGRAMLINKEDDOCUMENTDETAILS = "usp_P2P_PG_GetProgramLinkedDocumentDetails";
        public const string USP_P2P_PG_GETDOCUMENTCOUNT = "usp_P2P_PG_GetDocumentCount";
        public const string USP_P2P_PG_TRANSFERFUNDS = "usp_P2P_PG_TransferFunds";
        public const string USP_P2P_PG_SAVEFORMMAPPING = "usp_P2P_PG_SaveFormMapping";

        public const string USP_P2P_PG_PROGRAM_SAVEADDITIONALENTITYDETAILS =
            "usp_P2P_PG_Program_SaveAdditionalEntityDetails";

        public const string USP_P2P_PG_GETPROGRAMBYIDFORNOTIFICATION = "USP_P2P_PG_GETPROGRAMBYIDFORNOTIFICATION";
        public const string USP_P2P_PG_GETPROGRAMENTITYDETAILSBYID = "USP_P2P_PG_GETPROGRAMENTITYDETAILSBYID";

        #endregion Program sp's

        #region Operational Budget sp's

        public const string USP_P2P_OB_GETFINANCIALCALENDARANDPERIOD = "usp_P2P_OB_GetFinancialCalendarAndPeriod";
        public const string USP_P2P_OB_SAVEFINANCIALCALENDAR = "usp_P2P_OB_SaveFinancialCalendar";
        public const string USP_P2P_OB_SAVECALENDARPERIOD = "usp_P2P_OB_SaveCalendarPeriod";
        public const string USP_P2P_OB_VALIDATEPERIODGAPANDOVERLAP = "usp_P2P_OB_ValidatePeriodGapAndOverlap";
        public const string USP_P2P_OB_GETLEGALENTITIES = "usp_P2P_OB_GetLegalEntities";
        public const string USP_P2P_OB_GETBUDGETSEGMENTS = "usp_P2P_OB_GetBudgetSegments";
        public const string USP_P2P_OB_GETBUDGETSTRUCTURE = "usp_P2P_OB_GetBudgetStructure";
        public const string USP_P2P_OB_GETDIRECTPURCHASE = "usp_P2P_OB_GetDirectPurchase";
        public const string USP_P2P_OB_GETSTATUS = "usp_P2P_OB_GetStatus";
        public const string USP_P2P_OB_ADDBUDGETSTRUCTUREENTITYDETAILS = "usp_P2P_OB_SaveBudgetStructureEntityDetails";
        public const string USP_P2P_OB_SAVEBUDGETALLOCATIONDETAILS = "usp_P2P_OB_SaveBudgetAllocationDetails";
        public const string USP_P2P_OB_GETBUDGETUTILIZATION = "usp_P2P_OB_GetBudgetUtilization";
        public const string USP_P2P_OB_GETALLCURRENCYANDEXCHANGERATE = "usp_P2P_OB_GetAllCurrencyAndExchangeRate";
        public const string USP_P2P_OB_GETBUDGETENFORCEMENTRULES = "usp_P2P_OB_GetBudgetEnforcementRules";
        public const string USP_P2P_OB_SAVEBUDGETENFORCEMENTRULES = "usp_P2P_OB_SaveBudgetEnforcementRules";

        public const string USP_P2P_OB_GETPERIODDATAFORAUTOSUGGEST = "usp_P2P_OB_GetPeriodDataForAutoSuggest";
        public const string USP_P2P_OB_SAVEBUDGETSTRUCTURE = "usp_P2P_OB_SaveBudgetStructure";
        public const string USP_P2P_OB_UPDATEOPERATIONALBUDGETFUNDSFLOW = "usp_P2P_OB_UpdateOperationalBudgetFundsFlow";
        public const string USP_P2P_OB_GETORGENTITYNAMESBYENTITYID = "usp_P2P_OB_GetOrgEntityNamesByEntityId";
        public const string USP_P2P_OB_GETBUDGETALLOCATION = "usp_P2P_OB_GetBudgetAllocation";
        public const string USP_P2P_OB_GETBUDGETSEGMENTDETAILS = "usp_P2P_OB_GetBudgetSegmentDetails";
        public const string TVP_P2P_OB_ENFORCEMENTRULE = "tvp_P2P_OB_EnforcementRule";

        #endregion Operational Budget sp's

        #region Operational Budget Columns

        public const string COL_CALENDARID = "CalendarId";
        public const string COL_CALENDARNAME = "CalendarName";
        public const string COL_CALENDARCODE = "CalendarCode";
        public const string COL_PERIODID = "PeriodId";
        public const string COL_PERIODCODE = "PeriodCode";
        public const string COL_PERIODNAME = "PeriodName";
        public const string COL_STRUCTURE_ID = "StructureID";
        public const string COL_LEGAL_ENTITY_ID = "EntityID";
        public const string COL_ENTITY_DETAIL_CODE = "EntityDetailCode";
        public const string COL_PARENT_ENTITY_DETAIL_CODE = "ParentEntityDetailCode";
        public const string COL_LEGAL_ENTITY_DISPLAYNAME = "EntityDisplayName";
        public const string COL_SEGMENTS = "Segments";
        public const string COL_SEGMENTIDS = "SegmentIds";
        public const string COL_ORGANIZATION = "Organization";
        public const string COL_COMPANY = "Company";
        public const string COL_REGION = "Region";
        public const string COL_LOCATION = "Location";
        public const string COL_COST_CENTER = "CostCenter";
        public const string COL_PROFIT_CENTER = "ProfitCenter";
        public const string COL_BUSINESS_UNIT = "BusinessUnit";
        public const string COL_GROUP = "Groups";
        public const string COL_GroupText = "GroupText";
        public const string COL_PROJECT = "Project";
        public const string COL_COMPANY_CODE = "CompanyCode";
        public const string COL_OB_BUDGET = "Budget";
        public const string COL_FUND = "Fund";
        public const string COL_DIRECT_PURCHASE_ID = "DirectPurchaseId";
        public const string COL_DIRECT_PURCHASE_NAME = "DirectPurchaseDisplayName";
        public const string COL_OB_STATUS = "Status";
        public const string COL_OB_STATUSID = "StatusID";
        public const string COL_OB_STATUSDISPLAYNAME = "StatusDisplayName";
        public const string COL_OB_ISDEFAULT = "IsDefault";
        public const string COL_OB_STRUCTURECODE = "StructureCode";
        public const string COL_OB_ISALLOCATED = "IsAllocated";
        public const string COL_OB_IsBudgetMovementRestricted = "IsBudgetMovementRestricted";

        #endregion Operational Budget Columns

        #region Operational Budget For Interface

        public const string TVP_BZ_BUDGETALLOCATION = "tvp_BZ_BudgetAllocation";
        public const string TVP_BZ_BUDGETALLOCATIONACCOUNTCODES = "tvp_BZ_BudgetAllocationAccountCodes";
        public const string USP_P2P_OB_SAVEBUDGETALLOCATION = "usp_P2P_OB_SaveBudgetAllocation";
        public const string USP_P2P_OB_GETBUDGETALLOCATIONFORINTERFACE = "usp_P2P_OB_GetBudgetAllocationForInterface";

        #endregion Operational Budget For Interface

        #region Source System Info sp's

        public const string USP_P2P_GetSourceSystemInfo = "usp_P2P_GetSourceSystemInfo";
        public const string USP_P2P_GetAllSourceSystemInfo = "usp_P2P_GetAllSourceSystemInfo";

        #endregion Source System Info sp's

        #region Source System Info Columns

        public const string COL_SOURCESYSTEMID = "SourceSystemId";
        public const string COL_SOURCESYSTEMNAME = "SourceSystemName";

        #endregion Source System Info Columns

        #region Exception For Override

        public const string COL_OVERRIDEFLAG = "OverrideFlag";
        public const string COL_ISOVERRIDABLE = "IsOverridable";
        public const string COL_OrderedUOM = "OrderedUOM";
        public const string COL_InvoiceUOM = "InvoiceUOM";
        public const string COL_AllowMultipleResolvers = "AllowMultipleResolvers";

        #endregion Exception For Override

        #region PaymentRequest

        #region PaymentRequest StoredProcedures

        public const string USP_P2P_PR_SAVEPAYMENTREQUEST = "usp_P2P_PR_SavePaymentRequest";

        public const string USP_P2P_PR_GENERATEDEFAULTPAYMENTREQUESTNAME =
            "usp_P2P_PR_GenerateDefaultPaymentRequestName";

        public const string USP_P2P_PR_GETPAYMENTREQUESTADDITIONALDETAILS =
            "usp_P2P_PR_GetPaymentRequestAdditionalDetails";

        public const string USP_P2P_PR_GETPAYMENTREQUESTBASICDETAILSBYID =
            "usp_P2P_PR_GetPaymentRequestBasicDetailsById";

        public const string USP_P2P_GETALLPAYMENTREQUESTDETAILSBYPAYMENTREQUESTID =
            "usp_P2P_GetAllPaymentRequestDetailsByPaymentRequestId";

        public const string USP_P2P_PR_GETPAYMENTREQUESTENTITYDETAILSBYID =
            "usp_P2P_PR_GetPaymentRequestEntityDetailsById";

        public const string USP_P2P_PR_GETVALIDATIONERRORCODEBYID = "usp_P2P_PR_GetValidationErrorCodeById";

        public const string USP_P2P_PR_DELETEALLLINEITEMSBYPAYMENTREQUESTID =
            "usp_P2P_PR_DeleteAllLineItemsByPaymentRequestId";

        public const string USP_P2P_PR_SAVEPAYMENTREQUESTITEM = "usp_P2P_PR_SavePaymentRequestItem";
        public const string USP_P2P_PR_GETPAYMENTREQUESTLINEITEMS = "usp_P2P_PR_GetPaymentRequestLineItems";
        public const string USP_P2P_PR_DELETELINEITEMBYID = "usp_P2P_PR_DeleteLineItemById";
        public const string USP_P2P_PR_GETALLLINEITEMSBYID = "usp_P2P_PR_GetAllLineItemsById";
        public const string USP_P2P_PR_SAVEPAYMENTREQUESTITEMOTHER = "usp_P2P_PR_SavePaymentRequestItemOther";
        public const string USP_P2P_PR_GETOTHERITEMDETAILSBYLIID = "usp_P2P_PR_GetOtherItemDetailsByLiId";

        public const string USP_P2P_PR_GETPAYMENTREQUESTACCOUNTINGDETAILSBYITEMID =
            "USP_P2P_PR_GetPaymentRequestAccountingDetailsByItemId";

        public const string USP_P2P_PR_GETPAYMENTREQUESTITEMACCOUNTINGSTATUS =
            "usp_P2P_PR_GetPaymentRequestItemAccountingStatus";

        public const string USP_P2P_PR_SAVEPAYMENTREQUESTACCOUNTINGDETAILS =
            "usp_P2P_PR_SavePaymentRequestAccountingDetails";

        public const string USP_P2P_PR_GETPAYMENTREQUEST_ENTITIES = "usp_P2P_PR_GetPaymentRequestEntities";

        public const string USP_P2P_PR_SAVEPAYMENTREQUESTADDITIONALENTITYDETAILS =
            "usp_P2P_PR_SavePaymentRequestAdditionalEntityDetails";

        public const string USP_P2P_PR_PRORATESHIPPINGANDFREIGHT = "usp_P2P_PR_ProrateShippingAndFreight";
        public const string USP_P2P_PR_CALCULATELINEITEMTAX = "usp_P2P_PR_CalculateLineItemTax";
        public const string USP_P2P_PR_UPDATETAXONHEADERSHIPTO = "usp_P2P_PR_UpdateTaxOnHeaderShipTo";
        public const string USP_P2P_PR_PRORATELINEITEMTAX = "usp_P2P_PR_ProrateLineItemTax";
        public const string USP_P2P_PR_CALCULATE_AND_UPDATELINEITEMTAX = "usp_P2P_PR_CalculateAndUpdateLineItemTax";

        public const string USP_P2P_PR_GETLINEITEMTAXDETAILS_FORLISTOFDOCUMENTITEMIDS =
            "usp_P2P_PR_GetLineItemTaxDetails_ForListOfDocumentItemIds";

        public const string USP_P2P_PR_UPDATELINEITEMSHIPTOLOCATION = "usp_P2P_PR_UpdateLineItemShipToLocation";
        public const string USP_P2P_PR_UPDATETAXONLINEITEM = "usp_P2P_PR_UpdateTaxOnLineItem";

        public const string USP_P2P_PR_SAVEPAYMENTREQUESTITEMSHIPPINGDETAILS =
            "usp_P2P_PR_SavePaymentRequestItemShippingDetails";

        public const string USP_P2P_PR_GETPaymentRequestTYPES = "usp_P2p_PR_GetPaymentRequestTypes";

        public const string USP_P2P_PR_SAVEPAYMENTREQUEST_DEFAULT_ACCOUNTINGDETAILSADR =
            "usp_P2P_PR_SavePaymentRequestDefaultAccountingForADR";

        #endregion PaymentRequest StoredProcedures

        #region Payment Request Columns

        public const string COL_PAYMENTREQUEST_ID = "PaymentRequestID";
        public const string COL_PAYMENTREQUEST_NAME = "PaymentRequestName";
        public const string COL_PAYMENTREQUEST_NUMBER = "PaymentRequestNumber";
        public const string COL_PAYMENTREQUEST_STATUS = "PaymentRequestStatus";
        public const string COL_PAYMENTREQUEST_SOURCE = "PaymentRequestSource";
        public const string COL_PAYMENTREQUEST_LOCATIONID = "PaymentRequestLocationID";
        public const string COL_PAYMENTREQUEST_MATCHTYPE = "MatchType";
        public const string COL_PAYMENTREQUEST_ITEMTOTAL = "ItemTotal";
        public const string COL_PAYMENTREQUESTAMOUNT = "PaymentRequestAmount";
        public const string COL_PAYMENTREQUESTSUBMITTEDBY = "SubmittedBy";
        public const string COL_PAYMENTREQUEST_EXTENDEDSTATUS = "ExtendedStatus";
        public const string COL_PAYMENTREQUEST_DATEACKNOWLEDGED = "DateAcknowledged";
        public const string COL_PAYMENTREQUEST_CONTACTCODE = "PaymentRequestContactCode";
        public const string COL_PAYMENTREQUEST_PAYMENTREQUESTCONTACTEMAIL = "PaymentRequestContactEmail";
        public const string COL_PAYMENTREQUEST_PAYMENTREQUESTCONTACTCODE = "PaymentRequestContactCode";
        public const string COL_PAYMENTREQUEST_ISINTERNALITEMEXIST = "IsInternalItemExist";

        public const string COL_CLOSING_PAYMENTREQUEST_STATUS = "ClosingPaymentRequestStatus";

        public const string COL_PAYMENTREQUEST_TYPE = "PaymentRequestType";
        public const string COL_PAYMENTREQUEST_PARENTITEM_UNITPRICE = "ParentItemUnitPrice";

        public const string COL_PAYMENTREQUEST_PARENTITEM_DATENEEDED = "ParentItemDateNeeded";

        public const string COL_PAYMENTREQUEST_PARENTDOCUMENTCODE = "ParentDocumentCode";

        public const string COL_PAYMENTREQUEST_CONTACT = "PaymentRequestContact";
        public const string COL_PRITEM_SHIPPING_ID = "PaymentRequestLineItemShippingID";
        public const string COL_PRTYPEID = "PRTypeId";
        public const string COL_CREATED_ON = "CreatedOn";
        public const string COL_PAYMENTREQUEST_REMITTOLOCATIONID = "RemittoLocationId";

        #endregion Payment Request Columns

        #region Payment Request item Columns

        public const string COL_PR_ITEM_ID = "PaymentRequestItemID";

        #endregion Payment Request item Columns

        #endregion PaymentRequest

        #region Buisness Details

        public const string COL_BU_BusinessUnitCode = "BusinessUnitCode";
        public const string COL_BU_BusinessUnitEntityCode = "BusinessUnitEntityCode";
        public const string COL_BU_BusinessUnitName = "BusinessUnitName";

        #endregion Buisness Details

        #region Service Procument

        public const string COL_PURCHASETYPEID = "PurchaseTypeId";
        public const string COL_PURCHASETYPE = "PurchaseType";
        public const string COL_INVOICETYPE = "InvoiceType";
        public const string COL_ITEMTYPE = "ItemType";
        public const string COL_ISFLEXIBLECHARGE = "IsFlexibleCharge";
        public const string COL_PURCHASE_DESCRIPTION = "Description";
        public const string COL_CREDITMEMOTYPE = "CreditMemoType";

        #endregion Service Procument

        #region Service Confirmation

        #region ServiceConfirmation StoredProcedure

        public const string USP_P2P_SC_GENERATEDEFAULTSERVICECONFIRMATIONNAME =
            "usp_P2P_SC_GenerateDefaultServiceConfirmName";

        public const string USP_P2P_SC_GETSERVICECONFIRMATIONADDITIONALDETAILS =
            "usp_P2P_SC_GetServiceConfirmationAdditionalDetails";

        public const string USP_P2P_SC_CREATESERVICECONFIRMATIONFROMORDER =
            "usp_P2P_SC_CreateServiceConfirmationFromOrder";

        public const string USP_P2P_SC_GETSERVICECONFIRMATIONDETAILSFOREXPORTPDFBYID =
            "usp_P2P_SC_GetServiceConfirmationDetailsForExportPDFById";

        public const string USP_P2P_SC_CHECKINVOICECREATEDFORSERVICECONFIRMATION =
            "usp_P2P_SC_CheckInvoiceCreatedForServiceConfirmation";

        public const string USP_P2P_SC_GETSERVICECONFIRMATIONDETAILSFORNOTIFICATION =
            "usp_P2P_SC_GetServiceConfirmationDetailsForNotification";

        #endregion ServiceConfirmation StoredProcedure

        #endregion Service Confirmation

        #region Questionnaire

        public const string COL_QUESTIONNAIRECODE = "QuestionnaireCode";
        public const string COL_QUESTIONNAIRETITLE = "QuestionnaireTitle";
        public const string COL_QUESTIONNAIREDESCRIPTION = "QuestionnaireDescription";
        public const string COL_QUESTIONNAIREORDER = "QuestionnaireOrder";
        public const string COL_ISSUPPLIERVISIBLE = "IsSupplierVisible";
        public const string COL_ISINFORMATIVE = "IsInformative";
        public const string COL_WEIGHTAGE = "Weightage";
        public const string COL_QUESTIONTEXT = "QuestionText";
        public const string COL_RESPONSEVALUE = "ResponseValue";
        public const string COL_QUESTIONID = "QuestionId";
        public const string COL_QUESTIONTYPEID = "QuestionTypeId";
        public const string COL_SORTORDER = "SortOrder";
        public const string COL_ASSESSEEID = "AssesseeId";
        public const string COL_ASSESSORID = "AssessorId";
        public const string COL_ASSESSORTYPE = "AssessorType";
        public const string COL_COLUMNID = "ColumnId";
        public const string COL_ROWID = "RowId";
        public const string COL_OBJECTINSTANCEID = "ObjectInstanceId";
        public const string COL_RESPONSEID = "ResponseId";
        public const string COL_USERCOMMENTS = "UserComments";
        public const string COL_TABID = "TabId";
        public const string COL_ROWTEXT = "RowText";
        public const string COL_COLUMNTEXT = "ColumnText";
        public const string COL_ROWDESCRIPTION = "RowDescription";
        public const string COL_COLUMNDESCRIPTION = "ColumnDescription";
        public const string COL_CHILDQUESTIONSETCODE = "ChildQuestionSetCode";
        public const string COL_DATETIMETYPE = "DateTimeType";
        public const string COL_DATETIMEFORMAT = "DateTimeFormat";
        public const string COL_ALLOW_SINGLE_SELECT = "AllowSingleSelect";
        public const string COL_FIELD_TYPE_ID = "FieldTypeId";
        public const string COL_FIELD_TYPE_NAME = "FieldTypeName";
        public const string COL_FIELD_GET_SP_NAME = "FieldGetSPName";
        public const string COL_LOCALIZATION_SUFIX = "LocalizationSufix";
        public const string COL_ISAUTOSUGGEST = "IsAutoSuggest";
        public const string COL_CONDITIONAL_ID = "ConditionalId";
        public const string COL_HASCONDITIONALQUESTION = "HasConditionalQuestion";
        public const string COL_NUMBER_OF_ATTACHMENTS = "NumberofAttachments";
        public const string COL_IS_ATTACHMENTID = "AttachmentId";

        #endregion Questionnaire

        #region FOBShippingDetails

        #region sp's

        public const string USP_P2P_GETALLFOBCODES = "USP_P2P_GetAllFOBCodes";
        public const string USP_P2P_GETALLFOBLOCATIONS = "USP_P2P_GetAllFOBLocations";
        public const string USP_P2P_GETALLFREIGHTTERMS = "USP_P2P_GetAllFreightTerms";
        public const string USP_P2P_GETALLTRANSITTYPE = "USP_P2P_GetAllTransitType";
        public const string USP_P2P_GETALLCARRIERS = "USP_P2P_GetAllCarriers";
        public const string USP_P2P_SAVEFOBSHIPPINGDETAILS = "USP_P2P_SaveFOBShippingDetails";
        public const string USP_P2P_SAVESTANDARDANDPROCEDUREDETAILS = "USP_P2P_SaveStandardAndProcedureDetails";
        public const string USP_P2P_PO_GETSTANDARDANDPROCEDUREDETAILS = "USP_P2P_PO_GetStandardAndProcedureDetails";

        #endregion sp's

        public const string COL_FOBCODEID = "FOBCodeID";
        public const string COL_FOBCODE = "FOBCode";
        public const string COL_FOBCODEDESCRIPTION = "FOBCodeDescription";
        public const string COL_FOBLOCATIONID = "FOBLocationID";
        public const string COL_FOBLOCATIONCODE = "FOBLocationCode";
        public const string COL_FOBLOCATIONDESCRIPTION = "FOBLocationDescription";
        public const string COL_CARRIERSID = "CarriersID";
        public const string COL_CARRIERSCODE = "CarriersCode";
        public const string COL_CARRIERSDESCRIPTION = "CarriersDescription";
        public const string COL_FREIGHTTERMSID = "FreightTermsID";
        public const string COL_FREIGHTTERMSCODE = "FreightTermsCode";
        public const string COL_FREIGHTTERMSDESCRIPTION = "FreightTermsDescription";
        public const string COL_TRANSITTYPEID = "TransitTypeID";
        public const string COL_TRANSITTYPECODE = "TransitTypeCode";
        public const string COL_TRANSITTYPEDESCRIPTION = "TransitTypeDescription";
        public const string TVP_STANDARDS_PROCEDURES = "tvp_Standards_Procedures";
        public const string COL_FULLTEXTS = "FullTexts";
        public const string COL_MANUFACTURER_SUPPLIERCODE = "ManufacturerSupplierCode";
        public const string COL_MANUFACTURER_MODEL = "ManufacturerModel";

        #endregion FOBShippingDetails

        #region "Custom Attributes"

        public const string USP_QB_GETALLQUESTIONTYPES = "usp_QB_GetAllQuestionTypes";

        public const string COL_QUESTIONSETCODE = "QUESTIONSETCODE";
        public const string USP_BZ_GETQUESTIONSETCODEBYFORMCODE = "usp_BZ_GetQuestionSetCodeByFormCode";
        public const string USP_QB_SAVEQUESTIONRESPONSE = "usp_QB_SaveQuestionResponse";
        public const string USP_P2P_SAVECUSTOMATTRIBRESPONSE = "usp_P2P_SaveCustomAttribResponse";
        public const string USP_P2P_GETQUESTIONRESPONSEBYFORMCODE = "usp_P2P_GetQuestionResponseByFormCode";
        public const string USP_P2P_GETQUESTIONDETAILSBYFORMCODE = "usp_P2P_GetQuestionDetailsByFormCode";
        public const string USP_P2P_GETQUESTIONRESPONSEBYQSETCODE = "usp_P2P_GetQuestionResponseByQSetCode";
        public const string USP_P2P_GETCUSTOMFIELDDETAILFORINTERFACE = "usp_P2P_GetCustomFieldDetailForInterface";
        public const string USP_P2P_VALIDATECUSTOMFIELDS = "USP_P2P_ValidateCustomFields";

        public const string USP_P2P_INV_CALCULATEANDUPDATEINVOICEFROMCUSTOMATTRIBUTE =
            "usp_P2P_INV_CalculateAndUpdateInvoiceFromCustomAttribute";

        #endregion "Custom Attributes"

        #region export template

        public const string USP_GetDocumentExportTemplate = "usp_P2P_GetDocumentExportTemplate";

        public const string USP_P2P_GetDivisionCodeEntityCodeEntityDetailMappingByDocumentCode =
            "usp_P2P_GetDivisionCodeEntityCodeEntityDetailMappingByDocumentCode";

        public const string USP_P2P_GetPartnerContactCodeByDocumentCode = "usp_P2P_GetPartnerContactCodeByDocumentCode";

        public const string COL_TemplateHTML = "TemplateHTML";
        public const string COL_CultureCode = "CultureCode";
        public const string COL_EntityId = "EntityId";
        public const string COL_EntityDetailCode = "EntityDetailCode";
        public const string COL_DivisionEntityCode = "DivisionEntityCode";
        public const string COL_IsLandscape = "IsLandscape";
        public const string COL_TimeZone = "TimeZone";
        public const string COL_PartnerContactCode = "PartnerContactCode";
        public const string COL_PartnerCode = "PartnerCode";
        public const string COL_IsMultiDocInvoice = "IsMultiDocInvoice";
        public const string COL_DocumentStatusInfo = "DocumentStatusInfo";
        public const string COL_orderSource = "orderSource";
        public const string COL_type = "type";
        public const string COL_ContractUtilizationTrackingIncludeTaxes = "ContractUtilizationTrackingIncludeTaxes";

        #endregion export template

        #region VAT

        #region columns's

        public const string COL_IDENTIFICATIONID = "IdentificationId";
        public const string COL_IDENTIFICATIONVALUE = "IdentificationValueId";
        public const string COL_IdentificationValue = "IdentificationValue";
        public const string COL_SupplierIdentificationValue = "SupplierIdentificationValue";
        public const string COL_IDENTIFICATIONNAME = "IdentificationName";
        public const string COL_ISBUYERLOCATION = "IsBuyerLocation";
        public const string COL_SUPPLIERVAT = "SupplierVAT";

        #endregion columns's

        #endregion VAT

        #region LOBEntity Configuration

        public const string COL_FORMCODE = "FormCode";
        public const string COL_IDENTIFICATIONTYPEID = "IdentificationTypeID";

        public const string USP_P2P_GETLOBENTITYCONFIGURATIONBYLOBENTITYDETAILCODE =
            "usp_P2P_GetLOBEntityConfigurationByLOBEntityDetailCode";

        #endregion LOBEntity Configuration

        #region Item Charge

        #region sp's

        public const string USP_P2P_GETORDERITEMCHARGES = "USP_P2P_GETORDERITEMCHARGES";
        public const string USP_P2P_GETINVOICEITEMCHARGES = "USP_P2P_GETINVOICEITEMCHARGES";
        public const string USP_P2P_GETDEFAULTCALCULATIONBASIS = "usp_P2P_GetDefaultCalculationBasis";
        public const string USP_P2P_SAVEORDERITEMCHARGES = "usp_P2P_SaveOrderItemCharges";
        public const string USP_P2P_SAVEINVOICEITEMCHARGES = "usp_P2P_SaveInvoiceItemCharges";
        public const string USP_P2P_GETALLCHARGENAME = "usp_P2P_GetAllChargeName";
        public const string USP_P2P_GETALLCHARGEATTRIBUTESETTINGS = "usp_P2P_GetAllChargeAttributeSettings";

        public const string USP_P2P_GETCHARGEMASTERDETAILSBYCHARGEMASTERID =
            "usp_P2P_GetChargeMasterDetailsByChargeMasterId";

        public const string USP_P2P_DELETEORDERITEMCHARGEBYID = "usp_P2P_DeleteOrderItemChargeById";
        public const string USP_P2P_DELETEINVOICEITEMCHARGEBYID = "usp_P2P_DeleteInvoiceItemChargeById";
        public const string USP_P2P_PO_SAVEORDERCHARGEDEFAULTACCOUNTING = "usp_P2P_PO_SaveOrderChargeDefaultAccounting";

        public const string USP_P2P_PO_SAVEORDERCHARGEDEFAULTACCOUNTINGFORINTERFACE =
            "USP_P2P_PO_SAVEORDERCHARGEDEFAULTACCOUNTINGFORINTERFACE";

        public const string USP_P2P_INV_SAVEINVOICECHARGEDEFAULTACCOUNTING =
            "usp_P2P_INV_SaveInvoiceChargeDefaultAccounting";

        public const string USP_P2P_PO_ExternalCodeCombination = "usp_P2P_PO_UpdateExternalErrorCode";
        public const string USP_P2P_GETALLCHARGEMASTERDETAILSBYCHARGENAME = "usp_P2P_GetItemChargesByName";
        public const string USP_P2P_SAVEALLORDERITEMCHARGES = "usp_P2P_SaveAllOrderItemCharges";

        #endregion sp's

        #region columns's

        public const string COL_ITEMCHARGEID = "ItemChargeId";
        public const string COL_CHARGEMASTERID = "ChargeMasterId";
        public const string COL_CHARGENAME = "ChargeName";
        public const string COL_CHARGEDESCRIPTION = "ChargeDescription";
        public const string COL_CALCULATIONBASISID = "CalculationBasisId";
        public const string COL_CALCULATIONVALUE = "CalculationValue";
        public const string COL_CHARGEAMOUNT = "ChargeAmount";
        public const string COL_ISINCLUDEFORRETAINAGE = "IsIncludeForRetainage";
        public const string COL_ISINCLUDEFORTAX = "IsIncludeForTax";
        public const string COL_TOLERANCEPERCENTAGE = "TolerancePercentage";
        public const string COL_ISALLOWANCE = "IsAllowance";
        public const string COL_ISEDITABLEONINVOICE = "IsEditableOnInvoice";
        public const string COL_CHARGETYPENAME = "ChargeTypeName";
        public const string COL_CALCULATIONBASIS = "CalculationBasis";
        public const string COL_CHARGEATTRIBUTESETTINGID = "ChargeAttributeSettingId";
        public const string COL_ATTRIBUTENAME = "AttributeName";
        public const string COL_ISEDITABLE = "IsEditable";
        public const string COL_ISVISIBLE = "IsVisible";
        public const string COL_CHARGETYPECODE = "ChargeTypeCode";
        public const string COL_EDICODE = "EDICode";
        public const string COL_DEFAULTVALUE = "DefaultValue";
        public const string COL_TOTALALLOWANCE = "TotalAllowance";
        public const string COL_DOCUMENTTOTAL = "DocumentTotal";
        public const string COL_DOCUMENTTAX = "DocumentTax";
        public const string COL_DOCUMENTADDITIONALCHARGE = "DocumentAdditionalCharge";
        public const string PRM_P2P_TVP_ITEMCHARGES = "@Tvp_ItemCharges";
        public const string COL_ISHEADERLEVELCHARGE = "IsHeaderLevelCharge";

        #endregion columns's

        #endregion Item Charge

        #region "Exchangerate"

        public const string USP_P2P_PO_UpdateDocumentWithConversion = "usp_P2P_PO_UpdateDocumentWithConversion";
        public const string USP_P2P_GETCURRENCYCONVERSIONRATE = "usp_P2P_GetCurrencyConversionRate";
        public const string COL_FROMCURRENCY = "FromCurrency";
        public const string COL_RETURNCURRENCY = "ReturnCurrency";
        public const string COL_EXCHANGERATE = "ExchangeRate";
        public const string COL_ISCONVERSIONAVAILABLE = "IsConversionAvailable";
        public const string USP_CheckConversionOnFlip = "usp_CheckConversionOnFlip";
        public const string COL_DocumentCodeFlip = "DocumentCode";
        public const string COL_RequistionCurrencyFlip = "FromCurrency";
        public const string COL_ToCurrencyFlip = "ToCurrency";

        #endregion "Exchangerate"

        #region ASN

        public const string COL_ASNID = "ASNID";
        public const string COL_NOTESANDATTACHMENTS_ASNID = "ASNId";
        public const string COL_SHIPPINGDATE = "ShippingDate";
        public const string COL_EXPECTEDDELIVERYDATE = "ExpectedDeliveryDate";
        public const string COL_TRACKINGNUMBER = "TrackingNumber";
        public const string COL_ASSETINFORMATION = "AssetInformation";
        public const string COL_ASNITEMID = "ASNItemID";
        public const string COL_SENTQUANTITY = "SentQuantity";
        public const string COL_ASNStatus = "ASNStatus";
        public const string COL_SHIPTOLOCATIONID = "ShipToLocationID";
        public const string COL_SHIPTOLOCATIONNAME = "ShipToLocationName";
        public const string COL_ShiptoLocationState = "ShiptoLocationState";
        public const string COL_ShiptoLocationZip = "ShiptoLocationZip";
        public const string COL_SHIPTOLOCATIONADDRESS = "ShipToLocationAddress";
        public const string COL_ASNNAME = "ASNName";
        public const string COL_ASNNUMBER = "ASNNumber";
        public const string COL_PARTNERASNNUMBER = "PartnerASNNumber";
        public const string COL_CREATOR = "Creator";
        public const string COL_CREATORID = "CreatorId";
        public const string COL_ORDERID = "OrderId";
        public const string COL_ORDERRECEIVEDDATE = "OrderReceivedOn";
        public const string COL_ORDERACKNOWLEDGEDDATE = "OrderAcknowledgedOn";
        public const string COL_SHIPPEDQUANTITY = "ShippedQuantity";
        public const string COL_PREVIOUSLYACCEPTEDQUANTITY = "PreviouslyAcceptedQuantity";
        public const string COL_PREVIOUSLYSHIPPEDQUANTITY = "PreviouslyShippedQuantity";
        public const string COL_ISVALID = "IsValid";
        public const string COL_LINEITEM = "LineItem";
        public const string TVP_ASNITEM = "tvp_ASNItem";
        public const string USP_P2P_SAVEASN = "usp_P2P_SaveASN";
        public const string COL_PARTNERADDRESS = "PartnerAddress";
        public const string COL_PARTNEREMAILADDRESS = "PartnerEmailAddress";
        public const string COL_PARTNERPHONENUMBER = "PartnerPhoneNumber";
        public const string COL_BUYERNAME = "BuyerName";
        public const string COL_BUYERADDRESS = "BuyerAddress";
        public const string COL_BUYEREMAILADDRESS = "BuyerEmailAddress";
        public const string COL_BUYERPHONENUMBER = "BuyerPhoneNumber";
        public const string COL_ORDERIDS = "OrderIds";
        public const string USP_P2P_ASN_GETASNADDITIONALDETAILS = "usp_P2P_ASN_GetASNAdditionalDetails";
        public const string USP_P2P_ASN_GENERATEDEFAULTASNNAME = "usp_P2P_ASN_GenerateDefaultASNName";
        public const string USP_P2P_ASN_GETALLDISPLAYDETAILS = "usp_P2P_ASN_GetAllDisplayDetails";
        public const string USP_P2P_ASN_VALIDATEASNCREATION = "usp_P2P_ASN_ValidateASNCreation";
        public const string USP_P2P_ASN_VALIDATERECEIPTCREATIONFORASN = "usp_P2P_ASN_ValidateReceiptCreationForASN";
        public const string USP_P2P_ASN_CreateASNFROMORDERS = "usp_P2P_ASN_CreateASNFromOrders";
        public const string USP_P2P_ASN_GetASNDetailsForNotification = "usp_P2P_ASN_GetASNDetailsForNotification";
        public const string USP_P2P_ASN_ValidateASNONSUBMIT = "usp_P2P_ASN_ValidateASNOnSubmit";
        public const string USP_P2P_ASN_SAVENOTESANDATTACHMENTS = "usp_P2P_ASN_SaveNotesAndAttachments";
        public const string USP_P2P_ASN_GETNOTESANDATTACHMENTS = "usp_P2P_ASN_GetNotesAndAttachments";
        public const string USP_P2P_ASN_DELETENOTESANDATTACHMENTS = "usp_P2P_ASN_DeleteNotesAndAttachments";
        public const string USP_DM_GETDOCUMENTBUS = "usp_DM_GetDocumentBUs";
        public const string USP_P2P_ASN_CREATERECEIPTFROMASN = "usp_P2P_ASN_CreateReceiptFromASN";
        public const string USP_P2P_ASN_ValidateChangeOrder = "usp_P2P_ASN_ValidateChangeOrder";
        public const string USP_P2P_PO_UPDATEORDEREXTENDEDSTATUS = "usp_P2P_PO_UpdateOrderExtendedStatus";
        public const string USP_P2P_ASN_GETASNDETAILSBYID = "usp_P2P_ASN_GetAsnDetailsByID";
        public const string USP_P2P_ASN_GETASNFORINTERFACE = "usp_P2P_ASN_GetAsnForInterface";
        public const string USP_P2P_ASN_UPDATEINTERFACESTATUS = "usp_P2P_ASN_UpdateInterfaceStatus";
        public const string USP_P2P_ASN_GETASNDETAILSFOREXPORTPDFBYID = "usp_P2P_ASN_GetASNDetailsForExportPDFById";

        #endregion ASN

        #region Escalation Details

        public const string TVP_DM_DOCUMENT_ESCALATION = "tvp_DM_DocumentEscalation";
        public const string USP_UPDATE_DM_ESCALATION_LOG_TABLE = "usp_Update_DM_EscalationLogDtl";
        public const string USP_WF_ESCALATE_DOCUMENT_TO_MANAGER = "usp_WF_EscalateDocumentToManager";

        #endregion Escalation Details

        #region RegistrationLocationDetails

        public const string COL_COMPANYIDENTIFICATIONDISPLAYNAME = "CompanyIdentificationDisplayName";
        public const string COL_COMPANYIDENTIFICATION = "CompanyIdentification";

        #endregion RegistrationLocationDetails

        #region ADR

        public const string COL_SourceCombinationId = "SourceCombinationId";
        public const string COL_ADRDescription = "Description";
        public const string COL_ADRDSourceDescription = "SourceDescription";
        public const string COL_ADRDSourceid = "SourceId";
        public const string COL_ADRDSourceValue = "SourceValue";
        public const string COL_ADRDSourceMapPartId = "SourceMapPartId";
        public const string COL_ADRENTITY_LEVEL = "level";
        public const string COL_ADRMappingHeaderSetId = "MappingHeaderSetId";
        public const string COL_ADRLOBID = "LOBID";
        public const string COL_ADRSTRUCTUREID = "StructureID";
        public const string COL_ADRSetDescription = "SetDescription";
        public const string COL_ADROutPutObject = "OutPutObject";
        public const string COL_ADRPrecedence = "Precedence";
        public const string COL_ADRSetId = "SetId";
        public const string COL_ADRTargetId = "TargetId";
        public const string COL_ADRTargetDescription = "TargetDescription";
        public const string COL_ADRTargetEntityDetailCode = "TargetEntityDetailCode";
        public const string COL_ADRTargetValue = "TargetValue";
        public const string COL_Identifier = "Identifier";
        public const string COL_RESTURL = "RestUrl";
        public const string COL_ISACCOUNTINGSEGMENT = "IsAccountingsegment";

        #endregion ADR

        #region ADR

        #region SP

        public const string USP_ADR_GETALLHEADERSET = "USP_ADR_GetAllHeaderSet";
        public const string USP_ADR_GETALLDATASET = "USP_ADR_GetAllDataset";
        public const string USP_P2P_GETALLADRSOURCES = "USP_P2P_GetAllADRSources";
        public const string USP_ADR_GETENTITYDETAILSBYCODES = "USP_ADR_GetEntityDetailsByCodes";
        public const string USP_ADR_GETENTITYDETAILSBYUSERDEFUALT = "USP_ADR_GetEntityDetailsByUserDefualt";
        public const string USP_ADR_GETALLCATEGORYGLMAPPING = "USP_ADR_GetAllCategoryGLMapping";
        public const string USP_ADR_GETPERIODDEFAULTDATA = "USP_ADR_GetPeriodDefaultData";

        public const string USP_P2P_REQ_SAVEREQUISITION_DEFAULT_ACCOUNTINGDETAILSADR =
            "USP_P2P_REQ_SaveRequisitionDefaultAccountingForADR";

        public const string USP_P2P_PO_SAVEORDER_DEFAULT_ACCOUNTINGDETAILSADR =
            "USP_P2P_PO_SaveOrderDefaultAccountingForADR";

        #endregion SP

        #region TVP

        public const string TVP_ORG_ENTITYDETAILS = "tvp_ORG_EntityDetails";
        public const string TVP_P2P_ADRSPLITITEMSENTITIES = "tvp_P2P_ADRSplitItemsEntities";
        public const string TVP_P2P_INV_ORDERACCEPTANCELIST = "tvp_P2P_INV_OrderAcceptanceList";

        #endregion TVP

        #endregion ADR

        #region "NewP2PDocoumentDAO"

        public const string DOT = ".";
        public const string SLASH = "/";
        public const string SPACE = " ";
        public const string COMMA = ",";
        public const string HYPHEN = "-";
        public const string CITY = "CMN_City";
        public const string DRAFT = "CMN_Draft";
        public const string CC = "P2P_CC_ORDER";
        public const string STATE = "CMN_State";
        public const string GL_CODE = "GL CODE";
        public const string CUSTOM = "P2P_Custom";
        public const string BUYERS = "P2P_Buyers";
        public const string COUNTY = "CMN_County";
        public const string NONE = "PFM_CMN_None";
        public const string MANUAL = "P2P_REQ_Manual";
        public const string MRP = "P2P_MRP_ORDER";
        public const string REQUESTER = "REQUESTER";
        public const string FEDERAL = "CMN_Federal";
        public const string WORK = "P2P_WORK_ORDER";
        public const string ORDERED = "CMN_Ordered";
        public const string APPROVED = "CMN_Approved";
        public const string DISTRICT = "CMN_District";
        public const string SALES = "P2P_SALES_ORDER";
        public const string REJECTED = "CMN_Rejected";
        public const string SUPPLIER = "P2P_Supplier";
        public const string APPROVERS = "P2P_Approvers";
        public const string WITHDRAWN = "CMN_Withdrawn";
        public const string CATALOG = "P2P_REQ_Catalog";
        public const string MATERIAL = "P2P_REQ_Material";
        public const string REQUESTERS = "P2P_Requesters";
        public const string INTERNAL = "P2P_INTERNAL_ORDER";
        public const string ORDER = "P2P_ORDER";
        public const string INVOICE = "P2P_INVOICE";
        public const string INVENTORY = "From inventory";
        public const string PAYABLEUSERS = "P2P_PayableUsers";
        public const string PROCURABLE = "Procurable";
        public const string INTERNALUSERS = "P2P_InternalUsers";
        public const string NONPROCURABLE = "CMN_NonProcurable";
        public const string DRAFTWITHDRAWN = "CMN_DraftWithdrawn";
        public const string FIXED_SERVICE = "P2P_REQ_FixedService";
        public const string APPROVALPENDING = "CMN_ApprovalPending";
        public const string PARTIALLYORDERED = "CMN_PartiallyOrdered";
        public const string SUBMITTEDTOBUYER = "CMN_SubmittedToBuyer";
        public const string SENTTOSUPPLIER = "CMN_SentToSupplier";
        public const string SUPPLIERACKNOWLEDGED = "CMN_SupplierAcknowledged";
        public const string ACKNOWLEDGEMENTPENDING = "CMN_AcknowledgementPending";
        public const string SENDINGTOSUPPLIERFAILED = "CMN_SendingToSupplierFailed";
        public const string SENDFORAPPROVALFAILED = "CMN_SendForApprovalFailed";
        public const string CANCELLED = "CMN_Cancelled";
        public const string VARIABLE_SERVICE = "P2P_REQ_VariableService";
        public const string INTERNALUSERSANDPARTNERS = "P2P_InternalUsersAndSuppliers";
        public const string SENTFORBIDDING = "P2P_SendForBidding";
        public const string CHARGE = "P2P_CHARGE";
        public const string SERVICE_ACTIVITY = "P2P_SERVICEACTIVITY";
        public const string MILESTONE = "P2P_MILESTONE";
        public const string PROGRESS = "P2P_PROGRESS";
        public const string ADVANCE = "P2P_ADVANCE";
        public const string SENTBACK = "CMN_SentBack";
        public const string SENTTOREQUESTER = "CMN_SentToRequester";
        public const string ACCEPTED = "CMN_Accepted";
        public const string SENTBYBUYER = "CMN_SentByBuyer";
        public const string EXCEPTION = "CMN_Exception";
        public const string MATCHED = "CMN_Matched";
        public const string INVOICEDSTATUS = "CMN_InvoicedStatus";
        public const string CLOSEDFORRECEIVING = "CMN_ClosedForReceiving";
        public const string READYFORPAYMENT = "CMN_ReadyForPayment";
        public const string SENTFORPAYMENT = "CMN_SentForPayment";
        public const string CANCEL = "CMN_Cancel";
        public const string DELETED = "CMN_Deleted";
        public const string SENTFORPROCESSING = "CMN_SentForProcessing";
        public const string SENTTOERP = "CMN_SentToERP";
        public const string ERRORSTATUS = "CMN_ErrorStatus";
        public const string CLOSEDFORINVOICING = "CMN_ClosedForInvoicing";
        public const string INVOICEPAYMENTCANCELLED = "CMN_InvoicePaymentCancelled";
        public const string PERIOD = "PERIOD";
        public const string CONTINGENT_WORKER = "Contingent Worker";
        public const string EXPENSES = "Expense";

        #endregion "NewP2PDocoumentDAO"

        #region External Request

        public const string USP_P2P_INV_GETDATAFOREXTERNALREQUEST = "USP_P2P_INV_GetDataForExternalRequest";
        public const string TVP_P2P_INV_EXTERNALREQUEST = "tvp_P2P_INV_ExternalRequest";

        #endregion External Request

        #region Platform SP's

        public const string USP_STG_GET_BASIC_SETTING_BY_CONTACTID = "usp_STG_GetBasicSettingsByContactId";
        public const string USP_PAS_GETPASCODEFROMCLIENTPASCODE = "usp_PAS_GetPASCodeFromClientPASCode";
        public const string USP_PTL_GETFILTEREDTAXMASTERDETAILS = "usp_PTL_GetFilteredTaxMasterDetails";

        /// <summary>
        ///     This Sp is used To Get Tab Information
        /// </summary>
        public const string USP_PM_GetTab = "usp_PM_GetTab";

        public const string USP_PM_GETALLQUESTIONNAIRE = "usp_PM_GetAllQuestionnaire";
        public const string USP_QB_GETQUESTIONBYQUESTIONSETCODEPAGING = "usp_QB_GetQuestionsByQuestionSetCodePaging";
        public const string USP_QB_GETQUESTIONDETAIL = "usp_QB_GetQuestionDetails";
        public const string USP_QB_GETALLQUESTIONATTACHMENT = "usp_QB_GetAllQuestionAttachment";
        public const string USP_QB_GETQUESTIONRESPONSE = "usp_QB_GetQuestionResponse";
        public const string USP_QB_GETALLQUESTIONRESPONSEATTACHMENT = "usp_QB_GetAllQuestionResponseAttachment";
        public const string USP_QB_GETQUESTIONSCORERESPONSE = "usp_QB_GetQuestionScoreResponse";
        public const string USP_QB_MANDATORYQUESTIONWITHNORESPONSE = "usp_QB_MandatoryQuestionWithNoResponse";
        public const string USP_ORG_GET_ENTITIES_BY_ENTITYTYPE_OR_CODE = "usp_ORG_GetOrgEntitiesByEntityTypeOrCode";
        public const string USP_ORG_GET_ENTITYDETAILS_BY_SEARCH_RESULTS = "usp_ORG_GetEntityDetailsBySearchResults";
        public const string USP_ORG_GET_ORGENTITY_MANAGERS = "usp_ORG_GetOrgEntityManagers";
        public const string USP_ORG_GET_ENTITY_DETAILS = "usp_ORG_GetEntityDetails";
        public const string USP_ORG_GETLOBANDACCESSCONTROLENTITYDETAILS = "usp_ORG_GetLOBAndAccessControlEntityDetails";

        #endregion Platform SP's

        #region Platform Constants

        public const string COL_CONTACT_TYPE = "ContactType";
        public const string COL_SETTING_CONFIGURATION_ID = "SettingConfigurationId";
        public const string COL_BASIC_SETTING_DETAILS_ID = "BasicSettingDetailsId";
        public const string COL_CONTACT_ID = "ContactId";
        public const string COL_BASIC_SETTING_DETAILS = "BasicSettingDetails";
        public const string COL_OBJECT_TYPE = "ObjectType";

        #region Portal

        public const string COL_TAX_ID = "TaxId";
        public const string COL_TAX_TYPE_ID = "TaxTypeId";
        public const string COL_TAX_DESCRIPTION = "TaxDescription";
        public const string COL_COUNTRY_ID = "CountryId";
        public const string COL_STATE_CODE = "StateCode";
        public const string COL_ISDELETED = "IsDeleted";
        public const string COL_CreatedBy = "CreatedBy";
        public const string COL_DateCreated = "DateCreated";
        public const string COL_TOTALRECORDS = "TotalRecords";
        public const string COL_IS_INCLUDE_SHIPPING = "IsIncludeShipping";

        #endregion Portal

        #region PartnerManagement

        public const string COL_TABNAME = "TabName";
        public const string COL_TABORDER = "TabOrder";
        public const string COL_DATECREATED = "DateCreated";
        public const string COL_MODIFIEDBY = "ModifiedBy";
        public const string COL_DATEMODIFIED = "DateModified";

        #endregion PartnerManagement

        #region QuestionBank

        public const string COL_QUESTION_TYPE_DESCRIPTION = "QuestionTypeDescription";

        public const string COL_QUESTION_ID = "QuestionId";
        public const string COL_QUESTION_TYPE_ID = "QuestionTypeId";
        public const string COL_QUESTION_SET_CODE = "QuestionSetCode";
        public const string COL_QUESTION_TEXT = "QuestionText";
        public const string COL_QUESTION_DESCRIPTION = "QuestionDescription";
        public const string COL_QUESTION_TYPE_NAME = "QuestionTypeName";
        public const string COL_AUTOSCORED = "AutoScored";
        public const string COL_IS_ALLOWCOMMENT = "IsAllowComment";
        public const string COL_IS_ALLOWATTACHMENT = "IsAllowAttachment";
        public const string COL_IS_MANDATORY = "IsMandatory";
        public const string COL_MANDATORY_QUESTION_ERROR_MESSAGE = "MandatoryQuestionErrorMessage";
        public const string COL_SORT_ORDER = "SortOrder";
        public const string COL_IS_INFORMATIVE = "IsInformative";
        public const string COL_QUESTION_WEIGHT = "QuestionWeight";
        public const string COL_ISWEIGHTLOCK = "IsWeightLock";
        public const string COL_NOOFATTACHMENT = "NoOfAttachment";
        public const string COL_VISIBLE_TO = "VisibleTo";
        public const string COL_EDITABLEBY = "EditableBy";
        public const string COL_DOES_VALIDATE_TEXT = "DoesValidateText";
        public const string COL_TEXT_FORMAT_TYPE = "TextFormatType";
        public const string COL_TEXT_FORMAT_RANGE_MIN = "TextFormatRangeMin";
        public const string COL_TEXT_FORMAT_RANGE_MAX = "TextFormatRangeMax";
        public const string COL_TEXT_INVALID_FORMAT_ERROR_MESSAGE = "TextInvalidFormatErrorMessage";
        public const string COL_TEXT_FORMULA = "Formula";
        public const string COL_DATETIME_TYPE = "DateTimeType";
        public const string COL_DATETIME_FORMAT = "DateTimeFormat";
        public const string COL_MAX_FILE_SIZE_IN_MB = "MaxFileSizeInMB";
        public const string COL_FILE_TYPE_FILTER = "FileTypeFilter";
        public const string COL_PARENTQUESTIONID = "ParentQuestionID";
        public const string COL_PARENTQUESTIONSETCODE = "ParentQuestionSetCode";
        public const string COL_ROW_ID = "RowId";
        public const string COL_ROW_TEXT = "RowText";
        public const string COL_ROW_DESCRIPTION = "RowDescription";
        public const string COL_CHILD_QUESTION_SET_CODE = "ChildQuestionSetCode";
        public const string COL_ROW_SCORE = "RowScore";
        public const string COL_SORT_RANDOMIZE = "SortRandomize";
        public const string COL_ONE_RESPONSE_PER_COLUMN = "OneResponsePerColumn";
        public const string COL_COLUMN_ID = "ColumnId";
        public const string COL_COLUMN_DESCRIPTION = "ColumnDescription";
        public const string COL_COLUMN_TEXT = "ColumnText";
        public const string COL_COLUMNTYPE = "ColumnType";
        public const string COL_COLUMN_SCORE = "ColumnScore";
        public const string COL_CHOICE_SCORE = "ChoiceScore";
        public const string COL_CELL_CHOICE_ID = "CellChoiceId";
        public const string COL_CHOICE_VALUE = "ChoiceValue";
        public const string COL_IS_DEFAULT = "IsDefault";
        public const string COL_SORT_RANDOMIZE_CHOICES = "SortRandomizeChoices";
        public const string COL_ATTACHMENTID = "AttachmentId";
        public const string COL_FILENAME = "FileName";
        public const string COL_UPLOADEDDATE = "UploadedDate";
        public const string COL_SCOREVALUE = "ScoreValue";
        public const string COL_FIELD_ID = "FieldId";

        #endregion QuestionBank

        #region GEP.Cumulus.OrganizationStructure

        public const string COL_ENTITY_NAME = "EntityName";
        public const string COL_PARENT_ENTITY_CODE = "ParentEntityCode";
        public const string COL_IS_ACTIVE = "IsActive";
        public const string COL_LOB_ENTITY_DETAIL_CODE = "LOBEntityDetailCode";
        public const string COL_LOBCODE = "LobCode";
        public const string COL_LOBNAME = "LOBName";
        public const string COL_ENTITY_DESCRIPTION = "EntityDescription";

        public const string COL_MANAGERCODES = "ManagerCodes";
        public const string COL_CURRENCYCODE = "CurrencyCode";
        public const string COL_THRESHOLDAMOUNT = "ThresholdAmt";
        public const string COL_GEPMANAGERCODES = "GEPManagerCodes";
        public const string COL_COMPANY_CODE_ID = "CompanyCodeId";
        public const string COL_COMPANY_CODE_DESCRIPTION = "CompanyCodeDescription";
        public const string COL_ADDRESS_CODE = "AddressCode";
        public const string COL_DATE_START = "DateStart";
        public const string COL_DATE_END = "DateEnd";
        public const string COL_ASSOCIATION_TYPE = "AssociationType";
        public const string COL_IS_BRIDGE = "IsBridge";
        public const string COL_HAS_MAPPING = "HasMapping";
        public const string COL_LOBID = "LOBId";
        public const string COL_ACCESSCREATEENTITYID = "ACEntityID";
        public const string COL_CULTURECode = "CultureCode";
        public const string COL_ACCESSCREATEENTITYNAME = "ACEName";

        #endregion GEP.Cumulus.OrganizationStructure

        #endregion Platform Constants

        #region LWF

        public const string USP_LWF_GET_WORKFLOW_BY_PROPERTY_NAME = "usp_LWF_GetWorkflowByPropertyName";
        public const string COL_CURRENTSTEP = "CurrentStep";
        public const string LWF_GETWORKFLOWBYPROPERTYNAME = "GetWorkflowByPropertyName";

        #endregion LWF

        #region Basic Details Section

        public const string COL_CreatedById = "CreatedById";
        public const string COL_CreatedByName = "CreatedByName";

        #endregion Basic Details Section

        #region "tempstorage"

        public const string USP_P2P_INV_SAVEINVOICEDOCAGGR = "usp_P2P_INV_SaveInvoiceDocAggr";
        public const string USP_P2P_INV_SAVEINVOICEITEMSAGGR = "usp_P2P_INV_SaveInvoiceItemsAggr";

        #endregion "tempstorage"

        #region Platform API Endpoint

        public const string PFTUM_GETUSERDETAILSWITHLOBMAPPINGBYCONTACTCODE = "GetUserDetailsWithLOBMappingByContactCode";
        public const string PFTUM_GETUSERDETAILSWITHLOBMAPPINGBYUSERNAME = "GetUserDetailsWithLOBMappingByUserName";
        public const string PFTUM_GETCONTACTCODESBYORGENTITYCODE = "GetContactCodesByORGEntityCode";
        public const string PFTUM_GETCONTACTSBYCONTACTCODE = "GetContactsByContactCode";
        public const string PFTUM_GETBUYERUSERACTIVITIESBYCONTACTCODE = "GetBuyerUserActivitiesByContactCode";
        public const string PFTUM_GETCONTACTSFORGROUP = "GetContactsForGroup";
        public const string PFTUM_GETUSERDETAILSBYCONTACTCODES = "GetUserDetailsByContactCodes";

        #endregion Platform API Endpoint

        #region Partner API Endpoint

        public const string PFTUM_GETCONTACTPREFERENCEBYCONTACTCODE = "GetContactPreferenceByContactCode";
        public const string PFTUM_GETUSERSBASEDONACTIVITYCODE = "GetUsersBasedOnActivityCode";
        public const string PFTUM_GETCONTACTBYCONTACTCODE = "GetContactByContactCode";
        public const string PFTUM_GETBUYERSUPPLIERSAUTOSUGGEST = "GetBuyerSuppliersAutoSuggest";
        public const string PFTFM_DOWNLOADFILEBYFILEURI = "DownloadFilebyFileUri";
        public const string PFTUM_GETALLPARTNERLOCATIONS = "GetAllPartnerLocations";
        public const string PFTUM_GETALLCONTACTSBYPARTNERCODE = "GetAllContactsByPartnerCode";
        public const string PFTUM_GETALLPARTNERLOCATION = "GetAllPartnerLocation";
        public const string PFTUM_GETCONTACTORGMAPPING = "GetContactORGMapping";
        public const string PFTUM_GETPARTNERPAYMENTTERM = "GetPartnerPaymentTerm";
        public const string PFTUM_GETPARTNERPAYMENTTERMBYPAYMENTTERMS = "GetPartnerPaymentTermByPaymentTerms";
        public const string PFTUM_GETCLIENTPARTNERCODEBYPARTNERCODE = "GetClientPartnerCodeByPartnerCode";
        public const string ORD_GETPARTNERDETAILSBYORDERITEMID = "GetPartnerDetailsByOrderItemId";
        public const string IMPX_ADDUPLOADREQUEST = "AddUploadRequest";
        public const string P2PCMN_GETBUDETAILSFORDOCUMENT = "GetBuDetailsForDocument";
        public const string P2POB_UPDATEOPERATIONALBUDGETFUNDSFLOW = "UpdateOperationalBudgetFundsFlow";
        public const string P2PSCI_GETALLSCANNEDINVOICEFILEDETAILS = "GetAllScannedInvoiceFileDetails";
        public const string P2PSCI_GETIMAGEBYDOCUMENTCODE = "GetImageByDocumentCode";
        public const string P2PRCIPT_CREATERECEIPTFROMIR = "CreateReceiptFromIR";
        public const string P2PRCIPT_CREATERECEIPTFROMCONFIRMORDERIR = "CreateReceiptFromConfirmOrderIR";
        public const string P2PDOC_GETALLACCOUNTINGFIELDSDEFAULTVALUES = "GetAllAccountingFieldsDefaultValues";
        public const string P2PDOC_SENDFAILURENOTIFICAITON = "SendFailureNotificaiton";
        public const string P2PCMN_SENDPOAUTOACKNOWLEDGENOTIFICATION = "SendPOAutoAcknowledgeNotification";
        public const string P2PCMN_SENDNOTIFICATIONONINVFORPOINSENDTOPARTNER = "SendNotificationOnInvForPOInSendToPartner";
        public const string P2PORD_UPDATEDORDERSTATUS = "UpdatedOrderStatus";
        public const string P2PORD_GETORDERACCOUNTINGDETAILSBYITEMID = "GetOrderAccountingDetailsByItemId";
        public const string P2PORD_GETORDERLINEITEMBASICDETAILS = "GetOrderLineItemBasicDetails";
        public const string P2PORD_CHECKCREATEINVOICEFORORDER = "CheckCreateInvoiceForOrder";
        public const string P2PORD_GETORDERENTITYBYDOCUMENTNUMBER = "GetOrderDetailByDocumentNumber";
        public const string P2PORD_GETSHIPPINGSPLITDETAILSBYORDERITEMID = "GetShippingSplitDetailsByOrderItemId";
        public const string P2PORD_GETORDERDETAILSBYDOCUMENTNUMBERANDSTATUS = "GetOrderDetailByDocumentNumberAndStatus";
        public const string P2PORD_GETORDERENTITYDETAILSBYID = "GetOrderEntityDetailsById";
        public const string P2PORD_UPDATEORDERINVOICINGSTATUSBYID = "UpdateOrderInvoicingStatusById";
        public const string P2PIFTORD_GETORDERDETAILSBYID = "GetOrderDetailsById";
        public const string P2PSCI_SAVESCANNEDIMAGES = "SaveScannedImages";
        public const string P2PSCI_MAPSCANNEDIMAGETOINVOICE = "MapScannedImageToinvoice";
        public const string P2PSCI_UPDATESCANNEDIMAGEBYDOCUMENTCODE = "UpdateScannedImageByDocumentCode";
        public const string P2POB_GETPERIODDATAFORAUTOSUGGEST = "GetPeriodDataForAutoSuggest";
        public const string P2P_CM_GETCREDITMEMOBYINVOICEID = "GetCreditMemoByInvoiceId";
        public const string PFT_FM_GETFILEDETAILSBYFILEID = "GetFileDetailsByFileId";
        public const string P2P_CM_UPDATECREDITMEMOSTATUS = "UpdateCreditMemoStatus";
        public const string P2P_CM_GETCREDITMEMODETAILSBYMEMONUMBERANDSTATUS = "GetCreditMemoDetailsByMemoNumberAndStatus";
        public const string WF_GetContactCodeLastApprovalDetails = "GetContactCodeLastApprovalDetails";
        public const string ORD_GETORDERBASICDETAILSBYID = "GetOrderBasicDetailsById";
        public const string ORD_GETORDERHEADERDETAILSBYID = "GetOrderHeaderDetailsById";
        public const string PRT_GETBUYERSUPPLIERSAUTOSUGGESTFORQUICKCREATE = "GetBuyerSuppliersAutoSuggestForQuickCreate";
        public const string ORDIFT_GETINTERFACEBUYERCONFIGURATION = "GetInterfaceBuyerConfiguration";
        public const string PRT_GETUSERSBASEDONENTITYCODESORPASCODES = "GetUsersBasedOnEntityCodesORPASCodes";
        public const string P2P_GETRECEIPTHEADERADDITIONALFIELD = "GetReceiptHeaderAdditionalFields";
        public const string PRT_GETPARTNERDETAILS = "GetPartnerDetails";
        public const string PFT_FM_UPLOADFILETOTARGETBLOB = "UploadFileToTargetBlob";
        public const string PFT_FM_GETSTORAGEACCOUNTURL = "GetStorageAccountUrl";
        public const string PFT_FM_DOWNLOADFILEBYFILEURI = "DownloadFilebyFileUri";
        public const string ORD_CREATECONFORMINGORDER = "CreateConformingOrder";
        public const string ORD_ACKNOWLEDGEORDER = "AcknowledgeOrder";
        public const string ORD_GETORDERBASICDETAILSFORAPPROVAL = "GetOrderBasicDetailsForApproval";
        public const string ORD_SAVECHANGEORDERREQUEST = "SaveChangeOrderRequest";
        public const string PFT_FM_UNZIPANDUPLOADTOBLOB = "UnzipAndUploadToBlob";
        public const string ORD_GETCHANGEORDERDETAILSBYINVOICEORIR = "GetChangeOrderDetailsByInvoiceOrIR";
        public const string PRT_GETALLPARTNERLOCATIONSBYLOCATIONTYPE = "GetAllPartnerLocationsByLocationType";
        public const string PRT_GETREMITTOLOCATIONSBYORDERINGLOCATIONID = "GetRemitToLocationsByOrderingLocationID";
        public const string PRT_GETPARTNERCODEBYCLIENTPARTNERCODE = "GetPartnerCodeByClientPartnerCode";
        public const string PRT_GetFileUriByFileId = "GetFileUriByFileId";
        public const string PRT_GetContactCodeByClientContactCodeOrEmail = "GetContactCodeByClientContactCodeOrEmail";
        public const string PRT_GetContactAccountingInfoByContactCodeNewAPIEndPoint = "GetUserAuthorityAmountMapping";
        public const string PRT_GetContactAccountingInfoByContactCode = "GetContactAccountingInfoByContactCode";
        public const string PRT_GetAllContactsEmailAutoSuggest = "GetAllContactsEmailAutoSuggest";
        public const string PRT_GetContractUtilizationByOrderId = "GetContractUtilizationByOrderId";
        public const string PRT_GETCONTACTCULTUREANDTIMEZONEINFO = "GetContactCultureAndTimeZoneInfo";
        public const string CTL_GetLineItems = "GetLineItems";
        public const string ORD_ADDORDERINTOSEARCHINDEXERQUEUEING = "AddOrderIntoSearchIndexerQueueing";
        public const string SC_SCSEARCHINDEXER = "SCSearchIndexer";
        public const string DOC_GETDOCUMENTPROXYDETAILSBYACTIVITY = "GetDocumentProxyDetailsByActivity";

        #endregion Partner API Endpoint

        #region WorkFlow API

        public const string WF_UPDATEUSERDEFINEDAPPROVERS = "UpdateUserDefinedApprovers";
        public const string WF_POPULATESTATICAPPROVALS = "PopulateStaticApprovals";
        public const string WF_GETALLAPPROVALDETAILS = "GetAllApprovalDetails";
        public const string WF_RESETALLAPPROVERS = "ResetAllApprovers";
        public const string WF_GETORGMANAGERDETAILSBASEDONENTITIES = "GetOrgManagerDetailsBasedOnEntities";
        public const string WF_GETUSERDEFINEDAPPROVERS = "GetUserDefinedApprovers";
        public const string WF_ISAPPROVALPENDINGFORUSER = "IsApprovalPendingForUser";
        public const string WF_GetActionersList = "GetActionersList";
        public const string WF_INVOKEWORKFLOW = "InvokeWorkFlow";
        public const string WF_GETDOCUMENTINSTANCEIDACTIVE = "GetDocumentInstanceIdActive";
        public const string WF_UPDATEAPPROVALDOCUMENTINSTANCESTATUS = "UpdateApprovalDocumentInstanceStatus";

        public const string WF_WithdrawDocument = "WithdrawDocument";
        public const string WF_ReceiveNotification = "ReceiveNotification";

        #endregion WorkFlow API

        #region Comment API

        public const string CM_GetComments = "GetComments";
        public const string CM_SaveComment = "SaveComment";
        public const string CM_FinalizeComments = "FinalizeComments";
        public const string CM_SaveCommentAttachments = "SaveCommentAttachments";
        public const string CM_GetAttachmentIdsByCommentGroupIds = "GetAttachmentIdsByCommentGroupIds";

        #endregion Comment API

        #region CSM APIs

        public const string CSM_GetCurrencyAutoSuggest = "GetCurrencyAutoSuggest";
        public const string CSM_GetEntityNumber = "GetEntityNumber";
        public const string CSM_GetDefaultCurrencyExchangeRateByConversionDate = "GetDefaultCurrencyExchangeRateByConversionDate";
        public const string CSM_GetAllPaymentTermsForEntityCode = "GetAllPaymentTermsForEntityCode";
        
        #endregion CSM APIs

        #region QueryString Parameters

        public const string ACTIVITYCODES = "activityCodes";
        public const string SEARCHTEXT = "SearchText";
        public const string PAGEINDEX = "PageIndex";
        public const string PAGENO = "pageno";
        public const string PAGESIZE = "pageSize";
        public const string PageSize = "PageSize";
        public const string FILEURI = "fileUri";
        public const string BUYERPARTNERCODE = "buyerPartnerCode";
        public const string BuyerPartnerCode = "BuyerPartnerCode";
        public const string SearchFilterSetting = "SearchFilterSetting";
        public const string ORGENTITYCODES = "OrgEntityCodes";
        public const string CLIENTLOCATIONCODE = "clientLocationCode";
        public const string REGIONID = "RegionId";
        public const string SORTDIRECTION = "SortDirection";
        public const string SORTNAME = "SortName";
        public const string UPDATEDRAFTPROFILECOPY = "UpdateDraftProfileCopy";
        public const string HIERARCHY = "hierarchy";
        public const string PAYMENTTERMS = "paymentTerms";
        public const string PARTNERCODE = "partnerCode";
        public const string CULTURECODE = "cultureCode";
        public const string ORDERITEMID = "orderItemId";
        public const string IMAGEID = "imageId";
        public const string INVOICEID = "invoiceId";
        public const string FIELDID = "fieldId";
        public const string DOCUMENTCODE = "documentCode";
        public const string DOCUMENTTYPE = "documentType";
        public const string ITEMTYPE = "itemType";
        public const string STARTINDEX = "startIndex";
        public const string SORTBY = "sortBy";
        public const string SORTORDER = "sortOrder";
        public const string TYPEOFUSER = "typeOfUser";
        public const string SEARCHINFIELD = "searchInField";
        public const string SEARCHFOR = "searchFor";
        public const string ORDERID = "orderId";
        public const string ISDELTAREQUIRED = "isDeltaRequired";
        public const string FILEID = "fileId";
        public const string CREDITMEMOID = "creditMemoId";
        public const string MAXPRECISIONVALUE = "maxPrecisionValue";
        public const string MAXPRECISIONVALUEFORTAXESANDCHARGES = "maxPrecisionValueForTaxesAndCharges";
        public const string MAXPRECISIONVALUEFORTOTAL = "maxPrecisionValueForTotal";
        public const string DOCUMENTSTATUS = "documentStatus";
        public const string USERID = "userId";
        public const string CREDITMEMONUMBER = "creditMemoNumber";
        public const string ISPARTNERCREDITMEMONUMBER = "isPartnerCreditMemoNumber";
        public const string CREDITMEMOSTATUS = "creditMemoStatus";
        public const string CREDITMEMOEXTENDEDSTATUS = "creditMemoExtendedStatus";
        public const string SOURCESYSTEMID = "sourceSystemId";
        public const string PARTNERSTATUS = "PartnerStatus";
        public const string SUPPLIERPARTNERCODE = "supplierPartnerCode";
        public const string ENTITY = "entity";
        public const string DIRECTION = "direction";
        public const string DOCUMENTID = "documentId";
        public const string CLIENTPARTNERCODE = "clientPartnerCode";
        public const string SOURCESYSTEMNAME = "sourceSystemName";
        public const string THRESHOLDAMT = "ThresholdAmt";
        public const string PASCODES = "PasCodes";
        public const string CURRENCYCODE = "CurrencyCode";
        public const string ORDERNUMBER = "ordernumber";
        public const string DOCSTATUS = "docStatus";
        public const string REJECTIONSTATUS = "rejectionStatus";
        public const string LOBENTITYDETAILSCODE = "LOBentityDetailsCode";
        public const string CONTACTCODES = "ContactCodes";
        public const string OLOC = "oloc";

        #endregion QueryString Parameters

        public const string USP_P2P_IR_HASORDERISDELETED = "usp_p2p_IR_HasOrderIsDeleted";
        public const string commentOnIRCancellationWhileSentForPayment = "This Invoice Reconciliation document is cancelled, as the corresponding Invoice was send for payment";
        public const string USP_CSM_GETALLSTATES = "usp_CSM_GetAllStates";
        public const string USP_CSM_GETALLCOUNTRIES = "usp_CSM_GetAllCountries";
        public const string USP_INT_GETALLLOCATIONTYPES = "usp_INT_GetAllLocationTypes";

        public const string usp_P2P_IR_GETALLLINEITEMSBYIRID = "usp_P2P_IR_GetAllLineItemsByIRId";
        public const string COL_SPLITQUANTITY = "SplitQuantity";
        public const string USP_P2P_IR_GETALLAPPROVALDETAILS = "usp_P2P_IR_GetAllApprovalDetails";

        #region IR Approval Columns

        public const string COL_IRNAME = "IRName";
        public const string COL_IRNUMBER = "IRNumber";
        public const string COL_TOTALVALUE = "TotalValue";
        public const string COL_SUPPLIERINVOICENUMBER = "SupplierInvoiceNumber";
        public const string COL_InvoiceCreationDate = "InvoiceCreationDate";
        public const string COL_IRCreationDate = "IRCreationDate";
        public const string COL_Currency = "Currency";
        public const string COL_BUYERPHONE1 = "BuyerPhone1";
        public const string COL_BUYERPHONE2 = "BuyerPhone2";
        public const string COL_ORDERINGLOCATION = "OrderingLocation";
        public const string COL_IRID = "IRId";

        #endregion IR Approval Columns

        public const string USP_P2P_INV_SAVEINVOICEITEMSFROMORDERANDSERVICECONFIRMATIONTOINVOICE = "usp_P2P_INV_SaveInvoiceItemsFromOrderAndServiceConfirmationToInvoice";

        #region AcceptanceDelegation

        public const string USP_P2P_IR_ADDDELEGATIONFORIRACCEPTANCE = "usp_P2P_IR_AddDelegationForIRAcceptance";
        public const string COL_DEL_ISDELETED = "isDeleted";

        #endregion AcceptanceDelegation

        public const string USP_P2P_INV_UPDATEFULFILMENTDOCUMENTMAPPING = "usp_P2P_INV_UpdateFulfilmentDocumentMapping";

        #region Compliance Validation Messages

        public const string DATAINVALIDMESSAGE = "Data invalid  to perform validations";
        public const string COMPLIANCEVALIDATIONMESSAGE = "Invalid compliance setup for the specified country";

        #endregion Compliance Validation Messages

        #region Constant for Invoice Excel smart flow integration

        public const string INITIATESMARTFLOWENGINE = "InitiateSmartFlow";
        public const string APPROVEPENDINGREQUESTASYNC = "ApprovePendingRequestAsync";
        public const string SMARTFLOWSAVEINVOICEITEM = "SmartFlowSaveInvoiceItem";
        public const string USP_P2P_INV_UPDATEINVOICEITEMPROCESSINGDETAILS = "usp_P2P_INV_UpdateInvoiceItemProcessingDetails";
        public const string USP_P2P_INV_UPDATEINVOICEPROCESSINGDETAILS = "usp_P2P_INV_UpdateInvoiceProcessingDetails";
        public const string USP_P2P_INV_GETINVOICEITEMPROCESSINGDETAILS = "usp_P2P_INV_GetInvoiceItemProcessingDetails";
        public const string USP_P2P_INV_GETINVOICEPROCESSINGDETAILS = "usp_P2P_INV_GetInvoiceProcessingDetails";
        public const string COL_STARTTIME = "StartTime";
        public const string COL_ENDTIME = "EndTime";
        public const string COL_HEADERLEVELERRORDIRECTORY = "HeaderLevelErrorDirectory";
        public const string COL_FILEPATH = "FilePath";
        public const string COL_ITEMCHUNKDIRECTORY = "ItemChunkDirectory";
        public const string COL_ITEMCHUNKGUIDID = "ItemChunkGuidId";
        public const string COL_INVOICEPROCESSINGDIRECTORY = "InvoiceProcessingDirectory";
        public const string USP_P2P_GETALLINVOICEFORSMARTFLOWTRANSACTION = "usp_p2p_GetAllInvoiceForSmartFlowTransaction";
        public const string USP_P2P_INV_GETEXCELFILEPROCESSINGSTATUS = "usp_p2p_Inv_GetExcelFileProcessingStatus";
        public const string COL_NUMBEROFINVOICES = "NumberOfInvoices";
        public const string COL_BATCHCOUNT = "BatchCount";

        #endregion Constant for Invoice Excel smart flow integration

        #region Has Proceesed Invoice check

        public const string USP_P2P_INV_HASPROCESSEDINVOICE = "usp_P2P_INV_HasProcessedInvoice";

        #endregion Has Proceesed Invoice check

        #region Get invoices for processing 

        public const string USP_P2P_INV_GETINVOICESFORAUTOIRPROCESSING = "USP_P2P_INV_GETINVOICESFORAUTOIRPROCESSING";
        public const string USP_P2P_INV_SAVEAUTOIRREQUEST = "usp_P2P_INV_SaveAutoIRRequest";
        public const string USP_P2P_INV_GETAUTOIRREQUEST = "usp_P2P_INV_GetAutoIRRequest";

        #endregion Get invoices for processing 


    }
}