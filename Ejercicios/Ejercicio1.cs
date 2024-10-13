using Ejercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicio1 : IEjecutarEjercicio
    {
        public void Ejecutar()
        {
            Console.WriteLine("Introduce una frase para contar las vocales:");
            string frase = Console.ReadLine();
            int numeroDeVocales = ContarVocales(frase);
            Console.WriteLine($"El número de vocales en la frase es: {numeroDeVocales}");
        }
        static int ContarVocales(string cadena)
        {
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            int contador = 0;

            foreach (char c in cadena)
            {

                if (Array.Exists(vocales, v => v == c))
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}

