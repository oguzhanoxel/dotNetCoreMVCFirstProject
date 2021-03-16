using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMonthlyReportDal : EfEntityRepositoryBase<MonthlyReport, FirstProjectDBContext>, IMonthlyReportDal
    {
        public List<MonthlyReportDetailDto> GetMonthlyReportDetails()
        {
            using (FirstProjectDBContext context = new FirstProjectDBContext())
            {
                var result = from monthlyReport in context.MonthlyReports
                             join product in context.Products on monthlyReport.ProductId equals product.Id
                             join brand in context.Brands on product.BrandId equals brand.Id
                             select new MonthlyReportDetailDto
                             {
                                 Id = monthlyReport.Id,
                                 ProductId = product.Id,
                                 BrandId = brand.Id,
                                 Month = monthlyReport.Month,
                                 Profit = monthlyReport.Profit,
                                 BrandName = brand.Name,
                                 ProductName = product.Name,
                                 UnitPrice = product.UnitPrice,
                                 Stock = product.Stock,
                             };
                return result.ToList();
            }
        }
    }
}