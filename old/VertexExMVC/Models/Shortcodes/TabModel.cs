using Antlr.Runtime.Misc;
using ExpressMVC.UI;
using System.Collections.Generic;
using System.Web.WebPages;

namespace ExpressMVC.Models.Shortcodes
{
    public class TabModel : ShortcodeModelBase
    {
        public TabModel()
        {
            this.Items = new List<TabItemModel>();
            this.Alignment = Alignment.Left;
            this.Style = TabStyle.Default;
        }

        #region Members

        public List<TabItemModel> Items { get; set; }

        #endregion Members

        #region UI Props

        public Alignment Alignment { get; set; }
        public bool IsVertical { get; set; }
        public TabStyle Style { get; set; }

        #endregion UI Props
    }

    public class TabItemModel
    {
        public string Title { get; set; }
        public Func<dynamic, HelperResult> Content { get; set; }
        public bool IsActive { get; set; }
        public string TabIcon { get; set; }
    }
}