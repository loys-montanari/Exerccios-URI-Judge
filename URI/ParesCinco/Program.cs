using System;

namespace parescinco
{
    class Program
    {
        static void Main(string[] args)
        {
             int a = Convert.ToInt32(Console.ReadLine());
             int b = Convert.ToInt32(Console.ReadLine());
             int c = Convert.ToInt32(Console.ReadLine());
             int d = Convert.ToInt32(Console.ReadLine());
             int e = Convert.ToInt32(Console.ReadLine());

             int count = 0;

             if(a % 2 == 0)
             {
                 count = count + 1;
             }
             if(b % 2 == 0)
             {
                 count = count + 1;
             }
             if(c % 2 == 0)
             {
                 count = count + 1;
             }
             if(d % 2 == 0)
             {
                 count = count + 1;
             }
             if(e % 2 == 0)
             {
                 count = count + 1;
             }
        
         Console.WriteLine(count + " valores pares");                                                                 
        }
    }
}
