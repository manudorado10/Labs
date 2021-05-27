using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using FuncionesLINQ;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            //Ejercicio1
            var provincias = new List<string> { "Jujuy", "Salta", "Formosa", "Chaco", "Corrientes", "Misiones", "Catamarca", "Tucuman", "Santiago del Estero", "Santa Fe", "Entre Rios", "La Rioja", "Cordoba", "San Juan", "San Luis", "Mendoza", "La Pampa", "Buenos Aires", "Neuquen", "Rio Negro", "Chubut", "Santa Cruz", "Tierra del Fuego" };
            var selectProv = from p in provincias where p.StartsWith("S") | p.StartsWith("T") select p;

            foreach (var p in selectProv) 
            {
                Console.WriteLine(p);
            }


            //Ejercicio 2 -Crear un programa que acepte una lista de números, los almacene en un objeto del tipo List<int>
            //y luego usando LINQ muestre por Consola aquellos que son mayores a 20.
            var numeros = new List<int> {1,5,2,4,8,21,25,29,52,93,102};
            var selectNum = from n in numeros where n > 20 select n;
            foreach (var n in selectNum)
            {
                Console.WriteLine(n);
            }
            //Ejercicio 3 - Dado un ArrayList que incluya al menos 10 Ciudades de Argentina incluyendo Nombre y Código
            //Postal usar LINQ para obtener y mostrar por Consola el Código Postal de aquellas ciudades que
            //incluyan dentro de su nombre una expresión de busqueda de tres caracteres, sin respetar
            //mayusculas o minusculas. Por ejemplo, si se ingresa “ros” y el ArrayList incluye Rosario entonces
            //debe mostrarse el Código Postal de Rosario.
            
            List<Ciudad> ciudades = new List<Ciudad>()
            {
                new Ciudad ()
                {
                    Nombre = "Rosario",
                    CodigoPostal = 2000
                },
                new Ciudad()
                {
                    Nombre = "Firmat",
                    CodigoPostal = 2630
                },
                new Ciudad()
                {
                    Nombre = "Santa Fe",
                    CodigoPostal = 3000
                },
                new Ciudad()
                {
                    Nombre = "Salta",
                    CodigoPostal = 4400
                },
                new Ciudad()
                {
                    Nombre = "Mendoza",
                    CodigoPostal = 5500
                },
                new Ciudad()
                {
                    Nombre = "Corrientes",
                    CodigoPostal = 3400
                },
                new Ciudad()
                {
                    Nombre = "Cordoba",
                    CodigoPostal = 5000
                },
                new Ciudad()
                {
                    Nombre = "Neuquen",
                    CodigoPostal = 8300
                },
                new Ciudad()
                {
                    Nombre = "Lanus",
                    CodigoPostal = 1824
                },
                new Ciudad()
                {
                    Nombre = "Mar del Plata",
                    CodigoPostal = 7600
                }
            };
            Console.WriteLine("Ingrese una cadena de letras para buscar");
            string cadena = Console.ReadLine();
            var selectCiudad = from c in ciudades where c.Nombre.ToLower().Contains(cadena) select c;
            foreach (var c in selectCiudad) 
            {
                Console.WriteLine(c.CodigoPostal);
            }*/
            //Ejercicio 4 - Dada una List<Empleado> donde Empleado tiene las propiedades Id (int), Nombre (string),
            //Sueldo(decimal).Crear un programa que acepte dar de alta Empleados en esta lista y luego
            //muestre por Consola esta misma Lista ordenada por la propiedad Sueldo, tanto de manera
            //ascendente como descendente
            bool seguir = true;
            int id;
            string name;
            double salario;
            List<Empleado> empleados = new List<Empleado>();
            while (seguir == true)
            {
                Console.WriteLine("Ingrese los datos del empleado");

                Console.WriteLine("Ingrese el id");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre");
                name = Console.ReadLine();

                Console.WriteLine("Ingrese el sueldo");
                salario = Console.Read();

                Empleado nuevoEmpelado = new Empleado()
                {
                    Id = id,
                    Nombre = name,
                    Sueldo = salario
                };
                empleados.Add(nuevoEmpelado);
                Console.WriteLine("Desea agregar otro empelado 1-si/ 2-no");
                int op = int.Parse(Console.ReadLine());
                /*switch (op)
                {
                    case 1:
                        {
                            seguir = true;
                            break;
                        }
                    case 2:
                        {
                            seguir = false;
                            break;
                        }

                }*/
                if (op == 1) { seguir = true; } else { seguir = false; }
            }
            var misEmpleadosAsc = from e in empleados orderby e.Sueldo ascending select e;
            foreach (var e in misEmpleadosAsc)
            {
                Console.WriteLine(e);
            }
            var misEmpleadosDesc = from e in empleados orderby e.Sueldo ascending select e;
            foreach (var e in misEmpleadosDesc)
            {
                Console.WriteLine(e);
            }

        }   
    }
}