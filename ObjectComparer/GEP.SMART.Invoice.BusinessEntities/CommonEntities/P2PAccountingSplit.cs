using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    /// <summary>
    /// Class for accounting splits across P2P documents.
    /// </summary>
    [DataContract]
    [Serializable]
    [KnownType(typeof(IdAndName))]
    [System.Xml.Serialization.XmlInclude(typeof(IdAndName))]
    public abstract class P2PAccountingSplit
    {
        /// <summary>
        /// Split item Id.
        /// </summary>
        [DataMember]
        public Int64 id { get; set; }

        /// <summary>
        /// Document code.
        /// </summary>
        [DataMember]
        public Int64 documentCode { get; set; }

        /// <summary>
        /// Document item id.
        /// </summary>
        [DataMember]
        public Int64 documentItemId { get; set; }

        /// <summary>
        /// Quantity.
        /// </summary>
        [DataMember]
        public Double? quantity { get; set; }

        /// <summary>
        /// Additional Charges.
        /// </summary>
        [DataMember]
        public Decimal? additionalCharges { get; set; }

        /// <summary>
        /// Additional Charges.
        /// </summary>
        [DataMember]
        public Decimal percentage { get; set; }

        /// <summary>
        /// Additional Charges.
        /// </summary>
        [DataMember]
        public Decimal? shippingCharges { get; set; }

        /// <summary>
        /// Additional Charges.
        /// </summary>
        [DataMember]
        public Decimal? splitItemTotal { get; set; }

        /// <summary>
        /// Additional Charges.
        /// </summary>
        [DataMember]
        public Decimal? tax { get; set; }

        /// <summary>
        /// Craeted date.
        /// </summary>
        [DataMember]
        public DateTime? createdOn { get; set; }

        /// <summary>
        /// Last updated date.
        /// </summary>
        [DataMember]
        public DateTime? lastModifiedOn { get; set; }

        /// <summary>
        /// Created by user.
        /// </summary>
        [DataMember]
        public IdAndName createdBy { get; set; }

        /// <summary>
        /// Last updated by user.
        /// </summary>
        [DataMember]
        public IdAndName lastModifiedBy { get; set; }

        /// <summary>
        /// Accounting Error code
        /// </summary>
        [DataMember]
        public string errorCode { get; set; }

        /// <summary>
        /// Delete Split flag
        /// </summary>
        [DataMember]
        public bool isDeleted { get; set; }

        /// <summary>
        /// Requester.
        /// </summary>
        [DataMember]
        public SplitEntity requester { get; set; }

        /// <summary>
        /// Requester.
        /// </summary>
        [DataMember]
        public SplitEntity gLCode { get; set; }

        /// <summary>
        /// Requester.
        /// </summary>
        [DataMember]
        public SplitEntity period { get; set; }

        /// <summary>
        /// Split entity 1.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity1 { get; set; }

        /// <summary>
        /// Split entity 2.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity2 { get; set; }

        /// <summary>
        /// Split entity 3.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity3 { get; set; }

        /// <summary>
        /// Split entity 4.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity4 { get; set; }

        /// <summary>
        /// Split entity 5.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity5 { get; set; }

        /// <summary>
        /// Split entity 6.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity6 { get; set; }

        /// <summary>
        /// Split entity 7.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity7 { get; set; }

        /// <summary>
        /// Split entity 8.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity8 { get; set; }

        /// <summary>
        /// Split entity 9.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity9 { get; set; }

        /// <summary>
        /// Split entity 10.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity10 { get; set; }

        /// <summary>
        /// Split entity 11.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity11 { get; set; }

        /// <summary>
        /// Split entity 12.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity12 { get; set; }

        /// <summary>
        /// Split entity 13.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity13 { get; set; }

        /// <summary>
        /// Split entity 14.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity14 { get; set; }

        /// <summary>
        /// Split entity 15.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity15 { get; set; }

        /// <summary>
        /// Split entity 16.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity16 { get; set; }

        /// <summary>
        /// Split entity 17.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity17 { get; set; }

        /// <summary>
        /// Split entity 18.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity18 { get; set; }

        /// <summary>
        /// Split entity 19.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity19 { get; set; }

        /// <summary>
        /// Split entity 20.
        /// </summary>
        [DataMember]
        public SplitEntity splitEntity20 { get; set; }

        /// <summary>
        /// Custom Attribues
        /// </summary>
        [DataMember]
        public List<GEP.Cumulus.QuestionBank.Entities.QuestionResponse> SplitCustomAttribs { get; set; }

        /// <summary>
        /// Accounting Error code
        /// </summary>
        [DataMember]
        public string extendedErrorCode { get; set; }

        /// <summary>
        /// ADR call
        /// </summary>
        [DataMember]
        public bool isADREnabel { get; set; }

        [DataMember]
        public int SplitType { get; set; }

        [DataMember]
        public decimal OverallLimitSplitItem { get; set; }

        /// <summary>
        /// Dynamic SplitEntity object
        /// </summary>
        [DataMember]
        public List<DBSplitEntity> SplitEntities { get; set; }
    }
}