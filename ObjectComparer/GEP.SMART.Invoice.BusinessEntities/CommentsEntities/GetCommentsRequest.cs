using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.CommentsEntities
{
    public class GetCommentsRequest
    {
        public GetCommentsRequest(List<CommentsGroupRequestModel> commentsGroupRequestModel)
        {
            CommentsGroupRequestModel = commentsGroupRequestModel;
        }

        public List<CommentsGroupRequestModel> CommentsGroupRequestModel { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}