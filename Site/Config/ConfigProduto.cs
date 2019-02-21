using Site.Interfaces;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Config
{
    public class ConfigProduto : IProdutoRepositorio
    {
        //Propriedade utilizada para instanciar a class de ConfigCategoria, para buscar a categoria do Produto.
        private readonly ICategoriaRepositorio _categoriaRepositorio = new ConfigCategoria();

        public IEnumerable<Produto> Produtos => new List<Produto>
        {
            //Cria os Produtos.
            new Produto
            { Nome="Camisa",
              Valor=100,
              DescricaoCurta="Camisa Polo",
              DescricaoLonga="Camisa Polo Diversas Cores",
              Categoria = _categoriaRepositorio.Categorias.First(), //Categoria do produto
              ImagemUrl = "",
              ImagemMinUrl="",
              Estoque = true,
              Ativo = true
            },
            new Produto
            { Nome="Calça",
              Valor=150,
              DescricaoCurta="Camisa Jeans",
              DescricaoLonga="Camisa Jeans escura com bolso",
              Categoria = _categoriaRepositorio.Categorias.Last(), //Categoria do produto
              ImagemUrl = "",
              ImagemMinUrl="",
              Estoque = true,
              Ativo = true
            }
        };


        //Não está utilizando, mas como implementa a interface IProdutoRepositorio, precisa implementar os metodos dela.
        public IEnumerable<Produto> ProdutosMaisVendidos => throw new NotImplementedException();

        //Não está utilizando, mas como implementa a interface IProdutoRepositorio, precisa implementar os metodos dela.
        public Produto GetProdutoById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
