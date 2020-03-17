using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3_Manejo_de_Modularidad
{
    class Program
    {
        public double IVA, SUBTOTAL, TOTAL, FACTURA;
        

        public string[] P;
        public double[] C, CA;
        Random random = new Random();
        



        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Mercado();
            obj.Calcular();
            obj.imprimir();
            Console.ReadKey();
           
        }

        public void Mercado()
        {
            C = new double[5];
            CA = new double[5];
            P = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese nombre del producto #" + (i + 1));
                P[i] = Console.ReadLine();
                Console.WriteLine("Cantidad");
                CA[i] = Double.Parse(Console.ReadLine());
                Console.WriteLine("Precio del producto: ");
                C[i] = double.Parse(Console.ReadLine());
                Console.Clear();
                SUBTOTAL = SUBTOTAL + (C[i] * CA[i]);
            }
        }
         public void Calcular()
        {
            IVA = SUBTOTAL * 0.15;
            TOTAL = SUBTOTAL + IVA;
        }

        public void imprimir()
        {
                FACTURA = random.Next(1, 10000);
               
                Console.WriteLine("LA TIENDITA\nAbarrotes y carnes\n\nFactura # " + FACTURA +"\n\n" + "03/02/2020\n\n" + "ID CLIENTE: 666" + "\n\n");
                Console.WriteLine("{0,-14}{1,7}{2,8}{3,9}", "Productos", "Cantidad", "C/U", "Total\n");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("{0,-14}{1,4}{2,11}{3,9}", P[i], CA[i], ("$" + C[i]), ("$" + CA[i] * C[i]));
                }
                Console.WriteLine("{0,-14}{1,26}", "Sub-total:", ("$" + SUBTOTAL + "\n"));
                Console.WriteLine("{0,-14}{1,26}", "IVA:", ("$" + IVA + "\n"));
                Console.WriteLine("{0,-14}{1,29}", "Total:", ("$" + TOTAL + "\n\n\n"));
                
            
        }

    }
}
