using ORMNorthwind.Business.Abstract;
using ORMNorthwind.Entities.Concrete;
using ORMNorthwind.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORMNorthwind.Web.Controllers
{
    public class ProductController : Controller
    {
        IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            List<Products> products = _service.GetAllProducts();
            return View(products);
        }
    }
}