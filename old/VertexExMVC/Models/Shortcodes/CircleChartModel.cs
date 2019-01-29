namespace ExpressMVC.Models.Shortcodes
{
    public class CircleChartModel : ShortcodeModelBase
    {
        public CircleChartModel()
        {
            this.UIProps = new UIProp();
        }

        public UIProp UIProps { get; set; }

        public int Percent { get; set; }
        public string Text { get; set; }
        public string DetailText { get; set; }

        public class UIProp
        {
            public UIProp()
            {
                this.Size = 150;
                this.LineWidth = 4;
                this.BarColor = "#00bc87";
            }
            
            public string BarColor { get; set; }
            public int Size { get; set; }
            public int LineWidth { get; set; }
        }
    }
}