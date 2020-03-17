using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2_Manejo_de_Modularidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Program datos = new Program();
           
            Console.Write("\nEscribe nombre del alumno: ");
            datos.setNombre(Console.ReadLine());

            Console.Write("\nEscribe tu numero de control: ");
            datos.setMatricula(Console.ReadLine());

            Console.Write("\nEscribe tu calificacion 1: ");
            datos.setCal1(decimal.Parse(Console.ReadLine()));

            Console.Write("\nEscribe tu calificacion 2: ");
            datos.setCal2(decimal.Parse(Console.ReadLine()));

            Console.Write("\nEscribe tu calificacion 3: ");
            datos.setCal3(decimal.Parse(Console.ReadLine()));

            Console.Clear();

            Console.WriteLine("\nNombre del estudiante: "+ datos.getNombre());
            Console.WriteLine("\nNumero de control: " + datos.getMatricula());
            Console.WriteLine("\nCalificacion 1: " + datos.cal1);
            Console.WriteLine("\nCalificacion 2: " + datos.cal2);
            Console.WriteLine("\nCalificacion 3: " + datos.cal3);

            Console.WriteLine("\nPromedio: " + datos.getPromedio());
            Console.ReadKey();

        }

        private String nombre;
        private String numero_de_control;
        private decimal cal1;
        private decimal cal2;
        private decimal cal3;
        private decimal promedio;
        
        public void setNombre(String Nombre)
        {
            this.nombre = Nombre;
        }

        public void setMatricula(String matricula)
        {
            this.numero_de_control = matricula;
        }

        public void setCal1(decimal Cal1)
        {
            this.cal1 = Cal1;
        }

        public void setCal2(decimal Cal2)
        {
            this.cal2 = Cal2;
        }

        public void setCal3(decimal Cal3)
        {
            this.cal3 = Cal3;
        }

        public decimal getPromedio()
        {
            promedio = (cal1 + cal2 + cal3) / 3;

            return promedio;
        }

        public String getNombre()
        {
            return nombre;
        }

        public String getMatricula()
        {
            return numero_de_control;
        }

        public decimal getCal1(decimal cal1)
        {
            return cal1;
        }

        public decimal getCal2(decimal cal2)
        {
            return cal2;
        }
        public decimal getCal3(decimal cal3)
        {
            return cal3;
        }
    }
}
