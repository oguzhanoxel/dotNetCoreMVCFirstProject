using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class MonthlyReport : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Month { get; set; }
        public decimal Profit { get; set; }

    }
}
