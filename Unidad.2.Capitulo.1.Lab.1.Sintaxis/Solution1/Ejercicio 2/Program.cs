using System;

namespace Ejercicio_2
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
                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(inputTexto.ToUpper());
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine(inputTexto.ToLower());
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("Longitud del texto" + inputTexto.Length);
                        break;
                    default:
                        Console.WriteLine("No selecciono una opcion valida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("No se ha ingresado texto");
            }
        }
    }
}
