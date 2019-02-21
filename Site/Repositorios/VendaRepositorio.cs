using Site.Data;
using Site.Interfaces;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Repositorios
{
    public class VendaRepositorio : IVendaRepositorio
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly Carrinho _carrinho;

        public VendaRepositorio(ApplicationDbContext dbContext, Carrinho carrinho)
        {
            _dbContext = dbContext;
            _carrinho = carrinho;
        }

        public void CriarVenda(Venda venda)
        {
            venda.DataVenda = DateTime.Now;

            _dbContext.Vendas.Add(venda);

            var carrinhoItens = _carrinho.CarrinhoItens;
     
            foreach (var item in carrinhoItens)
            {
                var vendaDet = new VendaDetalhe()
                {
                    Quantidade = item.Quantidade,
                    ProdutoId = item.Produto.ProdutoId,
                    VendaId = venda.VendaId,
                    Preco = item.Produto.Valor
                };

                _dbContext.VendasDetalhes.Add(vendaDet);
            }

            _dbContext.SaveChanges();
        }
    }
}
