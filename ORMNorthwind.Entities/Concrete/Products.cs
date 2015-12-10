using OR_M_Data_Entities.Mapping;
using ORMNorthwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMNorthwind.Entities.Concrete
{
    
    public class Products : IEntity
    {
        [Key]
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int UnitsInStock { get; set; }

        public bool Discontinued { get; set; }
    }
}
