using ExpressMVC.Models.Blog;
using ExpressMVC.SampleData;
using ExpressMVC.UI;
using System.Linq;
using System.Web.Mvc;

namespace ExpressMVC.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Grid2Columns(int? page)
        {
            var model = BlogData.SampleData;
            model.UIProps.Layout = BlogLayout.Grid;
            model.UIProps.ColumnCount = 2;
            model.PageNumber = page;

            return View("Grid", model);
        }

        public ActionResult Grid3Columns(int? page)
        {
            var model = BlogData.SampleData;
            model.UIProps.Layout = BlogLayout.Grid;
            model.UIProps.ColumnCount = 3;
            model.PageNumber = page;

            return View("Grid", model);
        }

        public ActionResult Grid4Columns(int? page)
        {
            var model = BlogData.SampleData;
            model.UIProps.Layout = BlogLayout.Grid;
            model.UIProps.ColumnCount = 4;
            model.PageNumber = page;

            return View("Grid", model);
        }

        public ActionResult Masonry4Columns(int? page)
        {
            var model = BlogData.SampleData;
            model.UIProps.Layout = BlogLayout.Masonary;
            model.UIProps.ColumnCount = 4;
            model.PageNumber = page;

            return View("Masonry", model);
        }

        public ActionResult Masonry3Columns(int? page)
        {
            var model = BlogData.SampleData;
            model.UIProps.Layout = BlogLayout.Masonary;
            model.UIProps.ColumnCount = 3;
            model.PageNumber = page;

            return View("Masonry", model);
        }

        public ActionResult Masonry2Columns(int? page)
        {
            var model = BlogData.SampleData;
            model.UIProps.Layout = BlogLayout.Masonary;
            model.UIProps.ColumnCount = 2;
            model.PageNumber = page;

            return View("Masonry", model);
        }

        public ActionResult Masonry4ColumnsFullWith(int? page)
        {
            var model = BlogData.SampleData;
            model.UIProps.Layout = BlogLayout.Masonary;
            model.UIProps.ColumnCount = 4;
            model.PageNumber = page;

            return View(model);
        }

        public ActionResult GridFullWidth3Columns(int? page)
        {
            var model = BlogData.SampleData;
            model.UIProps.Layout = BlogLayout.Grid;
            model.UIProps.ColumnCount = 3;
            model.PageNumber = page;

            return View(model);
        }

        public ActionResult GridFullWidth4Columns(int? page)
        {
            var model = BlogData.SampleData;
            model.UIProps.Layout = BlogLayout.Grid;
            model.UIProps.ColumnCount = 4;
            model.PageNumber = page;

            return View(model);
        }

        public ActionResult GridFullWidth5Columns(int? page)
        {
            var model = BlogData.SampleData;
            model.UIProps.Layout = BlogLayout.Grid;
            model.UIProps.ColumnCount = 5;
            model.PageNumber = page;

            return View(model);
        }

        public ActionResult GridRightSidebar(int? page)
        {
            var model = BlogData.SampleData;
            model.UIProps.Layout = BlogLayout.Grid;
            model.PageNumber = page;

            return View(model);
        }

        public ActionResult GridLeftSidebar(int? page)
        {
            var model = BlogData.SampleData;
            model.UIProps.Layout = BlogLayout.Grid;
            model.PageNumber = page;

            return View(model);
        }

        public ActionResult MediumLeftSidebar(int? page)
        {
            var model = BlogData.SampleData;
            model.UIProps.Layout = BlogLayout.Masonary;
            model.PageNumber = page;

            return View(model);
        }

        public ActionResult MediumRightSidebar(int? page)
        {
            var model = BlogData.SampleData;
            model.UIProps.Layout = BlogLayout.Masonary;
            model.PageNumber = page;

            return View(model);
        }

        public ActionResult DefaultBothSidebar(int? page)
        {
            var model = BlogData.SampleData;
            model.UIProps.Layout = BlogLayout.Default;
            model.PageNumber = page;

            return View(model);
        }

        public ActionResult Default(int? page)
        {
            var model = BlogData.SampleData;
            model.UIProps.Layout = BlogLayout.Default;
            model.PageNumber = page;

            return View(model);
        }

        public ActionResult DefaultRightSidebar(int? page)
        {
            var model = BlogData.SampleData;
            model.UIProps.Layout = BlogLayout.Default;
            model.PageNumber = page;

            return View(model);
        }

        public ActionResult Single()
        {
            return View();
        }

        public ActionResult Detail(int? id)
        {
            BlogPostModel model = BlogData.SampleData.BlogPosts.FirstOrDefault();
            if (id.HasValue && id.Value > 0)
            {
                model = BlogData.SampleData.BlogPosts.Where(s => s.Id == id.Value).FirstOrDefault();
            } 
            return View(model);
        }

        public ActionResult SingleSidebar()
        { 
            return View();
        }
    }
}