using ExpressMVC.SampleData;
using ExpressMVC.UI;
using System.Web.Mvc;

namespace ExpressMVC.Controllers
{
    public class PortfolioController : Controller
    {
        public ActionResult Grid2Columns(int? page)
        {
            var model = PortfolioData.GridData;
            model.PageNumber = page;
            model.UIProps.ColumnCount = 2;

            return View("Grid", model);
        }

        public ActionResult Grid3Columns(int? page)
        {
            var model = PortfolioData.GridData;
            model.PageNumber = page;
            model.UIProps.ColumnCount = 3;

            return View("Grid", model);
        }

        public ActionResult Grid4Columns(int? page)
        {
            var model = PortfolioData.GridData;
            model.PageNumber = page;
            model.PageSize = 8;
            model.UIProps.ColumnCount = 4;

            return View("Grid", model);
        }

        public ActionResult Grid5Columns(int? page)
        {
            var model = PortfolioData.GridData;
            model.PageNumber = page;
            model.PageSize = 10;
            model.UIProps.ColumnCount = 5;

            return View("Grid", model);
        }

        public ActionResult Grid6Columns(int? page)
        {
            var model = PortfolioData.GridData;
            model.PageNumber = page;
            model.PageSize = 12;
            model.UIProps.ColumnCount = 6;

            return View("Grid", model);
        }

        public ActionResult Masonry2Columns(int? page)
        {
            var model = PortfolioData.MasonryData;
            model.PageNumber = page;
            model.UIProps.ColumnCount = 2;

            return View("Masonry", model);
        }

        public ActionResult Masonry3Columns(int? page)
        {
            var model = PortfolioData.MasonryData;
            model.PageNumber = page;
            model.UIProps.ColumnCount = 3;
            model.UIProps.Layout = PortfolioLayout.Masonry;

            return View("Masonry", model);
        }

        public ActionResult Masonry4Columns(int? page)
        {
            var model = PortfolioData.MasonryData;
            model.PageNumber = page;
            model.PageSize = 8;
            model.UIProps.ColumnCount = 4;
            model.UIProps.Layout = PortfolioLayout.Masonry;

            return View("Masonry", model);
        }

        public ActionResult Masonry5Columns(int? page)
        {
            var model = PortfolioData.MasonryData;
            model.PageNumber = page;
            model.PageSize = 10;
            model.UIProps.ColumnCount = 5;
            model.UIProps.Layout = PortfolioLayout.Masonry;

            return View("Masonry", model);
        }
        
        public ActionResult LeftSidebar(int? page)
        {
            var model = PortfolioData.MasonryData;
            model.PageNumber = page;
            model.UIProps.ColumnCount = 2;
            model.UIProps.Layout = PortfolioLayout.Masonry;

            return View("LeftSidebar", model);
        }

        public ActionResult RightSidebar(int? page)
        {
            var model = PortfolioData.MasonryData;
            model.PageNumber = page;
            model.UIProps.ColumnCount = 2;
            model.UIProps.Layout = PortfolioLayout.Masonry;

            return View("RightSidebar", model);
        }

        public ActionResult BothSidebar(int? page)
        {
            var model = PortfolioData.MasonryData;
            model.PageNumber = page;
            model.UIProps.ColumnCount = 2;
            model.UIProps.Layout = PortfolioLayout.Masonry;

            return View("BothSidebar", model);
        }

        public ActionResult SingleGallery()
        {
            return View();
        }

        public ActionResult SingleSmallSlider()
        {
            return View();
        }

        public ActionResult Detail(int? id)
        {
            return View();
        }
    }
}