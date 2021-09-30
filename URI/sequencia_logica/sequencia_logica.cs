using System;


    class sequencia_logica
    {
        static void Main(string[] args)
        {
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < (numero + 1); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("{0} {1} {2}", i, Math.Pow(i,2) + j, Math.Pow(i,3) + j);
                }
                    
            }
          
        }
    }