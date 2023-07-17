using BackendProje.Data.Abstract;
using BackendProje.Data.Concrete.EFCore;
using BackendProje.Entity.Concrete;
using BackendProje.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BackendProje.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            List<Product> products = _productRepository.GetAll();


            List<ProductViewModel> productModel = new List<ProductViewModel>();
            productModel = products.Select(p => new ProductViewModel
            {
                Name = p.Name,
                Price = p.Price
            }).ToList();
            return View(productModel);
        }
    }
}