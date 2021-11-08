using Microsoft.AspNetCore.Mvc;
using MVCWithVUE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWithVUE.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("product/{id}")]
        public IActionResult Index(int id)
        {
            ViewBag.Product = new Product();
            return View();
        }
    }
}
