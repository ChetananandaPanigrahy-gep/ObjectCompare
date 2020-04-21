using System;
using System.Collections.Generic;
using System.Text;

namespace GEP.SMART.Invoice.BusinessEntities.CommentsEntities
{
    public class SaveCommentAttachmentsRequest
    {
        public int CommentID { get; set; }
        public List<long> FileManagerFileIDs { get; set; }
    }
}
