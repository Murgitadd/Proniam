using Microsoft.AspNetCore.Mvc;
using Proniam.DAL;
using Proniam.Models;
using Proniam.ModelsVM;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Reflection.Metadata;
using System;

namespace Proniam.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Products> products = _context.Products.Include(p => p.ProductImages).OrderByDescending(s => s.CountId).Take(8).ToList();
            List<Slides> slides = _context.Slides.OrderBy(s => s.Id).Take(3).ToList();

            HomeVM vm = new HomeVM { Slides = slides, Products = products};

            return View(vm);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
