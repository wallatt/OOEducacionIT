using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dos numeros");
            Console.WriteLine("Primer numero");
            int n1 = Int32.Parse(Console.ReadLine());   
            
            Console.WriteLine("Segundo numero");
            int n2 = Int32.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine($"suma de n1 y n2 es {n1 + n2} \n y su resta es {n1 - n2}");
            }
            else{
                double a = Convert.ToDouble(n1) / Convert.ToDouble(n2);
                Console.WriteLine($"producto de n1 y n2 es {n1 * n2} \n y su division esa {a}");
            }
            Console.ReadKey();
        }
    }
}
