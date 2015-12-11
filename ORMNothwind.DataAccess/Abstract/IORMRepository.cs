using ORMNorthwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ORMNothwind.DataAccess.Abstract
{
    public interface IORMRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter);

        List<T> Get();

        List<T> GetList(Expression<Func<T, bool>> filter);
    }
}
