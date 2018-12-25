namespace ExpressMVC.Models.Common
{
    public class HeaderTopbarModel : ElementModelBase
    {
        public HeaderTopbarModel()
        {
            this.Name = "_Topbar.Default";
            this.ShowTopbar = false;
        }

        public bool ShowTopbar { get; set; }
    }
}