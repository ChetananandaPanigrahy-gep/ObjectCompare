using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class BasicDetails
    {
        public BasicDetails()
        {
            OrderNumberObj = new OrderInfo() { OrderName = "", OrderNumber = "" };
            Partner = new Partner() { Name = "", DisplayName = "", Value = "" };
            InvoiceNumber = "";
            ClientPartnerCode = "";
        }

        public List<Gep.Cumulus.Partner.Entities.UserLOBMapping> ServingLOBs { get; set; }
        public IdAndName InterfaceStatus { get; set; }
        public DateTime? InterfaceDate { get; set; }
        public string InterfaceComment { get; set; }
        public int IsMultiDocInvoice { get; set; }
        public List<DocumentBU> DocumentBU { get; set; }
        public int IdentificationId { get; set; }
        public long DocumentCode { get; set; }
        public Partner Partner { get; set; }
        public string InvoiceName { get; set; }
        public DocumentLOB DocumentLOB { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal? InvoiceTotalAmount { get; set; }
        public string PartnerInvoiceNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? PartnerInvoiceDate { get; set; }
        public DateTime ReceivedDate { get; set; }
        public bool NonPOInvoice { get; set; }
        public OrderInfo OrderNumberObj { get; set; }
        public IdAndName OrderPartner { get; set; }
        public string ClientPartnerCode { get; set; } // this field is already available in Partner
        public CodeAndName Currency { get; set; }
        public string ERPInvoiceNumber { get; set; }
        public IdAndName PurchaseType { get; set; } // Pending work
        public IdAndName Type { get; set; } // document type
        public IdAndName Source { get; set; } // document source type
        public IdAndName Status { get; set; } // document status
        public List<VATValues> VatValues { get; set; }
        public List<SplitAccountingFields> HeaderSplitAccountingFields { get; set; }
        public List<KeyValuePair<string, string>> InvoiceActionMenu { get; set; }
        public int InvoiceCreator { get; set; }
        public IdAndName DocumentExtendedStatus { get; set; }
        public List<InvoiceMatchStatus> MatchStatus { get; set; }
        public long ImageId { get; set; }
        public long OldImageId { get; set; }
        public bool HasComments { get; set; }
        public int FulfilmentDocumentType { get; set; }
        public string FulfilmentDocumentNumber { get; set; }
        public string FulfilmentDocumentStatus { get; set; }
        public int POFulfillmentDocumentType { get; set; }
        public List<Cumulus.Documents.Entities.DocumentStakeHolder> DocumentStakeHolderList { get; set; }
        public InvoiceComplianceStatus ComplianceStatus { get; set; }
        public InvoiceCompliance InvoiceCompliance { get; set; }
        public IdNameAndAddress RemittoLocation { get; set; } //For Invoice Compliance
        public InvoiceArchivalStatus ArchivalStatus { get; set; }
        public Int64 OrderContactCode { get; set; }
        public int InvoiceCreationSource { get; set; }

        #region Missing Entities

        public List<Tax> TaxItems { get; set; } //-P
        public IdAndName CreatedBy { get; set; }
        public decimal Tax { get; set; }
        public decimal Shipping { get; set; }
        public decimal OtherCharges { get; set; }
        public decimal Total { get; set; }
        public decimal ItemTotal { get; set; }
        public bool IsDocumentNumberUpdatable { get; set; } //-P
        public string ExistingDocumentNumber { get; set; } //-P
        public IdAndName InvoiceOrigin { get; set; }
        public bool IsERS { get; set; }
        public string DeliveryNoteNumber { get; set; }
        public string OrderName { get; set; }
        public decimal OrderTotal { get; set; } //-P
        public DateTime OrderDate { get; set; } //-P
        public IdAndName OrderStatus { get; set; } //-P
        public decimal AmountDifferenceBetweenOrderInvoice { get; set; } //-P
        public int OrderSourceSystemId { get; set; }
        public Int32 OrderPaymentTermId { get; set; }
        public long IsOrderAndInvoiceContactSame { get; set; } //-P
        public long IsOrderAndInvoiceCurrencySame { get; set; }
        public OnEvent OnEvent { get; set; } //-P
        public List<long> OrderIdList { get; set; } //-P
        public DateTime? ScheduledPaymentDate { get; set; }
        public decimal? TotalCharge { get; set; }

        #endregion Missing Entities

        #region For MULTI PO

        public List<OrderInfo> SelectedPOList { get; set; }

        #endregion For MULTI PO

        #region Custom attributes related properties

        public List<IdAndName> CustomAttrQuestionSetCodesForHeader { get; set; }
        public List<IdAndName> CustomAttrQuestionSetCodesForItem { get; set; }
        public long CustomAttrFormIdForHeader { get; set; }
        public long CustomAttrFormIdForItem { get; set; }
        public long CustomAttrFormIdForSplit { get; set; }

        #endregion Custom attributes related properties
    }
}