using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ORMNorthwind.Web.Models
{
    public class ProductsViewModel
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public bool Discontinued { get; set; }

    }
}