using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6_Uso_de_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena, cadena2;

            Console.WriteLine("Frase: ");
            cadena = "Hola, quetal ¿como estas?";

            Console.WriteLine(cadena +"\n");
            Console.WriteLine("Frase con letra a y cambio por letra o:");
            cadena2 = cadena.Replace("a", "o");
            Console.WriteLine(cadena2 + "\n");


            Console.ReadKey();
        }
    }
}
