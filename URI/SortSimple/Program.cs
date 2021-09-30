using System;
using System.Globalization;

namespace sortsimple
{
    class Program
    {
        static void Main(string[] args)
        {

            string[]   numeros = Console.ReadLine().Split(null);
            int a = int.Parse(numeros[0], CultureInfo.InvariantCulture);
            int b = int.Parse(numeros[1], CultureInfo.InvariantCulture);
            int c = int.Parse(numeros[2], CultureInfo.InvariantCulture);

            int medio = 0, menor = 0;
            int maior1 = (a + b + Math.Abs(a - b))/2;
            
            int maior = (maior1 + c + Math.Abs(maior1 - c))/2;      

            if ( maior == a)
            {
                medio = (b + c + Math.Abs(b - c))/2;
                menor = b+c-medio;

            }
            else if ( maior == b)
            {
                medio = (a + c + Math.Abs(a - c))/2;
                menor = a+c-medio;
            }
            else if ( maior == c)
            {
                medio = (a + b + Math.Abs(b - c))/2;
                menor = a+b-medio;
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
