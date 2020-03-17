using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4_uso_de_Tipos_de_Datos_Abstractos
{
    class Program
    {
        static void Main(string[] args)
        {         
            
                    
            Console.WriteLine("Cuantos alumnos va evaluar: ");
            string var1 = Console.ReadLine();
             int variable1 = int.Parse(var1);
            



            while (variable1 <= 1)
            {
                Console.Clear();
                Console.WriteLine("Digite numeros de alumnos mayor a 1: ");
                variable1 = int.Parse(Console.ReadLine());




            }
            Console.Clear();
            string var2 = "2";
            
            int variable2 = int.Parse(var2);
            double sumi = 0;
            double[,] matriz1 = new double[variable1, variable2];
            string[] N;
            N = new string[5];


            for (int i = 0; i < variable1; i++)
            {
                Console.WriteLine("Ingrese nombre del alumno: " + (i + 1));
                N[i] = Console.ReadLine();
                for (int j = 0; j < variable2; j++)
                {
                    Console.WriteLine("\nAsignando la nota {0}:", j + 1);
                    matriz1[i, j] = double.Parse(Console.ReadLine());
                    
                }
                Console.Clear();
            }


            Console.Clear();
            //imprimiendo notas y promedio 

            for (int i = 0; i < variable1; i++)
            {
                Console.WriteLine("Notas del alumnos {0} ", N[i], i + 1+"\n\n");
                for (int j = 0; j < variable2; j++)
                {
                    Console.WriteLine("NOTA {0}: {1}", j + 1, matriz1[i, j]+"\n");


                    sumi = sumi + matriz1[i, j];


                }
                Console.WriteLine("PROMEDIO: {0}", sumi / 2);
                sumi = 0;
            }


            Console.ReadKey();


        }
    }
}
