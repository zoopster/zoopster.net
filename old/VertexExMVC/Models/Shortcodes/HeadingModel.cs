using ExpressMVC.UI;

namespace ExpressMVC.Models.Shortcodes
{
    public class HeadingModel: ShortcodeModelBase
    {
        public HeadingModel()
        {
            this.HTag = HTag.h3;
            this.Style = HeadingStyle.None;
            this.Aligment = Alignment.Left;
        }

        public Alignment Aligment { get; set; }
        public TextElement Text { get; set; }
        public HTag HTag { get; set; }
        public HeadingStyle Style { get; set; }
    }
}