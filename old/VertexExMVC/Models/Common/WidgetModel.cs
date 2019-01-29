namespace ExpressMVC.Models.Common
{
    public class WidgetModel : ElementModelBase
    {
        public WidgetModel()
        {
            this.UIProps = new UIProp();
        }

        public WidgetModel(string name)
        {
            this.UIProps = new UIProp();
            this.Name = name;
        }

        public UIProp UIProps { get; set; }

        public class UIProp
        {
            public UIProp()
            {
            }
        }
    }
}