using Microsoft.AspNetCore.Mvc;
using Site.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Config
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public CategoriaMenu(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRepositorio.Categorias.OrderBy(c => c.Nome);
            return View(categorias);
        }

    }
}
