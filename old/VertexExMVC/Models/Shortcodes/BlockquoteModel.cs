using ExpressMVC.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpressMVC.Models.Shortcodes
{
    public class BlockquoteModel : ShortcodeModelBase
    {
        public BlockquoteModel()
        {
            this.Alignment = Alignment.Left;
            this.TextSize = Size.Default;
            this.ShowIcon = false;
            this.ShowBorder = false;
            this.UseAlternateFont = false;
        }


        #region Members

        public string Content { get; set; }
        public string SourceTitle { get; set; }
        public string SomeoneFamousIn { get; set; }

        #endregion Members

        #region UI Props

        public Size TextSize { get; set; }
        public Alignment Alignment { get; set; }
        public bool ShowIcon { get; set; }
        public bool ShowBorder { get; set; }
        public bool UseAlternateFont { get; set; }

        #endregion  UI Props
    }
}