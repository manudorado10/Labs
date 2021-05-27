using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int mxNum) : base(mxNum)
        {
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
                int diferencia = Math.Abs(Numero - num);
                if (num < Numero)
                {
                    if (diferencia > Numero * 0.5) { Console.WriteLine("Es mayor y aún estas muy lejos");}
                    else if (diferencia > Numero * 0.3) { Console.WriteLine("Es mayor y aún estas lejos pero no tanto"); }
                    else if (diferencia > Numero * 0.1) { Console.WriteLine("Es mayor y estas cerca"); }
                    else { Console.WriteLine("Es mayor y estas muy cerca"); }

                }
                else 
                {
                    if (diferencia > Numero * 0.5) { Console.WriteLine("Es menor y aún estas muy lejos"); }
                    else if (diferencia > Numero * 0.3) { Console.WriteLine("Es menory aún estas lejos pero no tanto"); }
                    else if (diferencia > Numero * 0.1) { Console.WriteLine("Es menor y estas cerca"); }
                    else { Console.WriteLine("Es menor y estas muy cerca"); }

                }

            }
            Intentos += 1;
            return Adivino;

        }
    }
}
