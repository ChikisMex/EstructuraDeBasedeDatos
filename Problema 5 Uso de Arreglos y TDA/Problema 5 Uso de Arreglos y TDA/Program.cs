using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5_Uso_de_Arreglos_y_TDA
{
    class Program
    {

        static void Main(string[] args)
        {

            jugadores obj = new jugadores();
            obj.captura();
            obj.convercion();
            
            obj.imprimir();



            Console.ReadKey();

        }


    }
}


namespace Problema_5_Uso_de_Arreglos_y_TDA
{
    public class jugadores
    {
        string[] A = new string[10];
        string[] M = new string[10];
        int[] varible = new int[10];

        public void captura()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno jugador: " + (i + 1));
                A[i] = Console.ReadLine();
                Console.WriteLine("Cuanto mide en metros: ");
                M[i] = Console.ReadLine();
            }
        }
            
        public void convercion()
        {
            for (int x= 0; x< M.Length; x++)
            {
                varible[x] = int.Parse(M[x]);
            }
        }

        public int alturamayor()
        {
            int mayor = 0, x = 0;
            while (x< varible.Length)
            {
                if(varible[x]> mayor)
                {
                    mayor = varible[x];
                }
            }
            return mayor;
        }

        public float promediodealtura()
        {
            float suma = 0, promedio = 0;
            for(int x = 0; x < M.Length; x++)
            {
                suma = suma + varible[x];
            }
            return promedio = suma / 10;
        }

        public void imprimir()
        {
            for(int x=0; x< A.Length; x++)
            {
                Console.WriteLine("Nombre del jugador: {0}", A[x], x + 1 + "\n");
                Console.WriteLine("Altura del jugador: {0]", varible[x]);

            }
            
        }  

     }
}

    

    