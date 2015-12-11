using ORMNorthwind.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORMNorthwind.Entities.Concrete;
using ORMNothwind.DataAccess.Abstract;

namespace ORMNorthwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        
        public List<Categories> GetCategories()
        {
            return _categoryDal.Get();
        }
    }
}
