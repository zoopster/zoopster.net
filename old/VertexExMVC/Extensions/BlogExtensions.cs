using ExpressMVC.Models.Blog;
using ExpressMVC.UI;
using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace ExpressMVC
{
    public static partial class HtmlExtensions
    {
        public static MvcHtmlString ExpressBlog(this HtmlHelper helper, BlogListModel model)
        {
            string layoutName = string.Empty;
            switch (model.UIProps.Layout)
            {
                case BlogLayout.Grid:
                    layoutName = "Post.Grid";
                    break;

                case BlogLayout.Default:
                    layoutName = "Post.Default";
                    break;

                case BlogLayout.Masonary:
                    layoutName = "Post.Masonary";
                    break;

                default:
                    break;
            }

            return PartialExtensions.Partial(helper, String.Format("Shortcodes/Blog/{0}", layoutName), model);
        }
    }
}