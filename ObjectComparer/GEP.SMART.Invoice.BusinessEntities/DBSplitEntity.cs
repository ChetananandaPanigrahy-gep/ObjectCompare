using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class DBSplitEntity : SplitEntity
    {
        /// <summary>
        /// Split item id.
        /// </summary>
        [DataMember]
        public Int64 splitItemId { get; set; }

        /// <summary>
        /// GL name.
        /// </summary>
        [DataMember]
        public String glName { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [DataMember]
        public String title { get; set; }

        [DataMember]
        public Int32 AutoSuggestURLId { get; set; }
    }
}