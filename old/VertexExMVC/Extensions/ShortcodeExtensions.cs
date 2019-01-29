using ExpressMVC.Models.Shortcodes;
using ExpressMVC.UI;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.WebPages;

namespace ExpressMVC
{
    public static partial class HtmlExtensions
    {
        #region Buttons

        public static MvcHtmlString ExpressButton(this HtmlHelper helper, ButtonModel model)
        {
            return PartialExtensions.Partial(helper, "Shortcodes/Button", model);
        }

        #endregion Buttons

        #region Counters

        public static MvcHtmlString ExpressCounter(this HtmlHelper helper, string label, decimal to)
        {
            var model = new CounterModel();
            model.Label = label;
            model.To = to;
            return ExpressCounter(helper, model);
        }

        public static MvcHtmlString ExpressCounter(this HtmlHelper helper, string label, decimal to, CounterSize size = CounterSize.Default)
        {
            var model = new CounterModel();
            model.Label = label;
            model.To = to;
            model.UIProps.Size = size;
            return ExpressCounter(helper, model);
        }

        public static MvcHtmlString ExpressCounter(this HtmlHelper helper, string label, decimal to, string apend)
        {
            var model = new CounterModel();
            model.Label = label;
            model.To = to;
            model.Append = apend;
            return ExpressCounter(helper, model);
        }

        public static MvcHtmlString ExpressCounter(this HtmlHelper helper, string label, decimal to, string apend, CounterSize size = CounterSize.Default)
        {
            var model = new CounterModel();
            model.Label = label;
            model.To = to;
            model.Append = apend;
            model.UIProps.Size = size;
            return ExpressCounter(helper, model);
        }

        public static MvcHtmlString ExpressCounter(this HtmlHelper helper, CounterModel model)
        {
            var counter = PartialExtensions.Partial(helper, "Shortcodes/Counter", model);
            if (model.UIProps.Animation.Type != AnimationType.None)
            {
                model.UIProps.Animation.Content = counter.ToHtmlString();
                return ExpressAnimation(helper, model.UIProps.Animation);
            }
            return counter;
        }

        #endregion Counters

        #region Testimonials

        public static MvcHtmlString ExpressTestimonial(this HtmlHelper helper, TestimonialsModel model)
        {
            return PartialExtensions.Partial(helper, "Shortcodes/Testimonials", model);
        }

        public static MvcHtmlString ExpressTestimonialSlider(this HtmlHelper helper,
            TestimonialStyle style = TestimonialStyle.Style1, params TestimonialsModel[] model)
        {
            CarouselModel carouselModel = new CarouselModel();

            foreach (var item in model)
            {
                item.UIProps.Style = style;
                carouselModel.Items.Add(ExpressTestimonial(helper, item).ToHtmlString());
            }

            switch (style)
            {
                case TestimonialStyle.Style1:
                    {
                        carouselModel.UIProps.Style = CarouselStyle.NavOutSide;
                        break;
                    }
                case TestimonialStyle.Style2:
                    {
                        carouselModel.UIProps.Style = CarouselStyle.NavOutSide;
                        break;
                    }
                case TestimonialStyle.Style3:
                    {
                        carouselModel.UIProps.Margin = 30;
                        carouselModel.DisplayCount = 3;
                        break;
                    }
                case TestimonialStyle.Style4:
                    {
                        carouselModel.UIProps.Margin = 30;
                        carouselModel.DisplayCount = 3;
                        break;
                    }
                case TestimonialStyle.Style5:
                    {
                        carouselModel.UIProps.Style = CarouselStyle.NavBottom;
                        break;
                    }
                default:
                    break;
            }

            return ExpressCarousel(helper, carouselModel);
        }

        #endregion Testimonials

        #region Sections

        public static MvcHtmlString ExpressSection(this HtmlHelper helper, SectionModel model, Func<dynamic, HelperResult> section)
        {
            model.InnerHtmlString = section(null).ToHtmlString();
            return PartialExtensions.Partial(helper, "Shortcodes/Section", model);
        }

        public static MvcHtmlString ExpressSection(this HtmlHelper helper, Func<dynamic, HelperResult> section)
        {
            SectionModel model = new SectionModel();
            model.InnerHtmlString = section(null).ToHtmlString();

            return PartialExtensions.Partial(helper, "Shortcodes/Section", model);
        }

        #endregion Sections

        #region Carousel

        public static MvcHtmlString ExpressCarousel(this HtmlHelper helper, CarouselModel model)
        {
            return PartialExtensions.Partial(helper, "Shortcodes/Carousel", model);
        }

        public static MvcHtmlString ExpressCarousel(this HtmlHelper helper, CarouselModel model, params Func<dynamic, HelperResult>[] items)
        {
            model.Items = new List<String>();
            foreach (var item in items)
            {
                model.Items.Add(item(null).ToHtmlString());
            }
            return ExpressCarousel(helper, model);
        }

        public static MvcHtmlString ExpressCarousel(this HtmlHelper helper, params Func<dynamic, HelperResult>[] items)
        {
            CarouselModel model = new CarouselModel();
            foreach (var item in items)
            {
                model.Items.Add(item(null).ToHtmlString());
            }
            return ExpressCarousel(helper, model);
        }

        #endregion Carousel

        #region Heading

        public static MvcHtmlString ExpressHeading(this HtmlHelper helper, HTag hTag, TextElement text, HeadingStyle style = HeadingStyle.BorderBottom, Alignment aligment = Alignment.Left)
        {
            HeadingModel model = new HeadingModel();
            model.HTag = hTag;
            model.Text = text;
            model.Style = style;
            model.Aligment = aligment;
            return ExpressHeading(helper, model);
        }

        public static MvcHtmlString ExpressHeading(this HtmlHelper helper, HeadingModel model)
        {
            return PartialExtensions.Partial(helper, "Shortcodes/Heading", model);
        }

        public static MvcHtmlString ExpressSectionTitle(this HtmlHelper helper, string text)
        {
            HeadingModel model = new HeadingModel();
            model.HTag = HTag.h2;
            model.Text = new TextElement(text);
            model.Text.TextSize = TextSize.Text_13;
            model.Text.Alignment = Alignment.Center;

            return ExpressSectionTitle(helper, text, textColor: TextColor.Default);
        }

        public static MvcHtmlString ExpressSectionTitle(this HtmlHelper helper, string text, TextColor textColor)
        {
            HeadingModel model = new HeadingModel();
            model.HTag = HTag.h2;
            model.Text = new TextElement(text)
            {
                TextSize = TextSize.Text_13,
                Alignment = Alignment.Center,
                TextColor = textColor
            };

            return PartialExtensions.Partial(helper, "Shortcodes/Heading", model);
        }

        public static MvcHtmlString ExpressSectionTitle(this HtmlHelper helper, TextElement text)
        {
            return PartialExtensions.Partial(helper, "Shortcodes/Heading", new HeadingModel() { HTag = HTag.h2, Text = text });
        }

        public static MvcHtmlString ExpressSectionSubTitle(this HtmlHelper helper, string text, TextColor textColor = TextColor.Default)
        {
            HeadingModel model = new HeadingModel();
            model.HTag = HTag.p;
            model.Text = new TextElement(text)
            {
                TextSize = TextSize.Text_4,
                FontWeight = FontWeight.Light,
                Alignment = Alignment.Center,
                TextColor = textColor
            };

            return PartialExtensions.Partial(helper, "Shortcodes/Heading", model);
        }

        public static MvcHtmlString ExpressSectionSubTitle(this HtmlHelper helper, TextElement text)
        {
            HeadingModel model = new HeadingModel();
            model.HTag = HTag.p;
            model.Text = text;

            return PartialExtensions.Partial(helper, "Shortcodes/Heading", model);
        }

        #endregion Heading

        #region Animations

        public static MvcHtmlString ExpressAnimation(this HtmlHelper helper, AnimationModel model)
        {
            return PartialExtensions.Partial(helper, "Shortcodes/Animation", model);
        }

        public static MvcHtmlString ExpressAnimation(this HtmlHelper helper, Func<dynamic, HelperResult> content)
        {
            AnimationModel model = new AnimationModel();
            model.Content = content(null).ToHtmlString();
            return ExpressAnimation(helper, model);
        }

        public static MvcHtmlString ExpressAnimation(this HtmlHelper helper, AnimationType type, Func<dynamic, HelperResult> content)
        {
            AnimationModel model = new AnimationModel();
            model.Content = content(null).ToHtmlString();
            model.Type = type;
            return ExpressAnimation(helper, model);
        }

        public static MvcHtmlString ExpressAnimation(this HtmlHelper helper, AnimationModel model, Func<dynamic, HelperResult> content)
        {
            model.Content = content(null).ToHtmlString();
            return ExpressAnimation(helper, model);
        }

        #endregion Animations

        #region Tabs

        public static MvcHtmlString ExpressTab(this HtmlHelper helper, TabModel model)
        {
            return PartialExtensions.Partial(helper, "Shortcodes/Tab", model);
        }

        #endregion Tabs

        #region IconBox

        public static MvcHtmlString ExpressIconBox(this HtmlHelper helper, IconBoxModel model)
        {
            var iconBox = PartialExtensions.Partial(helper, "Shortcodes/IconBox", model);
            if (model.UIProps.Animation != null && model.UIProps.Animation.Type != AnimationType.None)
            {
                model.UIProps.Animation.Content = iconBox.ToString();
                return ExpressAnimation(helper, model.UIProps.Animation);
            }
            return iconBox;
        }

        #endregion IconBox

        #region Alert

        public static MvcHtmlString ExpressAlert(this HtmlHelper helper, AlertModel model)
        {
            return PartialExtensions.Partial(helper, "Shortcodes/Alert", model);
        }

        public static MvcHtmlString ExpressAlert(this HtmlHelper helper, Func<dynamic, HelperResult> content)
        {
            var model = new AlertModel();
            model.Content = content(null).ToHtmlString();
            return ExpressAlert(helper, model);
        }

        public static MvcHtmlString ExpressAlert(this HtmlHelper helper, AlertModel model, Func<dynamic, HelperResult> content)
        {
            model.Content = content(null).ToHtmlString();
            return ExpressAlert(helper, model);
        }

        public static MvcHtmlString ExpressAlert(this HtmlHelper helper, AlertType alertTyle, Func<dynamic, HelperResult> content)
        {
            var model = new AlertModel();
            model.Type = alertTyle;
            model.Content = content(null).ToHtmlString();
            return ExpressAlert(helper, model);
        }

        #endregion Alert

        #region Divider

        public static MvcHtmlString ExpressSpace(this HtmlHelper helper)
        {
            var model = new DividerModel();
            model.Type = DividerType.Space;
            return ExpressDivider(helper, model);
        }

        public static MvcHtmlString ExpressSpace(this HtmlHelper helper, Size size = Size.Default)
        {
            var model = new DividerModel();
            model.Type = DividerType.Space;
            model.Size = size;
            return ExpressDivider(helper, model);
        }

        public static MvcHtmlString ExpressHr(this HtmlHelper helper)
        {
            var model = new DividerModel();
            model.Type = DividerType.Hr;
            return ExpressDivider(helper, model);
        }

        public static MvcHtmlString ExpressDivider(this HtmlHelper helper)
        {
            var model = new DividerModel();
            model.Type = DividerType.Divider;
            return ExpressDivider(helper, model);
        }

        private static MvcHtmlString ExpressDivider(this HtmlHelper helper, DividerModel model)
        {
            return PartialExtensions.Partial(helper, "Shortcodes/Divider", model);
        }

        #endregion Divider

        public static MvcHtmlString ExpressCallToAction(this HtmlHelper helper, CallToActionModel model)
        {
            return PartialExtensions.Partial(helper, "Shortcodes/CallToAction", model);
        }

        public static MvcHtmlString ExpressAccordion(this HtmlHelper helper, AccordionModel model)
        {
            return PartialExtensions.Partial(helper, "Shortcodes/Accordion", model);
        }

        public static MvcHtmlString ExpressBlockquote(this HtmlHelper helper, BlockquoteModel model)
        {
            return PartialExtensions.Partial(helper, "Shortcodes/Blockquote", model);
        }

        public static MvcHtmlString ExpressCircleChart(this HtmlHelper helper, CircleChartModel model)
        {
            return PartialExtensions.Partial(helper, "Shortcodes/CircleChart", model);
        }

        public static MvcHtmlString ExpressClient(this HtmlHelper helper, ClientModel model)
        {
            return PartialExtensions.Partial(helper, "Shortcodes/Client", model);
        }

        #region ProgressBars
         
        public static MvcHtmlString ExpressProgressBar(this HtmlHelper helper, int value, int? delay)
        {
            return ExpressProgressBar(helper, null, value, delay, null);
        }

        public static MvcHtmlString ExpressProgressBar(this HtmlHelper helper, TextElement label, int value, int? delay)
        {
            return ExpressProgressBar(helper, label, value, delay, null);
        }

        public static MvcHtmlString ExpressProgressBar(this HtmlHelper helper, TextElement label, int value, int? delay, ProgressBarModel.UIProp uiProps)
        {
            var model = new ProgressBarModel()
            {
                Label = label,
                Value = value,
                Delay = delay,
                UIProps = uiProps == null ? new ProgressBarModel.UIProp() : uiProps
            };
            return ExpressProgressBar(helper, model);
        }

        public static MvcHtmlString ExpressProgressBar(this HtmlHelper helper, ProgressBarModel model)
        {
            return PartialExtensions.Partial(helper, "Shortcodes/ProgressBar", model);
        }

        #endregion ProgressBars


        public static MvcHtmlString ExpressTeamElement(this HtmlHelper helper, TeamElementModel model)
        {
            return PartialExtensions.Partial(helper, "Shortcodes/TeamElement", model);
        }
    }
}