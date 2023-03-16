using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Verifica se o número é par ou impar---\t\t");
            Console.Write("informe um numero:");
            int num = int.Parse(Console.ReadLine());
            if (num%2 == 0)
            {
                Console.WriteLine("\n Este numero é par");
            }
            else
            {
                Console.WriteLine("\n Esse numero é impar");
            }
            Console.ReadKey ();
        }
    }
}
