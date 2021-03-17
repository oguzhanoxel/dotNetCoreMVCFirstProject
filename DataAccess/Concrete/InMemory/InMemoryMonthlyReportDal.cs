using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryMonthlyReportDal : IMonthlyReportDal
    {
        List<MonthlyReport> _monthlyReports;

        public InMemoryMonthlyReportDal()
        {
            _monthlyReports = new List<MonthlyReport>
            {
                new MonthlyReport{Id=1, ProductId=1, Month="Ocak", Profit=52000.00m},
                new MonthlyReport{Id=2, ProductId=1, Month="Şubat", Profit=63000.00m},
                new MonthlyReport{Id=3, ProductId=1, Month="Mart", Profit=42000.00m},
                new MonthlyReport{Id=4, ProductId=1, Month="Nisan", Profit=72000.00m},
                new MonthlyReport{Id=5, ProductId=1, Month="Mayıs", Profit=482000.00m},

                new MonthlyReport{Id=6, ProductId=2, Month="Ocak", Profit=78000.00m},
                new MonthlyReport{Id=7, ProductId=2, Month="Şubat", Profit=24000.00m},
                new MonthlyReport{Id=8, ProductId=2, Month="Mart", Profit=54000.00m},
                new MonthlyReport{Id=9, ProductId=2, Month="Nisan", Profit=68000.00m},
                new MonthlyReport{Id=10, ProductId=2, Month="Mayıs", Profit=50000.00m},

                new MonthlyReport{Id=11, ProductId=3, Month="Ocak", Profit=46000.00m},
                new MonthlyReport{Id=12, ProductId=3, Month="Şubat", Profit=66000.00m},
                new MonthlyReport{Id=13, ProductId=3, Month="Mart", Profit=96000.00m},
                new MonthlyReport{Id=14, ProductId=3, Month="Nisan", Profit=66000.00m},
                new MonthlyReport{Id=15, ProductId=3, Month="Mayıs", Profit=76000.00m},

                new MonthlyReport{Id=16, ProductId=4, Month="Ocak", Profit=20000.00m},
                new MonthlyReport{Id=17, ProductId=4, Month="Şubat", Profit=56000.00m},
                new MonthlyReport{Id=18, ProductId=4, Month="Mart", Profit=40000.00m},
                new MonthlyReport{Id=19, ProductId=4, Month="Nisan", Profit=60000.00m},
                new MonthlyReport{Id=20, ProductId=4, Month="Mayıs", Profit=36000.00m},
            };
            _products = new List<Product>
            {
                new Product{Id=1, BrandId=1, Name = "Mk1ürün1", UnitPrice = 1, Stock=100},
                new Product{Id=2, BrandId=1, Name = "Mk1Ürün2", UnitPrice = 1, Stock=100},
                new Product{Id=3, BrandId=2, Name = "Mk2Ürün1", UnitPrice = 1, Stock=100},
                new Product{Id=4, BrandId=2, Name = "Mk2Ürün2", UnitPrice = 1, Stock=100},
            };
            _brands = new List<Brand> {
                new Brand {Id=1, Name="Marka 1" },
                new Brand {Id=2, Name="Marka 2" },
            };
        }

        List<Product> _products;
        List<Brand> _brands;
        public void Add(MonthlyReport entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(MonthlyReport entity)
        {
            throw new NotImplementedException();
        }

        public MonthlyReport Get(Expression<Func<MonthlyReport, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<MonthlyReport> GetAll(Expression<Func<MonthlyReport, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<MonthlyReportDetailDto> GetMonthlyReportDetails()
        {
            List<MonthlyReportDetailDto> monthlyReportDetailDtos = new List<MonthlyReportDetailDto>
            {
                new MonthlyReportDetailDto {Id = _monthlyReports[0].Id, ProductId = _products[0].Id, BrandId = _brands[0].Id, Month = _monthlyReports[0].Month, Profit = _monthlyReports[0].Profit, BrandName=_brands[0].Name,ProductName = _products[0].Name, UnitPrice = _products[0].UnitPrice, Stock = _products[0].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[1].Id, ProductId = _products[0].Id, BrandId = _brands[0].Id, Month = _monthlyReports[1].Month, Profit = _monthlyReports[1].Profit, BrandName=_brands[0].Name,ProductName = _products[0].Name, UnitPrice = _products[0].UnitPrice, Stock = _products[0].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[2].Id, ProductId = _products[0].Id, BrandId = _brands[0].Id, Month = _monthlyReports[2].Month, Profit = _monthlyReports[2].Profit, BrandName=_brands[0].Name,ProductName = _products[0].Name, UnitPrice = _products[1].UnitPrice, Stock = _products[1].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[3].Id, ProductId = _products[0].Id, BrandId = _brands[0].Id, Month = _monthlyReports[3].Month, Profit = _monthlyReports[3].Profit, BrandName=_brands[0].Name,ProductName = _products[0].Name, UnitPrice = _products[1].UnitPrice, Stock = _products[1].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[4].Id, ProductId = _products[0].Id, BrandId = _brands[0].Id, Month = _monthlyReports[4].Month, Profit = _monthlyReports[4].Profit, BrandName=_brands[0].Name,ProductName = _products[0].Name, UnitPrice = _products[2].UnitPrice, Stock = _products[2].Stock },

                new MonthlyReportDetailDto {Id = _monthlyReports[5].Id, ProductId = _products[1].Id, BrandId = _brands[0].Id, Month = _monthlyReports[5].Month, Profit = _monthlyReports[5].Profit, BrandName=_brands[0].Name,ProductName = _products[1].Name, UnitPrice = _products[3].UnitPrice, Stock = _products[3].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[6].Id, ProductId = _products[1].Id, BrandId = _brands[0].Id, Month = _monthlyReports[6].Month, Profit = _monthlyReports[6].Profit, BrandName=_brands[0].Name,ProductName = _products[1].Name, UnitPrice = _products[3].UnitPrice, Stock = _products[3].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[7].Id, ProductId = _products[1].Id, BrandId = _brands[0].Id, Month = _monthlyReports[7].Month, Profit = _monthlyReports[7].Profit, BrandName=_brands[0].Name,ProductName = _products[1].Name, UnitPrice = _products[3].UnitPrice, Stock = _products[3].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[8].Id, ProductId = _products[1].Id, BrandId = _brands[0].Id, Month = _monthlyReports[8].Month, Profit = _monthlyReports[8].Profit, BrandName=_brands[0].Name,ProductName = _products[1].Name, UnitPrice = _products[3].UnitPrice, Stock = _products[3].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[9].Id, ProductId = _products[1].Id, BrandId = _brands[0].Id, Month = _monthlyReports[9].Month, Profit = _monthlyReports[9].Profit, BrandName=_brands[0].Name,ProductName = _products[1].Name, UnitPrice = _products[3].UnitPrice, Stock = _products[3].Stock },
                
                new MonthlyReportDetailDto {Id = _monthlyReports[10].Id, ProductId = _products[2].Id, BrandId = _brands[1].Id, Month = _monthlyReports[10].Month, Profit = _monthlyReports[10].Profit, BrandName=_brands[1].Name,ProductName = _products[2].Name, UnitPrice = _products[3].UnitPrice, Stock = _products[3].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[11].Id, ProductId = _products[2].Id, BrandId = _brands[1].Id, Month = _monthlyReports[11].Month, Profit = _monthlyReports[11].Profit, BrandName=_brands[1].Name,ProductName = _products[2].Name, UnitPrice = _products[3].UnitPrice, Stock = _products[3].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[12].Id, ProductId = _products[2].Id, BrandId = _brands[1].Id, Month = _monthlyReports[12].Month, Profit = _monthlyReports[12].Profit, BrandName=_brands[1].Name,ProductName = _products[2].Name, UnitPrice = _products[3].UnitPrice, Stock = _products[3].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[13].Id, ProductId = _products[2].Id, BrandId = _brands[1].Id, Month = _monthlyReports[13].Month, Profit = _monthlyReports[13].Profit, BrandName=_brands[1].Name,ProductName = _products[2].Name, UnitPrice = _products[3].UnitPrice, Stock = _products[3].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[14].Id, ProductId = _products[2].Id, BrandId = _brands[1].Id, Month = _monthlyReports[14].Month, Profit = _monthlyReports[14].Profit, BrandName=_brands[1].Name,ProductName = _products[2].Name, UnitPrice = _products[3].UnitPrice, Stock = _products[3].Stock },
                
                new MonthlyReportDetailDto {Id = _monthlyReports[15].Id, ProductId = _products[3].Id, BrandId = _brands[1].Id, Month = _monthlyReports[15].Month, Profit = _monthlyReports[15].Profit, BrandName=_brands[1].Name,ProductName = _products[3].Name, UnitPrice = _products[3].UnitPrice, Stock = _products[3].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[16].Id, ProductId = _products[3].Id, BrandId = _brands[1].Id, Month = _monthlyReports[16].Month, Profit = _monthlyReports[16].Profit, BrandName=_brands[1].Name,ProductName = _products[3].Name, UnitPrice = _products[3].UnitPrice, Stock = _products[3].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[17].Id, ProductId = _products[3].Id, BrandId = _brands[1].Id, Month = _monthlyReports[17].Month, Profit = _monthlyReports[17].Profit, BrandName=_brands[1].Name,ProductName = _products[3].Name, UnitPrice = _products[3].UnitPrice, Stock = _products[3].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[18].Id, ProductId = _products[3].Id, BrandId = _brands[1].Id, Month = _monthlyReports[18].Month, Profit = _monthlyReports[18].Profit, BrandName=_brands[1].Name,ProductName = _products[3].Name, UnitPrice = _products[3].UnitPrice, Stock = _products[3].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[19].Id, ProductId = _products[3].Id, BrandId = _brands[1].Id, Month = _monthlyReports[19].Month, Profit = _monthlyReports[19].Profit, BrandName=_brands[1].Name,ProductName = _products[3].Name, UnitPrice = _products[3].UnitPrice, Stock = _products[3].Stock },
            };
            return monthlyReportDetailDtos;
        }

        public void Update(MonthlyReport entity)
        {
            throw new NotImplementedException();
        }
    }
}
