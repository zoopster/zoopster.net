using System.Web.Mvc;

namespace ExpressMVC.Models.Blog
{
    public class AddBlogCommentModel
    {
        [AllowHtml]
        public string CommentText { get; set; }
    }
}