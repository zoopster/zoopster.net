using ExpressMVC.UI;

namespace ExpressMVC.Models.Common
{
    public class PageHeaderModel : ElementModelBase
    {
        public PageHeaderModel(string title)
        {
            this.UIProps = new UIProp();

            this.Title = title;
        }

        public UIProp UIProps { get; set; }

        public string Title { get; set; }
        public string TopSubTitle { get; set; }
        public string Lead { get; set; }

        /// <summary>
        /// If the header type is 'VideoBackground' set or gets the video path
        /// If the header type is 'Parallax' or 'CustomBackground' set or gets the video path
        /// </summary>
        public string Src { get; set; }

        public class UIProp
        {
            public UIProp()
            {
                this.Type = PageHeaderType.LeftAlignment;
                this.BGColor = ThemeColor.Default;
            }

            /// <summary>
            /// The type of the page headers.
            /// </summary>
            public PageHeaderType Type { get; set; }

            public ThemeColor BGColor { get; set; }
            public SectionOverlay Overlay { get; set; }
        }
    }
}