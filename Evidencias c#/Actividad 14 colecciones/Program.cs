// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /* comentado para el inicializador de objeto a continuación, línea 77
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Modle = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Modle = "Prism";
            car2.VIN = "B2";

            Book book1 = new Book();
            book1.Author = "Robert Tabor";
            book1.Title = "Microsoft .NET XML Web Services";
            book1.ISBN = "0=000=00000=0";
            */

            /*
            //old style collections

            //ArrayLists son de tamaño dinamico, ademas tienen funciones como sorting(organizar), remove items(remover objetos o valores)
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(book1);
            myArrayList.Remove(book1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
                
            }
            
            */


            /*
            //Newer style of collections = List<T> - generics where type <T> customizes generic to specific

            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            // myList.Add(book1);  --won't allow as list is specific to car datatype

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Make); 
            }
            */


            /*
            //Dictionary<TKey, TValuel> is a key/value pair list
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B2"].Make);
            */

            //inicializacion de un array con o sin usar una nueva palabrea clave
            //string[] names = { "Bob", "Steve", "Brian", "Chuck" };

            //object initializer  using object initialization syntax
            //No es necesario el contructor
            //Comentar car y books de arriba para ejecutar lo de abajo
            Car car1 = new Car() { Make = "BMW", Modle = "750li", VIN = "C3" };
            Car car2 = new Car() { Make = "Toyota", Modle = "4Runner", VIN = "D4" };

            //collection initializer
            List<Car> myList = new List<Car>
            {
                new Car {Make = "Oldsmobile", Modle = "Cutless Supreme", VIN = "A1" },
                new Car {Make = "Nisan" , Modle = "Altima", VIN = "F6" }
            };

            Console.ReadLine();

        }

        class Car
        {
            public string Make { get; set; }
            public string Modle { get; set; }
            public string VIN { get; set; }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
        }
    }
}
