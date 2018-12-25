using ExpressMVC.UI;
using System.Collections.Generic;

namespace ExpressMVC.Models.Blog
{
    public class BlogListModel : ShortcodeModelBase, IPageModel
    {
        public BlogListModel()
        {
            this.UIProps = new UIProp();
            this.AvailableCategiries = new List<BlogCategoryModel>();
            this.BlogPosts = new List<BlogPostModel>();
            this.PageSize = 9;
        }

        public UIProp UIProps { get; set; }
        public List<BlogPostModel> BlogPosts { get; set; }
        public List<BlogCategoryModel> AvailableCategiries { get; set; }

        #region IPage Members

        public int PageSize { get; set; }
        public int? PageNumber { get; set; }

        #endregion IPage Members

        public class UIProp
        {
            public UIProp()
            {
                this.ColumnCount = 3;
                this.Layout = BlogLayout.Grid;
            }

            public short ColumnCount { get; set; }
            public BlogLayout Layout { get; set; }

            public string GetColumnClass()
            {
                string columnClass = "col-sm-6 col-md-4";
                if (this.ColumnCount == 5)
                    columnClass = "col-md-1-5";
                else if (this.ColumnCount == 4)
                    columnClass = "col-sm-6 col-md-3";
                else if (this.ColumnCount == 3)
                    columnClass = "col-sm-6 col-md-4";
                else if (this.ColumnCount == 2)
                    columnClass = "col-sm-6 col-md-6";

                return columnClass;
            }
        }
    }
}