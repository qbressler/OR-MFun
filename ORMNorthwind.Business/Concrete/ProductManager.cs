using ORMNorthwind.Business.Abstract;
using ORMNorthwind.Entities.Concrete;
using ORMNothwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMNorthwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Products> GetAllProducts()
        {
            return _productDal.GetList(p => p.Discontinued == false);
        }
    }
}
