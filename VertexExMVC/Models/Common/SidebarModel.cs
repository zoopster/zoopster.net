namespace ExpressMVC.Models.Common
{
    public class SidebarModel: ElementModelBase
    {
        public SidebarModel() { }

        public SidebarModel(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.Name = name;
            }
        }
    }
}