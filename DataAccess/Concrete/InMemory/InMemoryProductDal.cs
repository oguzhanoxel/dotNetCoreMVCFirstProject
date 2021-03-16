using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        List<Brand> _brands;

        public InMemoryProductDal()
        {
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

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            List<ProductDetailDto> productDetailDtos = new List<ProductDetailDto> { 
                new ProductDetailDto {Id = _products[0].Id, BrandId = _brands[0].Id, ProductName = _products[0].Name, BrandName = _brands[0].Name, UnitPrice = _products[0].UnitPrice, Stock = _products[0].Stock},
                new ProductDetailDto {Id = _products[1].Id, BrandId = _brands[0].Id, ProductName = _products[1].Name, BrandName = _brands[0].Name, UnitPrice = _products[1].UnitPrice, Stock = _products[1].Stock},
                new ProductDetailDto {Id = _products[2].Id, BrandId = _brands[1].Id, ProductName = _products[2].Name, BrandName = _brands[1].Name, UnitPrice = _products[2].UnitPrice, Stock = _products[2].Stock},
                new ProductDetailDto {Id = _products[3].Id, BrandId = _brands[1].Id, ProductName = _products[3].Name, BrandName = _brands[1].Name, UnitPrice = _products[3].UnitPrice, Stock = _products[3].Stock},
            };
            return productDetailDtos;
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
