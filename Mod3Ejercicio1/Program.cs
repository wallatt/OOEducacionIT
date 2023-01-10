using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calcular dinero al cabo de un año con tasa de interes mensual de 2% con inversion inicial de 1000

            double monto = 1000.0;
            double interes = 1.02;

            for (int mes = 0; mes < 12; mes++) {
                monto *= interes;    
            }
            Console.WriteLine($"Al cabo de doce meses la ganacia es {Math.Round(monto,2)}");
            Console.ReadKey();
        }

    }
}
