using System;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {  
            int cantIteraciones = 5;
            string[] datos = new string[cantIteraciones];
            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.Write($"Ingrese letra para la posicion{i + 1}:");
                datos[i] = Console.ReadLine();
            }
            for (int x = 0; x < cantIteraciones; x++)
            {
                int z = cantIteraciones - x;
                Console.WriteLine(datos[z-1]);
            }
            
        }
    }
}
