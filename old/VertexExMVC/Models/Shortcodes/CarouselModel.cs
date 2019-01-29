using ExpressMVC.UI;
using System;
using System.Collections.Generic;

namespace ExpressMVC.Models.Shortcodes
{
    public class CarouselModel : ShortcodeModelBase
    {
        public CarouselModel()
        {
            this.UIProps = new UIProp();
            this.Items = new List<String>();
            this.DisplayCount = 1;
        }

        #region Members

        public UIProp UIProps { get; set; }
        public List<String> Items { get; set; }
        public int DisplayCount { get; set; }

        #endregion Members

        /// <summary>
        /// UIProp
        /// </summary>
        public class UIProp
        {
            public UIProp()
            {
                this.AnimateIn = AnimationType.fadeIn;
                this.AnimateOut = AnimationType.fadeOut;
                this.Style = CarouselStyle.DotsBottom;
            }

            public int? Margin { get; set; }
            public bool? AutoPlay { get; set; }
            public bool? Loop { get; set; }

            public AnimationType AnimateIn { get; set; }
            public AnimationType AnimateOut { get; set; }
            public CarouselStyle Style { get; set; }
        }
    } 
}