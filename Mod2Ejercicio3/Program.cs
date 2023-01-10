using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dos notas de alumno");
            Console.WriteLine("Primera nota");
            int n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Segunda nota");
            int n2 = Int32.Parse(Console.ReadLine());

            if (n1 >= 4 && n2 >= 4) Console.WriteLine("esta aprobado");
            else
            {
                if (n1 < 4) Console.WriteLine("Debe recuperar el primer parcial");
                if (n2 < 4) Console.WriteLine("Debe recuperar el segundo parcial");
            }


            Console.ReadKey();


        }
    }
}
