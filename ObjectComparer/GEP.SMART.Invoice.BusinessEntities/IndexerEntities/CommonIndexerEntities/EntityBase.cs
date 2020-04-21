using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.SearchIndexerEntities
{
    public abstract class EntityBase : ESEntityBase //: IOrg
    {
        //public abstract long Code { get; }
        //public abstract string Name { get; }
        //public virtual bool IsDeleted { get; set; }
        public virtual bool IsBulkIndexed { get; set; }

        public virtual string Tag { get; set; }
        public virtual double? Score { get; set; }
        public virtual long? BuyerPartnerCode { get; set; }

        //public virtual string CategoryCodesCSV { get; set; }
        //public virtual string CategoryNamesCSV { get; set; }
        //public virtual string BUCodesCSV { get; set; }
        //public virtual string BUNamesCSV { get; set; }
        //[ElasticProperty(Type = FieldType.Completion)]
        public virtual string DocumentNameForCompletion { get; set; }

        //// IOrg members
        //public virtual ICollection<DocumentCategory> DocumentCategory { get; set; }
        //public virtual ICollection<DocumentBU> DocumentBU { get; set; }

        public DateTime IndexedOn
        {
            get { return DateTime.Now; }
        }

        public override long Code
        {
            get
            {
                if (this is IDocument)
                {
                    if (((IDocument)this).DM_Documents == null) return 0;
                    return ((IDocument)this).DM_Documents.DocumentCode;
                }
                throw new NotImplementedException("Code property not implemented in the inherited class");
                //return default(long);
            }
        }

        public virtual string Name
        {
            get
            {
                if (this is IDocument)
                {
                    if (((IDocument)this).DM_Documents == null) return String.Empty;
                    return ((IDocument)this).DM_Documents.DocumentName;
                }
                throw new NotImplementedException("Name property not implemented in the inherited class");
                //return default(string);
            }
        }

        public virtual bool IsDocDeleted    //IsDeleted is a generic property used in many classes, so to keep this property unique we named it IsDocDeleted.
        {
            get
            {
                if (this is IDocument)
                {
                    if (((IDocument)this).DM_Documents == null) return false;
                    return ((IDocument)this).DM_Documents.IsDeleted;
                }
                throw new NotImplementedException("IsDocDeleted property not implemented in the inherited class");
                //return default(bool);
            }
        }

        public override long Version
        {
            get
            {
                if (this is IDocument)
                {
                    if (((IDocument)this).DM_Documents == null) return 0;
                    return GetMilliseconds(((IDocument)this).DM_Documents.CurrentDate);
                }

                throw new NotImplementedException("Current Date property not implemented in the inherited class");
            }
        }

        public virtual int DocTypeCode
        {
            get
            {
                if (this is IDocument)
                {
                    if (((IDocument)this).DM_Documents == null) return 0;
                    return ((IDocument)this).DM_Documents.DocumentTypeCode;
                }
                throw new NotImplementedException("DocTypeCode property not implemented in the inherited class");
            }
        }

        public virtual long Status
        {
            get
            {
                if (this is IDocument)
                {
                    if (((IDocument)this).DM_Documents == null) return 0;
                    return ((IDocument)this).DM_Documents.DocumentStatus.GetValueOrDefault();
                }
                throw new NotImplementedException("Status property not implemented in the inherited class");
            }
        }

        public List<long> QueueIds { get; set; }

        //protected string validateName(string name)
        //{
        //    return name.Replace('{', '(').Replace("}", ")");
        //}

        protected long GetMilliseconds(DateTime date)
        {
            long ms = 0;
            DateTime dt1970 = new DateTime(1970, 1, 1);
            DateTime current = date;
            TimeSpan span = current - dt1970;
            ms = Convert.ToInt64(span.TotalMilliseconds);
            return ms;
        }
    }
}