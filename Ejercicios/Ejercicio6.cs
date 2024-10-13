using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using Ejercicios;

namespace Ejercicios
{
    internal class Ejercicio6 : IEjecutarEjercicio
    {
        public void Ejecutar()
        {
            Console.WriteLine("Introduce un número positivo:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int num) && num > 0)
            {
                int resultado = CalcularPMultiplicativa(num);
                Console.WriteLine($"La persistencia multiplicativa de {num} es: {resultado}");
            }
            else
            {
                Console.WriteLine("Introduce un número positivo.");
            }
        }

        static int CalcularPMultiplicativa(int num)
        {
            int contador = 0;
            while (num >= 10)
            {
                num = MultiplicarDigitos(num);
                contador++;
            }
            return contador;
        }

        static int MultiplicarDigitos(int num)
        {
            int resto = 1;
            while (num > 0)
            {
                resto *= num % 10; 
                num /= 10;
            }
            return resto;
        }
    }
}