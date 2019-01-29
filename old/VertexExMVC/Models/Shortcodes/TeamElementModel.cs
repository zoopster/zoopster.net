using ExpressMVC.UI;
using System.Collections.Generic;

namespace ExpressMVC.Models.Shortcodes
{
    public class TeamElementModel: ShortcodeModelBase
    {
        public TeamElementModel()
        {
            this.UIProps = new UIProp();
            this.SocialLinks = new List<SocialIconModel>();
        }

        public UIProp UIProps { get; set; }
         
        public string Name { get; set; }
        public string Position { get; set; }
        public string Src { get; set; }
        public string Description { get; set; }
        public List<SocialIconModel> SocialLinks { get; set; } 

        public class UIProp
        {
            public UIProp()
            {
                this.IsTextCenter = true;
                this.Style = TeamElementStyle.Style1;
            }

            public bool IsTextCenter { get; set; }
            public bool IsRaundedImage { get; set; }
            public TeamElementStyle Style { get; set; }
        }
    } 
}