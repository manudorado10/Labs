using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Triangulo
    {
        private int Base;
        private int Altura;

        public int DefinirBase
        {
            get { return Base;}
            set
            {
                Base = value;
            }
        }
        public int DefinirAltura
        {
            get { return Altura;}
            set
            {
                Altura = value;
            }
        }

        public Triangulo(int val1,int val2) 
        {
            Base = val1;
            Altura = val2;
        
        }

        public void CalcularPerimetro()
        {
            double per;
            per= Base + Altura + System.Math.Sqrt(System.Math.Pow(Base,2) + System.Math.Pow(Altura,2));
            Console.WriteLine($"El perimetro es igual a {per}");
        }

        public void CalcularSuperficie()
        {
            double sup;
            sup = (Base * Altura) / 2;
            Console.WriteLine($"La superficie es igual a {sup}");
        }
    }
}
