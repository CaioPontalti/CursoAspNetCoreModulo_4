using Site.Interfaces;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Config
{
    public class ConfigCategoria : ICategoriaRepositorio
    {
        //Propriedade {get;} que está na interface ICategoriaRepositorio
        public IEnumerable<Categoria> Categorias => new List<Categoria>
        {
            new Categoria {Nome="Masculino", Descricao="Todos os Produtos Masculinos"},
            new Categoria {Nome="Feminino", Descricao="Todos os Produtos Femininos"}
        };
    }
}
