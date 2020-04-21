using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class Questionnaire
    {
        /// <summary>
        /// Entity - QuestionnaireCode has type integer
        /// </summary>
        [DataMember]
        public long QuestionnaireCode { get; set; }

        /// <summary>
        /// Entity - QuestionnaireTitle has type nvarchar
        /// </summary>
        [DataMember]
        public string QuestionnaireTitle { get; set; }

        /// <summary>
        /// Entity - QuestionnaireOrder has type integer
        /// </summary>
        [DataMember]
        public int QuestionnaireOrder { get; set; }

        /// <summary>
        /// Entity - IsSupplierVisible has type bit
        /// </summary>
        [DataMember]
        public bool IsSupplierVisible { get; set; }

        /// <summary>
        /// Entity - IsInformative has type bit
        /// </summary>d
        [DataMember]
        public bool IsInformative { get; set; }

        /// <summary>
        /// Entity - Weightage has type float
        /// </summary>
        [DataMember]
        public double Weightage { get; set; }

        [DataMember]
        public List<QuestionnaireResponse> QuestionnaireResponseValues { get; set; }

        [DataMember]
        public int TabId { get; set; }

        [DataMember]
        public long FormCode { get; set; }

        [DataMember]
        public long QuestionId { get; set; }
    }
}