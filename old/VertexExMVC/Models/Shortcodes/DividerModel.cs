using ExpressMVC.UI;

namespace ExpressMVC.Models.Shortcodes
{
    public class DividerModel: ShortcodeModelBase
    {
        public DividerModel()
        {
            this.Type = DividerType.Hr;
            this.Size = Size.Default;
        }

        public DividerType Type { get; set; }
        public Size Size { get; set; }
    }
}