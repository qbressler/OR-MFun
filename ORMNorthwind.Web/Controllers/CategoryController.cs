using ORMNorthwind.Business.Abstract;
using ORMNorthwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORMNorthwind.Web.Controllers
{
    public class CategoryController : Controller
    {

        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        // GET: Category
        public ActionResult Index()
        {
            List<Categories> categories = _categoryService.GetCategories();
            return View(categories);
        }
    }
}