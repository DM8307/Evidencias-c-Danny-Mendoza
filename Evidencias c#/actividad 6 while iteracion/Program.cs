// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_While_Iteracion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Menudedisplay = true;
            while (Menudedisplay)
            {
                Menudedisplay = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Escoge una opcion: ");
            Console.WriteLine("1) Mostrar Numero");
            Console.WriteLine("2) Juego de adivinanza");
            Console.WriteLine("3) Salir");

            string Resultados = Console.ReadLine();
            if (Resultados == "1")
            {
                PrintNumber();
                return true;
            }

            else if (Resultados == "2")
            {
                GuessingGame();
                return true;
            }

            else if (Resultados == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void PrintNumber()
        {
            Console.Clear();
            Console.WriteLine("Mostrar Numero!");
            Console.WriteLine("Escribe un numero: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1)
            {
                Console.Write(counter);
                Console.Write(" - ");
                counter++;
            }
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Juego de adivinanza");

            Random myRandom = new Random();
            int randonNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Adivina el numero entre 1 y 10");
                string result = Console.ReadLine();
                guesses++;
                if (result == randonNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Equivocado!");

            } while (incorrect);
            Console.WriteLine("Correcto! Te tomo {0} para adivinarlo.", guesses);

            Console.ReadLine();
        }
    }
}
