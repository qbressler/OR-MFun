using OR_M_Data_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMNothwind.DataAccess.Concrete.ORM.Contexts
{
    public class NorthwindContext : DbSqlContext
    {
        public NorthwindContext() : base("NorthwindConnectionString")
        {

        }
    }
}
