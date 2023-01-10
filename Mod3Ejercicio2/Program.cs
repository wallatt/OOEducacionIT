using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   Una persona desea invertir $1000 en un banco, el
            cual le otorga un 3 % de interés mensual.
            ¿En cuantos meses conseguirá $1200, si
            reinvierte cada mes todo su dinero?.*/

            double dinero = 1000;

            int mes = 1;

            double interes = 1.03;

            while(dinero < 1200)
            {
                dinero *= interes;
                mes++;
            }
            Console.WriteLine($"Al cabo de {mes} meses la inversion esta valuada en ${Math.Round(dinero,2)}");
            Console.ReadKey();
        }
    }
}
