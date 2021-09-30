using System;

namespace pares
{
    class Program
    {
        static void Main(string[] args)
        {
             for (int i = 1; i < 101; i++)
             {
                 if (i%2 == 0)
                 { 
                     Console.WriteLine(i);
                 }
             }
        }
    }
}
