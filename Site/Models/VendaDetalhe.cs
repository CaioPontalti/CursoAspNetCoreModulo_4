using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Models;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class VendaDetalhe
    {
        [Key]
        public int VendaDetalheId { get; set; }
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Venda Venda { get; set; }
    }
}
