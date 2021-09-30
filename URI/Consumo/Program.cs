using System;

namespace consumo
{
    class Program
    {
        static void Main(string[] args)
        {
                   int km = int.Parse(Console.ReadLine());
                   float litros = float.Parse(Console.ReadLine());  

                   float media = km/litros;

                   Console.WriteLine("{0:0.000 km/l}", media);                 
        }
    }
}
