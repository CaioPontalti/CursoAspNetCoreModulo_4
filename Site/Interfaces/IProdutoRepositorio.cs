using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Models;

namespace Site.Interfaces
{
    public interface IProdutoRepositorio
    {
        //Propriedades
        IEnumerable<Produto> Produtos { get; }
        IEnumerable<Produto> ProdutosMaisVendidos { get; }

        //Metodo
        Produto GetProdutoById(int id);
    }
}
