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
                new MonthlyReport{Id=2, ProductId=1, Month="Şubat", Profit=52000.00m},
                new MonthlyReport{Id=3, ProductId=2, Month="Ocak", Profit=52000.00m},
                new MonthlyReport{Id=4, ProductId=2, Month="Şubat", Profit=52000.00m},
                new MonthlyReport{Id=5, ProductId=3, Month="Ocak", Profit=52000.00m},
                new MonthlyReport{Id=6, ProductId=4, Month="Ocak", Profit=52000.00m},
                new MonthlyReport{Id=7, ProductId=4, Month="Şubat", Profit=52000.00m},
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
                new MonthlyReportDetailDto {Id = _monthlyReports[2].Id, ProductId = _products[1].Id, BrandId = _brands[0].Id, Month = _monthlyReports[2].Month, Profit = _monthlyReports[2].Profit, BrandName=_brands[0].Name,ProductName = _products[1].Name, UnitPrice = _products[1].UnitPrice, Stock = _products[1].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[3].Id, ProductId = _products[1].Id, BrandId = _brands[0].Id, Month = _monthlyReports[3].Month, Profit = _monthlyReports[3].Profit, BrandName=_brands[0].Name,ProductName = _products[1].Name, UnitPrice = _products[1].UnitPrice, Stock = _products[1].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[4].Id, ProductId = _products[2].Id, BrandId = _brands[1].Id, Month = _monthlyReports[4].Month, Profit = _monthlyReports[4].Profit, BrandName=_brands[1].Name,ProductName = _products[2].Name, UnitPrice = _products[2].UnitPrice, Stock = _products[2].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[5].Id, ProductId = _products[3].Id, BrandId = _brands[1].Id, Month = _monthlyReports[5].Month, Profit = _monthlyReports[5].Profit, BrandName=_brands[1].Name,ProductName = _products[3].Name, UnitPrice = _products[3].UnitPrice, Stock = _products[3].Stock },
                new MonthlyReportDetailDto {Id = _monthlyReports[6].Id, ProductId = _products[3].Id, BrandId = _brands[1].Id, Month = _monthlyReports[6].Month, Profit = _monthlyReports[6].Profit, BrandName=_brands[1].Name,ProductName = _products[3].Name, UnitPrice = _products[3].UnitPrice, Stock = _products[3].Stock },
            };
            return monthlyReportDetailDtos;
        }

        public void Update(MonthlyReport entity)
        {
            throw new NotImplementedException();
        }
    }
}
