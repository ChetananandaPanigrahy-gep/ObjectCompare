using System;

namespace GEP.SMART.Invoice.BusinessEntities.CommentsEntities
{
    public class CommentAttachment
    {
        public string FileName { get; set; }
        public long CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public long FileID { get; set; }
    }
}