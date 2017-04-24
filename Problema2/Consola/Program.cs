using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problema2, Ingrese los numeros:");
            string numeros = Console.ReadLine();
            Console.WriteLine("El resultado es:"+ CompleteRange.build(numeros));
            Console.ReadLine();
        }
    }
}
