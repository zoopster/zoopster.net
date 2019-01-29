using ExpressMVC.UI;
using System.Collections.Generic;

namespace ExpressMVC.Models.Portfolio
{
    public class PortfolioListModel : ShortcodeModelBase, IPageModel
    {
        public PortfolioListModel()
        {
            this.UIProps = new UIProp();

            this.Items = new List<PortfolioItemModel>();
            this.Categiries = new List<PortfolioCategoryModel>();
            this.PageSize = 6;
        }

        public UIProp UIProps { get; set; }
        public List<PortfolioItemModel> Items { get; set; }
        public List<PortfolioCategoryModel> Categiries { get; set; }

        #region IPage Members

        public int PageSize { get; set; }
        public int? PageNumber { get; set; }

        #endregion IPage Members

        public class UIProp
        {
            public UIProp()
            {
                this.ColumnCount = 3;
                this.Layout = PortfolioLayout.Grid;
                this.Variation = PortfolioVariation.Default;
                this.ShowFilter = true;
                this.GapHorizontal = 40;
                this.GapVertical = 30;
            }

            public short ColumnCount { get; set; }
            public bool ShowFilter { get; set; }
            public bool ShowSorting { get; set; }
            public bool ShowPaginations { get; set; }
            public int GapHorizontal { get; set; }
            public int GapVertical { get; set; }
            public PortfolioVariation Variation { get; set; }
            public PortfolioLayout Layout { get; set; }

            public string GetCssGridClass()
            {
                string gridClass = "col-sm-6 col-md-4 col-lg-3";
                if (this.ColumnCount == 1)
                    gridClass = "col-12";

                else if (this.ColumnCount == 2)
                    gridClass = "col-sm-6";

                else if (this.ColumnCount == 3)
                    gridClass = "col-sm-6 col-md-4";

                else if (this.ColumnCount == 4)
                    gridClass = "col-sm-6 col-md-4 col-lg-3";

                else if (this.ColumnCount == 5)
                    gridClass = "col-sm-6 col-md-3 col-lg-1-5";

                else if (this.ColumnCount == 6)
                    gridClass = "col-sm-6 col-md-3 col-lg-2";

                return gridClass;
            }
        }
    }
}