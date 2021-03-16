using DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
            var filteredReports = monthlyReports.Where(m => m.BrandId == ID);
            return View(filteredReports);
        }
    }
}
