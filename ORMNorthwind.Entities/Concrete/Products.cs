using OR_M_Data_Entities.Mapping;
using ORMNorthwind.Entities.Abstract;

namespace ORMNorthwind.Entities.Concrete
{
    [Table("Products")]
    public class Products : IEntity
    {
        [Key]
        public int ProductID { get; set; }

        public int CategoryID { get; set; }

        public string ProductName { get; set; }

        public int UnitsInStock { get; set; }

        public bool Discontinued { get; set; }

        [ForeignKey("CategoryID")]
        public Categories Category { get; set; }
    }
}
