using System;
using System.Collections.Generic;
using System.Text;

namespace GEP.SMART.Invoice.BusinessEntities.CommentsEntities
{
    public class GetAttachmentIdsByCommentGroupIdsResponseEntity
    {
        public int CommentGroupId { get; set; }
        public List<long> AttachmentIds { get; set; }
    }
}
