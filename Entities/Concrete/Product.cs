using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }
    }
}
