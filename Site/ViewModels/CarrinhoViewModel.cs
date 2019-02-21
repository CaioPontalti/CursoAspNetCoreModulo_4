using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Models;

namespace Site.ViewModels
{
    public class CarrinhoViewModel
    {
        public Carrinho Carrinho { get; set; }
        public decimal TotalCarrinho { get; set; }
    }
}
