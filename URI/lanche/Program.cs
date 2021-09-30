using System;
using System.Globalization;

namespace lanche
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]   valores = Console.ReadLine().Split(null);
            float cod = float.Parse(valores[0], CultureInfo.InvariantCulture);
            float qtd = float.Parse(valores[1], CultureInfo.InvariantCulture);


            if (cod == 1)
            {
                Console.WriteLine("Total: R$ {0:0.00}", 4*qtd);
            }
            else if (cod == 2)
            {
                Console.WriteLine("Total: R$ {0:0.00}", 4.5*qtd);
            }  
            else if (cod == 3)
            {
                Console.WriteLine("Total: R$ {0:0.00}", 5*qtd);
            }   
            else if (cod == 4)
            {
                Console.WriteLine("Total: R$ {0:0.00}", 2*qtd);
            }   
            else if (cod == 5)
            {
                Console.WriteLine("Total: R$ {0:0.00}", 1.5*qtd);
            }                                                 
        }
    }
}
