using System;
using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.CommentsEntities
{
    public class SaveCommentRequest
    {
        public int CommentGroupID { get; set; }

        public string GroupText { get; set; }

        public bool IsDeleted { get; set; }

        public long CreatedBy { get; set; }

        public DateTime DateCreated { get; set; }

        public string ObjectType { get; set; }

        public long ObjectID { get; set; }

        public List<Comment> Comment { get; set; }

        public int TotalComments { get; set; }
    }
}