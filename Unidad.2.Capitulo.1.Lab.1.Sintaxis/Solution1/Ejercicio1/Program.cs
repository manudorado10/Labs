using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese texto");
            string inputTexto;
            inputTexto = Console.ReadLine();
            if (inputTexto != "")
            {
                Console.WriteLine("Menu de opciones" + "\n Ingrese alguna de las siguientes opciones" + "\n 1. Mayuscula" + "\n 2. Minuscula" + "\n 3. Longitud");
                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.WriteLine(opcion.Key);
                if (opcion.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("Longitud del texto" + inputTexto.Length);
                }
                else
                {
                    if (opcion.Key == ConsoleKey.D1)
                    {
                        Console.WriteLine(inputTexto.ToUpper());
                    }
                    else
                    {
                        Console.WriteLine(inputTexto.ToLower());
                    }
                }
            }
            else
            {
                Console.WriteLine("No se ha ingresado texto");
            }
        }
    }
}
