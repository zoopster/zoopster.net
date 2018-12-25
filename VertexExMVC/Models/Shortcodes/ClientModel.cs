using ExpressMVC.Models;
using System.Collections.Generic;
using System;

namespace ExpressMVC.Models.Shortcodes
{
    public class ClientModel : ShortcodeModelBase
    {
        public ClientModel()
        {
            this.Style = ClientStyles.Default;
            this.ClientType = ClientTypes.Carousel; 

            this.SingelItem = false;
            this.AutoPlay = true;
            this.Dots = false;
            this.DisplayCount = 6;
            this.RowCount = 1;

            this.Items = new List<ClientItemModel>();
        }

        public bool HasTooltip { get; set; }
        public List<ClientItemModel> Items { get; set; }
        public ClientStyles Style { get; set; }
        public ClientTypes ClientType { get; set; }

        #region ICarouselModel Members

        public bool SingelItem { get; set; }
        public bool AutoPlay { get; set; }
        public bool Dots { get; set; }
        public int DisplayCount { get; set; }
        public int RowCount { get; set; }
        public int Margin { get; set; }

        #endregion ICarouselModel Members
    }

    public class ClientItemModel
    {
        public string Logo { get; set; }
        public string Name { get; set; }
        public string SeName { get; set; }
    }

    public enum ClientStyles
    {
        Default, 
        Style1,
        Style2
    }

    public enum ClientTypes
    {
        Table,
        Carousel
    }
}