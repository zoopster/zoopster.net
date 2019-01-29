using ExpressMVC.Models.Portfolio;
using ExpressMVC.UI;
using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace ExpressMVC
{
    public static partial class HtmlExtensions
    {
        public static MvcHtmlString ExpressPortfolio(this HtmlHelper helper, PortfolioListModel model)
        {
            string layoutName = string.Empty;
            switch (model.UIProps.Layout)
            {
                case PortfolioLayout.Pracia:
                    layoutName = "Grid.Styles.Pracia";
                    break;

                case PortfolioLayout.Honiara:
                    layoutName = "Grid.Styles.Honiara";
                    break;

                case PortfolioLayout.Camberra:
                    layoutName = "Grid.Styles.Camberra";
                    break;

                case PortfolioLayout.Brasilia:
                    layoutName = "Grid.Styles.Brasilia";
                    break;

                case PortfolioLayout.Praia:
                    layoutName = "Grid.Styles.Praia";
                    break;

                case PortfolioLayout.Oslo:
                    layoutName = "Grid.Styles.Oslo";
                    break;

                case PortfolioLayout.Grid:
                    layoutName = "Grid";
                    break;

                case PortfolioLayout.Masonry:
                    layoutName = "Masonry";
                    break;

                default:
                    break;
            }

            return PartialExtensions.Partial(helper, String.Format("Shortcodes/Portfolio/{0}", layoutName), model);
        }
    }
}