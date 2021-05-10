using System;

namespace Clases
{
    public class Juego
    {
        private int _record = 0;

        public int Record
        {
            get { return _record;}
            set
            {
                _record = value;
            }
        }

        public void ComenzarJuego()
        {
            bool seguir = true;
            while (seguir == true) {
                int maxval = PreguntarMaximo();
                bool val = false;
                Jugada ju = new Jugada(maxval);
                while (val == false)
                {
                    int num = PreguntarNumero();
                    val = ju.Comparar(num);
                    Console.WriteLine("--------");

                }
                if (val == true)
                {
                    Console.WriteLine("--------");
                    int ij = ju.Intentos;
                    Console.WriteLine(ij);
                    CompararRecord(ij);
                }
                Console.WriteLine("Desea continuar No/Si");
                string op = Console.ReadLine();
                switch (op)
                {
                    case "Si":
                        seguir = true;
                        break;
                    case "No":
                        seguir = false;
                        break;
                }



            }
            
        }

        private void CompararRecord(int intentos)
        {
            if (_record == 0 || _record > intentos)
            { 
                _record = intentos;
                Console.WriteLine($"Nuevo record {_record} intentos");
            }
        }

        private void Continuar()
        {   
        }

        private int PreguntarMaximo()
        {
            int _maxval;
            Console.WriteLine("Ingrese el maximo valor a adivinar (0-maximo)");
            _maxval = int.Parse(Console.ReadLine());
            return _maxval;
        }

        private int PreguntarNumero()
        {
            int _num;
            Console.WriteLine("Ingrese un numero (Ingrese un numero mayor al maximo para terminar)");
            _num = int.Parse(Console.ReadLine());
            return _num;

        }
        
    }
}
