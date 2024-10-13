using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicios;

namespace Ejercicios
{
    internal class Ejercicio8 : IEjecutarEjercicio
    {
        public void Ejecutar()
        {
            Console.WriteLine("Introduce los elementos de la lista A separados por espacios:");
            string inputA = Console.ReadLine();
            int[] listaA = inputA.Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Introduce los elementos de la lista B separados por espacios:");
            string inputB = Console.ReadLine();
            int[] listaB = inputB.Split(' ').Select(int.Parse).ToArray();

            var dif = Diferencia(listaA, listaB);
            Console.WriteLine("Resultado == " + string.Join(", ", dif));
        }
        static int[] Diferencia(int[] listaA, int[] listaB)
        {
            HashSet<int> conjuntoB = new HashSet<int>(listaB);
            return listaA.Where(x => !conjuntoB.Contains(x)).ToArray();
        }
    }
}