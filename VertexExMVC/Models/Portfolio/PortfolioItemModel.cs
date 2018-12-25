using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpressMVC.Models.Portfolio
{
    public class PortfolioItemModel : EntityModelBase
    {
        public PortfolioItemModel()
        {
            this.User = new UserModel();
            this.CreatedOn = DateTime.Now;
            this.Images = new List<string>();
            this.Categiries = new List<PortfolioCategoryModel>();
        }

        /// <summary>
        /// Gets or sets the image of portfolio item
        /// </summary>
        public string Src { get; set; }

        /// <summary>
        /// If you have more than 1 image use this prop.
        /// </summary>
        public List<String> Images { get; set; }
         
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }

        public UserModel User { get; set; }
        public List<PortfolioCategoryModel> Categiries { get; set; }
    }
}