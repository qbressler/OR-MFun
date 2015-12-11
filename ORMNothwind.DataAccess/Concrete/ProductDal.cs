using OR_M_Data_Entities;
using ORMNorthwind.Entities.Concrete;
using ORMNothwind.DataAccess.Abstract;
using ORMNothwind.DataAccess.Concrete.ORM;
using ORMNothwind.DataAccess.Concrete.ORM.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMNothwind.DataAccess.Concrete
{
    public class ProductDal : ORMBase<Products, NorthwindContext>, IProductDal
    {
        public string GetProductNameById(int id)
        {
            using (var context = new NorthwindContext())
            {
                return context.From<Products>().Where(p => p.ProductID == id).Select(p => p.ProductName).First();
            }
        }
    }
}
