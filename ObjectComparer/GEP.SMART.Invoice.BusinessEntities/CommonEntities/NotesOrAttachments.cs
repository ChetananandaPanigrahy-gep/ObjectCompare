using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(SourceType))]
    [KnownType(typeof(NoteOrAttachmentType))]
    [KnownType(typeof(NoteOrAttachmentAccessType))]
    [System.Xml.Serialization.XmlInclude(typeof(SourceType))]
    [System.Xml.Serialization.XmlInclude(typeof(NoteOrAttachmentType))]
    [System.Xml.Serialization.XmlInclude(typeof(NoteOrAttachmentAccessType))]
    public class NotesOrAttachments
    {
        [DataMember]
        public long NotesOrAttachmentId { get; set; }

        [DataMember]
        public long DocumentCode { get; set; }

        [DataMember]
        public long LineItemId { get; set; }

        [DataMember]
        public Nullable<long> FileId { get; set; }

        [DataMember]
        public string NoteOrAttachmentName { get; set; }

        [DataMember]
        public string NoteOrAttachmentDescription { get; set; }

        [DataMember]
        public NoteOrAttachmentType NoteOrAttachmentType { get; set; }

        [DataMember]
        public string NoteOrAttachmentTypeName { get; set; }

        [DataMember]
        public NoteOrAttachmentAccessType AccessTypeId { get; set; }

        [DataMember]
        public SourceType SourceType { get; set; }

        [DataMember]
        public bool IsEditable { get; set; }

        [DataMember]
        public int CategoryTypeId { get; set; }

        [DataMember]
        public long CreatedBy { get; set; }

        [DataMember]
        public string CreatorName { get; set; }

        [DataMember]
        public DateTime DateCreated { get; set; }

        [DataMember]
        public long ModifiedBy { get; set; }

        [DataMember]
        public DateTime ModifiedDate { get; set; }

        [DataMember]
        public decimal FileSize { get; set; }

        [DataMember]
        public string CategoryTypeName { get; set; }

        [DataMember]
        public string FilePath { get; set; }

        [DataMember]
        public byte DocumentType { get; set; }

        [DataMember]
        public long P2PLineItemID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings"), DataMember]
        public string FileUri { get; set; }
    }
}