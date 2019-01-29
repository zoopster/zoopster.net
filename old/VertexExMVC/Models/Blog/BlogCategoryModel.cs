using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpressMVC.Models.Blog
{
    public class BlogCategoryModel: EntityModelBase
    {
        public BlogCategoryModel()
        {

        }

        public string Name { get; set; } 
        public string SeName { get; set; }
    }
}