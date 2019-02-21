using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Site.Interfaces;
using Site.Models;
using Site.ViewModels;

namespace site.Controllers
{

    public class VendaController : Controller
    {
        private readonly IVendaRepositorio _vendaRep;
        private readonly Carrinho _carrinho;

        public VendaController(IVendaRepositorio vendaRep, Carrinho carrinho)
        {
            _vendaRep = vendaRep;
            _carrinho = carrinho;
        }


        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Venda venda)
        {
            var itens = _carrinho.GetCarrinhoItens();
            _carrinho.CarrinhoItens = itens;
            if (_carrinho.CarrinhoItens.Count == 0)
            {
                ModelState.AddModelError("", "Seu carrinho está vazio, adicione um produto");
            }

            if (ModelState.IsValid)
            {
                _vendaRep.CriarVenda(venda);
                //  _carrinho.LimparCarrinho();

                TempData["msg"] = "Compra Efetuada com Sucesso!";
                return RedirectToAction("Complete"); // redireciona para a action abaixo: public IActionResult Complete()
            }

            return View(venda);
        }

        public IActionResult Complete()
        {
            var carVM = new CarrinhoViewModel
            {
                Carrinho = _carrinho,
                TotalCarrinho = _carrinho.GetValorTotalCarrinho()
            };
            return View(carVM);
        }
    }
}