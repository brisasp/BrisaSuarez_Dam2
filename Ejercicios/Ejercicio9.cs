using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicios;
using System;
using System.Linq;

namespace Ejercicios
{
    internal class Ejercicio9 : IEjecutarEjercicio
    {
        public void Ejecutar()
        {
            Console.WriteLine("Introduce un número entero no negativo:");
            string input = Console.ReadLine();
            if (ulong.TryParse(input, out ulong num))
            {
                ulong resultado = ReordenarNum(num);
                Console.WriteLine($"El numero {num} es: {resultado}");
            }
            else{
                Console.WriteLine("Por favor, introduce un número entero no negativo válido.");
            }
        }

        static ulong ReordenarNum(ulong num)
        {
            string numeroStr = num.ToString();
            char[] digitos = numeroStr.ToCharArray();
            Array.Sort(digitos);
            Array.Reverse(digitos);
            return ulong.Parse(new string(digitos));
        }
    }
}