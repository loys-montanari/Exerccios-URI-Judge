using System;

namespace NomeFormulario
{
    class Program
    {
        static void Main(string[] args)
        {
                string nome = Console.ReadLine();

                int tamanho = nome.Length;

                if (tamanho <= 80)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
        }
    }
}
