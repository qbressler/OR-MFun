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

    }
}
