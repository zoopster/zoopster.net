using ExpressMVC.UI;

namespace ExpressMVC.Models.Shortcodes
{
    public class IconBoxModel: ShortcodeModelBase
    {
        public IconBoxModel()
        {
            this.UIProps = new UIProp(); 
        }

        public UIProp UIProps { get; set; }

        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }
        public string Icon { get; set; }

        public string ImageSrc { get; set; } 

        public class UIProp
        {
            public UIProp()
            {
                this.Style = IconBoxStyle.Style1;
                this.IconColor = ThemeColor.Primary;
                this.IconSize = TextSize.None; // default
                this.Animation = new AnimationModel(UI.AnimationType.None, 0);
                this.IsIconBoxReverse = false;
            }

            public bool IsSquareIcon { get; set; }
            public bool IsIconBoxReverse { get; set; }
            public ThemeColor IconColor { get; set; }
            public TextSize IconSize { get; set; }
            public IconBoxStyle Style { get; set; }
            public AnimationModel Animation { get; set; }
        }
    }
}