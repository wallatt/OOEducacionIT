using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar nota de usuario, informar si aprueba, recupera o promociona
            Console.WriteLine("Ingrese la nota del alumno");
            int nota = Int32.Parse(Console.ReadLine());


            if (nota >= 0 && nota <= 10)
            {
                if (nota < 4)
                {
                    Console.WriteLine("Recupera");
                }
                else if (nota < 7)
                {
                    Console.WriteLine("Aprueba");
                }
                else
                {
                    Console.WriteLine("Promociona");
                }
            }
            Console.ReadLine();
        }
    }
}
