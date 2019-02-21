using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Site.Interfaces;
using Site.Models;
using Site.ViewModels;

namespace Site.Controllers
{
    public class CarrinhoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        private readonly Carrinho _carrinho;

        public CarrinhoController(IProdutoRepositorio produtoRep, Carrinho carrinho)
        {
            _produtoRepositorio = produtoRep;
            _carrinho = carrinho; 
        }


        public IActionResult Index()
        {
            var itens = _carrinho.GetCarrinhoItens();
            _carrinho.CarrinhoItens = itens;

            var carVm = new CarrinhoViewModel
            {
                Carrinho = _carrinho,
                TotalCarrinho = _carrinho.GetValorTotalCarrinho()
            };

            return View(carVm);
        }

        public RedirectToActionResult AddCarrinho(int ProdutoId)
        {
            var selProduto = _produtoRepositorio.Produtos.FirstOrDefault(p => p.ProdutoId == ProdutoId);

            if (selProduto != null)
            {
                _carrinho.PostItemCarrinho(selProduto, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveCarrinho(int ProdutoId)
        {
            var selProduto = _produtoRepositorio.Produtos.FirstOrDefault(p => p.ProdutoId == ProdutoId);
            
            if (selProduto != null)
            {
                _carrinho.DeleteItemCarrinho(selProduto);
            }

            return RedirectToAction("Index");
        }
    }
}