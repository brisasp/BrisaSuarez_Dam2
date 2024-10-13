using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Ejercicios
{
    internal class Ejercicio11 : IEjecutarEjercicio
    {
        public void Ejecutar()
        {
            Console.WriteLine("Introduce un número positivo:");
            int n;
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                EncontrarCuadrados(n);
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número entero positivo válido.");
            }
        }

        static void EncontrarCuadrados(int n)
        {
            for (int a = 0; a * a <= n; a++)
            {
                for (int b = 0; b * b <= n - a * a; b++)
                {
                    for (int c = 0; c * c <= n - a * a - b * b; c++)
                    {
                        int dSquare = n - a * a - b * b - c * c;
                        if (dSquare >= 0)
                        {
                            int d = (int)Math.Sqrt(dSquare);
                            if (d * d == dSquare)
                            {
                                Console.WriteLine($"El número {n} : {a}^2 + {b}^2 + {c}^2 + {d}^2");
                                return;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"No se encontró una representación para el número {n}.");
        }
    }
}