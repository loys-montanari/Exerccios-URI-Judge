using System;
using System.Globalization;

namespace omaior
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]   valores = Console.ReadLine().Split(null);
            float a = float.Parse(valores[0], CultureInfo.InvariantCulture);
            float b = float.Parse(valores[1], CultureInfo.InvariantCulture);
            float c = float.Parse(valores[2], CultureInfo.InvariantCulture);

            float maior = (a + b + Math.Abs(a - b))/2;
            
            float maiorb = (maior + c + Math.Abs(maior - c))/2;

            Console.WriteLine("{0} eh o maior", maiorb);

        }
    }
}
