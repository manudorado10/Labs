using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Poligono
    {
        public void CalcularPerimetro()
        {
            throw new System.NotImplementedException();
        }

        public void CalcularSuperficie()
        {
            throw new System.NotImplementedException();
        }
    }

    class Rectangulo : Poligono
    {
        private int Alto;
        private int Ancho;
    }

    class Cuadrado : Rectangulo
    {
        private int Lado;
    }


}   

