using ExpressMVC.UI;

namespace ExpressMVC.Models.Shortcodes
{
    public class AlertModel: ShortcodeModelBase
    {
        public AlertModel()
        {
            this.UIProps = new UIProp();

            this.Type = AlertType.Default; 
        }

        public UIProp UIProps { get; set; }

        public AlertType Type { get; set; }
        public string Content { get; set; }
        public bool Dismissible { get; set; }


        /// <summary>
        /// UIProp
        /// </summary>
        public class UIProp
        {
            public UIProp()
            {
                this.Size = Size.Default;
                this.Color = ThemeColor.Default;
            }
            public Size Size { get; set; }
            public ThemeColor Color { get; set; }
        }
    }
}