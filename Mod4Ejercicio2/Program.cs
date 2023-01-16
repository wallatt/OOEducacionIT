using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Ejercicio2 {
    internal class Program {
        static void Main(string[] args) {

            string nombre = "Juan";
            int edad = 21;
            Console.WriteLine("HOola");
            Console.WriteLine("Hola { 0}, tu edad es {1}", nombre, edad);

            int[] facturacionXMes = new int[12] { 50, 20, 30, 40, 50, 60, 34, 45, 34, 34, 23, 45 };
            int[] facturacionXTrimestre;

            facturacionXTrimestre = calcularTrimestres(facturacionXMes);

            imprimirArray(facturacionXTrimestre);
             
            Console.ReadKey();
        }

        private static int[] calcularTrimestres(int[] facturacionXMes) {
            int[] result = new int[facturacionXMes.Length/3];
            int contador = 0;
            int facturacion = 0;
            for (int i = 0; i < facturacionXMes.Length; i++) {
                result[i/3] += facturacionXMes[i];
            }
            return result;
        }
        static void imprimirArray(int[] vector) {
            for (int i = 0; i < vector.Length; i++) {
                Console.WriteLine($"{i}. {vector[i]}");
            }
        }
    }
}
