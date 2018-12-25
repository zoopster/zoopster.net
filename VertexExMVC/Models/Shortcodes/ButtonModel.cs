using ExpressMVC.UI;

namespace ExpressMVC.Models.Shortcodes
{
    public class ButtonModel : ShortcodeModelBase
    {
        public ButtonModel()
        {
            this.UIProps = new UIProp(); 
        }

        public UIProp UIProps { get; set; }

        public string Text { get; set; }
        public bool IsDisabled { get; set; }
        public string Icon { get; set; }
        public ButtonType? Type { get; set; }


        /// <summary>
        /// UIProp
        /// </summary>
        public class UIProp
        {
            public UIProp()
            {
                this.Size = Size.Default;
                this.Effect = ButtonEffect.None;
            }

            public Size Size { get; set; }
            public ButtonEffect Effect { get; set; }

            public bool IsRounded { get; set; }
            public bool IsOutline { get; set; }
            public bool IsBlock { get; set; }
        }
    }
}