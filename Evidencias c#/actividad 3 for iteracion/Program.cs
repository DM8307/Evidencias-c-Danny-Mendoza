// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_For_Iteracion
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //  Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("Se encontro 7!");
                    break;
                }
            }

            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
            }

            Console.ReadLine();
        }
    }
}
