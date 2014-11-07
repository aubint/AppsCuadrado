using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado,perimetro;
            Console.WriteLine("HALLAR EL PERIMETRO DE UN CUADRADO");

            Console.WriteLine("Ingrese lado del cuadrado: ");
            lado = int.Parse(Console.ReadLine());
            perimetro = lado * 4;

            Console.WriteLine("El perimetro del cuadrado es: "+perimetro);
            Console.ReadKey();

        }
    }
}
