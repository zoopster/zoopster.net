using ExpressMVC.Models.Common;
using ExpressMVC.UI;
using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace ExpressMVC
{
    public static partial class HtmlExtensions
    {
        public static MvcHtmlString ExpressMenu(this HtmlHelper helper, HeaderTransparency transparency)
        {
            HeaderModel model = new HeaderModel();
            model.UIProps.Transparency = transparency;
            return ExpressMenu(helper, model);
        }

        public static MvcHtmlString ExpressMenu(this HtmlHelper helper)
        {
            HeaderModel model = new HeaderModel();
            return ExpressMenu(helper, model);
        }

        public static MvcHtmlString ExpressMenu(this HtmlHelper helper, HeaderModel model)
        {
            model.MenuList = new SampleData.Menu().GetMenuList();
            return PartialExtensions.Partial(helper, String.Format("Headers/{0}", model.Name), model);
        }

        public static MvcHtmlString ExpressSidebar(this HtmlHelper helper, SidebarModel model)
        {
            return PartialExtensions.Partial(helper, String.Format("Sidebars/{0}", model.Name), model);
        }

        public static MvcHtmlString ExpressSidebar(this HtmlHelper helper, string name)
        {
            SidebarModel model = new SidebarModel(name);
            return PartialExtensions.Partial(helper, String.Format("Sidebars/{0}", model.Name), model);
        }

        public static MvcHtmlString ExpressBanner(this HtmlHelper helper, string name)
        {
            return PartialExtensions.Partial(helper, String.Format("Banners/{0}", name));
        }

        public static MvcHtmlString ExpressFooter(this HtmlHelper helper)
        {
            return ExpressFooter(helper, new FooterModel());
        }

        public static MvcHtmlString ExpressFooter(this HtmlHelper helper, ThemeColor bgColor)
        {
            var model = new FooterModel() { UIProps = { BGColor = bgColor } };
            return ExpressFooter(helper, model);
        }

        public static MvcHtmlString ExpressFooter(this HtmlHelper helper, FooterModel model)
        {
            return PartialExtensions.Partial(helper, String.Format("Footers/{0}", model.Name), model);
        } 

        #region Page Headers

        public static MvcHtmlString ExpressPageHeader(this HtmlHelper helper, string title, string name)
        {
            PageHeaderModel model = new PageHeaderModel(title);
            model.Name = name;
            return ExpressPageHeader(helper, model);
        }

        public static MvcHtmlString ExpressPageHeader(this HtmlHelper helper, string title)
        {
            PageHeaderModel model = new PageHeaderModel(title);
            return ExpressPageHeader(helper, model);
        }

        public static MvcHtmlString ExpressPageHeader(this HtmlHelper helper, PageHeaderModel model)
        {
            return PartialExtensions.Partial(helper, String.Format("PageHeaders/{0}", model.Name), model);
        }

        #endregion Page Headers

        public static MvcHtmlString ExpressWidget(this HtmlHelper helper, string name)
        {
            var model = new WidgetModel(name);
            return ExpressWidget(helper, model);
        }

        public static MvcHtmlString ExpressWidget(this HtmlHelper helper, WidgetModel model)
        {
            return PartialExtensions.Partial(helper, String.Format("Widgets/{0}", model.Name), model);
        }


        public static MvcHtmlString ExpressLayerSlider(this HtmlHelper helper, string name)
        {
            return PartialExtensions.Partial(helper, String.Format("Sliders/LayerSlider/{0}", name));
        }

        public static MvcHtmlString ExpressMasterSlider(this HtmlHelper helper, string name)
        {
            return PartialExtensions.Partial(helper, String.Format("Sliders/MasterSlider/{0}", name));
        }

        public static MvcHtmlString ExpressRevolutionSlider(this HtmlHelper helper, string name)
        {
            return PartialExtensions.Partial(helper, String.Format("Sliders/RevolutionSlider/{0}", name));
        }
    }
}