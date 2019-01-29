using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpressMVC.Models
{
    public class ShortcodeModelBase
    {
        public string ClassName { get; set; }
        public string CssStyle { get; set; }

        public string GetCssStyle()
        {
            if (!string.IsNullOrEmpty(this.CssStyle))
            {
                return "style=" + this.CssStyle.Replace(" ", "") + "";
            }
            return string.Empty;
        }
    }
}