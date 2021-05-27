using System;

namespace Geometria
{
    public class Circulo
    {
        private int m_radio;

        public int Radio
        {
            get => default;
            set
            {
                m_radio = value;
            }
        }

        public void CalcularPerimetro()
        {
            double per;
            per = 2 * System.Math.PI* m_radio;
            Console.WriteLine($"El perimetro es igual a {per} ");
        }

        public void CalcularSuperficie()
        {
            double sup;
            sup = System.Math.Pow(System.Math.PI,2) * m_radio;
            Console.WriteLine($"La superficie es igual a {sup} ");
        }
    }
}
