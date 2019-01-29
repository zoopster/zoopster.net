using ExpressMVC.UI;

namespace ExpressMVC.Models.Shortcodes
{
    public class ProgressBarModel : ShortcodeModelBase
    {
        public ProgressBarModel()
        {
            this.UIProps = new UIProp();
            this.Label = new TextElement(string.Empty);
        }

        #region Members

        public UIProp UIProps { get; set; }
         
        public int Value { get; set; }
        public int? Delay { get; set; }
        public TextElement Label { get; set; }

        #endregion Members 

        /// <summary>
        /// UIProp
        /// </summary>
        public class UIProp
        {
            public UIProp()
            {
                this.Size = Size.Default;
                this.Color = ThemeColor.Primary;
                this.ShowValue = true;
            }
            
            public ThemeColor Color { get; set; }
            public Size Size { get; set; }
            public bool IsLabelOutside { get; set; }
            public bool ShowValue { get; set; }
        }
    }
}