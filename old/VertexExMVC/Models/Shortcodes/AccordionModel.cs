using ExpressMVC.UI;
using System.Collections.Generic;

namespace ExpressMVC.Models.Shortcodes
{
    public class AccordionModel : ShortcodeModelBase
    {
        public AccordionModel()
        {
            this.UIProps = new UIProp();
            this.Items = new List<AccordionItemModel>();
            this.IsToggleMode = false;
        }

        public UIProp UIProps { get; set; }

        public List<AccordionItemModel> Items { get; set; }
        public bool IsToggleMode { get; set; }

        public class UIProp
        {
            public UIProp()
            {
                this.Style = AccordionStyle.Default;
                this.Size = Size.Default;
            }

            public AccordionStyle Style { get; set; }
            public Size Size { get; set; }
        }
    }

    public class AccordionItemModel
    {
        public string TitleIcon { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsExpanded { get; set; }
    }
}