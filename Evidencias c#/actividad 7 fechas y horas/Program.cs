// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Fechas_horas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Mivalortemporal = DateTime.Now;
            Console.WriteLine(Mivalortemporal.ToString());
            Console.WriteLine(Mivalortemporal.ToShortDateString());
            Console.WriteLine(Mivalortemporal.ToShortTimeString());
            Console.WriteLine(Mivalortemporal.ToLongDateString());
            Console.WriteLine(Mivalortemporal.ToLongTimeString());


            Console.WriteLine(Mivalortemporal.AddDays(3).ToLongDateString());
            Console.WriteLine(Mivalortemporal.AddHours(3).ToLongTimeString());
            Console.WriteLine(Mivalortemporal.AddDays(-3).ToLongDateString());

            Console.WriteLine(Mivalortemporal.Month);

            DateTime Micumple = new DateTime(2003, 12, 8);
            Console.WriteLine(Micumple.ToShortDateString());

            DateTime Minacimiento = DateTime.Parse("12/8/2003");
            TimeSpan Miedad = DateTime.Now.Subtract(Minacimiento);
            Console.WriteLine(Miedad.TotalDays);
        }
    }
}



