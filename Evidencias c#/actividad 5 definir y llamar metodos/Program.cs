// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            // using helper methods

            Console.WriteLine("El nombre del juego");

            Console.Write("Cual es su primer nombre: ");
            string firstName = Console.ReadLine();

            Console.Write("Cual es su apellido: ");
            string lastName = Console.ReadLine();

            Console.Write("En que ciudad vive? ");
            string city = Console.ReadLine();

            DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(city));

            Console.ReadLine();

        }

        private static string ReverseString(string message)
        {
            char[] msgArray = message.ToCharArray();
            Array.Reverse(msgArray);
            return String.Concat(msgArray);
        }

        private static void DisplayResult(string reversedFirstName, string reversedLastName, string reversedCity)
        {
            Console.Write("Resultados: ");
            Console.Write(String.Format("{0} {1} {2})", reversedFirstName, reversedLastName, reversedCity));
        }

        private static void DisplayResult(string message)
        {
            Console.Write("Resultados: ");
            Console.Write(message);
        }
    }
}