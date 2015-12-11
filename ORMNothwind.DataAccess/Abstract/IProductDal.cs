using ORMNorthwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMNothwind.DataAccess.Abstract
{
    public interface IProductDal : IORMRepository<Products>
    {
        // nothing to implement yet
        string GetProductNameById(int id);
    }
}
