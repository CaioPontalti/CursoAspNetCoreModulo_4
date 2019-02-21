using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoLonga { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemMinUrl { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
        public bool Estoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
