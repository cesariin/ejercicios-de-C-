using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Perimetro_del_Cuadrado
{
    class Program
    {
        static void Main(string[]args);
        {
            int lado, perimetro;
            string linea;
            Console.Write("Escriba el lado del cuadrado:");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
            perimetro = lado * 4;
            Console.Write("El perimetro del cuadrado es:");
            Console.Write(érimetro);
            Console.ReadKey();
        }
    }
}