﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Models;

namespace Site.Interfaces
{
    public interface ICategoriaRepositorio
    {
        //Propriedade
        IEnumerable<Categoria> Categorias { get; }
    }
}
