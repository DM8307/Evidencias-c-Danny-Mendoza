// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_if_desicion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Gran sorteo de Bob");
            Console.Write("Elige una puerta: 1, 2 o 3: ");
            string Valor = Console.ReadLine();

            string msg = "";

            if (Valor == "1")
                msg = "Te ganaste un carro";
            else if (Valor == "2")
                msg = "Te ganaste un Barco!";
            else if (Valor == "3")
                msg = "Te ganaste un Gato!";
            else
            {
                msg = "Disculpe, No se entendio. ";
                //msg = msg + "Perdiste.";
                msg += "Perdiste.";
            }

            Console.WriteLine(msg);
            Console.ReadLine();
            */

            Console.WriteLine("Gran sorteo de Bob");
            Console.Write("Elige una puerta: 1, 2 o 3: ");
            string userValue = Console.ReadLine();

            //if-else syntax = if value equals 1 then 'Barco' else 'pelusas'
            string msg = (userValue == "1") ? "Barco" : "pelusas";

            //Console.Write("Ganaste un ");
            //Console.Write(msg);
            //Console.Write(".");
            //Console.ReadLine();

            //string manipulation {} value replaced by msg
            //Console.WriteLine("Ganaste un {0}.", msg);
            //Console.ReadLine();

            Console.WriteLine("Tu entrada: {0}, Por eso ganaste un {1}.", userValue, msg);
            Console.ReadLine();

        }
    }
}