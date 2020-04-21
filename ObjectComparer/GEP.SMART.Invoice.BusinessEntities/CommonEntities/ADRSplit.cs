using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    /// <summary>
    /// This class will contain output of ADR for multipler items or splits with respective idefier
    /// </summary>
    [DataContract]
    [Serializable]
    public class ADRSplit
    {
        #region Constructors

        public ADRSplit()
        {
            this.Splits = new List<SplitAccountingFields>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// type of identifier will be any primitive data type
        /// </summary
        [DataMember]
        public object Identifier { get; set; }

        /// <summary>
        /// Split data
        /// </summary>
        [DataMember]
        public List<SplitAccountingFields> Splits { get; set; }

        /// <summary>
        /// Split details in format of document Split Entities
        /// </summary
        [DataMember]
        public List<DocumentSplitItemEntity> docSplitEntities
        {
            get
            {
                var a = new List<DocumentSplitItemEntity>();
                this.Splits.ForEach(k =>
                {
                    var DocumentSplitItemEntity = new DocumentSplitItemEntity();
                    DocumentSplitItemEntity.SplitAccountingFieldId = k.SplitAccountingFieldId;
                    DocumentSplitItemEntity.SplitAccountingFieldValue = Convert.ToString(k.EntityDetailCode);
                    DocumentSplitItemEntity.EntityCode = k.EntityCode;
                    DocumentSplitItemEntity.EntityTypeId = k.EntityTypeId;
                    a.Add(DocumentSplitItemEntity);
                });
                return a;
            }
        }

        #endregion Properties
    }
}