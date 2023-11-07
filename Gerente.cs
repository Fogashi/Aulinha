using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulinha
{
    class Gerente : Funcionario
    {
        private bool Caixa;

        public bool Fechar()
        {
            Console.WriteLine("você fechou o caixa");
            this.Caixa = false;
            return this.Caixa;
        }
        public bool Abrir()
        {
            Console.Write("você abriu o caixa: ");
            this.Caixa = true;
            return this.Caixa;
        }

    }
}
