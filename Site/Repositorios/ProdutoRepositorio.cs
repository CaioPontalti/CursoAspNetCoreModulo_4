using Microsoft.EntityFrameworkCore;
using Site.Data;
using Site.Interfaces;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly ApplicationDbContext _dbContext;

        public ProdutoRepositorio(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Produto> Produtos => _dbContext.Produtos.Include(c => c.Categoria);

        public IEnumerable<Produto> ProdutosMaisVendidos => _dbContext.Produtos.Where(p => p.Ativo == true);

        public Produto GetProdutoById(int id)
        {
            return _dbContext.Produtos.FirstOrDefault(p => p.ProdutoId == id);
        }
    }
}
