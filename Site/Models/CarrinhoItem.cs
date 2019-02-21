﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Models
{
    public class CarrinhoItem
    {
        [Key]
        public int CarrinhoItemId { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public string CarrinhoId { get; set; }
    }
}
