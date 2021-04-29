using System;

namespace LabSintaxis2
{
    class Ejercicio3
    {
        static void Main2(string[] args)
        { 
            int cantIteraciones = 5;
            string[] datos = new string[cantIteraciones];
            for (int i = 0; i < cantIteraciones; i++) {
                datos[i] = Console.ReadLine();
            }
            for (int x = cantIteraciones; x < 1 ; x--){
                Console.WriteLine(datos[x]);
            }
        }
    }
}