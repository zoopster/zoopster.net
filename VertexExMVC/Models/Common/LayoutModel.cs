using ExpressMVC.UI;

namespace ExpressMVC.Models.Common
{
    public class LayoutModel
    {
        public LayoutModel()
        {
            // Set default value
            this.Layout = LayoutType.Default;
        }

        public LayoutType Layout { get; set; }
    }
}