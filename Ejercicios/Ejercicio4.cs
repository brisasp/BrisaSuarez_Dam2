using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicios;

namespace Ejercicios
{
    internal class Ejercicio4 : IEjecutarEjercicio
    {
        public void Ejecutar()
        {
            Console.WriteLine("Introduce una lista de números separados por espacios:");
            string input = Console.ReadLine();

            int[] numeros = input.Split(' ').Select(int.Parse).ToArray();
            List<int> resultado = EncontrarNumerosConRepeticionesImpares(numeros);
            if (resultado.Count > 0)
            {
                Console.WriteLine("Los números que aparecen un número impar de veces: " + string.Join(", ", resultado));
            }
            else
            {
                Console.WriteLine("No hay números");
            }
        }

        static List<int> EncontrarNumerosConRepeticionesImpares(int[] numeros)
        {
            Dictionary<int, int> frecuencia = new Dictionary<int, int>();
            foreach (int num in numeros)
            {
                if (frecuencia.ContainsKey(num))
                {
                    frecuencia[num]++;
                }else{
                    frecuencia[num] = 1;
                }
            }
            List<int> numerosImpares = frecuencia
                                        .Where(pair => pair.Value % 2 != 0)
                                        .Select(pair => pair.Key)
                                        .ToList();

            return numerosImpares;
        }
    }
}