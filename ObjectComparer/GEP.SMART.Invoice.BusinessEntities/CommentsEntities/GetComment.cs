using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.CommentsEntities
{
    public class GetComment
    {
        public int CommentID { get; set; }

        public string CommentText { get; set; }

        public int CommentGroupID { get; set; }

        public bool IsDeleted { get; set; }

        public long CreatedBy { get; set; }

        public DateTime DateCreated { get; set; }

        public string CommentType { get; set; }

        public int ParentCommentID { get; set; }

        public string AccessType { get; set; }

        public bool IsSubmitted { get; set; }

        public bool IsDeleteEnable { get; set; }

        public string FirstName { get; set; }

        public string ComapanyName { get; set; }

        public List<GetCommentAttachment> CommentAttachment { get; set; }
    }
}