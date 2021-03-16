using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class MonthlyReportDetailDto:IDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int BrandId { get; set; }
        public string Month { get; set; }
        public decimal Profit { get; set; }
        public string BrandName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }
    }
}
