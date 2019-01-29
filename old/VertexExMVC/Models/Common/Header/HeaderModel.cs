using ExpressMVC.UI;
using System.Collections.Generic;

namespace ExpressMVC.Models.Common
{
    public partial class HeaderModel : ElementModelBase
    {
        public HeaderModel()
        {
            this.UIProps = new UIProp();
            this.Logo = new HeaderLogoModel();
            this.Topbar = new HeaderTopbarModel();
            this.MenuList = new List<MenuModel>();
            this.IsStickyEnabled = true;
            this.IsStickyEnableOnBoxed = true;
            this.IsStickyEnableOnMobile = true;
        }

        public List<MenuModel> MenuList { get; set; }

        public UIProp UIProps { get; set; }
        public HeaderLogoModel Logo { get; set; }
        public HeaderTopbarModel Topbar { get; set; }

        public bool IsStickyEnabled { get; set; }
        public bool IsStickyEnableOnBoxed { get; set; }
        public bool IsStickyEnableOnMobile { get; set; } 

        /// <summary>
        /// Set the UI properties
        /// </summary>
        public class UIProp
        {
            public UIProp()
            {
                this.HeaderSide = HeaderSide.Top;
                this.Transparency = HeaderTransparency.None; 
                this.Navigation = HeaderNavigation.Default;
                this.IsFullWidth = true;
            }

            public bool IsFullWidth { get; set; }
            
            public HeaderTransparency Transparency { get; set; }
            public HeaderSide HeaderSide { get; set; }
            public HeaderNavigation Navigation { get; set; }
        }

        #region Get Css Class

        public string GetNavigationClass()
        {
            string navigationClass = string.Empty;
            switch (this.UIProps.Navigation)
            {
                case HeaderNavigation.Default:
                    navigationClass = string.Empty;
                    break;
                case HeaderNavigation.TopLine:
                    navigationClass = "header-nav-top-line";
                    break;
                case HeaderNavigation.Stripe:
                    navigationClass = "header-nav-stripe";
                    break;
                case HeaderNavigation.LightDropdown:
                    navigationClass = "header-nav-light-dropdown";
                    break;
                case HeaderNavigation.LineUnderText:
                    navigationClass = "header-nav-line-under-text";
                    break;
                default:
                    break;
            }

            return navigationClass;
        }

        public string GetTransparencyClass()
        {
            string transparencyClass = string.Empty;
            switch (this.UIProps.Transparency)
            {
                case HeaderTransparency.None:
                    transparencyClass = string.Empty;
                    break;
                case HeaderTransparency.Transparent:
                    transparencyClass = "header-transparent";
                    break;
                case HeaderTransparency.TransparentBorderBottom:
                    transparencyClass = "header-transparent header-container-bottom-border";
                    break;
                case HeaderTransparency.SemiTransparent:
                    transparencyClass = "header-semi-transparent";
                    break;
                case HeaderTransparency.SemiTransparentLight:
                    transparencyClass = "header-semi-transparent-light";
                    break;
                default:
                    break;
            }

            return transparencyClass;
        }

        public string GetFullWidthClass()
        {
            string fullWidthClass = "container";
            if (this.UIProps.IsFullWidth)
            {
                fullWidthClass = string.Empty;
            }

            return fullWidthClass;
        }

        public string GetLogoSrc()
        {
            return this.UIProps.Transparency == HeaderTransparency.None ? this.Logo.LogoSrc : this.Logo.TransparentLogoSrc;
        }

        public string GetPluginOptions()
        {
            string options = string.Empty;
            options += string.Format("'stickyEnabled': {0}, ", this.IsStickyEnabled.ToHtmlString());
            options += string.Format("'stickyEnableOnBoxed': {0}, ", this.IsStickyEnableOnBoxed.ToHtmlString());
            options += string.Format("'stickyEnableOnMobile': {0}, ", this.IsStickyEnableOnMobile.ToHtmlString());
            options += string.Format("'stickyStartAt': {0}", 120); 

            return options;
        }

        #endregion Get Css Class
    }
}