using Core.Entities;
using DataAccess.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IProductDal _productDal;
        IMonthlyReportDal _monthlyReportDal;

        public HomeController(ILogger<HomeController> logger, IProductDal productDal, IMonthlyReportDal monthlyReportDal)
        {
            _logger = logger;
            _productDal = productDal;
            _monthlyReportDal = monthlyReportDal;
        }

        // https://localhost:44343/Home
        public IActionResult Index()
        {
            var productDetails = _productDal.GetProductDetails();
            return View(productDetails);
        }

        // https://localhost:44343/Home/GetReports/BrandId
        public IActionResult GetReports(int ID)
        {
            if (ID == null)
            {
                return new BadRequestResult();
            }
            var monthlyReports = _monthlyReportDal.GetMonthlyReportDetails();
            if (!monthlyReports.Exists(m => m.BrandId == ID))
            {
                return new BadRequestResult();
            }
            var filteredReportsByBrand = monthlyReports.Where(m => m.BrandId == ID);

            List<List<DataPoint>> productsDataPoints = new List<List<DataPoint>>();
            List<string> productsName = new List<string>();
            foreach (var item1 in _productDal.GetProductDetails().Where(p => p.BrandId==ID))
            {
                List<DataPoint> subReport = new List<DataPoint>();
                foreach (var item in filteredReportsByBrand.Where(m => m.ProductId == item1.Id))
                {
                    subReport.Add(new DataPoint(item.ProductName, item.Month, Decimal.ToDouble(item.Profit)));
                }
                productsDataPoints.Add(subReport);
                productsName.Add(item1.ProductName);
            }

            ViewBag.ProductsDataPoints = JsonConvert.SerializeObject(productsDataPoints);
            ViewBag.ProductsName = JsonConvert.SerializeObject(productsName);

            return View(filteredReportsByBrand);
        }
    }
}
