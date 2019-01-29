using ExpressMVC.Models.Common;
using ExpressMVC.UI;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace ExpressMVC.SampleData
{
    public class Menu
    {
        public List<MenuModel> GetMenuList()
        {
            var url = new UrlHelper(HttpContext.Current.Request.RequestContext);
            var menus = new List<MenuModel>();

            var home = new MenuModel("Home", url.Action("Index", "Home"))
            {
                Childs = new List<MenuModel>() {
                   new MenuModel("Home Version 1", url.Action("Index", "Home")),
                   new MenuModel("Home Version 2", url.Action("Index2", "Home")),
                   new MenuModel("Home Version 3", url.Action("Index3", "Home"))
                }
            };

            var pages = new MenuModel("Pages", url.Action("AboutMe", "Page"))
            {
                Childs = new List<MenuModel>() {
                   new MenuModel("About Me", url.Action("AboutMe", "Page")),
                   new MenuModel("Contact Us", url.Action("ContactUs", "Page"))
                }
            };

            var shortcodes = new MenuModel("Shortcodes", url.Action("#", "Shortcode"), isMegaMenu: true)
            {
                Childs = new List<MenuModel>() {
                   new MenuModel(megaMenuTitle: "Shortcodes 1"),
                   new MenuModel("Accordions Toggles", url.Action("Accordion", "Shortcode")),
                   new MenuModel("Tabs", url.Action("Tab", "Shortcode")),
                   new MenuModel("Alert Messages", url.Action("Alert", "Shortcode")),
                   new MenuModel("Animations", url.Action("Animation", "Shortcode")),
                   new MenuModel("Icon Boxes", url.Action("IconBox", "Shortcode")),
                   new MenuModel("Carousels", url.Action("Carousel", "Shortcode")),
                   new MenuModel("Heading", url.Action("Heading", "Shortcode")),

                   new MenuModel(megaMenuTitle: "Shortcodes 2"),
                   new MenuModel("Buttons", url.Action("Button", "Shortcode")),
                   new MenuModel("Testimonials", url.Action("Testimonials", "Shortcode")),
                   new MenuModel("Blockquotes",url.Action("Blockquote", "Shortcode")),
                   new MenuModel("Counters", url.Action("Counter", "Shortcode")),

                   new MenuModel(megaMenuTitle: "Shortcodes 3"),
                   new MenuModel("Circle Charts", url.Action("CircleChart", "Shortcode")),
                   new MenuModel("Call to Action", url.Action("CallToAction", "Shortcode")),
                   new MenuModel("Progress Bars", url.Action("ProgressBar", "Shortcode")),

                   new MenuModel(megaMenuTitle: "Shortcodes 4"),
                   new MenuModel("Circle Charts", url.Action("CircleChart", "Shortcode")),
                   new MenuModel("Call to Action", url.Action("CallToAction", "Shortcode")),
                   new MenuModel("Progress Bars", url.Action("ProgressBar", "Shortcode")),
                }
            };

            var features = new MenuModel("Features", url.Action("#", "Feature"))
            {
                Childs = new List<MenuModel>() {
                   new MenuModel("Headers", url.Action("#", "Feature")){
                       Childs = new List<MenuModel>(){
                           new MenuModel("Default", url.Action("#", "Feature")) {
                               Childs = new List<MenuModel>() {
                                   new MenuModel("Default + Colored Top Bar", url.Action("#", "Feature")),
                                   new MenuModel("Default + Top Bar with Search", url.Action("#", "Feature")),
                                   new MenuModel("Default + Top Bar with Button", url.Action("#", "Feature"))
                               }
                           },
                           new MenuModel("Floating", url.Action("#", "Feature")),
                           new MenuModel("Transparency", url.Action("#", "Feature")) {
                               Childs = new List<MenuModel>() {
                                   new MenuModel("Transparent", url.Action("HeaderTransparency", "Feature", new { transparency = HeaderTransparency.Transparent })),
                                   new MenuModel("Transparent - Bottom Border", url.Action("HeaderTransparency", "Feature", new { transparency = HeaderTransparency.TransparentBorderBottom })),
                                   new MenuModel("Semi Transparent", url.Action("HeaderTransparency", "Feature", new { transparency = HeaderTransparency.SemiTransparent })),
                                   new MenuModel("Semi Transparent - Light", url.Action("HeaderTransparency", "Feature", new { transparency = HeaderTransparency.SemiTransparentLight }))
                               }
                           },
                           new MenuModel("Side Header", url.Action("#", "Feature")) {
                               Childs = new List<MenuModel>() {
                                   new MenuModel("Side Header Left", url.Action("#", "Feature")),
                                   new MenuModel("Side Header Right", url.Action("#", "Feature")),
                                   new MenuModel("Side Header Semi Transparent", url.Action("#", "Feature")),
                                   new MenuModel("Side Header Semi Transparent - Light", url.Action("#", "Feature")),
                                   new MenuModel("Side Header From Out", url.Action("#", "Feature"))
                               }
                           },
                           new MenuModel("Signin / Signup", url.Action("#", "Feature")),
                           new MenuModel("Logged", url.Action("#", "Feature")),
                       }
                   },

                   new MenuModel("Footers", url.Action("#", "Feature")) {
                       Childs = new List<MenuModel>() {
                           new MenuModel("Default", url.Action("Footer", "Feature", new { name = "Default" })),
                           new MenuModel("Simple", url.Action("Footer", "Feature", new { name = "Simple" })),
                           new MenuModel("Light", url.Action("Footer", "Feature", new { name = "Light" })),
                           new MenuModel("Light Narrow", url.Action("Footer", "Feature", new { name = "LightNarrow" })),
                           new MenuModel("Center", url.Action("Footer", "Feature", new { name = "Center" })),
                           new MenuModel("Colors", url.Action("#", "Feature", new { name = "Default" })) {
                               Childs = new List<MenuModel>() {
                                   new MenuModel("Primary Color", url.Action("FooterColor", "Feature", new { color = ThemeColor.Primary })),
                                   new MenuModel("Secondary Color", url.Action("FooterColor", "Feature", new { color = ThemeColor.Secondary })),
                                   new MenuModel("Tertiary Color", url.Action("FooterColor", "Feature", new { color = ThemeColor.Tertiary })),
                                   new MenuModel("Quaternary Color", url.Action("FooterColor", "Feature", new { color = ThemeColor.Quaternary }))
                               }
                           },
                           new MenuModel("Instagram / Twitter Feed", url.Action("Footer", "Feature", new { name = "InstagramTwitter" })),
                           new MenuModel("Newsletter", url.Action("Footer", "Feature", new { name = "Newsletter" })),
                           new MenuModel("Contact Form", url.Action("#", "Feature")) {
                               Childs = new List<MenuModel>() {
                                   new MenuModel("Default", url.Action("Footer", "Feature", new { name = "ContactForm" })),
                                   new MenuModel("Transparent", url.Action("Footer", "Feature", new { name = "ContactFormTransparent" }))
                               }
                           },
                       }
                   },

                   new MenuModel("Page Headers", url.Action("#", "Feature")) {
                       Childs = new List<MenuModel>() {
                           new MenuModel("Left Alignment", url.Action("PageHeader", "Feature", new { headerType = PageHeaderType.LeftAlignment })),
                           new MenuModel("Center Alignment", url.Action("PageHeader", "Feature", new { headerType = PageHeaderType.CenterAlignment })),
                           new MenuModel("Right Alignment", url.Action("PageHeader", "Feature", new { headerType = PageHeaderType.RightAlignment })),
                           new MenuModel("Colors", url.Action("#", "Feature"))
                           {
                               Childs = new List<MenuModel>() {
                                   new MenuModel("Primary Color", url.Action("PageHeaderColor", "Feature", new { color = ThemeColor.Primary })),
                                   new MenuModel("Secondary Color", url.Action("PageHeaderColor", "Feature", new { color = ThemeColor.Secondary })),
                                   new MenuModel("Tertiary Color", url.Action("PageHeaderColor", "Feature", new { color = ThemeColor.Tertiary })),
                                   new MenuModel("Quaternary Color", url.Action("PageHeaderColor", "Feature", new { color = ThemeColor.Quaternary }))
                               }
                           },
                           new MenuModel("Dark", url.Action("PageHeaderColor", "Feature", new { color = ThemeColor.Dark })),
                           new MenuModel("Custom Background", url.Action("PageHeader", "Feature", new { headerType = PageHeaderType.CustomBackground })),
                           new MenuModel("Parallax", url.Action("PageHeader", "Feature", new { headerType = PageHeaderType.Parallax })),
                           new MenuModel("Video Background", url.Action("PageHeader", "Feature", new { headerType = PageHeaderType.VideoBackground })),
                           new MenuModel("Mini", url.Action("PageHeader", "Feature", new { headerType = PageHeaderType.Mini }))
                       }
                   },

                   new MenuModel("Layout Options", url.Action("#", "Feature")) {
                       Childs = new List<MenuModel>() {
                           new MenuModel("Boxed", url.Action("#", "Feature")),
                           new MenuModel("Gap Outside", url.Action("#", "Feature"))
                       }
                   }
                }
            };

            var portfolio = new MenuModel("Portfolio", url.Action("#", "Portfolio"), isMegaMenu: true)
            {
                Childs = new List<MenuModel>() {
                   new MenuModel(megaMenuTitle: "GRID"),
                   new MenuModel("6 Columns", url.Action("Grid6Columns", "Portfolio")),
                   new MenuModel("5 Columns", url.Action("Grid5Columns", "Portfolio")),
                   new MenuModel("4 Columns", url.Action("Grid4Columns", "Portfolio")),
                   new MenuModel("3 Columns", url.Action("Grid3Columns", "Portfolio")),
                   new MenuModel("2 Columns", url.Action("Grid2Columns", "Portfolio")),

                   new MenuModel(megaMenuTitle: "MASONRY"),
                   new MenuModel("6 Columns", url.Action("Masonry6Columns", "Portfolio")),
                   new MenuModel("5 Columns", url.Action("Masonry5Columns", "Portfolio")),
                   new MenuModel("4 Columns",url.Action("Masonry4Columns", "Portfolio")),
                   new MenuModel("3 Columns", url.Action("Masonry3Columns", "Portfolio")),
                   new MenuModel("2 Columns", url.Action("Masonry2Columns", "Portfolio")),

                   new MenuModel(megaMenuTitle: "SIDEBAR LAYOUTS"),
                   new MenuModel("Right Sidebar", url.Action("RightSidebar", "Portfolio")),
                   new MenuModel("Left Sidebar", url.Action("LeftSidebar", "Portfolio")),
                   new MenuModel("Both Sidebar", url.Action("BothSidebar", "Portfolio")),

                   new MenuModel(megaMenuTitle: "PORTFOLIO DETAIL"),
                   new MenuModel("Single Gallery", url.Action("Detail", "Portfolio")),
                }
            };

            var blog = new MenuModel("Blog", url.Action("#", "Blog"), isMegaMenu: true)
            {
                Childs = new List<MenuModel>() {
                   new MenuModel(megaMenuTitle: "DEFAULT"),
                   new MenuModel("Default", url.Action("Default", "Blog")),
                   new MenuModel("Right Sidebar", url.Action("DefaultRightSidebar", "Blog")),
                   new MenuModel("Both Sidebar", url.Action("DefaultBothSidebar", "Blog")),

                   new MenuModel(megaMenuTitle: "MASONRY"), 
                   new MenuModel("4 Columns", url.Action("Masonry4Columns", "Blog")),
                   new MenuModel("3 Columns", url.Action("Masonry3Columns", "Blog")),
                   new MenuModel("2 Columns", url.Action("Masonry2Columns", "Blog")),
                   new MenuModel("Full Width", url.Action("Masonry4ColumnsFullWith", "Blog")),

                   new MenuModel(megaMenuTitle: "GRID"),
                   new MenuModel("4 Columns", url.Action("Grid4Columns", "Blog")),
                   new MenuModel("3 Columns", url.Action("Grid3Columns", "Blog")),
                   new MenuModel("2 Columns", url.Action("Grid2Columns", "Blog")),
                   new MenuModel("Full Width", url.Action("GridFullWidth4Columns", "Blog")),

                   new MenuModel(megaMenuTitle: "SINGLE POST"),
                   new MenuModel("Single Post", url.Action("Detail", "Blog", new { id = 1 })),
                }
            };

            menus.Add(home);
            menus.Add(pages);
            menus.Add(shortcodes);
            menus.Add(features);
            menus.Add(portfolio);
            menus.Add(blog);

            return menus;
        }
    }
}