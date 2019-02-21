using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Interfaces
{
    public interface IVendaRepositorio
    {
        void CriarVenda(Venda venda);
    }
}
