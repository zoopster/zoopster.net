using ExpressMVC.UI;
using System; 

namespace ExpressMVC.Models.Shortcodes
{
    public class SectionModel : ShortcodeModelBase
    {
        public SectionModel()
        {
            this.Height = SectionHeight.Default;
            this.BGLight = BGLight.Default;
            this.BGDark = BGDark.Default;
            this.HasBorderBottom = false;
            this.HasBorderTop = false;
        }

        public String InnerHtmlString { get; set; }
         

        public SectionHeight Height { get; set; }
        public BGLight BGLight { get; set; }
        public BGDark BGDark { get; set; }
        public ThemeColor BGColor { get; set; }

        public bool IsParallax { get; set; }
        public bool IsVideoSection { get; set; }
        public bool IsOverlaySection { get; set; }
        public bool HasBorderBottom { get; set; }
        public bool HasBorderTop { get; set; }

        /// <summary>
        /// Background image source
        /// </summary>
        public string Src { get; set; } 

        public bool HasContainerAndRow { get; set; }
         
    }
}