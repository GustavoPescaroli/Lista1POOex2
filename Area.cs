using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado t;
            t = new Quadrado();


            Console.WriteLine("Digite o valor da base");
            t.setl(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o valor da altura");
            t.setl(double.Parse(Console.ReadLine()));
            t.calcular();
            Console.WriteLine("O valor da aresta é {0} da altura {1} área é de {2}", t.getl(), t.getl(), t.geta());




        }
    }
}
