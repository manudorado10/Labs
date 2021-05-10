using System;

namespace Clases
{
    public class Persona
    {
        private string _Nombre;
        private string _Apellido;
        private int _Edad;
        private string _DNI;

        public Persona(string name, string surname, int age, string dni) 
        {
            _Nombre = name;
            _Apellido = surname;
            _Edad = age;
            _DNI = dni;
            Console.WriteLine("Objeto persona creado exitosamente");
        }
        ~Persona() 
        {
            Console.WriteLine("Objeto persona borrado exitosamente");
        }

        public string DefNombre
        {
            get {return _Nombre;}
            set
            {
                _Nombre =value;
            }
        }

        public string DefApellido
        {
            get { return _Apellido; }
            set
            {
                _Apellido = value;
            }
        }

        public string DefDni
        {
            get { return _DNI; }
            set
            {
                _DNI = value;
            }
        }

        public int DefEdad
        {
            get { return _Edad; }
            set
            {
                _Edad = value;
            }
        }

        public string GetFullName()
        {
            string fullName;
            fullName = _Nombre + " " + _Apellido;
            return fullName;
        }

        public int GetAge(int anio, int mes, int dia)
        {
            DateTime nacimiento = new DateTime(anio, mes, dia); //Fecha de nacimiento
            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
            return edad;
        }
    }
}
