using ExpressMVC.Models.Common;
using ExpressMVC.UI;
using System.Web.Mvc;

namespace ExpressMVC.Controllers
{
    public class FeatureController : Controller
    {
        public ActionResult Header()
        {
            HeaderModel model = new HeaderModel();

            return View(model);
        }

        public ActionResult Footer(string name)
        {
            var model = new FooterModel()
            {
                Name = string.IsNullOrEmpty(name) ? "Default" : name
            };
            return View(model);
        }

        public ActionResult FooterColor(ThemeColor? color)
        {
            var model = new FooterModel()
            {
                UIProps = { BGColor = color.HasValue ? color.Value : ThemeColor.Dark }
            };
            return View("Footer", model);
        }

        public ActionResult HeaderTransparency(HeaderTransparency? transparency)
        {
            var model = new HeaderModel();
            HeaderTransparency t = transparency.HasValue ? transparency.Value : UI.HeaderTransparency.None;
            model.UIProps.Transparency = t;

            return View(model);
        }

        public ActionResult PageHeader(PageHeaderType? headerType)
        {
            PageHeaderModel model = null;
            PageHeaderType _type = headerType == null ? PageHeaderType.LeftAlignment : (PageHeaderType)headerType;

            switch (_type)
            {
                case PageHeaderType.LeftAlignment:
                    {
                        model = new PageHeaderModel("Header Left Alignment")
                        {
                            TopSubTitle = "Express Features",
                            Lead = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                        };
                        break;
                    } 
                case PageHeaderType.CenterAlignment:
                    {
                        model = new PageHeaderModel("Header Center Alignment")
                        {
                            Lead = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                            UIProps = { Type = PageHeaderType.CenterAlignment }
                        };
                        break;
                    } 
                case PageHeaderType.RightAlignment:
                    {
                        model = new PageHeaderModel("Header Right Alignment")
                        {
                            TopSubTitle = "Express Features",
                            Lead = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                            UIProps = { Type = PageHeaderType.RightAlignment }
                        };
                        break;
                    } 
                case PageHeaderType.VideoBackground:
                    {
                        model = new PageHeaderModel("Header Video Background")
                        {
                            Lead = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                            UIProps = { Type = PageHeaderType.VideoBackground }
                        };
                        break;
                    } 
                case PageHeaderType.CustomBackground:
                    {
                        model = new PageHeaderModel("Header Background")
                        {
                            Src = "/Content/img/mix/man-for-about.jpg",
                            Lead = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                            UIProps = { Type = PageHeaderType.CustomBackground }
                        };
                        break;
                    } 
                case PageHeaderType.Parallax:
                    {
                        model = new PageHeaderModel("Header Parallax")
                        {
                            Src = "/Content/img/mix/man-for-about.jpg",
                            Lead = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                            UIProps = { Type = PageHeaderType.Parallax }
                        };
                        break;
                    } 
                case PageHeaderType.Mini:
                    {
                        model = new PageHeaderModel("Header Left Alignment");
                        break;
                    } 
                default:
                    model = new PageHeaderModel("Header Left Alignment");
                    break;
            }

            model.UIProps.Type = _type;
            return View(model);
        }

        public ActionResult PageHeaderColor(ThemeColor? color)
        {
            PageHeaderModel model = null;
            ThemeColor bgColor = color.HasValue ? color.Value : ThemeColor.Default;

            switch (bgColor)
            {
                case ThemeColor.Primary:
                    {
                        model = new PageHeaderModel("Primary Color")
                        {
                            TopSubTitle = "Express Features",
                            Lead = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        };
                    }
                    break;

                case ThemeColor.Secondary:
                    {
                        model = new PageHeaderModel("Secondary Color")
                        {
                            TopSubTitle = "Secondary Color",
                            Lead = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        };
                    }
                    break;

                case ThemeColor.Tertiary:
                    {
                        model = new PageHeaderModel("Tertiary Color")
                        {
                            TopSubTitle = "Express Features",
                            Lead = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                        };
                    }
                    break;

                case ThemeColor.Quaternary:
                    {
                        model = new PageHeaderModel("Quaternary Color")
                        {
                            TopSubTitle = "Express Features",
                            Lead = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                        };
                    }
                    break;

                case ThemeColor.Dark:
                    {
                        model = new PageHeaderModel("Dark Color")
                        {
                            Lead = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                        };
                    }
                    break;

                default:
                    model = new PageHeaderModel("Default Header");
                    break;
            }

            model.UIProps.BGColor = bgColor;
            return View("PageHeader", model);
        }
    }
}