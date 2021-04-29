using System;
using System.Collections;

namespace LabSintaxis4
{
    class Program
    {
        static void Main(string[] args)
        { /*1)
            Console.WriteLine("Ingrese el primer valor a sumar:");
            int val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor a sumar valor a sumar:");
            int val2 = int.Parse(Console.ReadLine());
            int resultado = val1 + val2;
            Console.Write($"El resultado de la suma de {val1} y {val2} es {resultado} ");*/

            /*2)
            Console.WriteLine("Ingrese un año:");
            int anio = int.Parse(Console.ReadLine());
            bool bandera = false;
            int res1 = anio % 100;
            if (res1 != 0)
            {
                int res2 = anio % 4;
                if (res2 == 0) {
                    bandera = true;
                }
            }
            else{
                int res3 = (anio / 100) % 4;
                if (res3 == 0) {
                    bandera = true;
            }
            }
            if (bandera == true){
                Console.WriteLine($"El año {anio} es bisiesto");
            }
            else {
                Console.WriteLine($"El año {anio} no es bisiesto");
            }*/

            /*//3 Serie de fibonacci
            int num1 = 0;
            int num2 = 1;
            int cant = 20;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            for (int i = 0; i < cant; i++) {
                int res= num1 + num2;
                num1 = num2;
                num2 = res;
                Console.WriteLine(res);
            }*/

            /*//4)
            for (int i = 1; i < 101; i++) {
                int z = i % 2;
                if (z == 0) {
                    Console.WriteLine(i);
                }
            }*/
            /*//5)
            string[] meses = new string [12]{"Enero","Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
            Console.WriteLine("Ingrese el nombre de un mes del año");
            string mes = Console.ReadLine();
            for(int i = 0; i < 12; i++)
            {
                if (mes.ToUpper() == meses[i].ToUpper())
                {
                    Console.Write(meses[i] + " " + (i + 1));
                }
            }*/
            /*//6)
            Console.WriteLine("Ingrese un numero entre 1 y 3999");
            int num = int.Parse(Console.ReadLine());
            string[] unidades = new string[10] {"", "I", "II", "III", "IV","V", "VI", "VII", "VIII", "IX" };
            string[] decenas = new string[10] {"", "X", "XX", "XXX", "IV", "XL", "L", "LXX", "LXXX", "XC" };
            string[] centenas = new string[10] {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] miles = new string[3] { "M", "MM", "MMM"};
            decimal x = num / 1000;
            Console.WriteLine(x);
            int mil = (int)System.Math.Truncate(x);
            x = (num % 1000) / 100;
            
            int cien = (int)System.Math.Truncate(x);
            x= ((num % 1000) % 100) / 10;
           
            int diez = (int)System.Math.Truncate(x);
            x = (((num % 1000) % 100) % 10);
            int uni = (int)System.Math.Truncate(x);
            
            Console.WriteLine($"El numero {num} en romano se escribe: " + miles[mil-1]+ centenas[cien]+ decenas[diez]+ unidades[uni]);
            */
            /*//7)
            int cant = 200;
            ArrayList primos = new ArrayList();
            ArrayList divisores = new ArrayList();
            for (int i = 1; i < cant+1; i++)
            {
                divisores.Clear();
                for (int x = 1; x < i+1; x++)
                {
                    decimal div = (decimal)i / x;

                    if ((int)div - div == 0)
                    {
                        divisores.Add(x);
                        //Console.WriteLine($"El numero {x} es divisor entero de {i}");
                    }
                }
                if (divisores.Count == 2)
                {
                    primos.Add(i);
                    //Console.WriteLine($"El numero {i} es primo");
                }
            }
            for (int z = 1; z < primos.Count; z++) {
                int j = (int)primos[z-1];
                int k = (int)primos[z];
                if ((k - j) == 2)
                {
                    Console.WriteLine($"Los numeros {primos[z - 1]} y {primos[z]} son primos gemelos");
                }

            }
            //-----------------------------------------------------------------------------------------*/
            /*//8)
            string clave = "hola";
            int intentos = 0;
            while (intentos < 4 ){
                intentos += 1;
                Console.WriteLine("Introduzca la clave");
                string leer=Console.ReadLine();
                if (leer == clave) {
                    Console.WriteLine("Clave Correcta");
                    break;
                }
                else
                {
                    Console.WriteLine("Clave incorrecta");
                }
            }*/

            //9)
            Console.WriteLine("Ingrese un numero de filas");
            int filas =(int)Console.Read();
            string g = "*";
            for (int i = 0; i < filas; i++) {
                string imp = "";
                for (int z = 0; z < 2 * filas + 1; z++)
                {
                    imp = imp + g;
                }
                Console.SetCursorPosition((Console.WindowWidth - imp.Length) / 2,3+i);
                Console.WriteLine(imp);
            }

        }   
    }
}
