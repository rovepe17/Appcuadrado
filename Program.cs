using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado, perimetro;
            Console.WriteLine("programa que calcule perimetro de cuadrado");
            Console.WriteLine("digite lado de un cuadrado");
            lado = int.Parse(Console.ReadLine());
            perimetro = lado * 4;
            Console.WriteLine("el perimetro es:" + perimetro);
            Console.ReadKey();


        }
    }
}
