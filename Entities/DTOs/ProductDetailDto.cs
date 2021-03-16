using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDetailDto:IDto
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }
    }
}
