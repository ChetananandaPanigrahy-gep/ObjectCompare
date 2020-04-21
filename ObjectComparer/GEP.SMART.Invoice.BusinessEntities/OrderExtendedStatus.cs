using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public enum OrderExtendedStatus
    {
        [EnumMember(Value = "0")]
        None = 0,

        [EnumMember(Value = "1")]
        PendingTaxCalculation = 1,

        [EnumMember(Value = "2")]
        TaxCalculationFailed = 2,
    }
}