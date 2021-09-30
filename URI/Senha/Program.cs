using System;

namespace senha
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = Convert.ToInt32(Console.ReadLine());
            

            while (senha != 2002)
            {
                 Console.WriteLine("Senha Invalida");
                 senha = Convert.ToInt32(Console.ReadLine());
            }
                
                 Console.WriteLine("Acesso Permitido");

        }
    }
}
