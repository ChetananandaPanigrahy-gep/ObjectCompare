using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities.CommentsEntities
{
    public class CommentsRequestModel
    {
        public CommentsRequestModel(List<CommentsGroupRequestModel> commentsGroupRequestModel)
        {
            CommentsGroupRequestModel = commentsGroupRequestModel;
        }

        public List<CommentsGroupRequestModel> CommentsGroupRequestModel { get; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}