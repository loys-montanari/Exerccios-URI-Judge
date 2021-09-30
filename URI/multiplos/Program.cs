using System;

namespace multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]   num = Console.ReadLine().Split(null);
            int a = int.Parse(num[0]);
            int b = int.Parse(num[1]);

            if (a%b == 0 || b%a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
