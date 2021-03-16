using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, FirstProjectDBContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (FirstProjectDBContext context = new FirstProjectDBContext())
            {
                var result = from product in context.Products
                             join brand in context.Brands on product.BrandId equals brand.Id
                             select new ProductDetailDto
                             {
                                 Id = product.Id,
                                 BrandId = brand.Id,
                                 ProductName = product.Name,
                                 BrandName = brand.Name,
                                 UnitPrice = product.UnitPrice,
                                 Stock = product.Stock
                             };
                return result.ToList();
            }
        }
    }
}
