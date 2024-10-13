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
    internal class Ejercicio3 : IEjecutarEjercicio
    {
        public void Ejecutar()
        {
            Console.WriteLine("Introduce una lista de números separados por espacios:");
            string input = Console.ReadLine();
            int[] numeros = input.Split(' ').Select(int.Parse).ToArray();
            int resultado = ObtenerMenosRepetido(numeros);
            Console.WriteLine($"El número que menos se repite es: {resultado}");
        }

        static int ObtenerMenosRepetido(int[] numeros)
        {
            Dictionary<int, int> frecuencia = new Dictionary<int, int>();
            foreach (int num in numeros)
            {
                if (frecuencia.ContainsKey(num))
                {
                    frecuencia[num]++;
                }
                else
                {
                    frecuencia[num] = 1;
                }
            }

            int menorFrecuencia = frecuencia.Values.Min();

            var numerosConMenorFrecuencia = frecuencia
                                            .Where(pair => pair.Value == menorFrecuencia)
                                            .Select(pair => pair.Key);
            return numerosConMenorFrecuencia.Min();
        }
    }
}
