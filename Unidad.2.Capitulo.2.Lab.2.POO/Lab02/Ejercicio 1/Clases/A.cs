using System;

namespace Clases
{
    public class A
    {
        string _nombreInstancia;

        public A()
        {
            _nombreInstancia = "Instancia sin Nombre";
        }

        public A (string name)
        {
            _nombreInstancia = name;
        }

        public void mostrarNombre()
        {
            Console.WriteLine(_nombreInstancia);
        }

        public void M1()
        {
            Console.WriteLine("El metodo M1 fue invocado");
        }

        public void M2()
        {
            Console.WriteLine("El metodo M2 fue invocado");
        }

        public void M3()
        {
            Console.WriteLine("El metodo M2 fue invocado");
        }

        
    }
}


