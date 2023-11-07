using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulinha
{
    class Vendedor : Funcionario
    {

        public double RealizarVenda(double valorp,double precop)
        {
            double lucro = precop - valorp;
            return lucro;
        }

    }
}
