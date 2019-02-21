using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Site.Interfaces;
using Site.Models;
using Site.ViewModels;

namespace Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public HomeController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public IActionResult Index()
        {
            var homeVm = new HomeViewModel
            {
                ProdutosMaisVendidos = _produtoRepositorio.ProdutosMaisVendidos
            };

            return View(homeVm);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
