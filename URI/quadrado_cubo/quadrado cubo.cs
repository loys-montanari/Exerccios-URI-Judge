using System;

namespace Quadrado_e_ao_cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i < (numero + 1); i++)
            {
                Console.WriteLine("{0} {1} {2}", i, Math.Pow(i,2), Math.Pow(i,3));
            }

            Console.ReadKey();
        }
    }
} 