using ExpressMVC.Models.Form;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace ExpressMVC
{
    public static partial class HtmlExtensions
    {
        public static MvcHtmlString ExpressNewsletterForm(this HtmlHelper helper)
        {
            NewsletterFormModel model = new NewsletterFormModel();
            return PartialExtensions.Partial(helper, "Forms/NewsletterForm", model);
        }
    }
}