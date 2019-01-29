using ExpressMVC.Models;
using ExpressMVC.UI;

namespace ExpressMVC.Models.Shortcodes
{
    public class CounterModel : ShortcodeModelBase
    {
        public CounterModel()
        {
            this.UIProps = new UIProp();
        }

        public CounterModel(UIProp uiProps)
        {
            this.UIProps = uiProps;
        }

        public UIProp UIProps { get; set; }

        public decimal To { get; set; }
        public string Label { get; set; }
        public string Append { get; set; }
        public string Icon { get; set; }
    }


    public class UIProp
    {
        public UIProp()
        {
            this.Animation = new AnimationModel(UI.AnimationType.None, 0);
            this.Size = CounterSize.Default;
            this.Color = ThemeColor.Default;
        }

        public AnimationModel Animation { get; set; }
        public CounterSize Size { get; set; }
        public ThemeColor Color { get; set; }
    }
}