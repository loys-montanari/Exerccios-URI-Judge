using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Leia 3 valores inteiros e ordene-os em ordem crescente.
             * No final, mostre os valores em ordem crescente, uma linha em
             * branco e em seguida, os valores na sequência como foram lidos.
             * 
             * Entrada
             * A entrada contem três números inteiros.
             * 
             * Saída
             * Imprima a saída conforme foi especificado.*/

            string[] numeros = Console.ReadLine().Split(' ');

            int a = int.Parse(numeros[0]);
            int b = int.Parse(numeros[1]);
            int c = int.Parse(numeros[2]);

            int menor = 0, medio = 0, maior = 0;

            if (a < b && a < c && b < c)
            {
                menor = a;
                medio = b;
                maior = c;
            } else if (a < b && a < c && b > c)
            {
                menor = a;
                medio = c;
                maior = b;
            } else if (a > b && a < c && b < c)
            {
                menor = b;
                medio = a;
                maior = c;
            } else if (a > b && a > c && b < c)
            {
                menor = b;
                medio = c;
                maior = a;
            } else if (a > b && a > c && b > c)
            {
                menor = c;
                medio = b;
                maior = a;
            } else
            {
                menor = c;
                medio = a;
                maior = b;
            }

            Console.WriteLine(menor);
            Console.WriteLine(medio);
            Console.WriteLine(maior);
            Console.WriteLine("");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}