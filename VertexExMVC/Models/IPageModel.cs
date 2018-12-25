using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpressMVC.Models
{
    public interface IPageModel
    {
        int PageSize { get; set; }
        int? PageNumber { get; set; }
    }
}