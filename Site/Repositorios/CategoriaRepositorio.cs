using Site.Data;
using Site.Interfaces;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Repositorios
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoriaRepositorio(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Categoria> Categorias => _dbContext.Categorias;
    }
}
