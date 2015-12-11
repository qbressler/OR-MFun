using OR_M_Data_Entities;
using ORMNorthwind.Entities.Abstract;
using ORMNothwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ORMNothwind.DataAccess.Concrete.ORM
{
    public class ORMBase<TEntity, TContext> : IORMRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbSqlContext, new()
    {
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.From<TEntity>().Where(filter).FirstOrDefault();
            }
        }

        public List<TEntity> Get()
        {
            using (var context = new TContext())
            {
                return context.From<TEntity>().ToList();
            }
        }


        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.From<TEntity>().Where(filter).ToList();
            }
        }

        public List<TEntity> GetList()
        {
            using (var context = new TContext())
            {
                return context.From<TEntity>().ToList();
            }
        }
    }
}
