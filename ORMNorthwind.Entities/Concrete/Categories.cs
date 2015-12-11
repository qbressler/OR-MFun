using OR_M_Data_Entities.Mapping;
using ORMNorthwind.Entities.Abstract;
using System.Collections.Generic;

namespace ORMNorthwind.Entities.Concrete
{
    public class Categories : IEntity
    {
        [Key]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

    }
}
