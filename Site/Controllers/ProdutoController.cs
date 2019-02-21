using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Site.Config;
using Site.Interfaces;
using Site.ViewModels;
using Microsoft.AspNetCore;
using Site.Models;

namespace Site.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        private readonly IProdutoRepositorio _produtoRepositorio;
        
        public ProdutoController(ICategoriaRepositorio categRepositorio, IProdutoRepositorio prodRepositorio)
        {
            _categoriaRepositorio = categRepositorio;
            _produtoRepositorio = prodRepositorio;
        }

        public ViewResult List(string categoria)// A variável tem que ter o mesmo nome do 'asp-route', nesse caso asp-route-categoria
        {
            string _categoria = categoria;
            IEnumerable<Produto> Produtos;
            string categoriaAtual = string.Empty;

            switch (_categoria)
            {
                case "Masculino":
                    Produtos = _produtoRepositorio.Produtos.Where(p => p.Categoria.Nome == "Masculino").OrderBy(p => p.ProdutoId);
                    categoriaAtual = _categoria;
                    break;

                case "Feminino":
                    Produtos = _produtoRepositorio.Produtos.Where(p => p.Categoria.Nome == "Feminino").OrderBy(p => p.ProdutoId);
                    categoriaAtual = _categoria;
                    break;

                default:
                    Produtos = _produtoRepositorio.Produtos.OrderBy(p => p.ProdutoId);
                    categoriaAtual = "Todos Produtos";
                    break;
            }

            return View(new ProdutoListViewModel
            {
                Produtos = Produtos,
                Categoria = categoriaAtual
            });
        }

        public IActionResult Details (int ProdutoId)
        {
            var Produto = _produtoRepositorio.GetProdutoById(ProdutoId);

            if (Produto == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(Produto);
        }

        public IActionResult BuscarProduto(string textoBusca)
        {
            var _textoBusca = textoBusca;
            IEnumerable<Produto> produtos;

            if (string.IsNullOrEmpty(_textoBusca))
            {
                produtos = _produtoRepositorio.Produtos.OrderBy(p => p.ProdutoId);
            }
            else
            {
                produtos = _produtoRepositorio.Produtos.Where(p => p.Nome.ToLower().Contains(_textoBusca.ToLower()));
            }

            return View("~/Views/Produto/List.cshtml", new ProdutoListViewModel { Produtos = produtos, Categoria = "Todos Produtos" });
        }
    }
}