using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulinha
{
    class Funcionario
    {

        private bool Estado;
        

        public bool MostrarEstado()
        {
            return this.Estado;
        }
        public void BaterCartao()
        {
            this.Estado = true;
        }



    }
}
