using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_7_Uso_de_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena1, cadena2;
            cadena1 = "ESTO ES SOLO UNA PRUEBA";
            cadena2 = cadena1.Substring(7);
            Console.WriteLine(cadena1);
            Console.WriteLine("la cadena contiene: {0} caracteres\n", cadena1.Length);
            Console.WriteLine("la cadena cortada: {0}", cadena2);
            Console.ReadKey();
        }
    }
}
