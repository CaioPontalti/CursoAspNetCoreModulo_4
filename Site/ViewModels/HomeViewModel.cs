﻿using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Produto> ProdutosMaisVendidos { get; set; }
    }
}
