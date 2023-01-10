using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar contrasena y manejar intentos fallidos
            Console.WriteLine("Ingrese nueva contraseña");
            string password = Console.ReadLine();
            Console.WriteLine("Inicie sesion con su contraseña");
            int intentos = 3;
            while(intentos > 0) {
                if(Console.ReadLine() == password)
                {
                    Console.WriteLine("Bienvenido");
                    break;
                }
                else
                {
                    intentos--;
                    if (intentos == 2) Console.WriteLine("Aun tiene dos chaces");
                    if (intentos == 1) Console.WriteLine("Atencion!! Ultima oportunidad");
                }
                
            }
            if (intentos == 0) Console.WriteLine("Tres veces fallido!");
                
            
            Console.ReadKey();

        }
    }
}
