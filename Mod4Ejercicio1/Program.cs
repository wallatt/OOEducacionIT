using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Ejercicio1 {
    internal class Program {
        static void Main(string[] args) {

            int[] vectorOrigen = { 1002, 104, 309, 500 };
            int[] vectorDestino;

            Console.WriteLine("Vector origen:");
            imprimirArray(vectorOrigen);

            vectorDestino = invertirArray(vectorOrigen);

            Console.WriteLine("Vector destino:");
            imprimirArray(vectorDestino);

            Console.ReadKey();
        }

        private static int[] invertirArray(int[] vectorOrigen) {
            int[] resultado = new int[vectorOrigen.Length]; 
            for (int i = 0; i < vectorOrigen.Length; i++) {
                resultado[i] = vectorOrigen[vectorOrigen.Length-1 - i];
            }
            return resultado;
        }

        static void imprimirArray(int[] vector) {
            for (int i = 0; i < vector.Length; i++) {
                Console.WriteLine($"{i}. {vector[i]}");
            }
        }
    }
}
