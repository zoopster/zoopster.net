using System;
using System.Collections.Generic;

namespace ExpressMVC.Models.Blog
{
    public partial class CommentModel : EntityModelBase
    {
        public CommentModel()
        {
            this.Childs = new List<CommentModel>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAvatarUrl { get; set; }
        public string CommentTitle { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedOnPretty { get; set; }

        public List<CommentModel> Childs { get; set; }
    }

    public partial class CommentListModel : EntityModelBase
    {
        public CommentListModel()
        {
            Comments = new List<CommentModel>();
        }

        public List<CommentModel> Comments { get; set; }
    }
}