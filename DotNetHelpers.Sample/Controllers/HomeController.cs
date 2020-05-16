using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DotNetHelpers.Extentions;
using DotNetHelpers.Models;
using DotNetHelpers.Sample.Enums;
using DotNetHelpers.Sample.Models;
using DotNetHelpers.Sample.Factories;

namespace DotNetHelpers.Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int page = 1, int perPage = 10)
        {
            try
            {
                var a = Result.Error("test");
                var products = ProductsFactory.Products;
                var totalCount = products.Count;

                PagedList<Product> result = new PagedList<Product>(
                    products.Skip((page - 1) * perPage)
                    .Take(perPage)
                    .ToList(),
                    new Paging(page, perPage, totalCount, (int)Math.Ceiling((decimal)totalCount / perPage)),
                    new Sorting()
                    );
                return View(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error type: {ErrorType.Internal.GetDisplayName()}, Error message: {ex.Message}");
                throw;
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
