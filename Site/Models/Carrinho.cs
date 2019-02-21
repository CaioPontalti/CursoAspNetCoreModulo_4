using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Site.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Models
{
    public class Carrinho
    {
        private readonly ApplicationDbContext _dbContext;

        [Key]
        public string CarrinhoId { get; set; }
        public List<CarrinhoItem> CarrinhoItens { get; set; }

        public Carrinho(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Metodo para criar e retornar o carrinho
        public static Carrinho GetCarrinho(IServiceProvider serviceProvider)
        {
            //armazena em cache/sessão
            ISession session = serviceProvider.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //Faz a inicialização do serviço
            var context = serviceProvider.GetService<ApplicationDbContext>();

            //Cria o Id do Carrinho
            string carId = session.GetString("CarId") ?? Guid.NewGuid().ToString();

            //Passa para a variavel criada a acima as informações da sessão.
            session.SetString("CarId", carId);

            return new Carrinho(context) { CarrinhoId = carId };
        }

        public void PostItemCarrinho(Produto produto, int qtd)
        {
            var carrinhoItem = _dbContext.CarrinhosItens.SingleOrDefault(c => c.Produto.ProdutoId == produto.ProdutoId
                                                                           && c.CarrinhoId == CarrinhoId);

            if (carrinhoItem == null)
            {
                carrinhoItem = new CarrinhoItem()
                {
                    CarrinhoId = CarrinhoId,
                    Produto = produto,
                    Quantidade = 1
                };

                _dbContext.CarrinhosItens.Add(carrinhoItem);
            }
            else
                carrinhoItem.Quantidade++;
            
            _dbContext.SaveChanges();
        }

        public int DeleteItemCarrinho(Produto produto)
        {
            var carrinhoItem = _dbContext.CarrinhosItens.SingleOrDefault(c => c.Produto.ProdutoId == produto.ProdutoId
                                                                           && c.CarrinhoId == CarrinhoId);
            var qtdLocal = 0;

            if (carrinhoItem != null)
            {
                if (carrinhoItem.Quantidade > 1)
                {
                    carrinhoItem.Quantidade--;
                    qtdLocal = carrinhoItem.Quantidade;
                }
                else
                    _dbContext.CarrinhosItens.Remove(carrinhoItem);
            }

            _dbContext.SaveChanges();

            return qtdLocal;
        }

        public List<CarrinhoItem> GetCarrinhoItens()
        {
            return _dbContext.CarrinhosItens.Where(c => c.CarrinhoId == CarrinhoId)
                                            .Include(c => c.Produto).ToList();

        }

        public void LimparCarrinho()
        {
            var carItens = _dbContext.CarrinhosItens.Where(c => c.CarrinhoId == CarrinhoId);

            _dbContext.CarrinhosItens.RemoveRange(carItens);
            _dbContext.SaveChanges();
        }

        public decimal GetValorTotalCarrinho()
        {
            var total = _dbContext.CarrinhosItens.Where(c => c.CarrinhoId == CarrinhoId)
                                                 .Select(c => c.Produto.Valor * c.Quantidade).Sum();

            return total;
        }
    }
}
