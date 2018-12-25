using ExpressMVC.UI;

namespace ExpressMVC.Models.Common
{
    public class FooterModel : ElementModelBase
    {
        public FooterModel()
        {
            this.UIProps = new UIProp();
        }

        public FooterModel(string name)
        {
            this.UIProps = new UIProp();
            this.Name = string.IsNullOrEmpty(name) ? "Default" : name;
        }

        public UIProp UIProps { get; set; }

        public class UIProp
        {
            public UIProp()
            {
                this.BGColor = ThemeColor.Dark;
            }

            public ThemeColor BGColor { get; set; }
        }
    }
}