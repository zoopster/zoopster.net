using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpressMVC.Models
{
    public class EntityModelBase: ShortcodeModelBase
    {
        public virtual int Id { get; set; }
    }
}