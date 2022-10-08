using System;
using System.Colletions.Generic;
using System.Linq;
using Sistem.Text;

namespace CalculoVenta;

static void Main(string[] args)
    {
        int cantidad;
        float PrecioArticulo, ValorVenta;
        string linea;

        Console.Write("ingresar el valor del articulo:");
        linea = Console.ReadLine();
        cantidad = int. Parse(linea);
        ValorVenta = PrecioArticulo * cantidad;
        Console.Write("El valor de la venta es:");
        Console.WriteLine(ValorVenta);
        Console.ReadKey();
    }
