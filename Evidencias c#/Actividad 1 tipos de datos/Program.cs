// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("Cual es tu primer nombre? ");
            Console.Write("Escribe tu primer Nombre ");
            string primernombre;
            primernombre = Console.ReadLine();

            /*
            Console.Write("Cual es tu apellido? ");
            Console.Write("Escribe tu apellido: ");
            string Apellido;
            Apellido = Console.ReadLine();
            */

            Console.Write("Escribe tu apellido: ");
            string Apellido = Console.ReadLine();

            Console.WriteLine("Hola, " + primernombre + " " + Apellido);
            Console.ReadLine();

        }
    }
}
