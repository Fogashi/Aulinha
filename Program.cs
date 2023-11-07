using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulinha
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("VENDEDOR!");

            Vendedor v1 = new Vendedor();
            Console.WriteLine("digite o valor do produto");
            double valorp = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o preço do produto");
            double precop = double.Parse(Console.ReadLine());
            double lucro = v1.RealizarVenda(valorp, precop);
            Console.WriteLine("o seu lucro foi: " + lucro);
            v1.MostrarEstado();
            v1.BaterCartao();
            v1.MostrarEstado();
            Console.ReadKey();

            Console.WriteLine("GERENTE!");

            Gerente g1 = new Gerente();

            Console.WriteLine("Abrir o Caixa: 1");
            Console.WriteLine("Fechar o Caixa: 2");
            int caixa = int.Parse(Console.ReadLine());

            if (caixa == 1){                            
            bool abrir = g1.Abrir();
            Console.WriteLine(abrir);
            Console.ReadKey();
            }
            else
            {
            bool fechar = g1.Fechar();
            Console.WriteLine(fechar);
            }
            g1.MostrarEstado();
            g1.BaterCartao();
            g1.MostrarEstado();
            Console.ReadKey();

            Console.WriteLine("FAXINEIRO!");

            Faxineiro f1 = new Faxineiro();
            Console.WriteLine("digite quantos produtos você deseja requisitar");
            int qt = int.Parse(Console.ReadLine());
            int m  = f1.Requisitar(qt);
            Console.WriteLine("quantidade de produtos requisitados" + m);
            f1.MostrarEstado();
            f1.BaterCartao();
            f1.MostrarEstado();
            Console.ReadKey();
        }
    }
}
