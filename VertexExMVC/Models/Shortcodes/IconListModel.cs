using System.Collections.Generic;

namespace ExpressMVC.Models.Shortcodes
{
    public class IconListModel
    {
        public IconListModel()
        {
            this.IconItems = new List<IconListItemModel>();
        }

        public List<IconListItemModel> IconItems { get; set; }
    }

    public class IconListItemModel
    {
        public IconListItemModel()
        {
            this.IconListItems = new List<IconListItemModel>();
        }

        public string Text { get; set; }
        public string Icon { get; set; }

        public List<IconListItemModel> IconListItems { get; set; }
    }
}