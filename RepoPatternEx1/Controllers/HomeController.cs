using Microsoft.AspNetCore.Mvc;
using RepoPatternEx1.Models;
using RepoPatternEx1.Repositories;
using System.Collections.Generic;

namespace RepoPatternEx1.Controllers
{
    public class HomeController : Controller
    {
        ProductRepo repo;
        public HomeController()
        {
            repo = new ProductRepo();
        }
        public IActionResult Index()
        {
            
            var res= repo.GetProducts();
            return View(res);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product rec) 
        {
           repo.addProduct(rec);
           return RedirectToAction("Index");
        } 
    }
}
