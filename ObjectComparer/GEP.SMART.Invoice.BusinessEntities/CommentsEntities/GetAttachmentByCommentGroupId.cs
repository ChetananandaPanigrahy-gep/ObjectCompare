using System;
using System.Collections.Generic;
using System.Text;

namespace GEP.SMART.Invoice.BusinessEntities.CommentsEntities
{
    public class GetAttachmentIdsByCommentGroupIdsRequest
    {
        public List<int> CommentGroupIds { get; set; }
    }
}
