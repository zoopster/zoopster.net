using ExpressMVC.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpressMVC.Models.Common
{
    public class MenuModel
    {
        public MenuModel()
        {
            this.Visible = true; 
        }

        public MenuModel(string text, string url)
        {
            this.Visible = true;
            this.Text = text;
            this.Url = url;
        }

        public MenuModel(string megaMenuTitle)
        {
            this.Visible = true;
            this.MegaMenuTitle = megaMenuTitle;
        }

        public MenuModel(string text, string url, bool isMegaMenu)
        {
            this.Visible = true;
            this.Text = text;
            this.Url = url;
            this.IsMegaMenu = isMegaMenu;
        }

        public string Icon { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }

        //public string ActionName { get; set; }
        //public string ControllerName { get; set; }
         
        public string Summary { get; set; }

        public bool Visible { get; set; }
        public bool Selected { get; set; }

        public string BadgeText { get; set; }
        public BadgeStyle BadgeStyle { get; set; }

        public bool IsMegaMenu { get; set; }
        public string MegaMenuTitle { get; set; }

        public List<MenuModel> Childs { get; set; }


        public bool HasChild()
        {
            return this.Childs != null && this.Childs.Count > 0;
        }

        public string IsActive
        {
            get
            {
                string activeClassName = "active";
                if (this.Url == HttpContext.Current.Request.Url.PathAndQuery)
                    return activeClassName;

                if (this.HasChild())
                {
                    var activeMenu = this._hasActive(this, HttpContext.Current.Request.Url.PathAndQuery);
                    return activeMenu != null ? activeClassName : string.Empty;
                }

                return string.Empty;
            }
        }

        MenuModel _hasActive(MenuModel rootNode, string stringToFind)
        {
            if (rootNode.Url == stringToFind) return rootNode;
            if (rootNode.HasChild())
            {
                foreach (var child in rootNode.Childs)
                {
                    var n = _hasActive(child, stringToFind);
                    if (n != null) return n;
                }
            }
            return null;
        }
    }
}