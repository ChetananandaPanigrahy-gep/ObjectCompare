using Gep.Cumulus.CSM.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using QuestionBankEntities = GEP.Cumulus.QuestionBank.Entities;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(SplitType))]
    [KnownType(typeof(QuestionBankEntities.Question))]
    [System.Xml.Serialization.XmlInclude(typeof(SplitType))]
    [System.Xml.Serialization.XmlInclude(typeof(QuestionBankEntities.Question))]
    public class DocumentSplitItems : EntityBase
    {
        [DataMember]
        public long DocumentSplitItemId { get; set; }

        [DataMember]
        public long DocumentItemId { get; set; }

        [DataMember]
        public decimal Percentage { get; set; }

        [DataMember]
        public decimal Quantity { get; set; }

        [DataMember]
        public decimal? Tax { get; set; }

        [DataMember]
        public decimal? ShippingCharges { get; set; }

        [DataMember]
        public decimal? AdditionalCharges { get; set; }

        [DataMember]
        public decimal? SplitItemTotal { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public SplitType SplitType { get; set; }

        [DataMember]
        public string CostObjectEntityCombination { get; set; }

        [DataMember]
        public string ErrorCode { get; set; }

        [DataMember]
        public string CodeCombination { get; set; }

        [DataMember]
        public int UiId { get; set; }

        [DataMember]
        public long CustomAttrFormId { get; set; }

        [DataMember]
        public List<Questionnaire> CustomAttributes { get; set; }

        [DataMember]
        public string UpdatedBy { get; set; }

        [DataMember]
        public string UpdatedVia { get; set; }

        [DataMember]
        public long SplitNumber { get; set; }

        [DataMember]
        public bool IsSplitEntityCodeChanged { get; set; }

        [DataMember]
        public decimal OverallLimitSplitItem { get; set; }
    }
}