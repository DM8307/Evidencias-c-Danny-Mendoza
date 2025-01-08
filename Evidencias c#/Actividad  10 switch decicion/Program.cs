// See https://aka.ms/new-console-template for more information

//ejemplo de este capitulo con un programa que trabajamos anteriormente

seleccion:
int seleccion = 0, decision;
string condicion;

Console.WriteLine($@"
                        |Digite un numero para elegir un programa|
1.Programa que muestre los números descendentes del 1 al 100 de dos en dos;
2.Programa que pida un número y muestre la tabla del 10 al 100 de dicho número;
3.Programa que pregunte la cantidad de montos, pida dichos montos y calcule la sumatorio y el promedio de estos;
4.Programa que pida un nombre y se repita mientras no sea Jose o José, colocando como límite que la cantidad de nombres ingresados sea menor o igual a 8.
5.Salir

");
    seleccion = Convert.ToInt32(Console.ReadLine());
    switch (seleccion)
    {
        case 1:
        Console.WriteLine("Números descendentes del 1 al 100 de dos en dos:");
        for (int i = 100; i >= 1; i -= 2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine(" ");
        Console.WriteLine("Quiere volver a la seleccion? escribe si o no");
        condicion = Console.ReadLine();
        decision = string.Compare(condicion, "si", true);
        if (decision == 0)
        {
            goto seleccion;
        }else
        {
            goto final;
        }
        case 2:
        
        Console.Write("\nIngresa un número para mostrar su tabla del 10 al 100: ");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine($"Tabla de {numero}:");
        for (int i = 10; i <= 100; i += 10)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }



        Console.WriteLine(" ");
        Console.WriteLine("Quiere volver a la seleccion? escribe si o no");
        condicion = Console.ReadLine();
        decision = string.Compare(condicion, "si", true);
        if (decision == 0)
        {
            goto seleccion;
        }else
        {
            goto final;
        }
        case 3:
       
        Console.Write("\n¿Cuántos montos deseas ingresar? ");
        int cantidadMontos = int.Parse(Console.ReadLine());
        double suma = 0;

        for (int i = 1; i <= cantidadMontos; i++)
        {
            Console.Write($"Monto {i}: ");
            double monto = double.Parse(Console.ReadLine());
            suma += monto;
        }

        double promedio = suma / cantidadMontos;
        Console.WriteLine($"\nSuma total: {suma}");
        Console.WriteLine($"Promedio: {promedio}");
        
        Console.WriteLine(" ");
        Console.WriteLine("Quiere volver a la seleccion? escribe si o no");
        condicion = Console.ReadLine();
        decision = string.Compare(condicion, "si", true);
        if (decision == 0)
        {
            goto seleccion;
        }else
        {
            goto final;
        }
        case 4:
        Console.WriteLine("\nIngresa nombres (máximo 8 intentos):");
        int intentos = 0;
        string nombre;

        do
        {
            Console.Write($"Intento {intentos + 1}: ");
            nombre = Console.ReadLine();
            intentos++;
        }
        while (nombre != "Jose" && nombre != "José" && intentos < 8);

        if (nombre == "Jose" || nombre == "José")
        {
            Console.WriteLine("¡Nombre correcto!");
        }
        else
        {
            Console.WriteLine("Se alcanzó el límite de intentos.");
        }

        Console.WriteLine(" ");
        Console.WriteLine("Quiere volver a la seleccion? escribe si o no");
        condicion = Console.ReadLine();
        decision = string.Compare(condicion, "si", true);
        if (decision == 0)
        {
            goto seleccion;
        }else
        {
            goto final;
        }
        case 5:
        goto final;
        default:
            Console.WriteLine(" Lo que selecciono esta fuera de los parametros ");
        goto seleccion;

    }
final:;
