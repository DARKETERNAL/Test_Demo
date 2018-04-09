using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_Demo
{
    class CalculadorTriangulos
    {
        public void DeterminarTipoTriangulo(float a1, float a2, float a3)
        {
            if (a1 + a2 + a3 == 180)
            {
                 if (a1 == a2 && a2 == a3)
                {
                    Console.WriteLine("El triángulo entrado es equiángulo");
                }
                else if (a1 == 90 || a2 == 90 || a3 == 90)
                {
                    Console.WriteLine("El triángulo entrado es rectángulo");
                }
                else if (a1 < 90 && a2 < 90 && a3 < 90)
                {
                    Console.WriteLine("El triángulo entrado es agudo");
                }
                else if (a1 > 90 || a2 > 90 || a3 > 90)
                {
                    Console.WriteLine("El triángulo entrado es obtuso");
                }
                else
                {
                    Console.WriteLine("No puedo determinar el tipo de triángulo");
                }
            }
            else
            {
                Console.WriteLine("Los valores entrados no describen un triángulo");
            }
        }
    }
}
