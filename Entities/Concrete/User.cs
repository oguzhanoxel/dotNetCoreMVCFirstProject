using Core.Entities;
using ServiceStack.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Unique]
        public int BrandId { get; set; }
        [Unique]
        public string Email { get; set; }
        public string Password { get; set; }
        [DefaultValue(false)]
        public bool IsAdmin { get; set; }
    }
}
