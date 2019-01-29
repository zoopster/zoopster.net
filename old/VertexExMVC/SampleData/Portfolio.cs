using ExpressMVC.Models.Portfolio;
using ExpressMVC.UI;
using System.Collections.Generic;

namespace ExpressMVC.SampleData
{
    public class PortfolioData
    {
        public static PortfolioListModel GetData(PortfolioLayout layout = PortfolioLayout.Pracia)
        {
            var artCategory = new PortfolioCategoryModel() { Id = 1, Name = "Art", SeName = "#" };
            var photographyCategory = new PortfolioCategoryModel() { Id = 2, Name = "Photography", SeName = "#" };
            var mockupCategory = new PortfolioCategoryModel() { Id = 3, Name = "Mockup", SeName = "#" };
            var brandingCategory = new PortfolioCategoryModel() { Id = 4, Name = "Branding", SeName = "#" };
            var identityCategory = new PortfolioCategoryModel() { Id = 5, Name = "Identity", SeName = "#" };
            
            var items = new List<PortfolioItemModel>();
            items.Add(new PortfolioItemModel()
            {
                Id = 1,
                Title = "Get Coffie",
                Src = "/Content/img/portfolio/p_1.jpg",
                Categiries = new List<PortfolioCategoryModel>() { artCategory } 
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 2,
                Title = "Business Card",
                Src = "/Content/img/portfolio/p_2.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { artCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 3,
                Title = "The Bottle",
                Src = "/Content/img/portfolio/p_3.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { artCategory, photographyCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 4,
                Title = "Spherical Vase",
                Src = "/Content/img/portfolio/p_9.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { mockupCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 5,
                Title = "Lucifer Match",
                Src = "/Content/img/portfolio/p_4.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { brandingCategory, mockupCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 6,
                Title = "Cream Cake",
                Src = "/Content/img/portfolio/p_5.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { brandingCategory, identityCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 7,
                Title = "Avocado",
                Src = "/Content/img/portfolio/p_6.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { artCategory, mockupCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 8,
                Title = "Headphone",
                Src = "/Content/img/portfolio/p_7.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { artCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 9,
                Title = "Open Letter",
                Src = "/Content/img/portfolio/p_8.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { identityCategory }
            });

            var model = new PortfolioListModel();
            model.Categiries.Add(artCategory);
            model.Categiries.Add(photographyCategory);
            model.Categiries.Add(mockupCategory);
            model.Categiries.Add(brandingCategory);
            model.Categiries.Add(identityCategory); 
            model.Items = items;
            model.UIProps.Layout = layout;

            return model;
        }

        public static PortfolioListModel GetMasonryData(PortfolioLayout layout = PortfolioLayout.Brasilia)
        {
            var artCategory = new PortfolioCategoryModel() { Id = 1, Name = "Art", SeName = "#" };
            var photographyCategory = new PortfolioCategoryModel() { Id = 2, Name = "Photography", SeName = "#" };
            var mockupCategory = new PortfolioCategoryModel() { Id = 3, Name = "Mockup", SeName = "#" };
            var brandingCategory = new PortfolioCategoryModel() { Id = 4, Name = "Branding", SeName = "#" };
            var identityCategory = new PortfolioCategoryModel() { Id = 5, Name = "Identity", SeName = "#" };

            var items = new List<PortfolioItemModel>();
            items.Add(new PortfolioItemModel()
            {
                Id = 1,
                Title = "The Bottle",
                Src = "/Content/img/portfolio/p_3.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { artCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 2,
                Title = "Spherical Vase",
                Src = "/Content/img/portfolio/p_9.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { mockupCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 3,
                Title = "Lucifer Match",
                Src = "/Content/img/portfolio/p_4.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { brandingCategory, mockupCategory}
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 4,
                Title = "Cream Cake",
                Src = "/Content/img/portfolio/p_15.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { mockupCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 5,
                Title = "Avocado",
                Src = "/Content/img/portfolio/p_6.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { brandingCategory, mockupCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 6,
                Title = "Open Letter",
                Src = "/Content/img/portfolio/p_8.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { brandingCategory, identityCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 7,
                Title = "Breakfast",
                Src = "/Content/img/portfolio/p_9.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { artCategory, mockupCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 8,
                Title = "The Objects",
                Src = "/Content/img/portfolio/p_10.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { artCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 9,
                Title = "Photography",
                Src = "/Content/img/portfolio/p_13.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { identityCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 10,
                Title = "Foot Brush",
                Src = "/Content/img/portfolio/p_12.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { identityCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 11,
                Title = "Sweeper & Funnel",
                Src = "/Content/img/portfolio/p_16.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { identityCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 12,
                Title = "Sky Planter",
                Src = "/Content/img/portfolio/p_17.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { identityCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Id = 13,
                Title = "Analog Clock",
                Src = "/Content/img/portfolio/p_18.jpg", 
                Categiries = new List<PortfolioCategoryModel>() { mockupCategory }
            });
            
            var model = new PortfolioListModel();
            model.Categiries.Add(artCategory);
            model.Categiries.Add(photographyCategory);
            model.Categiries.Add(mockupCategory);
            model.Categiries.Add(brandingCategory);
            model.Categiries.Add(identityCategory);
            model.Items = items;
            model.UIProps.Layout = layout;

            return model;
        }

        public static PortfolioListModel GetPraiaData()
        {
            var artCategory = new PortfolioCategoryModel() { Id = 1, Name = "Art", SeName = "#" };
            var photographyCategory = new PortfolioCategoryModel() { Id = 2, Name = "Photography", SeName = "#" };
            var mockupCategory = new PortfolioCategoryModel() { Id = 3, Name = "Mockup", SeName = "#" };
            var brandingCategory = new PortfolioCategoryModel() { Id = 4, Name = "Branding", SeName = "#" };
            var identityCategory = new PortfolioCategoryModel() { Id = 5, Name = "Identity", SeName = "#" };

            var items = new List<PortfolioItemModel>();
            items.Add(new PortfolioItemModel()
            {
                Title = "Just some stuffs",
                Src = "/Content/img/portfolio/just-some-stuff-800x500.jpg",
                Id = 1,
                Categiries = new List<PortfolioCategoryModel>() { artCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Title = "WoodWork",
                Src = "/Content/img/portfolio/woodwork-800x500.jpg",
                Id = 1,
                Categiries = new List<PortfolioCategoryModel>() { mockupCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Title = "Urban Fixie",
                Src = "/Content/img/portfolio/urban-fixie-800x500.jpg",
                Id = 1,
                Categiries = new List<PortfolioCategoryModel>() { brandingCategory, mockupCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Title = "Cook Crunch",
                Src = "/Content/img/portfolio/cook-and-crunch-800x500.jpg",
                Id = 1,
                Categiries = new List<PortfolioCategoryModel>() { mockupCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Title = "Just a quote",
                Src = "/Content/img/portfolio/quote-image-800x500.jpg",
                Id = 1,
                Categiries = new List<PortfolioCategoryModel>() { brandingCategory, mockupCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Title = "My sunday morning",
                Src = "/Content/img/portfolio/my-sunday-morning-1-800x500.jpg",
                Id = 1,
                Categiries = new List<PortfolioCategoryModel>() { brandingCategory, identityCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Title = "Foggy day",
                Src = "/Content/img/portfolio/foggy-day-800x500.jpg",
                Id = 1,
                Categiries = new List<PortfolioCategoryModel>() { artCategory, mockupCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Title = "HomeWork",
                Src = "/Content/img/portfolio/homework-800x500.jpg",
                Id = 1,
                Categiries = new List<PortfolioCategoryModel>() { artCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Title = "Alpha DCO",
                Src = "/Content/img/portfolio/alpha-deco-800x500.jpg",
                Id = 1,
                Categiries = new List<PortfolioCategoryModel>() { identityCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Title = "Just a link",
                Src = "/Content/img/portfolio/just-a-link-800x500.jpg",
                Id = 1,
                Categiries = new List<PortfolioCategoryModel>() { identityCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Title = "Beyond the pines",
                Src = "/Content/img/portfolio/beyound-the-pines-800x500.jpg",
                Id = 1,
                Categiries = new List<PortfolioCategoryModel>() { identityCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Title = "Architecture",
                Src = "/Content/img/portfolio/architecture-800x500.jpg",
                Id = 1,
                Categiries = new List<PortfolioCategoryModel>() { identityCategory }
            });

            items.Add(new PortfolioItemModel()
            {
                Title = "Suspended library",
                Src = "/Content/img/portfolio/suspended-library-800x500.jpg",
                Id = 1,
                Categiries = new List<PortfolioCategoryModel>() { mockupCategory }
            });

            var model = new PortfolioListModel();
            model.Categiries.Add(artCategory);
            model.Categiries.Add(photographyCategory);
            model.Categiries.Add(mockupCategory);
            model.Categiries.Add(brandingCategory);
            model.Categiries.Add(identityCategory);
            model.Items = items;
            model.UIProps.Layout = PortfolioLayout.Praia;

            return model;
        }


        public static PortfolioListModel GridData
        {
            get
            {
                var artCategory = new PortfolioCategoryModel() { Id = 1, Name = "Art", SeName = "#" };
                var photographyCategory = new PortfolioCategoryModel() { Id = 2, Name = "Photography", SeName = "#" };
                var mockupCategory = new PortfolioCategoryModel() { Id = 3, Name = "Mockup", SeName = "#" };
                var brandingCategory = new PortfolioCategoryModel() { Id = 4, Name = "Branding", SeName = "#" };
                var identityCategory = new PortfolioCategoryModel() { Id = 5, Name = "Identity", SeName = "#" };

                var items = new List<PortfolioItemModel>();
                items.Add(new PortfolioItemModel()
                {
                    Title = "Get Coffie",
                    Src = "/Content/img/portfolio/p_1.jpg",
                    Id = 1,
                    Categiries = new List<PortfolioCategoryModel>() { artCategory }
                });

                items.Add(new PortfolioItemModel()
                {
                    Title = "Business Card",
                    Src = "/Content/img/portfolio/p_2.jpg",
                    Id = 1,
                    Categiries = new List<PortfolioCategoryModel>() { artCategory }
                });

                items.Add(new PortfolioItemModel()
                {
                    Title = "The Bottle",
                    Src = "/Content/img/portfolio/p_3.jpg",
                    Id = 1,
                    Categiries = new List<PortfolioCategoryModel>() { artCategory, photographyCategory }
                });

                items.Add(new PortfolioItemModel()
                {
                    Title = "Spherical Vase",
                    Src = "/Content/img/portfolio/p_9.jpg",
                    Id = 1,
                    Categiries = new List<PortfolioCategoryModel>() { mockupCategory }
                });

                items.Add(new PortfolioItemModel()
                {
                    Title = "Lucifer Match",
                    Src = "/Content/img/portfolio/p_4.jpg",
                    Id = 1,
                    Categiries = new List<PortfolioCategoryModel>() { brandingCategory, mockupCategory }
                });

                items.Add(new PortfolioItemModel()
                {
                    Title = "Cream Cake",
                    Src = "/Content/img/portfolio/p_5.jpg",
                    Id = 1,
                    Categiries = new List<PortfolioCategoryModel>() { brandingCategory, identityCategory }
                });

                items.Add(new PortfolioItemModel()
                {
                    Title = "Avocado",
                    Src = "/Content/img/portfolio/p_6.jpg",
                    Id = 1,
                    Categiries = new List<PortfolioCategoryModel>() { artCategory, mockupCategory }
                });

                items.Add(new PortfolioItemModel()
                {
                    Title = "Headphone",
                    Src = "/Content/img/portfolio/p_7.jpg",
                    Id = 1,
                    Categiries = new List<PortfolioCategoryModel>() { artCategory }
                });

                items.Add(new PortfolioItemModel()
                {
                    Title = "Open Letter",
                    Src = "/Content/img/portfolio/p_8.jpg",
                    Id = 1,
                    Categiries = new List<PortfolioCategoryModel>() { identityCategory }
                });

                var model = new PortfolioListModel();
                model.Categiries.Add(artCategory);
                model.Categiries.Add(photographyCategory);
                model.Categiries.Add(mockupCategory);
                model.Categiries.Add(brandingCategory);
                model.Categiries.Add(identityCategory);
                model.Items = items;
                model.UIProps.Layout = PortfolioLayout.Grid;

                return model;
            }
        }
         
        public static PortfolioListModel MasonryData
        {
            get
            {
                var artCategory = new PortfolioCategoryModel() { Id = 1, Name = "Art", SeName = "#" };
                var photographyCategory = new PortfolioCategoryModel() { Id = 2, Name = "Photography", SeName = "#" };
                var mockupCategory = new PortfolioCategoryModel() { Id = 3, Name = "Mockup", SeName = "#" };
                var brandingCategory = new PortfolioCategoryModel() { Id = 4, Name = "Branding", SeName = "#" };
                var identityCategory = new PortfolioCategoryModel() { Id = 5, Name = "Identity", SeName = "#" };

                var items = new List<PortfolioItemModel>();
                items.Add(new PortfolioItemModel()
                {
                    Title = "Get Coffie",
                    Src = "/Content/img/portfolio/p_1.jpg",
                    Id = 1,
                    Categiries = new List<PortfolioCategoryModel>() { artCategory }
                });

                items.Add(new PortfolioItemModel()
                {
                    Title = "Business Card",
                    Src = "/Content/img/portfolio/p_2.jpg",
                    Id = 1,
                    Categiries = new List<PortfolioCategoryModel>() { artCategory }
                });

                items.Add(new PortfolioItemModel()
                {
                    Title = "The Bottle",
                    Src = "/Content/img/portfolio/p_3.jpg",
                    Id = 1,
                    Categiries = new List<PortfolioCategoryModel>() { artCategory, photographyCategory }
                });

                items.Add(new PortfolioItemModel()
                {
                    Title = "Spherical Vase",
                    Src = "/Content/img/portfolio/p_9.jpg",
                    Id = 1,
                    Categiries = new List<PortfolioCategoryModel>() { mockupCategory }
                });

                items.Add(new PortfolioItemModel()
                {
                    Title = "Lucifer Match",
                    Src = "/Content/img/portfolio/p_4.jpg",
                    Id = 1,
                    Categiries = new List<PortfolioCategoryModel>() { brandingCategory, mockupCategory }
                });

                items.Add(new PortfolioItemModel()
                {
                    Title = "Cream Cake",
                    Src = "/Content/img/portfolio/p_5.jpg",
                    Id = 1,
                    Categiries = new List<PortfolioCategoryModel>() { brandingCategory, identityCategory }
                });

                items.Add(new PortfolioItemModel()
                {
                    Title = "Avocado",
                    Src = "/Content/img/portfolio/p_6.jpg",
                    Id = 1,
                    Categiries = new List<PortfolioCategoryModel>() { artCategory, mockupCategory }
                });

                items.Add(new PortfolioItemModel()
                {
                    Title = "Headphone",
                    Src = "/Content/img/portfolio/p_7.jpg",
                    Id = 1,
                    Categiries = new List<PortfolioCategoryModel>() { artCategory }
                });

                items.Add(new PortfolioItemModel()
                {
                    Title = "Open Letter",
                    Src = "/Content/img/portfolio/p_8.jpg",
                    Id = 1,
                    Categiries = new List<PortfolioCategoryModel>() { identityCategory }
                });

                var model = new PortfolioListModel();
                model.Categiries.Add(artCategory);
                model.Categiries.Add(photographyCategory);
                model.Categiries.Add(mockupCategory);
                model.Categiries.Add(brandingCategory);
                model.Categiries.Add(identityCategory); 
                model.UIProps.Layout = PortfolioLayout.Grid;

                model.Items = items;

                return model;
            }
        }
    }
}