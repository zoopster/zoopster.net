using ExpressMVC.UI;

namespace ExpressMVC.Models.Shortcodes
{
    public class CallToActionModel : ShortcodeModelBase
    {
        public CallToActionModel()
        {
            this.UIProps = new UIProp();
        }

        public UIProp UIProps { get; set; }

        public string Text { get; set; }
        public string SubText { get; set; }

        public class UIProp
        {
            public UIProp()
            {
                this.BGColor = ThemeColor.Default;
                this.Height = CallToActionHeight.Height2;
                this.TextAnimation = new AnimationModel(AnimationType.None, 0);
                this.ButtonAnimation = new AnimationModel(AnimationType.None, 0);
            }

            public bool IsParallax { get; set; }
            public string Src { get; set; }
            public ThemeColor BGColor { get; set; }
            public CallToActionHeight Height { get; set; }
            public AnimationModel TextAnimation { get; set; }
            public AnimationModel ButtonAnimation { get; set; }
        }
    }
}