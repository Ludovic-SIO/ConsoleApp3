using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static double ConvertBtToE (int a)
        {
            double b = 33803.1;
            return a* b;

        }
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Saisie le montant en Bitcoins");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Le montant est {0}",a);

            while (a>= 0)
            {
                Console.WriteLine("Le montant en euros est {0}", ConvertBtToE(a));
                Console.WriteLine("Saisie le montant en Bitcoins");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Le montant est {0}",a);
            }
               
            Console.ReadKey();
        }
    }
}
