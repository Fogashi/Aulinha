using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulinha
{
    class Faxineiro : Funcionario
    {
        private int Produtos;

        public int Requisitar(int qt)
        {
            this.Produtos = qt;
            return this.Produtos;
        }

    }
}
