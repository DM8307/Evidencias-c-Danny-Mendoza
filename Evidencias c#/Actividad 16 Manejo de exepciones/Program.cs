// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _16_Manejo_de_exepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText
                (@"C:\Users\Danny\source\repos\DM8307\Evidencias-c-Danny-Mendoza\Evidencias c#\Actividad 16 Manejo de exepciones\ejemplo.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Ocurrion un poblema!");
                Console.WriteLine("Asegurate de que el nombre este nombrado correctamente: ejemplo.txt");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Ocurrion un poblema!");
                Console.WriteLine(@"Asegurate que el directorio c:\users\... exista");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrion un poblema!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //code to finalize
                //setting objects to null
                //closing database connections
                Console.WriteLine("Cerrando aplicacion ahora...");
            }
            Console.ReadLine();
        }
    }
}
