using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Jugada
    {
        private bool _adivino;
        private int _intentos;
        private int _numero;

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
            Intentos = 0;
        }

        private bool Adivino
        {
            get { return _adivino; }
            set
            {
                _adivino = value;
            }
        }

        public int Intentos
        {
            get { return _intentos;}
            set
            {
                _intentos = value;
            }
        }

        private int Numero
        {
            get { return _numero; }
            set
            {
                _numero = value;
            }
        }

        public bool Comparar(int num)
        {

            if (num == Numero)
            {
                Adivino = true;
                Console.WriteLine("Acerto el numero");
            }
            else
            {
                Adivino = false;
                Console.WriteLine("Numero incorrecto");
            }
            Intentos += 1;
            return Adivino;
        }
    }
}
