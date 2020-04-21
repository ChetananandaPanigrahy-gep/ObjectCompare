using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities.Old
{
    [DataContract]
    [Serializable]
    public enum ErrorStatusEnum
    {
        [EnumMember(Value = "1")]
        UnclearStructure = 1,

        [EnumMember(Value = "2")]
        UnclearImage = 2,

        [EnumMember(Value = "3")]
        UnclearData = 3,

        [EnumMember(Value = "4")]
        TotalCalculationError = 4,

        [EnumMember(Value = "5")]
        DoNotPayInvoice = 5,

        [EnumMember(Value = "6")]
        NoInvoiceTotal = 6,

        [EnumMember(Value = "7")]
        NoVendorId = 7,

        [EnumMember(Value = "8")]
        NoVendorAddress = 8,

        [EnumMember(Value = "9")]
        NoVendorName = 9,

        [EnumMember(Value = "10")]
        NoVendorCity = 10,

        [EnumMember(Value = "11")]
        InvalidPo = 11,

        [EnumMember(Value = "12")]
        POVendorMismatch = 12,

        [EnumMember(Value = "13")]
        MultiplePO = 13,

        [EnumMember(Value = "14")]
        UnclearPOLineMatch = 14,

        [EnumMember(Value = "15")]
        ZeroDollarInvoiceTotal = 15,

        [EnumMember(Value = "16")]
        OutOfDateRange = 16,

        [EnumMember(Value = "17")]
        PastDue = 17,

        [EnumMember(Value = "18")]
        Disconnect = 18,

        [EnumMember(Value = "19")]
        DuplicateInvoiceNumber = 19,

        [EnumMember(Value = "20")]
        Proforma = 20,

        [EnumMember(Value = "21")]
        LineTotalError = 21,

        [EnumMember(Value = "22")]
        NonTransactional = 22,

        [EnumMember(Value = "55")]
        InCorrectLineMapping = 55
    }
}